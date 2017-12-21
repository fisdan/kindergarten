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
using Hash;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data.Common;

namespace Kindergarten
{
    public partial class Registrierung : Form
    {
        public Registrierung()
        {
            InitializeComponent();
        }       

        private void btn_Registrieren_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = eduweb.kb.local; user id = team03; password = T3amO3; database = team03");
            MySqlCommand registrieren = new MySqlCommand("", con);
            if (chk_Admin.Checked == true)
            {
                registrieren.CommandText = string.Format("insert into login(Benutzername, Passwort, Benutzergruppe) values ('{0}', '{1}', '{2}')", txb_Benutzername.Text, txb_Passwort.Text, "Admin");
            }
            if (chk_Eltern.Checked == true)
            {
                registrieren.CommandText = string.Format("insert into login(Benutzername, Passwort, Benutzergruppe) values ('{0}', '{1}', '{2}')", txb_Benutzername.Text, txb_Passwort.Text, "Eltern");
            }
            if (chk_Betreuer.Checked == true)
            {
                registrieren.CommandText = string.Format("insert into login(Benutzername, Passwort, Benutzergruppe) values ('{0}', '{1}', '{2}')", txb_Benutzername.Text, txb_Passwort.Text, "Betreuer");
            }


            con.Open();

            try
            {
                registrieren.ExecuteNonQuery();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Benutzer konnte nicht angelegt werden!");
            }
        }

        private void btn_Abbrechen_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Registrierung_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
