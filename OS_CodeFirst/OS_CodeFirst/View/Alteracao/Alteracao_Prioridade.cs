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
    public partial class Alteracao_Prioridade : MaterialForm
    {
        Prioridade pri = new Prioridade();
        PrioridadeController pric = new PrioridadeController();
        int id = 0;

        public Alteracao_Prioridade(int codigo)
        {
            InitializeComponent();
            var dados = pric.getDados(codigo);
            id = dados.Id;
            txtNivel.Text = dados.Nivel;
            if(dados.status==true)
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
            PrioridadeController pric = new PrioridadeController();
            pri.Id = id;
            pri.Nivel = txtNivel.Text;

            if(cmbStatus.Text=="Ativo")
            {
                pri.status = true;
            }
            else
            {
                pri.status = false;
            }

            pric.trataRequisicao(btnSalvar.Text, pri);

        }
    }
}
