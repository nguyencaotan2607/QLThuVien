
namespace QLThuVien
{
    partial class RPSach
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
            this.CRPSach = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRPSach
            // 
            this.CRPSach.ActiveViewIndex = -1;
            this.CRPSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRPSach.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRPSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRPSach.Location = new System.Drawing.Point(0, 0);
            this.CRPSach.Name = "CRPSach";
            this.CRPSach.Size = new System.Drawing.Size(800, 450);
            this.CRPSach.TabIndex = 0;
            // 
            // RPSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRPSach);
            this.Name = "RPSach";
            this.Text = "RPSach";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRPSach;
    }
}