using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coiffure
{
    public partial class InfosReserv : Form
    {
   
        string chemin = "";
        SqlConnection cn;
        DataTable dt = new DataTable();
        public InfosReserv()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfosReserv_Load(object sender, EventArgs e)
        {
            StreamReader red = new StreamReader("Appsetting.txt");
            chemin = red.ReadToEnd();

            cn = new SqlConnection(Mylib.DecryptSym(Convert.FromBase64String(chemin), Mylib.cle, Mylib.iv));
            //client
            cn.Open();
            SqlCommand com = new SqlCommand("select * from client where id_client=" + Program.id, cn);
            SqlDataReader re = com.ExecuteReader();

            dt.Load(re);

            textBox1.DataBindings.Add("Text", dt, "nom");
            textBox3.DataBindings.Add("Text", dt, "email");
            textBox2.DataBindings.Add("Text", dt, "prenom");
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
