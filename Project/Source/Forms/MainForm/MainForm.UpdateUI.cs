﻿/// <license>
/// This file is part of Ordisoftware Hebrew Letters.
/// Copyright 2016-2021 Olivier Rogier.
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
/// <edited> 2021-04 </edited>
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ordisoftware.Hebrew.Letters
{

  /// <summary>
  /// The application's main form.
  /// </summary>
  /// <seealso cref="T:System.Windows.Forms.Form"/>
  partial class MainForm
  {

    private bool DoScreenPositionMutex;

    /// <summary>
    /// Center the form to the screen.
    /// </summary>
    public new void CenterToScreen()
    {
      base.CenterToScreen();
    }

    /// <summary>
    /// Execute the screen location operation.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    protected void DoScreenPosition(object sender, EventArgs e)
    {
      if ( DoScreenPositionMutex ) return;
      try
      {
        DoScreenPositionMutex = true;
        int left = SystemInformation.WorkingArea.Left;
        int top = SystemInformation.WorkingArea.Top;
        int width = SystemInformation.WorkingArea.Width;
        int height = SystemInformation.WorkingArea.Height;
        if ( sender is ToolStripMenuItem )
        {
          var value = sender as ToolStripMenuItem;
          var list = ( (ToolStripMenuItem)value.OwnerItem ).DropDownItems;
          foreach ( ToolStripMenuItem item in list )
            item.Checked = item == value;
        }
        if ( EditScreenNone.Checked )
          return;
        if ( EditScreenTopLeft.Checked )
          Location = new Point(left, top);
        else
        if ( EditScreenTopRight.Checked )
          Location = new Point(left + width - Width, top);
        else
        if ( EditScreenBottomLeft.Checked )
          Location = new Point(left, top + height - Height);
        else
        if ( EditScreenBottomRight.Checked )
          Location = new Point(left + width - Width, top + height - Height);
        else
        if ( EditScreenCenter.Checked )
          CenterToScreen();
        EditScreenNone.Checked = false;
      }
      finally
      {
        DoScreenPositionMutex = false;
      }
    }

    /// <summary>
    /// Enable double-buffering.
    /// </summary>
    protected override CreateParams CreateParams
    {
      get
      {
        var cp = base.CreateParams;
        if ( Settings.WindowsDoubleBufferingEnabled )
        {
          cp.ExStyle |= 0x02000000; // + WS_EX_COMPOSITED
          //cp.Style &= ~0x02000000;  // - WS_CLIPCHILDREN
        }
        return cp;
      }
    }

  }

}
