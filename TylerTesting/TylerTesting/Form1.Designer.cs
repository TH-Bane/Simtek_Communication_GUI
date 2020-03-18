namespace TylerTesting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.txtReceivePort = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRevisionValue = new System.Windows.Forms.Label();
            this.lblTestSoftwareValue = new System.Windows.Forms.Label();
            this.lblRevision = new System.Windows.Forms.Label();
            this.lblTestSoftware = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureSimtekLogo = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlSimtek = new System.Windows.Forms.TabControl();
            this.pageSettings = new System.Windows.Forms.TabPage();
            this.pageDimming = new System.Windows.Forms.TabPage();
            this.MemoRx = new System.Windows.Forms.RichTextBox();
            this.MemoTx = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSimtekLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControlSimtek.SuspendLayout();
            this.pageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.txtServerPort);
            this.panel1.Controls.Add(this.txtReceivePort);
            this.panel1.Controls.Add(this.txtIPAddress);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblRevisionValue);
            this.panel1.Controls.Add(this.lblTestSoftwareValue);
            this.panel1.Controls.Add(this.lblRevision);
            this.panel1.Controls.Add(this.lblTestSoftware);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 421);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtServerPort
            // 
            this.txtServerPort.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtServerPort.Location = new System.Drawing.Point(143, 166);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(100, 20);
            this.txtServerPort.TabIndex = 12;
            this.txtServerPort.Text = "51021";
            this.txtServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtServerPort.TextChanged += new System.EventHandler(this.txtServerPort_TextChanged);
            // 
            // txtReceivePort
            // 
            this.txtReceivePort.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtReceivePort.Location = new System.Drawing.Point(143, 144);
            this.txtReceivePort.Name = "txtReceivePort";
            this.txtReceivePort.Size = new System.Drawing.Size(100, 20);
            this.txtReceivePort.TabIndex = 11;
            this.txtReceivePort.Text = "51020";
            this.txtReceivePort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtReceivePort.TextChanged += new System.EventHandler(this.txtReceivePort_TextChanged);
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtIPAddress.Location = new System.Drawing.Point(143, 122);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(100, 20);
            this.txtIPAddress.TabIndex = 10;
            this.txtIPAddress.Text = "192.168.136.90";
            this.txtIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIPAddress.TextChanged += new System.EventHandler(this.txtIPAddress_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(5, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Panel Client Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(5, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Panel Receive Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(5, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Panel IP Address:";
            // 
            // lblRevisionValue
            // 
            this.lblRevisionValue.AutoSize = true;
            this.lblRevisionValue.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRevisionValue.Location = new System.Drawing.Point(177, 94);
            this.lblRevisionValue.Name = "lblRevisionValue";
            this.lblRevisionValue.Size = new System.Drawing.Size(39, 13);
            this.lblRevisionValue.TabIndex = 5;
            this.lblRevisionValue.Text = ": value";
            // 
            // lblTestSoftwareValue
            // 
            this.lblTestSoftwareValue.AutoSize = true;
            this.lblTestSoftwareValue.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTestSoftwareValue.Location = new System.Drawing.Point(177, 72);
            this.lblTestSoftwareValue.Name = "lblTestSoftwareValue";
            this.lblTestSoftwareValue.Size = new System.Drawing.Size(39, 13);
            this.lblTestSoftwareValue.TabIndex = 4;
            this.lblTestSoftwareValue.Text = ": value";
            // 
            // lblRevision
            // 
            this.lblRevision.AutoSize = true;
            this.lblRevision.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRevision.Location = new System.Drawing.Point(5, 94);
            this.lblRevision.Name = "lblRevision";
            this.lblRevision.Size = new System.Drawing.Size(51, 13);
            this.lblRevision.TabIndex = 3;
            this.lblRevision.Text = "Revision:";
            // 
            // lblTestSoftware
            // 
            this.lblTestSoftware.AutoSize = true;
            this.lblTestSoftware.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTestSoftware.Location = new System.Drawing.Point(5, 72);
            this.lblTestSoftware.Name = "lblTestSoftware";
            this.lblTestSoftware.Size = new System.Drawing.Size(76, 13);
            this.lblTestSoftware.TabIndex = 2;
            this.lblTestSoftware.Text = "Test Software:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureSimtekLogo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(249, 69);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureSimtekLogo
            // 
            this.pictureSimtekLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureSimtekLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureSimtekLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureSimtekLogo.Image")));
            this.pictureSimtekLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureSimtekLogo.Name = "pictureSimtekLogo";
            this.pictureSimtekLogo.Size = new System.Drawing.Size(243, 63);
            this.pictureSimtekLogo.TabIndex = 0;
            this.pictureSimtekLogo.TabStop = false;
            this.pictureSimtekLogo.Click += new System.EventHandler(this.pictureSimtekLogo_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(249, 421);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 5;
            this.lineShape1.X2 = 242;
            this.lineShape1.Y1 = 113;
            this.lineShape1.Y2 = 113;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControlSimtek
            // 
            this.tabControlSimtek.Controls.Add(this.pageSettings);
            this.tabControlSimtek.Controls.Add(this.pageDimming);
            this.tabControlSimtek.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControlSimtek.Location = new System.Drawing.Point(0, 24);
            this.tabControlSimtek.Name = "tabControlSimtek";
            this.tabControlSimtek.SelectedIndex = 0;
            this.tabControlSimtek.Size = new System.Drawing.Size(263, 453);
            this.tabControlSimtek.TabIndex = 2;
            // 
            // pageSettings
            // 
            this.pageSettings.Controls.Add(this.panel1);
            this.pageSettings.Location = new System.Drawing.Point(4, 22);
            this.pageSettings.Name = "pageSettings";
            this.pageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.pageSettings.Size = new System.Drawing.Size(255, 427);
            this.pageSettings.TabIndex = 0;
            this.pageSettings.Text = "Settings";
            this.pageSettings.UseVisualStyleBackColor = true;
            // 
            // pageDimming
            // 
            this.pageDimming.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pageDimming.Location = new System.Drawing.Point(4, 22);
            this.pageDimming.Name = "pageDimming";
            this.pageDimming.Padding = new System.Windows.Forms.Padding(3);
            this.pageDimming.Size = new System.Drawing.Size(255, 427);
            this.pageDimming.TabIndex = 1;
            this.pageDimming.Text = "Dimming";
            // 
            // MemoRx
            // 
            this.MemoRx.BackColor = System.Drawing.Color.Green;
            this.MemoRx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemoRx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MemoRx.ForeColor = System.Drawing.Color.Lime;
            this.MemoRx.Location = new System.Drawing.Point(263, 396);
            this.MemoRx.Name = "MemoRx";
            this.MemoRx.Size = new System.Drawing.Size(572, 81);
            this.MemoRx.TabIndex = 3;
            this.MemoRx.Text = "MemoRx";
            // 
            // MemoTx
            // 
            this.MemoTx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MemoTx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MemoTx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MemoTx.Location = new System.Drawing.Point(263, 315);
            this.MemoTx.Name = "MemoTx";
            this.MemoTx.Size = new System.Drawing.Size(572, 81);
            this.MemoTx.TabIndex = 4;
            this.MemoTx.Text = "MemoTx";
            this.MemoTx.TextChanged += new System.EventHandler(this.MemoTx_TextChanged);
            this.MemoTx.Enter += new System.EventHandler(this.MemoTx_Enter);
            this.MemoTx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MemoTx_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(835, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MemoTx);
            this.Controls.Add(this.MemoRx);
            this.Controls.Add(this.tabControlSimtek);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSimtekLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlSimtek.ResumeLayout(false);
            this.pageSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureSimtekLogo;
        private System.Windows.Forms.TabControl tabControlSimtek;
        private System.Windows.Forms.TabPage pageSettings;
        private System.Windows.Forms.TabPage pageDimming;
        private System.Windows.Forms.Label lblRevision;
        private System.Windows.Forms.Label lblTestSoftware;
        private System.Windows.Forms.Label lblTestSoftwareValue;
        private System.Windows.Forms.Label lblRevisionValue;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.TextBox txtReceivePort;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.RichTextBox MemoRx;
        private System.Windows.Forms.RichTextBox MemoTx;
        private System.Windows.Forms.Button button1;
    }
}

