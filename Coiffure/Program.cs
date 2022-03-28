using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Coiffure
{
    static class Program
    {
        public static List<string> cr = new List<string>
        {
            "AntiqueWhite","MediumTurquoise","DarkCyan","LightSalmon","Aquamarine"
            ,"SeaGreen","DarkSlateGray","LightCoral","Salmon","DodgerBlue","Orange"

        };
        public static string chenging = "";
        public static bool ClientVisiblity = false;
        public static bool CoiffeurVisiblity = false;
        public static int id = 0;

        //public static Form activeForm = null;
        //public static Label lb_home;
        //public static Panel panel1;
        //public static Reserver re= new Reserver();

        //public static void ShowForm(Form r, string t,Panel panel1,Label lb_home)
        //{
        //    if (activeForm != null)
        //    {
        //        activeForm.Close();

        //    }
        //    activeForm = r;
        //    r.TopLevel = false;
        //    r.FormBorderStyle = FormBorderStyle.None;
        //    r.Dock = DockStyle.Fill;
        //    panel1.Controls.Add(r);
        //    panel1.Tag = r;
        //
        //    lb_home.Text = t;
        //    r.Show();
        //}
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Accueil());
        }
    }
}
