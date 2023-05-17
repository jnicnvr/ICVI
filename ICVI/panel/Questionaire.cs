using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICVI.panel
{
    public partial class Questionaire : Form
    {
        public Questionaire()
        {
            InitializeComponent();
        }

        private void search_Enter(object sender, EventArgs e)
        {
            if(search.Text == "Search")
            {
                search.Text = "";
                search.ForeColor = Color.Black;
            }
        }

        private void search_Leave(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = "Search";
                search.ForeColor = Color.Gray;
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
