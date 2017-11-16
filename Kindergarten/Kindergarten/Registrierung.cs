using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Kindergarten
{
    public partial class Registrierung : Form
    {
        public Registrierung()
        {
            InitializeComponent();
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Registrieren_Click(object sender, EventArgs e)
        {
            if (txb_Benutzername.Text.Length < 3 || txb_Passwort.Text.Length < 3)
            {
                MessageBox.Show("Benutzername oder Passwort ist zu kurz!");
            }
            else
            {
                if(Directory.Exists($"/data/users/{txb_Benutzername}"))
                {
                    MessageBox.Show("Benutzername existiert bereits!");
                }
                else
                {

                }
            }

        }
    }
}
