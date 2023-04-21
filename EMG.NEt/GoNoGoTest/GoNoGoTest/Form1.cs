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
        public Form1()
        {
            InitializeComponent();
        }

        
        private void buttonInicio_Click(object sender, EventArgs e)
        {
            int estimuloCount = 0;
            while (estimuloCount < 80)
            {
                // Randomly change color between green and red
                if (new Random().Next(2) == 0)
                {
                    //Monitor.BackColor = Color.Green;
                    serialPort1.Write("1,0,0,0,0");
                    tverde.Start();
                    //tverde.Stop();
                    tamarillo.Start();
                    //tverde.Stop();
                    

                }
                else
                {
                    //Monitor.BackColor = Color.Red;
                    serialPort1.Write("0,1,0,0,0");
                    trojo.Start();
                  //trojo.Stop();
                    tamarillo.Start();

                   // tamarillo.Stop();

                }

                // Increment estimulo count
                estimuloCount++;
                
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
           try
            {
                serialPort1.PortName = "COM5";
                serialPort1.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void tamarillo_Tick(object sender, EventArgs e)
        {
            Monitor.BackColor = Color.Yellow;
        }

        private void tverde_Tick(object sender, EventArgs e)
        {
            Monitor.BackColor = Color.Green;
        }

        private void trojo_Tick(object sender, EventArgs e)
        {
            Monitor.BackColor = Color.Red;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

        }
    }
}
