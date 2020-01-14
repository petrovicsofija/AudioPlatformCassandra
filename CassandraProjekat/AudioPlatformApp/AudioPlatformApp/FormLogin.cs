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
    public partial class FormLogin : Form
    {
        Form1 mainForm;
        public string audioPlatform;
        public Customer customer;
        List<AudioPlatform.QueryEntities.Audioplatform> platforms;

        public FormLogin(Form1 mf)
        {
            InitializeComponent();
            mainForm = mf;
            customer = new Customer();
            tbPassword.PasswordChar = '*';
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;

            FillComboBox();
        }

        private void FillComboBox()
        {
            platforms = DataProvider.GetPlatforms();
            foreach (Audioplatform a in platforms)
            {
                comboPlatform.Items.Add(a.name);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String cutomerEmail = tbEmail.Text; // izmeni nije username nego name
            tbPassword.PasswordChar = '\0';
            String customerPassword = tbPassword.Text;

            customer = DataProvider.GetCustomer(tbEmail.Text, tbPassword.Text, comboPlatform.SelectedItem.ToString());
            audioPlatform = customer.audio_tier;

            if (customer.name == null)
            {
                MessageBox.Show("Login failed", "Try again",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Exclamation);
                tbPassword.PasswordChar = '*';
            }
            else
            {

                if (customer.name.Equals("Admin1") || customer.name.Equals("Admin2"))
                {
                    
                    Admin af = new Admin(customer);
                    af.Show();
                    if (af.DialogResult == DialogResult.OK)
                    {
                        af.Close();
                    }
                }
                else
                {
                    FormProfile profile = new FormProfile(audioPlatform, customer);
                    profile.Show();
                }
            }
            this.Hide();
        }
    }
}
