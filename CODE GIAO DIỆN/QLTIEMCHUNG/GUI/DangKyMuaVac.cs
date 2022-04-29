using BLL;
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

        private void DangKyMuaVac_Load(object sender, EventArgs e)
        {
            dsVacGrid.DataSource = vac_BLL.DocDSVaccine();
            txtBoxTongTien.Text = "0";
        }

        private void btnTaoPDK_Click(object sender, EventArgs e)
        {
            if (!KH_BLL.KiemTraMaKH(txtBoxMaKH.Text))
            {
                MessageBox.Show("MAKH KHÔNG TỒN TẠI!!");
                return;
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
