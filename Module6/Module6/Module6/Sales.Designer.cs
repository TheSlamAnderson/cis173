namespace Module6
{
    partial class Sales
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbAccessories = new System.Windows.Forms.GroupBox();
            this.cbComputer = new System.Windows.Forms.CheckBox();
            this.cbLeather = new System.Windows.Forms.CheckBox();
            this.cbStereo = new System.Windows.Forms.CheckBox();
            this.gbExterior = new System.Windows.Forms.GroupBox();
            this.rbDetailing = new System.Windows.Forms.RadioButton();
            this.rbPearlized = new System.Windows.Forms.RadioButton();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbFinish = new System.Windows.Forms.TextBox();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.tbTax = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbTrade = new System.Windows.Forms.TextBox();
            this.tbAmtDue = new System.Windows.Forms.TextBox();
            this.lblFinish = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTrade = new System.Windows.Forms.Label();
            this.lblAmtDue = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.gbAccessories.SuspendLayout();
            this.gbExterior.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.Black;
            this.btnCalc.Location = new System.Drawing.Point(35, 315);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(125, 35);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(184, 315);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(333, 315);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 35);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbAccessories
            // 
            this.gbAccessories.Controls.Add(this.cbComputer);
            this.gbAccessories.Controls.Add(this.cbLeather);
            this.gbAccessories.Controls.Add(this.cbStereo);
            this.gbAccessories.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAccessories.ForeColor = System.Drawing.Color.Black;
            this.gbAccessories.Location = new System.Drawing.Point(15, 35);
            this.gbAccessories.Name = "gbAccessories";
            this.gbAccessories.Size = new System.Drawing.Size(175, 125);
            this.gbAccessories.TabIndex = 2;
            this.gbAccessories.TabStop = false;
            this.gbAccessories.Text = "Accessories";
            // 
            // cbComputer
            // 
            this.cbComputer.AutoSize = true;
            this.cbComputer.Location = new System.Drawing.Point(15, 90);
            this.cbComputer.Name = "cbComputer";
            this.cbComputer.Size = new System.Drawing.Size(146, 20);
            this.cbComputer.TabIndex = 2;
            this.cbComputer.Text = "Computer Navigation";
            this.cbComputer.UseVisualStyleBackColor = true;
            // 
            // cbLeather
            // 
            this.cbLeather.AutoSize = true;
            this.cbLeather.Location = new System.Drawing.Point(15, 60);
            this.cbLeather.Name = "cbLeather";
            this.cbLeather.Size = new System.Drawing.Size(116, 20);
            this.cbLeather.TabIndex = 1;
            this.cbLeather.Text = "Leather Interior";
            this.cbLeather.UseVisualStyleBackColor = true;
            // 
            // cbStereo
            // 
            this.cbStereo.AutoSize = true;
            this.cbStereo.Location = new System.Drawing.Point(15, 30);
            this.cbStereo.Name = "cbStereo";
            this.cbStereo.Size = new System.Drawing.Size(111, 20);
            this.cbStereo.TabIndex = 0;
            this.cbStereo.Text = "Stereo System";
            this.cbStereo.UseVisualStyleBackColor = true;
            // 
            // gbExterior
            // 
            this.gbExterior.Controls.Add(this.rbDetailing);
            this.gbExterior.Controls.Add(this.rbPearlized);
            this.gbExterior.Controls.Add(this.rbStandard);
            this.gbExterior.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbExterior.ForeColor = System.Drawing.Color.Black;
            this.gbExterior.Location = new System.Drawing.Point(15, 170);
            this.gbExterior.Name = "gbExterior";
            this.gbExterior.Size = new System.Drawing.Size(175, 125);
            this.gbExterior.TabIndex = 3;
            this.gbExterior.TabStop = false;
            this.gbExterior.Text = "Exterior Finish";
            // 
            // rbDetailing
            // 
            this.rbDetailing.AutoSize = true;
            this.rbDetailing.Location = new System.Drawing.Point(15, 90);
            this.rbDetailing.Name = "rbDetailing";
            this.rbDetailing.Size = new System.Drawing.Size(145, 20);
            this.rbDetailing.TabIndex = 2;
            this.rbDetailing.TabStop = true;
            this.rbDetailing.Text = "Customized Detailing";
            this.rbDetailing.UseVisualStyleBackColor = true;
            // 
            // rbPearlized
            // 
            this.rbPearlized.AutoSize = true;
            this.rbPearlized.Location = new System.Drawing.Point(15, 60);
            this.rbPearlized.Name = "rbPearlized";
            this.rbPearlized.Size = new System.Drawing.Size(78, 20);
            this.rbPearlized.TabIndex = 1;
            this.rbPearlized.Text = "Pearlized";
            this.rbPearlized.UseVisualStyleBackColor = true;
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Checked = true;
            this.rbStandard.Location = new System.Drawing.Point(15, 30);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(78, 20);
            this.rbStandard.TabIndex = 0;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.ForeColor = System.Drawing.Color.Black;
            this.tbPrice.Location = new System.Drawing.Point(358, 45);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(120, 23);
            this.tbPrice.TabIndex = 0;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(241, 52);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 16);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Car Sales Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tbFinish
            // 
            this.tbFinish.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFinish.ForeColor = System.Drawing.Color.Black;
            this.tbFinish.Location = new System.Drawing.Point(358, 80);
            this.tbFinish.Name = "tbFinish";
            this.tbFinish.ReadOnly = true;
            this.tbFinish.Size = new System.Drawing.Size(120, 23);
            this.tbFinish.TabIndex = 0;
            this.tbFinish.TabStop = false;
            this.tbFinish.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubtotal.ForeColor = System.Drawing.Color.Black;
            this.tbSubtotal.Location = new System.Drawing.Point(358, 115);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.ReadOnly = true;
            this.tbSubtotal.Size = new System.Drawing.Size(120, 23);
            this.tbSubtotal.TabIndex = 0;
            this.tbSubtotal.TabStop = false;
            this.tbSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTax
            // 
            this.tbTax.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTax.ForeColor = System.Drawing.Color.Black;
            this.tbTax.Location = new System.Drawing.Point(358, 150);
            this.tbTax.Name = "tbTax";
            this.tbTax.ReadOnly = true;
            this.tbTax.Size = new System.Drawing.Size(120, 23);
            this.tbTax.TabIndex = 0;
            this.tbTax.TabStop = false;
            this.tbTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.ForeColor = System.Drawing.Color.Black;
            this.tbTotal.Location = new System.Drawing.Point(358, 185);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(120, 23);
            this.tbTotal.TabIndex = 0;
            this.tbTotal.TabStop = false;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTrade
            // 
            this.tbTrade.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTrade.ForeColor = System.Drawing.Color.Black;
            this.tbTrade.Location = new System.Drawing.Point(358, 220);
            this.tbTrade.Name = "tbTrade";
            this.tbTrade.Size = new System.Drawing.Size(120, 23);
            this.tbTrade.TabIndex = 1;
            this.tbTrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbAmtDue
            // 
            this.tbAmtDue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmtDue.ForeColor = System.Drawing.Color.Black;
            this.tbAmtDue.Location = new System.Drawing.Point(358, 255);
            this.tbAmtDue.Name = "tbAmtDue";
            this.tbAmtDue.ReadOnly = true;
            this.tbAmtDue.Size = new System.Drawing.Size(120, 27);
            this.tbAmtDue.TabIndex = 0;
            this.tbAmtDue.TabStop = false;
            this.tbAmtDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.ForeColor = System.Drawing.Color.Black;
            this.lblFinish.Location = new System.Drawing.Point(220, 87);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(130, 16);
            this.lblFinish.TabIndex = 11;
            this.lblFinish.Text = "Accessories && Finish:";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.Black;
            this.lblSubtotal.Location = new System.Drawing.Point(281, 122);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(60, 16);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.Color.Black;
            this.lblTax.Location = new System.Drawing.Point(239, 157);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(102, 16);
            this.lblTax.TabIndex = 13;
            this.lblTax.Text = "Sales Tax (8%):";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(299, 192);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 16);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblTrade
            // 
            this.lblTrade.AutoSize = true;
            this.lblTrade.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrade.ForeColor = System.Drawing.Color.Black;
            this.lblTrade.Location = new System.Drawing.Point(216, 227);
            this.lblTrade.Name = "lblTrade";
            this.lblTrade.Size = new System.Drawing.Size(125, 16);
            this.lblTrade.TabIndex = 15;
            this.lblTrade.Text = "Trade-In Allowance:";
            this.lblTrade.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblAmtDue
            // 
            this.lblAmtDue.AutoSize = true;
            this.lblAmtDue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmtDue.ForeColor = System.Drawing.Color.Black;
            this.lblAmtDue.Location = new System.Drawing.Point(258, 265);
            this.lblAmtDue.Name = "lblAmtDue";
            this.lblAmtDue.Size = new System.Drawing.Size(83, 16);
            this.lblAmtDue.TabIndex = 16;
            this.lblAmtDue.Text = "Amount Due:";
            this.lblAmtDue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.ShowShortcutKeys = false;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator1,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.clearToolStripMenuItem.Text = "C&lear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.fontToolStripMenuItem.Text = "&Font...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.colorToolStripMenuItem.Text = "C&olor...";
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
            // Module6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 366);
            this.Controls.Add(this.lblAmtDue);
            this.Controls.Add(this.lblTrade);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.tbAmtDue);
            this.Controls.Add(this.tbTrade);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbTax);
            this.Controls.Add(this.tbSubtotal);
            this.Controls.Add(this.tbFinish);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.gbExterior);
            this.Controls.Add(this.gbAccessories);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Module6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Christopher\'s Car Center";
            this.Load += new System.EventHandler(this.Module6_Load);
            this.gbAccessories.ResumeLayout(false);
            this.gbAccessories.PerformLayout();
            this.gbExterior.ResumeLayout(false);
            this.gbExterior.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbAccessories;
        private System.Windows.Forms.GroupBox gbExterior;
        private System.Windows.Forms.CheckBox cbComputer;
        private System.Windows.Forms.CheckBox cbLeather;
        private System.Windows.Forms.CheckBox cbStereo;
        private System.Windows.Forms.RadioButton rbDetailing;
        private System.Windows.Forms.RadioButton rbPearlized;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbFinish;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.TextBox tbTax;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbTrade;
        private System.Windows.Forms.TextBox tbAmtDue;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTrade;
        private System.Windows.Forms.Label lblAmtDue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

