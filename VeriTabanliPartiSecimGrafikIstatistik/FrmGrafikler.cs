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

namespace VeriTabanliPartiSecimGrafikIstatistik
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=DbSecimProje;Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //ilçe adlarını kombobox'a çekme
            baglanti.Open();
            SqlCommand command = new SqlCommand("Select ILCEAD from tbl_ilce",baglanti);
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            baglanti.Close();

            //Grafiğe toplam sonuçları getirme
            baglanti.Open();
            SqlCommand command2 = new SqlCommand("Select SUM(Aparti),SUM(Bparti),SUM(Cparti),SUM(Dparti),SUM(Eparti) from tbl_ilce", baglanti);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A Parti", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B Parti", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C Parti", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D Parti", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E Parti", dr2[4]);
            }
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From tbl_ilce where ILCEAD=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                lbla.Text = dr[2].ToString();
                lblb.Text = dr[3].ToString();
                lblc.Text = dr[4].ToString();
                lbld.Text = dr[5].ToString();
                lble.Text = dr[6].ToString();

            }
            baglanti.Close();

        }
    }
}
