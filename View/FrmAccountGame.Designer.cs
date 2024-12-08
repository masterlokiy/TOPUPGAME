namespace TOPUPGAME.View
{
    partial class FrmAccountGame
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
            this.lblDaftarkeLogin = new System.Windows.Forms.Label();
            this.lvwAkunUserGame = new System.Windows.Forms.ListView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDaftarkeLogin
            // 
            this.lblDaftarkeLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDaftarkeLogin.AutoSize = true;
            this.lblDaftarkeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaftarkeLogin.ForeColor = System.Drawing.Color.Blue;
            this.lblDaftarkeLogin.Location = new System.Drawing.Point(1051, 485);
            this.lblDaftarkeLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDaftarkeLogin.Name = "lblDaftarkeLogin";
            this.lblDaftarkeLogin.Size = new System.Drawing.Size(50, 20);
            this.lblDaftarkeLogin.TabIndex = 37;
            this.lblDaftarkeLogin.Text = "Login";
            // 
            // lvwAkunUserGame
            // 
            this.lvwAkunUserGame.HideSelection = false;
            this.lvwAkunUserGame.Location = new System.Drawing.Point(29, 38);
            this.lvwAkunUserGame.Margin = new System.Windows.Forms.Padding(4);
            this.lvwAkunUserGame.Name = "lvwAkunUserGame";
            this.lvwAkunUserGame.Size = new System.Drawing.Size(876, 309);
            this.lvwAkunUserGame.TabIndex = 39;
            this.lvwAkunUserGame.UseCompatibleStateImageBehavior = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(55, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 16);
            this.linkLabel1.TabIndex = 38;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "< Kembali";
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(29, 391);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 28);
            this.btnTambah.TabIndex = 40;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(152, 391);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 28);
            this.btnHapus.TabIndex = 41;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHapus);
            this.groupBox1.Controls.Add(this.btnTambah);
            this.groupBox1.Controls.Add(this.lvwAkunUserGame);
            this.groupBox1.Location = new System.Drawing.Point(29, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(936, 434);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Account Game";
            // 
            // FrmAccountGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(157)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(991, 614);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblDaftarkeLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAccountGame";
            this.Text = "FrmAccountGame";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDaftarkeLogin;
        private System.Windows.Forms.ListView lvwAkunUserGame;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}