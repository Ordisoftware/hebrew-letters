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
/// <created> 2016-04 </created>
/// <edited> 2020-08 </edited>
using System;
using System.Collections.Generic;

namespace Ordisoftware.HebrewCommon
{

  /// <summary>
  /// Provide global variables.
  /// </summary>
  static public partial class Globals
  {

    static public readonly Dictionary<string, string> DoYouWantToContinue
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Do you want to continue?" },
        { Localizer.FR, "Voulez-vous continuer ?" }
      };

    static public readonly Dictionary<string, string> GrammarGuideTitle
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Grammar guide" },
        { Localizer.FR, "Guide de grammaire" }
      };

    static public readonly Dictionary<string, string> MethodNoticeTitle
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Lettriq analysis method notice" },
        { Localizer.FR, "Notice de la méthode d'analyse lettrique" }
      };

    static public readonly Dictionary<string, string> GitHubIssueComment
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "> Describe here what you did, what you expected and what happened." },
        { Localizer.FR, "> Décrivez ici ce que vous avez fait, ce que vous attendiez et ce qui c'est passé." }
      };

    static public readonly Dictionary<string, string> AboutBoxTitle
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "About {0}" },
        { Localizer.FR, "À propos de {0}" }
      };

    static public readonly Dictionary<string, string> AboutBoxVersion
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Version {0}" },
        { Localizer.FR, "Version {0}" }
      };

    static public readonly Dictionary<string, string> NotYetAvailable
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Not yet available." },
        { Localizer.FR, "Pas encore disponible." }
      };

    static public readonly Dictionary<string, string> UpgradeResetRequired
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "An upgrade of the settings is required and they will be reseted to default values." },
        { Localizer.FR, "Une mise à jour des paramètres est requise et ils vont être réinialisés à leurs valeurs par défaut." }
      };

    static public readonly Dictionary<string, string> AskToExitApplication
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Exit application?" },
        { Localizer.FR, "Quitter l'application ?" }
      };

    static public readonly Dictionary<string, string> NoNewVersionAvailable
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "There is no new version available." },
        { Localizer.FR, "Il n'y a pas de nouvelle version de disponible." }
      };

    static public readonly Dictionary<string, string> NewVersionAvailable
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "A newer version is available : {0}" },
        { Localizer.FR, "Une nouvelle version est disponible : {0}" }
      };

    static public readonly Dictionary<string, string> AskToDownloadNewVersion
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Do you want to open the download page?" },
        { Localizer.FR, "Voulez-vous ouvrir la page de téléchargement ?" }
      };

    static public readonly Dictionary<string, string> AskToCheckParametersAfterDatabaseUpgraded
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Database upgraded." + Localizer.NL + Localizer.NL +
                        "Do you want check the parameters?" },
        { Localizer.FR, "La base de données a été mise à jour." + Localizer.NL + Localizer.NL +
                        "Voulez-vous vérifier les paramètres ?" }
      };

    static public readonly Dictionary<string, string> AskToOptimizeDatabase
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Optimization process will close and reopen the database." + Localizer.NL + Localizer.NL +
                        DoYouWantToContinue[Localizer.EN] },
        { Localizer.FR, "Le processus d'optimisation va fermer et rouvrir la base de données." + Localizer.NL + Localizer.NL +
                        DoYouWantToContinue[Localizer.FR] }
      };

    static public readonly Dictionary<string, string> AskToRestoreWindowPosition
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "This action will restore the window position." + Localizer.NL + Localizer.NL +
                        DoYouWantToContinue[Localizer.EN] },
        { Localizer.FR, "Cette action va restaurer la position de la fenêtre."  + Localizer.NL + Localizer.NL +
                        DoYouWantToContinue[Localizer.FR] },
      };

    static public readonly Dictionary<string, string> AskToResetPreferences
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Preferences will be reseted to their default values." + Localizer.NL + Localizer.NL +
                        DoYouWantToContinue[Localizer.EN] },
        { Localizer.FR, "Les préférences vont être réinitialisées à leurs valeurs par défaut." + Localizer.NL + Localizer.NL +
                        DoYouWantToContinue[Localizer.FR] },
      };

    static public readonly Dictionary<string, string> AskToLoadInstalledData
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "This action will load the data installed with the application." + Localizer.NL + Localizer.NL +
                        "All modifications will be lost." + Localizer.NL + Localizer.NL +
                        DoYouWantToContinue[Localizer.EN] },
        { Localizer.FR, "Cette action va charger les données installées avec l'application."  + Localizer.NL + Localizer.NL +
                        "Toutes les modifications seront perdues." + Localizer.NL + Localizer.NL +
                        DoYouWantToContinue[Localizer.FR] },
      };

    static public readonly Dictionary<string, string> ErrorInFile
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Error in {0}" + Localizer.NL + Localizer.NL +
                        "Line n° {1]" + Localizer.NL + Localizer.NL +
                        "{2}" },
        { Localizer.FR, "Erreur dans {0}" + Localizer.NL + Localizer.NL +
                        "Ligne n° {1}" + Localizer.NL + Localizer.NL +
                        "{2}" }
      };

    static public readonly Dictionary<string, string> FileNotFound
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "File not found: " + Localizer.NL + Localizer.NL + "{0}" },
        { Localizer.FR, "Fichier non trouvé :" + Localizer.NL + Localizer.NL + "{0}" }
      };

    static public readonly Dictionary<string, string> TermNotFound
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Term \"{0}\" not found." },
        { Localizer.FR, "Terme \"{0}\" non trouvé." }
      };

    static public readonly Dictionary<string, string> AskToOpenAllLinks
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Do you want to open all \"{0}\" links?" },
        { Localizer.FR, "Voulez-vous ouvrir tous les liens de \"{0}\" ?" }
      };

    static public readonly Dictionary<string, string> AskToDownloadHebrewLetters
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Hebrew Letters not found." + Localizer.NL +
                        "Check preferences." + Localizer.NL + Localizer.NL +
                        "Do you want to download it?" },
        { Localizer.FR, "Hebrew Letters n'a pas été trouvé." + Localizer.NL +
                        "Vérifiez les préférences." + Localizer.NL + Localizer.NL +
                        "Voulez-vous le télécharger ?" }
      };

    static public readonly Dictionary<string, string> AskToDownloadHebrewWOrds
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Hebrew Words not found." + Localizer.NL +
                        "Check preferences." + Localizer.NL + Localizer.NL +
                        "Do you want to download it?" },
        { Localizer.FR, "Hebrew Words n'a pas été trouvé." + Localizer.NL +
                        "Vérifiez les préférences." + Localizer.NL + Localizer.NL +
                        "Voulez-vous le télécharger ?" }
      };

    static public readonly Dictionary<string, string> ConfigureProviders
      = new Dictionary<string, string>()
      {
        { Localizer.EN, "Configure providers" },
        { Localizer.FR, "Configurer les fournisseurs" }
      };

    static public readonly Dictionary<bool, Dictionary<string, string>> HideRestore
      = new Dictionary<bool, Dictionary<string, string>>()
      {
        {
          true, new Dictionary<string, string>
          {
            { Localizer.EN, "Hide" },
            { Localizer.FR, "Cacher" }
          }
        },
        {
          false, new Dictionary<string, string>
          {
            { Localizer.EN, "Restore" },
            { Localizer.FR, "Restaurer" }
          }
        }
      };

  }

}
