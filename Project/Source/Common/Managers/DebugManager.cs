/// <license>
/// This file is part of Ordisoftware Hebrew Calendar/Letters/Words.
/// Originally developped for Ordisoftware Core Library.
/// Copyright 2004-2020 Olivier Rogier.
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
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ordisoftware.HebrewCommon
{

  /// <summary>
  /// Provide exception helper.
  /// </summary>
  /// <remarks> Using enter-Leave system :
  ///                                                           
  /// void Function()                                          
  /// {                                                        
  ///   try                                                    
  ///   {                                                      
  ///     DebugManager.Enter();                                     
  ///     DoSomething();                                                  
  ///   }                                                      
  ///   finally                                    
  ///   {                                                      
  ///     DebugManager.Leave();                                     
  ///   }                                                      
  /// }                                                          
  /// 
  /// void Function()                                          
  /// {                                                        
  ///   try                                                    
  ///   {                                                      
  ///     DebugManager.Enter();                                     
  ///     DoSomething();                                                  
  ///     DebugManager.Leave();                                     
  ///   }                                                      
  ///   catch (Exception ex)                                    
  ///   {                                                      
  ///     e.Manage(this, ex, false); // The Leave() will be automatically called
  ///   }                                                      
  /// }                                                          
  /// 
  /// </remarks>
  static public partial class DebugManager
  {

    /// <summary>
    /// Indicate before Exception event.
    /// </summary>
    static public event BeforeShowExceptionEventHandler BeforeShowException;

    /// <summary>
    /// Indicate after Exception event.
    /// </summary>
    static public event AfterShowExceptionEventHandler AfterShowException;

    /// <summary>
    /// Indicate Exception show alternative handler.
    /// </summary>
    static public event SubstitureShowExceptionEventHandler SubstituteShowException;

    /// <summary>
    /// Indicate if stack infos are used.
    /// </summary>
    static public bool UseStack { get; set; } = true;

    /// <summary>
    /// Indicate if only the program stack is used.
    /// </summary>
    static public bool StackOnlyProgram { get; set; } = true;

    /// <summary>
    /// Indicate if stack in specialized form is hidded by default.
    /// </summary>
    static public bool AutoHideStack { get; set; } = false;

    /// <summary>
    /// Indicate if Exception form show a terminate button.
    /// </summary>
    static public bool UserCanTerminate { get; set; } = true;

    /// <summary>
    /// Indicate if a specialized form is used to show Exception.
    /// </summary>
    static public ShowExceptionMode DeaultShowExceptionMode { get; set; }
      = ShowExceptionMode.Advanced;

    /// <summary>
    /// Indicate the trace listener.
    /// </summary>
    static public Listener TraceListener { get; private set; }

    /// <summary>
    /// Indicate if the debug manager is enabled or not.
    /// </summary>
    static public bool Enabled
    {
      get { return _Enabled; }
      set
      {
        if ( _Enabled == value ) return;
        if ( value )
        {
          AppDomain.CurrentDomain.UnhandledException += OnAppDomainException;
          Application.ThreadException += OnThreadException;
          Application.ApplicationExit += Stop;
        }
        else
        {
          AppDomain.CurrentDomain.UnhandledException -= OnAppDomainException;
          Application.ThreadException -= OnThreadException;
          Application.ApplicationExit -= Stop;
        }
        if ( value )
        {
          _Enabled = true;
          TraceListener = new Listener(
            Globals.TraceFolderPath,
            Globals.TraceFileCode,
            Globals.TraceFileExtension,
            Globals.TraceFileMode,
            Globals.TraceFileKeepCount,
            TraceFileChanged);
          System.Diagnostics.Trace.Listeners.Add(TraceListener);
          System.Diagnostics.Trace.AutoFlush = true;
          TraceListener.AutoFlush = true;
          WriteHeader();
        }
        else
        {
          WriteFooter();
          System.Diagnostics.Trace.Listeners.Remove(TraceListener);
          TraceListener.Dispose();
          TraceListener = null;
          _Enabled = false;
          TraceForm.Hide();
          TraceForm.TextBox.Clear();
        }
      }
    }

    /// <summary>
    /// Indicate if the debug manager is enabled or not.
    /// </summary>
    static private bool _Enabled = false;

    /// <summary>
    /// Start the debug manager.
    /// </summary>
    static public void Start(object sender = null, EventArgs e = null)
    {
      Enabled = true;
    }

    /// <summary>
    /// Stops the debug manager.
    /// </summary>
    static public void Stop(object sender = null, EventArgs e = null)
    {
      Enabled = false;
    }

    /// <summary>
    /// Manage unhandled domain exception.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="args">Event information to send to registered event handlers.</param>
    static private void OnAppDomainException(object sender, UnhandledExceptionEventArgs args)
    {
      if ( args.ExceptionObject == null ) return;
      Handle(sender, (Exception)args.ExceptionObject);
    }

    /// <summary>
    /// Manage unhandled thread exception.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="args">Event information to send to registered event handlers.</param>
    static private void OnThreadException(object sender, ThreadExceptionEventArgs args)
    {
      if ( args.Exception == null ) return;
      Handle(sender, args.Exception);
    }

    /// <summary>
    /// Handle an axception.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="ex">The ex.</param>
    static private void Handle(object sender, Exception ex)
    {
      if ( ex is AbortException ) return;
      Process(sender, ex);
    }

    /// <summary>
    /// Manage an axception.
    /// </summary>
    /// <param name="ex">The Exception to act on.</param>
    static public void Manage(this Exception ex)
    {
      Manage(ex, null, DeaultShowExceptionMode);
    }

    /// <summary>
    /// Manage an axception.
    /// </summary>
    /// <param name="ex">The Exception to act on.</param>
    /// <param name="show">The show mode.</param>
    static public void Manage(this Exception ex, ShowExceptionMode show)
    {
      Manage(ex, null, show);
    }

    /// <summary>
    /// Manage an axception.
    /// </summary>
    /// <param name="ex">The Exception to act on.</param>
    /// <param name="sender">Source of the event.</param>
    static public void Manage(this Exception ex, object sender)
    {
      Manage(ex, sender, DeaultShowExceptionMode);
    }

    /// <summary>
    /// Manage an axception.
    /// </summary>
    /// <param name="ex">The Exception to act on.</param>
    /// <param name="sender">Source of the event.</param>
    /// <param name="show">The show mode.</param>
    static public void Manage(this Exception ex, object sender, ShowExceptionMode show)
    {
      if ( !( ex is AbortException ) )
      {
        StackSkip++;
        Process(sender, ex, show);
        LeaveInternal();
      }
      LeaveInternal();
    }

    /// <summary>
    /// Process an exception.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="ex">The ex.</param>
    static private void Process(object sender, Exception ex)
    {
      Process(sender, ex, DeaultShowExceptionMode);
    }

    /// <summary>
    /// Process an exception.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="ex">The ex.</param>
    /// <param name="show">The show mode.</param>
    static private void Process(object sender, Exception ex, ShowExceptionMode show)
    {
      bool process = true;
      var einfo = new ExceptionInfo(sender, ex);
      if ( !_Enabled )
      {
        ShowSimple(einfo);
        return;
      }
      try
      {
        BeforeShowException?.Invoke(sender, einfo, ref process);
      }
      catch ( Exception err )
      {
        if ( show != ShowExceptionMode.None )
          DisplayManager.ShowError("Error on BeforeShowException :" + Globals.NL2 + err.Message);
      }
      if ( process )
      {
        Trace(TraceEvent.Exception, einfo.FullText);
        switch ( show )
        {
          case ShowExceptionMode.None:
            break;
          case ShowExceptionMode.Simple:
            ShowSimple(einfo);
            break;
          case ShowExceptionMode.Advanced:
            ShowAdvanced(einfo);
            break;
          default:
            throw new NotImplementedExceptionEx(show.ToStringFull());
        }
      }
      try
      {
        AfterShowException?.Invoke(sender, einfo, process);
      }
      catch ( Exception err )
      {
        if ( show != ShowExceptionMode.None )
          DisplayManager.ShowError("Error on AfterShowException :" + Globals.NL2 + err.Message);
      }
    }

    /// <summary>
    /// Show an exception with the exception form else a message box.
    /// </summary>
    /// <param name="einfo">The exception information.</param>
    static private void ShowAdvanced(ExceptionInfo einfo)
    {
      if ( einfo.Instance is AbortException ) return;
      try
      {
        if ( SubstituteShowException != null )
          SubstituteShowException.Invoke(einfo.Sender, einfo);
        else
        if ( !SystemManager.TryCatch(() => ExceptionForm.Run(einfo)) )
          ShowSimple(einfo);
      }
      catch ( Exception ex )
      {
        ShowCrash(ex, einfo);
      }
    }

    /// <summary>
    /// Show an sxception with a message box.
    /// </summary>
    /// <param name="einfo">The exception information.</param>
    static private void ShowSimple(ExceptionInfo einfo)
    {
      if ( einfo.Instance is AbortException ) return;
      try
      {
        string message = Localizer.UnhandledException.GetLang(
          einfo.Emitter,
          einfo.ModuleName,
          einfo.Instance.ToStringReadableFull());
        if ( UserCanTerminate )
          message += Globals.NL2 + Localizer.AskToContinueOrTerminate.GetLang();
        var goal = UserCanTerminate ? MessageBoxButtons.YesNo : MessageBoxButtons.OK;
        if ( DisplayManager.Show(message, goal, MessageBoxIcon.Error) == DialogResult.No )
          SystemManager.Terminate();
      }
      catch ( Exception ex )
      {
        ShowCrash(ex, einfo);
      }
    }

    /// <summary>
    /// Show a message when an error occurs on showing an exception.
    /// </summary>
    /// <param name="ex">The exception.</param>
    /// <param name="einfo">The exception information.</param>
    static private void ShowCrash(Exception ex, ExceptionInfo einfo)
    {
      try
      {
        string message = "Error on displaying Exception :" + Globals.NL2 +
                         ( einfo?.Instance?.Message ?? "null" ) + Globals.NL2 +
                         "(" + ex.Message + ")";
        DisplayManager.ShowError(message);
      }
      catch ( Exception err )
      {
        MessageBox.Show("DebugManager crash :" + Globals.NL2 + err.Message);
        SystemManager.Terminate();
      }
    }

    /// <summary>
    /// Get a full formatted text of an exeption including inners.
    /// </summary>
    /// <returns>
    /// ex as a string.
    /// </returns>
    /// <param name="ex">The exception to act on.</param>
    static public string ToStringFull(this Exception ex, object sender = null)
    {
      return ex.Parse(sender, einfo => einfo.FullText);
    }

    /// <summary>
    /// Get a readable formatted text of an exeption including inners.
    /// </summary>
    /// <returns>
    /// ex as a string.
    /// </returns>
    /// <param name="ex">The exception to act on.</param>
    static public string ToStringReadableFull(this Exception ex, object sender = null)
    {
      return ex.Parse(sender, einfo => einfo.ReadableText);
    }

    /// <summary>
    /// Parse an exception and all inners.
    /// </summary>
    /// <returns>
    /// A string.
    /// </returns>
    /// <param name="ex">The exception to act on.</param>
    /// <param name="getText">The gettext iteration.</param>
    static private string Parse(this Exception ex, object sender, Func<ExceptionInfo, string> getText)
    {
      var einfo = new ExceptionInfo(sender, ex);
      var list = new List<string> { getText(einfo) };
      einfo = einfo.InnerInfo;
      while ( einfo != null )
      {
        list.Add("[Inner] " + getText(einfo));
        einfo = einfo.InnerInfo;
      }
      return list.Join(Globals.NL2);
    }

  }

}