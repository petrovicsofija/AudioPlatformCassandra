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
    public partial class ExtendContract : Form
    {
        private Customer customer;
        private Contract contract;

        public ExtendContract(Customer c, Contract con)
        {
            InitializeComponent();
            customer = c;
            contract = con;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;

            lblStartDate.Parent = pictureBox1;
            lblStartDate.BackColor = Color.Transparent;
            lblTier.Parent = pictureBox1;
            lblTier.BackColor = Color.Transparent;
            groupBox1.Parent = pictureBox1;
            groupBox1.BackColor = Color.Transparent;
            Init();
        }
        private void Init()
        {
            lblStartDate.Text = contract.start_date;
            lblTier.Text = contract.audio_tier;

            if (contract.audio_tier.Equals("platinum"))
            {
                lblPrice1.Text = "costs: 10 EUR";
                lblPrice2.Text = "costs: 22 EUR";
                lblPrice3.Text = "costs: 35 EUR";
            }
            else if (contract.audio_tier.Equals("gold"))
            {
                lblPrice1.Text = "costs: 7 EUR";
                lblPrice2.Text = "costs: 19 EUR";
                lblPrice3.Text = "costs: 21 EUR";
            }
            else
            {
                lblPrice1.Text = "costs: 5 EUR";
                lblPrice2.Text = "costs: 10 EUR";
                lblPrice3.Text = "costs: 15 EUR";
            }
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string endDate = contract.end_date;

            String month = endDate.Substring(5, 2);
            String year = endDate.Substring(0, 4);
            String day = endDate.Substring(8, 2);
            int yearInt = Int32.Parse(year);
            int monthInt = Int32.Parse(month);

            if (radioButton1.Checked == true)
            {
                monthInt++;
                if (monthInt > 12)
                    monthInt = 1;
            }
            if (radioButton2.Checked == true)
            {
                monthInt = (monthInt + 6) % 12;
            }
            if (radioButton2.Checked == true)
            {
                yearInt++;
            }

            String datum = yearInt.ToString() + "-" + monthInt.ToString() + "-" + day;
            DataProvider.UpdateContractDate(datum, contract.start_date, contract.audio_tier, contract.customer_name, contract.customer_surname);
            MessageBox.Show("Contract extended");
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }

}

