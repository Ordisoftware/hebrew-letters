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
/// <created> 2020-04 </created>
/// <edited> 2020-04 </edited>
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ordisoftware.HebrewCommon
{

  public delegate void InsertingTextEventHandler(object sender, ref string text);

  public enum TextBoxCaretAfterPaste
  {
    Start,
    End
  }

  public partial class UndoRedoTextBox : TextBox
  {

    private Stack<UndoRedoItem> UndoStack = new Stack<UndoRedoItem>();
    private Stack<UndoRedoItem> RedoStack = new Stack<UndoRedoItem>();
    private UndoRedoItem Previous = new UndoRedoItem();
    private bool SetTextMutex;

    public event InsertingTextEventHandler InsertingText;

    public TextBoxCaretAfterPaste CaretAfterPaste { get; set; } = TextBoxCaretAfterPaste.End;

    public override string Text
    {
      get { return base.Text; }
      set
      {
        if ( Text == value )
          return;
        if ( InsertingText != null )
          InsertingText(this, ref value);
        try
        {
          if ( !SetTextMutex )
          {
            SetTextMutex = true;
            Previous.Set(Text, SelectionStart);
            UndoStack.Push(Previous);
            if ( RedoStack.Count > 0 )
              RedoStack.Clear();
          }
          base.Text = value;
          switch ( CaretAfterPaste )
          {
            case TextBoxCaretAfterPaste.Start:
              SelectionStart = 0;
              break;
            case TextBoxCaretAfterPaste.End:
              SelectionStart = Text.Length;
              break;
          }
          SelectionLength = 0;
        }
        finally
        {
          SetTextMutex = false;
        }
      }
    }

    public override string SelectedText
    {
      get { return base.SelectedText; }
      set
      {
        if ( SelectedText == value )
          return;
        if ( InsertingText != null )
          InsertingText(this, ref value);
        try
        {
          if ( !SetTextMutex )
          {
            SetTextMutex = true;
            Previous.Set(Text, SelectionStart);
            UndoStack.Push(Previous);
            if ( RedoStack.Count > 0 )
              RedoStack.Clear();
          }
          int selectionStart = SelectionStart;
          base.SelectedText = value;
          switch ( CaretAfterPaste )
          {
            case TextBoxCaretAfterPaste.Start:
              SelectionStart = selectionStart;
              break;
            case TextBoxCaretAfterPaste.End:
              SelectionStart = selectionStart + value.Length;
              break;
          }
        }
        finally
        {
          SetTextMutex = false;
        }
      }
    }

    public UndoRedoTextBox()
    {
      InitializeComponent();
      ActionUndo.Click += ActionUndo_Click;
      ActionRedo.Click += ActionRedo_Click;
      ActionCopy.Click += ActionCopy_Click;
      ActionCut.Click += ActionCut_Click;
      ActionPaste.Click += ActionPaste_Click;
    }

    private void ContextMenuEdit_Opened(object sender, EventArgs e)
    {
      ActionUndo.Enabled = UndoStack.Count != 0;
      ActionRedo.Enabled = RedoStack.Count != 0;
      ActionCopy.Enabled = SelectedText != "";
      ActionCut.Enabled = ActionCopy.Enabled;
      ActionPaste.Enabled = Clipboard.GetText() != "";
    }

    private void TextChangedEvent(object sender, EventArgs e)
    {
      if ( SetTextMutex ) return;
      UndoStack.Push(Previous);
      RedoStack.Clear();
    }

    private void KeyPressEvent(object sender, KeyPressEventArgs e)
    {
      if ( e.KeyChar == '\u0018' ) // Ctrl+X
        ActionCut.PerformClick();
      else
      if ( e.KeyChar == '\u0003' ) // Ctrl+C
        ActionCopy.PerformClick();
      else
      if ( e.KeyChar == '\u0016' ) // Ctrl+V
        ActionPaste.PerformClick();
      else
      if ( e.KeyChar == '\b' && SelectionStart > 0 ) // Back Space
      {
        var pos = SelectionStart;
        Text = Text.Remove(SelectionStart - 1, 1);
        SelectionStart = pos - 1;
      }
      else
        return;
      e.Handled = true;
    }

    private void KeyDownEvent(object sender, KeyEventArgs e)
    {
      Func<bool, Keys, Action, bool> check = (condition, key, action) =>
      {
        if ( !condition || e.KeyCode != key ) return false;
        e.SuppressKeyPress = true;
        if ( action != null ) action();
        return true;
      };
      if ( !check(e.Control, Keys.A, SelectAll) )
        if ( !check(e.Control, Keys.Z, ActionUndo.PerformClick) )
          if ( !check(e.Control, Keys.Y, ActionRedo.PerformClick) )
            if ( !check(e.Control, Keys.Insert, ActionCopy.PerformClick) )
              if ( !check(e.Shift, Keys.Delete, ActionCut.PerformClick) )
                if ( !check(e.Shift, Keys.Insert, ActionPaste.PerformClick) )
                  if ( !check(e.Control, Keys.Delete, null) )
                    Previous.Set(Text, SelectionStart);
    }

    private void ActionCopy_Click(object sender, EventArgs e)
    {
      if ( SelectedText == "" ) return;
      Clipboard.SetText(SelectedText);
    }

    private void ActionCut_Click(object sender, EventArgs e)
    {
      if ( SelectedText == "" ) return;
      Clipboard.SetText(SelectedText);
      int selectionStart = SelectionStart;
      Text = Text.Remove(selectionStart, SelectionLength);
      SelectionStart = selectionStart;
    }

    private void ActionPaste_Click(object sender, EventArgs e)
    {
      SelectedText = Clipboard.GetText();
    }

    private void ActionUndo_Click(object sender, EventArgs e)
    {
      if ( UndoStack.Count == 0 ) return;
      try
      {
        SetTextMutex = true;
        Previous.Set(Text, SelectionStart);
        RedoStack.Push(new UndoRedoItem().Set(Text, SelectionStart));
        var item = UndoStack.Pop();
        Text = item.Text;
        SelectionStart = item.SelectionStart;
      }
      finally
      {
        SetTextMutex = false;
      }
    }

    private void ActionRedo_Click(object sender, EventArgs e)
    {
      if ( RedoStack.Count == 0 ) return;
      try
      {
        SetTextMutex = true;
        UndoStack.Push(new UndoRedoItem().Set(Text, SelectionStart));
        var item = RedoStack.Pop();
        Text = item.Text;
        SelectionStart = item.SelectionStart;
        Previous.Set(Text, SelectionStart);
      }
      finally
      {
        SetTextMutex = false;
      }
    }

  }

  public struct UndoRedoItem
  {
    public string Text;
    public int SelectionStart;
    public UndoRedoItem Set(string text, int selectionStart)
    {
      Text = text;
      SelectionStart = selectionStart;
      return this;
    }
  }

}