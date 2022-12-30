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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Missing Data !!!!");
            }
            else if (UNameTb.Text == "Abdo" && PassTb.Text == "Abdo")
            {
                Customers Custform = new Customers();
                Custform.Show();
                this.Hide();
            }
            else
            {
                UNameTb.Text = "";
                PassTb.Text = "";

            }
        }
    }
}
