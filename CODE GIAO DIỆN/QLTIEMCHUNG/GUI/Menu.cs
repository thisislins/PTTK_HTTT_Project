﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnQLDSDM_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSDatMua dsDatMua = new DSDatMua();
            dsDatMua.Visible = true;
        }

        private void btnQLPhieuKham_Click(object sender, EventArgs e)
        {
            this.Hide();

            QLPhieuKham qlpk = new QLPhieuKham();
            qlpk.Visible = true;
        }
    }
}
