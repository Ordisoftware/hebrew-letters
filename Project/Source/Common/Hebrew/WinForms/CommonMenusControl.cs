﻿/// <license>
/// This file is part of Ordisoftware Hebrew Calendar/Letters/Words.
/// Copyright 2012-2021 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
/// If a copy of the MPL was not distributed with this file, You can obtain one at
/// https://mozilla.org/MPL/2.0/.
/// If it is not possible or desirable to put the notice in a particular file,
/// then You may include the notice in a location(such as a LICENSE file in a
/// relevant directory) where a recipient would be likely to look for such a notice.
/// You may add additional accurate notices of copyright ownership.
/// </license>
/// <created> 2016-04 </created>
/// <edited> 2020-12 </edited>
using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Ordisoftware.Core;
using Markdig;

namespace Ordisoftware.Hebrew
{

  public partial class CommonMenusControl : UserControl
  {

    public EventHandler AboutBoxHandler;

    public EventHandler WebCheckUpdateHandler;

    public CommonMenusControl()
    {
      InitializeComponent();
      MenuApplication.Text = Globals.AssemblyTitle;
      MenuApplication.Image = Globals.MainForm?.Icon.GetBySize(16, 16).ToBitmap();
      ActionSoftpedia.Tag = Globals.SoftpediaURL;
      ActionAlternativeTo.Tag = Globals.AlternativeToURL;
      bool b1 = !string.IsNullOrEmpty(Globals.SoftpediaURL);
      bool b2 = !string.IsNullOrEmpty(Globals.AlternativeToURL); ;
      ActionSoftpedia.Visible = b1;
      ActionAlternativeTo.Visible = b2;
      SeparatorOnlineArchive.Visible = b1 || b2;
      check(ActionHebrewCalendar);
      check(ActionHebrewLetters);
      check(ActionHebrewWords);
      void check(ToolStripMenuItem item)
      {
        if ( item.Text.Contains(Globals.AssemblyTitle) )
          MenuSoftware.DropDownItems.Remove(item);
      }
    }

    private void CommonMenusControl_Load(object sender, EventArgs e)
    {
    }

    private void ActionAbout_Click(object sender, EventArgs e)
    {
      AboutBoxHandler?.Invoke(this, EventArgs.Empty);
    }

    private void ActionHelp_Click(object sender, EventArgs e)
    {
      SystemManager.RunShell(Globals.HelpFilePath);
    }

    private void ActionCheckUpdate_Click(object sender, EventArgs e)
    {
      WebCheckUpdateHandler?.Invoke(this, EventArgs.Empty);
    }

    private void ActionReleaseNotes_Click(object sender, EventArgs e)
    {
      SystemManager.OpenApplicationReleaseNotes();
    }

    private void ActionAuthorHome_Click(object sender, EventArgs e)
    {
      SystemManager.OpenAuthorHome();
    }

    private void ActionApplicationHome_Click(object sender, EventArgs e)
    {
      SystemManager.OpenApplicationHome();
    }

    private void ActionContact_Click(object sender, EventArgs e)
    {
      SystemManager.OpenContactPage();
    }

    private void ActionGitHubRepo_Click(object sender, EventArgs e)
    {
      SystemManager.OpenGitHupRepo();
    }

    private void ActionSubmitBug_Click(object sender, EventArgs e)
    {
      SystemManager.CreateGitHubIssue("&labels=type: bug");
    }

    private void ActionSubmitFeature_Click(object sender, EventArgs e)
    {
      SystemManager.CreateGitHubIssue("&labels=type: feature");
    }

    private void ActionOpenWebsiteURL_Click(object sender, EventArgs e)
    {
      SystemManager.OpenWebLink((string)( (ToolStripItem)sender ).Tag);
    }

    private void ActionReadme_Click(object sender, EventArgs e)
    {
      var fileLines = Markdown.ToHtml(File.ReadAllText(Globals.ApplicationReadmeMDPath),
                                      new MarkdownPipelineBuilder().UseAdvancedExtensions().Build());
      string filePath = Path.Combine(Path.GetTempPath(), $"{Globals.ApplicationCode}-README.html");
      File.WriteAllText(filePath, fileLines, Encoding.UTF8);
      SystemManager.RunShell(filePath);
      var timer = new Timer();
      timer.Interval = 60000;
      timer.Tick += (_s, _e) =>
      {
        timer.Stop();
        try { File.Delete(filePath); }
        catch { }
      };
      timer.Start();
    }

  }

}