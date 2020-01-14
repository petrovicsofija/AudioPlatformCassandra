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
    public partial class CustomerAccount : Form
    {
        private List<Contract> contracts = new List<Contract>();

        Customer customer;
        Contract contract;
        FormProfile profile;
        public CustomerAccount(Customer c,FormProfile p)
        {
            InitializeComponent();
            customer = c;
            profile = p;
            FillControls(customer);
            ToolTip l = new ToolTip();
            l.SetToolTip(dataGridView1, "You can extend contract date here");

        }

        private void FillControls(Customer c)
        {
            lblName.Text = c.name;
            lblSurname.Text = c.surname;
            lblEmail.Text = c.email;

            Audioplatform ap = DataProvider.GetPlatform(c.audio_tier);
            lblAudioTier.Text = ap.name;

            //Contract contract = DataProvider.GetContract(c.contract_start_date,c.audio_tier,c.name,c.surname);

            dtpBirthDate.Value = DateTime.Parse(customer.birth_date);

            contracts = DataProvider.GetContracts();

            foreach (Contract con in contracts)
            {
                if (con.customer_name.Equals(customer.name) && con.customer_surname.Equals(c.surname))
                {
                    int rowId = dataGridView1.Rows.Add();

                    // Grab the new row!
                    DataGridViewRow row = dataGridView1.Rows[rowId];

                    // Add the data
                    row.Cells["ColStartDate"].Value = con.start_date;
                    row.Cells["ColEndsAt"].Value = con.end_date;
                    row.Cells["ColPlatform"].Value = con.audio_tier;
                }
            }

        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete account?", "Leaving platform...", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataProvider.DeleteCustomer(customer.email);
                foreach (Contract c in contracts)
                {
                    DataProvider.UpdateContractDate(DateTime.Now.ToString("yyyy-MM-dd"), c.start_date, c.audio_tier, customer.name, customer.surname);
                }

                this.Hide();// ovde problem
                profile.Hide();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string startDate = dataGridView1.Rows[e.RowIndex].Cells["ColStartDate"].Value.ToString();
                string platform = dataGridView1.Rows[e.RowIndex].Cells["ColPlatform"].Value.ToString();

                contract = DataProvider.GetContract(startDate, platform, customer.name, customer.surname);

                ExtendContract pc = new ExtendContract(customer, contract);
                if (pc.ShowDialog() == DialogResult.OK)
                {
                    Contract newC = DataProvider.GetContract(customer.contract_start_date, customer.audio_tier, customer.name, customer.surname);
                    // Grab the new row!
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Add the data
                    row.Cells["ColStartDate"].Value = newC.start_date;
                    row.Cells["ColEndsAt"].Value = newC.end_date;
                    row.Cells["ColPlatform"].Value = newC.audio_tier;
                }

            }
        }

        private void CustomerAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormProfile fp = new FormProfile(customer.audio_tier, customer);
            fp.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProfile fp = new FormProfile(customer.audio_tier, customer);
            fp.Show();
        }
    }
}
