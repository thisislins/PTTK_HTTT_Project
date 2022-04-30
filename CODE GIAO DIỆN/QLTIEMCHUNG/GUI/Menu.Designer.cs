
namespace GUI
{
    partial class Menu
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
            this.btnQLSTC = new System.Windows.Forms.Button();
            this.btnQLHD = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnQLDSDM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQLPhieuKham = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLSTC
            // 
            this.btnQLSTC.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQLSTC.ForeColor = System.Drawing.Color.White;
            this.btnQLSTC.Location = new System.Drawing.Point(425, 161);
            this.btnQLSTC.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLSTC.Name = "btnQLSTC";
            this.btnQLSTC.Size = new System.Drawing.Size(212, 49);
            this.btnQLSTC.TabIndex = 29;
            this.btnQLSTC.Text = "Quản lý sổ tiêm chủng";
            this.btnQLSTC.UseVisualStyleBackColor = false;
            this.btnQLSTC.Click += new System.EventHandler(this.btnQLSTC_Click);
            // 
            // btnQLHD
            // 
            this.btnQLHD.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQLHD.ForeColor = System.Drawing.Color.White;
            this.btnQLHD.Location = new System.Drawing.Point(425, 229);
            this.btnQLHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Size = new System.Drawing.Size(212, 49);
            this.btnQLHD.TabIndex = 28;
            this.btnQLHD.Text = "Quản lý hóa đơn";
            this.btnQLHD.UseVisualStyleBackColor = false;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(425, 300);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(212, 49);
            this.btnThanhToan.TabIndex = 27;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // btnQLDSDM
            // 
            this.btnQLDSDM.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQLDSDM.ForeColor = System.Drawing.Color.White;
            this.btnQLDSDM.Location = new System.Drawing.Point(425, 370);
            this.btnQLDSDM.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLDSDM.Name = "btnQLDSDM";
            this.btnQLDSDM.Size = new System.Drawing.Size(212, 49);
            this.btnQLDSDM.TabIndex = 26;
            this.btnQLDSDM.Text = "Quản lý danh sách đặt mua";
            this.btnQLDSDM.UseVisualStyleBackColor = false;
            this.btnQLDSDM.Click += new System.EventHandler(this.btnQLDSDM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(316, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(40, 12, 40, 12);
            this.label1.Size = new System.Drawing.Size(410, 49);
            this.label1.TabIndex = 25;
            this.label1.Text = "HỆ THỐNG TIÊM CHỦNG AN BÌNH";
            // 
            // btnQLPhieuKham
            // 
            this.btnQLPhieuKham.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQLPhieuKham.ForeColor = System.Drawing.Color.White;
            this.btnQLPhieuKham.Location = new System.Drawing.Point(425, 443);
            this.btnQLPhieuKham.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLPhieuKham.Name = "btnQLPhieuKham";
            this.btnQLPhieuKham.Size = new System.Drawing.Size(212, 49);
            this.btnQLPhieuKham.TabIndex = 30;
            this.btnQLPhieuKham.Text = "Quản lý phiếu khám";
            this.btnQLPhieuKham.UseVisualStyleBackColor = false;
            this.btnQLPhieuKham.Click += new System.EventHandler(this.btnQLPhieuKham_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnQLPhieuKham);
            this.Controls.Add(this.btnQLSTC);
            this.Controls.Add(this.btnQLHD);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnQLDSDM);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQLSTC;
        private System.Windows.Forms.Button btnQLHD;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnQLDSDM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQLPhieuKham;
    }
}