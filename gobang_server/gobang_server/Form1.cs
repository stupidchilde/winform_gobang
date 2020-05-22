using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gobang_server
{
    public partial class FormGobangServer : Form
    {

        private string ServerHost = "192.168.66.189";

        private int ServerPort = 77566;

        //保留文本信息最大值
        private int InfoMaxCount = 4096;

        //允许客户端连接的最大个数
        private int ClientSocketMaxCount = 100;

        //socket服务状态
        private int SocketServerStatus = 0;

        private Socket ServerSocket;

        private string InfoDetails = "";

        public FormGobangServer()
        {
            InitializeComponent();
     
            this.lbl_nowTimes.Text = DateTime.Now.ToString();

            



            
        }

        private void SocketCreate() 
        {
            ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
           
            ServerSocket.Bind( new IPEndPoint(IPAddress.Parse(ServerHost), ServerPort) );

            ServerSocket.Listen(20);
        
        }

        private void socketServerInfoManage()
        {


        }

        /// <summary>
        /// 清除文本信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cleartext_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 导出文本信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exporttext_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 开启服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_openService_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (true)
            {
                this.lbl_nowTimes.Text = DateTime.Now.ToString();
                this.lbl_serverState.Text = "已开启";
                this.richtextbox_handleinfo.Text += InfoDetails + i.ToString() + "\n";

                i++;
                if (i == InfoMaxCount)
                {
                    this.lbl_serverState.Text = "未开启";
                    break;
                   
                }
            }
        }

        /// <summary>
        /// 关闭服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_closeService_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// richtextbox内容更换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richtextbox_handleinfo_TextChanged(object sender, EventArgs e)
        {
            this.richtextbox_handleinfo.SelectionStart = this.richtextbox_handleinfo.TextLength;
            this.richtextbox_handleinfo.ScrollToCaret();
        }

        private void btn_sendMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
