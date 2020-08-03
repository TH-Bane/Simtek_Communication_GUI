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
using System.Threading;

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
            panelServerPort = Int32.Parse(txtServerPort.Text);
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
            // 02 7C 30 30 30 45 30 34 43 37 34 44 30 30 30 39 46 34 7C 03                                            get all message
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

        IPEndPoint m_endPoint = null;
        IPEndPoint endPoint
        {
            get
            {
                if (m_endPoint == null)
                    m_endPoint = new IPEndPoint(IPAddress.Parse(panelIPAddress), panelServerPort);

                return m_endPoint;
            }
        }
        private Socket mClient = null;
        public Socket client
        {
            get
            {
                if (mClient == null)
                    mClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                return mClient;
            }
            set
            {
                if (mClient != null)
                {
                    // you are assigning a socket, and one is already assigned
                    // use this block of code to close the old socket (mClient) if needed, before assigning the new one
                }
                mClient = value;
            }
        }
        public void UDPsenddata(string IP, int port, string memoTXMsg)
        {
            panelClientPort = Int32.Parse(txtClientPort.Text);
            panelServerPort = Int32.Parse(txtServerPort.Text);

            byte[] packetData = convertMessage2Hex(memoTXMsg);      // Packet of Data goes here
            client.SendTimeout = 1;

            client.SendTo(packetData, endPoint);

            UDPreceivedata();
            

        }

        private Socket mServer = null;
        public Socket server
        {
            get
            {
                if (mServer == null)
                    mServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                return mServer;
            }
            set
            {
                if (mServer != null)
                {
                    // you are assigning a socket, and one is already assigned
                    // use this block of code to close the old socket (mClient) if needed, before assigning the new one
                }
                mServer = value;
            }
        }

        private static object ReadLock = new object();
        private int received = 0;
        public int Received
        {
            get
            {
                int result = 0;
                lock(ReadLock)
                {
                    result = received;
                }
                return result;
            }
            set
            {
                lock(ReadLock)
                {
                    received = value;
                }
            }
        }

        public void UDPreceivedata()
        {
            byte[] data = new byte[1024];

            panelClientPort = Int32.Parse(txtClientPort.Text);

            IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, panelClientPort);
            if (!server.IsBound)
            {
                server.Bind(endpoint);
            } 

            //trying this
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, panelClientPort);
            EndPoint tmpRemote = (EndPoint)sender;

            AutoResetEvent flag = new AutoResetEvent(false);
            Thread th = new Thread(() =>
            {
                //Your Socket begins here...
                Received = server.ReceiveFrom(data, ref tmpRemote);
                flag.Set();   //Release the AutoResetEvent
            });
            th.IsBackground = true;
            th.Start();
            flag.WaitOne(500); //Block the current thread for 5 seconds

            MemoRx.Text = Encoding.ASCII.GetString(data, 0, Received);
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
                UDPsenddata(panelIPAddress, panelServerPort, memoTXMsg);
                }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //UDPreceivedata();
        }
    }
}
