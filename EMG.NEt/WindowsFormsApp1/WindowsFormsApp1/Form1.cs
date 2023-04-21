using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoNoGoTest
{
    public partial class Form1 : Form
    {
        private int tiempo;
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonInicio_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo++;
           for(int i = 0; i <= 80; i++)
            {
                if (new Random().Next(2) == 0)
                {

                }
            }
            
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*    try
                {
                    serialPort1.WriteLine("&On");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                } */
        }

           
    }
}
