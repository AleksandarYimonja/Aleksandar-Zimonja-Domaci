using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ekranska_forma
{
    public partial class Form1 : Form
    {
        public int Red = 0;
        DataTable osoba = new DataTable();
        string cs = "Data source=.; Initial catalog=Osoba; Integrated security=true";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(cs);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Ime, Prezime, JMBG, Adresa, Imejl FROM Osoba ORDER BY ID", veza);
            adapter.Fill(osoba);
            //MessageBox.Show(ucenik.Rows.Count.ToString());
            FillBoxes(Red);
        }

        private void FillBoxes(int id)
        {
            if (osoba.Rows.Count == 0)
            {
                TxtID.Text = "";
                TxtIme.Text = "";
                TxtPrezime.Text = "";
                TxtJMBG.Text = "";
                TxtAdresa.Text = "";
                TxtImejl.Text = "";

                btnNext.Enabled = false;
                btnEnd.Enabled = false;
                btnPrev.Enabled = false;
                btnHome.Enabled = false;
            }
            else
            {
                TxtID.Text = osoba.Rows[Red]["ID"].ToString();
                TxtIme.Text = osoba.Rows[Red]["Ime"].ToString();
                TxtPrezime.Text = osoba.Rows[Red]["Prezime"].ToString();
                TxtJMBG.Text = osoba.Rows[Red]["JMBG"].ToString();
                TxtAdresa.Text = osoba.Rows[Red]["Adresa"].ToString();
                TxtImejl.Text = osoba.Rows[Red]["Imejl"].ToString();

                btnNext.Enabled = (Red != osoba.Rows.Count - 1);
                btnEnd.Enabled = (Red != osoba.Rows.Count - 1);

                btnPrev.Enabled = (Red != 0);
                btnHome.Enabled = (Red != 0);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Red++;
            FillBoxes(Red);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            Red--;
            FillBoxes(Red);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Red = 0;
            FillBoxes(Red);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Red = osoba.Rows.Count - 1;
            FillBoxes(Red);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string komanda = "INSERT INTO Osoba (Ime, Prezime, JMBG, Adresa, Imejl) VALUES ('"
                + TxtIme.Text
                + "', '" + TxtPrezime.Text
                + "', '" + TxtJMBG.Text
                + "', '" + TxtAdresa.Text
                + "', " + TxtImejl.Text + ")";

            SqlConnection veza = new SqlConnection(cs);
            SqlCommand naredbaDodaj = new SqlCommand(komanda, veza);

            veza.Open();
            naredbaDodaj.ExecuteNonQuery();
            veza.Close();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT ID, Ime, Prezime, JMBG, Adresa, Imejl FROM Osoba ORDER BY ID", veza);
            osoba.Clear();
            adapter.Fill(osoba);
            Red = osoba.Rows.Count - 1;
            FillBoxes(Red);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string komanda = "DELETE FROM Osoba WHERE id = " + TxtID.Text;

            SqlConnection veza = new SqlConnection(cs);
            SqlCommand naredbaDodaj = new SqlCommand(komanda, veza);

            veza.Open();
            naredbaDodaj.ExecuteNonQuery();
            veza.Close();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT ID, Ime, Prezime, JMBG, Adresa, Imejl FROM Osoba ORDER BY ID", veza);
            osoba.Clear();
            adapter.Fill(osoba);
            if (Red > osoba.Rows.Count - 1)
            {
                Red = osoba.Rows.Count - 1;
            }
            FillBoxes(Red);
        }
    }
}
