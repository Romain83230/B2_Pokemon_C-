namespace TP1_Pokemon
{
    partial class PokemonVersionRouge
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
            this.Choisir = new System.Windows.Forms.Label();
            this.pokeBox = new System.Windows.Forms.PictureBox();
            this.b_next = new System.Windows.Forms.Button();
            this.b_previous = new System.Windows.Forms.Button();
            this.label_pokemon_stats = new System.Windows.Forms.Label();
            this.pb_votrechoixpoke = new System.Windows.Forms.PictureBox();
            this.pb_choixpokeadversaire = new System.Windows.Forms.PictureBox();
            this.Description_poke_joueur = new System.Windows.Forms.Label();
            this.Description_poke_adversaire = new System.Windows.Forms.Label();
            this.b_combat = new System.Windows.Forms.Button();
            this.label_votrepoke = new System.Windows.Forms.Label();
            this.label_adversairePoke = new System.Windows.Forms.Label();
            this.label_VS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pokeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_votrechoixpoke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_choixpokeadversaire)).BeginInit();
            this.SuspendLayout();
            // 
            // Choisir
            // 
            this.Choisir.AutoSize = true;
            this.Choisir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choisir.Location = new System.Drawing.Point(272, 30);
            this.Choisir.Name = "Choisir";
            this.Choisir.Size = new System.Drawing.Size(719, 37);
            this.Choisir.TabIndex = 0;
            this.Choisir.Text = "Choississez votre pokemon en cliquant dessus :) ";
            // 
            // pokeBox
            // 
            this.pokeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pokeBox.Location = new System.Drawing.Point(263, 127);
            this.pokeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pokeBox.Name = "pokeBox";
            this.pokeBox.Size = new System.Drawing.Size(394, 375);
            this.pokeBox.TabIndex = 1;
            this.pokeBox.TabStop = false;
            this.pokeBox.Click += new System.EventHandler(this.pokeBox_Click);
            // 
            // b_next
            // 
            this.b_next.Location = new System.Drawing.Point(611, 544);
            this.b_next.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b_next.Name = "b_next";
            this.b_next.Size = new System.Drawing.Size(84, 29);
            this.b_next.TabIndex = 2;
            this.b_next.Text = "Suivant";
            this.b_next.UseVisualStyleBackColor = true;
            this.b_next.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_previous
            // 
            this.b_previous.Location = new System.Drawing.Point(217, 544);
            this.b_previous.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b_previous.Name = "b_previous";
            this.b_previous.Size = new System.Drawing.Size(109, 29);
            this.b_previous.TabIndex = 3;
            this.b_previous.Text = "Precédent";
            this.b_previous.UseVisualStyleBackColor = true;
            this.b_previous.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_pokemon_stats
            // 
            this.label_pokemon_stats.AutoSize = true;
            this.label_pokemon_stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pokemon_stats.Location = new System.Drawing.Point(844, 170);
            this.label_pokemon_stats.Name = "label_pokemon_stats";
            this.label_pokemon_stats.Size = new System.Drawing.Size(0, 20);
            this.label_pokemon_stats.TabIndex = 4;
            this.label_pokemon_stats.Click += new System.EventHandler(this.label_pokemon_stats_Click);
            // 
            // pb_votrechoixpoke
            // 
            this.pb_votrechoixpoke.Location = new System.Drawing.Point(119, 118);
            this.pb_votrechoixpoke.Name = "pb_votrechoixpoke";
            this.pb_votrechoixpoke.Size = new System.Drawing.Size(404, 410);
            this.pb_votrechoixpoke.TabIndex = 5;
            this.pb_votrechoixpoke.TabStop = false;
            // 
            // pb_choixpokeadversaire
            // 
            this.pb_choixpokeadversaire.Location = new System.Drawing.Point(698, 118);
            this.pb_choixpokeadversaire.Name = "pb_choixpokeadversaire";
            this.pb_choixpokeadversaire.Size = new System.Drawing.Size(404, 410);
            this.pb_choixpokeadversaire.TabIndex = 6;
            this.pb_choixpokeadversaire.TabStop = false;
            this.pb_choixpokeadversaire.Click += new System.EventHandler(this.pb_choixpokeadversaire_Click);
            // 
            // Description_poke_joueur
            // 
            this.Description_poke_joueur.AutoSize = true;
            this.Description_poke_joueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_poke_joueur.Location = new System.Drawing.Point(213, 544);
            this.Description_poke_joueur.Name = "Description_poke_joueur";
            this.Description_poke_joueur.Size = new System.Drawing.Size(57, 20);
            this.Description_poke_joueur.TabIndex = 7;
            this.Description_poke_joueur.Text = "label1";
            // 
            // Description_poke_adversaire
            // 
            this.Description_poke_adversaire.AutoSize = true;
            this.Description_poke_adversaire.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Description_poke_adversaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_poke_adversaire.Location = new System.Drawing.Point(844, 544);
            this.Description_poke_adversaire.Name = "Description_poke_adversaire";
            this.Description_poke_adversaire.Size = new System.Drawing.Size(57, 20);
            this.Description_poke_adversaire.TabIndex = 8;
            this.Description_poke_adversaire.Text = "label1";
            this.Description_poke_adversaire.Click += new System.EventHandler(this.Description_poke_adversaire_Click);
            // 
            // b_combat
            // 
            this.b_combat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_combat.Location = new System.Drawing.Point(528, 678);
            this.b_combat.Name = "b_combat";
            this.b_combat.Size = new System.Drawing.Size(164, 44);
            this.b_combat.TabIndex = 9;
            this.b_combat.Text = "COMBAT";
            this.b_combat.UseVisualStyleBackColor = true;
            this.b_combat.Click += new System.EventHandler(this.b_combat_Click);
            // 
            // label_votrepoke
            // 
            this.label_votrepoke.AutoSize = true;
            this.label_votrepoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_votrepoke.Location = new System.Drawing.Point(223, 83);
            this.label_votrepoke.Name = "label_votrepoke";
            this.label_votrepoke.Size = new System.Drawing.Size(207, 32);
            this.label_votrepoke.TabIndex = 10;
            this.label_votrepoke.Text = "Votre pokemon";
            // 
            // label_adversairePoke
            // 
            this.label_adversairePoke.AutoSize = true;
            this.label_adversairePoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adversairePoke.Location = new System.Drawing.Point(769, 83);
            this.label_adversairePoke.Name = "label_adversairePoke";
            this.label_adversairePoke.Size = new System.Drawing.Size(278, 32);
            this.label_adversairePoke.TabIndex = 11;
            this.label_adversairePoke.Text = "Pokemon Adversaire";
            // 
            // label_VS
            // 
            this.label_VS.AutoSize = true;
            this.label_VS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_VS.Location = new System.Drawing.Point(586, 300);
            this.label_VS.Name = "label_VS";
            this.label_VS.Size = new System.Drawing.Size(78, 40);
            this.label_VS.TabIndex = 12;
            this.label_VS.Text = "V.S";
            // 
            // PokemonVersionRouge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 781);
            this.Controls.Add(this.label_VS);
            this.Controls.Add(this.label_adversairePoke);
            this.Controls.Add(this.label_votrepoke);
            this.Controls.Add(this.b_combat);
            this.Controls.Add(this.Description_poke_adversaire);
            this.Controls.Add(this.Description_poke_joueur);
            this.Controls.Add(this.pb_choixpokeadversaire);
            this.Controls.Add(this.pb_votrechoixpoke);
            this.Controls.Add(this.label_pokemon_stats);
            this.Controls.Add(this.b_previous);
            this.Controls.Add(this.b_next);
            this.Controls.Add(this.pokeBox);
            this.Controls.Add(this.Choisir);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PokemonVersionRouge";
            this.Text = "PokemonVersionRouge";
            this.Load += new System.EventHandler(this.PokemonVersionRouge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pokeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_votrechoixpoke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_choixpokeadversaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Choisir;
        private System.Windows.Forms.PictureBox pokeBox;
        private System.Windows.Forms.Button b_next;
        private System.Windows.Forms.Button b_previous;
        private System.Windows.Forms.Label label_pokemon_stats;
        private System.Windows.Forms.PictureBox pb_votrechoixpoke;
        private System.Windows.Forms.PictureBox pb_choixpokeadversaire;
        private System.Windows.Forms.Label Description_poke_joueur;
        private System.Windows.Forms.Label Description_poke_adversaire;
        private System.Windows.Forms.Button b_combat;
        private System.Windows.Forms.Label label_votrepoke;
        private System.Windows.Forms.Label label_adversairePoke;
        private System.Windows.Forms.Label label_VS;
    }
}