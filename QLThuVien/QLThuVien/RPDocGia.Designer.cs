
namespace QLThuVien
{
    partial class RPDocGia
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
            this.CRPDocGia = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRPDocGia
            // 
            this.CRPDocGia.ActiveViewIndex = -1;
            this.CRPDocGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRPDocGia.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRPDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRPDocGia.Location = new System.Drawing.Point(0, 0);
            this.CRPDocGia.Name = "CRPDocGia";
            this.CRPDocGia.Size = new System.Drawing.Size(800, 450);
            this.CRPDocGia.TabIndex = 0;
            // 
            // RPDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CRPDocGia);
            this.Name = "RPDocGia";
            this.Text = "RPDocGia";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRPDocGia;
    }
}