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
    public partial class CategorieProduit : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source= (LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mr shadow\Documents\AppBoxManagement\AppBoxManagement\Db\GestionCaisse.mdf""; Integrated Security = True; Connect Timeout = 30");
        public CategorieProduit()
        {
            InitializeComponent();
            AfficherFournisseur();
        }
        private void AfficherFournisseur()
        {


            Connection.Open();
            string RequeteSelection = "SELECT * FROM Categorie";
            SqlDataAdapter sda = new SqlDataAdapter(RequeteSelection, Connection);
            SqlCommandBuilder sqlBuild = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            DataGridviewCategorie.DataSource = dataSet.Tables[0];
            Connection.Close();
        }
        private void AjouterCategorie_Click(object sender, EventArgs e)
        {
         string   dataJour = DateTime.Now.ToString();
            if (Nomcatogorie.Text == "")
            {
                MessageBox.Show("veiller replir le Nom de la categorie", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    string requeteCategorie = "INSERT INTO Categorie(NomCategorie,DateCreation) VALUES('" + Nomcatogorie.Text + "','"+dataJour+"')";
                    Connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(requeteCategorie, Connection);
                 sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("categorie Ajouter avec succès !", "insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Connection.Close();
                    Nomcatogorie.Text = "";
                    AfficherFournisseur();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CategorieProduit_Load(object sender, EventArgs e)
        {
            Idcategorie.Enabled=false;
            Idcategorie.Visible=false;
        }

        private void ModifierCategorie_Click(object sender, EventArgs e)
        {
          int idcategory=int.Parse(Idcategorie.Text);
            try
            {
                if (Nomcatogorie.Text == "")
                    MessageBox.Show("remplisez le nom ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                string Requete = "UPDATE Categorie SET NomCategorie='" + Nomcatogorie.Text + "' WHERE IdCategorie='" + idcategory + "';";
                Connection.Open();
                SqlCommand command = new SqlCommand(Requete, Connection);
                command.ExecuteNonQuery();

                MessageBox.Show("catergorie Modifier avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Connection.Close();
                Nomcatogorie.Text = "";
                AfficherFournisseur();
            }catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
         
        }

        private void DataGridviewCategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Idcategorie.Text = DataGridviewCategorie.SelectedRows[0].Cells[0].Value.ToString();
            Nomcatogorie.Text = DataGridviewCategorie.SelectedRows[0].Cells[1].Value.ToString();
           

        }

        private void SupprimerCategorie_Click(object sender, EventArgs e)
        {
            var DeleteInfo = MessageBox.Show("voulez-vous vraiment supprimer cette categorie?", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DeleteInfo == DialogResult.Yes)
            {
                try
            {
                Connection.Open();
                int idcategory = int.Parse(Idcategorie.Text);
                string RequeteSupprimer = "DELETE FROM Categorie WHERE IdCategorie='" + idcategory + "';";
                SqlCommand sqlCommand = new SqlCommand(RequeteSupprimer, Connection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("categoriesupprimer avec succes", "supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Connection.Close();
                Idcategorie.Text = "";
                AfficherFournisseur();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        }

        private void RechercheCategorie_TextChanged(object sender, EventArgs e)
        {
            if (RechercheCategorie.Text != "")
            {
                string RequeteSelection = "SELECT * FROM Categorie where  NomCategorie Like '" + RechercheCategorie.Text + "%'";
                Connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(RequeteSelection, Connection);
                SqlCommandBuilder sqlBuild = new SqlCommandBuilder(sda);
                var dataSet = new DataSet();
                sda.Fill(dataSet);
                DataGridviewCategorie.DataSource = dataSet.Tables[0];
                Connection.Close();
            }
            else
            {
                AfficherFournisseur();
            }

        }
    }
}
