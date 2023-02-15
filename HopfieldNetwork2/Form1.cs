using System;
using System.ComponentModel;

namespace HopfieldNetwork2
{
    public partial class Form1 : Form
    {
        int[] invec1 = new int[9] { -1, -1, -1, -1, -1, -1, -1, -1, -1};
        int[] row = new int[9];

        HopfieldNetwork hopfieldNetwork;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) 
        {
              
            if (checkBox1.Checked)
            {
                checkBox1.BackColor = Color.Black;
                invec1[0] = 1;
            }
            else
            {
                checkBox1.BackColor = Color.White;
                invec1[0] = -1;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.BackColor = Color.Black;
                invec1[1] = 1;
            }
            else
            {
                checkBox2.BackColor = Color.White;
                invec1[1] = -1;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.BackColor = Color.Black;
                invec1[2] = 1;
            }
            else
            {
                checkBox3.BackColor = Color.White;
                invec1[2] = -1;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox4.BackColor = Color.Black;
                invec1[3] = 1;
            }
            else
            {
                checkBox4.BackColor = Color.White;
                invec1[3] = -1;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox5.BackColor = Color.Black;
                invec1[4] = 1;
            }
            else
            {
                checkBox5.BackColor = Color.White;
                invec1[4] = -1;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox6.BackColor = Color.Black;
                invec1[5] = 1;
            }
            else
            {
                checkBox6.BackColor = Color.White;
                invec1[5] = -1;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox7.BackColor = Color.Black;
                invec1[6] = 1;
            }
            else
            {
                checkBox7.BackColor = Color.White;
                invec1[6] = -1;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                checkBox8.BackColor = Color.Black;
                invec1[7] = 1;
            }
            else
            {
                checkBox8.BackColor = Color.White;
                invec1[7] = -1;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                checkBox9.BackColor = Color.Black;
                invec1[8] = 1;
            }
            else
            {
                checkBox9.BackColor = Color.White;
                invec1[8] = -1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hopfieldNetwork = new HopfieldNetwork(invec1);

            if (hopfieldNetwork.CheckPattern() == 2)
            {
                label3.Text = "Pattern not recognized";
            }
            else if (hopfieldNetwork.CheckPattern() == 1)
            {
                checkBox10.BackColor = Color.White;
                checkBox11.BackColor = Color.Black;
                checkBox12.BackColor = Color.White;
                checkBox13.BackColor = Color.Black;
                checkBox14.BackColor = Color.Black;
                checkBox15.BackColor = Color.Black;
                checkBox16.BackColor = Color.White;
                checkBox17.BackColor = Color.Black;
                checkBox18.BackColor = Color.White;
                label3.Text = "Pattern recognized";
            }
            else if (hopfieldNetwork.CheckPattern() == 0)
            {
                checkBox10.BackColor = Color.White;
                checkBox11.BackColor = Color.White;
                checkBox12.BackColor = Color.White;
                checkBox13.BackColor = Color.Black;
                checkBox14.BackColor = Color.Black;
                checkBox15.BackColor = Color.Black;
                checkBox16.BackColor = Color.White;
                checkBox17.BackColor = Color.White;
                checkBox18.BackColor = Color.White;
                label3.Text = "Pattern recognized";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                    ((CheckBox)control).BackColor = Color.White;
                }
            }
        }
    }
}