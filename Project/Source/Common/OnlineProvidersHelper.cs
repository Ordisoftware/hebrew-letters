﻿/// <license>
/// This file is part of Ordisoftware Hebrew Calendar/Letters/Words.
/// Copyright 2012-2020 Olivier Rogier.
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
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Ordisoftware.Core;

namespace Ordisoftware.HebrewCommon
{

  // TODO refactor

  /// <summary>
  /// Provide online providers list helper to create menu items.
  /// </summary>
  static public class OnlineProvidersHelper
  {

    /// <summary>
    /// Fatcow table_edit.ico for configure menu item.
    /// </summary>
    private const string ImageEditString
      = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8"
      + "YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAI5SURBVDhPnZNfSFNhGMbPldu6qKCboogguii6CLzoKgqK"
      + "wisvuq27iCKIYhHo1mZqKhmZmRsKShJRhhShO/tX28ByEQVBzm2Ym5IWUZRN+kd/fr3fd+aaiV30wMP7"
      + "nu8873O+9zvvZ6xuDH1Y7jFxuE1sLhO7ZqAYF+dKp/SqzlBQD/8DVacNHO6AtTK8Bx5Wwcg+PIGXkNyr"
      + "uSAfmoIHu7Rc1VkGsi0F990JEUxSb07SFMzRYOY1y/NGc4K6wXGtt80b2F1DeiH9CbKfIfcNWgNp8hIV"
      + "y/PzZoYX37UcY76FeYP8F5j6CjMiaAuO8UqiYin/AZciWWZEm/aEyDdFFxpcGBylLZDicihNZyRDh0RF"
      + "nYczXImM409M4fLUMnknz6POxzxz36Zk8Fa+8k6+Miu5L5Lmo0RFXzSjY0FY465j+vUbGlpbCNaEeXLU"
      + "/8eg8BPmfoF0Qnc0jXSj2RXLIcdD8sRaZrMD1DW3E43FOO1yqhYqSwZd4VG6Iyl6743RF8/QG8vQk8jR"
      + "k3zPiHOj/OKd0L+B1IAH58lTVDQmimdQaxnIBjQV+uLZYiZjoYqTu+HWFvCvwHdgvV5f5g1bBo7iDspx"
      + "LW796+Hj62RwdljFXavoOLhJryuUBmmpUZ7r3w7TLfDcK4eykquHNhffWCiN8pqzwYJ6UDuxSTsVcmmM"
      + "M3Fu1u8neEOKUxe5fmQrxrmn2L33S5dJ1WkDwTZh5d9sPlZN0+EqxturrdNeTFX3T5SLl4Bh/AZO3qcQ"
      + "BCcQLQAAAABJRU5ErkJggg==";

    /// <summary>
    /// Indicate image of the configure menu item.
    /// </summary>
    static Image ImageConfigure;

    /// <summary>
    /// Static constructor.
    /// </summary>
    static OnlineProvidersHelper()
    {
      var bytes = Convert.FromBase64String(ImageEditString);
      using ( var stream = new MemoryStream(bytes) )
      {
        stream.Position = 0;
        ImageConfigure = Image.FromStream(stream);
      }
    }

    /// <summary>
    /// Create configure menu item.
    /// </summary>
    /// <param name="onClick"></param>
    /// <returns></returns>
    static ToolStripMenuItem CreateConfigureMenu(EventHandler onClick)
    {
      var item = new ToolStripMenuItem(Globals.Configure.GetLang(), ImageConfigure);
      item.ImageScaling = ToolStripItemImageScaling.None;
      item.Click += onClick;
      return item;
    }

    /// <summary>
    /// Crate a list of menu items.
    /// </summary>
    /// <param name="tsic"></param>
    /// <param name="items"></param>
    /// <param name="action"></param>
    /// <param name="reconstruct"></param>
    static private void SetItems(ToolStripItemCollection tsic,
                                 OnlineProviders items,
                                 bool allowEdit,
                                 EventHandler action,
                                 Action reconstruct)
    {
      string nameItems = NameOfFromStack(items, 3).Replace("Globals.", "");
      int index = 0;
      foreach ( var item in items.Items )
        tsic.Insert(index++, item.CreateMenuItem(action));
      if ( !allowEdit ) return;
      tsic.Insert(index++, new ToolStripSeparator());
      tsic.Insert(index++, CreateConfigureMenu((sender, e) =>
      {
        int countTotal = items.Items.Count;
        if ( !EditProvidersForm.Run(items, nameItems) ) return;
        for ( int count = 0; count < countTotal; count++ )
          tsic.RemoveAt(0);
        tsic.RemoveAt(0);
        tsic.RemoveAt(0);
        reconstruct();
      }));
    }

