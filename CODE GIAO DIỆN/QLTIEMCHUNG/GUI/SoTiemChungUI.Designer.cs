
namespace GUI
{
    partial class SoTiemChungUI
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
            this.dgvSTCKH = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTCKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSTCKH
            // 
            this.dgvSTCKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSTCKH.Location = new System.Drawing.Point(45, 98);
            this.dgvSTCKH.Name = "dgvSTCKH";
            this.dgvSTCKH.RowHeadersWidth = 51;
            this.dgvSTCKH.RowTemplate.Height = 24;
            this.dgvSTCKH.Size = new System.Drawing.Size(701, 126);
            this.dgvSTCKH.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(273, 24);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.label2.Size = new System.Drawing.Size(245, 53);
            this.label2.TabIndex = 77;
            this.label2.Text = "SỔ TIÊM CHỦNG";
            // 
            // SoTiemChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 249);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSTCKH);
            this.Name = "SoTiemChung";
            this.Text = "SoTiemChung";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTCKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSTCKH;
        private System.Windows.Forms.Label label2;
    }
}