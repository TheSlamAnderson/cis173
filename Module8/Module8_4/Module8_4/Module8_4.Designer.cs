namespace Module8_4
{
    partial class Module8_4
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
            this.gbLookup = new System.Windows.Forms.GroupBox();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbAbb = new System.Windows.Forms.RadioButton();
            this.gbAnswer = new System.Windows.Forms.GroupBox();
            this.tbAbb = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblAbb = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLookup = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbLookup.SuspendLayout();
            this.gbAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLookup
            // 
            this.gbLookup.Controls.Add(this.rbName);
            this.gbLookup.Controls.Add(this.rbAbb);
            this.gbLookup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLookup.ForeColor = System.Drawing.Color.Black;
            this.gbLookup.Location = new System.Drawing.Point(18, 20);
            this.gbLookup.Name = "gbLookup";
            this.gbLookup.Size = new System.Drawing.Size(150, 125);
            this.gbLookup.TabIndex = 0;
            this.gbLookup.TabStop = false;
            this.gbLookup.Text = "Lookup:";
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Location = new System.Drawing.Point(25, 75);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(93, 20);
            this.rbName.TabIndex = 1;
            this.rbName.TabStop = true;
            this.rbName.Text = "State Name";
            this.rbName.UseVisualStyleBackColor = true;
            this.rbName.CheckedChanged += new System.EventHandler(this.rbAbb_CheckedChanged);
            // 
            // rbAbb
            // 
            this.rbAbb.AutoSize = true;
            this.rbAbb.Checked = true;
            this.rbAbb.Location = new System.Drawing.Point(25, 40);
            this.rbAbb.Name = "rbAbb";
            this.rbAbb.Size = new System.Drawing.Size(97, 20);
            this.rbAbb.TabIndex = 0;
            this.rbAbb.TabStop = true;
            this.rbAbb.Text = "Abbreviation";
            this.rbAbb.UseVisualStyleBackColor = true;
            this.rbAbb.CheckedChanged += new System.EventHandler(this.rbAbb_CheckedChanged);
            // 
            // gbAnswer
            // 
            this.gbAnswer.Controls.Add(this.tbAbb);
            this.gbAnswer.Controls.Add(this.tbName);
            this.gbAnswer.Controls.Add(this.lblAbb);
            this.gbAnswer.Controls.Add(this.lblName);
            this.gbAnswer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAnswer.ForeColor = System.Drawing.Color.Black;
            this.gbAnswer.Location = new System.Drawing.Point(198, 20);
            this.gbAnswer.Name = "gbAnswer";
            this.gbAnswer.Size = new System.Drawing.Size(275, 125);
            this.gbAnswer.TabIndex = 1;
            this.gbAnswer.TabStop = false;
            this.gbAnswer.Text = "Answer:";
            // 
            // tbAbb
            // 
            this.tbAbb.ForeColor = System.Drawing.Color.Black;
            this.tbAbb.Location = new System.Drawing.Point(124, 68);
            this.tbAbb.Name = "tbAbb";
            this.tbAbb.ReadOnly = true;
            this.tbAbb.Size = new System.Drawing.Size(50, 23);
            this.tbAbb.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(124, 33);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 23);
            this.tbName.TabIndex = 2;
            // 
            // lblAbb
            // 
            this.lblAbb.AutoSize = true;
            this.lblAbb.Location = new System.Drawing.Point(25, 75);
            this.lblAbb.Name = "lblAbb";
            this.lblAbb.Size = new System.Drawing.Size(84, 16);
            this.lblAbb.TabIndex = 1;
            this.lblAbb.Text = "Abbreviation:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "State Name:";
            // 
            // btnLookup
            // 
            this.btnLookup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookup.ForeColor = System.Drawing.Color.Black;
            this.btnLookup.Location = new System.Drawing.Point(34, 163);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(125, 30);
            this.btnLookup.TabIndex = 2;
            this.btnLookup.Text = "Lookup";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(184, 163);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(334, 163);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Module8_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 211);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.gbAnswer);
            this.Controls.Add(this.gbLookup);
            this.Name = "Module8_4";
            this.Text = "State Names";
            this.Load += new System.EventHandler(this.Module8_4_Load);
            this.gbLookup.ResumeLayout(false);
            this.gbLookup.PerformLayout();
            this.gbAnswer.ResumeLayout(false);
            this.gbAnswer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLookup;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbAbb;
        private System.Windows.Forms.GroupBox gbAnswer;
        private System.Windows.Forms.TextBox tbAbb;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblAbb;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

