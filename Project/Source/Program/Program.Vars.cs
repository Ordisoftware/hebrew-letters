﻿/// <license>
/// This file is part of Ordisoftware Hebrew Letters.
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
/// <edited> 2021-02 </edited>
using System;
using System.IO;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.Hebrew.Letters
{

  /// <summary>
  /// Provide Program class.
  /// </summary>
  static partial class Program
  {

    static public readonly NullSafeOfStringDictionary<ImageExportTarget> ImageExportTargets
      = ExportHelper.CreateExportTargets<ImageExportTarget>().SetUnsupported(ImageExportTarget.GIF);

    /// <summary>
    /// Indicate file path of the letters meanings.
    /// </summary>
    static public string MeaningsFilePath
      => Path.Combine(Globals.DocumentsFolderPath, "Alphabet-{0}.txt");

    /// <summary>
    /// Indicate the grammar guide form.
    /// </summary>
    static public HTMLBrowserForm GrammarGuideForm
    {
      get
      {
        if ( _GrammarGuideForm == null )
          _GrammarGuideForm = new HTMLBrowserForm(HebrewTranslations.GrammarGuideTitle,
                                                  OnlineProviders.HebrewGrammarGuideFilePath,
                                                  nameof(Settings.GrammarGuideFormLocation),
                                                  nameof(Settings.GrammarGuideFormSize));
        return _GrammarGuideForm;
      }
    }
    static public HTMLBrowserForm _GrammarGuideForm;

    /// <summary>
    /// Indicate the method notice form.
    /// </summary>
    static public HTMLBrowserForm MethodNoticeForm
    {
      get
      {
        if ( _MethodGuideForm == null )
          _MethodGuideForm = new HTMLBrowserForm(HebrewTranslations.MethodNoticeTitle,
                                                 OnlineProviders.LettriqMethodNoticeFilePath,
                                                 nameof(Settings.MethodNoticeFormLocation),
                                                 nameof(Settings.MethodNoticeFormSize));
        return _MethodGuideForm;
      }
    }
    static public HTMLBrowserForm _MethodGuideForm;

    /// <summary>
    /// Indicate the command line argument for hebrew word used at startup.
    /// </summary>
    static public string StartupWordHebrew
    {
      get
      {
        if ( _StartupWordHebrew.IsNullOrEmpty() )
          try
          {
            string word = ApplicationCommandLine.Instance?.WordHebrew ?? string.Empty;
            if ( word.IsNullOrEmpty() )
              if ( SystemManager.CommandLineArguments != null && SystemManager.CommandLineArguments.Length == 1 )
                word = SystemManager.CommandLineArguments[0];
            word = word.Trim().RemoveDiacritics();
            word = HebrewAlphabet.ContainsUnicode(word) ? HebrewAlphabet.ConvertToHebrewFont(word) : word;
            _StartupWordHebrew = HebrewAlphabet.UnFinalAll(word);
            if ( _StartupWordUnicode.IsNullOrEmpty() )
              _StartupWordUnicode = HebrewAlphabet.ConvertToUnicode(_StartupWordHebrew);
          }
          catch ( Exception ex )
          {
            MessageBox.Show(ex.Message, Globals.AssemblyTitle);
          }
        return _StartupWordHebrew;
      }
    }
    static private string _StartupWordHebrew = string.Empty;

    /// <summary>
    /// Indicate the command line argument for unicode word used at startup.
    /// </summary>
    static public string StartupWordUnicode
    {
      get
      {
        if ( _StartupWordUnicode.IsNullOrEmpty() )
          try
          {
            string word = ApplicationCommandLine.Instance?.WordUnicode ?? string.Empty;
            _StartupWordUnicode = HebrewAlphabet.ContainsUnicode(word) ? word.Trim().RemoveDiacritics() : string.Empty;
            if ( _StartupWordHebrew.IsNullOrEmpty() )
              _StartupWordHebrew = HebrewAlphabet.ConvertToHebrewFont(_StartupWordUnicode);
          }
          catch ( Exception ex )
          {
            MessageBox.Show(ex.Message, Globals.AssemblyTitle);
          }
        return _StartupWordUnicode;
      }
    }
    static private string _StartupWordUnicode = string.Empty;

  }

}
