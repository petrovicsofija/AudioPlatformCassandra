using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AudioPlatformApp
{
    public partial class FormListening : Form
    {
        String songToPlay;
        public FormListening(String s)
        {
            InitializeComponent();
            songToPlay = s;

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            //Change path --------->
            axWindowsMediaPlayer1.URL = @"F:\Pesme Cassandra\" + songToPlay; //@"c:\mediafile.wmv";
        }
    }
}
