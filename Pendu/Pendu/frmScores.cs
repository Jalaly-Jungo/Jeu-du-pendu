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
    public partial class frmScores : Form
    {
        public frmScores()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Go back to home
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdScoresBackHome_Click(object sender, EventArgs e)
        {
            frmHome ScoreToHome = new frmHome();//Create Form
            ScoreToHome.Show();//Show new Form
            this.Hide();//Hide Form
        }
    }
}
