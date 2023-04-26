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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0QRD6EF;Initial Catalog=DbFavCarMarka;Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //Ülke Adlarını ComboBox a çekeceğiz
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select UlkeAd from Ulke", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmbBoxUlkeSec.Items.Add(dr[0]); //Bu sorguda tek bir sütun olduğu için ve biz saymaya 0 dan başladığımız için [0] yaptık
            }
            baglanti.Close();

            //Grafiğe Toplam Sonuçları Getirme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select SUM(Mercedes),SUM(Audi),SUM(Bmw),SUM(Honda),SUM(Ford),SUM(Fiat),SUM(Gmc)from Ulke", baglanti);
            SqlDataReader dr2=komut2.ExecuteReader();
            while(dr2.Read())
            {
                chart1.Series["Araç Markaları"].Points.AddXY("Mercedes", dr2[0]); // 0 dememizin sebebi 35.satırdaki select sorgusundaki birinci paratmetriden itibare almak istedik.
                chart1.Series["Araç Markaları"].Points.AddXY("Auid", dr2[1]);
                chart1.Series["Araç Markaları"].Points.AddXY("Bmw", dr2[2]);
                chart1.Series["Araç Markaları"].Points.AddXY("Honda", dr2[3]);
                chart1.Series["Araç Markaları"].Points.AddXY("Ford", dr2[4]);
                chart1.Series["Araç Markaları"].Points.AddXY("Fiat", dr2[5]);
                chart1.Series["Araç Markaları"].Points.AddXY("Gmc", dr2[6]);
            }
            baglanti.Close();
        }

        private void cmbBoxUlkeSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Ulke where UlkeAd=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbBoxUlkeSec.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while (dr.Read())
            {
                progBarMer.Value = int.Parse(dr[2].ToString()); //sql tablosunda Mercedes üçüncü sütunda yer aldığı için ve saymaya sıfırdan başladığımız için ikinci yazdık.
                progBarAudi.Value = int.Parse(dr[3].ToString());
                progBarBmw.Value = int.Parse(dr[4].ToString());
                progBarHon.Value = int.Parse(dr[5].ToString());
                progBarFord.Value = int.Parse(dr[6].ToString());
                progBarFiat.Value = int.Parse(dr[7].ToString());
                progBarGmc.Value = int.Parse(dr[8].ToString());

                lblMer.Text = dr[2].ToString();
                lblAudi.Text = dr[3].ToString();
                lblBmw.Text = dr[4].ToString();
                lblHonda.Text = dr[5].ToString();
                lblFord.Text = dr[6].ToString();
                lblFiat.Text = dr[7].ToString();
                lblGmc.Text = dr[8].ToString();
            }
            baglanti.Close();
        }
    }
}
