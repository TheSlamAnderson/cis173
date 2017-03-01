namespace Module4
{
    partial class Module4
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbFinish = new System.Windows.Forms.TextBox();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.tbTax = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbTrade = new System.Windows.Forms.TextBox();
            this.tbAmtDue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbAccessories.SuspendLayout();
            this.gbExterior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.Black;
            this.btnCalc.Location = new System.Drawing.Point(35, 295);
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
            this.btnClear.Location = new System.Drawing.Point(184, 295);
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
            this.btnExit.Location = new System.Drawing.Point(333, 295);
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
            this.gbAccessories.Location = new System.Drawing.Point(15, 15);
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
            this.gbExterior.Location = new System.Drawing.Point(15, 150);
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
            this.tbPrice.Location = new System.Drawing.Point(358, 25);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(120, 23);
            this.tbPrice.TabIndex = 0;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(241, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Car Sales Price:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tbFinish
            // 
            this.tbFinish.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFinish.ForeColor = System.Drawing.Color.Black;
            this.tbFinish.Location = new System.Drawing.Point(358, 60);
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
            this.tbSubtotal.Location = new System.Drawing.Point(358, 95);
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
            this.tbTax.Location = new System.Drawing.Point(358, 130);
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
            this.tbTotal.Location = new System.Drawing.Point(358, 165);
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
            this.tbTrade.Location = new System.Drawing.Point(358, 200);
            this.tbTrade.Name = "tbTrade";
            this.tbTrade.Size = new System.Drawing.Size(120, 23);
            this.tbTrade.TabIndex = 1;
            this.tbTrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbAmtDue
            // 
            this.tbAmtDue.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmtDue.ForeColor = System.Drawing.Color.Black;
            this.tbAmtDue.Location = new System.Drawing.Point(358, 235);
            this.tbAmtDue.Name = "tbAmtDue";
            this.tbAmtDue.ReadOnly = true;
            this.tbAmtDue.Size = new System.Drawing.Size(120, 26);
            this.tbAmtDue.TabIndex = 0;
            this.tbAmtDue.TabStop = false;
            this.tbAmtDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(220, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Accessories && Finish:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(281, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Subtotal:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(239, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sales Tax (8%):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(299, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(216, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Trade-In Allowance:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(258, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Amount Due:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Module4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 341);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAmtDue);
            this.Controls.Add(this.tbTrade);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbTax);
            this.Controls.Add(this.tbSubtotal);
            this.Controls.Add(this.tbFinish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.gbExterior);
            this.Controls.Add(this.gbAccessories);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Name = "Module4";
            this.Text = "Christopher\'s Car Center";
            this.Load += new System.EventHandler(this.Module4_Load);
            this.gbAccessories.ResumeLayout(false);
            this.gbAccessories.PerformLayout();
            this.gbExterior.ResumeLayout(false);
            this.gbExterior.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFinish;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.TextBox tbTax;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbTrade;
        private System.Windows.Forms.TextBox tbAmtDue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

