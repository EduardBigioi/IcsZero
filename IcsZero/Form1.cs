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
            if (label1.Text == "")
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
            if (label1.Text == label2.Text && label2.Text == label3.Text)
            {
                if (label1.Text == "0") MessageBox.Show("A castigat Toni");
                else MessageBox.Show("A castigat Dorel");
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
            }
            if (label1.Text == label4.Text && label4.Text == label7.Text)
            {
                if (label1.Text == "0") MessageBox.Show("A castigat Toni");
                else MessageBox.Show("A castigat Dorel");
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
            }
            if (label1.Text == label5.Text && label5.Text == label9.Text)
            {
                if (label1.Text == "0") MessageBox.Show("A castigat Toni");
                else MessageBox.Show("A castigat Dorel");
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "")
                if (b)
            {
                label2.Text = "0";
                b = !b;
            }
            else
            {
                label2.Text = "1";
                b = !b;
            }

            if (label1.Text == label2.Text && label2.Text == label3.Text)
            {
                if (label1.Text == "0") MessageBox.Show("A castigat Toni");
                else MessageBox.Show("A castigat Dorel");
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
            }
            if (label2.Text == label5.Text && label5.Text == label8.Text)
            {
                if (label1.Text == "0") MessageBox.Show("A castigat Toni");
                else MessageBox.Show("A castigat Dorel");
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
            }
          
        }

        // TODO faceti restul sa mearga :(
        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
                if (b)
            {
                label3.Text = "0";
                b = !b;
            }
            else
            {
                label3.Text = "1";
                b = !b;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.Text == "")
                if (b)
            {
                label6.Text = "0";
                b = !b;
            }
            else
            {
                label6.Text = "1";
                b = !b;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (label5.Text == "")
                if (b)
            {
                label5.Text = "0";
                b = !b;
            }
            else
            {
                label5.Text = "1";
                b = !b;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "")
                if (b)
            {
                label4.Text = "0";
                b = !b;
            }
            else
            {
                label4.Text = "1";
                b = !b;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (label9.Text == "")
                if (b)
            {
                label9.Text = "0";
                b = !b;
            }
            else
            {
                label9.Text = "1";
                b = !b;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (label8.Text == "")
                if (b)
            {
                label8.Text = "0";
                b = !b;
            }
            else
            {
                label8.Text = "1";
                b = !b;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (label7.Text == "")
                if (b)
            {
                label7.Text = "0";
                b = !b;
            }
            else
            {
                label7.Text = "1";
                b = !b;
            }
        }
    }
}
