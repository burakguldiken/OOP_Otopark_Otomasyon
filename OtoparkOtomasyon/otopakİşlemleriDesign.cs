namespace OtoparkOtomasyon
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.chkAbone = new System.Windows.Forms.CheckBox();
            this.chkKontak = new System.Windows.Forms.CheckBox();
            this.lstAracTip = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAraclar = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSatisRaporu = new System.Windows.Forms.Button();
            this.lblUcret = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.chkAbone);
            this.groupBox1.Controls.Add(this.chkKontak);
            this.groupBox1.Controls.Add(this.lstAracTip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPlaka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(198, 243);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(92, 40);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // chkAbone
            // 
            this.chkAbone.AutoSize = true;
            this.chkAbone.Location = new System.Drawing.Point(208, 201);
            this.chkAbone.Name = "chkAbone";
            this.chkAbone.Size = new System.Drawing.Size(71, 21);
            this.chkAbone.TabIndex = 5;
            this.chkAbone.Text = "Abone";
            this.chkAbone.UseVisualStyleBackColor = true;
            // 
            // chkKontak
            // 
            this.chkKontak.AutoSize = true;
            this.chkKontak.Location = new System.Drawing.Point(87, 201);
            this.chkKontak.Name = "chkKontak";
            this.chkKontak.Size = new System.Drawing.Size(100, 21);
            this.chkKontak.TabIndex = 4;
            this.chkKontak.Text = "Kontak Var";
            this.chkKontak.UseVisualStyleBackColor = true;
            // 
            // lstAracTip
            // 
            this.lstAracTip.FormattingEnabled = true;
            this.lstAracTip.ItemHeight = 16;
            this.lstAracTip.Location = new System.Drawing.Point(87, 79);
            this.lstAracTip.Name = "lstAracTip";
            this.lstAracTip.Size = new System.Drawing.Size(203, 116);
            this.lstAracTip.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Araç Tipi";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(87, 30);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(203, 22);
            this.txtPlaka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAraclar);
            this.groupBox2.Location = new System.Drawing.Point(385, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 531);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otoparktaki Araçlar";
            // 
            // lstAraclar
            // 
            this.lstAraclar.ContextMenuStrip = this.contextMenuStrip1;
            this.lstAraclar.FormattingEnabled = true;
            this.lstAraclar.ItemHeight = 16;
            this.lstAraclar.Location = new System.Drawing.Point(6, 21);
            this.lstAraclar.Name = "lstAraclar";
            this.lstAraclar.Size = new System.Drawing.Size(544, 516);
            this.lstAraclar.TabIndex = 0;
            this.lstAraclar.SelectedIndexChanged += new System.EventHandler(this.lstAraclar_SelectedIndexChanged);
            this.lstAraclar.ContextMenuStripChanged += new System.EventHandler(this.lstAraclar_ContextMenuStripChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSatisRaporu);
            this.groupBox3.Controls.Add(this.lblUcret);
            this.groupBox3.Controls.Add(this.lblSure);
            this.groupBox3.Controls.Add(this.lblPlaka);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 329);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 227);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Durum";
            // 
            // btnSatisRaporu
            // 
            this.btnSatisRaporu.Location = new System.Drawing.Point(51, 161);
            this.btnSatisRaporu.Name = "btnSatisRaporu";
            this.btnSatisRaporu.Size = new System.Drawing.Size(266, 53);
            this.btnSatisRaporu.TabIndex = 7;
            this.btnSatisRaporu.Text = "Rapor";
            this.btnSatisRaporu.UseVisualStyleBackColor = true;
            this.btnSatisRaporu.Click += new System.EventHandler(this.btnSatisRaporu_Click);
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUcret.Location = new System.Drawing.Point(106, 133);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(52, 25);
            this.lblUcret.TabIndex = 6;
            this.lblUcret.Text = "0 TL";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(106, 82);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(69, 25);
            this.lblSure.TabIndex = 5;
            this.lblSure.Text = "0 Saat";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlaka.Location = new System.Drawing.Point(106, 37);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(105, 25);
            this.lblPlaka.TabIndex = 4;
            this.lblPlaka.Text = "00 XX 000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ücret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Süre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Plaka";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışYapToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 28);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.CikisYap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 597);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox chkAbone;
        private System.Windows.Forms.CheckBox chkKontak;
        private System.Windows.Forms.ListBox lstAracTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstAraclar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSatisRaporu;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}

