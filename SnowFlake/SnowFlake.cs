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

namespace SnowFlake
{
    public partial class SnowFlake : Form
    {
        Random rd = new Random();
        int WindowsWidth = 0;//屏幕宽度
        int WindowsHeight = 0;//屏幕高度

        int locationX = 0;//X轴位置
        int locationY = 0;//Y轴位置

        int interval = 50;//时钟没多少秒执行

        int MaxWidth = 30;
        int MinWidth = 10;
  
        public SnowFlake()
        {
            InitializeComponent();
        }

        private void SnowFlake_Load(object sender, EventArgs e)
        {
            //初始化雪花窗口透明，无边框，添加图片，缩放
            this.TransparencyKey = this.BackColor;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackgroundImage = Properties.Resources.snowflake;
            this.BackgroundImageLayout = ImageLayout.Zoom;

            //获取窗口宽度和高度
            WindowsWidth = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            WindowsHeight = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;

            //初始化雪花大小
            Width = rd.Next(MinWidth, MaxWidth);
            Height = Width;

            //初始化雪花位置
            locationX = rd.Next(WindowsWidth);
            Location = new Point(locationX, -20);

            //初始化时钟
            interval = rd.Next(40, 100);
            tmrMove.Interval = interval;
            tmrMove.Start();
        }

        private void tmrMove_Tick(object sender, EventArgs e)
        {
            tmrMove.Stop();
            

            if (rd.Next(10) > 5)
            {
                locationX += -1;
            }
            else
            {
                locationX += 1;
            }


            locationY += 5;

            if(locationY >= WindowsHeight)
            {
                locationX = rd.Next(WindowsWidth);
                locationY = 0;
                Width = rd.Next(MinWidth,MaxWidth);
                Height = Width;
                interval = rd.Next(40, 100);
                //  Location = new Point(rd.Next(WindowsWidth),0);
                //  Location = new Point(locationX, 0);
            }
            Location = new Point(locationX, locationY);

            tmrMove.Interval = interval;
            tmrMove.Start();

        }
    }
}
