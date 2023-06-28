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

namespace Mini_SQL_Derleyici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-DSQNOEI\SQLEXPRESS03;Initial Catalog=DbNotKayit;Integrated Security=True");

        private void BtnCalistir_Click(object sender, EventArgs e)
        {
            string sorgu;
            sorgu = RTxtSorgu.Text;

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DgvCikti.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Girilen Sorgu Herhangi Bir Değer Döndürmedi, Lütfen Sorguyu Kontrol Ediniz!", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }
    }
}
