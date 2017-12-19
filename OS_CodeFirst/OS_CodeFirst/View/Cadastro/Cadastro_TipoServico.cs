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
using MaterialSkin;
using MaterialSkin.Controls;

namespace OS_CodeFirst.View
{
    public partial class Cadastro_TipoServico : MaterialForm
    {
        public Cadastro_TipoServico()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TipoServico tis = new TipoServico();
            TipoServicoController tsc = new TipoServicoController();
            tis.Nome = txtServico.Text;
            tsc.trataRequisicao(btnSalvar.Text,tis);
        }
    }
}
