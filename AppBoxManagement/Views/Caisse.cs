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
    public partial class Caisse : Form
    {
        public static Caisse dashbord;
        public string budget;
        SqlConnection Connection = new SqlConnection(@"Data Source= (LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mr shadow\Documents\AppBoxManagement\AppBoxManagement\Db\GestionCaisse.mdf""; Integrated Security = True; Connect Timeout = 30");

        public Caisse()
        {
    
            dashbord = this;
            InitializeComponent();

          //  butjetsomme.Text=Dashbord.
            AfficherProduit();
        }
        private void AfficherProduit()
        {
            string dateJour = DateTime.Now.ToShortDateString();

            Connection.Open();
            string RequeteSelection = $"SELECT * FROM Caisse  ORDER BY IdCaisse DESC";
            SqlDataAdapter sda = new SqlDataAdapter(RequeteSelection, Connection);
            SqlCommandBuilder sqlBuild = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
           CaisseGrid.DataSource = dataSet.Tables[0];
            Connection.Close();
        }

        private void Caisse_Load(object sender, EventArgs e)
        {
      
            try
            {
                Connection.Open();
                string RequeteSelection4 = "SELECT Sum(Total_vendu)  FROM Caisse";
                SqlCommand cmd3 = new SqlCommand(RequeteSelection4, Connection);
                var count3 = cmd3.ExecuteScalar();
                TotalVenduCaisse.Text = count3.ToString() + " " + "FCFA";


                string RequeteSelection = $"SELECT * FROM VenteJour";
                SqlDataAdapter sda = new SqlDataAdapter(RequeteSelection, Connection);
                SqlCommandBuilder sqlBuild = new SqlCommandBuilder(sda);
                var dataSet = new DataSet();
                sda.Fill(dataSet);
                VenteJourGrid.DataSource = dataSet.Tables[0];


                Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Close();
            }

        }
        private void Effacer_Click(object sender, EventArgs e)
        {

        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
                if (RechercheCaisse.Text != "")
                {
                    string RequeteSelection = "SELECT * FROM Produit where   NomProduit Like '" + RechercheCaisse.Text + "%'";
                    Connection.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(RequeteSelection, Connection);
                    SqlCommandBuilder sqlBuild = new SqlCommandBuilder(sda);
                    var dataSet = new DataSet();
                    sda.Fill(dataSet);
                CaisseGrid.DataSource = dataSet.Tables[0];
                    Connection.Close();
                }
                else
                {
                    AfficherProduit();
                }
    }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            string RequeteSelection = "SELECT * FROM  Caisse where  Date_vendu='" + dateTimePicker1.Text + "'";
            Connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(RequeteSelection, Connection);
            SqlCommandBuilder sqlBuild = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            CaisseGrid.DataSource = dataSet.Tables[0];
            Connection.Close();
        }

        private void Imprimer_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "LISTE DES PRODUITS VENDU";
                printer.SubTitle = String.Format("Date: {0}", DateTime.Now.ToString());
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Center;
                printer.Footer = "Appbox application de gestion de vos caisses";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(CaisseGrid);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
