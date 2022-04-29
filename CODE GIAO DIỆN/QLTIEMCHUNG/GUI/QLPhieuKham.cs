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
    public partial class QLPhieuKham : Form
    {
        public QLPhieuKham()
        {
            InitializeComponent();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbBS.SelectedIndex == -1 || cbKH.SelectedIndex == -1 || tbKetLuan.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin!");
                    return;
                }
                int mabs = Int16.Parse(cbBS.Text);
                int makh = Int16.Parse(cbKH.Text);
                DateTime ngaykham = dateNgayKham.Value;
                int nhietdo = (int)numNhietDo.Value;
                int nhiptim = (int)numNhipTim.Value;
                int huyetap = (int)numHuyetAp.Value;
                string ketluan = tbKetLuan.Text;
                PhieuKham pk = new PhieuKham(1, mabs, makh, ngaykham, nhietdo, nhiptim, huyetap, ketluan);
                PhieuKham_BLL.ThemPhieuKham(pk);
                MessageBox.Show("Thêm phiếu khám thành công!");
                reset();
                dgvDSPhieuKham.DataSource = PhieuKham_BLL.LayDSPhieuKham();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void QLPhieuKham_Load(object sender, EventArgs e)
        {
            dgvDSPhieuKham.DataSource = PhieuKham_BLL.LayDSPhieuKham();

            cbBS.DataSource = PhieuKham_BLL.LayDSBacSi();
            cbBS.DisplayMember = "MANV";
            cbBS.ValueMember = "MANV";

            cbKH.DataSource = PhieuKham_BLL.LayDSKhachHang();
            cbKH.DisplayMember = "MAKH";
            cbKH.ValueMember = "MAKH";
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();

        }
        private void reset()
        {
            lblMaPK.Text = "Mã phiếu khám";
            cbBS.SelectedIndex = -1;
            cbKH.SelectedIndex = -1;
            numHuyetAp.Value = 0;
            numNhietDo.Value = 0;
            numNhipTim.Value = 0;
            tbKetLuan.Text = "";
            dateNgayKham.Value = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 0, 0, 0, 0);
        }

        private void dgvDSPhieuKham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvDSPhieuKham.Rows[e.RowIndex];
            lblMaPK.Text = row.Cells[0].Value.ToString();
            cbBS.Text = row.Cells[1].Value.ToString();
            cbKH.Text = row.Cells[2].Value.ToString();
            dateNgayKham.Text = row.Cells[3].Value.ToString();
            numNhietDo.Value = Int16.Parse(row.Cells[4].Value.ToString());
            numNhipTim.Value = Int16.Parse(row.Cells[5].Value.ToString());
            numHuyetAp.Value = Int16.Parse(row.Cells[6].Value.ToString());
            tbKetLuan.Text = row.Cells[7].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbBS.SelectedIndex == -1 || cbKH.SelectedIndex == -1 || tbKetLuan.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin!");
                    return;
                }
                int mapk = Int32.Parse(lblMaPK.Text);
                int mabs = Int16.Parse(cbBS.Text);
                int makh = Int16.Parse(cbKH.Text);
                DateTime ngaykham = dateNgayKham.Value;
                int nhietdo = (int)numNhietDo.Value;
                int nhiptim = (int)numNhipTim.Value;
                int huyetap = (int)numHuyetAp.Value;
                string ketluan = tbKetLuan.Text;
                PhieuKham pk = new PhieuKham(mapk, mabs, makh, ngaykham, nhietdo, nhiptim, huyetap, ketluan);
                PhieuKham_BLL.SuaPhieuKham(pk);
                MessageBox.Show("Sửa phiếu khám thành công!");
                reset();
                dgvDSPhieuKham.DataSource = PhieuKham_BLL.LayDSPhieuKham();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbBS.SelectedIndex == -1 || cbKH.SelectedIndex == -1 || tbKetLuan.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin!");
                    return;
                }
                int mapk = Int32.Parse(lblMaPK.Text);
                int mabs = Int16.Parse(cbBS.Text);
                int makh = Int16.Parse(cbKH.Text);
                DateTime ngaykham = dateNgayKham.Value;
                int nhietdo = (int)numNhietDo.Value;
                int nhiptim = (int)numNhipTim.Value;
                int huyetap = (int)numHuyetAp.Value;
                string ketluan = tbKetLuan.Text;
                PhieuKham pk = new PhieuKham(mapk, mabs, makh, ngaykham, nhietdo, nhiptim, huyetap, ketluan);
                PhieuKham_BLL.XoaPhieuKham(pk);
                MessageBox.Show("Xóa phiếu khám thành công!");
                reset();
                dgvDSPhieuKham.DataSource = PhieuKham_BLL.LayDSPhieuKham();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Visible = true;
        }

    }
}



