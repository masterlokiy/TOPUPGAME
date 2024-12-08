namespace TOPUPGAME.View
{
    partial class FrmBuatPesanan
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
            this.lblKembali = new System.Windows.Forms.LinkLabel();
            this.cmbaug = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHargaProduk = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblNamaProduk = new System.Windows.Forms.Label();
            this.picImageProduk = new System.Windows.Forms.PictureBox();
            this.btnBuatPesanan = new System.Windows.Forms.Button();
            this.picLogoGame = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoGame)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKembali
            // 
            this.lblKembali.AutoSize = true;
            this.lblKembali.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKembali.LinkColor = System.Drawing.Color.Black;
            this.lblKembali.Location = new System.Drawing.Point(33, 25);
            this.lblKembali.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKembali.Name = "lblKembali";
            this.lblKembali.Size = new System.Drawing.Size(53, 14);
            this.lblKembali.TabIndex = 39;
            this.lblKembali.TabStop = true;
            this.lblKembali.Text = "< Kembali";
            this.lblKembali.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblKembali_LinkClicked);
            // 
            // cmbaug
            // 
            this.cmbaug.FormattingEnabled = true;
            this.cmbaug.Location = new System.Drawing.Point(92, 246);
            this.cmbaug.Name = "cmbaug";
            this.cmbaug.Size = new System.Drawing.Size(188, 21);
            this.cmbaug.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.lblHargaProduk);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.lblNamaProduk);
            this.panel1.Controls.Add(this.picImageProduk);
            this.panel1.Location = new System.Drawing.Point(418, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 280);
            this.panel1.TabIndex = 42;
            // 
            // lblHargaProduk
            // 
            this.lblHargaProduk.AutoSize = true;
            this.lblHargaProduk.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHargaProduk.Location = new System.Drawing.Point(109, 208);
            this.lblHargaProduk.Name = "lblHargaProduk";
            this.lblHargaProduk.Size = new System.Drawing.Size(82, 14);
            this.lblHargaProduk.TabIndex = 48;
            this.lblHargaProduk.Text = "Mobile Legends";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(128, 242);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 18);
            this.btnNext.TabIndex = 47;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblNamaProduk
            // 
            this.lblNamaProduk.AutoSize = true;
            this.lblNamaProduk.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaProduk.Location = new System.Drawing.Point(109, 187);
            this.lblNamaProduk.Name = "lblNamaProduk";
            this.lblNamaProduk.Size = new System.Drawing.Size(82, 14);
            this.lblNamaProduk.TabIndex = 45;
            this.lblNamaProduk.Text = "Mobile Legends";
            // 
            // picImageProduk
            // 
            this.picImageProduk.Image = global::TOPUPGAME.Properties.Resources.R;
            this.picImageProduk.Location = new System.Drawing.Point(14, 16);
            this.picImageProduk.Name = "picImageProduk";
            this.picImageProduk.Size = new System.Drawing.Size(265, 150);
            this.picImageProduk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageProduk.TabIndex = 44;
            this.picImageProduk.TabStop = false;
            // 
            // btnBuatPesanan
            // 
            this.btnBuatPesanan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuatPesanan.Location = new System.Drawing.Point(329, 370);
            this.btnBuatPesanan.Name = "btnBuatPesanan";
            this.btnBuatPesanan.Size = new System.Drawing.Size(113, 31);
            this.btnBuatPesanan.TabIndex = 43;
            this.btnBuatPesanan.Text = "Buat Pesanan";
            this.btnBuatPesanan.UseVisualStyleBackColor = true;
            this.btnBuatPesanan.Click += new System.EventHandler(this.btnBuatPesanan_Click);
            // 
            // picLogoGame
            // 
            this.picLogoGame.Image = global::TOPUPGAME.Properties.Resources.maxresdefault;
            this.picLogoGame.Location = new System.Drawing.Point(92, 118);
            this.picLogoGame.Name = "picLogoGame";
            this.picLogoGame.Size = new System.Drawing.Size(188, 109);
            this.picLogoGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoGame.TabIndex = 41;
            this.picLogoGame.TabStop = false;
            // 
            // FrmBuatPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(157)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuatPesanan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picLogoGame);
            this.Controls.Add(this.cmbaug);
            this.Controls.Add(this.lblKembali);
            this.Name = "FrmBuatPesanan";
            this.Text = "FrmBuatPesanan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageProduk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblKembali;
        private System.Windows.Forms.ComboBox cmbaug;
        private System.Windows.Forms.PictureBox picLogoGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picImageProduk;
        private System.Windows.Forms.Button btnBuatPesanan;
        private System.Windows.Forms.Label lblNamaProduk;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblHargaProduk;
    }
}