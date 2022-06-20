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
        SqlConnection Connection = new SqlConnection(@"Data Source= (LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mr shadow\Documents\AppBoxManagement\AppBoxManagement\Db\GestionCaisse.mdf""; Integrated Security = True; Connect Timeout = 30");

        public Dashbord()
        {
            InitializeComponent();
            AfficherFournisseur();
        }

        private void AfficherFournisseur()
        {
         

            Connection.Open();
            string RequeteSelection = "SELECT  count( IdCategorie) FROM Categorie";
            SqlDataAdapter sda = new SqlDataAdapter(RequeteSelection, Connection);
            SqlCommandBuilder sqlBuild = new SqlCommandBuilder(sda);
            DataTable tableCategorie = new DataTable();
            sda.Fill(tableCategorie);
            NombreFournisseur.Text = sda.Fill(tableCategorie).ToString();
            Connection.Close();
        }
        private void Dashbord_Load(object sender, EventArgs e)     
        {

           
        }
    }
}
