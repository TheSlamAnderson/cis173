namespace Module7
{
    partial class Module7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Module7));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPackage = new System.Windows.Forms.Label();
            this.lbPackage = new System.Windows.Forms.ListBox();
            this.lblFragrance = new System.Windows.Forms.Label();
            this.cbFragrance = new System.Windows.Forms.ComboBox();
            this.lblExterior = new System.Windows.Forms.Label();
            this.lblSelections = new System.Windows.Forms.Label();
            this.lblInterior = new System.Windows.Forms.Label();
            this.lbExterior = new System.Windows.Forms.ListBox();
            this.lbInterior = new System.Windows.Forms.ListBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "&Print Order";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackage.Location = new System.Drawing.Point(15, 75);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(255, 16);
            this.lblPackage.TabIndex = 1;
            this.lblPackage.Text = "Select A &Detail Package From The List:";
            // 
            // lbPackage
            // 
            this.lbPackage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPackage.FormattingEnabled = true;
            this.lbPackage.ItemHeight = 16;
            this.lbPackage.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Executive",
            "Luxury"});
            this.lbPackage.Location = new System.Drawing.Point(20, 100);
            this.lbPackage.Name = "lbPackage";
            this.lbPackage.Size = new System.Drawing.Size(150, 68);
            this.lbPackage.TabIndex = 0;
            this.lbPackage.SelectedIndexChanged += new System.EventHandler(this.lbPackage_SelectedIndexChanged);
            // 
            // lblFragrance
            // 
            this.lblFragrance.AutoSize = true;
            this.lblFragrance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFragrance.Location = new System.Drawing.Point(15, 200);
            this.lblFragrance.Name = "lblFragrance";
            this.lblFragrance.Size = new System.Drawing.Size(136, 16);
            this.lblFragrance.TabIndex = 3;
            this.lblFragrance.Text = "Select A &Fragrance:";
            // 
            // cbFragrance
            // 
            this.cbFragrance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFragrance.FormattingEnabled = true;
            this.cbFragrance.Items.AddRange(new object[] {
            "Hawaiin Mist",
            "Baby Powder",
            "Pine",
            "Country Floral",
            "Pina Colada",
            "Vanilla"});
            this.cbFragrance.Location = new System.Drawing.Point(20, 225);
            this.cbFragrance.Name = "cbFragrance";
            this.cbFragrance.Size = new System.Drawing.Size(150, 24);
            this.cbFragrance.TabIndex = 1;
            // 
            // lblExterior
            // 
            this.lblExterior.AutoSize = true;
            this.lblExterior.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExterior.Location = new System.Drawing.Point(360, 75);
            this.lblExterior.Name = "lblExterior";
            this.lblExterior.Size = new System.Drawing.Size(64, 16);
            this.lblExterior.TabIndex = 7;
            this.lblExterior.Text = "Exterior:";
            // 
            // lblSelections
            // 
            this.lblSelections.AutoSize = true;
            this.lblSelections.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelections.Location = new System.Drawing.Point(350, 50);
            this.lblSelections.Name = "lblSelections";
            this.lblSelections.Size = new System.Drawing.Size(159, 16);
            this.lblSelections.TabIndex = 9;
            this.lblSelections.Text = "Selections Listed Below";
            // 
            // lblInterior
            // 
            this.lblInterior.AutoSize = true;
            this.lblInterior.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterior.Location = new System.Drawing.Point(360, 200);
            this.lblInterior.Name = "lblInterior";
            this.lblInterior.Size = new System.Drawing.Size(63, 16);
            this.lblInterior.TabIndex = 10;
            this.lblInterior.Text = "Interior:";
            // 
            // lbExterior
            // 
            this.lbExterior.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExterior.FormattingEnabled = true;
            this.lbExterior.ItemHeight = 16;
            this.lbExterior.Location = new System.Drawing.Point(370, 100);
            this.lbExterior.Name = "lbExterior";
            this.lbExterior.Size = new System.Drawing.Size(250, 84);
            this.lbExterior.TabIndex = 2;
            // 
            // lbInterior
            // 
            this.lbInterior.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInterior.FormattingEnabled = true;
            this.lbInterior.ItemHeight = 16;
            this.lbInterior.Location = new System.Drawing.Point(370, 225);
            this.lbInterior.Name = "lbInterior";
            this.lbInterior.Size = new System.Drawing.Size(250, 84);
            this.lbInterior.TabIndex = 4;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Module7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 331);
            this.Controls.Add(this.lbInterior);
            this.Controls.Add(this.lbExterior);
            this.Controls.Add(this.lblInterior);
            this.Controls.Add(this.lblSelections);
            this.Controls.Add(this.lblExterior);
            this.Controls.Add(this.cbFragrance);
            this.Controls.Add(this.lblFragrance);
            this.Controls.Add(this.lbPackage);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Module7";
            this.Text = "Christopher\'s Car Center";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.ListBox lbPackage;
        private System.Windows.Forms.Label lblFragrance;
        private System.Windows.Forms.ComboBox cbFragrance;
        private System.Windows.Forms.Label lblExterior;
        private System.Windows.Forms.Label lblSelections;
        private System.Windows.Forms.Label lblInterior;
        private System.Windows.Forms.ListBox lbExterior;
        private System.Windows.Forms.ListBox lbInterior;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

