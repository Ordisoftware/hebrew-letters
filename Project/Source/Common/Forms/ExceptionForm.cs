/// <license>
/// This file is part of Ordisoftware Hebrew Calendar/Letters/Words.
/// Originally developped for Ordisoftware Core Library.
/// Copyright 2004-2019 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at 
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file, 
/// then You may include the notice in a location(such as a LICENSE file in a 
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2007-05 </created>
/// <edited> 2020-08 </edited>
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Printing;
//using System.Drawing;

namespace Ordisoftware.HebrewCommon
{

  /// <summary>
  /// Provide Exception visualisation.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.Form"/>
  internal partial class ExceptionForm : Form
  {

    /// <summary>
    /// The button stack text.
    /// </summary>
    private string ButtonStackText;

    /// <summary>
    /// Information describing the error.
    /// </summary>
    private ExceptionInfo ErrorInfo;

    /// <summary>
    /// Message describing the error.
    /// </summary>
    private List<string> ErrorMsg = new List<string>();

    /// <summary>
    /// Run the given einfo.
    /// </summary>
    static public void Run(ExceptionInfo einfo, bool isInner = false)
    {
      using ( var form = new ExceptionForm() )
      {
        form.printPreviewDialog.FindForm().WindowState = FormWindowState.Maximized;
        form.buttonViewLog.Visible = false; // SystemManager.Log.Active;
        form.buttonViewStack.Enabled = Debugger.UseStack;
        form.buttonViewInner.Enabled = einfo.InnerInfo != null;
        form.buttonTerminate.Enabled = Debugger.UserCanTerminate && !isInner;
        if ( isInner )
        {
          form.buttonPrint.Enabled = false;
          form.buttonSendMail.Enabled = false;
          form.buttonClose.Text = "OK";
        }
        form.textException.Text = einfo.TypeText;
        form.textMessage.Text = einfo.Message;
        form.labelInfo1.Text += einfo.Emitter + " " + Globals.AssemblyVersion;
        form.textStack.Text = /* "[Thread: " + einfo.ThreadName + "]" + Globals.NL2 + */ einfo.StackText;
        form.ErrorMsg.Add(form.textException.Text);
        form.ErrorMsg.Add(Globals.NL);
        form.ErrorMsg.Add(form.textMessage.Text);
        form.ErrorMsg.Add(Globals.NL);
        form.ErrorMsg.Add(form.textStack.Text);
        form.OriginalHeight = form.Height;
        form.ErrorInfo = einfo;
        form.ButtonStackText = form.buttonViewStack.Text;
        form.buttonViewStack.Text += " <<";
        if ( Debugger.AutoHideStack ) form.buttonViewStack_Click(form, null);
        if ( !Debugger.UseStack ) form.buttonViewStack_Click(form, null);
        form.BringToFront();
        form.ShowDialog();
      }
    }

    /// <summary>
    /// Default constructor.
    /// </summary>
    public ExceptionForm()
    {
      InitializeComponent();
      Icon = Globals.MainForm.Icon;
    }

    /// <summary>
    /// Height of the original.
    /// </summary>
    private int OriginalHeight;

    /// <summary>
    /// Event handler. Called by buttonViewStack for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void buttonViewStack_Click(object sender, EventArgs e)
    {
      if ( Height == OriginalHeight )
      {
        Height = textStack.Top + 35;
        buttonViewStack.Text = ButtonStackText + " >>";
      }
      else
      {
        Height = OriginalHeight;
        buttonViewStack.Text = ButtonStackText + " <<";
      }
    }

    /// <summary>
    /// Event handler. Called by buttonViewInner for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void buttonViewInner_Click(object sender, EventArgs e)
    {
      Run(ErrorInfo.InnerInfo, true);
    }

    /// <summary>
    /// Event handler. Called by buttonViewLog for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void buttonViewLog_Click(object sender, EventArgs e)
    {
      //Invoke(new Action<Logger, bool>((log, b) => LogForm.Run(log, b)), new object[] { SystemManager.Log, true });
    }

