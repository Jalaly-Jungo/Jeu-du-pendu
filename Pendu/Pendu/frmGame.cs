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

        private void frmGame_Load(object sender, EventArgs e)
        {
            loadWords();
        }

        private string loadWords()
        {
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
            connDB.ExctractWords(idCat);


            return "";
        }

        /// <summary>
        /// check the char button with the letters in the word
        /// </summary>
        private void CharChecker()
        {

        }
    }
}
