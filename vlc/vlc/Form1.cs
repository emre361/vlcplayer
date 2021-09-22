using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxAXVLC;
using AXVLC;


namespace vlc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          string s = @"file:///C:\abc.mp4";
            int s=axVLCPlugin21.playlist.add(s);

            }
        }
                
            

            

        private void button2_Click(object sender, EventArgs e)
        {
          
            axVLCPlugin21.playlist.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.togglePause();
        }
    }
}
