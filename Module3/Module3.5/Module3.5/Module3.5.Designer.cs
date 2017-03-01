namespace Module3._
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
            this.gbCustInfo = new System.Windows.Forms.GroupBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbZip = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbCarDetails = new System.Windows.Forms.GroupBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblEndOdo = new System.Windows.Forms.Label();
            this.lblBeginOdo = new System.Windows.Forms.Label();
            this.tbEndOdo = new System.Windows.Forms.TextBox();
            this.tbDays = new System.Windows.Forms.TextBox();
            this.tbBeginOdo = new System.Windows.Forms.TextBox();
            this.gbTotals = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMiles = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbMiles = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbCustInfo.SuspendLayout();
            this.gbCarDetails.SuspendLayout();
            this.gbTotals.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustInfo
            // 
            this.gbCustInfo.Controls.Add(this.lblZip);
            this.gbCustInfo.Controls.Add(this.lblState);
            this.gbCustInfo.Controls.Add(this.lblAddress);
            this.gbCustInfo.Controls.Add(this.lblCity);
            this.gbCustInfo.Controls.Add(this.lblName);
            this.gbCustInfo.Controls.Add(this.tbZip);
            this.gbCustInfo.Controls.Add(this.tbState);
            this.gbCustInfo.Controls.Add(this.tbCity);
            this.gbCustInfo.Controls.Add(this.tbAddress);
            this.gbCustInfo.Controls.Add(this.tbName);
            this.gbCustInfo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustInfo.ForeColor = System.Drawing.Color.Black;
            this.gbCustInfo.Location = new System.Drawing.Point(25, 25);
            this.gbCustInfo.Name = "gbCustInfo";
            this.gbCustInfo.Size = new System.Drawing.Size(357, 160);
            this.gbCustInfo.TabIndex = 0;
            this.gbCustInfo.TabStop = false;
            this.gbCustInfo.Text = "Customer Information";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(200, 120);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(31, 18);
            this.lblZip.TabIndex = 9;
            this.lblZip.Text = "Zip:";
            this.lblZip.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(25, 120);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(44, 18);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "State:";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(25, 60);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 18);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(25, 90);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(36, 18);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(25, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 18);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbZip
            // 
            this.tbZip.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZip.Location = new System.Drawing.Point(275, 115);
            this.tbZip.Name = "tbZip";
            this.tbZip.Size = new System.Drawing.Size(50, 23);
            this.tbZip.TabIndex = 4;
            // 
            // tbState
            // 
            this.tbState.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbState.Location = new System.Drawing.Point(125, 115);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(40, 23);
            this.tbState.TabIndex = 3;
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(125, 85);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 23);
            this.tbCity.TabIndex = 2;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(125, 55);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(200, 23);
            this.tbAddress.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(125, 25);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 23);
            this.tbName.TabIndex = 0;
            // 
            // gbCarDetails
            // 
            this.gbCarDetails.Controls.Add(this.lblDays);
            this.gbCarDetails.Controls.Add(this.lblEndOdo);
            this.gbCarDetails.Controls.Add(this.lblBeginOdo);
            this.gbCarDetails.Controls.Add(this.tbEndOdo);
            this.gbCarDetails.Controls.Add(this.tbDays);
            this.gbCarDetails.Controls.Add(this.tbBeginOdo);
            this.gbCarDetails.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCarDetails.ForeColor = System.Drawing.Color.Black;
            this.gbCarDetails.Location = new System.Drawing.Point(25, 200);
            this.gbCarDetails.Name = "gbCarDetails";
            this.gbCarDetails.Size = new System.Drawing.Size(357, 125);
            this.gbCarDetails.TabIndex = 1;
            this.gbCarDetails.TabStop = false;
            this.gbCarDetails.Text = "Car Details";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.Location = new System.Drawing.Point(25, 90);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(99, 18);
            this.lblDays.TabIndex = 5;
            this.lblDays.Text = "Number of Day:";
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblEndOdo
            // 
            this.lblEndOdo.AutoSize = true;
            this.lblEndOdo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndOdo.Location = new System.Drawing.Point(25, 60);
            this.lblEndOdo.Name = "lblEndOdo";
            this.lblEndOdo.Size = new System.Drawing.Size(114, 18);
            this.lblEndOdo.TabIndex = 4;
            this.lblEndOdo.Text = "Ending Odometer:";
            this.lblEndOdo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblBeginOdo
            // 
            this.lblBeginOdo.AutoSize = true;
            this.lblBeginOdo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeginOdo.Location = new System.Drawing.Point(25, 30);
            this.lblBeginOdo.Name = "lblBeginOdo";
            this.lblBeginOdo.Size = new System.Drawing.Size(132, 18);
            this.lblBeginOdo.TabIndex = 3;
            this.lblBeginOdo.Text = "Beginning Odometer:";
            this.lblBeginOdo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbEndOdo
            // 
            this.tbEndOdo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndOdo.Location = new System.Drawing.Point(175, 55);
            this.tbEndOdo.Name = "tbEndOdo";
            this.tbEndOdo.Size = new System.Drawing.Size(100, 23);
            this.tbEndOdo.TabIndex = 1;
            // 
            // tbDays
            // 
            this.tbDays.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDays.Location = new System.Drawing.Point(175, 85);
            this.tbDays.Name = "tbDays";
            this.tbDays.Size = new System.Drawing.Size(50, 23);
            this.tbDays.TabIndex = 2;
            // 
            // tbBeginOdo
            // 
            this.tbBeginOdo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBeginOdo.Location = new System.Drawing.Point(175, 25);
            this.tbBeginOdo.Name = "tbBeginOdo";
            this.tbBeginOdo.Size = new System.Drawing.Size(100, 23);
            this.tbBeginOdo.TabIndex = 0;
            // 
            // gbTotals
            // 
            this.gbTotals.Controls.Add(this.lblTotal);
            this.gbTotals.Controls.Add(this.lblMiles);
            this.gbTotals.Controls.Add(this.tbTotal);
            this.gbTotals.Controls.Add(this.tbMiles);
            this.gbTotals.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotals.ForeColor = System.Drawing.Color.Black;
            this.gbTotals.Location = new System.Drawing.Point(400, 25);
            this.gbTotals.Name = "gbTotals";
            this.gbTotals.Size = new System.Drawing.Size(250, 100);
            this.gbTotals.TabIndex = 5;
            this.gbTotals.TabStop = false;
            this.gbTotals.Text = "Totals";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(25, 60);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(88, 18);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total Charge:";
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiles.Location = new System.Drawing.Point(25, 30);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(85, 18);
            this.lblMiles.TabIndex = 2;
            this.lblMiles.Text = "Miles Driven:";
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(125, 55);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 23);
            this.tbTotal.TabIndex = 1;
            this.tbTotal.TabStop = false;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMiles
            // 
            this.tbMiles.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMiles.Location = new System.Drawing.Point(125, 25);
            this.tbMiles.Name = "tbMiles";
            this.tbMiles.ReadOnly = true;
            this.tbMiles.Size = new System.Drawing.Size(100, 23);
            this.tbMiles.TabIndex = 0;
            this.tbMiles.TabStop = false;
            this.tbMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(400, 145);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(250, 50);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(400, 210);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(250, 50);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(400, 275);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(250, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 358);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.gbTotals);
            this.Controls.Add(this.gbCarDetails);
            this.Controls.Add(this.gbCustInfo);
            this.Name = "Form1";
            this.Text = "Rental Form";
            this.gbCustInfo.ResumeLayout(false);
            this.gbCustInfo.PerformLayout();
            this.gbCarDetails.ResumeLayout(false);
            this.gbCarDetails.PerformLayout();
            this.gbTotals.ResumeLayout(false);
            this.gbTotals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustInfo;
        private System.Windows.Forms.GroupBox gbCarDetails;
        private System.Windows.Forms.GroupBox gbTotals;
        private System.Windows.Forms.Label lblEndOdo;
        private System.Windows.Forms.Label lblBeginOdo;
        private System.Windows.Forms.TextBox tbDays;
        private System.Windows.Forms.TextBox tbEndOdo;
        private System.Windows.Forms.TextBox tbBeginOdo;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbZip;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbMiles;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

