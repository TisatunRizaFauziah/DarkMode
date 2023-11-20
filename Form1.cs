using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkMode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            indonesia.Visible = false;
            inggris.Visible = true;
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2ToggleSwitch1.Checked==true)
            {
                this.BackColor = Color.FromArgb(34, 36, 49);
                label2.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                label2.ForeColor = Color.Black;
            }
        }

        private void indonesia_Click(object sender, EventArgs e)
        {
            if(indonesia.Visible==true)
            {
               indonesia.Visible = false;
                label2.Text = "Selamat DAtang di Aplikasi saya ";

            }
        }

        private void inggris_Click(object sender, EventArgs e)
        {
            if (inggris.Visible == false)
            {
                inggris.Visible = true;
                label2.Text = "Wolcome to my application ";

            }
        }
    }
}
