using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendu
{
    public partial class frmGame : Form
    {
        private string s;

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
        public frmGame(string s)
        {
            this.s = s;
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// check the char button with the letters in the word
        /// </summary>
        private void CharChecker()
        {

        }
    }
}
