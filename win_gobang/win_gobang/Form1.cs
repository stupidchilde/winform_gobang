using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_gobang
{
    public partial class GobangMainFrom : Form
    {

        //确认是否已经开启游戏
        protected int GameState = 0;

        protected int[,] cheaaborad = new int[15, 15] {
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
        };

        protected int[,] cheaaboradTest = new int[15, 15];

        public GobangMainFrom()
        {
            InitializeComponent();
            this.lbl_nowMode.Text = "请选择模式";
            this.lbl_nowDegree.Text = "请选择模式";
           // DialogResult dr = MessageBox.Show( cheaaborad[0,0].ToString() ,"数组里面的值", MessageBoxButtons.YesNoCancel);
        }


        private void Btn_open_Click(object sender, EventArgs e)
        {
            //选择模式  人机、双人、联网
            //人机：选择难度  
            //双人：鼠标点击的位置，判断flag为第一次还是第二次
            //联网：通过网络

        }

        private void Btn_mode_Click(object sender, EventArgs e)
        {

        }

        private void Btn_goBack_Click(object sender, EventArgs e)
        {

        }

        private void Btn_close_Click(object sender, EventArgs e)
        {

        }

    }
}
