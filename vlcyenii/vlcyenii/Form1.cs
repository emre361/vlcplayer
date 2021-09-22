using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vlcyenii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "( *.mp4; *.flv; *mkv; *.avi) | *.mp4; *.flv; *.mkv; *.avi";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                axVLCPlugin21.playlist.add(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.togglePause();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.stop();
        }
    }
}
