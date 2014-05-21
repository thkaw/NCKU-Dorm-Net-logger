using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace NCKU_DORM_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Check_Net_Status();
            try
            {
             DeSerialize();
            }
            catch (Exception)
            {
              
            }
        }
        bool loginPage = true;
        bool isNet = false;
        LoginInformation info;

        [Serializable]
        public class LoginInformation
        {

            public string Account
            {
                get;
                set;
            }
            public string Password
            {
                get;
                set;
            }
        }

        //序列化函式
        private void SerializeBinary()
        {
            //建立資料流物件
            FileStream oFileStream = new FileStream("loggerinfo.txt", FileMode.Create);
            //建立二進位格式化物件
            BinaryFormatter myBinaryFormatter = new BinaryFormatter();
            Console.WriteLine("二進位格式序列化......");
            //將物件進行二進位格式序列化，並且將之儲存成檔案
            myBinaryFormatter.Serialize(oFileStream, info);
            oFileStream.Flush();
            oFileStream.Close();
            oFileStream.Dispose();
            Console.WriteLine("完成進位格式序列化......");
        }

        //反序列函式
        private void DeSerialize()
        {
            FileStream oFileStream = new FileStream("loggerinfo.txt", FileMode.Open);
            BinaryFormatter myBinaryFormatter = new BinaryFormatter();
            Console.WriteLine("開始還原序列化物件......");
            //將檔案還原成原來的物件
            info = (LoginInformation)myBinaryFormatter.Deserialize(oFileStream);
            tb_account.Text = info.Account;
            tb_password.Text=info.Password ;

            oFileStream.Flush();
            oFileStream.Close();
            oFileStream.Dispose();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            Check_Net_Status();
            
            //判斷網路連線狀態待修正
            isNet = false;
            
            if (!isNet)
            {
             

                if (tb_account.Text != "" && tb_password.Text != "")
                {
                    loginPage = true;
                    wb_1.Navigate("http://10.25.243.58/sys_dhcp_authcheck_content.html");
                    wb_1.DocumentCompleted += wb_1_DocumentCompleted;

                    info = new LoginInformation();

                    info.Account = tb_account.Text;
                    info.Password = tb_password.Text;
                    SerializeBinary();

                }
                else
                {
                    MessageBox.Show("請輸入帳號密碼!");
                }
            }
            else
            { 
                MessageBox.Show("已經連到網路，不需登錄");
            }
        }

        void wb_1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (loginPage)
            {
                try
                {
                    HtmlDocument doc = wb_1.Document;

                    HtmlElement htb_account = doc.GetElementsByTagName("input")[1];

                    htb_account.InnerText = info.Account;



                    HtmlElement htb_password = doc.GetElementsByTagName("input")[2];

                    htb_password.InnerText = info.Password;

                    HtmlElement hbtn_login = doc.GetElementsByTagName("input")[3];
                    hbtn_login.InvokeMember("onclick");

                    loginPage = false;

                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

        private void wb_1_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("登入成功！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check_Net_Status();

        }

        private void Check_Net_Status()
        {


            // 取得本機名稱
            string strHostName = Dns.GetHostName();
            // 取得本機的IpHostEntry類別實體，用這個會提示已過時
            //IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

            // 取得本機的IpHostEntry類別實體，MSDN建議新的用法
            IPHostEntry iphostentry = Dns.GetHostEntry(strHostName);

            // 取得所有 IP 位址
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                // 只取得IP V4的Address
                if (ipaddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    lb_ip.Text = "您的IP為：" + ipaddress.ToString();
                }
            }

            try
            {
                IPAddress ip = System.Net.Dns.GetHostEntry("dns.hinet.net").AddressList[0];
                //MessageBox.Show(ip.ToString());

                lb_netstatus.Text = "網際網路連線：有網際網路";
                isNet = true;
            }
            catch (Exception)
            {
                lb_netstatus.Text = "網際網路連線：無網際網路";
                isNet = false;
            }
        }
    }
}
