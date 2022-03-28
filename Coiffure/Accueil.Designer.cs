
namespace Coiffure
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_gere = new System.Windows.Forms.Button();
            this.btn_server = new System.Windows.Forms.Button();
            this.btn_Configuration = new System.Windows.Forms.Button();
            this.btn_aide = new System.Windows.Forms.Button();
            this.btn_inscrir = new System.Windows.Forms.Button();
            this.btn_conecter = new System.Windows.Forms.Button();
            this.btn_reservation = new System.Windows.Forms.Button();
            this.panel_salon = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_accueil = new System.Windows.Forms.Panel();
            this.btn_minimiz = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_substract = new System.Windows.Forms.Button();
            this.lb_home = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.panel_salon.SuspendLayout();
            this.panel_accueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            resources.ApplyResources(this.panel_menu, "panel_menu");
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.panel_menu.Controls.Add(this.btn_gere);
            this.panel_menu.Controls.Add(this.btn_server);
            this.panel_menu.Controls.Add(this.btn_Configuration);
            this.panel_menu.Controls.Add(this.btn_aide);
            this.panel_menu.Controls.Add(this.btn_inscrir);
            this.panel_menu.Controls.Add(this.btn_conecter);
            this.panel_menu.Controls.Add(this.btn_reservation);
            this.panel_menu.Controls.Add(this.panel_salon);
            this.panel_menu.Name = "panel_menu";
            // 
            // btn_gere
            // 
            resources.ApplyResources(this.btn_gere, "btn_gere");
            this.btn_gere.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_gere.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_gere.Image = global::Coiffure.Properties.Resources.reception_24px;
            this.btn_gere.Name = "btn_gere";
            this.btn_gere.UseVisualStyleBackColor = true;
            this.btn_gere.Click += new System.EventHandler(this.btn_reservation_Click);
            this.btn_gere.MouseEnter += new System.EventHandler(this.btn_reservation_MouseEnter_1);
            this.btn_gere.MouseLeave += new System.EventHandler(this.btn_reservation_MouseLeave_1);
            // 
            // btn_server
            // 
            resources.ApplyResources(this.btn_server, "btn_server");
            this.btn_server.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_server.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_server.Image = global::Coiffure.Properties.Resources.server_24px;
            this.btn_server.Name = "btn_server";
            this.btn_server.UseVisualStyleBackColor = true;
            this.btn_server.Click += new System.EventHandler(this.btn_reservation_Click);
            this.btn_server.MouseEnter += new System.EventHandler(this.btn_reservation_MouseEnter_1);
            this.btn_server.MouseLeave += new System.EventHandler(this.btn_reservation_MouseLeave_1);
            // 
            // btn_Configuration
            // 
            resources.ApplyResources(this.btn_Configuration, "btn_Configuration");
            this.btn_Configuration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Configuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Configuration.Image = global::Coiffure.Properties.Resources.tune_24px;
            this.btn_Configuration.Name = "btn_Configuration";
            this.btn_Configuration.UseVisualStyleBackColor = true;
            this.btn_Configuration.Click += new System.EventHandler(this.btn_reservation_Click);
            this.btn_Configuration.MouseEnter += new System.EventHandler(this.btn_reservation_MouseEnter_1);
            this.btn_Configuration.MouseLeave += new System.EventHandler(this.btn_reservation_MouseLeave_1);
            // 
            // btn_aide
            // 
            resources.ApplyResources(this.btn_aide, "btn_aide");
            this.btn_aide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_aide.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_aide.Image = global::Coiffure.Properties.Resources.help_24px;
            this.btn_aide.Name = "btn_aide";
            this.btn_aide.UseVisualStyleBackColor = true;
            this.btn_aide.Click += new System.EventHandler(this.btn_reservation_Click);
            this.btn_aide.MouseEnter += new System.EventHandler(this.btn_reservation_MouseEnter_1);
            this.btn_aide.MouseLeave += new System.EventHandler(this.btn_reservation_MouseLeave_1);
            // 
            // btn_inscrir
            // 
            resources.ApplyResources(this.btn_inscrir, "btn_inscrir");
            this.btn_inscrir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_inscrir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_inscrir.Image = global::Coiffure.Properties.Resources.plus___24px;
            this.btn_inscrir.Name = "btn_inscrir";
            this.btn_inscrir.UseVisualStyleBackColor = true;
            this.btn_inscrir.Click += new System.EventHandler(this.btn_reservation_Click);
            this.btn_inscrir.MouseEnter += new System.EventHandler(this.btn_reservation_MouseEnter_1);
            this.btn_inscrir.MouseLeave += new System.EventHandler(this.btn_reservation_MouseLeave_1);
            // 
            // btn_conecter
            // 
            resources.ApplyResources(this.btn_conecter, "btn_conecter");
            this.btn_conecter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_conecter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_conecter.Image = global::Coiffure.Properties.Resources.account_24px;
            this.btn_conecter.Name = "btn_conecter";
            this.btn_conecter.UseVisualStyleBackColor = true;
            this.btn_conecter.Click += new System.EventHandler(this.btn_reservation_Click);
            this.btn_conecter.MouseEnter += new System.EventHandler(this.btn_reservation_MouseEnter_1);
            this.btn_conecter.MouseLeave += new System.EventHandler(this.btn_reservation_MouseLeave_1);
            // 
            // btn_reservation
            // 
            resources.ApplyResources(this.btn_reservation, "btn_reservation");
            this.btn_reservation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_reservation.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_reservation.Image = global::Coiffure.Properties.Resources.reserve_24px;
            this.btn_reservation.Name = "btn_reservation";
            this.btn_reservation.UseVisualStyleBackColor = true;
            this.btn_reservation.Click += new System.EventHandler(this.btn_reservation_Click);
            this.btn_reservation.MouseEnter += new System.EventHandler(this.btn_reservation_MouseEnter_1);
            this.btn_reservation.MouseLeave += new System.EventHandler(this.btn_reservation_MouseLeave_1);
            // 
            // panel_salon
            // 
            resources.ApplyResources(this.panel_salon, "panel_salon");
            this.panel_salon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(56)))));
            this.panel_salon.Controls.Add(this.label2);
            this.panel_salon.Name = "panel_salon";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Image = global::Coiffure.Properties.Resources.barbershop_24px;
            this.label2.Name = "label2";
            // 
            // panel_accueil
            // 
            resources.ApplyResources(this.panel_accueil, "panel_accueil");
            this.panel_accueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel_accueil.Controls.Add(this.btn_minimiz);
            this.panel_accueil.Controls.Add(this.btn_close);
            this.panel_accueil.Controls.Add(this.btn_substract);
            this.panel_accueil.Controls.Add(this.lb_home);
            this.panel_accueil.Name = "panel_accueil";
            this.panel_accueil.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_accueil_Paint);
            // 
            // btn_minimiz
            // 
            resources.ApplyResources(this.btn_minimiz, "btn_minimiz");
            this.btn_minimiz.FlatAppearance.BorderSize = 0;
            this.btn_minimiz.Image = global::Coiffure.Properties.Resources.minimize_window_24px_white;
            this.btn_minimiz.Name = "btn_minimiz";
            this.btn_minimiz.UseVisualStyleBackColor = true;
            this.btn_minimiz.Click += new System.EventHandler(this.btn_minimiz_Click);
            // 
            // btn_close
            // 
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.Image = global::Coiffure.Properties.Resources.close_window_24px;
            this.btn_close.Name = "btn_close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_substract
            // 
            resources.ApplyResources(this.btn_substract, "btn_substract");
            this.btn_substract.FlatAppearance.BorderSize = 0;
            this.btn_substract.Image = global::Coiffure.Properties.Resources.subtract_24px_white;
            this.btn_substract.Name = "btn_substract";
            this.btn_substract.UseVisualStyleBackColor = true;
            this.btn_substract.Click += new System.EventHandler(this.btn_substract_Click);
            // 
            // lb_home
            // 
            resources.ApplyResources(this.lb_home, "lb_home");
            this.lb_home.ForeColor = System.Drawing.Color.White;
            this.lb_home.Name = "lb_home";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackgroundImage = global::Coiffure.Properties.Resources.pexels_nick_demou_1319458;
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Accueil
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_accueil);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_salon.ResumeLayout(false);
            this.panel_accueil.ResumeLayout(false);
            this.panel_accueil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btn_aide;
        private System.Windows.Forms.Button btn_inscrir;
        private System.Windows.Forms.Button btn_conecter;
        private System.Windows.Forms.Button btn_reservation;
        private System.Windows.Forms.Panel panel_salon;
        private System.Windows.Forms.Panel panel_accueil;
        private System.Windows.Forms.Label lb_home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Configuration;
        private System.Windows.Forms.Button btn_minimiz;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_substract;
        private System.Windows.Forms.Button btn_server;
        private System.Windows.Forms.Button btn_gere;
    }
}