    /// <summary>
    /// Create submenu items for providers menu.
    /// </summary>
    static public void InitializeFromProviders(this ContextMenuStrip menuRoot,
                                               OnlineProviders items,
                                               bool configurable,
                                               EventHandler action)
    {
      SetItems(menuRoot.Items, items, configurable, action, 
               () => InitializeFromProviders(menuRoot, items, configurable, action));
    }

    /// <summary>
    /// Create submenu items for providers menu.
    /// </summary>
    static public void InitializeFromProviders(this ToolStripMenuItem menu,
                                               OnlineProviders items,
                                               bool configurable,
                                               EventHandler action)
    {
      SetItems(menu.DropDownItems, items, configurable, action, 
               () => InitializeFromProviders(menu, items, configurable, action));
    }

    /// <summary>
    /// Create submenu items for web links menu.
    /// </summary>
    static public void InitializeFromWebLinks(this ToolStripDropDownButton menuRoot, bool configurable)
    {
      menuRoot.DropDownItems.Clear();
      foreach ( var items in Globals.WebLinksProviders )
        if ( items.Items.Count > 0 )
        {
          // Folder
          string title = items.Title.GetLang();
          ToolStripDropDownItem menu;
          if ( title != "" )
          {
            if ( items.SeparatorBeforeFolder )
              menuRoot.DropDownItems.Add(new ToolStripSeparator());
            menu = new ToolStripMenuItem(title);
            menuRoot.DropDownItems.Add(menu);
            menu.ImageScaling = ToolStripItemImageScaling.None;
            menu.Image = OnlineProviderItem.FolderImage;
            menu.MouseUp += (sender, e) =>
            {
              if ( e.Button != MouseButtons.Right ) return;
              ( (ToolStripDropDownButton)menu.OwnerItem ).HideDropDown();
              if ( !DisplayManager.QueryYesNo(Globals.AskToOpenAllLinks.GetLang(menu.Text)) ) return;
              foreach ( ToolStripItem item in ( (ToolStripMenuItem)sender ).DropDownItems )
                if ( item.Tag != null )
                {
                  SystemHelper.OpenWebLink((string)item.Tag);
                  Thread.Sleep(2000);
                }
            };
          }
          else
            menu = menuRoot;
          // Items
          foreach ( var item in items.Items )
            menu.DropDownItems.Add(item.CreateMenuItem((sender, e) =>
            {
              string url = (string)( (ToolStripItem)sender ).Tag;
              SystemHelper.OpenWebLink(url);
            }));
        }
      // Edit list
      if ( !configurable ) return;
      menuRoot.DropDownItems.Add(new ToolStripSeparator());
      menuRoot.DropDownItems.Add(CreateConfigureMenu((sender, e) =>
      {
        if ( !EditProvidersForm.Run(Globals.WebLinksProviders, nameof(Globals.WebLinksProviders)) ) return;
        InitializeFromWebLinks(menuRoot, true);
      }));
    }

    /// <summary>
    /// https://stackoverflow.com/questions/72121/finding-the-variable-name-passed-to-a-function/21219225#21219225
    /// </summary>
    static private Dictionary<string, string> AlreadyAcessedVarNames = new Dictionary<string, string>();
    static private string NameOfFromStack(this object instance, int level = 1)
    {
      try
      {
        var frame = new StackTrace(true).GetFrame(level);
        string filename = frame.GetFileName();
        int lineNumber = frame.GetFileLineNumber();
        string id = filename + lineNumber;
        if ( AlreadyAcessedVarNames.ContainsKey(id) )
          return AlreadyAcessedVarNames[id];
        using ( var file = new StreamReader(filename) )
        {
          for ( int i = 0; i < lineNumber - 1; i++ )
            file.ReadLine();
          string line = file.ReadLine();
          string name = line.Split(new char[] { '(', ')' })[1].TrimEnd(' ', ',');
          AlreadyAcessedVarNames.Add(id, name);
          file.Close();
          return name;
        }
      }
      catch
      {
        return "Error getting instance variable name";
      }
    }

  }

}
