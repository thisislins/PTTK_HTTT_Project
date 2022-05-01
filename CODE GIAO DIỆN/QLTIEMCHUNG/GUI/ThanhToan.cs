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
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                radioButtonTTTD.Enabled = true;              
                numTienHD.ReadOnly = false;

                if (cbMaPDK.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập mã phiếu đăng ký!");
                    return;
                }

                int MaPDK = Int32.Parse(cbMaPDK.Text);
                dgvDSCTPDK.DataSource = HoaDon_BLL.LayDSCTPDK(MaPDK);

                lbTongtien.Text = PhieuDK_BLL.LayTongTien(MaPDK).ToString();
                lbDotDTT.Text = PhieuDK_BLL.LaySoDotTT(MaPDK).ToString();
                lbTTTT.Text = PhieuDK_BLL.LayTTTT(MaPDK).ToString();
                lbTienDTT.Text = PhieuDK_BLL.LayTongTienDTT(MaPDK).ToString();

                decimal tongtien = decimal.Parse(lbTongtien.Text);
                if (tongtien < 10000000)
                {
                    radioButtonTTTD.Enabled = false;                    
                    numTienHD.Value = tongtien;
                    numTienHD.ReadOnly = true;
                }
                //labelTTPDK.Text = PhieuDK_BLL.LayTongTien(hd.MaPDK).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            cbMaPDK.DataSource = HoaDon_BLL.LayMaPDK();
            cbMaPDK.DisplayMember = "MAPDK";
            cbMaPDK.ValueMember = "MAPDK";

            cbMaNVTN.DataSource = HoaDon_BLL.LayMaNVTN();
            cbMaNVTN.DisplayMember = "MANV";
            cbMaNVTN.ValueMember = "MANV";

            cbMaPDK.ResetText();
            cbMaPDK.SelectedIndex = -1;
            cbMaNVTN.ResetText();
            cbMaNVTN.SelectedIndex = -1;
        }

        private void chbTT1L_CheckedChanged(object sender, EventArgs e)
        {
            if (lbTongtien.Text != "Tổng tiền")
            {
                //numTienHD.Maximum = 10000000000;
                //numTienHD.Minimum = 0;

                lbDotTTTD.Text = "1";
                lbSoTTT.Text = lbTongtien.Text;
                decimal tongtien = decimal.Parse(lbTongtien.Text);
                numTienHD.Value = tongtien;
                //numTienHD.Minimum = tongtien;
                //numTienHD.Maximum = tongtien;
            }
        }             

        private void chbTTTD_CheckedChanged(object sender, EventArgs e)
        {
            if (lbTongtien.Text != "Tổng tiền")
            {
                //numTienHD.Maximum = 10000000000;
                //numTienHD.Minimum = 0;

                lbDotTTTD.Text = "4";
                decimal tongtien = decimal.Parse(lbTongtien.Text);
                decimal soTTT = tongtien / 4;
                numTienHD.Value = soTTT;
                //numTienHD.Minimum = soTTT;
                lbSoTTT.Text = soTTT.ToString();
            }
        }


        private void reset()
        {
            cbMaPDK.ResetText();
            cbMaNVTN.ResetText();

            cbMaPDK.SelectedIndex = -1;
            cbMaNVTN.SelectedIndex = -1;

            dgvDSCTPDK.DataSource = null;

            tbNoiDung.Text = "";
            numTienHD.ReadOnly = false;
            radioButtonTTTD.Enabled = true;

            lbTongtien.Text = "Tổng tiền";
            lbTienDTT.Text = "Số tiền thanh toán";
            lbDotDTT.Text = "Số đợt thanh toán";
            lbDotTTTD.Text = "Đợt TTTD";
            lbSoTTT.Text = "Số tiền tối thiểu";
            lbTTTT.Text = "Trạng thái";
            numTienHD.Maximum = 1000000000;
            numTienHD.Minimum = 0;
            numTienHD.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbTTTT.Text == "ĐÃ THANH TOÁN ĐỦ") 
            {
                MessageBox.Show("Đã thanh toán đủ cho phiếu đăng ký này");
                return;
            }

            if (cbMaPDK.SelectedIndex == -1 || cbMaNVTN.SelectedIndex == -1 || tbNoiDung.Text == "" ||
                        (radioButtonTT1Lan.Checked== false && radioButtonTTTD.Checked == false) ||
                        (radioButtonTTThe.Checked == false && radioButtonTTTienMat.Checked == false))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }

            int MaKH = PhieuDK_BLL.LayMaKH(Int32.Parse(cbMaPDK.Text));
            string PTTT = "";
            string HTTT = "";

            if (radioButtonTT1Lan.Checked == true)
            {
                PTTT = "THANH TOÁN 1 LẦN";
                decimal tongtien = decimal.Parse(lbTongtien.Text);
                numTienHD.Value = tongtien;
                numTienHD.ReadOnly = true;
            }
            else if (radioButtonTTTD.Checked == true)
            {
                numTienHD.ReadOnly = false;
                PTTT = "THANH TOÁN THEO ĐỢT";
            }

            if (radioButtonTTThe.Checked == true)
            {
                HTTT = "THANH TOÁN BẰNG THẺ";
            }
            else if (radioButtonTTTienMat.Checked == true)
            {
                HTTT = "THANH TOÁN BẰNG TIỀN MẶT";
            }
            MessageBox.Show(PTTT);
            MessageBox.Show(HTTT);

            DateTime today = DateTime.Today;
            HoaDon hd = new HoaDon(1, today, tbNoiDung.Text, numTienHD.Value, Int32.Parse(cbMaPDK.Text), Int32.Parse(cbMaNVTN.Text), MaKH, PTTT, HTTT);
            HoaDon_BLL.TaoMoiHoaDon(hd);

            MessageBox.Show("Tao hoa don thanh cong");
            reset();
        }

        private void cbMaPDK_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void radioButtonTT1Lan_CheckedChanged(object sender, EventArgs e)
        {
            if (lbTongtien.Text != "Tổng tiền")
            {
                //numTienHD.Maximum = 10000000000;
                //numTienHD.Minimum = 0;

                lbDotTTTD.Text = "1";
                lbSoTTT.Text = lbTongtien.Text;
                decimal tongtien = decimal.Parse(lbTongtien.Text);
                numTienHD.Value = tongtien;
                //numTienHD.Minimum = tongtien;
                //numTienHD.Maximum = tongtien;
            }
        }

        private void radioButtonTTTD_CheckedChanged(object sender, EventArgs e)
        {
            //numTienHD.Maximum = 10000000000;
            //numTienHD.Minimum = 0;

            lbDotTTTD.Text = "4";
            decimal tongtien = 0;
            try
            {
                tongtien = decimal.Parse(lbTongtien.Text);
            }
            catch (Exception ex) { 
            
            }
            decimal soTTT = tongtien / 4;
            numTienHD.Value = soTTT;
            //numTienHD.Minimum = soTTT;
            lbSoTTT.Text = soTTT.ToString();             
        }
    }
}
