using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bloodDonorLoad
{
    public partial class Form1 : Form
    {
        int supply = 1;
        int supply2 = 2;
        float initialPercentage = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //Control supply
            if (panel2.Size.Height > 10)
            {
                initialPercentage += supply;
                label2.Text = (int)initialPercentage + " %";
                panel2.Height = panel2.Height - supply;

            }
            else
            {
                label2.Text = "100 %";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(panel1.Height != 100)
            {
                panel1.Height = panel1.Height + supply2;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }
    }
}
