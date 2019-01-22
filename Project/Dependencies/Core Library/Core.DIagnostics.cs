﻿/// <license>
/// This file is part of Ordisoftware Core Library.
/// Copyright 2004-2019 Olivier Rogier.
/// See www.ordisoftware.com for more information.
/// Project is registered at Depotnumerique.com (Agence des Depots Numeriques).
/// This program is free software: you can redistribute it and/or modify it under the terms of
/// the GNU Lesser General Public License (LGPL v3) as published by the Free Software Foundation,
/// either version 3 of the License, or (at your option) any later version.
/// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
/// without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
/// See the GNU Lesser General Public License for more details.
/// You should have received a copy of the GNU General Public License along with this program.
/// If not, see www.gnu.org/licenses website.
/// </license>
/// <created> 2007-05 </created>
/// <edited> 2016-04 </edited>
using System;

namespace Ordisoftware.Core.Diagnostics
{

  static public class Debugger
  {

    static public void ManageException(Exception except)
    {
      ManageException(null, except, true);
    }

    static public void ManageException(object sender, Exception except)
    {
      ManageException(sender, except, true);
    }

    static public void ManageException(object sender, Exception except, bool doshow)
    {
      string message = except.Message;
      var exceptInner = except.InnerException;
      while ( exceptInner != null )
      {
        message += Environment.NewLine + Environment.NewLine + except.InnerException;
        exceptInner = exceptInner.InnerException;
      }
      if ( doshow ) DisplayManager.Show(message);
    }

  }

}
