namespace TOPUPGAME
{
    partial class FrmVerifikasiDaftar
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
            this.lblKirimUlangKodeVerifikasi = new System.Windows.Forms.Label();
            this.lblKodeVerifikasi = new System.Windows.Forms.Label();
            this.lbltittleKodeVerifyDAFTAR = new System.Windows.Forms.Label();
            this.btnMencariEmail = new System.Windows.Forms.Button();
            this.lblEmailLupaPasswordPart1 = new System.Windows.Forms.Label();
            this.txtEmailLupaPasswordPart1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblKirimUlangKodeVerifikasi
            // 
            this.lblKirimUlangKodeVerifikasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKirimUlangKodeVerifikasi.AutoSize = true;
            this.lblKirimUlangKodeVerifikasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKirimUlangKodeVerifikasi.ForeColor = System.Drawing.Color.Blue;
            this.lblKirimUlangKodeVerifikasi.Location = new System.Drawing.Point(526, 392);
            this.lblKirimUlangKodeVerifikasi.Name = "lblKirimUlangKodeVerifikasi";
            this.lblKirimUlangKodeVerifikasi.Size = new System.Drawing.Size(179, 17);
            this.lblKirimUlangKodeVerifikasi.TabIndex = 28;
            this.lblKirimUlangKodeVerifikasi.Text = "Kirim ulang kode verifikassi";
            // 
            // lblKodeVerifikasi
            // 
            this.lblKodeVerifikasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKodeVerifikasi.AutoSize = true;
            this.lblKodeVerifikasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKodeVerifikasi.Location = new System.Drawing.Point(543, 300);
            this.lblKodeVerifikasi.Name = "lblKodeVerifikasi";
            this.lblKodeVerifikasi.Size = new System.Drawing.Size(162, 17);
            this.lblKodeVerifikasi.TabIndex = 36;
            this.lblKodeVerifikasi.Text = "MASUKAN EMAIL KAMU";
            // 
            // lbltittleKodeVerifyDAFTAR
            // 
            this.lbltittleKodeVerifyDAFTAR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltittleKodeVerifyDAFTAR.AutoSize = true;
            this.lbltittleKodeVerifyDAFTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltittleKodeVerifyDAFTAR.Location = new System.Drawing.Point(440, 223);
            this.lbltittleKodeVerifyDAFTAR.Name = "lbltittleKodeVerifyDAFTAR";
            this.lbltittleKodeVerifyDAFTAR.Size = new System.Drawing.Size(372, 54);
            this.lbltittleKodeVerifyDAFTAR.TabIndex = 35;
            this.lbltittleKodeVerifyDAFTAR.Text = "Lupa Password?";
            // 
            // btnMencariEmail
            // 
            this.btnMencariEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMencariEmail.FlatAppearance.BorderSize = 8;
            this.btnMencariEmail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMencariEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMencariEmail.Location = new System.Drawing.Point(546, 421);
            this.btnMencariEmail.Name = "btnMencariEmail";
            this.btnMencariEmail.Size = new System.Drawing.Size(140, 39);
            this.btnMencariEmail.TabIndex = 34;
            this.btnMencariEmail.Text = "Mencari Email";
            this.btnMencariEmail.UseVisualStyleBackColor = true;
            // 
            // lblEmailLupaPasswordPart1
            // 
            this.lblEmailLupaPasswordPart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailLupaPasswordPart1.AutoSize = true;
            this.lblEmailLupaPasswordPart1.Location = new System.Drawing.Point(345, 325);
            this.lblEmailLupaPasswordPart1.Name = "lblEmailLupaPasswordPart1";
            this.lblEmailLupaPasswordPart1.Size = new System.Drawing.Size(32, 13);
            this.lblEmailLupaPasswordPart1.TabIndex = 33;
            this.lblEmailLupaPasswordPart1.Text = "Email";
            // 
            // txtEmailLupaPasswordPart1
            // 
            this.txtEmailLupaPasswordPart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailLupaPasswordPart1.Location = new System.Drawing.Point(342, 348);
            this.txtEmailLupaPasswordPart1.Name = "txtEmailLupaPasswordPart1";
            this.txtEmailLupaPasswordPart1.Size = new System.Drawing.Size(548, 20);
            this.txtEmailLupaPasswordPart1.TabIndex = 32;
            // 
            // FrmVerifikasiDaftar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 659);
            this.Controls.Add(this.lblKodeVerifikasi);
            this.Controls.Add(this.lbltittleKodeVerifyDAFTAR);
            this.Controls.Add(this.btnMencariEmail);
            this.Controls.Add(this.lblEmailLupaPasswordPart1);
            this.Controls.Add(this.txtEmailLupaPasswordPart1);
            this.Controls.Add(this.lblKirimUlangKodeVerifikasi);
            this.Name = "FrmVerifikasiDaftar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.FrmMasukSebagaiAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKirimUlangKodeVerifikasi;
        private System.Windows.Forms.Label lblKodeVerifikasi;
        private System.Windows.Forms.Label lbltittleKodeVerifyDAFTAR;
        private System.Windows.Forms.Button btnMencariEmail;
        private System.Windows.Forms.Label lblEmailLupaPasswordPart1;
        private System.Windows.Forms.TextBox txtEmailLupaPasswordPart1;
    }
}