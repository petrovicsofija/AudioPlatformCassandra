using AudioPlatform;
using AudioPlatform.QueryEntities;
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
    public partial class PriceEdit : Form
    {
        Admin admin;
        List<Audioplatform> platforms = new List<Audioplatform>();
        public PriceEdit(Admin a)
        {
            InitializeComponent();
            platforms = DataProvider.GetPlatforms();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            txtNewPrice.Parent = pictureBox1;
            cmbPlatforms.Parent = pictureBox1;
            btnOK.Parent = pictureBox1;
            btnUpdate.Parent = pictureBox1;
            FillComboBox();
            admin = a;

        }

        private void FillComboBox()
        {
            foreach (var p in platforms)
            {
                cmbPlatforms.Items.Add(p.name);
            }

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            DataProvider.UpdatePlatformPrice(cmbPlatforms.SelectedItem.ToString(), txtNewPrice.Text);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
