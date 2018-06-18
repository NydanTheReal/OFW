using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObejctDetectionFramework
{
    public partial class Form1 : Form
    {
        Networking network;
        ObjectDetection cv;
        CancellationTokenSource ts;
        CancellationTokenSource ts2;
        string sendData;

        public Form1()
        {
            InitializeComponent();
            network = new Networking();
            cv = new ObjectDetection();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (network.Sending) return;

            string ip = txtIP.Text;
            int port;


            if (Int32.TryParse(txtPort.Text, out port))
            {
                network.Connect(ip, port);
                ts = new CancellationTokenSource();
                Task.Run(() =>
                {
                    while (!ts.Token.IsCancellationRequested)
                    {
                        network.Sending = true;
                        network.Send(sendData);
                        lstPackets.BeginInvoke(new Action(() =>
                        {
                            string time = DateTime.Now.ToLongTimeString();
                            //sendData = "random stuff";
                            lstPackets.Items.Clear();
                            lstPackets.Items.Add("At " + time + ": packet sent:" + sendData);
                        }));
                        Thread.Sleep(10);
                    }
                });
                lblStatus.Text = "Status: Sending...";
            }
            else
            {
                MessageBox.Show("Please enter a number as port.");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ts.Cancel();
            network.Disconnect();
            lblStatus.Text = "Status: Not sending";
        }

        private void btnWindows_Click(object sender, EventArgs e)
        {
            cv.createWindows(chbRaw.Checked, chbHSV.Checked, chbEdited.Checked);
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            ts2 = new CancellationTokenSource();
            Task.Run(() =>
            {
                while (!ts2.Token.IsCancellationRequested)
                {
                    cv.loop();
                    sendData = cv.SendData;

                    /*for (int i = 0; i < cv.Circ.Length; i++)
                    {
                        lstCircles.BeginInvoke(new Action(() =>
                        {
                            int y = i;
                           // if(y < cv.Circ.Length) lstCircles.Items.Add("Circle " + y + " X:" + cv.Circ[y].Center.X + " Y:" + cv.Circ[y].Center.Y);
                        }));
                    }
                    Thread.Sleep(10);*/
                }
            });
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            ts2.Cancel();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblMin.Text = trcMin.Value.ToString();
            cv.MinRad = trcMin.Value;
        }

        private void trcMax_Scroll(object sender, EventArgs e)
        {
            lblMax.Text = trcMax.Value.ToString();
            cv.MaxRad = trcMax.Value;
        }

        private void trcPar1_Scroll(object sender, EventArgs e)
        {
            lblPar1.Text = trcPar1.Value.ToString();
            cv.Par1 = trcPar1.Value;
        }

        private void trcPar2_Scroll(object sender, EventArgs e)
        {
            lblPar2.Text = trcPar2.Value.ToString();
            cv.Par2 = trcPar2.Value;
        }
    }
}
