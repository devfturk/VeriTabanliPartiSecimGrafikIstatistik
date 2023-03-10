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
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=DbSecimProje;Integrated Security=True");
        private void btnoy_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_ilce (ILCEAD,Aparti,Bparti,Cparti,Dparti,Eparti) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1",Txtilcead.Text);
            komut.Parameters.AddWithValue("@p2",Txta.Text);
            komut.Parameters.AddWithValue("@p3",Txtb.Text);
            komut.Parameters.AddWithValue("@p4",Txtc.Text);
            komut.Parameters.AddWithValue("@p5",Txtd.Text);
            komut.Parameters.AddWithValue("@p6",Txte.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy girişi gerçekleşti.");
        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmGrafikler = new FrmGrafikler();
            frmGrafikler.Show();

        }
    }
}
