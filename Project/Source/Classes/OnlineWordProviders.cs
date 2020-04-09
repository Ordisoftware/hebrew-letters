﻿/// <license>
/// This file is part of Ordisoftware Hebrew Letters.
/// Copyright 2016-2020 Olivier Rogier.
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
/// <edited> 2020-04 </edited>
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.HebrewLetters
{

  /// <summary>
  /// Online word search provider item.
  /// </summary>
  public class OnlineWordProvider
  {
    public string Name { get; set; }
    public string URL { get; set; }
    public ToolStripMenuItem CreateMenuItem(EventHandler action, Image image = null)
    {
      var result = new ToolStripMenuItem(Name, image);
      result.Tag = URL;
      result.Click += action;
      return result;
    }
  }

  /// <summary>
  /// Online word search providers list.
  /// </summary>
  static public class OnlineWordProviders
  {

    /// <summary>
    /// Indicate items.
    /// </summary>
    static public List<OnlineWordProvider> Items
    {
      get;
      private set;
    }

    /// <summary>
    /// Static constructor.
    /// </summary>
    static OnlineWordProviders()
    {
      Items = new List<OnlineWordProvider>();
      try
      {
        var lines = File.ReadAllLines(Program.OnlineWordProvidersFileName);
        for ( int index = 0; index < lines.Length; index++ )
        {
          Action showError = () =>
          {
            DisplayManager.ShowError("Error in " + Program.OnlineWordProvidersFileName + ": " + Environment.NewLine +
                                     Environment.NewLine +
                                     "Line n° " + index + Environment.NewLine +
                                     Environment.NewLine +
                                     lines[index]);
          };
          var item = new OnlineWordProvider(); ;
          if ( lines[index].Trim() == "" )
            continue;
          if ( lines[index].StartsWith(";") )
            continue;
          if ( lines[index].StartsWith("-") )
          {
            item.Name = "-";
            Items.Add(item);
          }
          else
          if ( lines[index].StartsWith("Name") )
          {
            var parts = lines[index].Split(new string[] { " = " }, StringSplitOptions.None);
            if ( parts.Length == 2 )
            {
              item.Name = parts[1].Trim();
              index++;
              if ( index >= lines.Length )
                showError();
              if ( lines[index].StartsWith("URL") )
              {
                parts = lines[index].Split(new string[] { " = " }, StringSplitOptions.None);
                if ( parts.Length == 2 )
                {
                  item.URL = parts[1].Trim();
                  Items.Add(item);
                }
                else
                  showError();
              }
              else
                showError();
            }
            else
              showError();
          }
          else
            showError();
        }
      }
      catch ( Exception ex )
      {
        ex.Manage();
        return;
      }
    }

  }

}
