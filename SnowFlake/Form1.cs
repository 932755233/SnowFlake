using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowFlake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = this.BackColor;
            Location = new Point(-10, -10);
            for (int i = 0; i < 30; i++)
            {
               // Thread.Sleep(3000);
                var snowFlake = new SnowFlake();
                snowFlake.Show();
                
            }

          //  SoundPlayer player = new SoundPlayer(Properties.Resources.ResourceManager.GetStream("oppo"));
          //  player.PlayLooping();

            ntfShow.ShowBalloonTip(1000);
        }

        private void Form1_MinimumSizeChanged(object sender, EventArgs e)
        {
            ntfShow.ShowBalloonTip(1000);
        }

        private void ntfShow_Click(object sender, EventArgs e)
        {
        
          //  ntfShow.ShowBalloonTip(1000);
        }

        private void ntfShow_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
