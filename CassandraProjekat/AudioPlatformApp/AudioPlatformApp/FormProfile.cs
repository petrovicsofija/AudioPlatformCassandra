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
    public partial class FormProfile : Form
    {
        List<Song> songs = new List<Song>();
        List<Song> allSongs = new List<Song>();
        string audioPlatform;
        Customer customer;
        String songToPlay;
        int rowIndex;

        public FormProfile(string ap, Customer c)
        {
            InitializeComponent();
            audioPlatform = ap;
            customer = c;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            lblName.Parent = pictureBox1;
            lblName.BackColor = Color.Transparent;
            lblName.Parent = pictureBox1;
            lblName.BackColor = Color.Transparent;
            lblPlatformTier.Parent = pictureBox1;
            lblPlatformTier.BackColor = Color.Transparent;
            ToolTip l = new ToolTip();
            l.SetToolTip(tnPlay, "Select wanted song and click play");
            Init();
            FillComboBox();
        }

        private void FillComboBox()
        {
            comboSearch.Items.Add("Search by Author");
            comboSearch.Items.Add("Search by Genre");
        }

        private void Init()
        {

            lblName.Text = customer.name;
            if (audioPlatform.Equals("platinum"))
                lblPlatformTier.Text = "Platinum";
            if (audioPlatform.Equals("gold"))
                lblPlatformTier.Text = "Gold";
            if (audioPlatform.Equals("silver"))
                lblPlatformTier.Text = "Silver";

            allSongs = DataProvider.GetSongs();
            foreach (Song s in allSongs) //bolje data grid view
            {
                if (s.audio_tier.Equals(audioPlatform))
                {
                    int rowId = dgwSongs.Rows.Add();

                    // Grab the new row!
                    DataGridViewRow row = dgwSongs.Rows[rowId];

                    // Add the data
                    row.Cells["ColName"].Value = s.name;
                    row.Cells["ColAuthor"].Value = s.autor;
                    row.Cells["ColGenre"].Value = s.genre;
                    songs.Add(s);
                }
            }
        }

        private void dgwSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (dgwSongs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string name = dgwSongs.Rows[e.RowIndex].Cells["ColName"].Value.ToString();
                string autor = dgwSongs.Rows[e.RowIndex].Cells["ColAuthor"].Value.ToString();

                Song s = DataProvider.GetSong(name, autor, audioPlatform);
                songToPlay = s.url;

                FormListening listening = new FormListening(songToPlay);
                listening.Show();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (comboSearch.SelectedItem.ToString().Equals("Search by Author"))
            {
                if (txtSearch.Text.Equals(""))
                    return;
                else
                {
                    dgwSongs.Rows.Clear();
                    foreach (Song s in songs) //bolje data grid view
                    {
                        if (s.autor.Equals(txtSearch.Text) /*&& s.genre.Equals(tbGenreSeach.Text)*/)
                        {
                            int rowId = dgwSongs.Rows.Add();
                            DataGridViewRow row = dgwSongs.Rows[rowId];
                            row.Cells["ColName"].Value = s.name;
                            row.Cells["ColAuthor"].Value = s.autor;
                            row.Cells["ColGenre"].Value = s.genre;
                        }
                    }
                }
            }
            else if (comboSearch.SelectedItem.ToString().Equals("Search by Genre"))
            {
                if (txtSearch.Text.Equals(""))
                    return;
                else
                {
                    dgwSongs.Rows.Clear();
                    foreach (Song s in songs) //bolje data grid view
                    {
                        if (s.genre.Equals(txtSearch.Text))
                        {
                            int rowId = dgwSongs.Rows.Add();
                            DataGridViewRow row = dgwSongs.Rows[rowId];
                            row.Cells["ColName"].Value = s.name;
                            row.Cells["ColAuthor"].Value = s.autor;
                            row.Cells["ColGenre"].Value = s.genre;
                        }
                    }
                }
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FormRating rating = new FormRating(customer, audioPlatform);
            rating.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            CustomerAccount personalData = new CustomerAccount(customer,this);
            personalData.Show();

 
            this.Close();
        }

        private void tnPlay_Click(object sender, EventArgs e)
        {
                string name = dgwSongs.Rows[rowIndex].Cells["ColName"].Value.ToString();
                string autor = dgwSongs.Rows[rowIndex].Cells["ColAuthor"].Value.ToString();

                Song s = DataProvider.GetSong(name, autor, audioPlatform);
                songToPlay = s.url;

                FormListening listening = new FormListening(songToPlay);
                listening.Show();
            
        }
    }
}
