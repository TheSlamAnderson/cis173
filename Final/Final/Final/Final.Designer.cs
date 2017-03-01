namespace Final
{
    partial class Final
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
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbCustomerInfo = new System.Windows.Forms.GroupBox();
            this.tbZip = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.ddStyle = new System.Windows.Forms.ComboBox();
            this.ddSize = new System.Windows.Forms.ComboBox();
            this.gbExtras = new System.Windows.Forms.GroupBox();
            this.cbExtra3 = new System.Windows.Forms.CheckBox();
            this.cbExtra2 = new System.Windows.Forms.CheckBox();
            this.cbExtra1 = new System.Windows.Forms.CheckBox();
            this.gbDiscount = new System.Windows.Forms.GroupBox();
            this.rbDisc3 = new System.Windows.Forms.RadioButton();
            this.rbDisc2 = new System.Windows.Forms.RadioButton();
            this.rbDisc1 = new System.Windows.Forms.RadioButton();
            this.gbPricing = new System.Windows.Forms.GroupBox();
            this.tbDue = new System.Windows.Forms.TextBox();
            this.tbTax = new System.Windows.Forms.TextBox();
            this.tbDisc = new System.Windows.Forms.TextBox();
            this.tbExtras = new System.Windows.Forms.TextBox();
            this.tbSmoothie = new System.Windows.Forms.TextBox();
            this.lblDue = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblDisc = new System.Windows.Forms.Label();
            this.lblExtras = new System.Windows.Forms.Label();
            this.lblSmoothie = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.gbCustomerInfo.SuspendLayout();
            this.gbProduct.SuspendLayout();
            this.gbExtras.SuspendLayout();
            this.gbDiscount.SuspendLayout();
            this.gbPricing.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.calculateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+R";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.clearToolStripMenuItem.Text = "Clea&r";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F";
            this.fontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+L";
            this.colorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // gbCustomerInfo
            // 
            this.gbCustomerInfo.Controls.Add(this.tbZip);
            this.gbCustomerInfo.Controls.Add(this.tbState);
            this.gbCustomerInfo.Controls.Add(this.tbCity);
            this.gbCustomerInfo.Controls.Add(this.tbAddress);
            this.gbCustomerInfo.Controls.Add(this.tbName);
            this.gbCustomerInfo.Controls.Add(this.lblZip);
            this.gbCustomerInfo.Controls.Add(this.lblState);
            this.gbCustomerInfo.Controls.Add(this.lblCity);
            this.gbCustomerInfo.Controls.Add(this.lblAddress);
            this.gbCustomerInfo.Controls.Add(this.lblName);
            this.gbCustomerInfo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gbCustomerInfo.ForeColor = System.Drawing.Color.Black;
            this.gbCustomerInfo.Location = new System.Drawing.Point(13, 35);
            this.gbCustomerInfo.Name = "gbCustomerInfo";
            this.gbCustomerInfo.Size = new System.Drawing.Size(500, 150);
            this.gbCustomerInfo.TabIndex = 0;
            this.gbCustomerInfo.TabStop = false;
            this.gbCustomerInfo.Text = "Customer Information";
            // 
            // tbZip
            // 
            this.tbZip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZip.ForeColor = System.Drawing.Color.Black;
            this.tbZip.Location = new System.Drawing.Point(396, 105);
            this.tbZip.Name = "tbZip";
            this.tbZip.Size = new System.Drawing.Size(75, 23);
            this.tbZip.TabIndex = 4;
            // 
            // tbState
            // 
            this.tbState.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbState.ForeColor = System.Drawing.Color.Black;
            this.tbState.Location = new System.Drawing.Point(297, 105);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(50, 23);
            this.tbState.TabIndex = 3;
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.ForeColor = System.Drawing.Color.Black;
            this.tbCity.Location = new System.Drawing.Point(135, 105);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 23);
            this.tbCity.TabIndex = 2;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.ForeColor = System.Drawing.Color.Black;
            this.tbAddress.Location = new System.Drawing.Point(135, 70);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(250, 23);
            this.tbAddress.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(135, 35);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(250, 23);
            this.tbName.TabIndex = 0;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(361, 109);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(30, 16);
            this.lblZip.TabIndex = 4;
            this.lblZip.Text = "&Zip:";
            this.lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(249, 107);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(43, 16);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "St&ate:";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(95, 107);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 16);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "Cit&y:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(32, 72);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(98, 16);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "S&treet Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(25, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "C&ustomer Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.ddStyle);
            this.gbProduct.Controls.Add(this.ddSize);
            this.gbProduct.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gbProduct.ForeColor = System.Drawing.Color.Black;
            this.gbProduct.Location = new System.Drawing.Point(527, 35);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(200, 150);
            this.gbProduct.TabIndex = 1;
            this.gbProduct.TabStop = false;
            this.gbProduct.Text = "Choose Product:";
            // 
            // ddStyle
            // 
            this.ddStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddStyle.ForeColor = System.Drawing.Color.Black;
            this.ddStyle.FormattingEnabled = true;
            this.ddStyle.Items.AddRange(new object[] {
            "Regular",
            "Organic"});
            this.ddStyle.Location = new System.Drawing.Point(12, 95);
            this.ddStyle.Name = "ddStyle";
            this.ddStyle.Size = new System.Drawing.Size(175, 24);
            this.ddStyle.TabIndex = 1;
            this.ddStyle.Text = "Select Smoothie Style:";
            // 
            // ddSize
            // 
            this.ddSize.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddSize.ForeColor = System.Drawing.Color.Black;
            this.ddSize.FormattingEnabled = true;
            this.ddSize.ItemHeight = 16;
            this.ddSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "Monster"});
            this.ddSize.Location = new System.Drawing.Point(12, 50);
            this.ddSize.Name = "ddSize";
            this.ddSize.Size = new System.Drawing.Size(175, 24);
            this.ddSize.TabIndex = 0;
            this.ddSize.Text = "Select Smoothie Size:";
            // 
            // gbExtras
            // 
            this.gbExtras.Controls.Add(this.cbExtra3);
            this.gbExtras.Controls.Add(this.cbExtra2);
            this.gbExtras.Controls.Add(this.cbExtra1);
            this.gbExtras.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gbExtras.ForeColor = System.Drawing.Color.Black;
            this.gbExtras.Location = new System.Drawing.Point(13, 200);
            this.gbExtras.Name = "gbExtras";
            this.gbExtras.Size = new System.Drawing.Size(200, 150);
            this.gbExtras.TabIndex = 2;
            this.gbExtras.TabStop = false;
            this.gbExtras.Text = "Extras:";
            // 
            // cbExtra3
            // 
            this.cbExtra3.AutoSize = true;
            this.cbExtra3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtra3.Location = new System.Drawing.Point(25, 105);
            this.cbExtra3.Name = "cbExtra3";
            this.cbExtra3.Size = new System.Drawing.Size(113, 20);
            this.cbExtra3.TabIndex = 2;
            this.cbExtra3.Text = "Energy Booster";
            this.cbExtra3.UseVisualStyleBackColor = true;
            // 
            // cbExtra2
            // 
            this.cbExtra2.AutoSize = true;
            this.cbExtra2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtra2.Location = new System.Drawing.Point(25, 70);
            this.cbExtra2.Name = "cbExtra2";
            this.cbExtra2.Size = new System.Drawing.Size(86, 20);
            this.cbExtra2.TabIndex = 1;
            this.cbExtra2.Text = "Bee Pollen";
            this.cbExtra2.UseVisualStyleBackColor = true;
            // 
            // cbExtra1
            // 
            this.cbExtra1.AutoSize = true;
            this.cbExtra1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtra1.Location = new System.Drawing.Point(25, 35);
            this.cbExtra1.Name = "cbExtra1";
            this.cbExtra1.Size = new System.Drawing.Size(84, 20);
            this.cbExtra1.TabIndex = 0;
            this.cbExtra1.Text = "Echinacea";
            this.cbExtra1.UseVisualStyleBackColor = true;
            // 
            // gbDiscount
            // 
            this.gbDiscount.Controls.Add(this.rbDisc3);
            this.gbDiscount.Controls.Add(this.rbDisc2);
            this.gbDiscount.Controls.Add(this.rbDisc1);
            this.gbDiscount.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gbDiscount.ForeColor = System.Drawing.Color.Black;
            this.gbDiscount.Location = new System.Drawing.Point(226, 200);
            this.gbDiscount.Name = "gbDiscount";
            this.gbDiscount.Size = new System.Drawing.Size(200, 150);
            this.gbDiscount.TabIndex = 3;
            this.gbDiscount.TabStop = false;
            this.gbDiscount.Text = "Discount:";
            // 
            // rbDisc3
            // 
            this.rbDisc3.AutoSize = true;
            this.rbDisc3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDisc3.Location = new System.Drawing.Point(25, 105);
            this.rbDisc3.Name = "rbDisc3";
            this.rbDisc3.Size = new System.Drawing.Size(139, 20);
            this.rbDisc3.TabIndex = 2;
            this.rbDisc3.Text = "Preferred Customer";
            this.rbDisc3.UseVisualStyleBackColor = true;
            // 
            // rbDisc2
            // 
            this.rbDisc2.AutoSize = true;
            this.rbDisc2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDisc2.Location = new System.Drawing.Point(25, 70);
            this.rbDisc2.Name = "rbDisc2";
            this.rbDisc2.Size = new System.Drawing.Size(120, 20);
            this.rbDisc2.TabIndex = 1;
            this.rbDisc2.Text = "10% Off Coupon";
            this.rbDisc2.UseVisualStyleBackColor = true;
            // 
            // rbDisc1
            // 
            this.rbDisc1.AutoSize = true;
            this.rbDisc1.Checked = true;
            this.rbDisc1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDisc1.Location = new System.Drawing.Point(25, 35);
            this.rbDisc1.Name = "rbDisc1";
            this.rbDisc1.Size = new System.Drawing.Size(55, 20);
            this.rbDisc1.TabIndex = 0;
            this.rbDisc1.TabStop = true;
            this.rbDisc1.Text = "None";
            this.rbDisc1.UseVisualStyleBackColor = true;
            // 
            // gbPricing
            // 
            this.gbPricing.Controls.Add(this.tbDue);
            this.gbPricing.Controls.Add(this.tbTax);
            this.gbPricing.Controls.Add(this.tbDisc);
            this.gbPricing.Controls.Add(this.tbExtras);
            this.gbPricing.Controls.Add(this.tbSmoothie);
            this.gbPricing.Controls.Add(this.lblDue);
            this.gbPricing.Controls.Add(this.lblTax);
            this.gbPricing.Controls.Add(this.lblDisc);
            this.gbPricing.Controls.Add(this.lblExtras);
            this.gbPricing.Controls.Add(this.lblSmoothie);
            this.gbPricing.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gbPricing.ForeColor = System.Drawing.Color.Black;
            this.gbPricing.Location = new System.Drawing.Point(439, 200);
            this.gbPricing.Name = "gbPricing";
            this.gbPricing.Size = new System.Drawing.Size(288, 225);
            this.gbPricing.TabIndex = 4;
            this.gbPricing.TabStop = false;
            this.gbPricing.Text = "Pricing:";
            // 
            // tbDue
            // 
            this.tbDue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDue.ForeColor = System.Drawing.Color.Black;
            this.tbDue.Location = new System.Drawing.Point(135, 175);
            this.tbDue.Name = "tbDue";
            this.tbDue.ReadOnly = true;
            this.tbDue.Size = new System.Drawing.Size(125, 23);
            this.tbDue.TabIndex = 4;
            this.tbDue.TabStop = false;
            this.tbDue.Text = "$0.00";
            this.tbDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTax
            // 
            this.tbTax.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTax.ForeColor = System.Drawing.Color.Black;
            this.tbTax.Location = new System.Drawing.Point(135, 140);
            this.tbTax.Name = "tbTax";
            this.tbTax.ReadOnly = true;
            this.tbTax.Size = new System.Drawing.Size(125, 23);
            this.tbTax.TabIndex = 3;
            this.tbTax.TabStop = false;
            this.tbTax.Text = "$0.00";
            this.tbTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbDisc
            // 
            this.tbDisc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisc.ForeColor = System.Drawing.Color.Black;
            this.tbDisc.Location = new System.Drawing.Point(135, 105);
            this.tbDisc.Name = "tbDisc";
            this.tbDisc.ReadOnly = true;
            this.tbDisc.Size = new System.Drawing.Size(125, 23);
            this.tbDisc.TabIndex = 2;
            this.tbDisc.TabStop = false;
            this.tbDisc.Text = "$0.00";
            this.tbDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbExtras
            // 
            this.tbExtras.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExtras.ForeColor = System.Drawing.Color.Black;
            this.tbExtras.Location = new System.Drawing.Point(135, 70);
            this.tbExtras.Name = "tbExtras";
            this.tbExtras.ReadOnly = true;
            this.tbExtras.Size = new System.Drawing.Size(125, 23);
            this.tbExtras.TabIndex = 1;
            this.tbExtras.TabStop = false;
            this.tbExtras.Text = "$0.00";
            this.tbExtras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSmoothie
            // 
            this.tbSmoothie.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSmoothie.ForeColor = System.Drawing.Color.Black;
            this.tbSmoothie.Location = new System.Drawing.Point(135, 35);
            this.tbSmoothie.Name = "tbSmoothie";
            this.tbSmoothie.ReadOnly = true;
            this.tbSmoothie.Size = new System.Drawing.Size(125, 23);
            this.tbSmoothie.TabIndex = 0;
            this.tbSmoothie.TabStop = false;
            this.tbSmoothie.Text = "$0.00";
            this.tbSmoothie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDue.Location = new System.Drawing.Point(34, 178);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(93, 16);
            this.lblDue.TabIndex = 4;
            this.lblDue.Text = "Amount Due:";
            this.lblDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(25, 142);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(102, 16);
            this.lblTax.TabIndex = 3;
            this.lblTax.Text = "Sales Tax (8%):";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisc.Location = new System.Drawing.Point(66, 107);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(61, 16);
            this.lblDisc.TabIndex = 2;
            this.lblDisc.Text = "Discount:";
            this.lblDisc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtras.Location = new System.Drawing.Point(79, 72);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(48, 16);
            this.lblExtras.TabIndex = 1;
            this.lblExtras.Text = "Extras:";
            this.lblExtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSmoothie
            // 
            this.lblSmoothie.AutoSize = true;
            this.lblSmoothie.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmoothie.Location = new System.Drawing.Point(60, 37);
            this.lblSmoothie.Name = "lblSmoothie";
            this.lblSmoothie.Size = new System.Drawing.Size(67, 16);
            this.lblSmoothie.TabIndex = 0;
            this.lblSmoothie.Text = "Smoothie:";
            this.lblSmoothie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 441);
            this.Controls.Add(this.gbPricing);
            this.Controls.Add(this.gbDiscount);
            this.Controls.Add(this.gbExtras);
            this.Controls.Add(this.gbProduct);
            this.Controls.Add(this.gbCustomerInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Final";
            this.Text = "Smoothie Queen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbCustomerInfo.ResumeLayout(false);
            this.gbCustomerInfo.PerformLayout();
            this.gbProduct.ResumeLayout(false);
            this.gbExtras.ResumeLayout(false);
            this.gbExtras.PerformLayout();
            this.gbDiscount.ResumeLayout(false);
            this.gbDiscount.PerformLayout();
            this.gbPricing.ResumeLayout(false);
            this.gbPricing.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbCustomerInfo;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox tbZip;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.ComboBox ddStyle;
        private System.Windows.Forms.ComboBox ddSize;
        private System.Windows.Forms.GroupBox gbExtras;
        private System.Windows.Forms.CheckBox cbExtra3;
        private System.Windows.Forms.CheckBox cbExtra2;
        private System.Windows.Forms.CheckBox cbExtra1;
        private System.Windows.Forms.GroupBox gbDiscount;
        private System.Windows.Forms.GroupBox gbPricing;
        private System.Windows.Forms.RadioButton rbDisc3;
        private System.Windows.Forms.RadioButton rbDisc2;
        private System.Windows.Forms.RadioButton rbDisc1;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.Label lblExtras;
        private System.Windows.Forms.Label lblSmoothie;
        private System.Windows.Forms.TextBox tbDue;
        private System.Windows.Forms.TextBox tbTax;
        private System.Windows.Forms.TextBox tbDisc;
        private System.Windows.Forms.TextBox tbExtras;
        private System.Windows.Forms.TextBox tbSmoothie;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

