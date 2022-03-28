using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Coiffure
{
    public partial class conecter : Form
    {
        //string cs = @"Data Source =DESKTOP-U2EH85I\SQL ;initial catalog=salon ;user id=sa;password=123456";
        public conecter()
        {
            InitializeComponent();
        }
        //bool p = false;
        SqlConnection cn;
        string chemin = "";
        bool exist = false;
        //string chemine = @"Data Source=DESKTOP-AD61IOL\SQLEXPRESS;Initial Catalog=salon;User ID=sa;Password=123456";
       

        private void conecter_Load(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            lb_coneceter.BackColor = System.Drawing.Color.Transparent;
            panel_email.BackColor = System.Drawing.Color.Transparent;
            panel_password.BackColor = System.Drawing.Color.Transparent;
            btn_close.BackColor = System.Drawing.Color.Transparent;
            btn_eye.BackColor = System.Drawing.Color.Transparent;
            //btn_conecter.BackColor = System.Drawing.Color.Transparent;
            btn_oublier.BackColor = System.Drawing.Color.Transparent;
            txt_email.BackColor = this.BackColor;
            txt_password.BackColor = this.BackColor;
            lk_incrire.BackColor = System.Drawing.Color.Transparent;
            lb_compte_non.BackColor = System.Drawing.Color.Transparent;
            rb_client.BackColor = System.Drawing.Color.Transparent;
            rb_coiffeur.BackColor = System.Drawing.Color.Transparent;

            //btn_conecter.ForeColor = Color.LightSeaGreen;

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_conecter_Click(object sender, EventArgs e)
        {
            remplir();
            StreamReader red = new StreamReader("Appsetting.txt");
            chemin = red.ReadToEnd();
            
            cn = new SqlConnection(Mylib.DecryptSym(Convert.FromBase64String(chemin),Mylib.cle ,Mylib.iv));
            if (rb_client.Checked)
            {
                cn.Open();
                SqlCommand com = new SqlCommand("select * from client where email like '" + txt_email.Text + "'", cn);
                SqlDataReader re = com.ExecuteReader();
                string pass = "";
                while (re.Read())
                {
                    pass = re["password"].ToString();
                    Program.id = Convert.ToInt32(re["id_client"]);
                    exist = true;
                }
                if (exist)
                {
                    if (pass == txt_password.Text)
                    {

                        Program.chenging = "Reserver";
                        Program.ClientVisiblity = true;
                        this.Close();
                    }
                    else
                    {
                        Program.id = 0;
                        MessageBox.Show("Mot de passe est inccorect !");
                        txt_password.Text = "Mot de passe";
                    }
                }
                else
                {
                    MessageBox.Show("Email est inccorect !");
                    txt_email.Text = "Entrez Votre Email";
                }
                cn.Close();
                re.Close();
            }
            else if (rb_coiffeur.Checked)
            {
                cn.Open();
                SqlCommand com = new SqlCommand("select * from coiffeur where email like '" + txt_email.Text + "'", cn);
                SqlDataReader re = com.ExecuteReader();
                string pass = "";
                while (re.Read())
                {
                    pass = re["password"].ToString();
                    Program.id = Convert.ToInt32(re["id_coiffeur"]);
                    exist = true;
                }
                if (exist)
                {
                    if (pass == txt_password.Text)
                    {
                        Program.chenging = "Gere_les_client";
                        Program.CoiffeurVisiblity = true;
                        this.Close();
                    }
                    else
                    {
                        Program.id = 0;
                        MessageBox.Show("Mot de pass est inccorect !");
                        txt_password.Text = "Mot de passe";
                    }
                }
                else
                {
                    MessageBox.Show("Email est inccorect !");
                    txt_email.Text = "Entrez Votre Email";

                }
                cn.Close();
                re.Close();
            }



        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void remplir()
        {
            if(txt_email.Text == "Entrez Votre Email"|| txt_email.Text == "Enter your email")
            {
                MessageBox.Show("si vous plait remplissez la zone d'email !");
            }
            if (txt_password.Text == "Mot de passe" || txt_password.Text == "Password")
            {
                MessageBox.Show("si vous plait remplissez la zone de mot de passe !");
            }
        }
        private void lk_incrire_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.chenging = "inscrire";
            this.Close();
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t == txt_email)
            {
                if(txt_email.Text== "Entrez Votre Email")
                {
                    txt_email.Text = "";
                }
            }
            else
            {
                if (txt_password.Text == "Mot de passe")
                {
                    txt_password.Text = "";
                    txt_password.PasswordChar = '*';
                }
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t == txt_email)
            {
                if (txt_email.Text == "")
                {
                    txt_email.Text = "Entrez Votre Email";
                }
            }
            else
            {
                if (txt_password.Text == "")
                {
                    txt_password.Text = "Mot de passe";
                    txt_password.PasswordChar = '\0';

                }
            }
        }

        private void btn_eye_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '*')
            {
                txt_password.PasswordChar='\0';
                btn_eye.Image =Image.FromFile(@"C:\Users\user\Desktop\Coiffurelakher-master\images\icons\invisible.png");
            }
            else
            {
                txt_password.PasswordChar = '*';
                btn_eye.Image = Image.FromFile(@"C:\Users\user\Desktop\Coiffurelakher-master\images\icons\eye_24px_blue.png");

            }
        }

        private void btn_oublier_Click(object sender, EventArgs e)
        {
            
        }
    }
}
