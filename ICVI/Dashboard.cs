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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void onLoadPanel(string choice)
        {
            switch (choice)
            {
                case "Profile":
                    container_panel.Controls.Clear();
                    panel.Profile profile = new panel.Profile();
                    profile.TopLevel = false;
                    container_panel.Controls.Add(profile);
                    profile.Show();

                    break;
                case "Guardian":
                    container_panel.Controls.Clear();
                    panel.ManageGuardian guardian = new panel.ManageGuardian();
                    guardian.TopLevel = false;
                    container_panel.Controls.Add(guardian);
                    guardian.Show();

                    break;
                case "Questionaire":
                    container_panel.Controls.Clear();
                    panel.Questionaire questionaire = new panel.Questionaire();
                    questionaire.TopLevel = false;
                    container_panel.Controls.Add(questionaire);
                    questionaire.Show();

                    break;
                    //default:
                    //    panel_fill.Controls.Clear();
                    //    panel.panel_home f = new panel.panel_home();
                    //    f.TopLevel = false;
                    //    panel_fill.Controls.Add(f);
                    //    f.Show();
                    //    break;
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            onLoadPanel("Profile");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            onLoadPanel("Questionaire");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onLoadPanel("Guardian");
        }

        private void btn_home_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
