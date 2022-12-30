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
    public partial class Spares : Form
    {
        Functions Con;
        public Spares()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSpares();
        }

        private void ShowSpares()
        {
            String Query = "Select * from SpareTbl";
            PartsList.DataSource = Con.GetData(Query);
        }

        private void clear()
        {
            PartNameTb.Text = "";
            PartCostTb.Text = "";
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (PartNameTb.Text == "" || PartCostTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    String PName = PartNameTb.Text;
                    int PCost = Convert.ToInt32(PartCostTb.Text);
                    String Query = "insert into SpareTbl values ('{0}',{1})";
                    Query = String.Format(Query, PName, PCost);
                    Con.SetData(Query);
                    MessageBox.Show("Part Add !!!!");
                    ShowSpares();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Key = 0;
        private void PartsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PartNameTb.Text = PartsList.SelectedRows[0].Cells[1].Value.ToString();
            PartCostTb.Text = PartsList.SelectedRows[0].Cells[2].Value.ToString();
            if (PartNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PartsList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (PartNameTb.Text == "" || PartCostTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    String PName = PartNameTb.Text;
                    int PCost = Convert.ToInt32(PartCostTb.Text);
                    String Query = "Update SpareTbl set SpName = '{0}', SpCost = {1} where SpCode ={2}";
                    Query = String.Format(Query, PName, PCost, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Part Updated !!!!");
                    ShowSpares();
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
                MessageBox.Show("Select Spare");
            }
            else
            {
                try
                {
                    String Query = "Delete from SpareTbl where SpCode = {0}";
                    Query = String.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Part Deleted !!!!");
                    ShowSpares();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
