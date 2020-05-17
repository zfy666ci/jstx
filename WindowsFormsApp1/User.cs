using _CUSTOM_CONTROLS._ChatListBox;
using Lance_post_测试;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using AsyncTcpClient;



namespace WindowsFormsApp1
{
    public partial class userfrom : Form
    {
        string getstr = "";
        private bool isExit = false;

        private delegate void SetListBoxCallback(string str);

        private delegate void SetRichTextBoxReceiveCallback(string str);

        private SetRichTextBoxReceiveCallback setRichTextBoxReceiveCallback;
        private delegate void SetcomboBoxCallback(string str);


        public  TcpClient client;
        public NetworkStream networkStream;
        private EventWaitHandle allDone = new EventWaitHandle(false, EventResetMode.ManualReset);

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

                if (str.Contains("务器已连接") == true)
                {
                    str = "*" + str;
                    string ip = TextGainCenter("*", "服务器", str);
                    Lance_post_测试.HttpHelper http = new HttpHelper();
                    Lance_post_测试.HttpItem item = new HttpItem();
                    HttpResult result = new HttpResult();

                    item = new HttpItem()
                    {
                        URL = "http://localhost/api/login/ipupdata",//URL     必需项
                        UserAgent = "Mozilla/4.0 (compatible; MSIE 9.0; Windows NT 6.1)",
                        Method = "post",
                        Postdata = "ip=" + ip + "&user=" + "zfy666ci",
                        ContentType = "application/x-www-form-urlencoded; Charset=UTF-8",
                        Accept = "*/*",
                    };
                    result = http.GetHtml(item);
                    Console.WriteLine(ip);
                    Console.WriteLine("IP更新完毕");



                };


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
              
            }
        }

        public userfrom( string userinfo)
        { 

            
            JObject job = JObject.Parse(userinfo);
            Console.WriteLine(userinfo);


            string img = job["img"].ToString();
            InitializeComponent();
            pictureBox1.LoadAsync(img);
            Name1.Text = job["name"].ToString();
            getstr = job["id"].ToString();

         
 


            if (job["sex"].ToString() == "0")
            {
                sex1.Text = "男";
            }
            else
            {
                sex1.Text = "女";

            };


        }

        private void SetRichTextBoxReceive(string str)
        {

            Console.WriteLine(str);
   








        }
        private void chatListBox1_MouseEnterHead(object sender, ChatListEventArgs e)
        {
       
        }

        private void chatListBox1_MouseLeaveHead(object sender, ChatListEventArgs e)
        {
        
        }


        private void chatListBox1_DoubleClickSubItem(object sender, ChatListEventArgs e)
        {

          
            Chat  frm = new Chat( client, networkStream,e.SelectSubItem.HeadImage, e.SelectSubItem.DisplayName, sex1.Text, e.SelectSubItem.IpAddress);
            frm.Show();
  

        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
        public Image ReadImage(byte[] bytes)
        {
            FileStream fs = new FileStream("imagetemp1", FileMode.Create, FileAccess.Write, FileShare.None);
            foreach (byte a in bytes)
            {
                fs.WriteByte(a);
            }
            fs.Close();
            fs = new FileStream("imagetemp1", FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryFormatter bf = new BinaryFormatter();
            object obj = bf.Deserialize(fs);
            fs.Close();
            return (Image)obj;
        }

  
        private void Form2_Load(object sender, EventArgs e)
        {
            setRichTextBoxReceiveCallback = new SetRichTextBoxReceiveCallback(SetRichTextBoxReceive);


            //setRichTextBoxReceiveCallback = new SetRichTextBoxReceiveCallback(SetRichTextBoxReceive);

            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            Console.WriteLine(ip[1]);


            //使用IPv4，实现应用时要将Dns.GetHostName()改为服务器名

            client = new TcpClient(AddressFamily.InterNetwork);
            IPAddress serverIP = IPAddress.Parse("118.25.48.83");

            AsyncCallback requestCallback = new AsyncCallback(RequestCallback);
            allDone.Reset();

            //开始对远程主机的异步请求
            client.BeginConnect(serverIP, 8886, requestCallback, client);

            //阻塞线程直到BeginConnect完成，连接完成自动调用RequestCallback中的Set方法解除阻塞
            allDone.WaitOne();

            HttpHelper http = new HttpHelper();
            HttpItem item1 = new HttpItem();
            HttpResult result = new HttpResult();

            item1 = new HttpItem()
            {
                URL = "http://localhost/api/login/friends",//URL     必需项
                UserAgent = "Mozilla/4.0 (compatible; MSIE 9.0; Windows NT 6.1)",
                Method = "post",
                Postdata = "id="+getstr,
                ContentType = "application/x-www-form-urlencoded; Charset=UTF-8",
                Accept = "*/*",
            };
            result = http.GetHtml(item1);
            chatListBox1.Items.Clear();
            string html = result.Html;
            getstr = html;
            Console.WriteLine(html);
            JArray jar = JArray.Parse(html);
         

            ChatListItem item = new ChatListItem("好友列表 ");
            foreach (var jsonitem in jar)
            {
                JObject job = (JObject)jsonitem;
                string id = job["id"].ToString();
                Console.WriteLine(id);
                ChatListSubItem subItem = new ChatListSubItem(job["name"].ToString(), job["name"].ToString(), job["sign"].ToString());
                Console.WriteLine(job["F_friendID"]);
                string img = job["img"].ToString();
                //subItem.IpAddress = job["ip"].ToString();
                subItem.HeadImage = Image.FromStream(System.Net.WebRequest.Create(img).GetResponse().GetResponseStream());
                string  state=job["flag"].ToString();
                if (state == "1")
                {
                    subItem.Status = (ChatListSubItem.UserStatus)(0);
                }
                else
                {
                    subItem.Status = (ChatListSubItem.UserStatus)(5);
                }


                


                item.SubItems.AddAccordingToStatus(subItem);

            }
        
            chatListBox1.Items.Add(item);
     












    }





        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chatListBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