    /// <summary>
    /// Event handler. Called by buttonPrint for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void buttonPrint_Click(object sender, EventArgs e)
    {
      /*Hide();
      try
      {
        DialogResult res;
        if ( SystemManager.Process.IsControlled ) res = printPreviewDialog.ShowDialog();
        else res = printDialog.ShowDialog();
        res = printPreviewDialog.ShowDialog();
        if ( res == DialogResult.OK ) printDocument.Print();
      }
      finally
      {
        Show();
      }*/
    }

    /// <summary>
    /// Event handler. Called by printDocument for print page events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Print page event information.</param>
    private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
    {
      /*var font1 = new Font("Arial", 12, FontStyle.Bold | FontStyle.Underline);
      var font2 = new Font("Arial", 12, FontStyle.Regular);
      int x = 50;
      int y = 50;
      string msg = "Error report for application : " + HebrewCommon.Globals.AssemblyTitle;
      e.Graphics.DrawString(msg, font1, Brushes.Black, x, y);
      y = y + font1.Height * 3;
      foreach ( string s in ErrorMsg )
      {
        e.Graphics.DrawString(s, font2, Brushes.Black, x, y);
        y = y + (int)( font2.Height * 1.5 );
      }*/
    }

    /// <summary>
    /// Event handler. Called by buttonSendMail for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void buttonSendMail_Click(object sender, EventArgs e)
    {
      if ( ErrorInfo == null ) return;
      try
      {
        TopMost = false;
        string query = "&title=" + ErrorInfo.Instance.GetType().Name + " in " + Globals.AssemblyTitleWithVersion
                     + "&labels=type: bug"
                     + "&body=";
        string body = "## COMMENT" + Globals.NL2
                    + Localizer.GitHubIssueComment.GetLang();
        body += Globals.NL2
              + "## SYSTEM" + Globals.NL2
              + SystemHelper.OperatingSystem;
        body += Globals.NL
              + "Total Visible Memory: " + SystemHelper.TotalVisibleMemory + Globals.NL
              + "Free Physical Memory: " + SystemHelper.PhysicalMemoryFree;
        body += Globals.NL2
              + "## ERROR : " + ErrorInfo.Instance.GetType().Name + Globals.NL2
              + ErrorInfo.Message + Globals.NL2
              + "#### _STACK_" + Globals.NL2
              + ErrorInfo.StackText;
        ExceptionInfo inner = ErrorInfo.InnerInfo;
        while ( inner != null )
        {
          body += Globals.NL2
                + "## INNER : " + inner.Instance.GetType().Name + Globals.NL2
                + inner.Message + Globals.NL2
                + "#### _STACK_" + Globals.NL2
                + inner.StackText;
          inner = inner.InnerInfo;
        }
        query += System.Net.WebUtility.UrlEncode(body);
        if ( query.Length > 8000 )
          query = query.Substring(0, 8000);
        Shell.CreateGitHubIssue(query);
      }
      catch ( Exception ex )
      {
        DisplayManager.ShowError(ex.Message);
      }
      /*string email = SystemManager.User.UserMail;
      if ( email.IsNullOrEmpty() )
        if ( DisplayManager.QueryValue("User email", ref email) == InputValueResult.Cancelled)
          return;
      var files = FileTool.Exists(SystemManager.Log.Filename)
                  ? new string[] { SystemManager.Log.Filename }
                  : null;
      if ( Net.NetUtility.SendMail(email,
                                   SystemManager.Assembly.HelpMail,
                                   SystemManager.Assembly.MailSubject, 
                                   StringUtility.AsMultiline(_ErrorMsg), 
                                   false, files) )
        DisplayManager.Show("Message has been sent.");*/
    }

    /// <summary>
    /// Event handler. Called by buttonTerminate for click events.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    private void buttonTerminate_Click(object sender, EventArgs e)
    {
      //SystemManager.Abort();
      Environment.Exit(-1);
    }

  }

}