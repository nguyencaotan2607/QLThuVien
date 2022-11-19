
namespace QLThuVien
{
    partial class RPNhanVien
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
            this.CRPNhanVien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRPNhanVien
            // 
            this.CRPNhanVien.ActiveViewIndex = -1;
            this.CRPNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRPNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRPNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRPNhanVien.Location = new System.Drawing.Point(0, 0);
            this.CRPNhanVien.Name = "CRPNhanVien";
            this.CRPNhanVien.Size = new System.Drawing.Size(800, 450);
            this.CRPNhanVien.TabIndex = 0;
            // 
            // RPNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRPNhanVien);
            this.Name = "RPNhanVien";
            this.Text = "RPNhanVien";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRPNhanVien;
    }
}