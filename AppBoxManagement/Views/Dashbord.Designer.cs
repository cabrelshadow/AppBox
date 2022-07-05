namespace AppBoxManagement.Views
{
    partial class Dashbord
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NombreFournisseur = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Graphe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.quatiteProduit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.produitDispnible = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Enregistrervente = new System.Windows.Forms.LinkLabel();
            this.VenteJour = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Butget = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graphe)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(372, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABLEAUX DE BORD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.NombreFournisseur);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(520, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 105);
            this.panel1.TabIndex = 1;
            // 
            // NombreFournisseur
            // 
            this.NombreFournisseur.AutoSize = true;
            this.NombreFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreFournisseur.ForeColor = System.Drawing.Color.White;
            this.NombreFournisseur.Location = new System.Drawing.Point(41, 63);
            this.NombreFournisseur.Name = "NombreFournisseur";
            this.NombreFournisseur.Size = new System.Drawing.Size(19, 20);
            this.NombreFournisseur.TabIndex = 3;
            this.NombreFournisseur.Text = "1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(23, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 4);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantité vendu";
            // 
            // Graphe
            // 
            chartArea2.Name = "ChartArea1";
            this.Graphe.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Graphe.Legends.Add(legend2);
            this.Graphe.Location = new System.Drawing.Point(39, 283);
            this.Graphe.Name = "Graphe";
            this.Graphe.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "quantite_vendu";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "produit_le_plus_vendu";
            this.Graphe.Series.Add(series3);
            this.Graphe.Series.Add(series4);
            this.Graphe.Size = new System.Drawing.Size(902, 329);
            this.Graphe.TabIndex = 2;
            this.Graphe.Text = "chart1";
            this.Graphe.Click += new System.EventHandler(this.Graphe_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(75)))), ((int)(((byte)(198)))));
            this.panel2.Controls.Add(this.quatiteProduit);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(98, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 105);
            this.panel2.TabIndex = 1;
            // 
            // quatiteProduit
            // 
            this.quatiteProduit.AutoSize = true;
            this.quatiteProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quatiteProduit.ForeColor = System.Drawing.Color.White;
            this.quatiteProduit.Location = new System.Drawing.Point(47, 63);
            this.quatiteProduit.Name = "quatiteProduit";
            this.quatiteProduit.Size = new System.Drawing.Size(19, 20);
            this.quatiteProduit.TabIndex = 4;
            this.quatiteProduit.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(23, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 4);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre Produit en stock";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(249)))));
            this.panel5.Controls.Add(this.produitDispnible);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label);
            this.panel5.Location = new System.Drawing.Point(308, 138);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(189, 105);
            this.panel5.TabIndex = 1;
            // 
            // produitDispnible
            // 
            this.produitDispnible.AutoSize = true;
            this.produitDispnible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produitDispnible.ForeColor = System.Drawing.Color.White;
            this.produitDispnible.Location = new System.Drawing.Point(46, 63);
            this.produitDispnible.Name = "produitDispnible";
            this.produitDispnible.Size = new System.Drawing.Size(19, 20);
            this.produitDispnible.TabIndex = 5;
            this.produitDispnible.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(63, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(23, 44);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(148, 4);
            this.panel6.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(-3, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(194, 16);
            this.label.TabIndex = 2;
            this.label.Text = "Total de produit disponible";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(23)))), ((int)(((byte)(50)))));
            this.panel7.Controls.Add(this.Enregistrervente);
            this.panel7.Controls.Add(this.VenteJour);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(731, 138);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(191, 105);
            this.panel7.TabIndex = 1;
            // 
            // Enregistrervente
            // 
            this.Enregistrervente.AutoSize = true;
            this.Enregistrervente.BackColor = System.Drawing.Color.Transparent;
            this.Enregistrervente.DisabledLinkColor = System.Drawing.Color.White;
            this.Enregistrervente.LinkColor = System.Drawing.Color.White;
            this.Enregistrervente.Location = new System.Drawing.Point(36, 83);
            this.Enregistrervente.Name = "Enregistrervente";
            this.Enregistrervente.Size = new System.Drawing.Size(122, 13);
            this.Enregistrervente.TabIndex = 5;
            this.Enregistrervente.TabStop = true;
            this.Enregistrervente.Text = "Enregistrer vente du jour";
            this.Enregistrervente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Enregistrervente_LinkClicked);
            // 
            // VenteJour
            // 
            this.VenteJour.AutoSize = true;
            this.VenteJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenteJour.ForeColor = System.Drawing.Color.White;
            this.VenteJour.Location = new System.Drawing.Point(19, 63);
            this.VenteJour.Name = "VenteJour";
            this.VenteJour.Size = new System.Drawing.Size(19, 20);
            this.VenteJour.TabIndex = 4;
            this.VenteJour.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(63, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 18);
            this.label7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(23, 44);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(159, 4);
            this.panel8.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total des vente du jour";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(121)))), ((int)(((byte)(101)))));
            this.panel9.Controls.Add(this.Butget);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Location = new System.Drawing.Point(91, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(191, 105);
            this.panel9.TabIndex = 1;
            // 
            // Butget
            // 
            this.Butget.AutoSize = true;
            this.Butget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butget.ForeColor = System.Drawing.Color.White;
            this.Butget.Location = new System.Drawing.Point(19, 62);
            this.Butget.Name = "Butget";
            this.Butget.Size = new System.Drawing.Size(19, 20);
            this.Butget.TabIndex = 4;
            this.Butget.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(63, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 18);
            this.label9.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(23, 44);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(159, 4);
            this.panel10.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(42, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Budget";
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1042, 670);
            this.Controls.Add(this.Graphe);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashbord";
            this.Text = "Dashbord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashbord_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graphe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label NombreFournisseur;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graphe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label quatiteProduit;
        private System.Windows.Forms.Label produitDispnible;
        private System.Windows.Forms.Label VenteJour;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label Butget;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel Enregistrervente;
    }
}