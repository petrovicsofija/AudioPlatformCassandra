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
using AudioPlatformApp;

namespace AudioPlatformApp
{
    public partial class AllRatingsForm : Form
    {
        List<AudioTierRating> ratings;

        Form1 mainForm;
        public AllRatingsForm(Form1 f1)
        {
            InitializeComponent();
            Init();
            mainForm = f1;

        }
        public void Init()
        {
            ratings = DataProvider.GetRatings();
            int n = ratings.Count;
            foreach (AudioTierRating atr in ratings)
            {
                lbRatings.Items.Add(atr.customer_email + ": " + atr.description + ", " + atr.evaluation.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
