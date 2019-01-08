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
        /// Inspired by Benoit Meylan (Splendor)
        /// <param name="fileName">string file</param>
        /// <returns></returns>
        public bool Exist(string fileName)
        {
            return System.IO.File.Exists(fileName);
        }

        /// <summary>
        /// constructor : creates the connection to the database SQLite
        /// </summary>
        /// Inspired by Benoit Meylan (Splendor)
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
                SQLiteConnection.CreateFile("hanged.sqlite");

                m_dbConnection = new SQLiteConnection("Data Source=hanged.sqlite;Version=3;");
                m_dbConnection.Open();

                //Create and insert words
                CreateInsertWords();

                //Create and insert category of words
                CreateInsertCategory();

                //Create players
                CreatePlayers();

                //Create scores
                CreateScores();
            }
        }

        /// <summary>
        /// Exectute SQL request query
        /// </summary>
        /// Inspired by Benoit Meylan (Splendor)
        /// <param name="sql"> SQL request</param>
        public void doSqlRequestQuery(string sql)
        {
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Exectute SQL request reader
        /// </summary>
        /// <author>JJO</author>
        /// <param name="sql"></param>
        public SQLiteDataReader doSqlRequestReader(string sql)
        {
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            return reader;
        }

        /// <summary>
        /// create the table "Words" and insert data
        /// </summary>
        /// <author>JJO</author>
        private void CreateInsertWords()
        {
            //create table of Words
            doSqlRequestQuery("CREATE TABLE Words (idWord INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, word TEXT NOT NULL UNIQUE, discovered BOOLEAN, fkCategory INTEGER NOT NULL);");
            //Insert Word
                //Sport
            doSqlRequestQuery("INSERT INTO Words (word, fkCategory) values('Football', 1)");
            doSqlRequestQuery("INSERT INTO Words (word, fkCategory) values('Volley-ball', 1)");
                //Fruit
            doSqlRequestQuery("INSERT INTO Words (word, fkCategory) values('Banane', 2)");
            doSqlRequestQuery("INSERT INTO Words (word, fkCategory) values('Tomate', 2)");
                //Pierre
            doSqlRequestQuery("INSERT INTO Words (word, fkCategory) values('Ruby', 3)");
            doSqlRequestQuery("INSERT INTO Words (word, fkCategory) values('Saphir', 3)");
                
            doSqlRequestQuery("INSERT INTO Words (word, fkCategory) values('Opel', 4)");
            doSqlRequestQuery("INSERT INTO Words (word, fkCategory) values('Ford', 4)");

            doSqlRequestQuery("INSERT INTO Words (word, fkCategory) values('C', 5)");
            doSqlRequestQuery("INSERT INTO Words (word, fkCategory) values('Wi-fi', 5)");

            doSqlRequestQuery("INSERT INTO Words (word, fkCategory) values('Dwayne Johnson', 6)");
            doSqlRequestQuery("INSERT INTO Words (word, fkCategory) values('Gérard Depardieu', 6)");
        }

        /// <summary>
        /// create the table "Words" and insert data
        /// </summary>
        /// <author>JJO</author>
        private void CreateInsertCategory()
        {
            //create table of Category
            doSqlRequestQuery("CREATE TABLE Category (idCategory INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, category TEXT NOT NULL);");
            //Insert Category
            doSqlRequestQuery("INSERT INTO Category (category) values('Sport')");
            doSqlRequestQuery("INSERT INTO Category (category) values('Fruit')");
            doSqlRequestQuery("INSERT INTO Category (category) values('Pierre précieuse')");
            doSqlRequestQuery("INSERT INTO Category (category) values('Voiture')");
            doSqlRequestQuery("INSERT INTO Category (category) values('IT')");
            doSqlRequestQuery("INSERT INTO Category (category) values('Célébrité')");
        }

        /// <summary>
        /// create the table "player"
        /// </summary>
        /// <author>JJO</author>
        private void CreatePlayers()
        {
            //create table of players
            doSqlRequestQuery("CREATE TABLE Players (idplayer INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, nameplayer TEXT NOT NULL);");
        }

        /// <summary>
        /// create the table "Score"
        /// </summary>
        /// <author>JJO</author>
        private void CreateScores()
        {
            //create table of Scores
            doSqlRequestQuery("CREATE TABLE Scores (idscore INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, score INTEGER NOT NULL, fkPlayer INTEGER NOT NULL);");
        }
        /// <summary>
        /// Exctract the list category of words
        /// </summary>
        /// <author>JJO</author>
        public List<String> ExtractCategory()
        {
            List<String> category = new List<string>();

            SQLiteDataReader reader = doSqlRequestReader("SELECT category FROM Category");

            while (reader.Read())
            {
                category.Add(reader["category"].ToString());
            }
            return category;
        }
    }
}
