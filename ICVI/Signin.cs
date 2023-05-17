using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICVI
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void tb_password_Enter(object sender, EventArgs e)
        {
            if (tb_password.Text == "Password")
            {
                tb_password.Text = "";
                tb_password.ForeColor = Color.Black;
            }
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                tb_password.Text = "Password";
                tb_password.ForeColor = Color.Silver;
            }
        }

        private void tb_username_Leave(object sender, EventArgs e)
        {
            if (tb_username.Text == "")
            {
                tb_username.Text = "Username";
                tb_username.ForeColor = Color.Silver;
            }
        }

        private void tb_username_Enter(object sender, EventArgs e)
        {
            if (tb_username.Text == "Username")
            {
                tb_username.Text = "";
                tb_username.ForeColor = Color.Black;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            Signin signin = new Signin();
            this.Visible = false;
            signin.Dispose();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            Signin signin = new Signin();
            this.Visible = false;
            signin.Dispose();
        }
    }
}
