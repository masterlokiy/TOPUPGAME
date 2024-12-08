namespace TOPUPGAME.View
{
    partial class FrmEntryAccountGame
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
            this.btnTambah = new System.Windows.Forms.Button();
            this.cmbNamaGame = new System.Windows.Forms.ComboBox();
            this.txtIDAkun = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(300, 223);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 28);
            this.btnTambah.TabIndex = 41;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // cmbNamaGame
            // 
            this.cmbNamaGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNamaGame.FormattingEnabled = true;
            this.cmbNamaGame.Items.AddRange(new object[] {
            "Free Fire",
            "Call Of Duty",
            "PUBG Mobile",
            "Mobile Legend",
            "Valorant"});
            this.cmbNamaGame.Location = new System.Drawing.Point(45, 146);
            this.cmbNamaGame.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNamaGame.Name = "cmbNamaGame";
            this.cmbNamaGame.Size = new System.Drawing.Size(613, 24);
            this.cmbNamaGame.TabIndex = 42;
            // 
            // txtIDAkun
            // 
            this.txtIDAkun.Location = new System.Drawing.Point(45, 79);
            this.txtIDAkun.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDAkun.Name = "txtIDAkun";
            this.txtIDAkun.Size = new System.Drawing.Size(613, 22);
            this.txtIDAkun.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIDAkun);
            this.groupBox1.Controls.Add(this.cmbNamaGame);
            this.groupBox1.Controls.Add(this.btnTambah);
            this.groupBox1.Location = new System.Drawing.Point(181, 134);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(715, 271);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entry Account Game";
            // 
            // FrmEntryAccountGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(157)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEntryAccountGame";
            this.Text = "FrmEntryAccountGame";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.ComboBox cmbNamaGame;
        private System.Windows.Forms.TextBox txtIDAkun;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}