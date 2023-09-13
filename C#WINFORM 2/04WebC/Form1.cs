using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//추가
using System.Net;
using System.Net.Http;
using System.Threading;
using System.IO;
using System.IO.Ports;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (SerialPort.GetPortNames().Length > 0)
            {
                foreach (string portnumber in SerialPort.GetPortNames())
                {
                    com_port.Items.Add(portnumber);
                }
                com_port.SelectedIndex = 0;
            }
            else
            {
                this.com_port.Items.AddRange(new object[] {
                    "COM1",
                    "COM2",
                    "COM3",
                    "COM4",
                    "COM5",
                    "COM6",
                    "COM7",
                    "COM8",
                    "COM9",
                    "COM10",
                    "COM11",
                    "COM12"});
                com_port.SelectedIndex = 0;
            }
        }

        //--------------------------------------
        //백그라운드 메시지 수신 스레드 참조변수
        //--------------------------------------
        private BackgroundWorker recvLedworker;
        private BackgroundWorker recvTmpworker;
        private BackgroundWorker recvLightworker;
        private BackgroundWorker recvDistanceworker;

        private void conn_btn_Click(object sender, EventArgs e)
        {
            String port = this.com_port.Items[this.com_port.SelectedIndex].ToString();
            Console.WriteLine("PORT : " + port);
            HttpWebRequest request = null;
            HttpWebResponse response = null;

            try {
            request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/connection/" + port);
            request.Method = "GET";
            request.ContentType = "application/json";
            //request.Timeout = 30 * 1000;

            response = (HttpWebResponse)request.GetResponse();
            Console.WriteLine("RESPONSE CODE : " + response.StatusCode);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("RESPONSE CODE : " + response.StatusCode);
                //-----------------------------------
                //수신 스레드 객체 생성 & 스레드 등록
                //-----------------------------------
                //LED
                recvLedworker = new BackgroundWorker();
                recvLedworker.DoWork += recvLedInfo;
                //TMP
                recvTmpworker = new BackgroundWorker();
                recvTmpworker.DoWork += recvTmpInfo;
                //LIGHT
                recvLightworker = new BackgroundWorker();
                recvLightworker.DoWork += recvLightInfo;
                //DISTANCE
                recvDistanceworker = new BackgroundWorker();
                recvDistanceworker.DoWork += recvDistanceInfo;

                //-----------------
                //수신 스레드 실행
                //-----------------
                recvLedworker.RunWorkerAsync();
                recvTmpworker.RunWorkerAsync();
                recvLightworker.RunWorkerAsync();
                recvDistanceworker.RunWorkerAsync();
            }
          } catch(Exception ex)
            {
                Console.WriteLine("EX : " + ex);
            }
        }

        private void recvLedInfo(object sender, DoWorkEventArgs e)
        {
            while(!recvLedworker.CancellationPending)
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/message/led");
                request.Method = "GET";
                request.ContentType = "application/json";
                //request.Timeout = 30 * 1000;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);

                //Invoke(new Action()=>{})
                Invoke(new Action(() =>
                {
                    this.led_txt.Text = reader.ReadToEnd();
                }));

                Thread.Sleep(1000);
            }
        }

        private void recvTmpInfo(object sender, DoWorkEventArgs e)
        {
            while (!recvTmpworker.CancellationPending)
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/message/tmp");
                request.Method = "GET";
                request.ContentType = "application/json";
                //request.Timeout = 30 * 1000;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);

                //Invoke(new Action()=>{})
                Invoke(new Action(() =>
                {
                    this.tmp_txt.Text = reader.ReadToEnd();
                }));

                Thread.Sleep(1000);
            }
        }

        private void recvLightInfo(object sender, DoWorkEventArgs e)
        {
            while (!recvLightworker.CancellationPending)
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/message/light");
                request.Method = "GET";
                request.ContentType = "application/json";
                //request.Timeout = 30 * 1000;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);

                //Invoke(new Action()=>{})
                Invoke(new Action(() =>
                {
                    this.light_txt.Text = reader.ReadToEnd();
                }));

                Thread.Sleep(1000);
            }
        }

        private void recvDistanceInfo(object sender, DoWorkEventArgs e)
        {
            while (!recvDistanceworker.CancellationPending)
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/message/distance");
                request.Method = "GET";
                request.ContentType = "application/json";
                //request.Timeout = 30 * 1000;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);

                //Invoke(new Action()=>{})
                Invoke(new Action(() =>
                {
                    this.dis_txt.Text = reader.ReadToEnd();
                }));

                Thread.Sleep(1000);
            }
        }

        private void led_on_btn_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/led/1");
            request.Method = "GET";
            request.ContentType = "application/json";
            //request.Timeout = 30 * 1000;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        }

        private void led_off_btn_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/led/0");
            request.Method = "GET";
            request.ContentType = "application/json";
            //request.Timeout = 30 * 1000;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        }
    }
}
