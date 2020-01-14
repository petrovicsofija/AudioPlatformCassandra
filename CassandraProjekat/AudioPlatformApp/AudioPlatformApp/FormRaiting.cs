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
    public partial class FormRating : Form
    {
        Customer customer;
        string audioPlatform;
        public FormRating(Customer c, string ap)
        {
            InitializeComponent();
            customer = c;
            audioPlatform = ap;

            if (audioPlatform.Equals("platinum"))
                lblPlatform.Text = "Platinum";
            if (audioPlatform.Equals("gold"))
                lblPlatform.Text = "Gold";
            if (audioPlatform.Equals("silver"))
                lblPlatform.Text = "Silver";

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            AudioTierRating atr = new AudioTierRating();

            atr.description = tbDescription.Text;
            atr.evaluation = Double.Parse(tbEvaluation.Text);
            atr.platform = audioPlatform;
            atr.customer_email = customer.email;
            atr.customer_name = customer.name;
            atr.customer_surname = customer.surname;
            DataProvider.AddRate(atr);

            this.Hide();
        }
    }
}
