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
    public partial class RegisterForm : Form
    {
        public List<RadioButton> buttons;
        public Customer customer;
        Form1 mainForm;
        public RegisterForm(Form1 mf)
        {
            InitializeComponent();
            mainForm = mf;
            buttons = new List<RadioButton>();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
            SetRadioButtons();
        }

        private void SetRadioButtons()
        {
            Point p = new Point(578, 140);
      
            List<AudioPlatform.QueryEntities.Audioplatform> platforms = DataProvider.GetPlatforms();
            foreach (var platform in platforms)
            {
                RadioButton radiobutton = new RadioButton();
                radiobutton.BackColor =Color.Transparent;
                radiobutton.ForeColor = Color.White;
                radiobutton.Name = platform.name;
                radiobutton.Text = platform.name + " with price: " + platform.price  + " EUR";
                radiobutton.Width = 300;
                radiobutton.Location = p;
                p.Y = p.Y + radiobutton.Height;
                ToolTip l = new ToolTip();
                l.SetToolTip(radiobutton,platform.description);
                pictureBox1.Controls.Add(radiobutton);
                buttons.Add(radiobutton);
                p.Y = p.Y;
            }

        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            customer = new Customer();
            Contract contract = new Contract();

            string name = txtName.Text;
            string surname = txtSurname.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            DateTime date = dtpBirthday.Value.Date;

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname) || String.IsNullOrEmpty(email) && String.IsNullOrEmpty(password))
            {
                MessageBox.Show("All inputs must be filled", "Error registering",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (RadioButton r in buttons)
                {
                    if (r.Checked == true)
                    {
                        Audioplatform p = DataProvider.GetPlatform(r.Name);
                        DateTime dtend = DateTime.Now;
                        DateTime end = new DateTime(2020, dtend.Month, dtend.Day);
                        DataProvider.AddContract(DateTime.Now.ToString("yyyy-MM-dd"), end.ToString("yyyy-MM-dd"), r.Name, name, surname);
                        DataProvider.AddCustomer(name, surname, email, date.ToString("yyyy-MM-dd"), password, r.Name, p.price, DateTime.Now.ToString("yyyy-MM-dd"), end.ToString("yyyy-MM-dd"));
                        MessageBox.Show("You have successfully registred on audio platform " + p.name + " which costs" + p.price, "Wellcome!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    }
                }
            }
            this.Close();
        }
    }
}
