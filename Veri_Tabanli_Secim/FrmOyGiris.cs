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
	public partial class FrmOyGiris : Form
	{
		public FrmOyGiris()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection(@"Data Source=CEMC\SQLEXPRESS01;Initial Catalog=DbSecimProje;Integrated Security=True");
		

		private void BtnOyGiris_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("Insert into TBLILCE (ILCEAD, APARTI, BPARTI,CPARTI,DPARTI,EPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
			komut.Parameters.AddWithValue("@p1", TxtIlceAd.Text);
			komut.Parameters.AddWithValue("@p2", TxtA.Text);
			komut.Parameters.AddWithValue("@p3", TxtB.Text);
			komut.Parameters.AddWithValue("@p4", TxtC.Text);
			komut.Parameters.AddWithValue("@p5", TxtD.Text);
			komut.Parameters.AddWithValue("@p6", TxtE.Text);
			komut.ExecuteNonQuery();
			MessageBox.Show("Kayıt başarı ile eklenmiştir", "Bilgi");
			
			baglanti.Close();
		}

		private void BtnGrafikler_Click(object sender, EventArgs e)
		{
			FrmGrafikler frm = new FrmGrafikler();
			frm.Show();
		}
	}
}
