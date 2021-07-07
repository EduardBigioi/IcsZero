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
            LabelClickAction(sender);

        }

        private void LabelClickAction(object sender)
        {
            if (((Label)sender).Text == "")
                if (b)
                {
                    ((Label)sender).Text = "0";
                    b = !b;
                }
                else
                {
                    ((Label)sender).Text = "1";
                    b = !b;
                }

            string winner = Winner();
            if (winner != "-1")
            {
                MessageBox.Show(winner);
                ResetBoard();
            }
        }

        private string Winner()
        {
            if (label1.Text == label2.Text && label2.Text == label3.Text && label1.Text != "")
            {
                return label1.Text;
            }
            if (label4.Text == label5.Text && label5.Text == label6.Text && label4.Text != "")
            {
                return label4.Text;
            }
            if (label7.Text == label8.Text && label8.Text == label9.Text && label7.Text != "")
            {
                return label7.Text;
            }
            if (label1.Text == label4.Text && label4.Text == label7.Text && label1.Text != "")
            {
                return label1.Text;
            }
            if (label2.Text == label5.Text && label5.Text == label8.Text && label2.Text != "")
            {
                return label2.Text;
            }
            if (label3.Text == label6.Text && label6.Text == label9.Text && label3.Text != "")
            {
                return label3.Text;
            }
            if (label1.Text == label5.Text && label5.Text == label9.Text && label1.Text != "")
            {
                return label1.Text;
            }
            if (label3.Text == label5.Text && label5.Text == label7.Text && label3.Text != "")
            {
                return label3.Text;
            }


            return "-1";
        }

        private void ResetBoard()
        {
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            LabelClickAction(sender);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            LabelClickAction(sender);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            LabelClickAction(sender);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LabelClickAction(sender);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LabelClickAction(sender);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            LabelClickAction(sender);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            LabelClickAction(sender);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            LabelClickAction(sender);
        }
    }
}
