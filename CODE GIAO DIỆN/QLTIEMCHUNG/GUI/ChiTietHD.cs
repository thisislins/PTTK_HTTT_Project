using System;
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
    public partial class ChiTietHD : Form
    {
        public ChiTietHD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbMaHD.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập mã hóa đơn!");
                    return;
                }
                cbMaPDK.DataSource = HoaDon_BLL.LayMaPDK();
                cbMaPDK.DisplayMember = "MAPDK";
                cbMaPDK.ValueMember = "MAPDK";

                cbMaKH.DataSource = HoaDon_BLL.LayMaKH();
                cbMaKH.DisplayMember = "MAKH";
                cbMaKH.ValueMember = "MAKH";

                cbMaNVTN.DataSource = HoaDon_BLL.LayMaNVTN();
                cbMaNVTN.DisplayMember = "MANV";
                cbMaNVTN.ValueMember = "MANV";

                int _mahd = Int32.Parse(cbMaHD.Text);
                HoaDon hd = HoaDon_BLL.LayThongTinHD(_mahd);
                string pttt = hd.PTTT;
                string httt = hd.HTTT;

                if (pttt == "THANH TOÁN 1 LẦN")
                {
                    chbTT1L.Checked = true;
                }
                if (pttt == "THANH TOÁN THEO ĐỢT")
                {
                    chbTTTD.Checked = true;
                }
                if (httt == "THANH TOÁN BẰNG THẺ")
                {
                    chbTTBT.Checked = true;
                }
                if (httt == "THANH TOÁN BẰNG TIỀN MẶT")
                {
                    chbTTBTM.Checked = true;
                }

                cbMaPDK.Text = hd.MaPDK.ToString();
                cbMaKH.Text = hd.MaKH.ToString();
                cbMaNVTN.Text = hd.MaNV.ToString();
                dateNgayLap.Text = hd.NgayLap.ToString();
                tbNoiDung.Text = hd.NoiDung.ToString();
                numTienHD.Value = hd.TongTienThanhToan;

                dgvDSCTPDK.DataSource = HoaDon_BLL.LayDSCTPDK(hd.MaPDK);
                labelTTPDK.Text = PhieuDK_BLL.LayTongTien(hd.MaPDK).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CTHoaDon_Load(object sender, EventArgs e)
        {
            cbMaHD.DataSource = HoaDon_BLL.LayDSMaHD();
            cbMaHD.DisplayMember = "MAHD";
            cbMaHD.ValueMember = "MAHD";
            reset();
        }
        private void reset()
        {
            cbMaHD.ResetText();
            cbMaPDK.ResetText();
            cbMaKH.ResetText();
            cbMaNVTN.ResetText();

            cbMaHD.SelectedIndex = -1;
            cbMaPDK.SelectedIndex = -1;
            cbMaKH.SelectedIndex = -1;
            cbMaNVTN.SelectedIndex = -1;

            labelTTPDK.Text = "TỔNG TIỀN PDK";
            dgvDSCTPDK.DataSource = null;
            numTienHD.Value = 0;
            tbNoiDung.Text = "";           
            chbTT1L.Checked = false;
            chbTTTD.Checked = false;
            chbTTBT.Checked = false;
            chbTTBTM.Checked = false;
            dateNgayLap.Value = DateTime.Parse("01/01/2000");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Cap nhat thong tin", "Ban co chac chan muon cap nhat thong tin ? ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (cbMaHD.SelectedIndex == -1 || cbMaPDK.SelectedIndex == -1 || cbMaKH.SelectedIndex == -1 ||
                         cbMaNVTN.SelectedIndex == -1 || dateNgayLap.Text == "" || tbNoiDung.Text == "" ||
                         (chbTT1L.CheckState == CheckState.Unchecked && chbTTTD.CheckState == CheckState.Unchecked) ||
                         (chbTTBT.CheckState == CheckState.Unchecked && chbTTBTM.CheckState == CheckState.Unchecked))
                    {
                        MessageBox.Show("Vui lòng điền đủ thông tin!");
                        return;
                    }

                    int _maHD = Int32.Parse(cbMaHD.Text);
                    int _maPDK = Int32.Parse(cbMaPDK.Text);
                    int _maNVTN = Int32.Parse(cbMaNVTN.Text);
                    int _maKH = Int32.Parse(cbMaKH.Text);
                    DateTime _ngaylap = dateNgayLap.Value;
                    string _nd = tbNoiDung.Text;
                    decimal _tongtien = numTienHD.Value;
                    String _PTTT, _HTTT = "";
                    if (chbTT1L.CheckState == CheckState.Checked)
                    {
                        _PTTT = "THANH TOÁN 1 LẦN";
                    }
                    else
                    {
                        _PTTT = "THANH TOÁN THEO ĐỢT";
                    }
                    if (chbTTBT.CheckState == CheckState.Checked)
                    {
                        _HTTT = "THANH TOÁN BẰNG THẺ";
                    }
                    else
                    {
                        _HTTT = "THANH TOÁN BẰNG TIỀN MẶT";
                    }

                    HoaDon hd = new HoaDon(_maHD, _ngaylap, _nd, _tongtien, _maPDK, _maNVTN, _maKH, _PTTT, _HTTT);
                    HoaDon_BLL.CapNhatHD(hd);

                    MessageBox.Show("Cập nhật thành công!");
                    reset();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Cập nhật thông tin", "Bạn có chắc chắn muốn xóa hóa đơn? ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (cbMaHD.SelectedIndex == -1)
                    {
                        MessageBox.Show("Vui lòng nhập mã hóa đơn!");
                        return;
                    }

                    int _maHD = Int32.Parse(cbMaHD.Text);

                    HoaDon_BLL.XoaHoaDon(_maHD);
                    MessageBox.Show("Xóa hóa đơn thành công!");

                    reset();
                    cbMaHD.DataSource = HoaDon_BLL.LayDSMaHD();
                    cbMaHD.DisplayMember = "MAHD";
                    cbMaHD.ValueMember = "MAHD";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void chbTT1L_CheckedChanged(object sender, EventArgs e)
        {
            chbTTTD.Checked = false;
        }

        private void chbTTTD_CheckedChanged(object sender, EventArgs e)
        {
            chbTT1L.Checked = false;
        }

        private void chbTTBTM_CheckedChanged(object sender, EventArgs e)
        {
            chbTTBT.Checked = false;
        }

        private void chbTTBT_CheckedChanged(object sender, EventArgs e)
        {
            chbTTBTM.Checked = false;
        }

        private void cbMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //QuanLyHoaDon qlhd = new QuanLyHoaDon();
            //qlhd.Visible = true;
        }
    }
}
