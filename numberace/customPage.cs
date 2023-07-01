using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numberace
{
    public partial class customPage : Form
    {
        public customPage()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide this form (gamepage)
            homePage back = new homePage(); // link to customPage
            back.Show(); // show customPage form
        }
    }
}
