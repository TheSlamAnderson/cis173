namespace Module1
{
    partial class Module1
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
            this.btnSales = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnEmployment = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSales
            // 
            this.btnSales.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Location = new System.Drawing.Point(15, 60);
            this.btnSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(150, 50);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "Auto Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnService
            // 
            this.btnService.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.Location = new System.Drawing.Point(180, 60);
            this.btnService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(150, 50);
            this.btnService.TabIndex = 1;
            this.btnService.Text = "Service Center";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(15, 115);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(150, 50);
            this.btnDetail.TabIndex = 2;
            this.btnDetail.Text = "Detail Shop";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnEmployment
            // 
            this.btnEmployment.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployment.Location = new System.Drawing.Point(180, 115);
            this.btnEmployment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployment.Name = "btnEmployment";
            this.btnEmployment.Size = new System.Drawing.Size(150, 50);
            this.btnEmployment.TabIndex = 3;
            this.btnEmployment.Text = "Employment Opportunities";
            this.btnEmployment.UseVisualStyleBackColor = true;
            this.btnEmployment.Click += new System.EventHandler(this.btnEmployment_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(15, 15);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(313, 40);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(97, 170);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Christopher M. Anderson";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Module1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnEmployment);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnSales);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Module1";
            this.Text = "Christopher\'s Car Center";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnEmployment;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

