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
    public partial class Dashbord : Form
    {
        public static Dashbord dashbord;
        
       SqlConnection Connection = new SqlConnection(@"Data Source= (LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mr shadow\Documents\AppBoxManagement\AppBoxManagement\Db\GestionCaisse.mdf""; Integrated Security = True; Connect Timeout = 30");

        public Dashbord()
        {
            dashbord = this;
            InitializeComponent();
          
        }

     
        private void Dashbord_Load(object sender, EventArgs e)     
        {
          // Caisse.dashbord.budget = Butget.Text;
            string DateJour = DateTime.Now.ToShortDateString();
            //la requete^pour compter le nombre de fournisseur
            try
            {
                Connection.Open();
                string RequeteSelection = "SELECT Sum(Quantite_Vendu)  FROM Caisse";
                SqlCommand cmd = new SqlCommand(RequeteSelection, Connection);
                var count = cmd.ExecuteScalar();
                NombreFournisseur.Text = count.ToString();



                string RequeteSelection2 = "SELECT count(IdProduit)  FROM Produit ";
                SqlCommand cmd1 = new SqlCommand(RequeteSelection2, Connection);
                var count1 = cmd1.ExecuteScalar();
                quatiteProduit.Text = count1.ToString();
     

                string RequeteSelection3 = "SELECT Sum(Quatite_disponble)  FROM Produit";
                SqlCommand cmd2 = new SqlCommand(RequeteSelection3, Connection);
                var count2 = cmd2.ExecuteScalar();
                produitDispnible.Text = count2.ToString();


                string RequeteSelection4 = "SELECT Sum(Total_vendu)  FROM Caisse WHERE Date_vendu='"+DateJour+"'";
                SqlCommand cmd3 = new SqlCommand(RequeteSelection4, Connection);
                var count3 = cmd3.ExecuteScalar();
                VenteJour.Text = count3.ToString()+" "+"FCFA";
    
              

                //requete pour le graphe di dahhbord;
                string RequeteSelection1 = "SELECT  * FROM Caisse";
                SqlDataAdapter sda = new SqlDataAdapter(RequeteSelection1, Connection);
                SqlCommandBuilder sqlBuild = new SqlCommandBuilder(sda);
                DataTable dataSet = new DataTable();
                sda.Fill(dataSet);
                Graphe.DataSource = dataSet;


                string RequeteSelectionBudjet= "SELECT Sum(Prix_Total) From  Produit";
                SqlCommand cmd5 = new SqlCommand(RequeteSelectionBudjet, Connection);
                var count5 = cmd5.ExecuteScalar();
                Butget.Text = count5.ToString() + " " + "FCFA";
               
             

                Caisse caisse = new Caisse();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





            Graphe.Series["produit_le_plus_vendu"].XValueMember = "NomProuit";
            Graphe.Series["produit_le_plus_vendu"].YValueMembers = "Total_vendu";

            Graphe.Series["quantite_vendu"].XValueMember = "NomProuit";
            Graphe.Series["quantite_vendu"].YValueMembers = "Quantite_Vendu";

            Graphe.Titles.Add("INFORMATION SUR LES VENTES");
             Connection.Close();
            //Graphe.Series[1].XValueMember = "Total_vendu";
            //Graphe.Series[1].YValueMembers = "Quantite_Vendu";



            //  Connection.Open();
            //  string RequeteSelection = "SELECT  Sum(isnull(cast(PrixProduit as float),0)) PrixProdrouveuit FROM Produit";
            //SqlCommand cmd = new SqlCommand(RequeteSelection, Connection);
            //  var count = cmd.ExecuteScalar();
            //  NombreFournisseur.Text=count.ToString();


        }

        private void Graphe_Click(object sender, EventArgs e)
        {

        }

        private void Enregistrervente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string DataJour = DateTime.Now.ToShortDateString();
         
            try
            {  
                string Requete = $"INSERT INTO VenteJour(Total_vente_du_jour,DateEnregistere) VALUES('{VenteJour.Text}','{DataJour}')";
                Connection.Open();
                SqlCommand sqlCommand = new SqlCommand(Requete, Connection);
                sqlCommand.ExecuteNonQuery();
                Connection.Close();
                MessageBox.Show("vente du jour enregsiter avec succès", "ventejour", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
