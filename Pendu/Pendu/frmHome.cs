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
    public partial class frmHome : Form
    {
        //ConnectionDB
        private ConnectionDB connDB = new ConnectionDB();

        public frmHome()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close the game
        /// </summary>
        /// <author>JJO</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Go to orders
        /// </summary>
        /// <author>JJO</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOrders_Click(object sender, EventArgs e)
        {
            frmOrders HomeToOrders = new frmOrders();//Create Form
            ChangeForm(HomeToOrders);
        }
        /// <summary>
        /// Go to scores
        /// </summary>
        /// <author>JJO</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdScores_Click(object sender, EventArgs e)
        {
            frmScores HomeToScores = new frmScores();//Create Form
            ChangeForm(HomeToScores);
        }
        /// <summary>
        /// Go to add word
        /// </summary>
        /// <author>JJO</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAddWords_Click(object sender, EventArgs e)
        {
            frmAddWord HomeToAddWord = new frmAddWord();//Create Form
            ChangeForm(HomeToAddWord);
        }
        /// <summary>
        /// Got to choice the category of words
        /// </summary>
        /// <author>JJO</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPlay_Click(object sender, EventArgs e)
        {
            frmChoiceCategory HomeToChoiceCategory = new frmChoiceCategory();
            ChangeForm(HomeToChoiceCategory);
        }

        /// <summary>
        /// Change the form visible
        /// </summary>
        /// <author>JJO</author>
        /// <param name="frm"></param>
        private void ChangeForm(Form frm)
        {
            frm.Show();
            this.Hide();
        }
    }
}
