using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace numberace
{
    public partial class homePage : Form
    {
        SoundPlayer gameMusic = new SoundPlayer(@"C:\Users\manga\source\repos\numberace2\numberace\Resources\RPReplay-Final1687929196.wav");

        public homePage()
        {
            InitializeComponent();
        }

        private void homePage_Load(object sender, EventArgs e)
        {
            gameMusic.Play();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide this page
            gamePage f = new gamePage(); //link to gamepage
            f.Show(); // show gamepage
        }
    }
}
