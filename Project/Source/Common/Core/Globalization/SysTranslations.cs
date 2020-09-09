﻿/// <license>
/// This file is part of Ordisoftware Core Library.
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
/// <created> 2016-04 </created>
/// <edited> 2020-09 </edited>
using System;

namespace Ordisoftware.Core
{

  public class TranslationsDictionary : NullSafeOfStringDictionary<Language>
  {
  }

  /// <summary>
  /// Provide localization helper.
  /// </summary>
  static public partial class SysTranslations
  {

    static public TranslationsDictionary AskToContinue
    {
      get
      {
        if ( _AskToContinue == null)
          _AskToContinue = new TranslationsDictionary
          {
            [Language.EN] = "Do you want to continue?",
            [Language.FR] = "Voulez-vous continuer ?"
          };
        return _AskToContinue;
      }
    }
    static public TranslationsDictionary _AskToContinue;

    static public readonly TranslationsDictionary NotImplemented
      = new TranslationsDictionary
      {
        [Language.EN] = "Not implemented: {0}",
        [Language.FR] = "Non implémenté : {0}",
      };

    static public readonly TranslationsDictionary NotYetAvailable
      = new TranslationsDictionary
      {
        [Language.EN] = "Not yet available.",
        [Language.FR] = "Pas encore disponible."
      };

    static public readonly TranslationsDictionary TermNotFound
      = new TranslationsDictionary
      {
        [Language.EN] = "Term \"{0}\" not found.",
        [Language.FR] = "Terme \"{0}\" non trouvé."
      };

    static public readonly TranslationsDictionary AskToOpenAllLinks
      = new TranslationsDictionary
      {
        [Language.EN] = "Do you want to open all \"{0}\" links?",
        [Language.FR] = "Voulez-vous ouvrir tous les liens de \"{0}\" ?"
      };

    static public readonly TranslationsDictionary ScreenshotDone
      = new TranslationsDictionary
      {
        [Language.EN] = "The window has been copied to the clipboard.",
        [Language.FR] = "La fenêtre a été copié dans le presse-papier."
      };

    static public readonly TranslationsDictionary AskToEmptyHistory
      = new TranslationsDictionary
      {
        [Language.EN] = "Empty history?",
        [Language.FR] = "Vider l'historique ?"
      };

    static public readonly TranslationsDictionary AskToEmptyBookmarks
      = new TranslationsDictionary
      {
        [Language.EN] = "Empty bookmarks?",
        [Language.FR] = "Vider les signets?"
      };

    static public readonly TranslationsDictionary AskToDeleteBookmark
      = new TranslationsDictionary
      {
        [Language.EN] = "Erase the bookmark?",
        [Language.FR] = "Effacer le signet ?"
      };

    static public readonly TranslationsDictionary AskToDeleteBookmarkAll
      = new TranslationsDictionary
      {
        [Language.EN] = "Erase all bookmarks?",
        [Language.FR] = "Effacer tous les signets ?"
      };

    static public readonly TranslationsDictionary AskToReplaceBookmark
      = new TranslationsDictionary
      {
        [Language.EN] = "Replace bookmark?",
        [Language.FR] = "Remplacer le signet ?"
      };

    static public readonly TranslationsDictionary NullSlot
      = new TranslationsDictionary
      {
        [Language.EN] = "<null>",
        [Language.FR] = "<null>"
      };

    static public readonly TranslationsDictionary UndefinedSlot
      = new TranslationsDictionary
      {
        [Language.EN] = "<not defined>",
        [Language.FR] = "<non définit>"
      };

    static public readonly TranslationsDictionary EmptySLot
      = new TranslationsDictionary
      {
        [Language.EN] = "<empty>",
        [Language.FR] = "<empty>"
      };

    static public readonly TranslationsDictionary ErrorSlot
      = new TranslationsDictionary
      {
        [Language.EN] = "<error>",
        [Language.FR] = "<erreur>"
      };

    static public NullSafeDictionary<Language, NullSafeStringList> MillisecondsFormat
      = new NullSafeDictionary<Language, NullSafeStringList>
      {
        [Language.EN] = new NullSafeStringList
          {
            "{4} ms",
            "{3} s",
            "{2} m {3} s",
            "{1} h {2} m {3} s",
            "{0} d {1} h {2} m {3} s",
          },
        [Language.FR] =
          new NullSafeStringList
          {
            "{4} ms",
            "{3} s",
            "{2} m {3} s",
            "{1} h {2} m {3} s",
            "{0} j {1} h {2} m {3} s",
          }
      };

  }

}