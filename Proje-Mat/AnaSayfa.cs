using Proje_Mat.Games;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Mat
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flapyy flapyy = new Flapyy();

            flapyy.Show();

            this.Hide();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            TaşKagıtMakas taşkagıtmakas = new TaşKagıtMakas();

            taşkagıtmakas.Show();

            this.Hide();
        }
    }
}
