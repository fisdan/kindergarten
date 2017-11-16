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

namespace Kindergarten

{

    public partial class Startseite : Form
    {
        MySqlConnection con = new MySqlConnection("server = eduweb.kb.local; user id = team03; password = T3amO3; database = team03");

        private MySqLConnection conn;
        private string server;
        private string database;
        private string lid;
        private string benutzername;
        private string passwort;
        
        public Startseite()
        {
            server = "localhost";
            database = "Kindergarten";
            lid = "team03";
            passwort = "";

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
