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
    }
}
