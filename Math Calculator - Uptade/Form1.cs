using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Calculator___Uptade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
          
        }

        private void b2_Click(object sender, EventArgs e)
        {
            
        }

        private void b3_Click(object sender, EventArgs e)
        {
            
        }

        private void b4_Click(object sender, EventArgs e)
        {
          
        }

        private void b5_Click(object sender, EventArgs e)
        {
            
        }

        private void b6_Click(object sender, EventArgs e)
        {
            
        }

        private void b7_Click(object sender, EventArgs e)
        {
          
        }

        private void b8_Click(object sender, EventArgs e)
        {
            
        }
        //10 references (1->0)//
        private void wow(object sender, EventArgs e)
        {
            Button all = (Button)sender;
            result.Text = result.Text + all.Text;
        }

        private void clr_Click(object sender, EventArgs e)
        {
            result.Text = null;
        }
        // 4 references (+,-,/,*) //
        private void second_wow(object sender, EventArgs e)
        {
            Button all1 = (Button)sender;

            result.Text = result.Text + all1.Text;
        }
    }
}
