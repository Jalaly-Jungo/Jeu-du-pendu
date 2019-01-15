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

        /// <summary>
        /// principal constructor
        /// </summary>
        public frmChoiceCategory()
        {
            InitializeComponent();
        }
        /// <summary>
        /// load the form and create button with Tuple list
        /// </summary>
        /// <author>JJO</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmChoiceCategory_Load(object sender, EventArgs e)
        {
            //list contains 2 types of value
            List<Tuple<int, string>> lstCategory = connDB.ExtractCategory();
            int i = 0;
            //extracts the contents of the Tuple list to create buttons
            foreach (Tuple<int, string> cat in lstCategory)
            {
                i++;
                var button = new Button();//create button
                button.Location = new Point(button.Width * i + 4, 0);
                button.Name = "cmd"+cat.Item2.ToString()+cat.Item1.ToString();
                button.Text = cat.Item2.ToString();
                Controls.Add(button);//Add button on form
                button.Click += this.Button_Click; //create event
            }
        }
        /// <summary>
        /// Event click for all button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            //We pass the name of the button in another form and we change the form
            string SenderCat = (sender as Button).Name;
            frmGame play = new frmGame(SenderCat);
            play.Show();
            this.Close();
        }
    }
}
