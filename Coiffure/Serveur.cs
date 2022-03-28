using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coiffure
{
    public partial class Serveur : Form
    {
        public Serveur()
        {
            InitializeComponent();
        }

        private void Serveur_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
        }

        private void btn_connecter_Click(object sender, EventArgs e)
        {
            string chemin = @"Data Source=" + txt_nom_server.Text + ";Initial Catalog=salon;User ID=" + txt_utilisateur.Text + ";Password=" + txt_password.Text;
            SqlConnection cs = new SqlConnection(chemin);
            try
            {
                cs.Open();
                if (cs.State == ConnectionState.Open)
                {
                    chemin = Convert.ToBase64String(Mylib.EncryptSym(chemin, Mylib.cle, Mylib.iv));
                    Appsetting ap = new Appsetting(chemin);
                    StreamWriter st = new StreamWriter("Appsetting.txt");
                    st.WriteLine(chemin);
                    st.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("les informations sont incorrectes ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "les informations sont incorrectes");
            }

        }
    }
}
