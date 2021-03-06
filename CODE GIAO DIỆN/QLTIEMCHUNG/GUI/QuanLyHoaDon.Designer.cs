
namespace GUI
{
    partial class QuanLyHoaDon
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
            this.dgvQLHD = new System.Windows.Forms.DataGridView();
            this.btnXemCTHD = new System.Windows.Forms.Button();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQLHD
            // 
            this.dgvQLHD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQLHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLHD.Location = new System.Drawing.Point(20, 85);
            this.dgvQLHD.Name = "dgvQLHD";
            this.dgvQLHD.RowHeadersWidth = 51;
            this.dgvQLHD.RowTemplate.Height = 24;
            this.dgvQLHD.Size = new System.Drawing.Size(940, 393);
            this.dgvQLHD.TabIndex = 120;
            // 
            // btnXemCTHD
            // 
            this.btnXemCTHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXemCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemCTHD.Location = new System.Drawing.Point(411, 528);
            this.btnXemCTHD.Name = "btnXemCTHD";
            this.btnXemCTHD.Size = new System.Drawing.Size(219, 52);
            this.btnXemCTHD.TabIndex = 119;
            this.btnXemCTHD.Text = "Xem chi tiết hóa đơn";
            this.btnXemCTHD.UseVisualStyleBackColor = false;
            this.btnXemCTHD.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTaoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHD.Location = new System.Drawing.Point(20, 529);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(155, 51);
            this.btnTaoHD.TabIndex = 118;
            this.btnTaoHD.Text = "Tạo hóa đơn";
            this.btnTaoHD.UseVisualStyleBackColor = false;
            this.btnTaoHD.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(377, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 29);
            this.label2.TabIndex = 117;
            this.label2.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 116;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(3, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(113, 30);
            this.btnReturn.TabIndex = 205;
            this.btnReturn.Text = "Trở lại";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvQLHD);
            this.Controls.Add(this.btnXemCTHD);
            this.Controls.Add(this.btnTaoHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyHoaDon";
            this.Text = "QLHoaDon";
            this.Load += new System.EventHandler(this.QLHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvQLHD;
        private System.Windows.Forms.Button btnXemCTHD;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
    }
}