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
    public partial class Boutique : Form
    {
        // connection a la base donneeSqlConnection
        // 
        public int quantite;
        public int prix;
        public int totalcal;

        SqlConnection Connection = new SqlConnection(@"Data Source= (LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mr shadow\Documents\AppBoxManagement\AppBoxManagement\Db\GestionCaisse.mdf""; Integrated Security = True; Connect Timeout = 30");

        public Boutique()
        {
            InitializeComponent();
            AfficherProduit();
            NomProduitVendu.Visible=false;
            PrixProuitVendu.Visible = false;
            QuantiteProduitVendu.Visible = false;
            NomClientFacture.Visible = false;
            TotalProduitVendu.Visible = false;
            Idproduit.Visible = false;

        }

        private void AfficherProduit()
        {


            Connection.Open();
            string RequeteSelection = "SELECT * FROM Produit ORDER BY IdProduit DESC";
            SqlDataAdapter sda = new SqlDataAdapter(RequeteSelection, Connection);
            SqlCommandBuilder sqlBuild = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            ProduitGridview.DataSource = dataSet.Tables[0];
            Connection.Close();
        }
        private void Boutique_Load(object sender, EventArgs e)
        {
            PrixProduit.Enabled = false;
        

        }

        //afficher et calcule du prix instantanement
        private void Evenement_Load(object sender, EventArgs e)
        {

            this.Quantite1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AfficherErcran);

        }
        private void AfficherErcran(object sender, EventArgs e)
        {
            try
            {
                
                quantite = 0;
                prix = 0;
                quantite = Convert.ToInt32(Quantite1.Value);
                totalcal = 0;
                
                prix = int.Parse(PrixProduit.Text);
               totalcal= quantite * prix;
                TotalPrix.Text =  totalcal.ToString();
               //foreach(DataGridViewRow row in ProduitGridview.Rows) {
               //     int qty = Convert.ToInt32(row.Cells[3].Value);
               //     if (qty >= 10)
               //     {
               //         MessageBox.Show("la quantité entrer ne peux pas etre supprieur a la quantité en stock", "stock info", MessageBoxButtons.OK,MessageBoxIcon.Error) ;
               //     }
                
                
               // }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
           
            //if (Quantite.Text.Length > 2)
            //{
            //    ValeurQte.Text = "la quantité ne peut pas etre 0";
            //    errorQuantite.SetError(this.ValeurQte, "la quanté ne peut pas etre null");
            //}

        }
        
        private void ProduitGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          Idproduit.Text = ProduitGridview.SelectedRows[0].Cells[0].Value.ToString();
                 Nomproduit.Text = ProduitGridview.SelectedRows[0].Cells[1].Value.ToString();
        //   Quantite.Text = ProduitGridview.SelectedRows[0].Cells[2].Value.ToString();
            PrixProduit.Text = ProduitGridview.SelectedRows[0].Cells[4].Value.ToString();
           // CategorieProuits.SelectedItem = ProduitGridview.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void AjouterFacture_Click(object sender, EventArgs e)
        {
            if (Nomproduit.Text == "" || PrixProduit.Text=="")
            {
                MessageBox.Show("veiiler renseigner le nom produit et le prix", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FactureBox.AppendText(Environment.NewLine);
                string dateJour = DateTime.Now.ToString();
                FactureBox.AppendText("\t\t       Appbox Management\t\t" + "\n" + Environment.NewLine);
                FactureBox.AppendText("\t\t date:  " + dateJour + "\n" + Environment.NewLine);

                NomProduitVendu.Text = Nomproduit.Text;
                PrixProuitVendu.Text = PrixProduit.Text;
                QuantiteProduitVendu.Text = Quantite1.Value.ToString();
                TotalProduitVendu.Text = TotalPrix.Text;
                NomClientFacture.Text = NomClient.Text;
                FactureBox.AppendText("\t\tNom Produit :\t\t" + NomProduitVendu.Text + "\n" + Environment.NewLine);
                FactureBox.AppendText("\t\tPrix unitaire :\t\t" + PrixProuitVendu.Text + "FcFa" + "\n" + Environment.NewLine);
                FactureBox.AppendText("\t\t Quantité du produit acheter :\t" + QuantiteProduitVendu.Text + "\n" + Environment.NewLine);
                FactureBox.AppendText("\t\tPrix Total :\t\t" + TotalProduitVendu.Text + "FcFa" + Environment.NewLine);
                FactureBox.AppendText("\t\tNom de l'acheteur : " + NomClient.Text + Environment.NewLine);

            }

        }
        private void EffacerChamps()
        {
            NomProduitVendu.Text = ""; 
            Nomproduit.Text="";
            PrixProuitVendu.Text = "";
            PrixProduit.Text="";
            QuantiteProduitVendu.Text = ""; 
            Quantite1.ResetText();
            TotalProduitVendu.Text = ""; 
            TotalPrix.Text="";
            NomClientFacture.Text = "";
            NomClient.Text="";
            FactureBox.Clear();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AjouterCaisse_Click(object sender, EventArgs e)
        {
            string dateJour = DateTime.Now.ToShortDateString();

            int quantiterVendu=int.Parse(QuantiteProduitVendu.Text);
            int totqlVendu= int.Parse(TotalProduitVendu.Text);
            int id =int.Parse(Idproduit.Text);
            try
            {
             
                string Requete = @"INSERT INTO Caisse(NomProuit,Quantite_Vendu,Prix_Unitaire,Total_vendu,Nom_Acheteur,Date_Vendu) VALUES
                     ('" + NomProduitVendu.Text + "' ,'" + Convert.ToInt32(QuantiteProduitVendu.Text) + "','" + Convert.ToInt32(PrixProuitVendu.Text) + "','" + Convert.ToInt32(TotalProduitVendu.Text) + "','" + NomClient.Text + "','" + dateJour + "')";
                Connection.Open();
                SqlCommand sqlCommand = new SqlCommand(Requete,Connection) ; 
                sqlCommand.ExecuteNonQuery();

                string RequeteUpdate = $"UPDATE Produit SET Quatite_disponble=Quatite_disponble - {quantiterVendu} , Prix_Total=Prix_Total - {totqlVendu} WHERE IdProduit='" + id + "'";
                SqlCommand command = new SqlCommand(RequeteUpdate, Connection);
                command.ExecuteNonQuery();

                //string RequeteUpdate1 = $"UPDATE Produit SET Quatite_disponble=Quatite_disponble - {quantiterVendu} WHERE IdProduit='" + id + "'";
                //SqlCommand command1 = new SqlCommand(RequeteUpdate, Connection);
                //command.ExecuteNonQuery();

                Connection.Close();
           
                MessageBox.Show("Ajout a la caisse avec succes","ajout" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                AfficherProduit();
                EffacerChamps();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("         " + FactureBox.Text , new Font("Centuty Gothic", 15, FontStyle.Regular), Brushes.Black, new Point(10));
        }

        private void Imprimer_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void ProduitGridview_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ( e.ColumnIndex == 2 || e.ColumnIndex == 3   & e.Value != null)
            {
                 int stockProduit = Convert.ToInt32(e.Value);
                if (stockProduit < 5)
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
                else
                {
                    e.CellStyle.BackColor = Color.White;
                    e.CellStyle.ForeColor = Color.Black;
                }
                if (stockProduit == 0)
                {
                    Quantite1.Enabled = false;
                    stockMessage.Text = "le stock est epuisé";
                    errorProvider.SetError(this.stockMessage, "le stock est epuisé");
                }
                else
                {
                    Quantite1.Enabled = true;
                    stockMessage.Text = "";
                    errorProvider.Clear();
                }



            }
        }

        private void Effacer_Click(object sender, EventArgs e)
        {
            EffacerChamps();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void NomProduitVendu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
