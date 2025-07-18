namespace WindowsFormsApp5
{
    partial class FrmLiderler
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblBasliq = new System.Windows.Forms.Label();
            this.lstLiderler = new System.Windows.Forms.ListBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBasliq
            // 
            this.lblBasliq.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBasliq.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasliq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBasliq.Location = new System.Drawing.Point(230, 16);
            this.lblBasliq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBasliq.Name = "lblBasliq";
            this.lblBasliq.Size = new System.Drawing.Size(306, 31);
            this.lblBasliq.TabIndex = 0;
            this.lblBasliq.Text = "Liderlər Cədvəli";
            this.lblBasliq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstLiderler
            // 
            this.lstLiderler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLiderler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstLiderler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLiderler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstLiderler.FormattingEnabled = true;
            this.lstLiderler.ItemHeight = 21;
            this.lstLiderler.Location = new System.Drawing.Point(19, 61);
            this.lstLiderler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstLiderler.Name = "lstLiderler";
            this.lstLiderler.Size = new System.Drawing.Size(728, 296);
            this.lstLiderler.TabIndex = 1;
            // 
            // btnGeri
            // 
            this.btnGeri.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(316, 374);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(135, 32);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // FrmLiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(768, 431);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lstLiderler);
            this.Controls.Add(this.lblBasliq);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(342, 470);
            this.Name = "FrmLiderler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liderlər Cədvəli";
            this.Load += new System.EventHandler(this.FrmLiderler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBasliq;
        private System.Windows.Forms.ListBox lstLiderler;
        private System.Windows.Forms.Button btnGeri;
    }
}