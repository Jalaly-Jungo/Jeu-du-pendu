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
    public partial class frmAddWord : Form
    {
        public frmAddWord()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Go back to home
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAddWordsToHome_Click(object sender, EventArgs e)
        {
            frmHome AddWordsToHome = new frmHome();//Create Form
            AddWordsToHome.Show();//Show new Form
            this.Close();//Close Form
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAddWord_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtAddWord.Text == "")
            {
                MessageBox.Show("Il n'y a pas de mot");
            }
            else
            {
                if (txtAddWord.Text.Contains !== "" )
                {
                    //send to the DATABASE
                }
            }
        }

        // Read only letters (Upper or Lower with Space and Backspace)
        private void txtAddWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >=65) && (e.KeyChar <=90) || (e.KeyChar >=97) && (e.KeyChar <= 122) || (e.KeyChar ==8)|| (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
