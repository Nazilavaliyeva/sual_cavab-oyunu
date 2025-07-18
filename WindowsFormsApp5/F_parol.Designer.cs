namespace WindowsFormsApp5
{
    partial class F_parol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_parol));
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtyenisifre = new System.Windows.Forms.TextBox();
            this.txtsifretekrar = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblyenisifre = new System.Windows.Forms.Label();
            this.lblsifretekrari = new System.Windows.Forms.Label();
            this.btntesdiqs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(30, 49);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(301, 29);
            this.txtemail.TabIndex = 0;
            // 
            // txtyenisifre
            // 
            this.txtyenisifre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtyenisifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyenisifre.Location = new System.Drawing.Point(30, 110);
            this.txtyenisifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtyenisifre.Name = "txtyenisifre";
            this.txtyenisifre.PasswordChar = '●';
            this.txtyenisifre.Size = new System.Drawing.Size(301, 29);
            this.txtyenisifre.TabIndex = 1;
            // 
            // txtsifretekrar
            // 
            this.txtsifretekrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsifretekrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsifretekrar.Location = new System.Drawing.Point(30, 171);
            this.txtsifretekrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsifretekrar.Name = "txtsifretekrar";
            this.txtsifretekrar.PasswordChar = '●';
            this.txtsifretekrar.Size = new System.Drawing.Size(301, 29);
            this.txtsifretekrar.TabIndex = 2;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblemail.Location = new System.Drawing.Point(27, 28);
            this.lblemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(47, 19);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "E-mail";
            // 
            // lblyenisifre
            // 
            this.lblyenisifre.AutoSize = true;
            this.lblyenisifre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyenisifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblyenisifre.Location = new System.Drawing.Point(27, 89);
            this.lblyenisifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblyenisifre.Name = "lblyenisifre";
            this.lblyenisifre.Size = new System.Drawing.Size(63, 19);
            this.lblyenisifre.TabIndex = 4;
            this.lblyenisifre.Text = "Yeni şifrə";
            this.lblyenisifre.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblsifretekrari
            // 
            this.lblsifretekrari.AutoSize = true;
            this.lblsifretekrari.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsifretekrari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblsifretekrari.Location = new System.Drawing.Point(27, 150);
            this.lblsifretekrari.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsifretekrari.Name = "lblsifretekrari";
            this.lblsifretekrari.Size = new System.Drawing.Size(97, 19);
            this.lblsifretekrari.TabIndex = 5;
            this.lblsifretekrari.Text = "Şifrənin təkrarı";
            // 
            // btntesdiqs
            // 
            this.btntesdiqs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btntesdiqs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btntesdiqs.FlatAppearance.BorderSize = 0;
            this.btntesdiqs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntesdiqs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntesdiqs.ForeColor = System.Drawing.Color.White;
            this.btntesdiqs.Location = new System.Drawing.Point(30, 224);
            this.btntesdiqs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntesdiqs.Name = "btntesdiqs";
            this.btntesdiqs.Size = new System.Drawing.Size(300, 37);
            this.btntesdiqs.TabIndex = 3;
            this.btntesdiqs.Text = "Təsdiqlə";
            this.btntesdiqs.UseVisualStyleBackColor = false;
            this.btntesdiqs.Click += new System.EventHandler(this.btntesdiqs_Click_1);
            // 
            // F_parol
            // 
            this.AcceptButton = this.btntesdiqs;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 293);
            this.Controls.Add(this.lblsifretekrari);
            this.Controls.Add(this.lblyenisifre);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.btntesdiqs);
            this.Controls.Add(this.txtsifretekrar);
            this.Controls.Add(this.txtyenisifre);
            this.Controls.Add(this.txtemail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(379, 332);
            this.Name = "F_parol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifrəni Dəyişdir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtyenisifre;
        private System.Windows.Forms.TextBox txtsifretekrar;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblyenisifre;
        private System.Windows.Forms.Label lblsifretekrari;
        private System.Windows.Forms.Button btntesdiqs;
    }
}