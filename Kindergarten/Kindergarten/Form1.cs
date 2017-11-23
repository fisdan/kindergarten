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
        //http://web.hak-kitz.at/dbv/index.php
        public string salt = "98uQhgtü0wAzt";

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

            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\RanBahadurBK\Documents\testlogin.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username ='" + txb_Benutzername.Text + "' and password='" + txb_Passwort.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Main mm = new Main();
                    mm.Show();
                }
                else
                {
                    MessageBox.Show("Bitte geben sie ein gültiges Passwort mit Benutzer ein", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            if (txb_Benutzername.Text.Length < 3 || txb_Passwort.Text.Length < 3)
            {
                MessageBox.Show("Benutzername oder Passwort ist falsch!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Directory.Exists($"/data/users/{txb_Benutzername}"))
                {
                    MessageBox.Show("Benutzername oder Passwort ist falsch!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StreamReader sr = new StreamReader($"data/users/{txb_Benutzername}/data.ls");
                    string user = sr.ReadLine();
                    string passhash = sr.ReadLine();
                    sr.Close();

                    string thispass = SHA01.Hashing(SHA01.Hashing(txb_Passwort.Text + salt));
                    if(user == txb_Benutzername.Text && passhash == thispass) //== muss durch equal ersetzt werden
                    {
                        MessageBox.Show($"Willkommen {user}!");
                    }
                    else
                    {
                        MessageBox.Show("Benutzername oder Passwort ist falsch!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Registrierung a = new Registrierung();
            a.Show();
        }
    }
}
