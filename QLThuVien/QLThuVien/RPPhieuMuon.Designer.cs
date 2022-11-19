
namespace QLThuVien
{
    partial class RPPhieuMuon
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
            this.CRPPhieuMuon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRPPhieuMuon
            // 
            this.CRPPhieuMuon.ActiveViewIndex = -1;
            this.CRPPhieuMuon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRPPhieuMuon.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRPPhieuMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRPPhieuMuon.Location = new System.Drawing.Point(0, 0);
            this.CRPPhieuMuon.Name = "CRPPhieuMuon";
            this.CRPPhieuMuon.Size = new System.Drawing.Size(800, 450);
            this.CRPPhieuMuon.TabIndex = 0;
            // 
            // RPPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRPPhieuMuon);
            this.Name = "RPPhieuMuon";
            this.Text = "RPPhieuMuon";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRPPhieuMuon;
    }
}