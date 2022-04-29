
namespace GUI
{
    partial class QLPhieuKham
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMaPK = new System.Windows.Forms.Label();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.numHuyetAp = new System.Windows.Forms.NumericUpDown();
            this.numNhipTim = new System.Windows.Forms.NumericUpDown();
            this.numNhietDo = new System.Windows.Forms.NumericUpDown();
            this.cbBS = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbKetLuan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateNgayKham = new System.Windows.Forms.DateTimePicker();
            this.cbKH = new System.Windows.Forms.ComboBox();
            this.lblNgayKham = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.dgvDSPhieuKham = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHuyetAp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNhipTim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNhietDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuKham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 31;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Salmon;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(841, 294);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 40);
            this.btnReset.TabIndex = 98;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMaPK
            // 
            this.lblMaPK.AutoSize = true;
            this.lblMaPK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPK.Location = new System.Drawing.Point(255, 299);
            this.lblMaPK.Name = "lblMaPK";
            this.lblMaPK.Size = new System.Drawing.Size(159, 25);
            this.lblMaPK.TabIndex = 97;
            this.lblMaPK.Text = "Mã phiếu khám";
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieu.Location = new System.Drawing.Point(109, 304);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(132, 20);
            this.lblMaPhieu.TabIndex = 96;
            this.lblMaPhieu.Text = "Mã phiếu khám: ";
            // 
            // numHuyetAp
            // 
            this.numHuyetAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numHuyetAp.Location = new System.Drawing.Point(202, 571);
            this.numHuyetAp.Name = "numHuyetAp";
            this.numHuyetAp.Size = new System.Drawing.Size(86, 30);
            this.numHuyetAp.TabIndex = 95;
            // 
            // numNhipTim
            // 
            this.numNhipTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numNhipTim.Location = new System.Drawing.Point(202, 529);
            this.numNhipTim.Name = "numNhipTim";
            this.numNhipTim.Size = new System.Drawing.Size(86, 30);
            this.numNhipTim.TabIndex = 94;
            // 
            // numNhietDo
            // 
            this.numNhietDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numNhietDo.Location = new System.Drawing.Point(202, 489);
            this.numNhietDo.Name = "numNhietDo";
            this.numNhietDo.Size = new System.Drawing.Size(86, 30);
            this.numNhietDo.TabIndex = 93;
            // 
            // cbBS
            // 
            this.cbBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBS.FormattingEnabled = true;
            this.cbBS.ItemHeight = 25;
            this.cbBS.Location = new System.Drawing.Point(632, 568);
            this.cbBS.Name = "cbBS";
            this.cbBS.Size = new System.Drawing.Size(270, 33);
            this.cbBS.TabIndex = 92;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(461, 581);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 20);
            this.label12.TabIndex = 91;
            this.label12.Text = "Bác sĩ phụ trách:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(461, 499);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 90;
            this.label11.Text = "Kết luận:";
            // 
            // tbKetLuan
            // 
            this.tbKetLuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKetLuan.Location = new System.Drawing.Point(553, 489);
            this.tbKetLuan.Name = "tbKetLuan";
            this.tbKetLuan.Size = new System.Drawing.Size(349, 30);
            this.tbKetLuan.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(107, 581);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 88;
            this.label10.Text = "Huyết áp:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(108, 539);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 87;
            this.label9.Text = "Nhịp tim:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(108, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 86;
            this.label8.Text = "Nhiệt độ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(461, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 85;
            this.label7.Text = "KẾT LUẬN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 24);
            this.label6.TabIndex = 84;
            this.label6.Text = "KẾT QUẢ KHÁM";
            // 
            // dateNgayKham
            // 
            this.dateNgayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayKham.Location = new System.Drawing.Point(260, 390);
            this.dateNgayKham.MaxDate = new System.DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.Now.Day, 0, 0, 0, 0);
            this.dateNgayKham.Name = "dateNgayKham";
            this.dateNgayKham.Size = new System.Drawing.Size(328, 28);
            this.dateNgayKham.TabIndex = 83;
            this.dateNgayKham.Value = new System.DateTime(2022, 4, 27, 0, 0, 0, 0);
            // 
            // cbKH
            // 
            this.cbKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKH.FormattingEnabled = true;
            this.cbKH.ItemHeight = 25;
            this.cbKH.Location = new System.Drawing.Point(260, 340);
            this.cbKH.Name = "cbKH";
            this.cbKH.Size = new System.Drawing.Size(200, 33);
            this.cbKH.TabIndex = 82;
            // 
            // lblNgayKham
            // 
            this.lblNgayKham.AutoSize = true;
            this.lblNgayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKham.Location = new System.Drawing.Point(109, 399);
            this.lblNgayKham.Name = "lblNgayKham";
            this.lblNgayKham.Size = new System.Drawing.Size(97, 20);
            this.lblNgayKham.TabIndex = 81;
            this.lblNgayKham.Text = "Ngày khám:";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(108, 353);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(132, 20);
            this.lblMaKH.TabIndex = 80;
            this.lblMaKH.Text = "Mã khách hàng: ";
            // 
            // dgvDSPhieuKham
            // 
            this.dgvDSPhieuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhieuKham.Location = new System.Drawing.Point(24, 104);
            this.dgvDSPhieuKham.Name = "dgvDSPhieuKham";
            this.dgvDSPhieuKham.RowHeadersWidth = 51;
            this.dgvDSPhieuKham.RowTemplate.Height = 24;
            this.dgvDSPhieuKham.Size = new System.Drawing.Size(940, 163);
            this.dgvDSPhieuKham.TabIndex = 79;
            this.dgvDSPhieuKham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhieuKham_CellContentClick);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(838, 58);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 40);
            this.btnXoa.TabIndex = 78;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(709, 58);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(123, 40);
            this.btnSua.TabIndex = 77;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(580, 58);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 40);
            this.btnThem.TabIndex = 76;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(329, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 29);
            this.label2.TabIndex = 75;
            this.label2.Text = "QUẢN LÝ PHIẾU KHÁM";
            // 
            // QLPhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblMaPK);
            this.Controls.Add(this.lblMaPhieu);
            this.Controls.Add(this.numHuyetAp);
            this.Controls.Add(this.numNhipTim);
            this.Controls.Add(this.numNhietDo);
            this.Controls.Add(this.cbBS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbKetLuan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateNgayKham);
            this.Controls.Add(this.cbKH);
            this.Controls.Add(this.lblNgayKham);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.dgvDSPhieuKham);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QLPhieuKham";
            this.Text = "QLPhieuKham";
            this.Load += new System.EventHandler(this.QLPhieuKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHuyetAp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNhipTim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNhietDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuKham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMaPK;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.NumericUpDown numHuyetAp;
        private System.Windows.Forms.NumericUpDown numNhipTim;
        private System.Windows.Forms.NumericUpDown numNhietDo;
        private System.Windows.Forms.ComboBox cbBS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbKetLuan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateNgayKham;
        private System.Windows.Forms.ComboBox cbKH;
        private System.Windows.Forms.Label lblNgayKham;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.DataGridView dgvDSPhieuKham;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
    }
}