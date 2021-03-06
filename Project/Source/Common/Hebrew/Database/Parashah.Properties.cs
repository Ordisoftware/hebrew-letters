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
/// <created> 2021-02 </created>
/// <edited> 2021-06 </edited>
using System;
using System.Linq;
using SQLite;
using Ordisoftware.Core;
using System.ComponentModel;
using System.Collections.Generic;

namespace Ordisoftware.Hebrew
{

  public partial class Parashah
  {

    [PrimaryKey]
    public string ID { get; set; }

    public TorahBooks Book { get; set; }
    public int Number { get; set; }

    public string VerseBegin { get; set; }
    public string VerseEnd { get; set; }

    public string FullReferenceBegin => $"{(int)Book}.{VerseBegin}";

    public string Name { get; set; }
    public string Unicode { get; set; }
    public string Hebrew { get; set; }

    public string Translation { get; set; }
    public string Lettriq { get; set; }

    public Parashah GetLinked(List<Parashah> owner = null)
    {
      if ( !IsLinkedToNext ) return null;
      if ( owner != null ) return owner[owner.IndexOf(this) + 1];
      var list = ParashotFactory.All.ToList();
      return list[list.IndexOf(this) + 1];
    }

    public string Memo
    {
      get => _Memo;
      set
      {
        _Memo = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HasMemo"));
      }
    }
    private string _Memo;

    public bool HasMemo => !Memo.IsNullOrEmpty();

    public bool IsLinkedToNext { get; set; }

  }

}
