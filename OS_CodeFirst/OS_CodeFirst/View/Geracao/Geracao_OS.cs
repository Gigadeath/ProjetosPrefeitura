using OS_CodeFirst.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using Word = Microsoft.Office.Interop.Word;
using MaterialSkin;
using MaterialSkin.Controls;

namespace OS_CodeFirst.View
{
    public partial class Geracao_OS : MaterialForm
    {
        public Geracao_OS()
        {
            InitializeComponent();
        }

        private void Geracao_OS_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'oSSet.os'. Você pode movê-la ou removê-la conforme necessário.
            this.osTableAdapter.Fill(this.oSSet.os);

        }

        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            OSController osc = new OSController();
            osc.MontaOS(Convert.ToInt32(cmbOS.SelectedValue));
            this.Close();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
