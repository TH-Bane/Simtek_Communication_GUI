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
        //----------------------------------------------------------------------------------------
        // name    : convertMessage2Hex(string inputString)                                       //
        // purpose : remove extra characters, corrects for whitespace,                            //
        //           return a byte with string input converted to hex string                      //
        // params  : a string input                                                               //
        // returns : byte[] of string converted to hex values                                     //
        // notes   : still needs error handling                                                   //
        //----------------------------------------------------------------------------------------
        public byte[] convertMessage2Hex(string inputString)
        {
            inputString = inputString.Replace("\r\n", "");                                                         // remove return and new line characters
            inputString = inputString.Replace("\n", "");                                                           // remove return new line characters

            if (!Char.IsWhiteSpace(inputString,2))                                                                 // adds white space every 2 characters
            {                                                                                                      // this actually keeps formatting the same
                for (int i = 2; i <= inputString.Length; i += 2)
                {
                    inputString = inputString.Insert(i, " ");
                    i++;
                }
            }

            inputString = inputString.Trim();                                                                      // remove leading or trailing whitespace

            List<byte> outputValue = new List<byte>();
            foreach (string element in inputString.Split(' '))                                                     // for each group of characters seperated by a space
            {
                outputValue.Add(Convert.ToByte(element, 16));                                                      // Add the converted hex byte to outputValue
            }
            return outputValue.ToArray();
        }

        IPEndPoint m_endPoint = null;
        IPEndPoint endPoint
        {
            get
            {
                if (m_endPoint == null)                                                                             // check to make sure an endpoint hasn't already been created
                    m_endPoint = new IPEndPoint(IPAddress.Parse(panelIPAddress), panelServerPort);                  // create endpoint with a specified address at a specified port

                return m_endPoint;
            }
        }
        private Socket mClient = null;
        public Socket client
        {
            get
            {
                if (mClient == null)
                    mClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);           // Initialize a new instance of a socket

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
            panelServerPort = Int32.Parse(txtServerPort.Text);                                                      // ensure that panelServerPort has the port from the user

            byte[] packetData = convertMessage2Hex(memoTXMsg);  // Packet of Data goes here                         // convert packet
            client.SendTimeout = 1;                                                                                 // low timeout so you don't have to wait forever for control back after trying to send a packet

            client.SendTo(packetData, endPoint);                                                                    // send out to proper IP (or instrument in our case)

            UDPreceivedata();
            

        }

        private Socket mServer = null;
        public Socket server
        {
            get
            {
                if (mServer == null)
                    mServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);           // Initialize a new instance of a socket

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


        //
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

        int RxCounter = 0;
        int RxCounterLimit = 500;
        public void UDPreceivedata()
        {
            byte[] data = new byte[1024];
            byte[] dataBuffer = new byte[1024];
            string stringBuffer = "";
            

            panelClientPort = Int32.Parse(txtClientPort.Text);

            IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, panelClientPort);
            if (!server.IsBound)
            {
                server.Bind(endpoint);
            } 

            IPEndPoint sender = new IPEndPoint(IPAddress.Any, panelClientPort);
            EndPoint tmpRemote = (EndPoint)sender;

            AutoResetEvent flag = new AutoResetEvent(false);
            Thread th = new Thread(() =>
            {
                //Your Socket begins here...
                if (Received >= 0)                                                                                  // make sure nothing strange happens to Received
                {
                    Received = server.ReceiveFrom(data, ref tmpRemote);                                             // Receives datagram into the data buffer and stores endpoint
                }
                flag.Set();   //Release the AutoResetEvent
            });
            th.IsBackground = true;                                                                                  
            th.Start();
            flag.WaitOne(500); //Block the current thread for .5 seconds

            stringBuffer = Encoding.ASCII.GetString(data, 0, Received);                                             // place Received data into string Buffer
            dataBuffer = Encoding.Default.GetBytes(stringBuffer);                                                   // convert Received data to hex bytes and place into data buffer
            var hexString = BitConverter.ToString(dataBuffer);                                                      // convert to a string
            hexString = hexString.Replace("-", " ");

            if(RxCounter <= RxCounterLimit)
            {
                MemoRx.AppendText("\n\r");
                MemoRx.AppendText("RX " + RxCounter.ToString("D3") + " -> ");                                           // formatting to RxCount to 3 places
                MemoRx.AppendText(hexString);                                                                           // output to MemoRx.Text
                MemoRx.ScrollToCaret();                                                                                 // ensure most recent data is always shown
                RxCounter++;
            }
            else
            {
                RxCounter = 0;
                MemoRx.AppendText("\n\r");
                MemoRx.AppendText("RX " + RxCounter.ToString("D3") + " -> ");                                           // formatting to RxCount to 3 places
                MemoRx.AppendText(hexString);                                                                           // output to MemoRx.Text
                MemoRx.ScrollToCaret();                                                                                 // ensure most recent data is always shown
                RxCounter++;
            }
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
