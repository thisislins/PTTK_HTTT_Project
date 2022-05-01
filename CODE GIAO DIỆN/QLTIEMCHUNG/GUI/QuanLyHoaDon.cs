﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class QuanLyHoaDon : Form
    {
        public QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void QLHoaDon_Load(object sender, EventArgs e)
        {
            dgvQLHD.DataSource = HoaDon_BLL.HienThiDSHoaDon();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThanhToan TT = new ThanhToan();
            this.Hide();
            TT.ShowDialog();
            this.Show();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            ChiTietHD CTHD = new ChiTietHD();
            this.Hide();
            CTHD.ShowDialog();
            this.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Menu menu = new Menu();
            //menu.Visible = true;
        }
    }
}
