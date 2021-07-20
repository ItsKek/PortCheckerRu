namespace MatthiWare.PortChecker
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbPortsOpen = new System.Windows.Forms.ListBox();
            this.lblPortsOpen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPortRange = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPortRange1 = new System.Windows.Forms.TextBox();
            this.txtPortRange2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(20, 23);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbPortsOpen);
            this.splitContainer1.Panel1.Controls.Add(this.lblPortsOpen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.lblPortRange);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtPortRange1);
            this.splitContainer1.Panel2.Controls.Add(this.txtPortRange2);
            this.splitContainer1.Size = new System.Drawing.Size(751, 188);
            this.splitContainer1.SplitterDistance = 371;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 10;
            // 
            // lbPortsOpen
            // 
            this.lbPortsOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPortsOpen.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbPortsOpen.FormattingEnabled = true;
            this.lbPortsOpen.ItemHeight = 11;
            this.lbPortsOpen.Location = new System.Drawing.Point(0, 16);
            this.lbPortsOpen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbPortsOpen.Name = "lbPortsOpen";
            this.lbPortsOpen.Size = new System.Drawing.Size(367, 169);
            this.lbPortsOpen.TabIndex = 2;
            this.lbPortsOpen.SelectedIndexChanged += new System.EventHandler(this.lbPortsOpen_SelectedIndexChanged);
            // 
            // lblPortsOpen
            // 
            this.lblPortsOpen.AutoSize = true;
            this.lblPortsOpen.Font = new System.Drawing.Font("Minecraft Rus", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPortsOpen.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblPortsOpen.Location = new System.Drawing.Point(4, 4);
            this.lblPortsOpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortsOpen.Name = "lblPortsOpen";
            this.lblPortsOpen.Size = new System.Drawing.Size(140, 11);
            this.lblPortsOpen.TabIndex = 8;
            this.lblPortsOpen.Text = "Открытые порты: ";
            this.lblPortsOpen.Click += new System.EventHandler(this.lblPortsOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 171);
            this.label2.TabIndex = 16;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 11);
            this.label5.TabIndex = 15;
            // 
            // lblPortRange
            // 
            this.lblPortRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPortRange.AutoSize = true;
            this.lblPortRange.Font = new System.Drawing.Font("Minecraft Rus", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPortRange.Location = new System.Drawing.Point(17, 16);
            this.lblPortRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortRange.Name = "lblPortRange";
            this.lblPortRange.Size = new System.Drawing.Size(89, 11);
            this.lblPortRange.TabIndex = 5;
            this.lblPortRange.Text = "Диапозон >";
            this.lblPortRange.Click += new System.EventHandler(this.lblPortRange_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minecraft Rus", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(237, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 11);
            this.label3.TabIndex = 14;
            this.label3.Text = "До";
            // 
            // txtPortRange1
            // 
            this.txtPortRange1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPortRange1.Location = new System.Drawing.Point(114, 13);
            this.txtPortRange1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPortRange1.Name = "txtPortRange1";
            this.txtPortRange1.Size = new System.Drawing.Size(115, 18);
            this.txtPortRange1.TabIndex = 4;
            this.txtPortRange1.Text = "От 0";
            // 
            // txtPortRange2
            // 
            this.txtPortRange2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPortRange2.Location = new System.Drawing.Point(268, 13);
            this.txtPortRange2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPortRange2.Name = "txtPortRange2";
            this.txtPortRange2.Size = new System.Drawing.Size(103, 18);
            this.txtPortRange2.TabIndex = 3;
            this.txtPortRange2.Text = "65535";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Minecraft Rus", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem1.Text = "Выход";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minecraft Rus", 7.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 10);
            this.label1.TabIndex = 19;
            this.label1.Text = "Клик чтобы указать айпи (ЦИФРЕННОЕ)";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minecraft Rus", 6.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(212, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(362, 9);
            this.label4.TabIndex = 21;
            this.label4.Text = "КЛИК ЧТОБЫ ПРОВЕРИТЬ ПОРТЫ УКАЗАННЫЕ В ДИАПОЗОНЕ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(787, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Minecraft Rus", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Портчекер от itskekoff";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox lbPortsOpen;
        private System.Windows.Forms.TextBox txtPortRange2;
        private System.Windows.Forms.TextBox txtPortRange1;
        private System.Windows.Forms.Label lblPortRange;
        private System.Windows.Forms.Label lblPortsOpen;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}