
namespace Coiffure
{
    partial class inscrire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inscrire));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rb_client = new System.Windows.Forms.RadioButton();
            this.rb_coiffeur = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_inscrire = new System.Windows.Forms.Button();
            this.cb_ville = new System.Windows.Forms.ComboBox();
            this.lb_confirmer = new System.Windows.Forms.Label();
            this.lb_ville = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_prenom = new System.Windows.Forms.Label();
            this.lb_nom = new System.Windows.Forms.Label();
            this.txt_confirmer = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.btn_left = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Name = "panel1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Coiffure.Properties.Resources.services_50px;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackgroundImage = global::Coiffure.Properties.Resources.pexels_nick_demou_1319462;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_left);
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rb_client);
            this.panel3.Controls.Add(this.rb_coiffeur);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btn_inscrire);
            this.panel3.Controls.Add(this.cb_ville);
            this.panel3.Controls.Add(this.lb_confirmer);
            this.panel3.Controls.Add(this.lb_ville);
            this.panel3.Controls.Add(this.lb_password);
            this.panel3.Controls.Add(this.lb_email);
            this.panel3.Controls.Add(this.lb_prenom);
            this.panel3.Controls.Add(this.lb_nom);
            this.panel3.Controls.Add(this.txt_confirmer);
            this.panel3.Controls.Add(this.txt_password);
            this.panel3.Controls.Add(this.txt_email);
            this.panel3.Controls.Add(this.txt_prenom);
            this.panel3.Controls.Add(this.txt_nom);
            this.panel3.Name = "panel3";
            // 
            // rb_client
            // 
            resources.ApplyResources(this.rb_client, "rb_client");
            this.rb_client.ForeColor = System.Drawing.Color.SpringGreen;
            this.rb_client.Name = "rb_client";
            this.rb_client.UseVisualStyleBackColor = true;
            this.rb_client.CheckedChanged += new System.EventHandler(this.rb_client_CheckedChanged);
            // 
            // rb_coiffeur
            // 
            resources.ApplyResources(this.rb_coiffeur, "rb_coiffeur");
            this.rb_coiffeur.Checked = true;
            this.rb_coiffeur.ForeColor = System.Drawing.Color.SpringGreen;
            this.rb_coiffeur.Name = "rb_coiffeur";
            this.rb_coiffeur.TabStop = true;
            this.rb_coiffeur.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.SpringGreen;
            this.label4.Name = "label4";
            // 
            // btn_inscrire
            // 
            resources.ApplyResources(this.btn_inscrire, "btn_inscrire");
            this.btn_inscrire.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_inscrire.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_inscrire.Name = "btn_inscrire";
            this.btn_inscrire.UseVisualStyleBackColor = false;
            this.btn_inscrire.Click += new System.EventHandler(this.btn_inscrire_Click);
            // 
            // cb_ville
            // 
            resources.ApplyResources(this.cb_ville, "cb_ville");
            this.cb_ville.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ville.ForeColor = System.Drawing.Color.DarkCyan;
            this.cb_ville.FormattingEnabled = true;
            this.cb_ville.Items.AddRange(new object[] {
            resources.GetString("cb_ville.Items")});
            this.cb_ville.Name = "cb_ville";
            // 
            // lb_confirmer
            // 
            resources.ApplyResources(this.lb_confirmer, "lb_confirmer");
            this.lb_confirmer.ForeColor = System.Drawing.Color.SpringGreen;
            this.lb_confirmer.Name = "lb_confirmer";
            // 
            // lb_ville
            // 
            resources.ApplyResources(this.lb_ville, "lb_ville");
            this.lb_ville.ForeColor = System.Drawing.Color.SpringGreen;
            this.lb_ville.Name = "lb_ville";
            // 
            // lb_password
            // 
            resources.ApplyResources(this.lb_password, "lb_password");
            this.lb_password.ForeColor = System.Drawing.Color.SpringGreen;
            this.lb_password.Name = "lb_password";
            // 
            // lb_email
            // 
            resources.ApplyResources(this.lb_email, "lb_email");
            this.lb_email.ForeColor = System.Drawing.Color.SpringGreen;
            this.lb_email.Name = "lb_email";
            // 
            // lb_prenom
            // 
            resources.ApplyResources(this.lb_prenom, "lb_prenom");
            this.lb_prenom.ForeColor = System.Drawing.Color.SpringGreen;
            this.lb_prenom.Name = "lb_prenom";
            // 
            // lb_nom
            // 
            resources.ApplyResources(this.lb_nom, "lb_nom");
            this.lb_nom.ForeColor = System.Drawing.Color.SpringGreen;
            this.lb_nom.Name = "lb_nom";
            // 
            // txt_confirmer
            // 
            resources.ApplyResources(this.txt_confirmer, "txt_confirmer");
            this.txt_confirmer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirmer.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_confirmer.Name = "txt_confirmer";
            // 
            // txt_password
            // 
            resources.ApplyResources(this.txt_password, "txt_password");
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_password.Name = "txt_password";
            // 
            // txt_email
            // 
            resources.ApplyResources(this.txt_email, "txt_email");
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_email.Name = "txt_email";
            // 
            // txt_prenom
            // 
            resources.ApplyResources(this.txt_prenom, "txt_prenom");
            this.txt_prenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_prenom.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_prenom.Name = "txt_prenom";
            // 
            // txt_nom
            // 
            resources.ApplyResources(this.txt_nom, "txt_nom");
            this.txt_nom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nom.ForeColor = System.Drawing.Color.DarkCyan;
            this.txt_nom.Name = "txt_nom";
            // 
            // btn_left
            // 
            resources.ApplyResources(this.btn_left, "btn_left");
            this.btn_left.BackColor = System.Drawing.Color.DimGray;
            this.btn_left.Image = global::Coiffure.Properties.Resources.left_24px;
            this.btn_left.Name = "btn_left";
            this.btn_left.UseVisualStyleBackColor = false;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // inscrire
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inscrire";
            this.Load += new System.EventHandler(this.inscrire_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_confirmer;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lb_confirmer;
        private System.Windows.Forms.Label lb_ville;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_prenom;
        private System.Windows.Forms.Label lb_nom;
        private System.Windows.Forms.ComboBox cb_ville;
        private System.Windows.Forms.Button btn_inscrire;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rb_client;
        private System.Windows.Forms.RadioButton rb_coiffeur;
        private System.Windows.Forms.Label label4;
    }
}