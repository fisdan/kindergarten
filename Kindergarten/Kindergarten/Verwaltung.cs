using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kindergarten
{
    public partial class Verwaltung : Form
    {
        public Verwaltung()
        {
            InitializeComponent();
        }

        private void btn_MVerwalten_Click(object sender, EventArgs e)
        {
            Mitarbeiterverwaltung a = new Mitarbeiterverwaltung();
            a.Show();
        }

        private void btn_KVerwalten_Click(object sender, EventArgs e)
        {

        }
    }
}
