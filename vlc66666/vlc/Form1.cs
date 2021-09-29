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

namespace vlc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void axVLCPlugin21_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                axVLCPlugin21.playlist.add("file:///" + ofd.FileName, ofd.SafeFileName, null);
                listBox1.Items.Add(ofd.SafeFileName);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                axVLCPlugin21.playlist.play();
            }
            catch
            {
                MessageBox.Show("hata");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.togglePause();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
