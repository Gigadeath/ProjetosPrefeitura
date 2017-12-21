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
using OS_CodeFirst.Controller;
using OS_CodeFirst.Model;

namespace OS_CodeFirst.View
{
    public partial class Alteracao_TipoServico : MaterialForm
    {
        TipoServico ts = new TipoServico();
        TipoServicoController tsc = new TipoServicoController();
        int id = 0;
        public Alteracao_TipoServico(int codigo)
        {
            InitializeComponent();
            id = codigo;
            var dados = tsc.getDados(codigo);
            txtServico.Text = dados.Nome;
            if (dados.status==true)
            {
                cmbStatus.Text = "Ativo";
            }
            else
            {
                cmbStatus.Text = "Inativo";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TipoServicoController tsc = new TipoServicoController();
            ts.Id = id;
            ts.Nome = txtServico.Text;
            
            if (cmbStatus.Text=="Ativo")
            {
                ts.status = true;
            }
            else
            {
                ts.status = false;
            }

            tsc.trataRequisicao(btnSalvar.Text, ts);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
