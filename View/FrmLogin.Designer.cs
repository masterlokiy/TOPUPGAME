namespace TOPUPGAME
{
    partial class frmlogin
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsernameEmail = new System.Windows.Forms.TextBox();
            this.lblUsernameEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLupaPassword = new System.Windows.Forms.Label();
            this.lblDaftarAkun = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTopUp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(342, 448);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(548, 20);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsernameEmail
            // 
            this.txtUsernameEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsernameEmail.Location = new System.Drawing.Point(342, 376);
            this.txtUsernameEmail.Name = "txtUsernameEmail";
            this.txtUsernameEmail.Size = new System.Drawing.Size(548, 20);
            this.txtUsernameEmail.TabIndex = 0;
            // 
            // lblUsernameEmail
            // 
            this.lblUsernameEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsernameEmail.AutoSize = true;
            this.lblUsernameEmail.Location = new System.Drawing.Point(345, 360);
            this.lblUsernameEmail.Name = "lblUsernameEmail";
            this.lblUsernameEmail.Size = new System.Drawing.Size(85, 13);
            this.lblUsernameEmail.TabIndex = 3;
            this.lblUsernameEmail.Text = "Username/Email";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(345, 432);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblLupaPassword
            // 
            this.lblLupaPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLupaPassword.AutoSize = true;
            this.lblLupaPassword.Location = new System.Drawing.Point(345, 484);
            this.lblLupaPassword.Name = "lblLupaPassword";
            this.lblLupaPassword.Size = new System.Drawing.Size(86, 13);
            this.lblLupaPassword.TabIndex = 6;
            this.lblLupaPassword.Text = "Lupa Password?";
            this.lblLupaPassword.Click += new System.EventHandler(this.lblLupaPassword_Click);
            this.lblLupaPassword.MouseEnter += new System.EventHandler(this.lblLupaPassword_MouseEnter);
            this.lblLupaPassword.MouseLeave += new System.EventHandler(this.lblLupaPassword_MouseLeave);
            // 
            // lblDaftarAkun
            // 
            this.lblDaftarAkun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDaftarAkun.AutoSize = true;
            this.lblDaftarAkun.Location = new System.Drawing.Point(345, 523);
            this.lblDaftarAkun.Name = "lblDaftarAkun";
            this.lblDaftarAkun.Size = new System.Drawing.Size(64, 13);
            this.lblDaftarAkun.TabIndex = 7;
            this.lblDaftarAkun.Text = "Daftar Akun";
            this.lblDaftarAkun.Click += new System.EventHandler(this.lblDaftarAkun_Click);
            this.lblDaftarAkun.MouseEnter += new System.EventHandler(this.lblDaftarAkun_MouseEnter);
            this.lblDaftarAkun.MouseLeave += new System.EventHandler(this.lblDaftarAkun_MouseLeave);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.FlatAppearance.BorderSize = 8;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(777, 497);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 39);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::TOPUPGAME.Properties.Resources.best_minecraft_seeds_badlands_seed;
            this.pictureBox1.Location = new System.Drawing.Point(342, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblTopUp
            // 
            this.lblTopUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTopUp.AutoSize = true;
            this.lblTopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopUp.Location = new System.Drawing.Point(477, 310);
            this.lblTopUp.Name = "lblTopUp";
            this.lblTopUp.Size = new System.Drawing.Size(298, 46);
            this.lblTopUp.TabIndex = 12;
            this.lblTopUp.Text = "TOP UP GAME";
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 659);
            this.Controls.Add(this.lblTopUp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblDaftarAkun);
            this.Controls.Add(this.lblLupaPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsernameEmail);
            this.Controls.Add(this.txtUsernameEmail);
            this.Controls.Add(this.txtPassword);
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Pemesanan Top Up Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmlogin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmlogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsernameEmail;
        private System.Windows.Forms.Label lblUsernameEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLupaPassword;
        private System.Windows.Forms.Label lblDaftarAkun;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTopUp;
    }
}

