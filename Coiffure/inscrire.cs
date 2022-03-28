using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
namespace Coiffure
{
    public partial class inscrire : Form
    {
        //string cs = @"Data Source =DESKTOP-U2EH85I\SQL ;initial catalog=salon ;user id=sa;password=123456";
        public inscrire()
        {
            
            InitializeComponent();
            //[DllImport("gdi32.dll")];
            // IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2,
            //   int cx, int cy);
        }
        string chemin = "";
        private void inscrire_Load(object sender, EventArgs e)
        {
            //panel3.Region = Region.FromHrgn();
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            //btn_inscrir.BackColor = System.Drawing.Color.Transparent;
            btn_left.BackColor = System.Drawing.Color.Transparent;

            lb_nom.BackColor = System.Drawing.Color.Transparent;
            lb_confirmer.BackColor = System.Drawing.Color.Transparent;
            lb_email.BackColor = System.Drawing.Color.Transparent;
            lb_password.BackColor = System.Drawing.Color.Transparent;
            lb_prenom.BackColor = System.Drawing.Color.Transparent;
            lb_ville.BackColor = System.Drawing.Color.Transparent;
            rb_client.BackColor = System.Drawing.Color.Transparent;
            rb_coiffeur.BackColor = System.Drawing.Color.Transparent;

            //txt_confirmer.BackColor = System.Drawing.Color.Transparent;
            //txt_email.BackColor = System.Drawing.Color.Transparent;
            //txt_password.BackColor = System.Drawing.Color.Transparent;
            //txt_prenom.BackColor = System.Drawing.Color.Transparent;
            //cb_ville.BackColor = System.Drawing.Color.Transparent;
            StreamReader red = new StreamReader("Appsetting.txt");
            string chemin = red.ReadToEnd();

            SqlConnection cn = new SqlConnection(Mylib.DecryptSym(Convert.FromBase64String(chemin), Mylib.cle, Mylib.iv));
            cn.Open();
            SqlCommand com = new SqlCommand();
            com = new SqlCommand("select * from  client ", cn);
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cb_ville.DisplayMember = "ville";
            cb_ville.ValueMember = "id_client";
            cb_ville.DataSource = dt;

        }
        void ini()
        {
            txt_confirmer.DataBindings.Clear();
            txt_email.DataBindings.Clear();
            txt_password.DataBindings.Clear();
            txt_prenom.DataBindings.Clear();
            txt_nom.DataBindings.Clear();
            


            txt_confirmer.Clear();
            txt_email.Clear();
            txt_password.Clear();
            txt_prenom.Clear();
            txt_nom.Clear();
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void rb_client_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_inscrire_Click(object sender, EventArgs e)
        {
            StreamReader red = new StreamReader("Appsetting.txt");
            chemin = red.ReadToEnd();
            SqlConnection cn = new SqlConnection(Mylib.DecryptSym(Convert.FromBase64String(chemin), Mylib.cle, Mylib.iv));
 
            cn.Open();
            SqlCommand com = new SqlCommand();
       
            if (rb_client.Checked == true)
            {
                
                com = new SqlCommand("insert into client values ( @nom, @prenom, @email, @password,@ville )", cn);
                if(txt_password!= txt_confirmer) { }
                com.Parameters.AddWithValue("@nom", txt_nom.Text);
                com.Parameters.AddWithValue("@prenom", txt_prenom.Text);
                com.Parameters.AddWithValue("@email", txt_email.Text);
                com.Parameters.AddWithValue("@password", txt_password.Text);
                com.Parameters.AddWithValue("@ville", cb_ville.SelectedText);
                com.ExecuteNonQuery();

            }
             else if (rb_coiffeur.Checked == true)
             {

                SqlCommand c = new SqlCommand("insert into coiffeur values ( @nom, @prenom, @email, @password,@ville )", cn);
                c.Parameters.AddWithValue("@nom", txt_nom.Text);
                c.Parameters.AddWithValue("@prenom", txt_prenom.Text);
                c.Parameters.AddWithValue("@email", txt_email.Text);
                c.Parameters.AddWithValue("@password", txt_password.Text);
                c.Parameters.AddWithValue("@ville", cb_ville.Text);
                c.ExecuteNonQuery();

             }
            ini();
            cn.Close();

            Program.chenging = "conecter";
            this.Close();

            //else if (rb_coiffeur.Checked == true)
            //{

            //    com = new SqlCommand("insert into coiffeur values ( @nom, @prenom, @email, @password,@ville )", cn);
            //    com.Parameters.AddWithValue("@nom", txt_nom.Text);
            //    com.Parameters.AddWithValue("@prenom", txt_prenom.Text);
            //    com.Parameters.AddWithValue("@email", txt_email.Text);
            //    com.Parameters.AddWithValue("@password", txt_password.Text);
            //    com.Parameters.AddWithValue("@ville", cb_ville.SelectedValue);

            //}




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
