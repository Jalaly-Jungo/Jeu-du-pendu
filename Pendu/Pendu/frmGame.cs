using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendu
{
    public partial class frmGame : Form
    {
        //ConnectionDB
        private ConnectionDB connDB = new ConnectionDB();

        private string _s; //SenderCat
        private int idCat; //

        /// <summary>
        /// The simple constructor without parameters
        /// </summary>
        public frmGame() : this("")
        {
            
        }

        /// <summary>
        /// The principal constructor 
        /// </summary>
        /// <author>JJO</author>
        /// <param name="s">category of word</param>
        public frmGame(string SenderCat)
        {
            this._s = SenderCat;
            InitializeComponent();
        }
        /// <summary>
        /// Extract the words and load the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGame_Load(object sender, EventArgs e)
        {
            //search words
            //Split the name of button passed in parameter using the format of a number
            string[] number = Regex.Split(_s, @"\D+");
            foreach (string value in number)
            {
                //Check the type of value
                if (!string.IsNullOrEmpty(value))
                {
                    idCat = int.Parse(value);
                    //Console.WriteLine("Number: {0}", idCat);
                }
            }

            List<Tuple<string, bool>> lstWords = connDB.ExctractWords(idCat);
            int i = 0;

            //extract all words
            //stocker dans un tableau afin de les parcourir 
            foreach (Tuple<string, bool> words in lstWords)
            {
                var array = words.Item1.ToCharArray();
            }

            //split the letters of one word
            //ATTENTION l'espace n'existe pas dans le clavier visuelle


            //Create textBox with letters but value invisible
            foreach (Tuple<string, bool> words in lstWords)
            {
                //string Word1 = "";
                i++;
                if (words.Item2 == false)
                {
                    var textbox = new TextBox();
                    Console.WriteLine("txt" + (words.Item1.Substring(0,i))+"\n");
                    //textbox.Name = "txt"+ (words.Item1.Substring(i));
                    textbox.Location = new Point(textbox.Width * i + 5, 200);
                    Controls.Add(textbox);//Add button on form
                }
            }
        }

        /// <summary>
        /// check the char button with the letters in the word
        /// </summary>
        private void CharChecker()
        {

        }
    }
}
