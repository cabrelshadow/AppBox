namespace AppBoxManagement.Views
{
    partial class CategorieProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorieProduit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.Nomcatogorie = new System.Windows.Forms.TextBox();
            this.SupprimerCategorie = new System.Windows.Forms.Button();
            this.ModifierCategorie = new System.Windows.Forms.Button();
            this.AjouterCategorie = new System.Windows.Forms.Button();
            this.DataGridviewCategorie = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Idcategorie = new System.Windows.Forms.TextBox();
            this.RechercheCategorie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridviewCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(304, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter une categorie";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.Location = new System.Drawing.Point(326, 90);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(119, 18);
            this.Nom.TabIndex = 1;
            this.Nom.Text = "Nom categorie";
            // 
            // Nomcatogorie
            // 
            this.Nomcatogorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nomcatogorie.Location = new System.Drawing.Point(285, 120);
            this.Nomcatogorie.Multiline = true;
            this.Nomcatogorie.Name = "Nomcatogorie";
            this.Nomcatogorie.Size = new System.Drawing.Size(230, 28);
            this.Nomcatogorie.TabIndex = 2;
            // 
            // SupprimerCategorie
            // 
            this.SupprimerCategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.SupprimerCategorie.FlatAppearance.BorderSize = 0;
            this.SupprimerCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupprimerCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerCategorie.ForeColor = System.Drawing.Color.White;
            this.SupprimerCategorie.Image = ((System.Drawing.Image)(resources.GetObject("SupprimerCategorie.Image")));
            this.SupprimerCategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SupprimerCategorie.Location = new System.Drawing.Point(563, 179);
            this.SupprimerCategorie.Name = "SupprimerCategorie";
            this.SupprimerCategorie.Size = new System.Drawing.Size(182, 40);
            this.SupprimerCategorie.TabIndex = 11;
            this.SupprimerCategorie.Text = "Supprimer";
            this.SupprimerCategorie.UseVisualStyleBackColor = false;
            this.SupprimerCategorie.Click += new System.EventHandler(this.SupprimerCategorie_Click);
            // 
            // ModifierCategorie
            // 
            this.ModifierCategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.ModifierCategorie.FlatAppearance.BorderSize = 0;
            this.ModifierCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifierCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierCategorie.ForeColor = System.Drawing.Color.White;
            this.ModifierCategorie.Image = ((System.Drawing.Image)(resources.GetObject("ModifierCategorie.Image")));
            this.ModifierCategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModifierCategorie.Location = new System.Drawing.Point(329, 179);
            this.ModifierCategorie.Name = "ModifierCategorie";
            this.ModifierCategorie.Size = new System.Drawing.Size(169, 40);
            this.ModifierCategorie.TabIndex = 10;
            this.ModifierCategorie.Text = "Modifier";
            this.ModifierCategorie.UseVisualStyleBackColor = false;
            this.ModifierCategorie.Click += new System.EventHandler(this.ModifierCategorie_Click);
            // 
            // AjouterCategorie
            // 
            this.AjouterCategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.AjouterCategorie.FlatAppearance.BorderSize = 0;
            this.AjouterCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjouterCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterCategorie.ForeColor = System.Drawing.Color.White;
            this.AjouterCategorie.Image = ((System.Drawing.Image)(resources.GetObject("AjouterCategorie.Image")));
            this.AjouterCategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AjouterCategorie.Location = new System.Drawing.Point(106, 179);
            this.AjouterCategorie.Name = "AjouterCategorie";
            this.AjouterCategorie.Size = new System.Drawing.Size(169, 40);
            this.AjouterCategorie.TabIndex = 9;
            this.AjouterCategorie.Text = "Ajouter";
            this.AjouterCategorie.UseVisualStyleBackColor = false;
            this.AjouterCategorie.Click += new System.EventHandler(this.AjouterCategorie_Click);
            // 
            // DataGridviewCategorie
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridviewCategorie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridviewCategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridviewCategorie.BackgroundColor = System.Drawing.Color.White;
            this.DataGridviewCategorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridviewCategorie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridviewCategorie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridviewCategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridviewCategorie.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridviewCategorie.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridviewCategorie.EnableHeadersVisualStyles = false;
            this.DataGridviewCategorie.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridviewCategorie.Location = new System.Drawing.Point(124, 288);
            this.DataGridviewCategorie.Name = "DataGridviewCategorie";
            this.DataGridviewCategorie.RowHeadersVisible = false;
            this.DataGridviewCategorie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridviewCategorie.Size = new System.Drawing.Size(569, 173);
            this.DataGridviewCategorie.TabIndex = 12;
            this.DataGridviewCategorie.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridviewCategorie.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridviewCategorie.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridviewCategorie.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridviewCategorie.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridviewCategorie.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridviewCategorie.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridviewCategorie.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridviewCategorie.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridviewCategorie.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridviewCategorie.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridviewCategorie.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridviewCategorie.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridviewCategorie.ThemeStyle.HeaderStyle.Height = 30;
            this.DataGridviewCategorie.ThemeStyle.ReadOnly = false;
            this.DataGridviewCategorie.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridviewCategorie.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridviewCategorie.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridviewCategorie.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridviewCategorie.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridviewCategorie.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridviewCategorie.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridviewCategorie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridviewCategorie_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(106, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 4);
            this.panel1.TabIndex = 13;
            // 
            // Idcategorie
            // 
            this.Idcategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idcategorie.Location = new System.Drawing.Point(534, 120);
            this.Idcategorie.Multiline = true;
            this.Idcategorie.Name = "Idcategorie";
            this.Idcategorie.Size = new System.Drawing.Size(230, 28);
            this.Idcategorie.TabIndex = 2;
            this.Idcategorie.Visible = false;
            // 
            // RechercheCategorie
            // 
            this.RechercheCategorie.Location = new System.Drawing.Point(124, 262);
            this.RechercheCategorie.Name = "RechercheCategorie";
            this.RechercheCategorie.Size = new System.Drawing.Size(259, 20);
            this.RechercheCategorie.TabIndex = 14;
            this.RechercheCategorie.TextChanged += new System.EventHandler(this.RechercheCategorie_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recherche categorie";
            // 
            // CategorieProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.RechercheCategorie);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridviewCategorie);
            this.Controls.Add(this.SupprimerCategorie);
            this.Controls.Add(this.ModifierCategorie);
            this.Controls.Add(this.AjouterCategorie);
            this.Controls.Add(this.Idcategorie);
            this.Controls.Add(this.Nomcatogorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategorieProduit";
            this.Text = "CategorieProduit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CategorieProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridviewCategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox Nomcatogorie;
        private System.Windows.Forms.Button SupprimerCategorie;
        private System.Windows.Forms.Button ModifierCategorie;
        private System.Windows.Forms.Button AjouterCategorie;
        private Guna.UI.WinForms.GunaDataGridView DataGridviewCategorie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Idcategorie;
        private System.Windows.Forms.TextBox RechercheCategorie;
        private System.Windows.Forms.Label label2;
    }
}