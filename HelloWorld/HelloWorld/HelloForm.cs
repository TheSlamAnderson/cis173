using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void messageLabel_Click(object sender, EventArgs e)
        {

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // Display The Hello World Message.

            messageLabel.Text = "Hello World";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit The Project.

            this.Close();
        }
    }
}