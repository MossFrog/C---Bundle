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

        int R = 255;
        int G = 255;
        int B = 255;
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

            R--;

            if (R <= 0)
            {
                R = 0;
                G--;
            }
            
            if (G <= 0)
            {
                G = 0;
                B--;
            }

            if (B <= 0)
            {
                B = 0;
            }
        }

    }
}
