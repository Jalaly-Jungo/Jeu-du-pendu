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
        private void doSqlRequestQuery(string sql)
        {
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// Exectute SQL request reader
        /// </summary>
        /// <author>JJO</author>
        /// <param name="sql"></param>
        private SQLiteDataReader doSqlRequestReader(string sql)
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
            doSqlRequestQuery("INSERT INTO Words (word, discovered, fkCategory) values('Football', false, 1)");
            doSqlRequestQuery("INSERT INTO Words (word, discovered, fkCategory) values('Volley-ball', false, 1)");
            //Fruit
            doSqlRequestQuery("INSERT INTO Words (word, discovered, fkCategory) values('Banane', false, 2)");
            doSqlRequestQuery("INSERT INTO Words (word, discovered, fkCategory) values('Tomate', false, 2)");
            //Pierre
            doSqlRequestQuery("INSERT INTO Words (word, discovered, fkCategory) values('Ruby', false, 3)");
            doSqlRequestQuery("INSERT INTO Words (word, discovered, fkCategory) values('Saphir', false, 3)");

            doSqlRequestQuery("INSERT INTO Words (word, discovered, fkCategory) values('Opel', false, 4)");
            doSqlRequestQuery("INSERT INTO Words (word, discovered, fkCategory) values('Ford', false, 4)");

            doSqlRequestQuery("INSERT INTO Words (word, discovered, fkCategory) values('C', false, 5)");
            doSqlRequestQuery("INSERT INTO Words (word, discovered, fkCategory) values('Wi-fi', false, 5)");

            doSqlRequestQuery("INSERT INTO Words (word, discovered, fkCategory) values('Dwayne Johnson', false, 6)");
            doSqlRequestQuery("INSERT INTO Words (word, discovered, fkCategory) values('Gérard Depardieu', false, 6)");
        }

        /// <summary>
        /// create the table "Categories" and insert data
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
            doSqlRequestQuery("INSERT INTO Category (category) values('Autres')");
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
        /// <returns>Tuple int, string</returns>
        public List<Tuple<int, string>> ExtractCategory()
        {
            //list contains 2 types of value 
            var lstCategory = new List<Tuple<int, string>>();
            //SQL Request
            SQLiteDataReader reader = doSqlRequestReader("SELECT idCategory, category FROM Category");

            while (reader.Read())
            {
                //Convert value
                int idcat = System.Convert.ToInt32(reader["idCategory"].ToString());
                string cat = reader["category"].ToString();

                //AddToList
                lstCategory.Add(Tuple.Create<int, string>(idcat, cat));
            }
            return lstCategory;
        }
        /// <summary>
        /// Exctract the list words
        /// </summary>
        /// <author>JJO</author>
        /// <param name="id"></param>
        /// <returns>Tuple string, bool</returns>
        public List<Tuple<string, bool>> ExctractWords(int id)
        {
            //list of words
            var lstWords = new List<Tuple<string, bool>>();
            //SQL Request
            SQLiteDataReader reader = doSqlRequestReader("SELECT word, discovered FROM Words WHERE fkCategory =" + id);

            while (reader.Read())
            {
                string word = reader["word"].ToString();
                bool discover = System.Convert.ToBoolean(reader["discovered"].ToString());

                //AddToList
                lstWords.Add(Tuple.Create<string, bool>(word, discover));
            }
            return lstWords;
        }
        /// <summary>
        ///  Method to add 
        /// </summary>
        /// <author> EJY</author>
        /// <param name="word"></param>
        /// <param name="category"></param>
        public void Addword (string oneword, int category)
        {
            try
            {
                doSqlRequestQuery("INSERT INTO Words (word, discovered, fkCategory) values(" + "'" + oneword + "'" + "," + false + "," + category + ")");
            }
            catch
            {
                
            }
        }
    }
}
