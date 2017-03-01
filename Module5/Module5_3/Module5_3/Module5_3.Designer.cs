namespace Module5_3
{
    partial class Module5_3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbSales = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPay = new System.Windows.Forms.TextBox();
            this.tbCommission = new System.Windows.Forms.TextBox();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.gbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(342, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payToolStripMenuItem,
            this.summaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // payToolStripMenuItem
            // 
            this.payToolStripMenuItem.Name = "payToolStripMenuItem";
            this.payToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.payToolStripMenuItem.Text = "&Pay";
            this.payToolStripMenuItem.Click += new System.EventHandler(this.payToolStripMenuItem_Click);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.summaryToolStripMenuItem.Text = "&Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.toolStripSeparator1,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.clearToolStripMenuItem.Text = "C&lear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.fontToolStripMenuItem.Text = "&Font...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.colorToolStripMenuItem.Text = "&Color...";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.lblSales);
            this.gbInput.Controls.Add(this.lblName);
            this.gbInput.Controls.Add(this.tbSales);
            this.gbInput.Controls.Add(this.tbName);
            this.gbInput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInput.ForeColor = System.Drawing.Color.Black;
            this.gbInput.Location = new System.Drawing.Point(15, 35);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(315, 100);
            this.gbInput.TabIndex = 1;
            this.gbInput.TabStop = false;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblSales.Location = new System.Drawing.Point(13, 67);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(96, 17);
            this.lblSales.TabIndex = 3;
            this.lblSales.Text = "Sales Amount:";
            this.lblSales.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblName.Location = new System.Drawing.Point(61, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tbSales
            // 
            this.tbSales.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbSales.Location = new System.Drawing.Point(120, 60);
            this.tbSales.Name = "tbSales";
            this.tbSales.Size = new System.Drawing.Size(100, 24);
            this.tbSales.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbName.Location = new System.Drawing.Point(120, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(175, 24);
            this.tbName.TabIndex = 0;
            // 
            // tbPay
            // 
            this.tbPay.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tbPay.ForeColor = System.Drawing.Color.Black;
            this.tbPay.Location = new System.Drawing.Point(135, 150);
            this.tbPay.Name = "tbPay";
            this.tbPay.ReadOnly = true;
            this.tbPay.Size = new System.Drawing.Size(100, 24);
            this.tbPay.TabIndex = 2;
            // 
            // tbCommission
            // 
            this.tbCommission.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tbCommission.ForeColor = System.Drawing.Color.Black;
            this.tbCommission.Location = new System.Drawing.Point(135, 185);
            this.tbCommission.Name = "tbCommission";
            this.tbCommission.ReadOnly = true;
            this.tbCommission.Size = new System.Drawing.Size(100, 24);
            this.tbCommission.TabIndex = 3;
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblPay.ForeColor = System.Drawing.Color.Black;
            this.lblPay.Location = new System.Drawing.Point(54, 157);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(70, 17);
            this.lblPay.TabIndex = 4;
            this.lblPay.Text = "Total Pay:";
            this.lblPay.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCommission.ForeColor = System.Drawing.Color.Black;
            this.lblCommission.Location = new System.Drawing.Point(38, 192);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(86, 17);
            this.lblCommission.TabIndex = 5;
            this.lblCommission.Text = "Commission:";
            this.lblCommission.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Module5_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 231);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.tbCommission);
            this.Controls.Add(this.tbPay);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Module5_3";
            this.Text = "Commission Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbSales;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPay;
        private System.Windows.Forms.TextBox tbCommission;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

