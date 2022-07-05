using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBoxManagement.Views
{
    public partial class Paramettre : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source= (LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mr shadow\Documents\AppBoxManagement\AppBoxManagement\Db\GestionCaisse.mdf""; Integrated Security = True; Connect Timeout = 30");
        public Paramettre()
        {
            InitializeComponent();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            int id = 1;
            if (NomUser.Text == "" || password.Text == "" || Cpassword.Text == "")
            {
                MessageBox.Show("veiller remplir tout les champs ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (password.Text!= Cpassword.Text)
            {
                MessageBox.Show("les deux mot de passes doivent etre identique ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Connection.Open();
                string Requete = "UPDATE UserLogin SET Nom='" + NomUser.Text + "'  , Password='" + password.Text + "' WHERE IdUser='"+id+"'";


                SqlCommand command = new SqlCommand(Requete, Connection);
                command.ExecuteNonQuery();

                MessageBox.Show("modiffication effectuer avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NomUser.Text = "";
                password.Text = "";
            }
        }
    }
}
