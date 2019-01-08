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
    public partial class frmChoiceCategory : Form
    {
        //ConnectionDB
        private ConnectionDB connDB = new ConnectionDB();

        public frmChoiceCategory()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <author>JJO</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmChoiceCategory_Load(object sender, EventArgs e)
        {
            List<String> lstCategory = connDB.ExtractCategory();
            int i = 0;

            foreach (String cat in lstCategory)
            {
                i++;
                var button = new Button();
                button.Location = new Point(button.Width * i + 4, 0);
                button.Name = "cmd"+cat;
                button.Text = cat;
                Controls.Add(button);
                button.Click += this.Button_Click; 
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            //Test du parametre
            //Console.WriteLine(s);
            frmGame play = new frmGame(s);
            play.Show();
            this.Close();
        }
    }
}
