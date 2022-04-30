
namespace GUI
{
    partial class DSDatMua
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTaoPDK = new System.Windows.Forms.Button();
            this.btnThemPD = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxTongTien = new System.Windows.Forms.TextBox();
            this.cbBoxMaPDK = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxMaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CTDKGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHuyPD = new System.Windows.Forms.Button();
            this.btnDuyetPD = new System.Windows.Forms.Button();
            this.btnXemCTPD = new System.Windows.Forms.Button();
            this.PhieuDatGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CTDKGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuDatGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaoPDK
            // 
            this.btnTaoPDK.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTaoPDK.ForeColor = System.Drawing.Color.White;
            this.btnTaoPDK.Location = new System.Drawing.Point(793, 448);
            this.btnTaoPDK.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoPDK.Name = "btnTaoPDK";
            this.btnTaoPDK.Size = new System.Drawing.Size(181, 37);
            this.btnTaoPDK.TabIndex = 34;
            this.btnTaoPDK.Text = "TẠO PHIẾU ĐĂNG KÝ";
            this.btnTaoPDK.UseVisualStyleBackColor = false;
            this.btnTaoPDK.Click += new System.EventHandler(this.btnTaoPDK_Click);
            // 
            // btnThemPD
            // 
            this.btnThemPD.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemPD.ForeColor = System.Drawing.Color.White;
            this.btnThemPD.Location = new System.Drawing.Point(875, 726);
            this.btnThemPD.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemPD.Name = "btnThemPD";
            this.btnThemPD.Size = new System.Drawing.Size(100, 37);
            this.btnThemPD.TabIndex = 33;
            this.btnThemPD.Text = "THÊM";
            this.btnThemPD.UseVisualStyleBackColor = false;
            this.btnThemPD.Click += new System.EventHandler(this.btnThemPD_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(728, 698);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "TỔNG TIỀN:";
            // 
            // txtBoxTongTien
            // 
            this.txtBoxTongTien.Location = new System.Drawing.Point(828, 694);
            this.txtBoxTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTongTien.Name = "txtBoxTongTien";
            this.txtBoxTongTien.Size = new System.Drawing.Size(145, 22);
            this.txtBoxTongTien.TabIndex = 31;
            // 
            // cbBoxMaPDK
            // 
            this.cbBoxMaPDK.FormattingEnabled = true;
            this.cbBoxMaPDK.Location = new System.Drawing.Point(97, 455);
            this.cbBoxMaPDK.Margin = new System.Windows.Forms.Padding(4);
            this.cbBoxMaPDK.Name = "cbBoxMaPDK";
            this.cbBoxMaPDK.Size = new System.Drawing.Size(160, 24);
            this.cbBoxMaPDK.TabIndex = 30;
            this.cbBoxMaPDK.SelectionChangeCommitted += new System.EventHandler(this.cbBoxMaPDK_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 436);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "MÃ NHÂN VIÊN";
            // 
            // txtBoxMaNV
            // 
            this.txtBoxMaNV.Location = new System.Drawing.Point(353, 455);
            this.txtBoxMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxMaNV.Name = "txtBoxMaNV";
            this.txtBoxMaNV.Size = new System.Drawing.Size(164, 22);
            this.txtBoxMaNV.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 494);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "CHI TIẾT PHIẾU ĐĂNG KÝ";
            // 
            // CTDKGrid
            // 
            this.CTDKGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CTDKGrid.Location = new System.Drawing.Point(97, 513);
            this.CTDKGrid.Margin = new System.Windows.Forms.Padding(4);
            this.CTDKGrid.Name = "CTDKGrid";
            this.CTDKGrid.RowHeadersWidth = 51;
            this.CTDKGrid.Size = new System.Drawing.Size(877, 174);
            this.CTDKGrid.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 436);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "MÃ PHIẾU ĐĂNG KÝ";
            // 
            // btnHuyPD
            // 
            this.btnHuyPD.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHuyPD.ForeColor = System.Drawing.Color.White;
            this.btnHuyPD.Location = new System.Drawing.Point(875, 320);
            this.btnHuyPD.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyPD.Name = "btnHuyPD";
            this.btnHuyPD.Size = new System.Drawing.Size(100, 37);
            this.btnHuyPD.TabIndex = 24;
            this.btnHuyPD.Text = "HỦY";
            this.btnHuyPD.UseVisualStyleBackColor = false;
            this.btnHuyPD.Click += new System.EventHandler(this.btnHuyPD_Click);
            // 
            // btnDuyetPD
            // 
            this.btnDuyetPD.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDuyetPD.ForeColor = System.Drawing.Color.White;
            this.btnDuyetPD.Location = new System.Drawing.Point(767, 320);
            this.btnDuyetPD.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuyetPD.Name = "btnDuyetPD";
            this.btnDuyetPD.Size = new System.Drawing.Size(100, 37);
            this.btnDuyetPD.TabIndex = 23;
            this.btnDuyetPD.Text = "DUYỆT";
            this.btnDuyetPD.UseVisualStyleBackColor = false;
            this.btnDuyetPD.Click += new System.EventHandler(this.btnDuyetPD_Click);
            // 
            // btnXemCTPD
            // 
            this.btnXemCTPD.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnXemCTPD.ForeColor = System.Drawing.Color.White;
            this.btnXemCTPD.Location = new System.Drawing.Point(659, 320);
            this.btnXemCTPD.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemCTPD.Name = "btnXemCTPD";
            this.btnXemCTPD.Size = new System.Drawing.Size(100, 37);
            this.btnXemCTPD.TabIndex = 22;
            this.btnXemCTPD.Text = "XEM";
            this.btnXemCTPD.UseVisualStyleBackColor = false;
            this.btnXemCTPD.Click += new System.EventHandler(this.btnXemCTPD_Click);
            // 
            // PhieuDatGrid
            // 
            this.PhieuDatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhieuDatGrid.Location = new System.Drawing.Point(97, 139);
            this.PhieuDatGrid.Margin = new System.Windows.Forms.Padding(4);
            this.PhieuDatGrid.MultiSelect = false;
            this.PhieuDatGrid.Name = "PhieuDatGrid";
            this.PhieuDatGrid.RowHeadersWidth = 51;
            this.PhieuDatGrid.Size = new System.Drawing.Size(877, 174);
            this.PhieuDatGrid.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Chocolate;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(93, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(13, 6, 13, 6);
            this.label3.Size = new System.Drawing.Size(230, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "DANH SÁCH PHIẾU ĐẶT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(93, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(13, 6, 13, 6);
            this.label2.Size = new System.Drawing.Size(281, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "THÊM MỚI TỪ PHIẾU ĐĂNG KÝ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(404, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(40, 12, 40, 12);
            this.label1.Size = new System.Drawing.Size(306, 49);
            this.label1.TabIndex = 18;
            this.label1.Text = "DANH SÁCH ĐẶT MUA";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(97, 726);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 37);
            this.btnReturn.TabIndex = 35;
            this.btnReturn.Text = "Trở lại";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // DSDatMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 796);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnTaoPDK);
            this.Controls.Add(this.btnThemPD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxTongTien);
            this.Controls.Add(this.cbBoxMaPDK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxMaNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CTDKGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHuyPD);
            this.Controls.Add(this.btnDuyetPD);
            this.Controls.Add(this.btnXemCTPD);
            this.Controls.Add(this.PhieuDatGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DSDatMua";
            this.Text = "Danh sách đặt mua";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DSDatMua_FormClosing);
            this.Load += new System.EventHandler(this.DSDatMua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CTDKGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuDatGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaoPDK;
        private System.Windows.Forms.Button btnThemPD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxTongTien;
        private System.Windows.Forms.ComboBox cbBoxMaPDK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView CTDKGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHuyPD;
        private System.Windows.Forms.Button btnDuyetPD;
        private System.Windows.Forms.Button btnXemCTPD;
        private System.Windows.Forms.DataGridView PhieuDatGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
    }
}

