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
    public partial class RemoveAccountsForm : Form
    {
        private List<Contract> contracts = new List<Contract>();

        public RemoveAccountsForm()
        {
            InitializeComponent();
            contracts = DataProvider.GetContracts();
            dataGridView1.Parent = pictureBox1;
            btnOK.Parent = pictureBox1;
            btnRemove.Parent = pictureBox1;

            FillDataGrid();
        }

        private void FillDataGrid()
        {
           // contracts = DataProvider.GetContracts();
            for (int i = 0;i<10;i++) //bolje data grid view
            {
                if (contracts[i] != null)
                {
                    int rowId = dataGridView1.Rows.Add();

                    // Grab the new row!
                    DataGridViewRow row = dataGridView1.Rows[rowId];

                    // Add the data
                    row.Cells["colName"].Value = contracts[i].customer_name;
                    row.Cells["colSurname"].Value = contracts[i].customer_surname;
                    row.Cells["colContrStartDate"].Value = contracts[i].start_date;
                    row.Cells["colContrEndDate"].Value = contracts[i].end_date;
                    row.Cells["ColAuidoTier"].Value = contracts[i].audio_tier;
              
                }
            }
        }


        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            String date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            dataGridView1.Rows.Clear();


            foreach (Contract c in contracts)
            {
                if (c.start_date.Equals(date) && txtSearch.Text.Equals(""))
                {
                    int rowId = dataGridView1.Rows.Add();

                    // Grab the new row!
                    DataGridViewRow row = dataGridView1.Rows[rowId];

                    row.Cells["colName"].Value = c.customer_name;
                    row.Cells["colSurname"].Value = c.customer_surname;
                    row.Cells["colContrStartDate"].Value = c.start_date;
                    row.Cells["colContrEndDate"].Value = c.end_date;
                    row.Cells["ColAuidoTier"].Value = c.audio_tier;
                }

                else if (c.start_date.Equals(date) && c.customer_name.Equals(txtSearch.Text))
                {
                    int rowId = dataGridView1.Rows.Add();

                    // Grab the new row!
                    DataGridViewRow row = dataGridView1.Rows[rowId];

                    row.Cells["colName"].Value = c.customer_name;
                    row.Cells["colSurname"].Value = c.customer_surname;
                    row.Cells["colContrStartDate"].Value = c.start_date;
                    row.Cells["colContrEndDate"].Value = c.end_date;
                    row.Cells["ColAuidoTier"].Value = c.audio_tier;
                }
                
            }

            //int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            //DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            //string email = selectedRow.Cells["colEmail"].Value.ToString();

            //DataProvider.DeleteCustomer(email);
            //dataGridView1.Rows.Clear();
    
            //FillDataGrid();
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
