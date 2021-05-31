namespace B191210071_EzgiBAGCIK_projeodevi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbAtiklar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPuan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSure = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBarOrganik = new System.Windows.Forms.ProgressBar();
            this.btnOrgBosalt = new System.Windows.Forms.Button();
            this.btnOrganikAtik = new System.Windows.Forms.Button();
            this.lbOrganikAtik = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pBarKagit = new System.Windows.Forms.ProgressBar();
            this.btnKagitBosalt = new System.Windows.Forms.Button();
            this.btnKagit = new System.Windows.Forms.Button();
            this.lbKagit = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pBarCam = new System.Windows.Forms.ProgressBar();
            this.btnCamBosalt = new System.Windows.Forms.Button();
            this.btnCam = new System.Windows.Forms.Button();
            this.lbCam = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pBarMetal = new System.Windows.Forms.ProgressBar();
            this.btnMetalBosalt = new System.Windows.Forms.Button();
            this.btnMetal = new System.Windows.Forms.Button();
            this.lbMetal = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAtiklar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAtiklar
            // 
            this.pbAtiklar.BackColor = System.Drawing.Color.White;
            this.pbAtiklar.Location = new System.Drawing.Point(12, 12);
            this.pbAtiklar.Name = "pbAtiklar";
            this.pbAtiklar.Size = new System.Drawing.Size(191, 147);
            this.pbAtiklar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAtiklar.TabIndex = 0;
            this.pbAtiklar.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lbPuan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbSure);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCikis);
            this.groupBox1.Controls.Add(this.btnYeniOyun);
            this.groupBox1.Location = new System.Drawing.Point(12, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 298);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lbPuan
            // 
            this.lbPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPuan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbPuan.Location = new System.Drawing.Point(6, 179);
            this.lbPuan.Name = "lbPuan";
            this.lbPuan.Size = new System.Drawing.Size(179, 41);
            this.lbPuan.TabIndex = 5;
            this.lbPuan.Text = "0";
            this.lbPuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "PUAN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSure
            // 
            this.lbSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSure.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbSure.Location = new System.Drawing.Point(6, 104);
            this.lbSure.Name = "lbSure";
            this.lbSure.Size = new System.Drawing.Size(179, 39);
            this.lbSure.TabIndex = 3;
            this.lbSure.Text = "0";
            this.lbSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "SÜRE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCikis.Location = new System.Drawing.Point(6, 238);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(179, 54);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyun.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnYeniOyun.Location = new System.Drawing.Point(6, 9);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(179, 55);
            this.btnYeniOyun.TabIndex = 0;
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pBarOrganik);
            this.panel1.Controls.Add(this.btnOrgBosalt);
            this.panel1.Controls.Add(this.btnOrganikAtik);
            this.panel1.Controls.Add(this.lbOrganikAtik);
            this.panel1.Location = new System.Drawing.Point(248, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 207);
            this.panel1.TabIndex = 2;
            // 
            // pBarOrganik
            // 
            this.pBarOrganik.ForeColor = System.Drawing.Color.DarkGreen;
            this.pBarOrganik.Location = new System.Drawing.Point(16, 153);
            this.pBarOrganik.Name = "pBarOrganik";
            this.pBarOrganik.Size = new System.Drawing.Size(100, 21);
            this.pBarOrganik.TabIndex = 3;
            // 
            // btnOrgBosalt
            // 
            this.btnOrgBosalt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnOrgBosalt.Enabled = false;
            this.btnOrgBosalt.Location = new System.Drawing.Point(16, 180);
            this.btnOrgBosalt.Name = "btnOrgBosalt";
            this.btnOrgBosalt.Size = new System.Drawing.Size(102, 27);
            this.btnOrgBosalt.TabIndex = 2;
            this.btnOrgBosalt.Text = "BOŞALT";
            this.btnOrgBosalt.UseVisualStyleBackColor = false;
            this.btnOrgBosalt.Click += new System.EventHandler(this.btnOrgBosalt_Click);
            // 
            // btnOrganikAtik
            // 
            this.btnOrganikAtik.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnOrganikAtik.Enabled = false;
            this.btnOrganikAtik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrganikAtik.Location = new System.Drawing.Point(16, 3);
            this.btnOrganikAtik.Name = "btnOrganikAtik";
            this.btnOrganikAtik.Size = new System.Drawing.Size(102, 27);
            this.btnOrganikAtik.TabIndex = 1;
            this.btnOrganikAtik.Text = "ORGANİK ATIK";
            this.btnOrganikAtik.UseVisualStyleBackColor = false;
            this.btnOrganikAtik.Click += new System.EventHandler(this.btnOrganikAtik_Click);
            // 
            // lbOrganikAtik
            // 
            this.lbOrganikAtik.FormattingEnabled = true;
            this.lbOrganikAtik.Location = new System.Drawing.Point(16, 39);
            this.lbOrganikAtik.Name = "lbOrganikAtik";
            this.lbOrganikAtik.Size = new System.Drawing.Size(102, 108);
            this.lbOrganikAtik.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.pBarKagit);
            this.panel2.Controls.Add(this.btnKagitBosalt);
            this.panel2.Controls.Add(this.btnKagit);
            this.panel2.Controls.Add(this.lbKagit);
            this.panel2.Location = new System.Drawing.Point(401, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 207);
            this.panel2.TabIndex = 3;
            // 
            // pBarKagit
            // 
            this.pBarKagit.ForeColor = System.Drawing.Color.DarkGreen;
            this.pBarKagit.Location = new System.Drawing.Point(14, 153);
            this.pBarKagit.Name = "pBarKagit";
            this.pBarKagit.Size = new System.Drawing.Size(100, 21);
            this.pBarKagit.TabIndex = 3;
            // 
            // btnKagitBosalt
            // 
            this.btnKagitBosalt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnKagitBosalt.Enabled = false;
            this.btnKagitBosalt.Location = new System.Drawing.Point(14, 180);
            this.btnKagitBosalt.Name = "btnKagitBosalt";
            this.btnKagitBosalt.Size = new System.Drawing.Size(102, 27);
            this.btnKagitBosalt.TabIndex = 2;
            this.btnKagitBosalt.Text = "BOŞALT";
            this.btnKagitBosalt.UseVisualStyleBackColor = false;
            this.btnKagitBosalt.Click += new System.EventHandler(this.btnKagitBosalt_Click);
            // 
            // btnKagit
            // 
            this.btnKagit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnKagit.Enabled = false;
            this.btnKagit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKagit.Location = new System.Drawing.Point(14, 3);
            this.btnKagit.Name = "btnKagit";
            this.btnKagit.Size = new System.Drawing.Size(102, 27);
            this.btnKagit.TabIndex = 1;
            this.btnKagit.Text = "KAĞIT";
            this.btnKagit.UseVisualStyleBackColor = false;
            this.btnKagit.Click += new System.EventHandler(this.btnKagit_Click);
            // 
            // lbKagit
            // 
            this.lbKagit.FormattingEnabled = true;
            this.lbKagit.Location = new System.Drawing.Point(14, 36);
            this.lbKagit.Name = "lbKagit";
            this.lbKagit.Size = new System.Drawing.Size(102, 108);
            this.lbKagit.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.pBarCam);
            this.panel3.Controls.Add(this.btnCamBosalt);
            this.panel3.Controls.Add(this.btnCam);
            this.panel3.Controls.Add(this.lbCam);
            this.panel3.Location = new System.Drawing.Point(248, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 207);
            this.panel3.TabIndex = 4;
            // 
            // pBarCam
            // 
            this.pBarCam.ForeColor = System.Drawing.Color.DarkGreen;
            this.pBarCam.Location = new System.Drawing.Point(18, 151);
            this.pBarCam.Name = "pBarCam";
            this.pBarCam.Size = new System.Drawing.Size(100, 21);
            this.pBarCam.TabIndex = 3;
            // 
            // btnCamBosalt
            // 
            this.btnCamBosalt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCamBosalt.Enabled = false;
            this.btnCamBosalt.Location = new System.Drawing.Point(16, 180);
            this.btnCamBosalt.Name = "btnCamBosalt";
            this.btnCamBosalt.Size = new System.Drawing.Size(102, 27);
            this.btnCamBosalt.TabIndex = 2;
            this.btnCamBosalt.Text = "BOŞALT";
            this.btnCamBosalt.UseVisualStyleBackColor = false;
            this.btnCamBosalt.Click += new System.EventHandler(this.btnCamBosalt_Click);
            // 
            // btnCam
            // 
            this.btnCam.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCam.Enabled = false;
            this.btnCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCam.Location = new System.Drawing.Point(16, 3);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(102, 27);
            this.btnCam.TabIndex = 1;
            this.btnCam.Text = "CAM";
            this.btnCam.UseVisualStyleBackColor = false;
            this.btnCam.Click += new System.EventHandler(this.btnCam_Click);
            // 
            // lbCam
            // 
            this.lbCam.FormattingEnabled = true;
            this.lbCam.Location = new System.Drawing.Point(16, 36);
            this.lbCam.Name = "lbCam";
            this.lbCam.Size = new System.Drawing.Size(102, 108);
            this.lbCam.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.pBarMetal);
            this.panel4.Controls.Add(this.btnMetalBosalt);
            this.panel4.Controls.Add(this.btnMetal);
            this.panel4.Controls.Add(this.lbMetal);
            this.panel4.Location = new System.Drawing.Point(401, 277);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(133, 207);
            this.panel4.TabIndex = 5;
            // 
            // pBarMetal
            // 
            this.pBarMetal.ForeColor = System.Drawing.Color.DarkGreen;
            this.pBarMetal.Location = new System.Drawing.Point(14, 151);
            this.pBarMetal.Name = "pBarMetal";
            this.pBarMetal.Size = new System.Drawing.Size(100, 21);
            this.pBarMetal.TabIndex = 3;
            // 
            // btnMetalBosalt
            // 
            this.btnMetalBosalt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMetalBosalt.Enabled = false;
            this.btnMetalBosalt.Location = new System.Drawing.Point(14, 180);
            this.btnMetalBosalt.Name = "btnMetalBosalt";
            this.btnMetalBosalt.Size = new System.Drawing.Size(102, 27);
            this.btnMetalBosalt.TabIndex = 2;
            this.btnMetalBosalt.Text = "BOŞALT";
            this.btnMetalBosalt.UseVisualStyleBackColor = false;
            this.btnMetalBosalt.Click += new System.EventHandler(this.btnMetalBosalt_Click);
            // 
            // btnMetal
            // 
            this.btnMetal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMetal.Enabled = false;
            this.btnMetal.Location = new System.Drawing.Point(14, 3);
            this.btnMetal.Name = "btnMetal";
            this.btnMetal.Size = new System.Drawing.Size(102, 27);
            this.btnMetal.TabIndex = 1;
            this.btnMetal.Text = "METAL";
            this.btnMetal.UseVisualStyleBackColor = false;
            this.btnMetal.Click += new System.EventHandler(this.btnMetal_Click);
            // 
            // lbMetal
            // 
            this.lbMetal.FormattingEnabled = true;
            this.lbMetal.Location = new System.Drawing.Point(14, 36);
            this.lbMetal.Name = "lbMetal";
            this.lbMetal.Size = new System.Drawing.Size(102, 108);
            this.lbMetal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(248, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "ATIK KUTULARI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(588, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbAtiklar);
            this.Name = "Form1";
            this.Text = "ATIK TOPLAMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAtiklar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.Button btnYeniOyun;
        public System.Windows.Forms.Button btnOrgBosalt;
        public System.Windows.Forms.Button btnOrganikAtik;
        public System.Windows.Forms.ListBox lbOrganikAtik;
        public System.Windows.Forms.Button btnKagitBosalt;
        public System.Windows.Forms.Button btnKagit;
        public System.Windows.Forms.ListBox lbKagit;
        public System.Windows.Forms.Button btnCamBosalt;
        public System.Windows.Forms.Button btnCam;
        public System.Windows.Forms.ListBox lbCam;
        public System.Windows.Forms.Button btnMetalBosalt;
        public System.Windows.Forms.Button btnMetal;
        public System.Windows.Forms.ListBox lbMetal;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox pbAtiklar;
        public System.Windows.Forms.Label lbPuan;
        public System.Windows.Forms.Label lbSure;
        public System.Windows.Forms.ProgressBar pBarOrganik;
        public System.Windows.Forms.ProgressBar pBarKagit;
        public System.Windows.Forms.ProgressBar pBarCam;
        public System.Windows.Forms.ProgressBar pBarMetal;
    }
}

