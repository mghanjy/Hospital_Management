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
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=GHANJY\ABOUDI; DataBase=Hospital; Integrated Security=true");
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

       
            //cmd = new SqlCommand("Insert into Docto(id,dname,ds,phone) values ('"+ textBox1.Text +"','" + textBox6.Text + "','" + textBox2.Text + "'," + textBox3.Text + ")", conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("mohameed ghanjy");
            //conn.Close();   


        

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                cmd = new SqlCommand("select dname, ds, phone from Docto where id='" + textBox4.Text + "'", conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                textBoxname.Text = dr["dname"].ToString();
                textBoxSp.Text = dr["ds"].ToString();
                textBoxPhone.Text = dr["phone"].ToString();
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

           
            cmd = new SqlCommand("Update Docto set dname='" + textBoxname.Text + "',ds='"+textBoxSp.Text + "' , phone= '" + textBoxPhone.Text + "' where id= '" + textBox4.Text + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("mohameed ghanjy");
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
