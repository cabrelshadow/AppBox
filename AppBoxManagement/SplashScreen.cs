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
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
          
            PrograssBar.Width += 3;
            if(PrograssBar.Width >=700)
            {
                timer1.Stop();
                Login loginForm= new Login();
                loginForm.Show();
                this.Hide();
            }
        }

      
    }
}
