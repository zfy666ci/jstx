using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using AsyncTcpClient;
using Lance_post_测试;

namespace WindowsFormsApp1
{
    public partial class Chat : Form
    {

        public static Chat form1;

        //声明公共变量
        private bool isExit = false;
        private delegate void SetListBoxCallback(string str);

        private delegate void SetRichTextBoxReceiveCallback(string str);
        private SetRichTextBoxReceiveCallback setRichTextBoxReceiveCallback;

        private delegate void SetcomboBoxCallback(string str);


         TcpClient client;
         NetworkStream networkStream;
        private EventWaitHandle allDone = new EventWaitHandle(false, EventResetMode.ManualReset);


        public Chat(TcpClient client1,NetworkStream networkStream1 ,Image pic, string name,string sex,string ip)

        {
            InitializeComponent();

            form1 = this;
            client = client1;
            networkStream = networkStream1;
            Console.WriteLine(client);
            Console.WriteLine(networkStream);
            name1.Text = name;
            sex1.Text = sex;
            pictureBox1.Image = pic;

  
            IPlabel1.Text = ip;


        }

        private void Chat_Load(object sender, EventArgs e)
        {
            setRichTextBoxReceiveCallback = new SetRichTextBoxReceiveCallback(SetRichTextBoxReceive);
            AsyncCallback requestCallback = new AsyncCallback(RequestCallback);


        }
        private void SetRichTextBoxReceive(string str)
        {
            richTextBoxReceive.AppendText("对方：" + DateTime.Now.ToString() + "\r\n" + str + "\r\n");
        }

        private void FChat_FormClosing(object sender, FormClosingEventArgs e)

        {
            isExit = true;
            allDone.Set();
        }

        private void RequestCallback(IAsyncResult ar)
        {
            //异步执行到此，说明BeginConnect已完成，但未结束，需要解除阻塞，并调用EndConnect
            allDone.Set();
            try
            {
                client = (TcpClient)ar.AsyncState;
                client.EndConnect(ar);           
                networkStream = client.GetStream();
                ReadObject readObject = new ReadObject(networkStream, client.ReceiveBufferSize);

                networkStream.BeginRead(readObject.bytes, 0, readObject.bytes.Length, ReadCallback, readObject);
            }
            catch (Exception err)
            {

                richTextBoxReceive.Invoke(setRichTextBoxReceiveCallback, err.Message);
                return;

            }
        }

        public static string TextGainCenter(string left, string right, string text)
        {
            //判断是否为null或者是empty
            if (string.IsNullOrEmpty(left))
                return "";
            if (string.IsNullOrEmpty(right))
                return "";
            if (string.IsNullOrEmpty(text))
                return "";
            //判断是否为null或者是empty

            int Lindex = text.IndexOf(left); //搜索left的位置

            if (Lindex == -1)
            { //判断是否找到left
                return "";
            }

            Lindex = Lindex + left.Length; //取出left右边文本起始位置

            int Rindex = text.IndexOf(right, Lindex);//从left的右边开始寻找right

            if (Rindex == -1)
            {//判断是否找到right
                return "";
            }

            return text.Substring(Lindex, Rindex - Lindex);//返回查找到的文本
        }

        private void ReadCallback(IAsyncResult ar)
        {
            //异步执行操作到此，说明BeginRead已完成
            try
            {
                ReadObject readObject = (ReadObject)ar.AsyncState;
                int count = readObject.netStream.EndRead(ar);
                string str = System.Text.Encoding.UTF8.GetString(readObject.bytes, 0, count);
                Console.WriteLine(str);

         

                string[] IPs = str.Split(';');


                int posization = str.IndexOf(";");
                if (posization != -1)
                {
                    str = str.Remove(posization);
                }

                int posization1 = str.IndexOf("*");
                if (posization1 != -1)
                {
                    string[] temp = str.Split('*');
           
                    richTextBoxReceive.Invoke(setRichTextBoxReceiveCallback, temp[0]);
                }
                else
                {
                    
                    richTextBoxReceive.Invoke(setRichTextBoxReceiveCallback, str);


                }

                if (isExit == false)
                {
                    readObject = new ReadObject(networkStream, client.ReceiveBufferSize);
                    networkStream.BeginRead(readObject.bytes, 0, readObject.bytes.Length, ReadCallback, readObject);
                }
            }
            catch (Exception ex)
            {
                richTextBoxReceive.Invoke(setRichTextBoxReceiveCallback, ex.Message);
            }
        }



        private void SendString(string str)
        {
            try
            { 
                byte[] bytesData = System.Text.Encoding.UTF8.GetBytes(str + "\r\n");
              
                networkStream.BeginWrite(bytesData, 0, bytesData.Length, new AsyncCallback(SendCallback), networkStream);
                ShowMsg1(str);

                    
                networkStream.Flush();
            }
            catch (Exception err)
            {

               
            }
        }
        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                networkStream.EndWrite(ar);
            }
            catch (Exception ex)
            {

             
            }
        }
        public void PlayForm()
        {
            int leftWidth = this.Left;
            int topWidth = this.Top;
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    this.Left -= 5;
                }
                else
                {
                    this.Left += 5;
                }
                if (i % 2 == 0)
                {
                    this.Top -= 5;
                }
                else
                {
                    this.Left += 5;
                }

                Thread.Sleep(25);
                this.Left = leftWidth;
                this.Top = topWidth;
            }
            this.Left = leftWidth;
            this.Top = topWidth;
        }

        public void ShowMsg(string str)
        {
            Console.WriteLine(str);

            richTextBoxReceive.AppendText(str + "\r\n");
        }
        private void ShowMsg1(string str)
        {
           
            string[] temp = str.Split(';');
            richTextBoxReceive.AppendText("自己："+ DateTime.Now.ToString() + "\r\n" + temp[0] + "\r\n");
        }

       

   


        private void button1_Click(object sender, EventArgs e)
        {
           




        }

        private void IPlabel1_Click(object sender, EventArgs e)
        {

        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            PlayForm();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            SendString(textBox2.Text + ";" + "120.12.86.126:55639" + ";");
            


              textBox2.Clear();
          
         
        }
    }
}
