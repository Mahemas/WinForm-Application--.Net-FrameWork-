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

namespace Veri_Tabanli_Fav_Marka_Grafik_Istatistik
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0QRD6EF;Initial Catalog=DbFavCarMarka;Integrated Security=True");
        private void btnOyGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Ulke (UlkeAd, Mercedes, Audi, Bmw, Honda, Ford, Fiat, Gmc) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUlkeAd.Text);
            komut.Parameters.AddWithValue("@p2", txtMer.Text);
            komut.Parameters.AddWithValue("@p3", txtAudi.Text);
            komut.Parameters.AddWithValue("@p4", txtBmw.Text);
            komut.Parameters.AddWithValue("@p5", txtHon.Text);
            komut.Parameters.AddWithValue("@p6", txtFord.Text);
            komut.Parameters.AddWithValue("@p7", txtFiat.Text);
            komut.Parameters.AddWithValue("@p8", txtGmc.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Başarılı Bir Şekilde Gerçekleştirildi.");
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler(); //FrmGrafikleri buraya bir sınıf olarak ekledik ve bu sınıftan fr adında bir nesne türettik ve burada da Show özelliğiyle ikinci formun görünmesini sağladık.
            fr.Show();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
