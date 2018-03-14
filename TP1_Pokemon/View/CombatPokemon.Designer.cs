namespace TP1_Pokemon.View
{
    partial class CombatPokemon
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
            this.pb_pokeJoueur = new System.Windows.Forms.PictureBox();
            this.pb_pokeAdversaire = new System.Windows.Forms.PictureBox();
            this.label_nompokeJoueur = new System.Windows.Forms.Label();
            this.label_viepokejoueur = new System.Windows.Forms.Label();
            this.pb_viePoke = new System.Windows.Forms.ProgressBar();
            this.pb_vieAdv = new System.Windows.Forms.ProgressBar();
            this.label_viepokeadv = new System.Windows.Forms.Label();
            this.label_nomPokeAdv = new System.Windows.Forms.Label();
            this.label_choixStyleCombat = new System.Windows.Forms.Label();
            this.b_attaquer = new System.Windows.Forms.Button();
            this.b_accesSac = new System.Windows.Forms.Button();
            this.label2_descriptionCombat = new System.Windows.Forms.Label();
            this.b_Atk1 = new System.Windows.Forms.Button();
            this.b_Atk2 = new System.Windows.Forms.Button();
            this.b_Atk3 = new System.Windows.Forms.Button();
            this.b_Atk4 = new System.Windows.Forms.Button();
            this.b_retour = new System.Windows.Forms.Button();
            this.label_descriptionCombat = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pokeJoueur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pokeAdversaire)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_pokeJoueur
            // 
            this.pb_pokeJoueur.Location = new System.Drawing.Point(15, 166);
            this.pb_pokeJoueur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_pokeJoueur.Name = "pb_pokeJoueur";
            this.pb_pokeJoueur.Size = new System.Drawing.Size(352, 329);
            this.pb_pokeJoueur.TabIndex = 0;
            this.pb_pokeJoueur.TabStop = false;
            // 
            // pb_pokeAdversaire
            // 
            this.pb_pokeAdversaire.Location = new System.Drawing.Point(884, 12);
            this.pb_pokeAdversaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_pokeAdversaire.Name = "pb_pokeAdversaire";
            this.pb_pokeAdversaire.Size = new System.Drawing.Size(352, 329);
            this.pb_pokeAdversaire.TabIndex = 1;
            this.pb_pokeAdversaire.TabStop = false;
            // 
            // label_nompokeJoueur
            // 
            this.label_nompokeJoueur.AutoSize = true;
            this.label_nompokeJoueur.Location = new System.Drawing.Point(399, 349);
            this.label_nompokeJoueur.Name = "label_nompokeJoueur";
            this.label_nompokeJoueur.Size = new System.Drawing.Size(120, 20);
            this.label_nompokeJoueur.TabIndex = 2;
            this.label_nompokeJoueur.Text = "nomPojeJoueur";
            // 
            // label_viepokejoueur
            // 
            this.label_viepokejoueur.AutoSize = true;
            this.label_viepokejoueur.Location = new System.Drawing.Point(399, 382);
            this.label_viepokejoueur.Name = "label_viepokejoueur";
            this.label_viepokejoueur.Size = new System.Drawing.Size(75, 20);
            this.label_viepokejoueur.TabIndex = 3;
            this.label_viepokejoueur.Text = "viepokejo";
            // 
            // pb_viePoke
            // 
            this.pb_viePoke.Location = new System.Drawing.Point(403, 418);
            this.pb_viePoke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_viePoke.Name = "pb_viePoke";
            this.pb_viePoke.Size = new System.Drawing.Size(100, 22);
            this.pb_viePoke.TabIndex = 4;
            // 
            // pb_vieAdv
            // 
            this.pb_vieAdv.Location = new System.Drawing.Point(633, 95);
            this.pb_vieAdv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_vieAdv.Name = "pb_vieAdv";
            this.pb_vieAdv.Size = new System.Drawing.Size(100, 22);
            this.pb_vieAdv.TabIndex = 7;
            // 
            // label_viepokeadv
            // 
            this.label_viepokeadv.AutoSize = true;
            this.label_viepokeadv.Location = new System.Drawing.Point(629, 60);
            this.label_viepokeadv.Name = "label_viepokeadv";
            this.label_viepokeadv.Size = new System.Drawing.Size(83, 20);
            this.label_viepokeadv.TabIndex = 6;
            this.label_viepokeadv.Text = "viepokeAd";
            // 
            // label_nomPokeAdv
            // 
            this.label_nomPokeAdv.AutoSize = true;
            this.label_nomPokeAdv.Location = new System.Drawing.Point(629, 28);
            this.label_nomPokeAdv.Name = "label_nomPokeAdv";
            this.label_nomPokeAdv.Size = new System.Drawing.Size(151, 20);
            this.label_nomPokeAdv.TabIndex = 5;
            this.label_nomPokeAdv.Text = "nomPokeAdversaire";
            this.label_nomPokeAdv.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_choixStyleCombat
            // 
            this.label_choixStyleCombat.AutoSize = true;
            this.label_choixStyleCombat.Location = new System.Drawing.Point(2, 578);
            this.label_choixStyleCombat.Name = "label_choixStyleCombat";
            this.label_choixStyleCombat.Size = new System.Drawing.Size(88, 20);
            this.label_choixStyleCombat.TabIndex = 8;
            this.label_choixStyleCombat.Text = "Votre choix";
            // 
            // b_attaquer
            // 
            this.b_attaquer.Location = new System.Drawing.Point(6, 601);
            this.b_attaquer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_attaquer.Name = "b_attaquer";
            this.b_attaquer.Size = new System.Drawing.Size(88, 30);
            this.b_attaquer.TabIndex = 9;
            this.b_attaquer.Text = "Attaquer";
            this.b_attaquer.UseVisualStyleBackColor = true;
            this.b_attaquer.Click += new System.EventHandler(this.b_attaquer_Click);
            // 
            // b_accesSac
            // 
            this.b_accesSac.Location = new System.Drawing.Point(123, 601);
            this.b_accesSac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_accesSac.Name = "b_accesSac";
            this.b_accesSac.Size = new System.Drawing.Size(101, 30);
            this.b_accesSac.TabIndex = 10;
            this.b_accesSac.Text = "Sac";
            this.b_accesSac.UseVisualStyleBackColor = true;
            this.b_accesSac.Click += new System.EventHandler(this.b_accesSac_Click);
            // 
            // label2_descriptionCombat
            // 
            this.label2_descriptionCombat.AutoSize = true;
            this.label2_descriptionCombat.Location = new System.Drawing.Point(636, 545);
            this.label2_descriptionCombat.Name = "label2_descriptionCombat";
            this.label2_descriptionCombat.Size = new System.Drawing.Size(0, 20);
            this.label2_descriptionCombat.TabIndex = 11;
            this.label2_descriptionCombat.Click += new System.EventHandler(this.label_descriptionCombat_Click);
            // 
            // b_Atk1
            // 
            this.b_Atk1.Location = new System.Drawing.Point(22, 611);
            this.b_Atk1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_Atk1.Name = "b_Atk1";
            this.b_Atk1.Size = new System.Drawing.Size(122, 59);
            this.b_Atk1.TabIndex = 12;
            this.b_Atk1.Text = "Attaque 1";
            this.b_Atk1.UseVisualStyleBackColor = true;
            this.b_Atk1.Click += new System.EventHandler(this.b_Atk1_Click);
            // 
            // b_Atk2
            // 
            this.b_Atk2.Location = new System.Drawing.Point(151, 611);
            this.b_Atk2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_Atk2.Name = "b_Atk2";
            this.b_Atk2.Size = new System.Drawing.Size(119, 59);
            this.b_Atk2.TabIndex = 13;
            this.b_Atk2.Text = "Attaque 2";
            this.b_Atk2.UseVisualStyleBackColor = true;
            this.b_Atk2.Click += new System.EventHandler(this.b_Atk2_Click);
            // 
            // b_Atk3
            // 
            this.b_Atk3.Location = new System.Drawing.Point(277, 611);
            this.b_Atk3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_Atk3.Name = "b_Atk3";
            this.b_Atk3.Size = new System.Drawing.Size(125, 59);
            this.b_Atk3.TabIndex = 14;
            this.b_Atk3.Text = "Attaque 3";
            this.b_Atk3.UseVisualStyleBackColor = true;
            this.b_Atk3.Click += new System.EventHandler(this.b_Atk3_Click);
            // 
            // b_Atk4
            // 
            this.b_Atk4.Location = new System.Drawing.Point(408, 611);
            this.b_Atk4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_Atk4.Name = "b_Atk4";
            this.b_Atk4.Size = new System.Drawing.Size(120, 59);
            this.b_Atk4.TabIndex = 15;
            this.b_Atk4.Tag = "4";
            this.b_Atk4.Text = "Attaque 4";
            this.b_Atk4.UseVisualStyleBackColor = true;
            this.b_Atk4.Click += new System.EventHandler(this.b_Atk4_Click);
            // 
            // b_retour
            // 
            this.b_retour.Location = new System.Drawing.Point(536, 618);
            this.b_retour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_retour.Name = "b_retour";
            this.b_retour.Size = new System.Drawing.Size(111, 45);
            this.b_retour.TabIndex = 16;
            this.b_retour.Text = "Retour";
            this.b_retour.UseVisualStyleBackColor = true;
            this.b_retour.Click += new System.EventHandler(this.b_retour_Click);
            // 
            // label_descriptionCombat
            // 
            this.label_descriptionCombat.Location = new System.Drawing.Point(734, 460);
            this.label_descriptionCombat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_descriptionCombat.Name = "label_descriptionCombat";
            this.label_descriptionCombat.Size = new System.Drawing.Size(502, 258);
            this.label_descriptionCombat.TabIndex = 17;
            this.label_descriptionCombat.Text = "";
            this.label_descriptionCombat.TextChanged += new System.EventHandler(this.label_descriptionCombat_TextChanged);
            // 
            // CombatPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 734);
            this.Controls.Add(this.label_descriptionCombat);
            this.Controls.Add(this.b_retour);
            this.Controls.Add(this.b_Atk4);
            this.Controls.Add(this.b_Atk3);
            this.Controls.Add(this.b_Atk2);
            this.Controls.Add(this.b_Atk1);
            this.Controls.Add(this.label2_descriptionCombat);
            this.Controls.Add(this.b_accesSac);
            this.Controls.Add(this.b_attaquer);
            this.Controls.Add(this.label_choixStyleCombat);
            this.Controls.Add(this.pb_vieAdv);
            this.Controls.Add(this.label_viepokeadv);
            this.Controls.Add(this.label_nomPokeAdv);
            this.Controls.Add(this.pb_viePoke);
            this.Controls.Add(this.label_viepokejoueur);
            this.Controls.Add(this.label_nompokeJoueur);
            this.Controls.Add(this.pb_pokeAdversaire);
            this.Controls.Add(this.pb_pokeJoueur);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CombatPokemon";
            this.Text = "Combat";
            ((System.ComponentModel.ISupportInitialize)(this.pb_pokeJoueur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pokeAdversaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_pokeJoueur;
        private System.Windows.Forms.PictureBox pb_pokeAdversaire;
        private System.Windows.Forms.Label label_nompokeJoueur;
        private System.Windows.Forms.Label label_viepokejoueur;
        private System.Windows.Forms.ProgressBar pb_viePoke;
        private System.Windows.Forms.ProgressBar pb_vieAdv;
        private System.Windows.Forms.Label label_viepokeadv;
        private System.Windows.Forms.Label label_nomPokeAdv;
        private System.Windows.Forms.Label label_choixStyleCombat;
        private System.Windows.Forms.Button b_attaquer;
        private System.Windows.Forms.Button b_accesSac;
        private System.Windows.Forms.Label label2_descriptionCombat;
        private System.Windows.Forms.Button b_Atk1;
        private System.Windows.Forms.Button b_Atk2;
        private System.Windows.Forms.Button b_Atk3;
        private System.Windows.Forms.Button b_Atk4;
        private System.Windows.Forms.Button b_retour;
        private System.Windows.Forms.RichTextBox label_descriptionCombat;
    }
}