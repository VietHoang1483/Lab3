namespace Lab03_02
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
            this.richText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoVănBảnMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởTậpTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuNộiDungVănBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhDạngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tscboFont = new System.Windows.Forms.ToolStripComboBox();
            this.tscboSize = new System.Windows.Forms.ToolStripComboBox();
            this.tsbtnB = new System.Windows.Forms.ToolStripButton();
            this.tsbtnI = new System.Windows.Forms.ToolStripButton();
            this.tsbtnU = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richText
            // 
            this.richText.Location = new System.Drawing.Point(-1, 57);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(801, 384);
            this.richText.TabIndex = 0;
            this.richText.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.địnhDạngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoVănBảnMớiToolStripMenuItem,
            this.mởTậpTinToolStripMenuItem,
            this.lưuNộiDungVănBảnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // tạoVănBảnMớiToolStripMenuItem
            // 
            this.tạoVănBảnMớiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tạoVănBảnMớiToolStripMenuItem.Image")));
            this.tạoVănBảnMớiToolStripMenuItem.Name = "tạoVănBảnMớiToolStripMenuItem";
            this.tạoVănBảnMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tạoVănBảnMớiToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.tạoVănBảnMớiToolStripMenuItem.Text = "Tạo Văn Bản Mới";
            this.tạoVănBảnMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoVănBảnMớiToolStripMenuItem_Click);
            // 
            // mởTậpTinToolStripMenuItem
            // 
            this.mởTậpTinToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mởTậpTinToolStripMenuItem.Image")));
            this.mởTậpTinToolStripMenuItem.Name = "mởTậpTinToolStripMenuItem";
            this.mởTậpTinToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.mởTậpTinToolStripMenuItem.Text = "Mở Tập Tin";
            this.mởTậpTinToolStripMenuItem.Click += new System.EventHandler(this.mởTậpTinToolStripMenuItem_Click);
            // 
            // lưuNộiDungVănBảnToolStripMenuItem
            // 
            this.lưuNộiDungVănBảnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lưuNộiDungVănBảnToolStripMenuItem.Image")));
            this.lưuNộiDungVănBảnToolStripMenuItem.Name = "lưuNộiDungVănBảnToolStripMenuItem";
            this.lưuNộiDungVănBảnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lưuNộiDungVănBảnToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.lưuNộiDungVănBảnToolStripMenuItem.Text = "Lưu Nội Dung Văn Bản";
            this.lưuNộiDungVănBảnToolStripMenuItem.Click += new System.EventHandler(this.lưuNộiDungVănBảnToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // địnhDạngToolStripMenuItem
            // 
            this.địnhDạngToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            this.địnhDạngToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.địnhDạngToolStripMenuItem.Text = "Định Dạng";
            this.địnhDạngToolStripMenuItem.Click += new System.EventHandler(this.địnhDạngToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNew,
            this.tsbtnSave,
            this.tscboFont,
            this.tscboSize,
            this.tsbtnB,
            this.tsbtnI,
            this.tsbtnU});
            this.toolStrip1.Location = new System.Drawing.Point(0, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbtnNew
            // 
            this.tsbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNew.Image")));
            this.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNew.Name = "tsbtnNew";
            this.tsbtnNew.Size = new System.Drawing.Size(29, 25);
            this.tsbtnNew.Text = "New ";
            this.tsbtnNew.Click += new System.EventHandler(this.tsbtnNew_Click);
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(29, 25);
            this.tsbtnSave.Text = "Save";
            this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
            // 
            // tscboFont
            // 
            this.tscboFont.Name = "tscboFont";
            this.tscboFont.Size = new System.Drawing.Size(121, 28);
            this.tscboFont.Text = "Tahoma";
            this.tscboFont.SelectedIndexChanged += new System.EventHandler(this.tscboFont_SelectedIndexChanged);
            this.tscboFont.TextChanged += new System.EventHandler(this.tscboFont_TextChanged);
            // 
            // tscboSize
            // 
            this.tscboSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.tscboSize.Name = "tscboSize";
            this.tscboSize.Size = new System.Drawing.Size(121, 28);
            this.tscboSize.Text = "14";
            this.tscboSize.SelectedIndexChanged += new System.EventHandler(this.tscboSize_SelectedIndexChanged);
            this.tscboSize.Click += new System.EventHandler(this.tscboSize_Click);
            // 
            // tsbtnB
            // 
            this.tsbtnB.BackColor = System.Drawing.Color.White;
            this.tsbtnB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnB.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnB.Image")));
            this.tsbtnB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnB.Name = "tsbtnB";
            this.tsbtnB.Size = new System.Drawing.Size(29, 25);
            this.tsbtnB.Text = "Bold";
            this.tsbtnB.Click += new System.EventHandler(this.tsbtnB_Click);
            // 
            // tsbtnI
            // 
            this.tsbtnI.BackColor = System.Drawing.Color.White;
            this.tsbtnI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnI.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnI.Image")));
            this.tsbtnI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnI.Name = "tsbtnI";
            this.tsbtnI.Size = new System.Drawing.Size(29, 25);
            this.tsbtnI.Text = "Italic";
            this.tsbtnI.Click += new System.EventHandler(this.tsbtnI_Click);
            // 
            // tsbtnU
            // 
            this.tsbtnU.BackColor = System.Drawing.Color.White;
            this.tsbtnU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnU.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnU.Image")));
            this.tsbtnU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnU.Name = "tsbtnU";
            this.tsbtnU.Size = new System.Drawing.Size(29, 25);
            this.tsbtnU.Text = "UnderLine";
            this.tsbtnU.Click += new System.EventHandler(this.tsbtnU_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoVănBảnMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởTậpTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuNộiDungVănBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnNew;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripComboBox tscboFont;
        private System.Windows.Forms.ToolStripComboBox tscboSize;
        private System.Windows.Forms.ToolStripButton tsbtnB;
        private System.Windows.Forms.ToolStripButton tsbtnI;
        private System.Windows.Forms.ToolStripButton tsbtnU;
        private System.Windows.Forms.ToolStripMenuItem địnhDạngToolStripMenuItem;
    }
}

