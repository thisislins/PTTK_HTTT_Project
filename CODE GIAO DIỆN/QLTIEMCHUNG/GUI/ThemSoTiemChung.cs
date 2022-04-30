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
    public partial class ThemSoTiemChung : Form
    {
        public ThemSoTiemChung()
        {
            InitializeComponent();
        }

        private void ThemSoTiemChung_Load(object sender, EventArgs e)
        {
            cbMaKH.DataSource = SoTiemChung_BLL.LayDSKhachHang();
            cbMaKH.DisplayMember = "MAKH";
            cbMaKH.ValueMember = "MAKH";

            cbDSVac.DataSource = SoTiemChung_BLL.LayDSVaccine();
            cbDSVac.DisplayMember = "MAVC";
            cbDSVac.ValueMember = "MAVC";
        }

        private void btnTaoSTC_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbMaKH.SelectedIndex == -1 || cbDSVac.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin!");
                    return;
                }
                int mavac = Int32.Parse(cbDSVac.Text);
                int makh = Int32.Parse(cbMaKH.Text);
                DateTime ngaytiem = dateNgayTiem.Value;
                string phanung = txtPU.Text;

                SoTiemChung stc = new SoTiemChung(mavac, makh, ngaytiem, phanung);
                SoTiemChung_BLL.ThemSoTiemChung(stc);
                MessageBox.Show("Thêm sổ tiêm chủng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ThemSoTiemChung_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            QLSoTiemChung STC = new QLSoTiemChung();
            STC.Visible = true;
        }
    }
}
