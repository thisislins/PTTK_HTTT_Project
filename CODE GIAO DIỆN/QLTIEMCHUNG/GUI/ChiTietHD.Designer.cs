
namespace GUI
{
    partial class ChiTietHD
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
            this.labelTTPDK = new System.Windows.Forms.Label();
            this.numTienHD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaPDK = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.cbMaNVTN = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNoiDung = new System.Windows.Forms.TextBox();
            this.dateNgayLap = new System.Windows.Forms.DateTimePicker();
            this.cbMaHD = new System.Windows.Forms.ComboBox();
            this.lblNgayKham = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.dgvDSCTPDK = new System.Windows.Forms.DataGridView();
            this.btnCapNhatHD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKtra = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnTTTD = new System.Windows.Forms.RadioButton();
            this.rbtnTT1Lan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnTTThe = new System.Windows.Forms.RadioButton();
            this.rbtnTTTienMat = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numTienHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPDK)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTTPDK
            // 
            this.labelTTPDK.AutoSize = true;
            this.labelTTPDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTTPDK.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTTPDK.Location = new System.Drawing.Point(442, 395);
            this.labelTTPDK.Name = "labelTTPDK";
            this.labelTTPDK.Size = new System.Drawing.Size(155, 24);
            this.labelTTPDK.TabIndex = 176;
            this.labelTTPDK.Text = "TỔNG TIỀN PDK";
            // 
            // numTienHD
            // 
            this.numTienHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.numTienHD.Location = new System.Drawing.Point(588, 449);
            this.numTienHD.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numTienHD.Name = "numTienHD";
            this.numTienHD.Size = new System.Drawing.Size(202, 27);
            this.numTienHD.TabIndex = 175;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 20);
            this.label5.TabIndex = 173;
            this.label5.Text = "Số tiền khách thanh toán cho hóa đơn này (VND):";
            // 
            // cbMaPDK
            // 
            this.cbMaPDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbMaPDK.FormattingEnabled = true;
            this.cbMaPDK.ItemHeight = 18;
            this.cbMaPDK.Location = new System.Drawing.Point(350, 104);
            this.cbMaPDK.Name = "cbMaPDK";
            this.cbMaPDK.Size = new System.Drawing.Size(246, 26);
            this.cbMaPDK.TabIndex = 172;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 171;
            this.label4.Text = "Mã phiếu đăng ký: ";
            // 
            // cbMaKH
            // 
            this.cbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.ItemHeight = 18;
            this.cbMaKH.Location = new System.Drawing.Point(350, 136);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(246, 26);
            this.cbMaKH.TabIndex = 170;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 169;
            this.label3.Text = "Mã khách hàng: ";
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.BackColor = System.Drawing.Color.Salmon;
            this.btnXoaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHD.Location = new System.Drawing.Point(664, 680);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(166, 47);
            this.btnXoaHD.TabIndex = 168;
            this.btnXoaHD.Text = "XÓA HÓA ĐƠN";
            this.btnXoaHD.UseVisualStyleBackColor = false;
            this.btnXoaHD.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieu.Location = new System.Drawing.Point(147, 74);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(106, 20);
            this.lblMaPhieu.TabIndex = 167;
            this.lblMaPhieu.Text = "Mã hóa đơn: ";
            // 
            // cbMaNVTN
            // 
            this.cbMaNVTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbMaNVTN.FormattingEnabled = true;
            this.cbMaNVTN.ItemHeight = 18;
            this.cbMaNVTN.Location = new System.Drawing.Point(350, 168);
            this.cbMaNVTN.Name = "cbMaNVTN";
            this.cbMaNVTN.Size = new System.Drawing.Size(246, 26);
            this.cbMaNVTN.TabIndex = 166;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(148, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(243, 20);
            this.label12.TabIndex = 165;
            this.label12.Text = "Tổng tiền phiếu đăng ký (VND):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(641, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 164;
            this.label11.Text = "Nội dung:";
            // 
            // tbNoiDung
            // 
            this.tbNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoiDung.Location = new System.Drawing.Point(743, 158);
            this.tbNoiDung.Name = "tbNoiDung";
            this.tbNoiDung.Size = new System.Drawing.Size(251, 30);
            this.tbNoiDung.TabIndex = 163;
            // 
            // dateNgayLap
            // 
            this.dateNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayLap.Location = new System.Drawing.Point(743, 110);
            this.dateNgayLap.MaxDate = new System.DateTime(2022, 4, 30, 0, 0, 0, 0);
            this.dateNgayLap.Name = "dateNgayLap";
            this.dateNgayLap.Size = new System.Drawing.Size(251, 24);
            this.dateNgayLap.TabIndex = 161;
            this.dateNgayLap.Value = new System.DateTime(2022, 4, 27, 0, 0, 0, 0);
            // 
            // cbMaHD
            // 
            this.cbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaHD.FormattingEnabled = true;
            this.cbMaHD.ItemHeight = 18;
            this.cbMaHD.Location = new System.Drawing.Point(350, 72);
            this.cbMaHD.Name = "cbMaHD";
            this.cbMaHD.Size = new System.Drawing.Size(246, 26);
            this.cbMaHD.TabIndex = 160;
            this.cbMaHD.SelectedIndexChanged += new System.EventHandler(this.cbMaHD_SelectedIndexChanged);
            // 
            // lblNgayKham
            // 
            this.lblNgayKham.AutoSize = true;
            this.lblNgayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKham.Location = new System.Drawing.Point(641, 114);
            this.lblNgayKham.Name = "lblNgayKham";
            this.lblNgayKham.Size = new System.Drawing.Size(79, 20);
            this.lblNgayKham.TabIndex = 159;
            this.lblNgayKham.Text = "Ngày lập:";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(147, 170);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(187, 20);
            this.lblMaKH.TabIndex = 158;
            this.lblMaKH.Text = "Mã nhân viên thu ngân: ";
            // 
            // dgvDSCTPDK
            // 
            this.dgvDSCTPDK.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSCTPDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCTPDK.Location = new System.Drawing.Point(151, 236);
            this.dgvDSCTPDK.Name = "dgvDSCTPDK";
            this.dgvDSCTPDK.RowHeadersWidth = 51;
            this.dgvDSCTPDK.RowTemplate.Height = 24;
            this.dgvDSCTPDK.Size = new System.Drawing.Size(843, 130);
            this.dgvDSCTPDK.TabIndex = 157;
            // 
            // btnCapNhatHD
            // 
            this.btnCapNhatHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCapNhatHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatHD.Location = new System.Drawing.Point(271, 680);
            this.btnCapNhatHD.Name = "btnCapNhatHD";
            this.btnCapNhatHD.Size = new System.Drawing.Size(205, 47);
            this.btnCapNhatHD.TabIndex = 156;
            this.btnCapNhatHD.Text = "CẬP NHẬT HÓA ĐƠN";
            this.btnCapNhatHD.UseVisualStyleBackColor = false;
            this.btnCapNhatHD.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(458, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 29);
            this.label2.TabIndex = 155;
            this.label2.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 154;
            // 
            // btnKtra
            // 
            this.btnKtra.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnKtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKtra.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnKtra.Location = new System.Drawing.Point(623, 65);
            this.btnKtra.Name = "btnKtra";
            this.btnKtra.Size = new System.Drawing.Size(98, 33);
            this.btnKtra.TabIndex = 177;
            this.btnKtra.Text = "Tìm kiếm";
            this.btnKtra.UseVisualStyleBackColor = false;
            this.btnKtra.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(147, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 24);
            this.label7.TabIndex = 178;
            this.label7.Text = "CHI TIẾT PHIẾU ĐĂNG KÝ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(163, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 20);
            this.label8.TabIndex = 180;
            this.label8.Text = "Phương thức thanh toán:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(693, 522);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 20);
            this.label9.TabIndex = 181;
            this.label9.Text = "Hình thức thanh toán:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(-2, -3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(113, 30);
            this.btnReturn.TabIndex = 206;
            this.btnReturn.Text = "Trở lại";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnTTTD);
            this.groupBox2.Controls.Add(this.rbtnTT1Lan);
            this.groupBox2.Location = new System.Drawing.Point(201, 555);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 81);
            this.groupBox2.TabIndex = 212;
            this.groupBox2.TabStop = false;
            // 
            // rbtnTTTD
            // 
            this.rbtnTTTD.AutoSize = true;
            this.rbtnTTTD.Location = new System.Drawing.Point(8, 49);
            this.rbtnTTTD.Name = "rbtnTTTD";
            this.rbtnTTTD.Size = new System.Drawing.Size(158, 21);
            this.rbtnTTTD.TabIndex = 206;
            this.rbtnTTTD.TabStop = true;
            this.rbtnTTTD.Text = "Thanh toán theo đợt";
            this.rbtnTTTD.UseVisualStyleBackColor = true;
            // 
            // rbtnTT1Lan
            // 
            this.rbtnTT1Lan.AutoSize = true;
            this.rbtnTT1Lan.Location = new System.Drawing.Point(10, 12);
            this.rbtnTT1Lan.Name = "rbtnTT1Lan";
            this.rbtnTT1Lan.Size = new System.Drawing.Size(137, 21);
            this.rbtnTT1Lan.TabIndex = 205;
            this.rbtnTT1Lan.TabStop = true;
            this.rbtnTT1Lan.Text = "Thanh toán 1 lần";
            this.rbtnTT1Lan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnTTThe);
            this.groupBox1.Controls.Add(this.rbtnTTTienMat);
            this.groupBox1.Location = new System.Drawing.Point(728, 555);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 84);
            this.groupBox1.TabIndex = 211;
            this.groupBox1.TabStop = false;
            // 
            // rbtnTTThe
            // 
            this.rbtnTTThe.AutoSize = true;
            this.rbtnTTThe.Location = new System.Drawing.Point(9, 49);
            this.rbtnTTThe.Name = "rbtnTTThe";
            this.rbtnTTThe.Size = new System.Drawing.Size(162, 21);
            this.rbtnTTThe.TabIndex = 208;
            this.rbtnTTThe.TabStop = true;
            this.rbtnTTThe.Text = "Thanh toán bằng thẻ";
            this.rbtnTTThe.UseVisualStyleBackColor = true;
            // 
            // rbtnTTTienMat
            // 
            this.rbtnTTTienMat.AutoSize = true;
            this.rbtnTTTienMat.Location = new System.Drawing.Point(9, 13);
            this.rbtnTTTienMat.Name = "rbtnTTTienMat";
            this.rbtnTTTienMat.Size = new System.Drawing.Size(192, 21);
            this.rbtnTTTienMat.TabIndex = 207;
            this.rbtnTTTienMat.TabStop = true;
            this.rbtnTTTienMat.Text = "Thanh toán bằng tiền mặt";
            this.rbtnTTTienMat.UseVisualStyleBackColor = true;
            // 
            // ChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 784);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnKtra);
            this.Controls.Add(this.labelTTPDK);
            this.Controls.Add(this.numTienHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMaPDK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMaKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXoaHD);
            this.Controls.Add(this.lblMaPhieu);
            this.Controls.Add(this.cbMaNVTN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbNoiDung);
            this.Controls.Add(this.dateNgayLap);
            this.Controls.Add(this.cbMaHD);
            this.Controls.Add(this.lblNgayKham);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.dgvDSCTPDK);
            this.Controls.Add(this.btnCapNhatHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChiTietHD";
            this.Text = "CTHoaDon";
            this.Load += new System.EventHandler(this.CTHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTienHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTPDK)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTTPDK;
        private System.Windows.Forms.NumericUpDown numTienHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaPDK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.ComboBox cbMaNVTN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNoiDung;
        private System.Windows.Forms.DateTimePicker dateNgayLap;
        private System.Windows.Forms.ComboBox cbMaHD;
        private System.Windows.Forms.Label lblNgayKham;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.DataGridView dgvDSCTPDK;
        private System.Windows.Forms.Button btnCapNhatHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKtra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnTTTD;
        private System.Windows.Forms.RadioButton rbtnTT1Lan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnTTThe;
        private System.Windows.Forms.RadioButton rbtnTTTienMat;
    }
}