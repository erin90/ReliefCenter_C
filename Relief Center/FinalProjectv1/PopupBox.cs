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
    public partial class PopupBox : Form
    {
        public string Input1
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        public PopupBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if(textBox1.Text != "")
            {
                Close();
            }
            else
            {
                MessageBox.Show("Please input a name");
            }
            
        }

        private void PopupBox_Load(object sender, EventArgs e)
        {

        }

        private void PopupBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void PopupBox_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
