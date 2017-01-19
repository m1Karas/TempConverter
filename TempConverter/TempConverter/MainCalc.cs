using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverter
{
    public partial class MainCalc : Form
    {
        private float fer, cel;

        public MainCalc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //input
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //output
        {

        }
      

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //Fer in if true
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //Cel in if true
        {

        }


        private void button1_Click(object sender, EventArgs e) //calculate
        {
            if (radioButton1.Checked) //Fer to Cel conversion
            {
                fer = float.Parse(textBox1.Text);
                cel = (fer - 32) * 5 / 9;
                textBox2.Text = Convert.ToString(cel);
            }
            else if (radioButton2.Checked) //Cel to Fer conversion
            {
                cel = float.Parse(textBox1.Text);
                fer = (cel * 9 / 5) + 32;
                textBox2.Text = Convert.ToString(fer);
            }
            /*else
            {

            }
            */
        }   
    }
}
