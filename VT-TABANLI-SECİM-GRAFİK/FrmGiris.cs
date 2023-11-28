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

namespace VT_TABANLI_SECİM_GRAFİK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-A21VQ07\\SQLEXPRESS;Initial Catalog=DbSecimProjesi;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            VTGS fr=new VTGS();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6) ", baglanti);
            komut.Parameters.AddWithValue("@P1", txtilceAd.Text);
            komut.Parameters.AddWithValue("@P2", txtA.Text);
            komut.Parameters.AddWithValue("@P3", txtB.Text);
            komut.Parameters.AddWithValue("@P4", txtC.Text);
            komut.Parameters.AddWithValue("@P5", txtD.Text);
            komut.Parameters.AddWithValue("@P6", txtE.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Oy Girişi Başarılı");

        }
    }
}
