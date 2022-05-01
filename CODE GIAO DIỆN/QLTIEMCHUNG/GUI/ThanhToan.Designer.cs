
namespace GUI
{
    partial class ThanhToan
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
            this.numTienHD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbMaPDK = new System.Windows.Forms.ComboBox();
            this.lblNgayKham = new System.Windows.Forms.Label();
            this.dgvDSCTPDK = new System.Windows.Forms.DataGridView();
            this.btnKtra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chbTTBT = new System.Windows.Forms.CheckBox();
            this.chbTTBTM = new System.Windows.Forms.CheckBox();
            this.chbTTTD = new System.Windows.Forms.CheckBox();
            this.chbTT1L = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.lbTTTT = new System.Windows.Forms.Label();
            this.lbDotDTT = new System.Windows.Forms.Label();
            this.lbSoTTT = new System.Windows.Forms.Label();
            this.lbDotTTTD = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbTienDTT = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNoiDung = new System.Windows.Forms.TextBox();
            this.cbMaNVTN = new System.Windows.Forms.ComboBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTienHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPDK)).BeginInit();
            this.SuspendLayout();
            // 
            // numTienHD
            // 
            this.numTienHD.Location = new System.Drawing.Point(344, 477);
            this.numTienHD.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numTienHD.Name = "numTienHD";
            this.numTienHD.Size = new System.Drawing.Size(120, 22);
            this.numTienHD.TabIndex = 175;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 173;
            this.label5.Text = "Số tiền khách thanh toán:";
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieu.Location = new System.Drawing.Point(193, 92);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(149, 20);
            this.lblMaPhieu.TabIndex = 167;
            this.lblMaPhieu.Text = "Mã phiếu đăng ký: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(702, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 164;
            this.label11.Text = "Tổng tiền:";
            // 
            // cbMaPDK
            // 
            this.cbMaPDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaPDK.FormattingEnabled = true;
            this.cbMaPDK.ItemHeight = 18;
            this.cbMaPDK.Location = new System.Drawing.Point(394, 93);
            this.cbMaPDK.Name = "cbMaPDK";
            this.cbMaPDK.Size = new System.Drawing.Size(246, 26);
            this.cbMaPDK.TabIndex = 160;
            this.cbMaPDK.SelectedIndexChanged += new System.EventHandler(this.cbMaPDK_SelectedIndexChanged);
            // 
            // lblNgayKham
            // 
            this.lblNgayKham.AutoSize = true;
            this.lblNgayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKham.Location = new System.Drawing.Point(94, 424);
            this.lblNgayKham.Name = "lblNgayKham";
            this.lblNgayKham.Size = new System.Drawing.Size(89, 20);
            this.lblNgayKham.TabIndex = 159;
            this.lblNgayKham.Text = "Trạng thái:";
            // 
            // dgvDSCTPDK
            // 
            this.dgvDSCTPDK.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSCTPDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCTPDK.Location = new System.Drawing.Point(97, 159);
            this.dgvDSCTPDK.Name = "dgvDSCTPDK";
            this.dgvDSCTPDK.RowHeadersWidth = 51;
            this.dgvDSCTPDK.RowTemplate.Height = 24;
            this.dgvDSCTPDK.Size = new System.Drawing.Size(900, 159);
            this.dgvDSCTPDK.TabIndex = 157;
            // 
            // btnKtra
            // 
            this.btnKtra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKtra.Location = new System.Drawing.Point(721, 86);
            this.btnKtra.Name = "btnKtra";
            this.btnKtra.Size = new System.Drawing.Size(125, 33);
            this.btnKtra.TabIndex = 156;
            this.btnKtra.Text = "Kiểm tra";
            this.btnKtra.UseVisualStyleBackColor = false;
            this.btnKtra.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(462, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 155;
            this.label2.Text = "THANH TOÁN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 154;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(617, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 20);
            this.label7.TabIndex = 177;
            this.label7.Text = "Số đợt đã thanh toán:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(94, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 20);
            this.label8.TabIndex = 178;
            this.label8.Text = "Số đợt thanh toán tối đa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(94, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(305, 20);
            this.label9.TabIndex = 179;
            this.label9.Text = "Số tiền tối thiểu cần thanh toán mỗi đợt:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(454, 698);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 53);
            this.button1.TabIndex = 180;
            this.button1.Text = "THANH TOÁN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chbTTBT
            // 
            this.chbTTBT.AutoSize = true;
            this.chbTTBT.Location = new System.Drawing.Point(713, 599);
            this.chbTTBT.Name = "chbTTBT";
            this.chbTTBT.Size = new System.Drawing.Size(163, 21);
            this.chbTTBT.TabIndex = 192;
            this.chbTTBT.Text = "Thanh toán bằng thẻ";
            this.chbTTBT.UseVisualStyleBackColor = true;
            this.chbTTBT.CheckedChanged += new System.EventHandler(this.chbTTBT_CheckedChanged);
            // 
            // chbTTBTM
            // 
            this.chbTTBTM.AutoSize = true;
            this.chbTTBTM.Location = new System.Drawing.Point(713, 563);
            this.chbTTBTM.Name = "chbTTBTM";
            this.chbTTBTM.Size = new System.Drawing.Size(193, 21);
            this.chbTTBTM.TabIndex = 191;
            this.chbTTBTM.Text = "Thanh toán bằng tiền mặt";
            this.chbTTBTM.UseVisualStyleBackColor = true;
            this.chbTTBTM.CheckedChanged += new System.EventHandler(this.chbTTBTM_CheckedChanged);
            // 
            // chbTTTD
            // 
            this.chbTTTD.AutoSize = true;
            this.chbTTTD.Location = new System.Drawing.Point(200, 599);
            this.chbTTTD.Name = "chbTTTD";
            this.chbTTTD.Size = new System.Drawing.Size(159, 21);
            this.chbTTTD.TabIndex = 190;
            this.chbTTTD.Text = "Thanh toán theo đợt";
            this.chbTTTD.UseVisualStyleBackColor = true;
            this.chbTTTD.CheckedChanged += new System.EventHandler(this.chbTTTD_CheckedChanged);
            // 
            // chbTT1L
            // 
            this.chbTT1L.AutoSize = true;
            this.chbTT1L.Location = new System.Drawing.Point(200, 563);
            this.chbTT1L.Name = "chbTT1L";
            this.chbTT1L.Size = new System.Drawing.Size(138, 21);
            this.chbTT1L.TabIndex = 189;
            this.chbTT1L.Text = "Thanh toán 1 lần";
            this.chbTT1L.UseVisualStyleBackColor = true;
            this.chbTT1L.CheckedChanged += new System.EventHandler(this.chbTT1L_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(657, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 188;
            this.label3.Text = "Hình thức thanh toán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 187;
            this.label4.Text = "Phương thức thanh toán:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 24);
            this.label6.TabIndex = 193;
            this.label6.Text = "CHI TIẾT PHIẾU ĐĂNG KÝ";
            // 
            // lbTongtien
            // 
            this.lbTongtien.AutoSize = true;
            this.lbTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongtien.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTongtien.Location = new System.Drawing.Point(854, 336);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(77, 17);
            this.lbTongtien.TabIndex = 194;
            this.lbTongtien.Text = "Tổng tiền";
            // 
            // lbTTTT
            // 
            this.lbTTTT.AutoSize = true;
            this.lbTTTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTTTT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTTTT.Location = new System.Drawing.Point(245, 427);
            this.lbTTTT.Name = "lbTTTT";
            this.lbTTTT.Size = new System.Drawing.Size(83, 17);
            this.lbTTTT.TabIndex = 195;
            this.lbTTTT.Text = "Trạng thái";
            // 
            // lbDotDTT
            // 
            this.lbDotDTT.AutoSize = true;
            this.lbDotDTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDotDTT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbDotDTT.Location = new System.Drawing.Point(854, 385);
            this.lbDotDTT.Name = "lbDotDTT";
            this.lbDotDTT.Size = new System.Drawing.Size(143, 17);
            this.lbDotDTT.TabIndex = 196;
            this.lbDotDTT.Text = " Số đợt thanh toán";
            // 
            // lbSoTTT
            // 
            this.lbSoTTT.AutoSize = true;
            this.lbSoTTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTTT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbSoTTT.Location = new System.Drawing.Point(452, 382);
            this.lbSoTTT.Name = "lbSoTTT";
            this.lbSoTTT.Size = new System.Drawing.Size(123, 17);
            this.lbSoTTT.TabIndex = 197;
            this.lbSoTTT.Text = "Số tiền tối thiểu";
            // 
            // lbDotTTTD
            // 
            this.lbDotTTTD.AutoSize = true;
            this.lbDotTTTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDotTTTD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbDotTTTD.Location = new System.Drawing.Point(341, 336);
            this.lbDotTTTD.Name = "lbDotTTTD";
            this.lbDotTTTD.Size = new System.Drawing.Size(79, 17);
            this.lbDotTTTD.TabIndex = 197;
            this.lbDotTTTD.Text = "Đợt TTTD";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(617, 427);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(172, 20);
            this.label16.TabIndex = 198;
            this.label16.Text = "Số tiền đã thanh toán:";
            // 
            // lbTienDTT
            // 
            this.lbTienDTT.AutoSize = true;
            this.lbTienDTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienDTT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTienDTT.Location = new System.Drawing.Point(854, 430);
            this.lbTienDTT.Name = "lbTienDTT";
            this.lbTienDTT.Size = new System.Drawing.Size(147, 17);
            this.lbTienDTT.TabIndex = 199;
            this.lbTienDTT.Text = " Số tiền thanh toán";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(541, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 200;
            this.label10.Text = "Nội dung:";
            // 
            // tbNoiDung
            // 
            this.tbNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoiDung.Location = new System.Drawing.Point(650, 472);
            this.tbNoiDung.Name = "tbNoiDung";
            this.tbNoiDung.Size = new System.Drawing.Size(347, 30);
            this.tbNoiDung.TabIndex = 201;
            // 
            // cbMaNVTN
            // 
            this.cbMaNVTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbMaNVTN.FormattingEnabled = true;
            this.cbMaNVTN.ItemHeight = 18;
            this.cbMaNVTN.Location = new System.Drawing.Point(302, 646);
            this.cbMaNVTN.Name = "cbMaNVTN";
            this.cbMaNVTN.Size = new System.Drawing.Size(246, 26);
            this.cbMaNVTN.TabIndex = 203;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(99, 648);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(187, 20);
            this.lblMaKH.TabIndex = 202;
            this.lblMaKH.Text = "Mã nhân viên thu ngân: ";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(3, 1);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(113, 30);
            this.btnReturn.TabIndex = 204;
            this.btnReturn.Text = "Trở lại";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 783);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cbMaNVTN);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.tbNoiDung);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbTienDTT);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbDotTTTD);
            this.Controls.Add(this.lbSoTTT);
            this.Controls.Add(this.lbDotDTT);
            this.Controls.Add(this.lbTTTT);
            this.Controls.Add(this.lbTongtien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chbTTBT);
            this.Controls.Add(this.chbTTBTM);
            this.Controls.Add(this.chbTTTD);
            this.Controls.Add(this.chbTT1L);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numTienHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMaPhieu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbMaPDK);
            this.Controls.Add(this.lblNgayKham);
            this.Controls.Add(this.dgvDSCTPDK);
            this.Controls.Add(this.btnKtra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThanhToan";
            this.Text = "ThanhToan";
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTienHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTienHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbMaPDK;
        private System.Windows.Forms.Label lblNgayKham;
        private System.Windows.Forms.DataGridView dgvDSCTPDK;
        private System.Windows.Forms.Button btnKtra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chbTTBT;
        private System.Windows.Forms.CheckBox chbTTBTM;
        private System.Windows.Forms.CheckBox chbTTTD;
        private System.Windows.Forms.CheckBox chbTT1L;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTongtien;
        private System.Windows.Forms.Label lbTTTT;
        private System.Windows.Forms.Label lbDotDTT;
        private System.Windows.Forms.Label lbSoTTT;
        private System.Windows.Forms.Label lbDotTTTD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbTienDTT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNoiDung;
        private System.Windows.Forms.ComboBox cbMaNVTN;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Button btnReturn;
    }
}