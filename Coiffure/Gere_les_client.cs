using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coiffure
{
    public partial class Gere_les_client : Form
    {
        string chemin = "";
        DataTable dt1 = new DataTable();
        SqlConnection cn = new SqlConnection();
        public Gere_les_client()
        {
            InitializeComponent();
        }

        private void Gere_les_client_Load(object sender, EventArgs e)
        {

            //StreamReader red = new StreamReader("Appsetting.txt");
            //chemin = red.ReadToEnd();

            //cn = new SqlConnection(Mylib.DecryptSym(Convert.FromBase64String(chemin), Mylib.cle, Mylib.iv));
            ////client
            //cn.Open();
            //SqlCommand com = new SqlCommand("select * from client ", cn);
            //SqlDataReader re = com.ExecuteReader();
            //dt1.Load(re);
            //textBox1.DataBindings.Add("Text", dt1, "nom");
            //textBox3.DataBindings.Add("Text", dt1, "email");
            //textBox2.DataBindings.Add("Text", dt1, "prenom"); 
            //dateTimePicker1.DataBindings.Add
            

            //cn.Close();
            //re.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            StreamReader red = new StreamReader("Appsetting.txt");
            chemin = red.ReadToEnd();

            cn = new SqlConnection(Mylib.DecryptSym(Convert.FromBase64String(chemin), Mylib.cle, Mylib.iv));
            //client
            cn.Open();
            DateTime d =Convert.ToDateTime(dateTimePicker1.Value.Date.ToShortDateString());
            SqlCommand com = new SqlCommand("select * from reservation r inner join client c on" +
                " r.id_client=c.id_client where _date like'"+d+"'", cn);
            SqlDataReader re = com.ExecuteReader();
            dt1.Load(re);
            textBox1.DataBindings.Add("Text", dt1, "nom");
            textBox3.DataBindings.Add("Text", dt1, "email");
            textBox2.DataBindings.Add("Text", dt1, "prenom");
            
            cn.Close();
            re.Close();
        }
    }
}
