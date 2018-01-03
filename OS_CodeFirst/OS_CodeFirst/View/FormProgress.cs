using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace OS_CodeFirst.View
{
    public partial class FormProgress : MaterialForm
    {
        private Timer time = new Timer();
        FrmInicial ini = new FrmInicial();
        public FormProgress()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue700, Primary.Blue900,
                Primary.Blue700, Accent.LightBlue100,
                TextShade.WHITE
            ); 

            time.Interval = 100;
            time.Tick += new EventHandler(IncreaseProgressBar);
            // Start the timer.
            time.Start();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            pgbInicial.Increment(1);
        }
        private void IncreaseProgressBar(object sender, EventArgs e)
        {
            // Increment the value of the ProgressBar a value of one each time.
            pgbInicial.Increment(1);
            // Display the textual value of the ProgressBar in the StatusBar control's first panel.
            pgbInicial.Text = pgbInicial.Value.ToString() + "% Completed";
            // Determine if we have completed by comparing the value of the Value property to the Maximum value.
            if (pgbInicial.Value == pgbInicial.Maximum)
            {
                // Stop the timer.
                time.Stop();
                ini.Show();
                this.Owner = ini;
                this.Hide();
                MessageBox.Show(System.Windows.Forms.SystemInformation.UserName);
                MessageBox.Show(System.Windows.Forms.SystemInformation.UserDomainName);
                


            }
                
        }
    }
}
