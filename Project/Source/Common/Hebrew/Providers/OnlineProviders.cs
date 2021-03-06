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
/// <created> 2020-03 </created>
/// <edited> 2021-02 </edited>
using System;
using System.IO;
using System.Collections.Generic;
using Ordisoftware.Core;

namespace Ordisoftware.Hebrew
{

  /// <summary>
  /// Provide online providers list.
  /// </summary>
  partial class OnlineProviders : DataFile
  {

    /// <summary>
    /// Indicate display name tag.
    /// </summary>
    private const string TagName = "Name = ";

    /// <summary>
    /// Indicate url tag.
    /// </summary>
    private const string TagURL = "URL = ";

    /// <summary>
    /// Indicate items.
    /// </summary>
    public List<OnlineProviderItem> Items { get; }
     = new List<OnlineProviderItem>();

    /// <summary>
    /// Indicate the multilingual title of the list to create a folder
    /// </summary>
    public TranslationsDictionary Title { get; }
      = new TranslationsDictionary();

    /// <summary>
    /// Indicate if a separator must be inserted before the folder
    /// </summary>
    public bool SeparatorBeforeFolder { get; private set; }

    /// <summary>
    /// Constructor.
    /// </summary>
    public OnlineProviders(string filePath, bool showFileNotFound, bool configurable, DataFileFolder folder)
      : base(filePath, showFileNotFound, configurable, folder)
    {
    }

    /// <summary>
    /// Load or reload data from disk.
    /// </summary>
    protected override void DoReLoad(string filePath)
    {
      if ( filePath.IsNullOrEmpty() ) return;
      try
      {
        Title.Clear();
        Items.Clear();
        var lines = File.ReadAllLines(filePath);
        for ( int index = 0; index < lines.Length; index++ )
        {
          void showError() => DisplayManager.ShowError(SysTranslations.ErrorInFile.GetLang(filePath, index + 1, lines[index]));
          string line = lines[index].Trim();
          if ( line == string.Empty ) continue;
          if ( line.StartsWith(";") ) continue;
          if ( line.StartsWith("FOLDER-SEPARATOR") )
            SeparatorBeforeFolder = true;
          else
          if ( line.StartsWith("-") )
            Items.Add(new OnlineProviderItem("-"));
          else
          if ( line.StartsWith("Lang/") )
          {
            var parts = line.Split('/', '=');
            if ( parts.Length == 3 )
              Title.Add(Languages.Values[parts[1].Trim().ToLower()], parts[2].Trim());
            else
              showError();
          }
          else
          if ( line.StartsWith(TagName) )
          {
            string name = line.Substring(TagName.Length);
            if ( ++index >= lines.Length )
            {
              showError();
              break;
            }
            line = lines[index].Trim();
            if ( line.StartsWith(TagURL) )
              Items.Add(new OnlineProviderItem(name, line.Substring(TagURL.Length)));
            else
              showError();
          }
          else
            showError();
        }
      }
      catch ( Exception ex )
      {
        string msg = SysTranslations.LoadFileError.GetLang(filePath, ex.Message);
        DisplayManager.ShowError(msg);
      }
    }

  }

}
