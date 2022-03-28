using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Coiffure
{
    public partial class Reserver : Form
    {
        public Reserver()
        {
            InitializeComponent();
        }
        string chemin = "";
        SqlConnection cn;
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt5 = new DataTable();
        private void Reserver_Load(object sender, EventArgs e)
        {
            panel_inside.BackColor = Color.FromArgb(100, 0, 0, 0);
            lb_salon.BackColor = System.Drawing.Color.Transparent;
            lb_style.BackColor = System.Drawing.Color.Transparent;
            lb_temps.BackColor = System.Drawing.Color.Transparent;
            lb_ville.BackColor = System.Drawing.Color.Transparent;
            lb_prix_total.BackColor = System.Drawing.Color.Transparent;
            lb_nom_client.BackColor = System.Drawing.Color.Transparent;
            lb_nom_coiffeur.BackColor = System.Drawing.Color.Transparent;
            dateTimePicker1.MinDate = DateTime.Now;

            StreamReader red = new StreamReader("Appsetting.txt");
            chemin = red.ReadToEnd();

            cn = new SqlConnection(Mylib.DecryptSym(Convert.FromBase64String(chemin), Mylib.cle, Mylib.iv));
            //client
            cn.Open();
            SqlCommand com = new SqlCommand("select * from client where id_client=" + Program.id, cn);
            SqlDataReader re = com.ExecuteReader();
            
            dt1.Load(re);

            txt_nom_client.DataBindings.Add("Text", dt1, "nom");
            //txt_prenom.DataBindings.Add("Text", dt, "prenom");
            //txt_nom.DataBindings.Add("Text", dt, "nom");
            //txt_password.DataBindings.Add("Text", dt, "password");
            //txt_ville.DataBindings.Add("Text", dt, "ville");
            cn.Close();
            re.Close();

            //coiffure
            cn.Open();
            SqlCommand com2 = new SqlCommand("select * from coiffure c inner join ville v on c.id_ville=v.id_ville inner join coiffeur cr on cr.id_coiffeur=c.id_coiffeur", cn);
            SqlDataReader re2 = com2.ExecuteReader();
            dt2.Load(re2);
            cb_salon.DisplayMember = "salon";
            cb_salon.ValueMember = "id_coiffure";
            cb_salon.DataSource = dt2;

            cb_ville.DisplayMember = "ville";
            cb_ville.ValueMember = "id_coiffure";
            cb_ville.DataSource = dt2;
            txt_nom_salon.DataBindings.Add("Text", dt2, "salon");
            txt_nom_coiffeur.DataBindings.Add("Text", dt2, "nom");

            cn.Close();
            re2.Close();

            //style
            cn.Open();
            SqlCommand com3 = new SqlCommand("select * from style", cn);
            SqlDataReader re3 = com3.ExecuteReader();
            dt3.Load(re3);
            cb_type_style.DisplayMember = "nom_style";
            cb_type_style.ValueMember = "id_style";
            cb_type_style.DataSource = dt3;
            
            txt_nom_style_panel_right.DataBindings.Add("Text", dt3, "nom_style");
            txt_prix_panel_right.DataBindings.Add("Text", dt3, "prix");

            txt_style.DataBindings.Add("Text", dt3, "nom_style");
            txt_prix_total.DataBindings.Add("Text", dt3, "prix");
            cn.Close();
            re3.Close();
            //calendrier
            //cn.Open();
            //SqlCommand com4 = new SqlCommand("select * from calendrier", cn);
            //SqlDataReader re4 = com4.ExecuteReader();
            //dt4.Load(re4);
            //cb_temps.DisplayMember = "temps";
            //cb_temps.ValueMember = "id_temps";
            //cb_temps.DataSource = dt4;

            //txt_temps.DataBindings.Add("Text", dt4, "temps");

            //cn.Close();
            //re4.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cb_type_style_SelectedIndexChanged(object sender, EventArgs e)
        {

            //string chemin = @"C:\Users\bismilah\Desktop\mini_projet\Coiffure\images\2.jpg";
            //string chemin = @"images/2.jpg";
            //pictureBox1.Image = Bitmap.FromFile(chemin);
            //int indix = cb_type_style.SelectedIndex + 1;
            //pictureBox1.Image = Bitmap.FromFile(chemin);
            int ind = cb_type_style.SelectedIndex;
            switch (ind)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources._1;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources._2;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._3;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._4;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._5;
                    break;
            }
        }

        private void btn_reserver_Click(object sender, EventArgs e)
        {
            
            //StreamReader red = new StreamReader("Appsetting.txt");
            //chemin = red.ReadToEnd();

            //cn = new SqlConnection(Mylib.DecryptSym(Convert.FromBase64String(chemin), Mylib.cle, Mylib.iv));
            ////client
            //cn.Open();

            //cn.Close();
            //cn.Open();
            //SqlCommand com = new SqlCommand("insert into reservation values(@id_client,@id_coiffeur,@id_coiffure,@id_style,@id_temps,@_date", cn);
            //com.Parameters.AddWithValue("@id_client",Program.id);
            //com.Parameters.AddWithValue("@id_coiffeur",);
            //com.Parameters.AddWithValue("@id_coiffure",);
            //com.Parameters.AddWithValue("@id_style",);
            //com.Parameters.AddWithValue("@id_temps",);
            //com.Parameters.AddWithValue("@_date",);

        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            StreamReader red = new StreamReader("Appsetting.txt");
            chemin = red.ReadToEnd();

            cn = new SqlConnection(Mylib.DecryptSym(Convert.FromBase64String(chemin), Mylib.cle, Mylib.iv));
            //client
            cn.Open();
            SqlCommand com = new SqlCommand("select * from calendrier where id_temps not in (select id_temps from reservation where _date like '" + dateTimePicker1.Value+"')", cn);
            SqlDataReader re = com.ExecuteReader();
            dt5.Load(re);

            cb_temps.DisplayMember = "temps";
            cb_temps.ValueMember = "id_temps";
            cb_temps.DataSource = dt5;
            txt_temps.DataBindings.Add("Text", dt5, "temps");

            cn.Close();
            re.Close();
            btn_reserver.Visible = true;
        }

        private void panel_header_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
