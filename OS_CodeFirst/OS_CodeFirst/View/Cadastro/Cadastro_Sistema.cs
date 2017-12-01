using OS_CodeFirst.Controller;
using OS_CodeFirst.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_CodeFirst.View
{
    public partial class Cadastro_Sistema : Form
    {
        public Cadastro_Sistema()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Sistema sis = new Sistema();
            SistemaController siscon = new SistemaController();

            sis.Nome = txtSistema.Text;
            sis.Numero_OS = mtxtNumero.Text;

            siscon.trataRequisicao(btnSalvar.Text, sis);
        }
    }
}
