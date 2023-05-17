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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (tb_name.Text == "Name")
            {
                tb_name.Text = "";
                tb_name.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                tb_name.Text = "Name";
                tb_name.ForeColor = Color.Silver;
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

        private void tb_username_Leave(object sender, EventArgs e)
        {
            if (tb_username.Text == "")
            {
                tb_username.Text = "Username";
                tb_username.ForeColor = Color.Silver;
            }
        }

        private void tb_email_Enter(object sender, EventArgs e)
        {
            if (tb_email.Text == "Email")
            {
                tb_email.Text = "";
                tb_email.ForeColor = Color.Black;
            }
        }

        private void tb_email_Leave(object sender, EventArgs e)
        {
            if (tb_email.Text == "")
            {
                tb_email.Text = "Email";
                tb_email.ForeColor = Color.Silver;
            }
        }

        private void tb_password_Enter(object sender, EventArgs e)
        {
            if (tb_password.Text == "Password1")
            {
                tb_password.Text = "";
                tb_password.ForeColor = Color.Black;
            }
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                tb_password.Text = "Password1";
                tb_password.ForeColor = Color.Silver;
            }
        }

        private void tb_password2_Enter(object sender, EventArgs e)
        {
            if (tb_password2.Text == "Password2")
            {
                tb_password2.Text = "";
                tb_password2.ForeColor = Color.Black;
            }
        }

        private void tb_password2_Leave(object sender, EventArgs e)
        {
            if (tb_password2.Text == "")
            {
                tb_password2.Text = "Password2";
                tb_password2.ForeColor = Color.Silver;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Signin signin = new Signin();
            signin.Show();
            Signup signup = new Signup();
            this.Visible = false;
            signup.Dispose();
        }
    }
}
