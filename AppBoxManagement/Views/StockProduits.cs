using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppBoxManagement.Views
{
    public partial class StockProduits : Form
    {

        public int quantite;
        public int prix;
        public int totalcal;
        SqlConnection Connection = new SqlConnection(@"Data Source= (LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mr shadow\Documents\AppBoxManagement\AppBoxManagement\Db\GestionCaisse.mdf""; Integrated Security = True; Connect Timeout = 30");
        public StockProduits()
        {
            InitializeComponent();
            AfficherProduit();
            //remplir la combobox
            Connection.Open();
            string RequeteSelection = "SELECT IdCategorie, NomCategorie FROM Categorie";
            SqlCommand command = new SqlCommand(RequeteSelection, Connection);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand=command;
            //SqlCommandBuilder sqlBuild = new SqlCommandBuilder(sda);
              DataTable tableCategorie= new DataTable();
            sda.Fill(tableCategorie);
            CategorieProuits.DataSource =tableCategorie;
            CategorieProuits.DisplayMember = "Categorie";
            CategorieProuits.ValueMember = "NomCategorie";
            Connection.Close();

            //CategorieProuits.DataSource = Gender;
        }
        private void ClearTextBox()
        {
            NomProduit.Text = "";
            QuantiteProduit.Text = "";
            PrixProduit.Text = "";
            TotalProduit.Text = "";
           
            QuantiteProduit.ResetText();



        }
        private void StockProduits_Load(object sender, EventArgs e)
        {
             IdProduit.Enabled = false;
            IdProduit.Visible = false;
        }

        private void Evenement_Load(object sender, EventArgs e)
        {

            this.QuantiteProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AfficherErcran);

        }
        private void AfficherErcran(object sender, EventArgs e)
        {
            try
            {

                quantite = 0;
                prix = 0;
                quantite = Convert.ToInt32(QuantiteProduit.Value);
                totalcal = 0;

                prix = int.Parse(PrixProduit.Text);
                totalcal = quantite * prix;
                TotalProduit.Text = totalcal.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            //if (Quantite.Text.Length > 2)
            //{
            //    ValeurQte.Text = "la quantité ne peut pas etre 0";
            //    errorQuantite.SetError(this.ValeurQte, "la quanté ne peut pas etre null");
            //}

        }

        private void AjouterProduit_Click(object sender, EventArgs e)
        {
            if (NomProduit.Text == "" || TotalProduit.Text == "" || PrixProduit.Text == "" )
            {
                MessageBox.Show("tout les champs doivent etre rempli", "error de ramplisage des champs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     
            else
            {

              
                string dataJour = DateExpiration.Value.ToString("dd MMM yyyy");
                try
                {
                    // ouverture de la connexion
                    Connection.Open();
                    string Requete = @"INSERT INTO Produit(NomProduit,QuantiteProduit,Quatite_disponble,PrixProduit,Prix_Total,CategorieProui,DateExpiration) VALUES
                     ('" + NomProduit.Text + "' ,'" + Convert.ToInt32(QuantiteProduit.Value) + "','" + Convert.ToInt32(QuantiteProduit.Value) + "','" + Convert.ToInt32(PrixProduit.Text)+"','"+ Convert.ToInt32(TotalProduit.Text) + "','" + CategorieProuits.Text + "','" + dataJour + "')";
                    SqlCommand command = new SqlCommand(Requete, Connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Produit  Ajouter avec succes", "insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //fermerture de la connexion
                    Connection.Close();
                    ClearTextBox();
                    AfficherProduit();
                   // AfficherFournisseur();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        //afficher la liste des des produit dans la grid view
        private void AfficherProduit()
        {

            Connection.Open();
            string RequeteSelection = "SELECT * FROM Produit ORDER BY IdProduit DESC";
            SqlDataAdapter sda = new SqlDataAdapter(RequeteSelection, Connection);
            SqlCommandBuilder sqlBuild = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            DataGridview.DataSource = dataSet.Tables[0];
            Connection.Close();
        }
    

        private void DataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdProduit.Text = DataGridview.SelectedRows[0].Cells[0].Value.ToString();

            NomProduit.Text = DataGridview.SelectedRows[0].Cells[1].Value.ToString();
           TotalProduit.Text = DataGridview.SelectedRows[0].Cells[5].Value.ToString();
            PrixProduit.Text = DataGridview.SelectedRows[0].Cells[4].Value.ToString();
            CategorieProuits.SelectedItem = DataGridview.SelectedRows[0].Cells[6].Value.ToString();
        }

         
                    //e.CellStyle.BackColor = Color.Red;
                    //e.CellStyle.ForeColor = Color.White;
        private void DataGridview_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            foreach (DataGridViewRow row in DataGridview.Rows)
            {
                int stcok = Convert.ToInt32(row.Cells[3].Value);
                if (stcok < 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {

                }

            }
        }

        private void RechercheFoirnisseur_TextChanged(object sender, EventArgs e)
        {
            if (RechercheFoirnisseur.Text != "")
            {
                string RequeteSelection = "SELECT * FROM Produit where   NomProduit Like '" + RechercheFoirnisseur.Text + "%'";
                Connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(RequeteSelection, Connection);
                SqlCommandBuilder sqlBuild = new SqlCommandBuilder(sda);
                var dataSet = new DataSet();
                sda.Fill(dataSet);
                DataGridview.DataSource = dataSet.Tables[0];
                Connection.Close();
            }
            else
            {
                AfficherProduit();
            }

        }
        /// <summary>
        // modifcation des produits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifierProduit_Click(object sender, EventArgs e)
        {
            try
            {
                // ouverture de la connexion

                Connection.Open();
                string Requete = "UPDATE Produit SET NomProduit='" + NomProduit.Text + "'  , QuantiteProduit='" + QuantiteProduit.Value + "' ,Quatite_disponble='"+ QuantiteProduit.Text + "' ,Prix_Total='"+ TotalProduit.Text + "' ,PrixProduit='" + PrixProduit.Text+ "' ,CategorieProui='" + CategorieProuits.Text + "' WHERE IdProduit='" + IdProduit.Text + "';";


                SqlCommand command = new SqlCommand(Requete, Connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Produit modifier avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Connection.Close();



                //fermerture de la connexion

                ClearTextBox();
                AfficherProduit();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void SupprimerFournisseur_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                string RequeteSuppressionProduit="DELETE FROM Produit WHERE IdProduit='"+ IdProduit.Text+"';";
                SqlCommand command = new SqlCommand(RequeteSuppressionProduit, Connection);
                command.BeginExecuteNonQuery();
                MessageBox.Show("Produit supprimer en stock avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Connection.Close();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Imprimer_Click(object sender, EventArgs e)
        {
            try
            {

                DGVPrinter printer = new DGVPrinter();
                printer.Title = "LISTE DES PRODUITS EN STOCK";
                printer.SubTitle = String.Format("Date: {0}", DateTime.Now.ToString());
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Appbox application de gestion de vos caisses";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(DataGridview);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("         " + DataGridview.ToString(), new Font("Centuty Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(10));
        }



    

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void CategorieProuits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TotalProduit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
