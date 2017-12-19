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

namespace OS_CodeFirst.View.Cadastro
{
    public partial class Cadastro_DepxFun : MaterialForm
    {
        public Cadastro_DepxFun()
        {
            InitializeComponent();
        }

        private void Cadastro_DepxFun_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'departamentoDataSet.departamento'. Você pode movê-la ou removê-la conforme necessário.
            this.departamentoTableAdapter.Fill(this.departamentoDataSet.departamento);
            // TODO: esta linha de código carrega dados na tabela 'ordemservicoDataSet.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.ordemservicoDataSet.funcionario);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Dep_Func df = new Dep_Func();
            DepFuncController dfc = new DepFuncController();

            df.Funcionario_Id = Convert.ToInt32(cmbFuncionario.SelectedValue);
            df.Departamento_Id = Convert.ToInt32(cmbSetor.SelectedValue);

            dfc.trataRequisicao(btnSalvar.Text, df);
        }
    }
}
