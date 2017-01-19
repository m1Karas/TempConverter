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
        private float ferA, ferB, celA, celB, kelA, kelB;

        public MainCalc()
        {
            InitializeComponent();
        }

        public void ferToCel(float ferIn) //Fer to Cel conversion
        {
            celB = (ferIn - 32) * (5 / 9);
        }

        public void celToFer(float celIn) //Cel to Fer conversion
        {
            ferB = (celIn * 9 / 5) + 32;
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

        private void radioButton4_CheckedChanged(object sender, EventArgs e) //Fer out if true
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e) //Cel out if true
        { 

        }


        private void button1_Click(object sender, EventArgs e) //calculate
        {

        }   
    }
}
