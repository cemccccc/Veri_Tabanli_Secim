using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Tabanli_Secim
{
	public partial class FrmGrafikler : Form
	{

		SqlConnection baglanti = new SqlConnection(@"Data Source=CEMC\SQLEXPRESS01;Initial Catalog=DbSecimProje;Integrated Security=True");

		public FrmGrafikler()
		{
			InitializeComponent();
		}

		private void FrmGrafikler_Load(object sender, EventArgs e)
		{
			//İlçeleri c.box'a çekme
			baglanti.Open();
			SqlCommand komut = new SqlCommand("Select ILCEAD from TBLILCE", baglanti);
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				comboBox1.Items.Add(dr[0]);
			}
			dr.Close();
			baglanti.Close();

			//oy toplamları labelleri ve Grafiğe toplam sonuçları getirme
			baglanti.Open();
			SqlCommand komut2 = new SqlCommand("select sum(APARTI),sum(BPARTI),sum(CPARTI),sum(DPARTI),sum(EPARTI) from TBLILCE", baglanti);
			SqlDataReader dr2 = komut2.ExecuteReader();
			while (dr2.Read())
			{
				chart1.Series["Partiler"].Points.AddXY("A Parti", dr2[0]);
				chart1.Series["Partiler"].Points.AddXY("B Parti", dr2[1]);
				chart1.Series["Partiler"].Points.AddXY("C Parti", dr2[2]);
				chart1.Series["Partiler"].Points.AddXY("D Parti", dr2[3]);
				chart1.Series["Partiler"].Points.AddXY("E Parti", dr2[4]);
			}
			dr.Close();
			baglanti.Close();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select * from TBLILCE where ILCEAD=@p1", baglanti);
			komut.Parameters.AddWithValue("@p1", comboBox1.Text);
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				progressBar1.Value = int.Parse(dr[2].ToString());
				LblA.Text = dr[2].ToString();

				progressBar2.Value = int.Parse(dr[3].ToString());
				LblB.Text = dr[3].ToString();

				progressBar3.Value = int.Parse(dr[4].ToString());
				LblC.Text = dr[4].ToString();

				progressBar4.Value = int.Parse(dr[5].ToString());
				LblD.Text = dr[5].ToString();

				progressBar5.Value = int.Parse(dr[6].ToString());
				LblE.Text = dr[6].ToString();
			}
			dr.Close();
			baglanti.Close();
		}
	}
}
