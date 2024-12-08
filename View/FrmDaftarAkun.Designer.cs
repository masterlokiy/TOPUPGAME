namespace TOPUPGAME
{
    partial class FrmDaftarAkun
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
            this.lblKodeVerifikasi = new System.Windows.Forms.Label();
            this.lbltittleBuatAkun = new System.Windows.Forms.Label();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.lblDaftarEmail = new System.Windows.Forms.Label();
            this.lblDaftarUsername = new System.Windows.Forms.Label();
            this.txtDaftarUsername = new System.Windows.Forms.TextBox();
            this.txtDaftarEmail = new System.Windows.Forms.TextBox();
            this.lblDaftarkeLogin = new System.Windows.Forms.Label();
            this.lblDaftarNomor = new System.Windows.Forms.Label();
            this.lblDaftarPassword = new System.Windows.Forms.Label();
            this.txtDaftarPassword = new System.Windows.Forms.TextBox();
            this.txtDaftarNomor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblKodeVerifikasi
            // 
            this.lblKodeVerifikasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKodeVerifikasi.AutoSize = true;
            this.lblKodeVerifikasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKodeVerifikasi.Location = new System.Drawing.Point(546, 185);
            this.lblKodeVerifikasi.Name = "lblKodeVerifikasi";
            this.lblKodeVerifikasi.Size = new System.Drawing.Size(120, 17);
            this.lblKodeVerifikasi.TabIndex = 31;
            this.lblKodeVerifikasi.Text = "Sudah ada akun?";
            // 
            // lbltittleBuatAkun
            // 
            this.lbltittleBuatAkun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltittleBuatAkun.AutoSize = true;
            this.lbltittleBuatAkun.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltittleBuatAkun.Location = new System.Drawing.Point(466, 104);
            this.lbltittleBuatAkun.Name = "lbltittleBuatAkun";
            this.lbltittleBuatAkun.Size = new System.Drawing.Size(349, 54);
            this.lbltittleBuatAkun.TabIndex = 30;
            this.lbltittleBuatAkun.Text = "Buat Akun Baru";
            // 
            // btnDaftar
            // 
            this.btnDaftar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDaftar.FlatAppearance.BorderSize = 8;
            this.btnDaftar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftar.Location = new System.Drawing.Point(578, 501);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(113, 39);
            this.btnDaftar.TabIndex = 29;
            this.btnDaftar.Text = "Lanjut";
            this.btnDaftar.UseVisualStyleBackColor = true;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // lblDaftarEmail
            // 
            this.lblDaftarEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDaftarEmail.AutoSize = true;
            this.lblDaftarEmail.Location = new System.Drawing.Point(355, 273);
            this.lblDaftarEmail.Name = "lblDaftarEmail";
            this.lblDaftarEmail.Size = new System.Drawing.Size(32, 13);
            this.lblDaftarEmail.TabIndex = 27;
            this.lblDaftarEmail.Text = "Email";
            // 
            // lblDaftarUsername
            // 
            this.lblDaftarUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDaftarUsername.AutoSize = true;
            this.lblDaftarUsername.Location = new System.Drawing.Point(355, 201);
            this.lblDaftarUsername.Name = "lblDaftarUsername";
            this.lblDaftarUsername.Size = new System.Drawing.Size(55, 13);
            this.lblDaftarUsername.TabIndex = 26;
            this.lblDaftarUsername.Text = "Username";
            // 
            // txtDaftarUsername
            // 
            this.txtDaftarUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDaftarUsername.Location = new System.Drawing.Point(352, 224);
            this.txtDaftarUsername.Name = "txtDaftarUsername";
            this.txtDaftarUsername.Size = new System.Drawing.Size(548, 20);
            this.txtDaftarUsername.TabIndex = 24;
            // 
            // txtDaftarEmail
            // 
            this.txtDaftarEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDaftarEmail.Location = new System.Drawing.Point(352, 296);
            this.txtDaftarEmail.Name = "txtDaftarEmail";
            this.txtDaftarEmail.Size = new System.Drawing.Size(548, 20);
            this.txtDaftarEmail.TabIndex = 25;
            // 
            // lblDaftarkeLogin
            // 
            this.lblDaftarkeLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDaftarkeLogin.AutoSize = true;
            this.lblDaftarkeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaftarkeLogin.ForeColor = System.Drawing.Color.Blue;
            this.lblDaftarkeLogin.Location = new System.Drawing.Point(672, 185);
            this.lblDaftarkeLogin.Name = "lblDaftarkeLogin";
            this.lblDaftarkeLogin.Size = new System.Drawing.Size(43, 17);
            this.lblDaftarkeLogin.TabIndex = 32;
            this.lblDaftarkeLogin.Text = "Login";
            this.lblDaftarkeLogin.Click += new System.EventHandler(this.lblDaftarkeLogin_Click);
            // 
            // lblDaftarNomor
            // 
            this.lblDaftarNomor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDaftarNomor.AutoSize = true;
            this.lblDaftarNomor.Location = new System.Drawing.Point(355, 424);
            this.lblDaftarNomor.Name = "lblDaftarNomor";
            this.lblDaftarNomor.Size = new System.Drawing.Size(80, 13);
            this.lblDaftarNomor.TabIndex = 36;
            this.lblDaftarNomor.Text = "Nomor Telepon";
            // 
            // lblDaftarPassword
            // 
            this.lblDaftarPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDaftarPassword.AutoSize = true;
            this.lblDaftarPassword.Location = new System.Drawing.Point(355, 352);
            this.lblDaftarPassword.Name = "lblDaftarPassword";
            this.lblDaftarPassword.Size = new System.Drawing.Size(53, 13);
            this.lblDaftarPassword.TabIndex = 35;
            this.lblDaftarPassword.Text = "Password";
            // 
            // txtDaftarPassword
            // 
            this.txtDaftarPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDaftarPassword.Location = new System.Drawing.Point(352, 375);
            this.txtDaftarPassword.Name = "txtDaftarPassword";
            this.txtDaftarPassword.Size = new System.Drawing.Size(548, 20);
            this.txtDaftarPassword.TabIndex = 33;
            // 
            // txtDaftarNomor
            // 
            this.txtDaftarNomor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDaftarNomor.Location = new System.Drawing.Point(352, 447);
            this.txtDaftarNomor.Name = "txtDaftarNomor";
            this.txtDaftarNomor.Size = new System.Drawing.Size(548, 20);
            this.txtDaftarNomor.TabIndex = 34;
            // 
            // FrmDaftarAkun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 659);
            this.Controls.Add(this.lblDaftarNomor);
            this.Controls.Add(this.lblDaftarPassword);
            this.Controls.Add(this.txtDaftarPassword);
            this.Controls.Add(this.txtDaftarNomor);
            this.Controls.Add(this.lblDaftarkeLogin);
            this.Controls.Add(this.lblKodeVerifikasi);
            this.Controls.Add(this.lbltittleBuatAkun);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(this.lblDaftarEmail);
            this.Controls.Add(this.lblDaftarUsername);
            this.Controls.Add(this.txtDaftarUsername);
            this.Controls.Add(this.txtDaftarEmail);
            this.Name = "FrmDaftarAkun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDaftarAkun";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDaftarAkun_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKodeVerifikasi;
        private System.Windows.Forms.Label lbltittleBuatAkun;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.Label lblDaftarEmail;
        private System.Windows.Forms.Label lblDaftarUsername;
        private System.Windows.Forms.TextBox txtDaftarUsername;
        private System.Windows.Forms.TextBox txtDaftarEmail;
        private System.Windows.Forms.Label lblDaftarkeLogin;
        private System.Windows.Forms.Label lblDaftarNomor;
        private System.Windows.Forms.Label lblDaftarPassword;
        private System.Windows.Forms.TextBox txtDaftarPassword;
        private System.Windows.Forms.TextBox txtDaftarNomor;
    }
}