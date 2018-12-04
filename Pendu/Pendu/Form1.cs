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
    public partial class Form1 : Form
    {
        //connection to the database
        private ConnectionDB ConDB = new ConnectionDB();

        public Form1()
        {
            InitializeComponent();
        }
    }
}
