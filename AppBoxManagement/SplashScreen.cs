using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBoxManagement
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        int compteur=0;
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timerPourcentage.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
         
            PrograssBar.Width += 2;
            if(PrograssBar.Width >=745)
            {
                timer1.Stop();
                Login loginForm= new Login();
                loginForm.Show();
                this.Hide();
            }
        }

        private void timerPourcentage_Tick(object sender, EventArgs e)
        {
            compteur += 1;
            Pourcentage.Text = compteur + "%";
            if(compteur == 100)
            {
                timerPourcentage.Stop();
            }
        }
    }
}
