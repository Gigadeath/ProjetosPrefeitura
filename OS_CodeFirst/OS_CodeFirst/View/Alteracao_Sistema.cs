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
    public partial class Alteracao_Sistema : MaterialForm
    {
        Sistema sis = new Sistema();
        SistemaController sisc = new SistemaController();
        int id = 0;

        public Alteracao_Sistema(int codigo)
        {
            InitializeComponent();
            var dados = sisc.getDados(codigo);
            txtSistema.Text = dados.Nome;
            mtxtNumero.Text = dados.Numero_OS;
            id = codigo;

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
            SistemaController sisc = new SistemaController();
            sis.Id = id;
            sis.Nome = txtSistema.Text;
            sis.Numero_OS = mtxtNumero.Text;

            if(cmbStatus.Text=="Ativo")
            {
                sis.status = true;
            }
            else
            {
                sis.status = false;
            }

            sisc.trataRequisicao(btnSalvar.Text, sis);
        }
    }
}
