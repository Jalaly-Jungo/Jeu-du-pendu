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
        //Connexion DB to get categories 
        private ConnectionDB connDB = new ConnectionDB();

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


        private void frmAddWord_Load(object sender, EventArgs e)
        {

            List<Tuple<int, string>> lstCat = connDB.ExtractCategory();

            foreach (Tuple<int, string> cat in lstCat)
            {
                lstCategory.Items.Add(cat.Item2.ToString());
            }


        }
        
        /// <summary>
        /// Add Word to Database
        /// </summary>
        /// <author>EJY</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            string word = txtAddWord.Text;
            if (word == "")
            {
                MessageBox.Show("Il n'y a pas de mot");
            }
            else
            {
                //Category not selected
                if (lstCategory.SelectedIndex ==-1)
                {
                    MessageBox.Show("Il faut choisir la catégorie");
                }
                else
                {
                    //Add word to DATABASE
                    connDB.Addword(word, lstCategory.SelectedIndex+1);
                    MessageBox.Show("Votre mot a été ajouté avec succès","Succès", MessageBoxButtons.OK);

                    //Come back to home
                    frmHome AddWordsToHome = new frmHome();//Create Form
                    AddWordsToHome.Show();//Show new Form
                    this.Close();//Close Form
                }
            }
        }

        /// <summary>
        /// Read only letters (Upper or Lower with Space and Backspace)
        /// </summary>
        /// <author>EJY</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAddWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
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
