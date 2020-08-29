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
/// <created> 2019-01 </created>
/// <edited> 2020-08 </edited>
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Odbc;
using System.Runtime.Serialization;

namespace Ordisoftware.HebrewCommon
{

  /// <summary>
  /// Provide SQLite exception.
  /// </summary>
  public class SQLiteException : DbException
  {
    public SQLiteException() : base() { }
    public SQLiteException(string message) : base(message) { }
    public SQLiteException(string message, Exception innerException) : base(message, innerException) { }
    public SQLiteException(SerializationInfo info, StreamingContext context) : base(info, context) { }
  }

  /// <summary>
  /// Provide SQLite helper.
  /// </summary>
  static public class SQLiteOdbcHelper
  {

    static public int DefaultOptimizeDaysInterval = 7;

    /// <summary>
    /// Get a single line of a string.
    /// </summary>
    /// <param name="sql"></param>
    /// <returns></returns>
    static public string UnformatSQL(string sql)
    {
      var lines = sql.Split(Globals.NL.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
      return string.Join(" ", lines.Select(line => line.Trim()));
    }

    /// <summary>
    /// Optimize the database.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <param name="lastdone">The last done date.</param>
    /// <param name="force"></param>
    /// <returns>The new date if done else lastdone.</returns>
    static public DateTime Optimize(this OdbcConnection connection, DateTime lastdone, bool force = false)
    {
      if ( force || lastdone.AddDays(DefaultOptimizeDaysInterval) < DateTime.Now )
      {
        connection.CheckIntegrity();
        connection.Vacuum();
        lastdone = DateTime.Now;
      }
      return lastdone;
    }

    /// <summary>
    ///  Vacuum the database.
    /// </summary>
    /// <param name="connection">The connection.</param>
    static public void CheckIntegrity(this OdbcConnection connection)
    {
      try
      {
        var errors = new List<string>();
        using ( var command = new OdbcCommand("SELECT integrity_check FROM pragma_integrity_check()", connection) )
        using ( var reader = command.ExecuteReader() )
          while ( reader.Read() )
          {
            string data = reader.GetString(0);
            if ( data != "ok" ) errors.Add(data);
          }
        if ( errors.Count > 0 )
        {
          string msg = Localizer.DatabaseIntegrityError.GetLang(string.Join(Environment.NewLine, errors));
          throw new SQLiteException(msg);
        }
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
    }

    /// <summary>
    ///  Vacuum the database.
    /// </summary>
    /// <param name="connection">The connection.</param>
    static public void Vacuum(this OdbcConnection connection)
    {
      try
      {
        using ( var command = new OdbcCommand("VACUUM", connection) )
          if ( command.ExecuteNonQuery() != 0 )
            throw new SQLiteException(Localizer.DatabaseVacuumError.GetLang());
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
    }

    /// <summary>
    /// Drop a table if exists.
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="table"></param>
    static public void DropTableIfExists(this OdbcConnection connection, string table)
    {
      try
      {
        using ( var command = new OdbcCommand($"DROP TABLE IF EXISTS {table}", connection) )
          command.ExecuteNonQuery();
      }
      catch ( Exception ex )
      {
        ex.Manage();
      }
    }

    /// <summary>
    /// Check if a table exists and create it if not.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <param name="table">The table name.</param>
    /// <param name="sql">The sql query to create the table, can be empty to only check.</param>
    /// <returns>True if the table does not exist else false.</returns>
    static public bool CheckTable(this OdbcConnection connection, string table, string sql)
    {
      try
      {
        using ( var commandCheck = connection.CreateCommand() )
        {
          commandCheck.CommandText = $"SELECT count(*) FROM sqlite_master WHERE type = 'table' AND name = '{table}'";
          if ( (int)commandCheck.ExecuteScalar() != 0 ) return false;
          if ( !string.IsNullOrEmpty(sql) )
            using ( var commandCreate = new OdbcCommand(sql, connection) )
              try
              {
                commandCreate.ExecuteNonQuery();
              }
              catch ( Exception ex )
              {
                throw new SQLiteException($"Error on create table:{Globals.NL2}{UnformatSQL(sql)}", ex);
              }
        }
      }
      catch ( Exception ex )
      {
        throw new SQLiteException($"Error in {nameof(CheckTable)}", ex);
      }
      return true;
    }

    /// <summary>
    /// Check if a column of a table exists and create it if not.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <param name="table">The table name.</param>
    /// <param name="column">The column name.</param>
    /// <param name="sql">The sql query to create the column, can be empty to only check</param>
    /// <returns>True if the column does not exist else false.</returns>
    static public bool CheckColumn(this OdbcConnection connection, string table, string column, string sql)
    {
      try
      {
        using ( var commandCheck = new OdbcCommand($"PRAGMA table_info({table})", connection) )
        using ( var readerCheck = commandCheck.ExecuteReader() )
        {
          bool found = false;
          int nameIndex = readerCheck.GetOrdinal("Name");
          while ( readerCheck.Read() )
            if ( readerCheck.GetString(nameIndex).Equals(column) )
            {
              found = true;
              break;
            }
          if ( found ) return false;
          if ( !string.IsNullOrEmpty(sql) )
          {
            sql = sql.Replace("%TABLE%", table).Replace("%COLUMN%", column);
            using ( var commandCreate = new OdbcCommand(sql, connection) )
              try
              {
                commandCreate.ExecuteNonQuery();
              }
              catch ( Exception ex )
              {
                throw new SQLiteException($"Error on create column:{Globals.NL2}{UnformatSQL(sql)}", ex);
              }
          }
        }
      }
      catch ( Exception ex )
      {
        throw new SQLiteException($"Error in {nameof(CheckColumn)}", ex);
      }
      return true;
    }

    /// <summary>
    /// Check if a column of a table exists and create it if not.
    /// </summary>
    /// <param name="connection">The connection.</param>
    /// <param name="table">The table name.</param>
    /// <param name="column">The column name.</param>
    /// <param name="type">The type of the column.</param>
    /// <param name="valueDefault">The default value.</param>
    /// <param name="valueNotNull">Indicate if not null.</param>
    /// <returns>True if the column does not exist else false.</returns>
    static public bool CheckColumn(this OdbcConnection connection,
                                   string table,
                                   string column,
                                   string type,
                                   string valueDefault,
                                   bool valueNotNull)
    {
      if ( !string.IsNullOrEmpty(valueDefault) ) valueDefault = " DEFAULT " + valueDefault;
      if ( valueNotNull ) valueDefault += " NOT NULL";
      string sql = $"ALTER TABLE %TABLE% ADD COLUMN %COLUMN% {type} {valueDefault}";
      return connection.CheckColumn(table, column, sql);
    }

  }

}