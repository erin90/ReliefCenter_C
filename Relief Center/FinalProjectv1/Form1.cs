using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectv1
{
    public partial class Form1 : Form
    {
        ReliefCenter reliefC;
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopupBox a = new PopupBox();
            a.ShowDialog();
            label7.Text = a.Input1;
            label7.Text = label7.Text + " Relief Center";

            reliefC = new ReliefCenter(label7.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you want to exit?","Exit",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(exit == DialogResult.Yes){
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(reliefC.PrintInventory());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool textChar = false;
            bool numInt = false;
            if (comboBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                foreach (char input in textBox2.Text )
                {
                if (!Char.IsNumber(input))
                {
                    numInt = true;
                    break;
                }
                }
                foreach (char input1 in comboBox1.Text)
                {
                    if (!Char.IsLetter(input1))
                    {
                        textChar = true;
                        break;
                    }
                }
                foreach (char input2 in textBox3.Text)
                {
                    if (!Char.IsLetter(input2))
                    {
                        textChar = true;
                        break;
                    }
                }
                if (textChar || numInt)
                {
                    MessageBox.Show("Please enter a valid input.");
                }
                else
                {
                    string name = comboBox1.Text.ToUpper();
                    int amount = int.Parse(textBox2.Text);
                    string unit = textBox3.Text.ToUpper();
                    richTextBox1.AppendText(reliefC.AddNewGood(name, amount, unit));
                    comboBox1.Text = "Name";
                    textBox2.Text = "Release Rate";
                    textBox3.Text = "Unit";
                }
               
            }
            else
            {
                MessageBox.Show("Please fill up the missing fields!");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool textChar = false;
            bool numInt = false;
            if (comboBox2.Text != "" && textBox5.Text != "")
            {
                foreach (char input in textBox5.Text)
                {
                    if (!Char.IsNumber(input))
                    {
                        numInt = true;
                        break;
                    }
                }
                foreach (char input1 in comboBox2.Text)
                    {
                    if (!Char.IsLetter(input1))
                    {
                         textChar = true;
                         break;
                    }
                    }
                if (textChar || numInt)
                {
                    MessageBox.Show("Please enter a valid input.");
                }
                else
                {
                    string reliefGood = comboBox2.Text.ToUpper();
                    int amount = int.Parse(textBox5.Text);
                    richTextBox1.AppendText(reliefC.ReceiveGoods(reliefGood, amount));
                    comboBox2.Text = "Relief Good";
                    textBox5.Text = "Quantity";
                }
            }
            else
            {
                MessageBox.Show("Please fill up the missing fields!");
            }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            bool numInt = false;

            if (textBox6.Text != "")
            {
                foreach (char input in textBox6.Text)
                {
                    if (!Char.IsNumber(input))
                    {
                        numInt = true;
                        break;
                    }
                }
                if (numInt)
                {
                    MessageBox.Show("Please enter a valid input.");
                }
                else
                {
                    int packsAmt = int.Parse(textBox6.Text);
                    richTextBox1.AppendText(reliefC.ReleasePacks(packsAmt));
                    textBox6.Text = "Number of Packs";
                }
            }
            else
            {
                MessageBox.Show("Please fill up the missing fields!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(panel2.Width == 174)
            {
                panel2.Width = 57;
                richTextBox1.Width = 720;
                richTextBox1.Location = new Point(490, 136);
                groupBox2.Location = new Point(110, 136);
                groupBox3.Location = new Point(110, 309);
                groupBox4.Location = new Point(110, 477);
            }
            else
            {
                panel2.Width = 174;
                richTextBox1.Width = 635;
                richTextBox1.Location = new Point(614, 136);
                groupBox2.Location = new Point(230, 136);
                groupBox3.Location = new Point(230, 307);
                groupBox4.Location = new Point(230, 477);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(reliefC.PrintInventory());
        }
    }
}
