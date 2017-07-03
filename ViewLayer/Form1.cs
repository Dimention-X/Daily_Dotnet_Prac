using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace ViewLayer
{
    public partial class Form1 : Form
    {
        StundetBAL sbobj = new StundetBAL();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = sbobj.insert(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
            if(result> 0)
            {
                MessageBox.Show("Insertion Sucessfull");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = sbobj.Delete(Convert.ToInt32(textBox1.Text));
            if (result > 0)
            {
                MessageBox.Show("Deletion Sucessfull");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int result = sbobj.Update(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
            if (result > 0)
            {
                MessageBox.Show("Updation Sucessfull");
            }
        }
    }
}
