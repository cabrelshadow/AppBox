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
        SqlConnection Connection = new SqlConnection(@"Data Source= (LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mr shadow\Documents\AppBoxManagement\AppBoxManagement\Db\GestionCaisse.mdf""; Integrated Security = True; Connect Timeout = 30");
        public StockProduits()
        {
            InitializeComponent();

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

        private void StockProduits_Load(object sender, EventArgs e)
        {

        }
    }
}
