namespace TP1_Pokemon.View
{
    partial class problemAccessDossierPokemon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_chemin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.b_cheminEnvoyer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Il semblerait qu\'il y est un problème avec l\'accés au dossier contenant le .dat, " +
    "listant les pokémons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veuillez indiquer le bon chemin : ";
            // 
            // tb_chemin
            // 
            this.tb_chemin.Location = new System.Drawing.Point(259, 170);
            this.tb_chemin.Multiline = true;
            this.tb_chemin.Name = "tb_chemin";
            this.tb_chemin.Size = new System.Drawing.Size(519, 57);
            this.tb_chemin.TabIndex = 2;
            this.tb_chemin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(698, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ex : D:\\\\OneDrive - Ynov\\\\Ingesup\\\\2ieme_annee\\\\C_Scharp\\\\TP1_Pokemon\\\\TP1_Pokemo" +
    "n\\\\Model\\\\pokemon";
            // 
            // b_cheminEnvoyer
            // 
            this.b_cheminEnvoyer.Location = new System.Drawing.Point(360, 338);
            this.b_cheminEnvoyer.Name = "b_cheminEnvoyer";
            this.b_cheminEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.b_cheminEnvoyer.TabIndex = 4;
            this.b_cheminEnvoyer.Text = "Envoyer";
            this.b_cheminEnvoyer.UseVisualStyleBackColor = true;
            this.b_cheminEnvoyer.Click += new System.EventHandler(this.b_cheminEnvoyer_Click);
            // 
            // problemAccessDossierPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_cheminEnvoyer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_chemin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "problemAccessDossierPokemon";
            this.Text = "problemAccessDossierPokemon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_chemin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_cheminEnvoyer;
    }
}