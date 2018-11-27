using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Pendu
{
    /// <summary>
    /// contains methods and attributes to connect and deal with the database
    /// </summary>
    class ConnectionDB
    {
        //connection to the database
        private SQLiteConnection m_dbConnection;

        /// <summary>
        /// if File exist return false
        /// </summary>
        /// <param name="fileName">string file</param>
        /// <returns></returns>
        public bool Exist(string fileName)
        {
            return System.IO.File.Exists(fileName);
        }

        /// <summary>
        /// constructor : creates the connection to the database SQLite
        /// </summary>
        public ConnectionDB()
        {
            //if BDD exist do not create Table and insert data
            if (Exist("hanged.sqlite"))
            {
                m_dbConnection = new SQLiteConnection("Data Source=hanged.sqlite;Version=3;");
                m_dbConnection.Open();
            }
            else
            {
                SQLiteConnection.CreateFile("Splendor.sqlite");

                m_dbConnection = new SQLiteConnection("Data Source=Splendor.sqlite;Version=3;");
                m_dbConnection.Open();

                //Create and insert ressources
                CreateInsertWords();

                //Create and insert cards
                CreatePlayers();

                //Create and insert Cost
                CreateScores();
            }
        }

        /// <summary>
        /// Exectute SQL request
        /// by Benoit meylan (Splandor)
        /// </summary>
        /// <param name="sql"> SQL request</param>
        public void doSqlRequest(string sql)
        {
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// create the table "Words" and insert data
        /// </summary>
        private void CreateInsertWords()
        {
            //create table of Words
            doSqlRequest("CREATE TABLE `Words` (`idWord` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, `word` TEXT NOT NULL UNIQUE, `descriptionWord` TEXT, `discovered` BOOLEAN);");
            //Insert Word
            doSqlRequest("Insert Into Words (wrods) values('Ruby')");
            //Insert Word
            doSqlRequest("Insert Into Words (wrods) values('Ruby')");
        }

        /// <summary>
        /// create the table "player"
        /// </summary>
        private void CreatePlayers()
        {
            //create table of players
            doSqlRequest("CREATE TABLE `Players` (`idplayer` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, `nameplayer` TEXT NOT NULL UNIQUE);");
        }

        /// <summary>
        /// create the table "Score"
        /// </summary>
        private void CreateScores()
        {
            //create table of Scores
            doSqlRequest("CREATE TABLE `Scores` (`idscore` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, `score` INTEGER NOT NULL);");
        }
    }
}
