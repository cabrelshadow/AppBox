﻿namespace AppBoxManagement.Views
{
    partial class Formisseur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.IdFournisseur = new System.Windows.Forms.TextBox();
            this.AjouterForniseur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.NomProduit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdressFournisseur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NomProduitLivre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QuantiterProduit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TelePhoneFornisseur = new System.Windows.Forms.MaskedTextBox();
            this.ModifierFournisseurs = new System.Windows.Forms.Button();
            this.SupprimerFournisseur = new System.Windows.Forms.Button();
            this.Imprimer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridFournisseur = new Guna.UI.WinForms.GunaDataGridView();
            this.PrintPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFournisseur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(321, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un fornisseur";
            // 
            // IdFournisseur
            // 
            this.IdFournisseur.Location = new System.Drawing.Point(150, 160);
            this.IdFournisseur.Multiline = true;
            this.IdFournisseur.Name = "IdFournisseur";
            this.IdFournisseur.Size = new System.Drawing.Size(196, 29);
            this.IdFournisseur.TabIndex = 1;
            // 
            // AjouterForniseur
            // 
            this.AjouterForniseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.AjouterForniseur.FlatAppearance.BorderSize = 0;
            this.AjouterForniseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjouterForniseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterForniseur.ForeColor = System.Drawing.Color.White;
            this.AjouterForniseur.Location = new System.Drawing.Point(116, 260);
            this.AjouterForniseur.Name = "AjouterForniseur";
            this.AjouterForniseur.Size = new System.Drawing.Size(169, 40);
            this.AjouterForniseur.TabIndex = 2;
            this.AjouterForniseur.Text = "Ajouter";
            this.AjouterForniseur.UseVisualStyleBackColor = false;
            this.AjouterForniseur.Click += new System.EventHandler(this.AjouterForniseur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id Fournisseur";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.Location = new System.Drawing.Point(147, 193);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(44, 18);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom";
            // 
            // NomProduit
            // 
            this.NomProduit.Location = new System.Drawing.Point(150, 214);
            this.NomProduit.Multiline = true;
            this.NomProduit.Name = "NomProduit";
            this.NomProduit.Size = new System.Drawing.Size(196, 29);
            this.NomProduit.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adresse";
            // 
            // AdressFournisseur
            // 
            this.AdressFournisseur.Location = new System.Drawing.Point(373, 160);
            this.AdressFournisseur.Multiline = true;
            this.AdressFournisseur.Name = "AdressFournisseur";
            this.AdressFournisseur.Size = new System.Drawing.Size(196, 29);
            this.AdressFournisseur.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telephone";
            // 
            // NomProduitLivre
            // 
            this.NomProduitLivre.Location = new System.Drawing.Point(584, 160);
            this.NomProduitLivre.Multiline = true;
            this.NomProduitLivre.Name = "NomProduitLivre";
            this.NomProduitLivre.Size = new System.Drawing.Size(205, 29);
            this.NomProduitLivre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(581, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom produit Livrer";
            // 
            // QuantiterProduit
            // 
            this.QuantiterProduit.Location = new System.Drawing.Point(584, 214);
            this.QuantiterProduit.Multiline = true;
            this.QuantiterProduit.Name = "QuantiterProduit";
            this.QuantiterProduit.Size = new System.Drawing.Size(205, 29);
            this.QuantiterProduit.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(581, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quantité";
            // 
            // TelePhoneFornisseur
            // 
            this.TelePhoneFornisseur.Location = new System.Drawing.Point(373, 223);
            this.TelePhoneFornisseur.Name = "TelePhoneFornisseur";
            this.TelePhoneFornisseur.Size = new System.Drawing.Size(171, 20);
            this.TelePhoneFornisseur.TabIndex = 3;
            // 
            // ModifierFournisseurs
            // 
            this.ModifierFournisseurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.ModifierFournisseurs.FlatAppearance.BorderSize = 0;
            this.ModifierFournisseurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifierFournisseurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierFournisseurs.ForeColor = System.Drawing.Color.White;
            this.ModifierFournisseurs.Location = new System.Drawing.Point(309, 260);
            this.ModifierFournisseurs.Name = "ModifierFournisseurs";
            this.ModifierFournisseurs.Size = new System.Drawing.Size(169, 40);
            this.ModifierFournisseurs.TabIndex = 2;
            this.ModifierFournisseurs.Text = "Modifier";
            this.ModifierFournisseurs.UseVisualStyleBackColor = false;
            this.ModifierFournisseurs.Click += new System.EventHandler(this.ModifierFournisseurs_Click);
            // 
            // SupprimerFournisseur
            // 
            this.SupprimerFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.SupprimerFournisseur.FlatAppearance.BorderSize = 0;
            this.SupprimerFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupprimerFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerFournisseur.ForeColor = System.Drawing.Color.White;
            this.SupprimerFournisseur.Location = new System.Drawing.Point(496, 260);
            this.SupprimerFournisseur.Name = "SupprimerFournisseur";
            this.SupprimerFournisseur.Size = new System.Drawing.Size(169, 40);
            this.SupprimerFournisseur.TabIndex = 2;
            this.SupprimerFournisseur.Text = "Supprimer";
            this.SupprimerFournisseur.UseVisualStyleBackColor = false;
            this.SupprimerFournisseur.Click += new System.EventHandler(this.SupprimerFournisseur_Click);
            // 
            // Imprimer
            // 
            this.Imprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.Imprimer.FlatAppearance.BorderSize = 0;
            this.Imprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Imprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimer.ForeColor = System.Drawing.SystemColors.Window;
            this.Imprimer.Location = new System.Drawing.Point(688, 260);
            this.Imprimer.Name = "Imprimer";
            this.Imprimer.Size = new System.Drawing.Size(169, 40);
            this.Imprimer.TabIndex = 2;
            this.Imprimer.Text = "Imprimer";
            this.Imprimer.UseVisualStyleBackColor = false;
            this.Imprimer.Click += new System.EventHandler(this.Imprimer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(92, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 4);
            this.panel1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(403, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Liste des fournisseurs";
            // 
            // dataGridFournisseur
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridFournisseur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridFournisseur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFournisseur.BackgroundColor = System.Drawing.Color.White;
            this.dataGridFournisseur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFournisseur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridFournisseur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFournisseur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridFournisseur.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(184)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridFournisseur.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridFournisseur.EnableHeadersVisualStyles = false;
            this.dataGridFournisseur.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridFournisseur.Location = new System.Drawing.Point(92, 401);
            this.dataGridFournisseur.Name = "dataGridFournisseur";
            this.dataGridFournisseur.ReadOnly = true;
            this.dataGridFournisseur.RowHeadersVisible = false;
            this.dataGridFournisseur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFournisseur.Size = new System.Drawing.Size(765, 281);
            this.dataGridFournisseur.TabIndex = 7;
            this.dataGridFournisseur.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataGridFournisseur.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridFournisseur.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridFournisseur.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridFournisseur.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridFournisseur.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridFournisseur.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridFournisseur.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridFournisseur.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.dataGridFournisseur.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridFournisseur.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridFournisseur.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridFournisseur.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridFournisseur.ThemeStyle.HeaderStyle.Height = 20;
            this.dataGridFournisseur.ThemeStyle.ReadOnly = true;
            this.dataGridFournisseur.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridFournisseur.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridFournisseur.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridFournisseur.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridFournisseur.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridFournisseur.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(184)))), ((int)(((byte)(230)))));
            this.dataGridFournisseur.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridFournisseur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFournisseur_CellContentClick);
            // 
            // PrintPdf
            // 
            this.PrintPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.PrintPdf.FlatAppearance.BorderSize = 0;
            this.PrintPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPdf.ForeColor = System.Drawing.SystemColors.Window;
            this.PrintPdf.Location = new System.Drawing.Point(708, 352);
            this.PrintPdf.Name = "PrintPdf";
            this.PrintPdf.Size = new System.Drawing.Size(149, 43);
            this.PrintPdf.TabIndex = 2;
            this.PrintPdf.Text = "sauvegarder en pfd";
            this.PrintPdf.UseVisualStyleBackColor = false;
            this.PrintPdf.Click += new System.EventHandler(this.PrintPdf_Click);
            // 
            // Formisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 694);
            this.Controls.Add(this.dataGridFournisseur);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TelePhoneFornisseur);
            this.Controls.Add(this.PrintPdf);
            this.Controls.Add(this.Imprimer);
            this.Controls.Add(this.SupprimerFournisseur);
            this.Controls.Add(this.ModifierFournisseurs);
            this.Controls.Add(this.AjouterForniseur);
            this.Controls.Add(this.NomProduit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.AdressFournisseur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuantiterProduit);
            this.Controls.Add(this.NomProduitLivre);
            this.Controls.Add(this.IdFournisseur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formisseur";
            this.Text = "Formisseur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Formisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFournisseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdFournisseur;
        private System.Windows.Forms.Button AjouterForniseur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox NomProduit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdressFournisseur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NomProduitLivre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QuantiterProduit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TelePhoneFornisseur;
        private System.Windows.Forms.Button ModifierFournisseurs;
        private System.Windows.Forms.Button SupprimerFournisseur;
        private System.Windows.Forms.Button Imprimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaDataGridView dataGridFournisseur;
        private System.Windows.Forms.Button PrintPdf;
    }
}