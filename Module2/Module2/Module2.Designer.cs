namespace Module2
{
    partial class Module2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Module2));
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.pbSales = new System.Windows.Forms.PictureBox();
            this.pbService = new System.Windows.Forms.PictureBox();
            this.pcDetail = new System.Windows.Forms.PictureBox();
            this.pbEmployment = new System.Windows.Forms.PictureBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pbClear = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.cbHours = new System.Windows.Forms.CheckBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblEmployment = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.gbMsgColor = new System.Windows.Forms.GroupBox();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.lblHours = new System.Windows.Forms.Label();
            this.rbGrey = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.gbMsgColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(15, 15);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(463, 40);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToolTip.SetToolTip(this.lblMessage, "Special Notes");
            // 
            // lblAuthor
            // 
            this.lblAuthor.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(12, 385);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(463, 20);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Christopher M. Anderson";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbSales
            // 
            this.pbSales.Image = ((System.Drawing.Image)(resources.GetObject("pbSales.Image")));
            this.pbSales.Location = new System.Drawing.Point(15, 125);
            this.pbSales.Name = "pbSales";
            this.pbSales.Size = new System.Drawing.Size(100, 100);
            this.pbSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSales.TabIndex = 7;
            this.pbSales.TabStop = false;
            this.ToolTip.SetToolTip(this.pbSales, "Click Here For Auto Sales");
            this.pbSales.Click += new System.EventHandler(this.pbSales_Click);
            // 
            // pbService
            // 
            this.pbService.Image = ((System.Drawing.Image)(resources.GetObject("pbService.Image")));
            this.pbService.Location = new System.Drawing.Point(136, 125);
            this.pbService.Name = "pbService";
            this.pbService.Size = new System.Drawing.Size(100, 100);
            this.pbService.TabIndex = 8;
            this.pbService.TabStop = false;
            this.ToolTip.SetToolTip(this.pbService, "Click Here For The Service Center");
            this.pbService.Click += new System.EventHandler(this.pbService_Click);
            // 
            // pcDetail
            // 
            this.pcDetail.Image = ((System.Drawing.Image)(resources.GetObject("pcDetail.Image")));
            this.pcDetail.Location = new System.Drawing.Point(257, 125);
            this.pcDetail.Name = "pcDetail";
            this.pcDetail.Size = new System.Drawing.Size(100, 100);
            this.pcDetail.TabIndex = 9;
            this.pcDetail.TabStop = false;
            this.ToolTip.SetToolTip(this.pcDetail, "Click Here For The Detail Shop");
            this.pcDetail.Click += new System.EventHandler(this.pcDetail_Click);
            // 
            // pbEmployment
            // 
            this.pbEmployment.Image = ((System.Drawing.Image)(resources.GetObject("pbEmployment.Image")));
            this.pbEmployment.Location = new System.Drawing.Point(378, 125);
            this.pbEmployment.Name = "pbEmployment";
            this.pbEmployment.Size = new System.Drawing.Size(100, 100);
            this.pbEmployment.TabIndex = 10;
            this.pbEmployment.TabStop = false;
            this.ToolTip.SetToolTip(this.pbEmployment, "Click Here For Employment Opportunities");
            this.pbEmployment.Click += new System.EventHandler(this.pbEmployment_Click);
            // 
            // pbClear
            // 
            this.pbClear.Image = ((System.Drawing.Image)(resources.GetObject("pbClear.Image")));
            this.pbClear.Location = new System.Drawing.Point(257, 265);
            this.pbClear.Name = "pbClear";
            this.pbClear.Size = new System.Drawing.Size(100, 100);
            this.pbClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbClear.TabIndex = 15;
            this.pbClear.TabStop = false;
            this.ToolTip.SetToolTip(this.pbClear, "Click Here To Clear The Message");
            this.pbClear.Click += new System.EventHandler(this.pbClear_Click);
            // 
            // pbExit
            // 
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(378, 265);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(100, 100);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbExit.TabIndex = 16;
            this.pbExit.TabStop = false;
            this.ToolTip.SetToolTip(this.pbExit, "Click Here To Exit The Program");
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // cbHours
            // 
            this.cbHours.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHours.Location = new System.Drawing.Point(15, 60);
            this.cbHours.Name = "cbHours";
            this.cbHours.Size = new System.Drawing.Size(100, 20);
            this.cbHours.TabIndex = 0;
            this.cbHours.Text = "Our Hours";
            this.ToolTip.SetToolTip(this.cbHours, "Click Here To Display Our Hours");
            this.cbHours.UseVisualStyleBackColor = true;
            this.cbHours.CheckedChanged += new System.EventHandler(this.cbHours_CheckedChanged);
            // 
            // lblSales
            // 
            this.lblSales.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.Location = new System.Drawing.Point(15, 105);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(100, 18);
            this.lblSales.TabIndex = 0;
            this.lblSales.Text = "Auto Sales";
            this.lblSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblService
            // 
            this.lblService.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(136, 105);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(100, 18);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Service Center";
            this.lblService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetail
            // 
            this.lblDetail.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.Location = new System.Drawing.Point(257, 105);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(100, 18);
            this.lblDetail.TabIndex = 0;
            this.lblDetail.Text = "Detail Shop";
            this.lblDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployment
            // 
            this.lblEmployment.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployment.Location = new System.Drawing.Point(378, 105);
            this.lblEmployment.Name = "lblEmployment";
            this.lblEmployment.Size = new System.Drawing.Size(100, 18);
            this.lblEmployment.TabIndex = 0;
            this.lblEmployment.Text = "Employment";
            this.lblEmployment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClear
            // 
            this.lblClear.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.Location = new System.Drawing.Point(257, 245);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(100, 18);
            this.lblClear.TabIndex = 0;
            this.lblClear.Text = "Clear Message";
            this.lblClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExit
            // 
            this.lblExit.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(378, 245);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(100, 18);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "Exit Program";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbMsgColor
            // 
            this.gbMsgColor.Controls.Add(this.rbGrey);
            this.gbMsgColor.Controls.Add(this.rbBlue);
            this.gbMsgColor.Controls.Add(this.rbGreen);
            this.gbMsgColor.Controls.Add(this.rbRed);
            this.gbMsgColor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMsgColor.ForeColor = System.Drawing.Color.Black;
            this.gbMsgColor.Location = new System.Drawing.Point(15, 245);
            this.gbMsgColor.Name = "gbMsgColor";
            this.gbMsgColor.Size = new System.Drawing.Size(221, 120);
            this.gbMsgColor.TabIndex = 1;
            this.gbMsgColor.TabStop = false;
            this.gbMsgColor.Text = "Change Message Color:";
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBlue.ForeColor = System.Drawing.Color.Blue;
            this.rbBlue.Location = new System.Drawing.Point(125, 75);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(50, 22);
            this.rbBlue.TabIndex = 3;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGreen.ForeColor = System.Drawing.Color.Green;
            this.rbGreen.Location = new System.Drawing.Point(125, 35);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(61, 22);
            this.rbGreen.TabIndex = 2;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbGreen_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRed.ForeColor = System.Drawing.Color.Red;
            this.rbRed.Location = new System.Drawing.Point(25, 75);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(48, 22);
            this.rbRed.TabIndex = 1;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // lblHours
            // 
            this.lblHours.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.ForeColor = System.Drawing.Color.Red;
            this.lblHours.Location = new System.Drawing.Point(115, 60);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(200, 20);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "Open 24 Hours - 7 Days A Week";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbGrey
            // 
            this.rbGrey.AutoSize = true;
            this.rbGrey.Checked = true;
            this.rbGrey.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGrey.ForeColor = System.Drawing.Color.Gray;
            this.rbGrey.Location = new System.Drawing.Point(25, 35);
            this.rbGrey.Name = "rbGrey";
            this.rbGrey.Size = new System.Drawing.Size(53, 22);
            this.rbGrey.TabIndex = 0;
            this.rbGrey.TabStop = true;
            this.rbGrey.Text = "Gray";
            this.rbGrey.UseVisualStyleBackColor = true;
            this.rbGrey.CheckedChanged += new System.EventHandler(this.rbGrey_CheckedChanged);
            // 
            // Module2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 416);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.cbHours);
            this.Controls.Add(this.gbMsgColor);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbClear);
            this.Controls.Add(this.lblEmployment);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.pbEmployment);
            this.Controls.Add(this.pcDetail);
            this.Controls.Add(this.pbService);
            this.Controls.Add(this.pbSales);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Module2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Christopher\'s Car Center";
            ((System.ComponentModel.ISupportInitialize)(this.pbSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.gbMsgColor.ResumeLayout(false);
            this.gbMsgColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.PictureBox pbSales;
        private System.Windows.Forms.PictureBox pbService;
        private System.Windows.Forms.PictureBox pcDetail;
        private System.Windows.Forms.PictureBox pbEmployment;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblEmployment;
        private System.Windows.Forms.PictureBox pbClear;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.GroupBox gbMsgColor;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.CheckBox cbHours;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.RadioButton rbGrey;
    }
}

