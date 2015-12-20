using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

//-- This a simple demonstration of a button that only reveals its text with a fading animation --//
//-- The user hovering their mouse over the button will trigger this event --//
namespace Test
{
    public partial class Form1 : Form
    {
        //-- Initial values for the fade animation --//
        int i = 0;
        int rate = -10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //-- Enable and start the timer on load --//
            fadeTimer.Enabled = true;
            fadeTimer.Start();
        }

        //-- Use the mouseEnter and mouseLeave methods to trigger the fading event --//
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            rate = -rate;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            rate = -rate;
        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            //-- Limit the variable within the RGB spectrum --//
            if (i >= 255)
            { i = 255; }

            if (i <= 0)
            { i = 0; }

            //-- Change the background color on every clock cycle --//
            button1.BackColor = Color.FromArgb(i, i, i);

            //-- Increment the RGB index --//
            i += rate;
        }
    }
}
