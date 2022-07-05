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

namespace AppBoxManagement
{
    public partial class Login : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source= (LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mr shadow\Documents\AppBoxManagement\AppBoxManagement\Db\GestionCaisse.mdf""; Integrated Security = True; Connect Timeout = 30");

        public Login()
        {
            InitializeComponent();
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {

            if (TxtPassword.UseSystemPasswordChar == true)
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }

        private void BtnConnecter_Click(object sender, EventArgs e)
        {
            
            if(Txtusername.Text=="" || TxtPassword.Text == "")
            {
                MessageBox.Show("le nom et le mot de passe doivent etre renseigner", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

           
            Connection.Open();
            string req = "SELECT Count(*) FROM UserLogin WHERE Nom='" + Txtusername.Text + "' AND Password='" + TxtPassword.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(req, Connection);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
           
            if (dataTable.Rows[0][0].ToString() == "1")
          
            {
                MainForms mainForms = new MainForms();
                mainForms.Show();
                this.Close();
            }
            
            else
            {
                MessageBox.Show("login ou mot de passe incorrect", "error");
                Connection.Close();
            }
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
