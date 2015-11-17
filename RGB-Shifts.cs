using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBTest
{
    public partial class Form1 : Form
    {

        int R = 0;
        int G = 0;
        int B = 255;

        int state = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void colorTimer_Tick(object sender, EventArgs e)
        {
            //-- Ticks every 10ms --//
            this.BackColor = Color.FromArgb(R, G, B);

            //-- Display the RGB information --//
            infoLabel.Text = "R: " + R.ToString();
            infoLabel.Text += "\nG: " + G.ToString();
            infoLabel.Text += "\nB: " + B.ToString();


            //-- Loop that cycles through three main states (colors) --//
            if (state == 0)
            {
                B--;
                R++;
                if (R >= 255)
                {
                    R = 255;
                    state = 1;
                }
            }

            else if (state == 1)
            {
                R--;
                G++;
                if (G >= 255)
                {
                    G = 255;
                    state = 2;
                }
            }

            else if (state == 2)
            {
                G--;
                B++;
                if (B >= 255)
                {
                    B = 255;
                    state = 0;
                }
            }

        }

    }
}
