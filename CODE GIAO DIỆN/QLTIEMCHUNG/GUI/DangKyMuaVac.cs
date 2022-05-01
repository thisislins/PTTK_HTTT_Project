using BLL;
using DTO;
using System;
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
    public partial class DangKyMuaVac : Form
    {
        public DangKyMuaVac()
        {
            InitializeComponent();
        }

        KhachHang_BLL KH_BLL = new KhachHang_BLL();
        Vaccine_BLL vac_BLL = new Vaccine_BLL();
        PhieuDK_BLL pdk_BLL = new PhieuDK_BLL();
        private void DangKyMuaVac_Load(object sender, EventArgs e)
        {
            dsVacGrid.DataSource = vac_BLL.DocDSVaccine();
        }

        private void btnTaoPDK_Click(object sender, EventArgs e)
        {
            if (!KH_BLL.KiemTraMaKH(txtBoxMaKH.Text))
            {
                MessageBox.Show("MAKH KHÔNG TỒN TẠI!!");
                return;
            }
            PhieuDK pdk = new PhieuDK(ngayLapPicker.Value, "N'Chưa thanh toán'", "Online",
0, "N'Chưa tiêm'", 0, int.Parse(txtBoxMaKH.Text), int.Parse(txtBoxMaNV.Text));
            MessageBox.Show(pdk.NgayTiem.ToString() + " " + pdk.TrangThai + " " + pdk.Loai + " " + pdk.TongTien + " " + pdk.TrangThaiTT+ " " + pdk.SoDTT+ " " + pdk.MaKH+" " +pdk.MaNV);
            for (int i = 0; i < dsTamGrid.Rows.Count - 1; i++)
            {
                pdk.DSCT_DangKy.Add(new CTDangKY(int.Parse(dsTamGrid.Rows[i].Cells[0].Value.ToString()), int.Parse(dsTamGrid.Rows[i].Cells[2].Value.ToString()),
                int.Parse(dsTamGrid.Rows[i].Cells[3].Value.ToString()), decimal.Parse(dsTamGrid.Rows[i].Cells[4].Value.ToString())));
            }
            if (pdk_BLL.TaoPhieuDK(pdk))
            {
                MessageBox.Show("Tạo phiếu thành công");
            }
            else
            {
                MessageBox.Show("Tạo phiếu thất bại");
            }
        }

        private void btnThemPD_Click(object sender, EventArgs e)
        {
            if (dsTamGrid.Rows[0].Cells[0].Value != null)
            {
                for (int i = 0; i < dsTamGrid.RowCount-1; i++)
                {
                    if (dsTamGrid.Rows[i].Cells[0].Value.ToString().Equals(dsVacGrid.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("BỊ TRÙNG!!!");
                        return;
                    }
                }
            }
            dsTamGrid.Rows.Add(dsVacGrid.SelectedRows[0].Cells[0].Value,
                    dsVacGrid.SelectedRows[0].Cells[1].Value,
                    "0", "0", "0");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dsTamGrid.Rows.Clear();
        }
    }
}
