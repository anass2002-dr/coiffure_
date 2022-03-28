
namespace Coiffure
{
    partial class Reserver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserver));
            this.cb_ville = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_salon = new System.Windows.Forms.ComboBox();
            this.cb_temps = new System.Windows.Forms.ComboBox();
            this.panel_header = new System.Windows.Forms.Panel();
            this.lb_temps_header = new System.Windows.Forms.Label();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.lb_salon_header = new System.Windows.Forms.Label();
            this.lb_date_header = new System.Windows.Forms.Label();
            this.lb_ville = new System.Windows.Forms.Label();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_inside = new System.Windows.Forms.Panel();
            this.btn_reserver = new System.Windows.Forms.Button();
            this.txt_prix_total = new System.Windows.Forms.TextBox();
            this.txt_temps = new System.Windows.Forms.TextBox();
            this.txt_style = new System.Windows.Forms.TextBox();
            this.txt_nom_client = new System.Windows.Forms.TextBox();
            this.txt_nom_coiffeur = new System.Windows.Forms.TextBox();
            this.txt_nom_salon = new System.Windows.Forms.TextBox();
            this.lb_prix_total = new System.Windows.Forms.Label();
            this.lb_temps = new System.Windows.Forms.Label();
            this.lb_style = new System.Windows.Forms.Label();
            this.lb_salon = new System.Windows.Forms.Label();
            this.lb_nom_client = new System.Windows.Forms.Label();
            this.lb_nom_coiffeur = new System.Windows.Forms.Label();
            this.panel_right = new System.Windows.Forms.Panel();
            this.txt_prix_panel_right = new System.Windows.Forms.TextBox();
            this.txt_nom_style_panel_right = new System.Windows.Forms.TextBox();
            this.cb_type_style = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_header.SuspendLayout();
            this.panel_body.SuspendLayout();
            this.panel_inside.SuspendLayout();
            this.panel_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_ville
            // 
            resources.ApplyResources(this.cb_ville, "cb_ville");
            this.cb_ville.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ville.FormattingEnabled = true;
            this.cb_ville.Name = "cb_ville";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cb_salon
            // 
            resources.ApplyResources(this.cb_salon, "cb_salon");
            this.cb_salon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_salon.FormattingEnabled = true;
            this.cb_salon.Name = "cb_salon";
            // 
            // cb_temps
            // 
            resources.ApplyResources(this.cb_temps, "cb_temps");
            this.cb_temps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_temps.FormattingEnabled = true;
            this.cb_temps.Name = "cb_temps";
            // 
            // panel_header
            // 
            resources.ApplyResources(this.panel_header, "panel_header");
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(154)))));
            this.panel_header.Controls.Add(this.cb_temps);
            this.panel_header.Controls.Add(this.lb_temps_header);
            this.panel_header.Controls.Add(this.btn_rechercher);
            this.panel_header.Controls.Add(this.cb_salon);
            this.panel_header.Controls.Add(this.dateTimePicker1);
            this.panel_header.Controls.Add(this.cb_ville);
            this.panel_header.Controls.Add(this.lb_salon_header);
            this.panel_header.Controls.Add(this.lb_date_header);
            this.panel_header.Controls.Add(this.lb_ville);
            this.panel_header.Name = "panel_header";
            this.panel_header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_header_Paint);
            // 
            // lb_temps_header
            // 
            resources.ApplyResources(this.lb_temps_header, "lb_temps_header");
            this.lb_temps_header.Image = global::Coiffure.Properties.Resources.clock_24px;
            this.lb_temps_header.Name = "lb_temps_header";
            // 
            // btn_rechercher
            // 
            resources.ApplyResources(this.btn_rechercher, "btn_rechercher");
            this.btn_rechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.btn_rechercher.FlatAppearance.BorderSize = 0;
            this.btn_rechercher.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_rechercher.Image = global::Coiffure.Properties.Resources.search_more_24px;
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = false;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // lb_salon_header
            // 
            resources.ApplyResources(this.lb_salon_header, "lb_salon_header");
            this.lb_salon_header.Image = global::Coiffure.Properties.Resources.barber_chair_24px;
            this.lb_salon_header.Name = "lb_salon_header";
            // 
            // lb_date_header
            // 
            resources.ApplyResources(this.lb_date_header, "lb_date_header");
            this.lb_date_header.Image = global::Coiffure.Properties.Resources.pay_date_24px;
            this.lb_date_header.Name = "lb_date_header";
            // 
            // lb_ville
            // 
            resources.ApplyResources(this.lb_ville, "lb_ville");
            this.lb_ville.Image = global::Coiffure.Properties.Resources.city_24px;
            this.lb_ville.Name = "lb_ville";
            // 
            // panel_body
            // 
            resources.ApplyResources(this.panel_body, "panel_body");
            this.panel_body.BackColor = System.Drawing.Color.White;
            this.panel_body.BackgroundImage = global::Coiffure.Properties.Resources.pexels_josh_sorenson_9953001;
            this.panel_body.Controls.Add(this.panel_inside);
            this.panel_body.Controls.Add(this.panel_right);
            this.panel_body.Name = "panel_body";
            // 
            // panel_inside
            // 
            resources.ApplyResources(this.panel_inside, "panel_inside");
            this.panel_inside.BackColor = System.Drawing.Color.Silver;
            this.panel_inside.Controls.Add(this.btn_reserver);
            this.panel_inside.Controls.Add(this.txt_prix_total);
            this.panel_inside.Controls.Add(this.txt_temps);
            this.panel_inside.Controls.Add(this.txt_style);
            this.panel_inside.Controls.Add(this.txt_nom_client);
            this.panel_inside.Controls.Add(this.txt_nom_coiffeur);
            this.panel_inside.Controls.Add(this.txt_nom_salon);
            this.panel_inside.Controls.Add(this.lb_prix_total);
            this.panel_inside.Controls.Add(this.lb_temps);
            this.panel_inside.Controls.Add(this.lb_style);
            this.panel_inside.Controls.Add(this.lb_salon);
            this.panel_inside.Controls.Add(this.lb_nom_client);
            this.panel_inside.Controls.Add(this.lb_nom_coiffeur);
            this.panel_inside.Name = "panel_inside";
            // 
            // btn_reserver
            // 
            resources.ApplyResources(this.btn_reserver, "btn_reserver");
            this.btn_reserver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.btn_reserver.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_reserver.FlatAppearance.BorderSize = 0;
            this.btn_reserver.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_reserver.Image = global::Coiffure.Properties.Resources.reserve_24px_2;
            this.btn_reserver.Name = "btn_reserver";
            this.btn_reserver.UseVisualStyleBackColor = false;
            this.btn_reserver.Click += new System.EventHandler(this.btn_reserver_Click);
            // 
            // txt_prix_total
            // 
            resources.ApplyResources(this.txt_prix_total, "txt_prix_total");
            this.txt_prix_total.Name = "txt_prix_total";
            // 
            // txt_temps
            // 
            resources.ApplyResources(this.txt_temps, "txt_temps");
            this.txt_temps.Name = "txt_temps";
            // 
            // txt_style
            // 
            resources.ApplyResources(this.txt_style, "txt_style");
            this.txt_style.Name = "txt_style";
            // 
            // txt_nom_client
            // 
            resources.ApplyResources(this.txt_nom_client, "txt_nom_client");
            this.txt_nom_client.Name = "txt_nom_client";
            // 
            // txt_nom_coiffeur
            // 
            resources.ApplyResources(this.txt_nom_coiffeur, "txt_nom_coiffeur");
            this.txt_nom_coiffeur.Name = "txt_nom_coiffeur";
            // 
            // txt_nom_salon
            // 
            resources.ApplyResources(this.txt_nom_salon, "txt_nom_salon");
            this.txt_nom_salon.Name = "txt_nom_salon";
            // 
            // lb_prix_total
            // 
            resources.ApplyResources(this.lb_prix_total, "lb_prix_total");
            this.lb_prix_total.Name = "lb_prix_total";
            // 
            // lb_temps
            // 
            resources.ApplyResources(this.lb_temps, "lb_temps");
            this.lb_temps.Name = "lb_temps";
            // 
            // lb_style
            // 
            resources.ApplyResources(this.lb_style, "lb_style");
            this.lb_style.Name = "lb_style";
            // 
            // lb_salon
            // 
            resources.ApplyResources(this.lb_salon, "lb_salon");
            this.lb_salon.Name = "lb_salon";
            // 
            // lb_nom_client
            // 
            resources.ApplyResources(this.lb_nom_client, "lb_nom_client");
            this.lb_nom_client.Name = "lb_nom_client";
            // 
            // lb_nom_coiffeur
            // 
            resources.ApplyResources(this.lb_nom_coiffeur, "lb_nom_coiffeur");
            this.lb_nom_coiffeur.Name = "lb_nom_coiffeur";
            // 
            // panel_right
            // 
            resources.ApplyResources(this.panel_right, "panel_right");
            this.panel_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.panel_right.Controls.Add(this.txt_prix_panel_right);
            this.panel_right.Controls.Add(this.txt_nom_style_panel_right);
            this.panel_right.Controls.Add(this.cb_type_style);
            this.panel_right.Controls.Add(this.label7);
            this.panel_right.Controls.Add(this.label6);
            this.panel_right.Controls.Add(this.label5);
            this.panel_right.Controls.Add(this.pictureBox1);
            this.panel_right.Name = "panel_right";
            // 
            // txt_prix_panel_right
            // 
            resources.ApplyResources(this.txt_prix_panel_right, "txt_prix_panel_right");
            this.txt_prix_panel_right.Name = "txt_prix_panel_right";
            // 
            // txt_nom_style_panel_right
            // 
            resources.ApplyResources(this.txt_nom_style_panel_right, "txt_nom_style_panel_right");
            this.txt_nom_style_panel_right.Name = "txt_nom_style_panel_right";
            // 
            // cb_type_style
            // 
            resources.ApplyResources(this.cb_type_style, "cb_type_style");
            this.cb_type_style.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type_style.FormattingEnabled = true;
            this.cb_type_style.Name = "cb_type_style";
            this.cb_type_style.SelectedIndexChanged += new System.EventHandler(this.cb_type_style_SelectedIndexChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Image = global::Coiffure.Properties.Resources.hair_clip_24px;
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Image = global::Coiffure.Properties.Resources.expensive_price_24px;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Image = global::Coiffure.Properties.Resources.barber_scissors_24px;
            this.label5.Name = "label5";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Coiffure.Properties.Resources._5;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Reserver
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reserver";
            this.Load += new System.EventHandler(this.Reserver_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_body.ResumeLayout(false);
            this.panel_inside.ResumeLayout(false);
            this.panel_inside.PerformLayout();
            this.panel_right.ResumeLayout(false);
            this.panel_right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.ComboBox cb_type_style;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_prix_total;
        private System.Windows.Forms.TextBox txt_temps;
        private System.Windows.Forms.TextBox txt_style;
        private System.Windows.Forms.TextBox txt_nom_client;
        private System.Windows.Forms.TextBox txt_nom_coiffeur;
        private System.Windows.Forms.TextBox txt_nom_salon;
        private System.Windows.Forms.Label lb_prix_total;
        private System.Windows.Forms.Label lb_temps;
        private System.Windows.Forms.Label lb_style;
        private System.Windows.Forms.Label lb_salon;
        private System.Windows.Forms.Label lb_nom_client;
        private System.Windows.Forms.Label lb_nom_coiffeur;
        private System.Windows.Forms.TextBox txt_prix_panel_right;
        private System.Windows.Forms.TextBox txt_nom_style_panel_right;
        private System.Windows.Forms.Button btn_reserver;
        private System.Windows.Forms.Panel panel_inside;
        private System.Windows.Forms.Label lb_ville;
        private System.Windows.Forms.Label lb_date_header;
        private System.Windows.Forms.Label lb_salon_header;
        private System.Windows.Forms.ComboBox cb_ville;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cb_salon;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Label lb_temps_header;
        private System.Windows.Forms.ComboBox cb_temps;
        private System.Windows.Forms.Panel panel_header;
    }
}