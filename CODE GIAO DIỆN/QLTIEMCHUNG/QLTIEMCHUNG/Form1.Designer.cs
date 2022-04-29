
namespace QLTIEMCHUNG
{
    partial class Form1
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
            this.myFlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // myFlowLayoutPanel1
            // 
            this.myFlowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.myFlowLayoutPanel1.Name = "myFlowLayoutPanel1";
            this.myFlowLayoutPanel1.Size = new System.Drawing.Size(1038, 729);
            this.myFlowLayoutPanel1.TabIndex = 0;
            this.myFlowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.myFlowLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 753);
            this.Controls.Add(this.myFlowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel myFlowLayoutPanel1;
    }
}

