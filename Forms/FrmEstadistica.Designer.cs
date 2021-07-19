
namespace QuickFood.Forms
{
    partial class FrmEstadistica
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
            this.pnlGráfica2 = new System.Windows.Forms.Panel();
            this.pnlGráfica1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlGráfica2
            // 
            this.pnlGráfica2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlGráfica2.Location = new System.Drawing.Point(540, 12);
            this.pnlGráfica2.Name = "pnlGráfica2";
            this.pnlGráfica2.Size = new System.Drawing.Size(528, 588);
            this.pnlGráfica2.TabIndex = 8;
            this.pnlGráfica2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGráfica2_Paint);
            // 
            // pnlGráfica1
            // 
            this.pnlGráfica1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlGráfica1.Location = new System.Drawing.Point(12, 12);
            this.pnlGráfica1.Name = "pnlGráfica1";
            this.pnlGráfica1.Size = new System.Drawing.Size(522, 588);
            this.pnlGráfica1.TabIndex = 7;
            this.pnlGráfica1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGráfica1_Paint);
            // 
            // FrmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.pnlGráfica2);
            this.Controls.Add(this.pnlGráfica1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstadistica";
            this.Text = "Meseros";
            this.Load += new System.EventHandler(this.FrmEstadistica_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGráfica2;
        private System.Windows.Forms.Panel pnlGráfica1;
    }
}