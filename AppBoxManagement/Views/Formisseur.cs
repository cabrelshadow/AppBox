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
using System.IO;
using iTextSharp.text.pdf;
using DGV2Printer;

namespace AppBoxManagement.Views
{
    public partial class Formisseur : Form
    {
        public string Id;
        public string Nomf;
        public string Adresse;
        public string NomProduitl;
        public string Quantiter;
        public string telephone;
        public string dataJour; 


        public Formisseur()
        {
            InitializeComponent();
            AfficherFournisseur();
        }
        // la connection a la base de donnees
        SqlConnection Connection= new  SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mr shadow\Documents\GestionCaisse.mdf"";Integrated Security=True;Connect Timeout=30");

        private void Formisseur_Load(object sender, EventArgs e)
        {

        }
        //Pour effacer les champs on cree une method aui ne revoie rien 
        private void ClearTextBox()
        {
            IdFournisseur.Text = "";
            Nom.Text = "";
           AdressFournisseur.Text = "";
           TelePhoneFornisseur.Text = "";
            NomProduitLivre.Text = "";
            QuantiterProduit.Text = "";

        }
        //requete de seletion des fournisseurs
        private void AfficherFournisseur()
        {
            Connection.Open();
            string RequeteSelection = "SELECT * FROM Fournisseur";
            SqlDataAdapter sda = new SqlDataAdapter(RequeteSelection,Connection);
            SqlCommandBuilder sqlBuild= new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            dataGridFournisseur.DataSource = dataSet.Tables[0];
            Connection.Close();
        }
        private void AjouterForniseur_Click(object sender, EventArgs e)
        {
            if(IdFournisseur.Text ==""|| NomProduit.Text == "" || AdressFournisseur.Text=="" || TelePhoneFornisseur.Text==""|| NomProduitLivre.Text==""|| QuantiterProduit.Text == "")
            {
                MessageBox.Show("tout les champs doivent etre rempli", "error de ramplisage des champs", MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            }
            else
            {
                Id = IdFournisseur.Text.ToUpper();
                Nomf = NomProduit.Text;
                Adresse = AdressFournisseur.Text;
                telephone = TelePhoneFornisseur.Text;
                NomProduitl = NomProduitLivre.Text;
                Quantiter=QuantiterProduit.Text;
                dataJour = DateTime.Now.ToString();
                try
                {
                     // ouverture de la connexion
                     Connection.Open();
                    string Requete= @"INSERT INTO Fournisseur(IdFournisseur,NomF,AdresseF,TelephoneF,NomProduitL,QuantiteProduitL,DateLivrer) VALUES
                     ('" + Id + "','" + Nomf + "' ,'" + Adresse + "','" + telephone + "','" + NomProduitl + "','" +Quantiter + "','" + dataJour + "')";
                    SqlCommand command = new SqlCommand(Requete, Connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Fournisseur Ajouter avec succes", "insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  
                    //fermerture de la connexion
                    Connection.Close();
                    ClearTextBox();
                    AfficherFournisseur();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        /// <summary>
        /// modification des information du fornisseur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifierFournisseurs_Click(object sender, EventArgs e)
        {

            if (IdFournisseur.Text == "")
            {
                MessageBox.Show("l'identifiant doit etre renseigner", "l'identifiant ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Id = IdFournisseur.Text.ToUpper();
                Nomf = NomProduit.Text;
                Adresse = AdressFournisseur.Text;
                telephone = TelePhoneFornisseur.Text;
                NomProduitl = NomProduitLivre.Text;
                Quantiter = QuantiterProduit.Text;
                dataJour = DateTime.Now.ToString();
                try
                {
                    // ouverture de la connexion
                 
                        Connection.Open();
           string Requete = "UPDATE Fournisseur SET NomF='"+ NomProduit.Text+ "'  , AdresseF='" + AdressFournisseur.Text+ "' ,TelephoneF='" + TelePhoneFornisseur.Text+ "' ,NomProduitL='" + NomProduitLivre.Text+ "', " +
                        "QuantiteProduitL='"+QuantiterProduit.Text+"'  WHERE IdFournisseur='" + IdFournisseur.Text + "';";

                        SqlCommand command = new SqlCommand(Requete, Connection);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Fournisseur effectuer avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Connection.Close();



                    //fermerture de la connexion

                    ClearTextBox();
                    AfficherFournisseur();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        /// <summary>
        /// losque on selectionne un ligne du grid view elle reagis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
 
        private void dataGridFournisseur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdFournisseur.Text = dataGridFournisseur.SelectedRows[0].Cells[0].Value.ToString();

            NomProduit.Text = dataGridFournisseur.SelectedRows[0].Cells[1].Value.ToString();
            AdressFournisseur.Text = dataGridFournisseur.SelectedRows[0].Cells[2].Value.ToString();
            TelePhoneFornisseur.Text = dataGridFournisseur.SelectedRows[0].Cells[3].Value.ToString();

            NomProduitLivre.Text = dataGridFournisseur.SelectedRows[0].Cells[4].Value.ToString();

            QuantiterProduit.Text = dataGridFournisseur.SelectedRows[0].Cells[5].Value.ToString();
        }
        /// <summary>
        /// suppresion du fornisseur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SupprimerFournisseur_Click(object sender, EventArgs e)
        {

            if (IdFournisseur.Text == "" )
            {
                MessageBox.Show("l'identifiant doit etre renseigner", "l'identifiant ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Id = IdFournisseur.Text.ToUpper();
                Nomf = NomProduit.Text;
                Adresse = AdressFournisseur.Text;
                telephone = TelePhoneFornisseur.Text;
                NomProduitl = NomProduitLivre.Text;
                Quantiter = QuantiterProduit.Text;
                dataJour = DateTime.Now.ToString();
                try
                {
                    // ouverture de la connexion
                 var DeleteInfo=   MessageBox.Show("voulez-vous vraiment supprimer ce fornisseur ?","suppression",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if(DeleteInfo== DialogResult.Yes)
                    {
                        Connection.Open();
                        string Requete = "DELETE  FROM Fournisseur WHERE IdFournisseur='" + IdFournisseur.Text + "';";
                        SqlCommand command = new SqlCommand(Requete, Connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("supprimer avec succes", "supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Connection.Close();

                    }
                


                    //fermerture de la connexion
                    
                    ClearTextBox();
                    AfficherFournisseur();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

      

        private void Imprimer_Click(object sender, EventArgs e)
        {
         
           DGVPrinter printer = new DGVPrinter();
            printer.Title = "lsite des fournisseur";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader=false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Appbox application de gestion de vos caisses";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridFournisseur);

        }

        private void PrintPdf_Click(object sender, EventArgs e)
        {

        }

        private void RechercheFoirnisseur_TextChanged(object sender, EventArgs e)
        {

            if (RechercheFoirnisseur.Text != "")
            {
                string RequeteSelection = "SELECT * FROM Fournisseur where  NomF Like '"+RechercheFoirnisseur.Text+"%'";
                Connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(RequeteSelection, Connection);
                SqlCommandBuilder sqlBuild = new SqlCommandBuilder(sda);
                var dataSet = new DataSet();
                sda.Fill(dataSet);
                dataGridFournisseur.DataSource = dataSet.Tables[0];
                Connection.Close();
            }
            else
            {
                AfficherFournisseur();
            }
          
           
        }
    }
}
