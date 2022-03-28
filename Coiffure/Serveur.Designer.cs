namespace Coiffure
{
    partial class Serveur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Serveur));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_connecter = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_utilisateur = new System.Windows.Forms.TextBox();
            this.txt_nom_server = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.btn_connecter);
            this.panel2.Controls.Add(this.txt_password);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_utilisateur);
            this.panel2.Controls.Add(this.txt_nom_server);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Name = "panel2";
            // 
            // btn_connecter
            // 
            resources.ApplyResources(this.btn_connecter, "btn_connecter");
            this.btn_connecter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_connecter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_connecter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_connecter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_connecter.Name = "btn_connecter";
            this.btn_connecter.UseVisualStyleBackColor = true;
            this.btn_connecter.Click += new System.EventHandler(this.btn_connecter_Click);
            // 
            // txt_password
            // 
            resources.ApplyResources(this.txt_password, "txt_password");
            this.txt_password.ForeColor = System.Drawing.Color.DimGray;
            this.txt_password.Name = "txt_password";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Name = "label3";
            // 
            // txt_utilisateur
            // 
            resources.ApplyResources(this.txt_utilisateur, "txt_utilisateur");
            this.txt_utilisateur.ForeColor = System.Drawing.Color.DimGray;
            this.txt_utilisateur.Name = "txt_utilisateur";
            // 
            // txt_nom_server
            // 
            resources.ApplyResources(this.txt_nom_server, "txt_nom_server");
            this.txt_nom_server.ForeColor = System.Drawing.Color.DimGray;
            this.txt_nom_server.Name = "txt_nom_server";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Name = "panel3";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Serveur
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coiffure.Properties.Resources.pexels_panumas_nikhomkhai_1148820__1_3;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Serveur";
            this.Load += new System.EventHandler(this.Serveur_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_connecter;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_utilisateur;
        private System.Windows.Forms.TextBox txt_nom_server;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}