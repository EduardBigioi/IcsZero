using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IcsZero
{
    public partial class Form1 : Form
    {
        bool b = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (b)
            {
                label1.Text = "0";
                b = !b;
            }
            else
            {
                label1.Text = "1";
                b = !b;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
