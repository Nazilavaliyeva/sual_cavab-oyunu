namespace WindowsFormsApp5
{
    partial class FrmKateqoriyaSecimi
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
            this.btnMentiq = new System.Windows.Forms.Button();
            this.btnUmumiBilik = new System.Windows.Forms.Button();
            this.btnQarisiq = new System.Windows.Forms.Button();
            this.btnLiderler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBasliq
            // 
            this.lblBasliq.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBasliq.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasliq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBasliq.Location = new System.Drawing.Point(9, 9);
            this.lblBasliq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBasliq.Name = "lblBasliq";
            this.lblBasliq.Size = new System.Drawing.Size(354, 62);
            this.lblBasliq.TabIndex = 0;
            this.lblBasliq.Text = "Zəhmət olmasa, bir kateqoriya seçin";
            this.lblBasliq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMentiq
            // 
            this.btnMentiq.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMentiq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnMentiq.FlatAppearance.BorderSize = 0;
            this.btnMentiq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMentiq.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMentiq.ForeColor = System.Drawing.Color.White;
            this.btnMentiq.Location = new System.Drawing.Point(82, 73);
            this.btnMentiq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMentiq.Name = "btnMentiq";
            this.btnMentiq.Size = new System.Drawing.Size(210, 41);
            this.btnMentiq.TabIndex = 1;
            this.btnMentiq.Text = "Məntiq";
            this.btnMentiq.UseVisualStyleBackColor = false;
            this.btnMentiq.Click += new System.EventHandler(this.btnKateqoriya_Click);
            // 
            // btnUmumiBilik
            // 
            this.btnUmumiBilik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUmumiBilik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnUmumiBilik.FlatAppearance.BorderSize = 0;
            this.btnUmumiBilik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUmumiBilik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUmumiBilik.ForeColor = System.Drawing.Color.White;
            this.btnUmumiBilik.Location = new System.Drawing.Point(82, 122);
            this.btnUmumiBilik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUmumiBilik.Name = "btnUmumiBilik";
            this.btnUmumiBilik.Size = new System.Drawing.Size(210, 41);
            this.btnUmumiBilik.TabIndex = 2;
            this.btnUmumiBilik.Text = "Ümumi Bilik";
            this.btnUmumiBilik.UseVisualStyleBackColor = false;
            this.btnUmumiBilik.Click += new System.EventHandler(this.btnKateqoriya_Click);
            // 
            // btnQarisiq
            // 
            this.btnQarisiq.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQarisiq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnQarisiq.FlatAppearance.BorderSize = 0;
            this.btnQarisiq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQarisiq.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQarisiq.ForeColor = System.Drawing.Color.White;
            this.btnQarisiq.Location = new System.Drawing.Point(82, 171);
            this.btnQarisiq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQarisiq.Name = "btnQarisiq";
            this.btnQarisiq.Size = new System.Drawing.Size(210, 41);
            this.btnQarisiq.TabIndex = 3;
            this.btnQarisiq.Text = "Qarışıq";
            this.btnQarisiq.UseVisualStyleBackColor = false;
            this.btnQarisiq.Click += new System.EventHandler(this.btnKateqoriya_Click);
            // 
            // btnLiderler
            // 
            this.btnLiderler.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLiderler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLiderler.FlatAppearance.BorderSize = 0;
            this.btnLiderler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiderler.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiderler.ForeColor = System.Drawing.Color.White;
            this.btnLiderler.Location = new System.Drawing.Point(82, 236);
            this.btnLiderler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLiderler.Name = "btnLiderler";
            this.btnLiderler.Size = new System.Drawing.Size(210, 32);
            this.btnLiderler.TabIndex = 4;
            this.btnLiderler.Text = "Liderlər Cədvəli";
            this.btnLiderler.UseVisualStyleBackColor = false;
            this.btnLiderler.Click += new System.EventHandler(this.btnLiderler_Click);
            // 
            // FrmKateqoriyaSecimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 303);
            this.Controls.Add(this.btnLiderler);
            this.Controls.Add(this.btnQarisiq);
            this.Controls.Add(this.btnUmumiBilik);
            this.Controls.Add(this.btnMentiq);
            this.Controls.Add(this.lblBasliq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmKateqoriyaSecimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kateqoriya Seçimi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBasliq;
        private System.Windows.Forms.Button btnMentiq;
        private System.Windows.Forms.Button btnUmumiBilik;
        private System.Windows.Forms.Button btnQarisiq;
        private System.Windows.Forms.Button btnLiderler;
    }
}