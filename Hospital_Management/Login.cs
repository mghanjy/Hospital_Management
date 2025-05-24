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

namespace Hospital_Management
{
    public partial class Login : Form
    {
        //private SqlConnection connection;
        //private string connectionString  = @"Server=GHANJY\ABOUDI; DataBase=Hospital; Integrated Security=true";
        //// SqlCommand cmd;
      
        public Login()
        {
            InitializeComponent();
        }
        Class1 bgl = new Class1(); 
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Logi where user_name=@p1 and pass=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxUsername.Text);
            komut.Parameters.AddWithValue("@p2", textBoxPass.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 fr = new Form1();
              //  fr.TC = msktc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Doktor TC veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();



        }


    }
}
