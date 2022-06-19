using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBoxManagement.Views;

namespace AppBoxManagement
{
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();
        }
        //pourcharger les autres formulaires dans le mainpanel

        public void LoadForm(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
                   Form formulaire = Form as Form;
            formulaire.TopLevel = false;
            formulaire.Dock=DockStyle.Fill;
            this.MainPanel.Controls.Add(formulaire);
            this.MainPanel.Tag=formulaire;
            formulaire.Show();
        
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
           Application.Exit();
            
        }

        private void BtnMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnDashbord_Click(object sender, EventArgs e)
        {
            LoadForm(new Dashbord());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadForm(new Formisseur());
        }
    }
}
