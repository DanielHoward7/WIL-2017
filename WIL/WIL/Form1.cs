﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemLogic;

namespace WIL
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
=======

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new UserForm().ShowDialog();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
           Servicefrm fService = new Servicefrm();
           fService.Show();
        }
>>>>>>> Morne
    }
}
