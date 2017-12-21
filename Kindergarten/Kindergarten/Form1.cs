using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Hash;
using System.Data.SqlClient;

namespace Kindergarten

{

    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server = eduweb.kb.local; user id = team03; password = T3amO3; database = team03");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MitarbeiterÜbersicht a = new MitarbeiterÜbersicht();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Protokoll a = new Protokoll();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Eintrag a = new Eintrag();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Protokoll_Betreuer a = new Protokoll_Betreuer();
            a.Show();
        }

        private void Startseite_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Verwaltung a = new Verwaltung();
            a.Show();
        }

        private void btn_Anmelden_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = eduweb.kb.local; user id = team03; password = T3amO3; database = team03");
            MySqlCommand get_user = new MySqlCommand("", con);
            get_user.CommandText = string.Format("select Benutzername from login where Benutzername = '{0}'", txb_Benutzername.Text);
            MySqlCommand get_passwort = new MySqlCommand("", con);
            get_passwort.CommandText = string.Format("select Passwort from login where Passwort = '{0}'", txb_Passwort.Text);
            MySqlCommand get_benutzergruppe = new MySqlCommand("", con);
            get_benutzergruppe.CommandText = string.Format("select Benutzergruppe from login where Benutzername = '{0}'", txb_Benutzername.Text);
            con.Open();


            string benutzer = Convert.ToString(get_user.ExecuteScalar());
            string passwort = Convert.ToString(get_passwort.ExecuteScalar());
            string benutzergruppe = Convert.ToString(get_benutzergruppe.ExecuteScalar());

            if (txb_Benutzername.Text == benutzer && txb_Passwort.Text == passwort && benutzergruppe == "Admin")
            {
                Verwaltung admin = new Verwaltung();
                this.Hide();
                admin.ShowDialog();
            }
            else if(txb_Benutzername.Text == benutzer && txb_Passwort.Text == passwort && benutzergruppe == "Eltern")
            {
                Protokoll eltern = new Protokoll();
                this.Hide();
                eltern.ShowDialog();
            }
            else if (txb_Benutzername.Text == benutzer && txb_Passwort.Text == passwort && benutzergruppe == "Betreuer")
            {
                MitarbeiterÜbersicht mitarbeiter = new MitarbeiterÜbersicht();
                this.Hide();
                mitarbeiter.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login ist fehlgeschlagen");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Registrierung a = new Registrierung();
            a.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
