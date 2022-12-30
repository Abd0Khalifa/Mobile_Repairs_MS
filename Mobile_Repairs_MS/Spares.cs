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
                    MessageBox.Show("Spare Add !!!!");
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
