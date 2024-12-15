namespace WindowsFormsApp5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taoVanBanMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.moTap = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuNộiDungVănBản = new System.Windows.Forms.ToolStripMenuItem();
            this.thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.dinhDang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.cbxFont = new System.Windows.Forms.ToolStripComboBox();
            this.cbxSize = new System.Windows.Forms.ToolStripComboBox();
            this.indam = new System.Windows.Forms.ToolStripButton();
            this.innghieng_ = new System.Windows.Forms.ToolStripButton();
            this.gachchan_ = new System.Windows.Forms.ToolStripButton();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.dinhDang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taoVanBanMoi,
            this.moTap,
            this.lưuNộiDungVănBản,
            this.thoat});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // taoVanBanMoi
            // 
            this.taoVanBanMoi.Name = "taoVanBanMoi";
            this.taoVanBanMoi.Size = new System.Drawing.Size(190, 22);
            this.taoVanBanMoi.Text = "Tạo văn bản mới";
            this.taoVanBanMoi.Click += new System.EventHandler(this.taoVanBanMoi_Click);
            // 
            // moTap
            // 
            this.moTap.Name = "moTap";
            this.moTap.Size = new System.Drawing.Size(190, 22);
            this.moTap.Text = "Mở tập tin";
            this.moTap.Click += new System.EventHandler(this.moTap_Click);
            // 
            // lưuNộiDungVănBản
            // 
            this.lưuNộiDungVănBản.Name = "lưuNộiDungVănBản";
            this.lưuNộiDungVănBản.Size = new System.Drawing.Size(190, 22);
            this.lưuNộiDungVănBản.Text = "Lưu nội dung văn bản";
            this.lưuNộiDungVănBản.Click += new System.EventHandler(this.lưuNộiDungVănBản_Click);
            // 
            // thoat
            // 
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(190, 22);
            this.thoat.Text = "Thoát";
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // dinhDang
            // 
            this.dinhDang.Name = "dinhDang";
            this.dinhDang.Size = new System.Drawing.Size(75, 20);
            this.dinhDang.Text = "Định Dạng";
            this.dinhDang.Click += new System.EventHandler(this.địnhDạngToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.cbxFont,
            this.cbxSize,
            this.indam,
            this.innghieng_,
            this.gachchan_});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // cbxFont
            // 
            this.cbxFont.Name = "cbxFont";
            this.cbxFont.Size = new System.Drawing.Size(121, 25);
            this.cbxFont.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // cbxSize
            // 
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(121, 25);
            this.cbxSize.Click += new System.EventHandler(this.cbxSize_Click);
            // 
            // indam
            // 
            this.indam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.indam.Image = ((System.Drawing.Image)(resources.GetObject("indam.Image")));
            this.indam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.indam.Name = "indam";
            this.indam.Size = new System.Drawing.Size(23, 22);
            this.indam.Text = "toolStripButton3";
            this.indam.Click += new System.EventHandler(this.indam_Click);
            // 
            // innghieng_
            // 
            this.innghieng_.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.innghieng_.Image = ((System.Drawing.Image)(resources.GetObject("innghieng_.Image")));
            this.innghieng_.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.innghieng_.Name = "innghieng_";
            this.innghieng_.Size = new System.Drawing.Size(23, 22);
            this.innghieng_.Text = "toolStripButton4";
            this.innghieng_.Click += new System.EventHandler(this.innghieng__Click);
            // 
            // gachchan_
            // 
            this.gachchan_.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gachchan_.Image = ((System.Drawing.Image)(resources.GetObject("gachchan_.Image")));
            this.gachchan_.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gachchan_.Name = "gachchan_";
            this.gachchan_.Size = new System.Drawing.Size(23, 22);
            this.gachchan_.Text = "toolStripButton5";
            this.gachchan_.Click += new System.EventHandler(this.gachchan__Click);
            // 
            // richText
            // 
            this.richText.Location = new System.Drawing.Point(0, 52);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(413, 311);
            this.richText.TabIndex = 2;
            this.richText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "    ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taoVanBanMoi;
        private System.Windows.Forms.ToolStripMenuItem dinhDang;
        private System.Windows.Forms.ToolStripMenuItem moTap;
        private System.Windows.Forms.ToolStripMenuItem lưuNộiDungVănBản;
        private System.Windows.Forms.ToolStripMenuItem thoat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripComboBox cbxFont;
        private System.Windows.Forms.ToolStripComboBox cbxSize;
        private System.Windows.Forms.ToolStripButton indam;
        private System.Windows.Forms.ToolStripButton innghieng_;
        private System.Windows.Forms.ToolStripButton gachchan_;
        private System.Windows.Forms.RichTextBox richText;
    }
}

