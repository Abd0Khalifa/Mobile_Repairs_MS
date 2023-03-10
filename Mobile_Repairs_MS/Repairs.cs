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
    public partial class Repairs : Form
    {
        Functions Con;
        public Repairs()
        {
            InitializeComponent();
            Con = new Functions();
            ShowRepairs();
            GetCustomer();
            GetSpare();
        }

        private void ShowRepairs()
        {
            string Query = "Select * from RepairTbl";
            RepairsList.DataSource = Con.GetData(Query);

        }

        private void GetCustomer()
        {
            string Query = "Select * from CustomerTbl";
            CustCb.DisplayMember = Con.GetData(Query).Columns["CustName"].ToString();
            CustCb.ValueMember = Con.GetData(Query).Columns["CustCode"].ToString();
            CustCb.DataSource = Con.GetData(Query);
        }

        private void GetSpare()
        {
            string Query = "Select * from SpareTbl";
            SpareCb.DisplayMember = Con.GetData(Query).Columns["SpName"].ToString();
            SpareCb.ValueMember = Con.GetData(Query).Columns["SpCode"].ToString();
            SpareCb.DataSource = Con.GetData(Query);
        }

        private void GetCost()
        {
            string Query = "Select * from SpareTbl where SpCode = {0}";
            Query = string.Format(Query, SpareCb.SelectedValue.ToString());
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                SpareCostTb.Text = dr["SpCost"].ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CustCb.SelectedIndex == -1 || PhoneTb.Text == "" || ProblemTb.Text == "" || DNameTb.Text == ""
                || ModelTb.Text == "" || SpareCb.SelectedIndex == -1 || TotalTb.Text == "" || SpareCostTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    string RDate = RepDateTb.Value.Date.ToString("yyyyMMdd");
                    int Customer = Convert.ToInt32(CustCb.SelectedValue.ToString());
                    string CPhone = PhoneTb.Text;
                    string DeviceName = DNameTb.Text;
                    string DeviceModle = ModelTb.Text;
                    string Problem = ProblemTb.Text;
                    int Spare = Convert.ToInt32(SpareCb.SelectedValue.ToString());
                    int Total = Convert.ToInt32(TotalTb.Text);
                    int GrdTotal = Convert.ToInt32(SpareCostTb.Text) + Total;
                    string Query = "insert into repairTbl values ('{0}',{1},'{2}','{3}','{4}','{5}',{6},{7})";
                    Query = string.Format(Query, RDate, Customer, CPhone, DeviceName, DeviceModle, Problem, Spare, GrdTotal);
                    Con.SetData(Query);
                    MessageBox.Show("Repair Add !!!!");
                    ShowRepairs();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void SpareCostTb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SpareCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCost();
        }

        int Key = 0;
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a Data");
            }
            else
            {
                try
                {
                    string Query = "delete from RepairTbl where RepCode = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Repair Deleted !!!!");
                    ShowRepairs();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void RepairsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Key = Convert.ToInt32(RepairsList.SelectedRows[0].Cells[0].Value.ToString());
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
