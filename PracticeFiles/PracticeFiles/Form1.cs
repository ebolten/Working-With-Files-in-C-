using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PracticeFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            try
            {
                String text = System.IO.File.ReadAllText(@"C:text.txt");
                label1.Text = text;
            }
            catch
            {
                label1.Text = "File Not Found";
            }
            btnMenu.Visible = true;
            btnFile.Visible = false;
            btnWrite.Visible = false;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            btnFile.Visible = false;
            btnWrite.Visible = false;
            textBoxWrite.Visible = true;
            btnChange.Visible = true;
            label2.Visible = true;
        }

        private void textBoxWrite_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            String text = textBoxWrite.Text;
            String[] lines = Regex.Split(text, @"(?<=[.!?;])");
            
            try
            {
                System.IO.File.WriteAllLines(@"C:text.txt", lines);
            }
            catch
            {
                label1.Text = "File Not Found.";
            }
            btnFile.Visible = true;
            btnWrite.Visible = true;
            textBoxWrite.Visible = false;
            btnChange.Visible = false;
            label2.Visible = false;
            textBoxWrite.Text = "";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            btnMenu.Visible = false;
            label1.Text = "";
            btnFile.Visible = true;
            btnWrite.Visible = true;
        }
    }
}

