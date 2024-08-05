using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
namespace HYItest
{
    public partial class Form1 : Form
    {
        private int baud;
        private string data;
        int[] z = { 0xFF, 0xFF, 0x54, 0x52, 0x00, 0x00, 0x33, 0x33, 0x23, 0x41, 0x9A, 0xB1, 0xB6, 0x44, 0x38, 0xB3, 0x1F, 0x42, 0x0A, 0x59, 0x03, 0x42, 0x85, 0x33, 0xAA, 0x44, 0x1A, 0x6B, 0x24, 0x42, 0xFE, 0x31, 0xE8, 0x41, 0x85, 0x53, 0xD0, 0x44, 0xAE, 0x5D, 0x24, 0x42, 0xC6, 0x7D, 0xE8, 0x41, 0xAE, 0x47, 0xC1, 0x3F, 0x48, 0xE1, 0xFA, 0x3E, 0xF6, 0x28, 0x1C, 0x3F, 0x79, 0x58, 0x28, 0x3D, 0x42, 0x60, 0x65, 0x3C, 0xFD, 0x87, 0x74, 0xBF, 0x5C, 0x8F, 0xA2, 0x40, 0x01, 0x82, 0x0D, 0x0A };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports)
            {
                comboBox1.Items.Add(port);
            }
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);

        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadLine();
            this.Invoke(new EventHandler(displayDataEvent));
        }

        private void displayDataEvent(object sender, EventArgs e)
        {
            //string[] a = data.Split(',');
            //takimID.Text = a[0];
            //irtifa.Text = a[1];
            //GPSirtifa.Text = a[2];
            //enlem.Text = a[3];
            //boylam.Text = a[4];
            //GyroX.Text = a[5];
            //GyroY.Text = a[6];
            //GyroZ.Text = a[7];
            //accX.Text = a[8];
            //accY.Text = a[9];
            //accZ.Text = a[10];
            //angle.Text = a[11];
            //status.Text = a[12];
            //crc.Text = a[13];
            byte[] buffer = System.Text.Encoding.ASCII.GetBytes(data);
            int[] ints = new int[]

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = baud;
                serialPort1.Open();
                button1.Enabled = false;
                button2.Enabled = true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Hata");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button2.Enabled = false;
                serialPort1.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Hata");
            }
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            baud = Int32.Parse(comboBox2.Text);
        }
    }
}
