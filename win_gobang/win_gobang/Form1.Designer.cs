namespace win_gobang
{
    partial class GobangMainFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GobangMainFrom));
            this.Btn_open = new System.Windows.Forms.Button();
            this.Btn_goBack = new System.Windows.Forms.Button();
            this.Btn_mode = new System.Windows.Forms.Button();
            this.Btn_close = new System.Windows.Forms.Button();
            this.lbl_degree = new System.Windows.Forms.Label();
            this.lbl_Mode = new System.Windows.Forms.Label();
            this.lbl_nowMode = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_nowDegree = new System.Windows.Forms.Label();
            this.gbox_chessboard = new System.Windows.Forms.GroupBox();
            this.gbox_btns = new System.Windows.Forms.GroupBox();
            this.gbox_userinfo = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gbox_btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_open
            // 
            this.Btn_open.Location = new System.Drawing.Point(61, 38);
            this.Btn_open.Name = "Btn_open";
            this.Btn_open.Size = new System.Drawing.Size(75, 30);
            this.Btn_open.TabIndex = 0;
            this.Btn_open.Text = "开始";
            this.Btn_open.UseVisualStyleBackColor = true;
            this.Btn_open.Click += new System.EventHandler(this.Btn_open_Click);
            // 
            // Btn_goBack
            // 
            this.Btn_goBack.Location = new System.Drawing.Point(61, 152);
            this.Btn_goBack.Name = "Btn_goBack";
            this.Btn_goBack.Size = new System.Drawing.Size(75, 30);
            this.Btn_goBack.TabIndex = 1;
            this.Btn_goBack.Text = "悔棋";
            this.Btn_goBack.UseVisualStyleBackColor = true;
            this.Btn_goBack.Click += new System.EventHandler(this.Btn_goBack_Click);
            // 
            // Btn_mode
            // 
            this.Btn_mode.Location = new System.Drawing.Point(61, 95);
            this.Btn_mode.Name = "Btn_mode";
            this.Btn_mode.Size = new System.Drawing.Size(75, 30);
            this.Btn_mode.TabIndex = 2;
            this.Btn_mode.Text = "模式";
            this.Btn_mode.UseVisualStyleBackColor = true;
            this.Btn_mode.Click += new System.EventHandler(this.Btn_mode_Click);
            // 
            // Btn_close
            // 
            this.Btn_close.Location = new System.Drawing.Point(61, 212);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(75, 30);
            this.Btn_close.TabIndex = 3;
            this.Btn_close.Text = "退出";
            this.Btn_close.UseVisualStyleBackColor = true;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // lbl_degree
            // 
            this.lbl_degree.AutoSize = true;
            this.lbl_degree.Location = new System.Drawing.Point(18, 74);
            this.lbl_degree.Name = "lbl_degree";
            this.lbl_degree.Size = new System.Drawing.Size(52, 15);
            this.lbl_degree.TabIndex = 4;
            this.lbl_degree.Text = "难度：";
            // 
            // lbl_Mode
            // 
            this.lbl_Mode.AutoSize = true;
            this.lbl_Mode.Location = new System.Drawing.Point(17, 44);
            this.lbl_Mode.Name = "lbl_Mode";
            this.lbl_Mode.Size = new System.Drawing.Size(82, 15);
            this.lbl_Mode.TabIndex = 5;
            this.lbl_Mode.Text = "当前模式：";
            // 
            // lbl_nowMode
            // 
            this.lbl_nowMode.AutoSize = true;
            this.lbl_nowMode.Location = new System.Drawing.Point(105, 44);
            this.lbl_nowMode.Name = "lbl_nowMode";
            this.lbl_nowMode.Size = new System.Drawing.Size(67, 15);
            this.lbl_nowMode.TabIndex = 6;
            this.lbl_nowMode.Text = "人机模式";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_nowDegree);
            this.groupBox1.Controls.Add(this.lbl_Mode);
            this.groupBox1.Controls.Add(this.lbl_degree);
            this.groupBox1.Controls.Add(this.lbl_nowMode);
            this.groupBox1.Location = new System.Drawing.Point(661, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 118);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "游戏模式";
            // 
            // lbl_nowDegree
            // 
            this.lbl_nowDegree.AutoSize = true;
            this.lbl_nowDegree.Location = new System.Drawing.Point(105, 74);
            this.lbl_nowDegree.Name = "lbl_nowDegree";
            this.lbl_nowDegree.Size = new System.Drawing.Size(37, 15);
            this.lbl_nowDegree.TabIndex = 7;
            this.lbl_nowDegree.Text = "简单";
            // 
            // gbox_chessboard
            // 
            this.gbox_chessboard.Location = new System.Drawing.Point(32, 16);
            this.gbox_chessboard.Name = "gbox_chessboard";
            this.gbox_chessboard.Size = new System.Drawing.Size(604, 577);
            this.gbox_chessboard.TabIndex = 8;
            this.gbox_chessboard.TabStop = false;
            this.gbox_chessboard.Text = "棋盘";
            // 
            // gbox_btns
            // 
            this.gbox_btns.Controls.Add(this.Btn_open);
            this.gbox_btns.Controls.Add(this.Btn_mode);
            this.gbox_btns.Controls.Add(this.Btn_goBack);
            this.gbox_btns.Controls.Add(this.Btn_close);
            this.gbox_btns.Location = new System.Drawing.Point(661, 318);
            this.gbox_btns.Name = "gbox_btns";
            this.gbox_btns.Size = new System.Drawing.Size(216, 275);
            this.gbox_btns.TabIndex = 9;
            this.gbox_btns.TabStop = false;
            this.gbox_btns.Text = "选项";
            // 
            // gbox_userinfo
            // 
            this.gbox_userinfo.Location = new System.Drawing.Point(661, 164);
            this.gbox_userinfo.Name = "gbox_userinfo";
            this.gbox_userinfo.Size = new System.Drawing.Size(216, 100);
            this.gbox_userinfo.TabIndex = 10;
            this.gbox_userinfo.TabStop = false;
            this.gbox_userinfo.Text = "用户信息";
            // 
            // GobangMainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 635);
            this.Controls.Add(this.gbox_userinfo);
            this.Controls.Add(this.gbox_btns);
            this.Controls.Add(this.gbox_chessboard);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GobangMainFrom";
            this.Text = "五子棋";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbox_btns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_open;
        private System.Windows.Forms.Button Btn_goBack;
        private System.Windows.Forms.Button Btn_mode;
        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.Label lbl_degree;
        private System.Windows.Forms.Label lbl_Mode;
        private System.Windows.Forms.Label lbl_nowMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_nowDegree;
        private System.Windows.Forms.GroupBox gbox_chessboard;
        private System.Windows.Forms.GroupBox gbox_btns;
        private System.Windows.Forms.GroupBox gbox_userinfo;
    }
}

