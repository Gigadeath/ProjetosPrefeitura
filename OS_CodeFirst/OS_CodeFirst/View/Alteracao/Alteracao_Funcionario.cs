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
    public partial class Alteracao_Funcionario : MaterialForm
    {
        Funcionario fun = new Funcionario();
        FuncionarioController func = new FuncionarioController();
        int id=0;
        public Alteracao_Funcionario(int codigo)
        {
            InitializeComponent();
            var dados = func.getDados(codigo);
            id = codigo;
            mtxtRF.Text = dados.RF;
            txtNome.Text = dados.Nome;
            if (dados.status == true)
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
            FuncionarioController func = new FuncionarioController();
            fun.Id = id;
            MessageBox.Show(Convert.ToString(id));
            fun.RF = mtxtRF.Text;
            MessageBox.Show(fun.RF);
            fun.Nome = txtNome.Text;
            MessageBox.Show(fun.Nome);
            if (cmbStatus.Text == "Ativo")
            {
                MessageBox.Show("1");
                fun.status = true;
            }
            else
            {
                MessageBox.Show("2");
                fun.status = false;
            }

            

            func.trataRequisicao(btnSalvar.Text, fun);
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
