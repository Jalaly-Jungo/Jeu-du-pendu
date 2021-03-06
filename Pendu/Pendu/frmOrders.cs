﻿using System;
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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Go back to home
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOrdersBackHome_Click(object sender, EventArgs e)
        {
            frmHome OrderToHome = new frmHome();//Create Form
            OrderToHome.Show();//Show new Form
            this.Close();//Close Form
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            rtbOrders.Text = "Vous devez essayer de deviner le mot généré aléatoirement par le programme en mettant les bonnes lettres.";
            rtbOrders.Enabled = false;
        }
    }
}
