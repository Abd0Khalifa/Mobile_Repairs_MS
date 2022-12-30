using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Repairs_MS
{
    public partial class Customers : Form
    {

        Functions Con;
        public Customers()
        {
            InitializeComponent();
            Con = new Functions();
            ShowCustomers();
        }

        private void ShowCustomers()
        {
            String Query = "Select * from CustomerTbl";
            CustomerList.DataSource = Con.GetData(Query);
        }


        private void clear()
        {
            CustNameTb.Text = "";
            CustAddTb.Text = "";
            CustPhoneTb.Text = "";
            Key = 0;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CustNameTb.Text == "" || CustAddTb.Text == "" || CustPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    String CName = CustNameTb.Text;
                    String CPhone = CustPhoneTb.Text;
                    String CAddress = CustAddTb.Text;
                    String Query = "insert into CustomerTbl values ('{0}','{1}','{2}')";
                    Query = String.Format(Query, CName, CPhone, CAddress);
                    Con.SetData(Query);
                    MessageBox.Show("Customer Add !!!!");
                    ShowCustomers();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

            }

        int Key = 0;
        private void CustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustNameTb.Text = CustomerList.SelectedRows[0].Cells[1].Value.ToString();
            CustPhoneTb.Text = CustomerList.SelectedRows[0].Cells[2].Value.ToString();
            CustAddTb.Text = CustomerList.SelectedRows[0].Cells[3].Value.ToString();
            if (CustNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CustomerList.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CustNameTb.Text == "" || CustAddTb.Text == "" || CustPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    String CName = CustNameTb.Text;
                    String CPhone = CustPhoneTb.Text;
                    String CAddress = CustAddTb.Text;
                    String Query = "Update CustomerTbl set CustName ='{0}', CustPhone = '{1}', CustAdd = '{2}' where CustCode = {3}";
                    Query = String.Format(Query, CName, CPhone, CAddress, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Customer Updated !!!!");
                    ShowCustomers();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Customer");
            }
            else
            {
                try
                {
                    String Query = "Delete from CustomerTbl where CustCode = {0}";
                    Query = String.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Customer Deleted !!!!");
                    ShowCustomers();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Spares obj = new Spares();
            obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Repairs obj = new Repairs();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            obj.Show();
            this.Hide();
        }
    }
}
