using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTIEMCHUNG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myFlowLayoutPanel1.Controls.Clear();
            myFlowLayoutPanel1.Controls.Add(new QLPhieuKham());
        }

        private void myFlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
