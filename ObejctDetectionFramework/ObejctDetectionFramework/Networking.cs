using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObejctDetectionFramework
{
    class Networking
    {
        private UdpClient client;
        private bool sending;
        //CancellationTokenSource ts;
        //List<Task> tasks;
        public bool Sending { get => sending; set => sending = value; }

        public Networking()
        {
            
            //tasks = new List<Task>();
        }

        public void Connect(string ip, int port)
        {
            client = new UdpClient();
            IPAddress ipadd;

            if (IPAddress.TryParse(ip, out ipadd))
            {
                client.Connect(new IPEndPoint(ipadd, port));
            }
            else
            {
                MessageBox.Show("Please input a valid IP address.");
            }
        }

        public void Disconnect()
        {
            if (client == null) return;
            //ts.Cancel();
            client.Close();
            Sending = false;
        }

        public void Send(string toSend)
        {
                byte[] bytesent = Encoding.ASCII.GetBytes(toSend.ToString());

                client.Send(bytesent, bytesent.Length);

                //MessageBox.Show("asd");
                //Thread.Sleep(2000);

            /*if (!sending)
            {
                //var t = Task.Run(() => SendData(toSend, ts.Token));
                ts = new CancellationTokenSource();
                tasks.Add(Task.Run(() => SendData(toSend, ts.Token)));
                //MessageBox.Show("started");
                //sendigTask.Start();
                sending = true;
            }*/
        }

        private void SendData(string toSend, CancellationToken ct)
        {
            while (!ct.IsCancellationRequested)
            {
                byte[] bytesent = Encoding.ASCII.GetBytes(toSend.ToString());

                client.Send(bytesent, bytesent.Length);

                //MessageBox.Show("asd");
                //Thread.Sleep(2000);
            }
        }
    }
}
