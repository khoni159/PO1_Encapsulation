namespace PO1_Encapsulation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_joueur = new System.Windows.Forms.GroupBox();
            this.gb_dragon = new System.Windows.Forms.GroupBox();
            this.lbl_pointsVieJoueur = new System.Windows.Forms.Label();
            this.lbl_puissanceAttaqueJoueur = new System.Windows.Forms.Label();
            this.lbl_pointsVieDragon = new System.Windows.Forms.Label();
            this.lbl_puissanceAttaqueDragon = new System.Windows.Forms.Label();
            this.btn_attaquer = new System.Windows.Forms.Button();
            this.btn_seSoigner = new System.Windows.Forms.Button();
            this.btn_puissanceAttaque = new System.Windows.Forms.Button();
            this.gb_joueur.SuspendLayout();
            this.gb_dragon.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_joueur
            // 
            this.gb_joueur.Controls.Add(this.lbl_puissanceAttaqueJoueur);
            this.gb_joueur.Controls.Add(this.lbl_pointsVieJoueur);
            this.gb_joueur.Location = new System.Drawing.Point(12, 12);
            this.gb_joueur.Name = "gb_joueur";
            this.gb_joueur.Size = new System.Drawing.Size(207, 159);
            this.gb_joueur.TabIndex = 0;
            this.gb_joueur.TabStop = false;
            this.gb_joueur.Text = "Joueur";
            // 
            // gb_dragon
            // 
            this.gb_dragon.Controls.Add(this.lbl_puissanceAttaqueDragon);
            this.gb_dragon.Controls.Add(this.lbl_pointsVieDragon);
            this.gb_dragon.Location = new System.Drawing.Point(225, 12);
            this.gb_dragon.Name = "gb_dragon";
            this.gb_dragon.Size = new System.Drawing.Size(207, 159);
            this.gb_dragon.TabIndex = 1;
            this.gb_dragon.TabStop = false;
            this.gb_dragon.Text = "Dragon";
            // 
            // lbl_pointsVieJoueur
            // 
            this.lbl_pointsVieJoueur.AutoSize = true;
            this.lbl_pointsVieJoueur.Location = new System.Drawing.Point(6, 36);
            this.lbl_pointsVieJoueur.Name = "lbl_pointsVieJoueur";
            this.lbl_pointsVieJoueur.Size = new System.Drawing.Size(99, 20);
            this.lbl_pointsVieJoueur.TabIndex = 2;
            this.lbl_pointsVieJoueur.Text = "Points de vie :";
            // 
            // lbl_puissanceAttaqueJoueur
            // 
            this.lbl_puissanceAttaqueJoueur.AutoSize = true;
            this.lbl_puissanceAttaqueJoueur.Location = new System.Drawing.Point(6, 77);
            this.lbl_puissanceAttaqueJoueur.Name = "lbl_puissanceAttaqueJoueur";
            this.lbl_puissanceAttaqueJoueur.Size = new System.Drawing.Size(146, 20);
            this.lbl_puissanceAttaqueJoueur.TabIndex = 3;
            this.lbl_puissanceAttaqueJoueur.Text = "Puissance d\'attaque :";
            // 
            // lbl_pointsVieDragon
            // 
            this.lbl_pointsVieDragon.AutoSize = true;
            this.lbl_pointsVieDragon.Location = new System.Drawing.Point(6, 36);
            this.lbl_pointsVieDragon.Name = "lbl_pointsVieDragon";
            this.lbl_pointsVieDragon.Size = new System.Drawing.Size(99, 20);
            this.lbl_pointsVieDragon.TabIndex = 4;
            this.lbl_pointsVieDragon.Text = "Points de vie :";
            // 
            // lbl_puissanceAttaqueDragon
            // 
            this.lbl_puissanceAttaqueDragon.AutoSize = true;
            this.lbl_puissanceAttaqueDragon.Location = new System.Drawing.Point(6, 77);
            this.lbl_puissanceAttaqueDragon.Name = "lbl_puissanceAttaqueDragon";
            this.lbl_puissanceAttaqueDragon.Size = new System.Drawing.Size(146, 20);
            this.lbl_puissanceAttaqueDragon.TabIndex = 5;
            this.lbl_puissanceAttaqueDragon.Text = "Puissance d\'attaque :";
            // 
            // btn_attaquer
            // 
            this.btn_attaquer.Location = new System.Drawing.Point(12, 177);
            this.btn_attaquer.Name = "btn_attaquer";
            this.btn_attaquer.Size = new System.Drawing.Size(235, 33);
            this.btn_attaquer.TabIndex = 2;
            this.btn_attaquer.Text = "Attaquer";
            this.btn_attaquer.UseVisualStyleBackColor = true;
            this.btn_attaquer.Click += new System.EventHandler(this.btn_attaquer_Click);
            // 
            // btn_seSoigner
            // 
            this.btn_seSoigner.Location = new System.Drawing.Point(12, 216);
            this.btn_seSoigner.Name = "btn_seSoigner";
            this.btn_seSoigner.Size = new System.Drawing.Size(235, 33);
            this.btn_seSoigner.TabIndex = 3;
            this.btn_seSoigner.Text = "Se soigner";
            this.btn_seSoigner.UseVisualStyleBackColor = true;
            this.btn_seSoigner.Click += new System.EventHandler(this.btn_seSoigner_Click);
            // 
            // btn_puissanceAttaque
            // 
            this.btn_puissanceAttaque.Location = new System.Drawing.Point(12, 255);
            this.btn_puissanceAttaque.Name = "btn_puissanceAttaque";
            this.btn_puissanceAttaque.Size = new System.Drawing.Size(235, 33);
            this.btn_puissanceAttaque.TabIndex = 4;
            this.btn_puissanceAttaque.Text = "Boire une potion de puissance";
            this.btn_puissanceAttaque.UseVisualStyleBackColor = true;
            this.btn_puissanceAttaque.Click += new System.EventHandler(this.btn_puissanceAttaque_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 300);
            this.Controls.Add(this.btn_puissanceAttaque);
            this.Controls.Add(this.btn_seSoigner);
            this.Controls.Add(this.btn_attaquer);
            this.Controls.Add(this.gb_dragon);
            this.Controls.Add(this.gb_joueur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_joueur.ResumeLayout(false);
            this.gb_joueur.PerformLayout();
            this.gb_dragon.ResumeLayout(false);
            this.gb_dragon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gb_joueur;
        private Label lbl_puissanceAttaqueJoueur;
        private Label lbl_pointsVieJoueur;
        private GroupBox gb_dragon;
        private Label lbl_puissanceAttaqueDragon;
        private Label lbl_pointsVieDragon;
        private Button btn_attaquer;
        private Button btn_seSoigner;
        private Button btn_puissanceAttaque;
    }
}