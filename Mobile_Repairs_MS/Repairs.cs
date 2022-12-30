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
            
        }

        private void ShowRepairs()
        {
            string Query = "Select * from RepairTbl";
            RepairsList.DataSource = Con.GetData(Query);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
