using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace TylerTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureSimtekLogo_Click(object sender, EventArgs e)
        {
            // Launch browser to SimtekInc...
            System.Diagnostics.Process.Start("http://www.simtekinc.com");
        }

        public string panelIPAddress = "192.168.136.90";
        protected void txtIPAddress_TextChanged(object sender, EventArgs e)
        {
            panelIPAddress = txtIPAddress.Text;
        }

        public int panelServerPort = 27000;
        protected void txtServerPort_TextChanged(object sender, EventArgs e)
        {
            panelServerPort = Int32.Parse(txtClientPort.Text);
        }

        public int panelClientPort = 27000;
        protected void txtClientPort_TextChanged(object sender, EventArgs e)
        {
            panelClientPort = Int32.Parse(txtClientPort.Text);
        }

        public string memoTXMsg = null;
        protected void MemoTx_TextChanged(object sender, EventArgs e)
        {
            memoTXMsg = MemoTx.Text;
        }

        public byte[] convertMessage2Hex(string inputString)
        {
            //string inputString = "02 7C 30 30 30 45 30 34 43 37 34 43 30 30 30 31 45 42 7C 03";
            inputString = inputString.Replace("\r\n", "");                                                         // remove return and new line characters
            inputString = inputString.Replace("\n", "");                                                           // remove return new line characters

            if (!Char.IsWhiteSpace(inputString,2))
            {
                for (int i = 2; i <= inputString.Length; i += 2)
                {
                    inputString = inputString.Insert(i, " ");
                    i++;
                }
            }

            inputString = inputString.Trim();                                                                                    // remove leading or trailing whitespace

            List<byte> outputValue = new List<byte>();
            foreach (string element in inputString.Split(' ')) // for each group of characters seperated by a space
            {
                outputValue.Add(Convert.ToByte(element, 16));
            }
            return outputValue.ToArray();
        }

        public void UDPsenddata(string IP, int port, string memoTXMsg)
        {
            byte[] packetData = System.Text.ASCIIEncoding.ASCII.GetBytes(memoTXMsg);      // Packet of Data goes here

            //string IP = "127.0.0.1";
            //int port = 51021;

            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), port);

            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            client.SendTimeout = 1;

            client.SendTo(packetData, ep);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            //UDPSocket s = new UDPSocket();
            //s.Server("127.0.0.1", 27000);

            //UDPSocket c = new UDPSocket();
            //c.Client("127.0.0.1", 27000);
            //c.Send("TEST!");


            Console.ReadKey();
        }

        private void MemoTx_Enter(object sender, EventArgs e)
        {
            MemoTx.Text = "";
        }

        private void buttonbutt_Click(object sender, EventArgs e)
        {

        }

        private void MemoTx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                {
                UDPsenddata(panelIPAddress, panelClientPort, memoTXMsg);
                }

        }
    }
}
