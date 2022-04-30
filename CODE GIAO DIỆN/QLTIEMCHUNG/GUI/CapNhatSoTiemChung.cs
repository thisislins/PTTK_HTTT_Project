using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class CapNhatSoTiemChung : Form
    {
        public CapNhatSoTiemChung(int makh, int mavc, DateTime ngaytiem)
        {
            InitializeComponent();
            lbMaKH.Text = makh.ToString();
            lbVaccine.Text = mavc.ToString();
            dateNgayTiem.Value = ngaytiem;
            
            SoTiemChung stc = SoTiemChung_BLL.LaySoTiemChung(mavc, makh, ngaytiem);

            txtPU.Text = stc.pHANUNG;
        }

        private void CapNhatSoTiemChung_Load(object sender, EventArgs e)
        {
           
        }

        private void btnUpdateSTC_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbMaKH.Text == "0")
                {
                    MessageBox.Show("Xảy ra sự cố, vui lòng quay lại sau!");
                    return;
                }
                int mavc = Int32.Parse(lbVaccine.Text);
                int makh = Int16.Parse(lbMaKH.Text);
                DateTime ngaytiem = dateNgayTiem.Value;
                string phanung = txtPU.Text;
                SoTiemChung stc = new SoTiemChung(mavc, makh, ngaytiem, phanung);
                SoTiemChung_BLL.SuaSoTiemChung(stc);
                MessageBox.Show("Cập nhật sổ tiêm chủng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
        }

        private void CapNhatSoTiemChung_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            QLSoTiemChung STC = new QLSoTiemChung();
            STC.Visible = true;
        }
    }
}
