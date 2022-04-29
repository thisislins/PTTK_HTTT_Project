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

using DTO;
namespace GUI
{
    public partial class DSDatMua : Form
    {
        public DSDatMua()
        {
            InitializeComponent();
        }
        PhieuDK_BLL pdk_BLL = new PhieuDK_BLL();
        PhieuDat_BLL pd_BLL = new PhieuDat_BLL();
        private void DSDatMua_Load(object sender, EventArgs e)
        {
            foreach (PhieuDK item in pdk_BLL.DocDSPDK().DS_PDK) {
                cbBoxMaPDK.Items.Add(item.MaPDK);
            }
            PhieuDatGrid.DataSource = pd_BLL.DocDSPhieuDat();
            PhieuDatGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void cbBoxMaPDK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int maPDK = int.Parse(cbBoxMaPDK.SelectedItem.ToString());
            PhieuDK pdk = new PhieuDK(maPDK);
            CTDKGrid.DataSource = pdk_BLL.XemCTPDK(pdk);
            CTDKGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtBoxTongTien.Text = pdk_BLL.XemTT(maPDK).TongTien.ToString();
            txtBoxMaNV.Text = pdk_BLL.XemTT(maPDK).MaNV.ToString();
        }

        private void btnThemPD_Click(object sender, EventArgs e)
        {
            int maPDK = int.Parse(cbBoxMaPDK.SelectedItem.ToString());
            string result = pd_BLL.ThemPhieuDat(pdk_BLL.XemTT(maPDK),CTDKGrid);
            if (result.Equals("True")) {
                PhieuDatGrid.DataSource = pd_BLL.DocDSPhieuDat();
            }
            MessageBox.Show(result);
        }

        private void btnXemCTPD_Click(object sender, EventArgs e)
        {
            if (PhieuDatGrid.SelectedRows.Count != 0)
            {
                int maPD = int.Parse(PhieuDatGrid.SelectedRows[0].Cells[0].Value.ToString());
                CTPhieuDat ctpd = new CTPhieuDat(pd_BLL.XemCTPD(maPD));
                ctpd.ShowDialog();
            }
            else
            {
                MessageBox.Show("KHÔNG CÓ DÒNG NÀO ĐƯỢC CHỌN!!");
            }
        }

        private void btnDuyetPD_Click(object sender, EventArgs e)
        {
            if (PhieuDatGrid.SelectedRows.Count != 0) {
                int maPD = int.Parse(PhieuDatGrid.SelectedRows[0].Cells[0].Value.ToString());
                pd_BLL.DuyetPD(maPD);
                PhieuDatGrid.DataSource = pd_BLL.DocDSPhieuDat();
            }
            else
            {
                MessageBox.Show("KHÔNG CÓ DÒNG NÀO ĐƯỢC CHỌN!!");
            }
        }

        private void btnHuyPD_Click(object sender, EventArgs e)
        {
            if (PhieuDatGrid.SelectedRows.Count != 0)
            {
                int maPD = int.Parse(PhieuDatGrid.SelectedRows[0].Cells[0].Value.ToString());
                pd_BLL.HuyPD(maPD);
                PhieuDatGrid.DataSource = pd_BLL.DocDSPhieuDat();
            }
            else
            {
                MessageBox.Show("KHÔNG CÓ DÒNG NÀO ĐƯỢC CHỌN!!");
            }
        }

        private void btnTaoPDK_Click(object sender, EventArgs e)
        {
            DangKyMuaVac dangKyMuaVac = new DangKyMuaVac();
            dangKyMuaVac.ShowDialog();
        }
    }
}
