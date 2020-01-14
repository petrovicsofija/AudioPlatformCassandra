using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AudioPlatform;
using AudioPlatform.QueryEntities;

namespace AudioPlatformApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            RegisterForm af = new RegisterForm(this);
            if (af.ShowDialog() == DialogResult.OK)
            {
                af.Close();
            }
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            FormLogin af = new FormLogin(this);
            af.Show();
            if (af.DialogResult == DialogResult.OK)
            {
                af.Close();
            }
        }

        private void btnRatings_Click(object sender, EventArgs e)
        {
            AllRatingsForm arf = new AllRatingsForm(this);
            arf.Show();
        }
    }
}
