using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mvcplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] path,files;

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = path[listBox1.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                path = ofd.FileNames;
                for(int i = 0; i < files.Length; i++)
                {
                    listBox1.Items.Add(files[i]);
                }
            }
        }
    }
}
