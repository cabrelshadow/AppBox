namespace AppBoxManagement.Views
{
    partial class StockProduits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockProduits));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.NomProduit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CategorieProuits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DateExpiration = new System.Windows.Forms.DateTimePicker();
            this.RechercheFoirnisseur = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SupprimerFournisseur = new System.Windows.Forms.Button();
            this.ModifierProduit = new System.Windows.Forms.Button();
            this.AjouterProduit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.PrixProduit = new System.Windows.Forms.TextBox();
            this.IdProduit = new System.Windows.Forms.TextBox();
            this.DataGridview = new Guna.UI.WinForms.GunaDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Imprimer = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.QuantiteProduit = new System.Windows.Forms.NumericUpDown();
            this.TotalProduit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantiteProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(389, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter les produits ";
            // 
            // NomProduit
            // 
            this.NomProduit.Location = new System.Drawing.Point(151, 146);
            this.NomProduit.Multiline = true;
            this.NomProduit.Name = "NomProduit";
            this.NomProduit.Size = new System.Drawing.Size(193, 21);
            this.NomProduit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(148, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom du produit";
            // 
            // CategorieProuits
            // 
            this.CategorieProuits.FormattingEnabled = true;
            this.CategorieProuits.Location = new System.Drawing.Point(598, 143);
            this.CategorieProuits.Name = "CategorieProuits";
            this.CategorieProuits.Size = new System.Drawing.Size(193, 21);
            this.CategorieProuits.TabIndex = 3;
            this.CategorieProuits.SelectedIndexChanged += new System.EventHandler(this.CategorieProuits_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(595, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "categorie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(148, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "quantité du produit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(384, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Prix produit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(384, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "data d\'expiration produit";
            // 
            // DateExpiration
            // 
            this.DateExpiration.Location = new System.Drawing.Point(387, 199);
            this.DateExpiration.Name = "DateExpiration";
            this.DateExpiration.Size = new System.Drawing.Size(193, 20);
            this.DateExpiration.TabIndex = 5;
            // 
            // RechercheFoirnisseur
            // 
            this.RechercheFoirnisseur.Location = new System.Drawing.Point(92, 377);
            this.RechercheFoirnisseur.Multiline = true;
            this.RechercheFoirnisseur.Name = "RechercheFoirnisseur";
            this.RechercheFoirnisseur.Size = new System.Drawing.Size(304, 26);
            this.RechercheFoirnisseur.TabIndex = 18;
            this.RechercheFoirnisseur.TextChanged += new System.EventHandler(this.RechercheFoirnisseur_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(62, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 4);
            this.panel1.TabIndex = 14;
            // 
            // SupprimerFournisseur
            // 
            this.SupprimerFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.SupprimerFournisseur.FlatAppearance.BorderSize = 0;
            this.SupprimerFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupprimerFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerFournisseur.ForeColor = System.Drawing.Color.White;
            this.SupprimerFournisseur.Image = ((System.Drawing.Image)(resources.GetObject("SupprimerFournisseur.Image")));
            this.SupprimerFournisseur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SupprimerFournisseur.Location = new System.Drawing.Point(557, 278);
            this.SupprimerFournisseur.Name = "SupprimerFournisseur";
            this.SupprimerFournisseur.Size = new System.Drawing.Size(182, 40);
            this.SupprimerFournisseur.TabIndex = 17;
            this.SupprimerFournisseur.Text = "Supprimer";
            this.SupprimerFournisseur.UseVisualStyleBackColor = false;
            this.SupprimerFournisseur.Click += new System.EventHandler(this.SupprimerFournisseur_Click);
            // 
            // ModifierProduit
            // 
            this.ModifierProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.ModifierProduit.FlatAppearance.BorderSize = 0;
            this.ModifierProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifierProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierProduit.ForeColor = System.Drawing.Color.White;
            this.ModifierProduit.Image = ((System.Drawing.Image)(resources.GetObject("ModifierProduit.Image")));
            this.ModifierProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModifierProduit.Location = new System.Drawing.Point(359, 279);
            this.ModifierProduit.Name = "ModifierProduit";
            this.ModifierProduit.Size = new System.Drawing.Size(169, 40);
            this.ModifierProduit.TabIndex = 16;
            this.ModifierProduit.Text = "Modifier";
            this.ModifierProduit.UseVisualStyleBackColor = false;
            this.ModifierProduit.Click += new System.EventHandler(this.ModifierProduit_Click);
            // 
            // AjouterProduit
            // 
            this.AjouterProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.AjouterProduit.FlatAppearance.BorderSize = 0;
            this.AjouterProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjouterProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterProduit.ForeColor = System.Drawing.Color.White;
            this.AjouterProduit.Image = ((System.Drawing.Image)(resources.GetObject("AjouterProduit.Image")));
            this.AjouterProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AjouterProduit.Location = new System.Drawing.Point(151, 278);
            this.AjouterProduit.Name = "AjouterProduit";
            this.AjouterProduit.Size = new System.Drawing.Size(169, 40);
            this.AjouterProduit.TabIndex = 15;
            this.AjouterProduit.Text = "Ajouter";
            this.AjouterProduit.UseVisualStyleBackColor = false;
            this.AjouterProduit.Click += new System.EventHandler(this.AjouterProduit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(341, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Liste des fournisseurs";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.Location = new System.Drawing.Point(89, 356);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(215, 18);
            this.d.TabIndex = 13;
            this.d.Text = "Rechercher un produit en stock";
            // 
            // PrixProduit
            // 
            this.PrixProduit.Location = new System.Drawing.Point(359, 143);
            this.PrixProduit.Multiline = true;
            this.PrixProduit.Name = "PrixProduit";
            this.PrixProduit.Size = new System.Drawing.Size(193, 21);
            this.PrixProduit.TabIndex = 1;
            // 
            // IdProduit
            // 
            this.IdProduit.Location = new System.Drawing.Point(625, 198);
            this.IdProduit.Multiline = true;
            this.IdProduit.Name = "IdProduit";
            this.IdProduit.Size = new System.Drawing.Size(193, 21);
            this.IdProduit.TabIndex = 1;
            // 
            // DataGridview
            // 
            this.DataGridview.AllowUserToAddRows = false;
            this.DataGridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridview.BackgroundColor = System.Drawing.Color.White;
            this.DataGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridview.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridview.EnableHeadersVisualStyles = false;
            this.DataGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridview.Location = new System.Drawing.Point(83, 437);
            this.DataGridview.Name = "DataGridview";
            this.DataGridview.ReadOnly = true;
            this.DataGridview.RowHeadersVisible = false;
            this.DataGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridview.Size = new System.Drawing.Size(787, 254);
            this.DataGridview.TabIndex = 19;
            this.DataGridview.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridview.ThemeStyle.HeaderStyle.Height = 30;
            this.DataGridview.ThemeStyle.ReadOnly = true;
            this.DataGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridview.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridview_CellContentClick);
            this.DataGridview.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridview_CellFormatting);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 43);
            this.panel2.TabIndex = 20;
            // 
            // Imprimer
            // 
            this.Imprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.Imprimer.FlatAppearance.BorderSize = 0;
            this.Imprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Imprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimer.ForeColor = System.Drawing.SystemColors.Window;
            this.Imprimer.Image = ((System.Drawing.Image)(resources.GetObject("Imprimer.Image")));
            this.Imprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imprimer.Location = new System.Drawing.Point(688, 363);
            this.Imprimer.Name = "Imprimer";
            this.Imprimer.Size = new System.Drawing.Size(169, 40);
            this.Imprimer.TabIndex = 21;
            this.Imprimer.Text = "Imprimer";
            this.Imprimer.UseVisualStyleBackColor = false;
            this.Imprimer.Click += new System.EventHandler(this.Imprimer_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // QuantiteProduit
            // 
            this.QuantiteProduit.Location = new System.Drawing.Point(151, 198);
            this.QuantiteProduit.Name = "QuantiteProduit";
            this.QuantiteProduit.Size = new System.Drawing.Size(193, 20);
            this.QuantiteProduit.TabIndex = 22;
            this.QuantiteProduit.ValueChanged += new System.EventHandler(this.AfficherErcran);
            // 
            // TotalProduit
            // 
            this.TotalProduit.Location = new System.Drawing.Point(159, 243);
            this.TotalProduit.Name = "TotalProduit";
            this.TotalProduit.Size = new System.Drawing.Size(161, 20);
            this.TotalProduit.TabIndex = 23;
            this.TotalProduit.TextChanged += new System.EventHandler(this.TotalProduit_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(156, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Prix total";
            // 
            // StockProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 725);
            this.Controls.Add(this.TotalProduit);
            this.Controls.Add(this.QuantiteProduit);
            this.Controls.Add(this.Imprimer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DataGridview);
            this.Controls.Add(this.RechercheFoirnisseur);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SupprimerFournisseur);
            this.Controls.Add(this.ModifierProduit);
            this.Controls.Add(this.AjouterProduit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.d);
            this.Controls.Add(this.DateExpiration);
            this.Controls.Add(this.CategorieProuits);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdProduit);
            this.Controls.Add(this.PrixProduit);
            this.Controls.Add(this.NomProduit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockProduits";
            this.Text = "StockProduits";
            this.Load += new System.EventHandler(this.StockProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantiteProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomProduit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CategorieProuits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateExpiration;
        private System.Windows.Forms.TextBox RechercheFoirnisseur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SupprimerFournisseur;
        private System.Windows.Forms.Button ModifierProduit;
        private System.Windows.Forms.Button AjouterProduit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.TextBox PrixProduit;
        private System.Windows.Forms.TextBox IdProduit;
        private Guna.UI.WinForms.GunaDataGridView DataGridview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Imprimer;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.NumericUpDown QuantiteProduit;
        private System.Windows.Forms.TextBox TotalProduit;
        private System.Windows.Forms.Label label8;
    }
}