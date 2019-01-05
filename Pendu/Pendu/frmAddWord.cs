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
    }
}
