
namespace GUI
{
    partial class CTPhieuDat
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
            this.CTPDGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CTPDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CTPDGrid
            // 
            this.CTPDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CTPDGrid.Location = new System.Drawing.Point(26, 46);
            this.CTPDGrid.Name = "CTPDGrid";
            this.CTPDGrid.Size = new System.Drawing.Size(569, 150);
            this.CTPDGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHI TIẾT PHIẾU ĐẶT";
            // 
            // CTPhieuDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CTPDGrid);
            this.Name = "CTPhieuDat";
            this.Text = "CTPhieuDat";
            ((System.ComponentModel.ISupportInitialize)(this.CTPDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CTPDGrid;
        private System.Windows.Forms.Label label1;
    }
}