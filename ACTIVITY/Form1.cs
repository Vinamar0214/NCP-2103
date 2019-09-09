using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACTIVITY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack(); 
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward(); 
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (!(toolStripComboBox1.Text == ""))
            {
                webBrowser1.Navigate(toolStripComboBox1.Text);
                toolStripComboBox1.Items.Add(toolStripComboBox1.Text);
                if (toolStripComboBox1.Items.Count == 11)
                {
                    toolStripComboBox1.Items.RemoveAt(0);
                }
            } 

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@"https://www.google.com/search?q=" + toolStripTextBox1.Text); 
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = openFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
                webBrowser1.Navigate(openFileDialog1.FileName); 

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintDialog(); 
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog(); 
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowSaveAsDialog(); 
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
