
namespace GUI
{
    partial class XoaSoTiemChung
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
            this.btnXoaSTC = new System.Windows.Forms.Button();
            this.txtPU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateNgayTiem = new System.Windows.Forms.DateTimePicker();
            this.lbNgayTiem = new System.Windows.Forms.Label();
            this.btnDSVac = new System.Windows.Forms.Label();
            this.btnMaKH = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbVaccine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnXoaSTC
            // 
            this.btnXoaSTC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoaSTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSTC.ForeColor = System.Drawing.Color.White;
            this.btnXoaSTC.Location = new System.Drawing.Point(235, 376);
            this.btnXoaSTC.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaSTC.Name = "btnXoaSTC";
            this.btnXoaSTC.Size = new System.Drawing.Size(223, 37);
            this.btnXoaSTC.TabIndex = 118;
            this.btnXoaSTC.Text = "Xóa sổ tiêm chủng";
            this.btnXoaSTC.UseVisualStyleBackColor = false;
            this.btnXoaSTC.Click += new System.EventHandler(this.btnXoaSTC_Click);
            // 
            // txtPU
            // 
            this.txtPU.Location = new System.Drawing.Point(37, 335);
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(608, 22);
            this.txtPU.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 116;
            this.label1.Text = "PHẢN ỨNG";
            // 
            // dateNgayTiem
            // 
            this.dateNgayTiem.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayTiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayTiem.Location = new System.Drawing.Point(190, 225);
            this.dateNgayTiem.Name = "dateNgayTiem";
            this.dateNgayTiem.Size = new System.Drawing.Size(315, 27);
            this.dateNgayTiem.TabIndex = 115;
            // 
            // lbNgayTiem
            // 
            this.lbNgayTiem.AutoSize = true;
            this.lbNgayTiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayTiem.Location = new System.Drawing.Point(40, 229);
            this.lbNgayTiem.Name = "lbNgayTiem";
            this.lbNgayTiem.Size = new System.Drawing.Size(99, 20);
            this.lbNgayTiem.TabIndex = 114;
            this.lbNgayTiem.Text = "NGÀY TIÊM";
            // 
            // btnDSVac
            // 
            this.btnDSVac.AutoSize = true;
            this.btnDSVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSVac.Location = new System.Drawing.Point(40, 170);
            this.btnDSVac.Name = "btnDSVac";
            this.btnDSVac.Size = new System.Drawing.Size(82, 20);
            this.btnDSVac.TabIndex = 113;
            this.btnDSVac.Text = "VACCINE";
            // 
            // btnMaKH
            // 
            this.btnMaKH.AutoSize = true;
            this.btnMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaKH.Location = new System.Drawing.Point(40, 114);
            this.btnMaKH.Name = "btnMaKH";
            this.btnMaKH.Size = new System.Drawing.Size(123, 20);
            this.btnMaKH.TabIndex = 111;
            this.btnMaKH.Text = "KHÁCH HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(193, 21);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.label2.Size = new System.Drawing.Size(302, 53);
            this.label2.TabIndex = 110;
            this.label2.Text = "XÓA SỔ TIÊM CHỦNG";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.Location = new System.Drawing.Point(194, 115);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(133, 20);
            this.lbMaKH.TabIndex = 121;
            this.lbMaKH.Text = "KHÁCH HÀNG";
            // 
            // lbVaccine
            // 
            this.lbVaccine.AutoSize = true;
            this.lbVaccine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVaccine.Location = new System.Drawing.Point(194, 170);
            this.lbVaccine.Name = "lbVaccine";
            this.lbVaccine.Size = new System.Drawing.Size(76, 20);
            this.lbVaccine.TabIndex = 122;
            this.lbVaccine.Text = "Vaccine";
            // 
            // XoaSoTiemChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 437);
            this.Controls.Add(this.lbVaccine);
            this.Controls.Add(this.lbMaKH);
            this.Controls.Add(this.btnXoaSTC);
            this.Controls.Add(this.txtPU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateNgayTiem);
            this.Controls.Add(this.lbNgayTiem);
            this.Controls.Add(this.btnDSVac);
            this.Controls.Add(this.btnMaKH);
            this.Controls.Add(this.label2);
            this.Name = "XoaSoTiemChung";
            this.Text = "XoaSoTiemChung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XoaSoTiemChung_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXoaSTC;
        private System.Windows.Forms.TextBox txtPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateNgayTiem;
        private System.Windows.Forms.Label lbNgayTiem;
        private System.Windows.Forms.Label btnDSVac;
        private System.Windows.Forms.Label btnMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbVaccine;
    }
}