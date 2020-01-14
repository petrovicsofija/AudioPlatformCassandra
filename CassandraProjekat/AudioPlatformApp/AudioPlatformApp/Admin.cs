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
{//flat button dark turk. i cadet blue
    public partial class Admin : Form
    {
        List<AudioPlatform.QueryEntities.Audioplatform> platforms;
        public Admin(Customer c)
        {
            InitializeComponent();
            FillComboBox();
            lblWellcome.Text = c.name;
        }

        private void FillComboBox()
        {
            platforms = DataProvider.GetPlatforms();
            foreach (Audioplatform a in platforms)
            {
                comboPlatform.Items.Add(a.name);
            }
        }

        private string GetPlatform(string name)
        {
            foreach (Audioplatform a in platforms)
            {
                if (a.name.Equals(name))
                {
                    return a.name;
                }
            }
            return String.Empty;
        }

        private void btnSong_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string autor = txtAutor.Text;
            string url = txtUrl.Text;
            string genre = txtGenre.Text;
            string audio_tier = comboPlatform.SelectedItem.ToString();
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(autor) || String.IsNullOrEmpty(url) || String.IsNullOrEmpty(genre) || String.IsNullOrEmpty(audio_tier))
            {
                MessageBox.Show("All inputs must be filled correctly", "Error adding a new song",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                Song s = new Song();
                s.name = name;
                s.autor = autor;
                s.url = url;
                s.genre = genre;
                s.audio_tier = audio_tier;
                DataProvider.AddSong(s);
                MessageBox.Show("Song added correctly", "",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);

            }
        }

        private void btnPrices_Click_1(object sender, EventArgs e)
        {

            PriceEdit pe = new PriceEdit(this);
            if (pe.ShowDialog() == DialogResult.OK)
            {
                pe.Close();
            }
        }

        private void btnAccounts_Click_1(object sender, EventArgs e)
        {
            RemoveAccountsForm af = new RemoveAccountsForm();
            if (af.ShowDialog() == DialogResult.OK)
            {
                af.Close();
            }
        }
    }
}
