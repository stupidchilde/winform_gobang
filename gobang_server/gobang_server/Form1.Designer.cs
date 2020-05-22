namespace gobang_server
{
    partial class FormGobangServer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.richtextbox_handleinfo = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cleartext = new System.Windows.Forms.Button();
            this.btn_exporttext = new System.Windows.Forms.Button();
            this.lbl_timeName = new System.Windows.Forms.Label();
            this.lbl_nowTimes = new System.Windows.Forms.Label();
            this.lbl_serverStateName = new System.Windows.Forms.Label();
            this.lbl_serverState = new System.Windows.Forms.Label();
            this.btn_openService = new System.Windows.Forms.Button();
            this.btn_closeService = new System.Windows.Forms.Button();
            this.btn_sendMsg = new System.Windows.Forms.Button();
            this.textbox_Msg = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richtextbox_handleinfo
            // 
            this.richtextbox_handleinfo.Location = new System.Drawing.Point(25, 33);
            this.richtextbox_handleinfo.Name = "richtextbox_handleinfo";
            this.richtextbox_handleinfo.Size = new System.Drawing.Size(572, 312);
            this.richtextbox_handleinfo.TabIndex = 0;
            this.richtextbox_handleinfo.Text = "";
            this.richtextbox_handleinfo.TextChanged += new System.EventHandler(this.richtextbox_handleinfo_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richtextbox_handleinfo);
            this.groupBox1.Location = new System.Drawing.Point(22, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作信息";
            // 
            // btn_cleartext
            // 
            this.btn_cleartext.Location = new System.Drawing.Point(428, 561);
            this.btn_cleartext.Name = "btn_cleartext";
            this.btn_cleartext.Size = new System.Drawing.Size(100, 30);
            this.btn_cleartext.TabIndex = 2;
            this.btn_cleartext.Text = "清除文本";
            this.btn_cleartext.UseVisualStyleBackColor = true;
            this.btn_cleartext.Click += new System.EventHandler(this.btn_cleartext_Click);
            // 
            // btn_exporttext
            // 
            this.btn_exporttext.Location = new System.Drawing.Point(546, 561);
            this.btn_exporttext.Name = "btn_exporttext";
            this.btn_exporttext.Size = new System.Drawing.Size(100, 30);
            this.btn_exporttext.TabIndex = 3;
            this.btn_exporttext.Text = "导出文本";
            this.btn_exporttext.UseVisualStyleBackColor = true;
            this.btn_exporttext.Click += new System.EventHandler(this.btn_exporttext_Click);
            // 
            // lbl_timeName
            // 
            this.lbl_timeName.AutoSize = true;
            this.lbl_timeName.Location = new System.Drawing.Point(21, 19);
            this.lbl_timeName.Name = "lbl_timeName";
            this.lbl_timeName.Size = new System.Drawing.Size(52, 15);
            this.lbl_timeName.TabIndex = 4;
            this.lbl_timeName.Text = "时间：";
            // 
            // lbl_nowTimes
            // 
            this.lbl_nowTimes.AutoSize = true;
            this.lbl_nowTimes.Location = new System.Drawing.Point(79, 19);
            this.lbl_nowTimes.Name = "lbl_nowTimes";
            this.lbl_nowTimes.Size = new System.Drawing.Size(159, 15);
            this.lbl_nowTimes.TabIndex = 5;
            this.lbl_nowTimes.Text = "yyyy-MM-dd HH:mm:ss";
            // 
            // lbl_serverStateName
            // 
            this.lbl_serverStateName.AutoSize = true;
            this.lbl_serverStateName.Location = new System.Drawing.Point(491, 19);
            this.lbl_serverStateName.Name = "lbl_serverStateName";
            this.lbl_serverStateName.Size = new System.Drawing.Size(97, 15);
            this.lbl_serverStateName.TabIndex = 6;
            this.lbl_serverStateName.Text = "服务器状态：";
            // 
            // lbl_serverState
            // 
            this.lbl_serverState.AutoSize = true;
            this.lbl_serverState.Location = new System.Drawing.Point(596, 19);
            this.lbl_serverState.Name = "lbl_serverState";
            this.lbl_serverState.Size = new System.Drawing.Size(52, 15);
            this.lbl_serverState.TabIndex = 7;
            this.lbl_serverState.Text = "未开启";
            // 
            // btn_openService
            // 
            this.btn_openService.Location = new System.Drawing.Point(22, 561);
            this.btn_openService.Name = "btn_openService";
            this.btn_openService.Size = new System.Drawing.Size(100, 30);
            this.btn_openService.TabIndex = 8;
            this.btn_openService.Text = "开启服务";
            this.btn_openService.UseVisualStyleBackColor = true;
            this.btn_openService.Click += new System.EventHandler(this.btn_openService_Click);
            // 
            // btn_closeService
            // 
            this.btn_closeService.Location = new System.Drawing.Point(161, 561);
            this.btn_closeService.Name = "btn_closeService";
            this.btn_closeService.Size = new System.Drawing.Size(100, 30);
            this.btn_closeService.TabIndex = 9;
            this.btn_closeService.Text = "关闭服务";
            this.btn_closeService.UseVisualStyleBackColor = true;
            this.btn_closeService.Click += new System.EventHandler(this.btn_closeService_Click);
            // 
            // btn_sendMsg
            // 
            this.btn_sendMsg.Location = new System.Drawing.Point(519, 104);
            this.btn_sendMsg.Name = "btn_sendMsg";
            this.btn_sendMsg.Size = new System.Drawing.Size(100, 30);
            this.btn_sendMsg.TabIndex = 10;
            this.btn_sendMsg.Text = "发送信息";
            this.btn_sendMsg.UseVisualStyleBackColor = true;
            this.btn_sendMsg.Click += new System.EventHandler(this.btn_sendMsg_Click);
            // 
            // textbox_Msg
            // 
            this.textbox_Msg.Location = new System.Drawing.Point(47, 74);
            this.textbox_Msg.Multiline = true;
            this.textbox_Msg.Name = "textbox_Msg";
            this.textbox_Msg.Size = new System.Drawing.Size(426, 60);
            this.textbox_Msg.TabIndex = 11;
            // 
            // FormGobangServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 613);
            this.Controls.Add(this.textbox_Msg);
            this.Controls.Add(this.btn_sendMsg);
            this.Controls.Add(this.btn_closeService);
            this.Controls.Add(this.btn_openService);
            this.Controls.Add(this.lbl_serverState);
            this.Controls.Add(this.lbl_serverStateName);
            this.Controls.Add(this.lbl_nowTimes);
            this.Controls.Add(this.lbl_timeName);
            this.Controls.Add(this.btn_exporttext);
            this.Controls.Add(this.btn_cleartext);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGobangServer";
            this.Text = "五子棋服务端";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtextbox_handleinfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cleartext;
        private System.Windows.Forms.Button btn_exporttext;
        private System.Windows.Forms.Label lbl_timeName;
        private System.Windows.Forms.Label lbl_nowTimes;
        private System.Windows.Forms.Label lbl_serverStateName;
        private System.Windows.Forms.Label lbl_serverState;
        private System.Windows.Forms.Button btn_openService;
        private System.Windows.Forms.Button btn_closeService;
        private System.Windows.Forms.Button btn_sendMsg;
        private System.Windows.Forms.TextBox textbox_Msg;
    }
}

