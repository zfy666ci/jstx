using Lance_post_测试;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;




namespace WindowsFormsApp1

{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   

            HttpHelper http = new HttpHelper();
            HttpItem item = new HttpItem();
            HttpResult result = new HttpResult();
      
            item = new HttpItem()
            {
                URL = "http://localhost/api/login",//URL     必需项
                UserAgent = "Mozilla/4.0 (compatible; MSIE 9.0; Windows NT 6.1)",
                Method = "post",
                Postdata = "username=" + Usertxt1.Text + "&pwd="+Pwdtxt1.Text,
                ContentType = "application/x-www-form-urlencoded; Charset=UTF-8",
                Accept = "*/*",
            };
            result = http.GetHtml(item);

            string html = result.Html;
            Console.WriteLine(html);
            JObject job = JObject.Parse(html);
        


            string Return = job["msg"].ToString();
            
            if (Return == "error")
            {
                MessageBox.Show("登陆失败"+ Return);

            }
            if (Return == "success")
            {
                MessageBox.Show("登陆成功" );
                userfrom frm = new userfrom(html);
                frm.Show();
                this.Hide();



            }









        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
