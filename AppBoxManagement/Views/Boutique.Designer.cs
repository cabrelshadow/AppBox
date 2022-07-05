namespace AppBoxManagement.Views
{
    partial class Boutique
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boutique));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ProduitGridview = new Guna.UI.WinForms.GunaDataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.FactureBox = new System.Windows.Forms.RichTextBox();
            this.errorQuantite = new System.Windows.Forms.ErrorProvider(this.components);
            this.AjouterFacture = new System.Windows.Forms.Button();
            this.Effacer = new System.Windows.Forms.Button();
            this.Nomproduit = new System.Windows.Forms.TextBox();
            this.TotalPrix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ValeurQte = new System.Windows.Forms.Label();
            this.Quantite1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stockMessage = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NomClient = new System.Windows.Forms.TextBox();
            this.PrixProduit = new System.Windows.Forms.TextBox();
            this.Imprimer = new System.Windows.Forms.Button();
            this.AjouterCaisse = new System.Windows.Forms.Button();
            this.NomProduitVendu = new System.Windows.Forms.TextBox();
            this.PrixProuitVendu = new System.Windows.Forms.TextBox();
            this.QuantiteProduitVendu = new System.Windows.Forms.TextBox();
            this.TotalProduitVendu = new System.Windows.Forms.TextBox();
            this.NomClientFacture = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Idproduit = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProduitGridview)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantite1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 49);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(345, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Vente des Produits";
            // 
            // ProduitGridview
            // 
            this.ProduitGridview.AllowUserToAddRows = false;
            this.ProduitGridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ProduitGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ProduitGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProduitGridview.BackgroundColor = System.Drawing.Color.White;
            this.ProduitGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProduitGridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProduitGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProduitGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ProduitGridview.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProduitGridview.DefaultCellStyle = dataGridViewCellStyle6;
            this.ProduitGridview.EnableHeadersVisualStyles = false;
            this.ProduitGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProduitGridview.Location = new System.Drawing.Point(75, 423);
            this.ProduitGridview.Name = "ProduitGridview";
            this.ProduitGridview.ReadOnly = true;
            this.ProduitGridview.RowHeadersVisible = false;
            this.ProduitGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProduitGridview.Size = new System.Drawing.Size(837, 318);
            this.ProduitGridview.TabIndex = 24;
            this.ProduitGridview.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ProduitGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProduitGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProduitGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProduitGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProduitGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProduitGridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProduitGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProduitGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProduitGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProduitGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProduitGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProduitGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProduitGridview.ThemeStyle.HeaderStyle.Height = 30;
            this.ProduitGridview.ThemeStyle.ReadOnly = true;
            this.ProduitGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProduitGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProduitGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ProduitGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ProduitGridview.ThemeStyle.RowsStyle.Height = 22;
            this.ProduitGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProduitGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProduitGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProduitGridview_CellContentClick);
            this.ProduitGridview.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProduitGridview_CellFormatting);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.panel3.Location = new System.Drawing.Point(12, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(967, 4);
            this.panel3.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(403, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Produits disponible";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.FactureBox);
            this.panel4.Location = new System.Drawing.Point(538, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 264);
            this.panel4.TabIndex = 27;
            // 
            // FactureBox
            // 
            this.FactureBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactureBox.Location = new System.Drawing.Point(3, 27);
            this.FactureBox.Name = "FactureBox";
            this.FactureBox.ReadOnly = true;
            this.FactureBox.Size = new System.Drawing.Size(410, 239);
            this.FactureBox.TabIndex = 0;
            this.FactureBox.Text = "";
            // 
            // errorQuantite
            // 
            this.errorQuantite.ContainerControl = this;
            // 
            // AjouterFacture
            // 
            this.AjouterFacture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.AjouterFacture.FlatAppearance.BorderSize = 0;
            this.AjouterFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjouterFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterFacture.ForeColor = System.Drawing.Color.White;
            this.AjouterFacture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AjouterFacture.Location = new System.Drawing.Point(349, 190);
            this.AjouterFacture.Name = "AjouterFacture";
            this.AjouterFacture.Size = new System.Drawing.Size(156, 44);
            this.AjouterFacture.TabIndex = 28;
            this.AjouterFacture.Text = "Ajouter a la Facture";
            this.AjouterFacture.UseVisualStyleBackColor = false;
            this.AjouterFacture.Click += new System.EventHandler(this.AjouterFacture_Click);
            // 
            // Effacer
            // 
            this.Effacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.Effacer.FlatAppearance.BorderSize = 0;
            this.Effacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Effacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Effacer.ForeColor = System.Drawing.Color.White;
            this.Effacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Effacer.Location = new System.Drawing.Point(349, 248);
            this.Effacer.Name = "Effacer";
            this.Effacer.Size = new System.Drawing.Size(156, 44);
            this.Effacer.TabIndex = 28;
            this.Effacer.Text = "Effacer";
            this.Effacer.UseVisualStyleBackColor = false;
            this.Effacer.Click += new System.EventHandler(this.Effacer_Click);
            // 
            // Nomproduit
            // 
            this.Nomproduit.Location = new System.Drawing.Point(27, 34);
            this.Nomproduit.Multiline = true;
            this.Nomproduit.Name = "Nomproduit";
            this.Nomproduit.ReadOnly = true;
            this.Nomproduit.Size = new System.Drawing.Size(211, 24);
            this.Nomproduit.TabIndex = 0;
            // 
            // TotalPrix
            // 
            this.TotalPrix.Location = new System.Drawing.Point(77, 170);
            this.TotalPrix.Multiline = true;
            this.TotalPrix.Name = "TotalPrix";
            this.TotalPrix.ReadOnly = true;
            this.TotalPrix.Size = new System.Drawing.Size(161, 24);
            this.TotalPrix.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nom produit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Prix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Quantité";
            // 
            // ValeurQte
            // 
            this.ValeurQte.AutoSize = true;
            this.ValeurQte.ForeColor = System.Drawing.Color.Red;
            this.ValeurQte.Location = new System.Drawing.Point(244, 132);
            this.ValeurQte.Name = "ValeurQte";
            this.ValeurQte.Size = new System.Drawing.Size(0, 13);
            this.ValeurQte.TabIndex = 2;
            // 
            // Quantite1
            // 
            this.Quantite1.Location = new System.Drawing.Point(27, 130);
            this.Quantite1.Name = "Quantite1";
            this.Quantite1.Size = new System.Drawing.Size(211, 20);
            this.Quantite1.TabIndex = 3;
            this.Quantite1.ValueChanged += new System.EventHandler(this.AfficherErcran);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stockMessage);
            this.panel1.Controls.Add(this.Quantite1);
            this.panel1.Controls.Add(this.ValeurQte);
            this.panel1.Controls.Add(this.v);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TotalPrix);
            this.panel1.Controls.Add(this.NomClient);
            this.panel1.Controls.Add(this.PrixProduit);
            this.panel1.Controls.Add(this.Nomproduit);
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 231);
            this.panel1.TabIndex = 23;
            // 
            // stockMessage
            // 
            this.stockMessage.AutoSize = true;
            this.stockMessage.ForeColor = System.Drawing.Color.Red;
            this.stockMessage.Location = new System.Drawing.Point(24, 153);
            this.stockMessage.Name = "stockMessage";
            this.stockMessage.Size = new System.Drawing.Size(0, 13);
            this.stockMessage.TabIndex = 29;
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.BackColor = System.Drawing.Color.White;
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v.ForeColor = System.Drawing.Color.Black;
            this.v.Location = new System.Drawing.Point(1, 199);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(76, 15);
            this.v.TabIndex = 1;
            this.v.Text = "Nom client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total :";
            // 
            // NomClient
            // 
            this.NomClient.Location = new System.Drawing.Point(83, 195);
            this.NomClient.Multiline = true;
            this.NomClient.Name = "NomClient";
            this.NomClient.Size = new System.Drawing.Size(161, 24);
            this.NomClient.TabIndex = 0;
            // 
            // PrixProduit
            // 
            this.PrixProduit.Location = new System.Drawing.Point(27, 80);
            this.PrixProduit.Multiline = true;
            this.PrixProduit.Name = "PrixProduit";
            this.PrixProduit.Size = new System.Drawing.Size(211, 24);
            this.PrixProduit.TabIndex = 0;
            // 
            // Imprimer
            // 
            this.Imprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.Imprimer.FlatAppearance.BorderSize = 0;
            this.Imprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Imprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimer.ForeColor = System.Drawing.Color.White;
            this.Imprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Imprimer.Location = new System.Drawing.Point(578, 321);
            this.Imprimer.Name = "Imprimer";
            this.Imprimer.Size = new System.Drawing.Size(156, 44);
            this.Imprimer.TabIndex = 28;
            this.Imprimer.Text = "Imprimer";
            this.Imprimer.UseVisualStyleBackColor = false;
            this.Imprimer.Click += new System.EventHandler(this.Imprimer_Click);
            // 
            // AjouterCaisse
            // 
            this.AjouterCaisse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.AjouterCaisse.FlatAppearance.BorderSize = 0;
            this.AjouterCaisse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjouterCaisse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterCaisse.ForeColor = System.Drawing.Color.White;
            this.AjouterCaisse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AjouterCaisse.Location = new System.Drawing.Point(779, 317);
            this.AjouterCaisse.Name = "AjouterCaisse";
            this.AjouterCaisse.Size = new System.Drawing.Size(156, 44);
            this.AjouterCaisse.TabIndex = 28;
            this.AjouterCaisse.Text = "Ajouter a la caisse";
            this.AjouterCaisse.UseVisualStyleBackColor = false;
            this.AjouterCaisse.Click += new System.EventHandler(this.AjouterCaisse_Click);
            // 
            // NomProduitVendu
            // 
            this.NomProduitVendu.Enabled = false;
            this.NomProduitVendu.Location = new System.Drawing.Point(360, 101);
            this.NomProduitVendu.Multiline = true;
            this.NomProduitVendu.Name = "NomProduitVendu";
            this.NomProduitVendu.Size = new System.Drawing.Size(145, 24);
            this.NomProduitVendu.TabIndex = 0;
            this.NomProduitVendu.TextChanged += new System.EventHandler(this.NomProduitVendu_TextChanged);
            // 
            // PrixProuitVendu
            // 
            this.PrixProuitVendu.Enabled = false;
            this.PrixProuitVendu.Location = new System.Drawing.Point(360, 126);
            this.PrixProuitVendu.Multiline = true;
            this.PrixProuitVendu.Name = "PrixProuitVendu";
            this.PrixProuitVendu.Size = new System.Drawing.Size(145, 24);
            this.PrixProuitVendu.TabIndex = 0;
            // 
            // QuantiteProduitVendu
            // 
            this.QuantiteProduitVendu.Enabled = false;
            this.QuantiteProduitVendu.Location = new System.Drawing.Point(360, 153);
            this.QuantiteProduitVendu.Multiline = true;
            this.QuantiteProduitVendu.Name = "QuantiteProduitVendu";
            this.QuantiteProduitVendu.Size = new System.Drawing.Size(145, 24);
            this.QuantiteProduitVendu.TabIndex = 0;
            // 
            // TotalProduitVendu
            // 
            this.TotalProduitVendu.Enabled = false;
            this.TotalProduitVendu.Location = new System.Drawing.Point(12, 325);
            this.TotalProduitVendu.Multiline = true;
            this.TotalProduitVendu.Name = "TotalProduitVendu";
            this.TotalProduitVendu.Size = new System.Drawing.Size(161, 24);
            this.TotalProduitVendu.TabIndex = 0;
            // 
            // NomClientFacture
            // 
            this.NomClientFacture.Enabled = false;
            this.NomClientFacture.Location = new System.Drawing.Point(179, 325);
            this.NomClientFacture.Multiline = true;
            this.NomClientFacture.Name = "NomClientFacture";
            this.NomClientFacture.Size = new System.Drawing.Size(161, 24);
            this.NomClientFacture.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // Idproduit
            // 
            this.Idproduit.Enabled = false;
            this.Idproduit.Location = new System.Drawing.Point(89, 65);
            this.Idproduit.Multiline = true;
            this.Idproduit.Name = "Idproduit";
            this.Idproduit.Size = new System.Drawing.Size(161, 24);
            this.Idproduit.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Le Facturier";
            // 
            // Boutique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 753);
            this.Controls.Add(this.AjouterCaisse);
            this.Controls.Add(this.Imprimer);
            this.Controls.Add(this.Effacer);
            this.Controls.Add(this.AjouterFacture);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Idproduit);
            this.Controls.Add(this.TotalProduitVendu);
            this.Controls.Add(this.NomClientFacture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ProduitGridview);
            this.Controls.Add(this.QuantiteProduitVendu);
            this.Controls.Add(this.PrixProuitVendu);
            this.Controls.Add(this.NomProduitVendu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Boutique";
            this.Text = "Boutique";
            this.Load += new System.EventHandler(this.Boutique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProduitGridview)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantite1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView ProduitGridview;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ErrorProvider errorQuantite;
        private System.Windows.Forms.Button Effacer;
        private System.Windows.Forms.Button AjouterFacture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Quantite1;
        private System.Windows.Forms.Label ValeurQte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalPrix;
        private System.Windows.Forms.TextBox PrixProduit;
        private System.Windows.Forms.TextBox Nomproduit;
        private System.Windows.Forms.Button AjouterCaisse;
        private System.Windows.Forms.Button Imprimer;
        private System.Windows.Forms.TextBox TotalProduitVendu;
        private System.Windows.Forms.TextBox QuantiteProduitVendu;
        private System.Windows.Forms.TextBox PrixProuitVendu;
        private System.Windows.Forms.TextBox NomProduitVendu;
        private System.Windows.Forms.RichTextBox FactureBox;
        private System.Windows.Forms.TextBox NomClientFacture;
        private System.Windows.Forms.TextBox NomClient;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.TextBox Idproduit;
        private System.Windows.Forms.Label stockMessage;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label7;
    }
}