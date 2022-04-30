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
    public partial class QLSoTiemChung : Form
    {
        public QLSoTiemChung()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Visible = true;
        }

        private void reset()
        {
            cbMaKH.SelectedIndex = -1;
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            dgvDSSoTiemChung.DataSource = SoTiemChung_BLL.LayDSSoTiemChung();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void QLSoTiemChung_Load(object sender, EventArgs e)
        {
            dgvDSSoTiemChung.DataSource = SoTiemChung_BLL.LayDSSoTiemChung();

            cbMaKH.DataSource = SoTiemChung_BLL.LayDSKhachHang();
            cbMaKH.DisplayMember = "MAKH";
            cbMaKH.ValueMember = "MAKH";
            dgvDSSoTiemChung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbMaKH.SelectedIndex != -1)
            {
                int makh = Int32.Parse(cbMaKH.Text);
                dgvDSSoTiemChung.DataSource = SoTiemChung_BLL.LaySoTiemChung(makh);

                KhachHang ttKH = SoTiemChung_BLL.LayTTKhachHang(makh);
                txtTenKH.Text = ttKH.hOTEN;
                txtDiaChi.Text = ttKH.dIACHI;
            }
        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemSoTiemChung themSTC = new ThemSoTiemChung();
            themSTC.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDSSoTiemChung.SelectedRows.Count != 0)
            {
                int mavc = int.Parse(dgvDSSoTiemChung.SelectedRows[0].Cells[1].Value.ToString());
                DateTime ngaytiem = DateTime.Parse(dgvDSSoTiemChung.SelectedRows[0].Cells[0].Value.ToString());
                int makh = int.Parse(dgvDSSoTiemChung.SelectedRows[0].Cells[3].Value.ToString());

                this.Hide();
                CapNhatSoTiemChung upSTC = new CapNhatSoTiemChung(makh, mavc, ngaytiem);
                upSTC.ShowDialog();
            }
            else
            {
                MessageBox.Show("CHỌN SỔ TIÊM CHỦNG ĐỂ CHỈNH SỬA!!");
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDSSoTiemChung.SelectedRows.Count != 0)
            {
                int mavc = int.Parse(dgvDSSoTiemChung.SelectedRows[0].Cells[1].Value.ToString());
                DateTime ngaytiem = DateTime.Parse(dgvDSSoTiemChung.SelectedRows[0].Cells[0].Value.ToString());
                int makh = int.Parse(dgvDSSoTiemChung.SelectedRows[0].Cells[3].Value.ToString());

                this.Hide();
                XoaSoTiemChung xoaSTC = new XoaSoTiemChung(makh, mavc, ngaytiem);
                xoaSTC.ShowDialog();
            }
            else
            {
                MessageBox.Show("CHỌN SỔ TIÊM CHỦNG ĐỂ XÓA!!");
            }
        }
    }
}
