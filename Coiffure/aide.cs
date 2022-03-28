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
    public partial class aide : Form
    {
        SqlConnection cn;
        string chemin = "";
        public aide()
        {
            InitializeComponent();
        }

        private void btn_suppression_Click(object sender, EventArgs e)
        {
            pnlsuppression.Visible = true;
            pnlavis.Visible = false;
            StreamReader red = new StreamReader("Appsetting.txt");
            chemin = red.ReadToEnd();

            cn = new SqlConnection(Mylib.DecryptSym(Convert.FromBase64String(chemin), Mylib.cle, Mylib.iv));

        }

        private void btn_ajouterAvis_Click(object sender, EventArgs e)
        {

            pnlavis.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader red = new StreamReader("Appsetting.txt");
            chemin = red.ReadToEnd();

            cn = new SqlConnection(Mylib.DecryptSym(Convert.FromBase64String(chemin), Mylib.cle, Mylib.iv));
            if (txtemail.Text != "")
            {
                if (MessageBox.Show("Etes-vous sure de vouloir supprimer votre compte ? ", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cn.Open();
                    SqlCommand com = new SqlCommand("delete from client where email like ('" + txtemail.Text + "')",cn);
                    com.ExecuteNonQuery();

                    MessageBox.Show("Suppression avec succée");
                }
                else
                {
                    pnlsuppression.Visible = false;
                    MessageBox.Show("Veuillez comfirmer votre email,Merci");
                }
            }
        }

        private void btn_envoyer_Click(object sender, EventArgs e)
        {
            txt_avis.Text = "Merci d'avoir partager votre avis .";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
