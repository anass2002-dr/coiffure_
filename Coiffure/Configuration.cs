using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace Coiffure
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }
        bool modefier = false;
        string chemin = "";
        SqlConnection cn;
        private void Configuration_Load(object sender, EventArgs e)
        {
            StreamReader red = new StreamReader("Appsetting.txt");
            chemin = red.ReadToEnd();

            cn = new SqlConnection(Mylib.DecryptSym(Convert.FromBase64String(chemin), Mylib.cle, Mylib.iv));

            if (Program.ClientVisiblity)
            {
                cn.Open();
                SqlCommand com = new SqlCommand("select * from client c inner join ville v on c.id_ville=v.id_ville where id_client=" + Program.id, cn);
                SqlDataReader re = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(re);

                txt_email.DataBindings.Add("Text", dt, "email");
                txt_prenom.DataBindings.Add("Text", dt, "prenom");
                txt_nom.DataBindings.Add("Text", dt, "nom");
                txt_password.DataBindings.Add("Text", dt, "password");
                txt_ville.DataBindings.Add("Text", dt, "ville");
                cn.Close();
                re.Close();
                
            }
            else if (Program.CoiffeurVisiblity)
            {
                cn.Open();
                SqlCommand com = new SqlCommand("select * from coiffeur c inner join ville v on c.id_ville=v.id_ville where id_coiffeur =" + Program.id, cn);
                SqlDataReader re = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(re);
                
                txt_email.DataBindings.Add("Text", dt, "email");
                txt_prenom.DataBindings.Add("Text", dt, "prenom");
                txt_nom.DataBindings.Add("Text", dt, "nom");
                txt_password.DataBindings.Add("Text", dt, "password");
                txt_ville.DataBindings.Add("Text", dt, "ville");
                cn.Close();
                re.Close();
            }
        }



        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btn_modefier_sauvgarder_Click_1(object sender, EventArgs e)
        {
            if (!modefier)
            {
                active(true);
                btn_modefier_sauvgarder.Text = "Sauvegarder";
                btn_annule.Visible = true;
                modefier = true;
                lb_password.Text = "Nouveau mot de passe  :";
            }
            else
            {
                if (vide())
                {
                    StreamReader red = new StreamReader("Appsetting.txt");
                    chemin = red.ReadToEnd();

                    cn = new SqlConnection(Mylib.DecryptSym(Convert.FromBase64String(chemin), Mylib.cle, Mylib.iv));
                    if (Program.ClientVisiblity && vide())
                    {
                        cn.Open();
                        SqlCommand com = new SqlCommand("update client set email=@email,nom=@nom,prenom=@prenom," +
                            "password=@password where id_client=" + Program.id, cn);
                        com.Parameters.AddWithValue("@email", txt_email.Text);
                        com.Parameters.AddWithValue("@nom", txt_nom.Text);
                        com.Parameters.AddWithValue("@prenom", txt_prenom.Text);
                        com.Parameters.AddWithValue("@password", txt_password.Text);

                        com.ExecuteNonQuery();
                        MessageBox.Show("la modification a été  bien éffectuée");
                        cn.Close();


                    }
                    else if (Program.CoiffeurVisiblity && vide())
                    {
                        cn.Open();
                        SqlCommand com = new SqlCommand("update coiffeur set email=@email,nom=@nom,prenom=@prenom," +
                            "password=@password where id_coiffeur=" + Program.id, cn);
                        com.Parameters.AddWithValue("@email", txt_email.Text);
                        com.Parameters.AddWithValue("@nom", txt_nom.Text);
                        com.Parameters.AddWithValue("@prenom", txt_prenom.Text);
                        com.Parameters.AddWithValue("@password", txt_password.Text);
                        com.ExecuteNonQuery();
                        MessageBox.Show("la modification a été bien éffectuée");
                        cn.Close();
                    }
                }
                else
                {
                    MessageBox.Show(" remplissez tous les zones svp !");
                }
               
                active(false);
                btn_modefier_sauvgarder.Text = "Modifier";
                btn_annule.Visible = false;
                modefier = false;
                lb_password.Text = "Mot de passe :";
            }
        }
        public void active(bool a)
        {
            txt_email.Enabled = a;
            txt_nom.Enabled = a;
            txt_password.Enabled = a;
            txt_prenom.Enabled = a;
        }
        public bool vide()
        {
            if(txt_nom.Text!="" || txt_prenom.Text != "" || txt_ville.Text != "" || txt_email.Text != "" || txt_password.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btn_annule_Click_1(object sender, EventArgs e)
        {
            btn_modefier_sauvgarder.Text = "Modifier";
            modefier = false;
            btn_annule.Visible = false;
            lb_password.Text = "Mot de passe :";

            active(false);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Anglais":
                    System.Threading.Thread.CurrentThread.CurrentUICulture =System.Globalization.CultureInfo.GetCultureInfo("en");
                    this.RightToLeft = RightToLeft.No;
                    this.RightToLeftLayout = false;

                    break;
                case "Français":
                    System.Threading.Thread.CurrentThread.CurrentUICulture =System.Globalization.CultureInfo.GetCultureInfo("fr");
                    this.RightToLeft = RightToLeft.No;
                    this.RightToLeftLayout = false;
                    break;
          
            }
        }
    }
}
