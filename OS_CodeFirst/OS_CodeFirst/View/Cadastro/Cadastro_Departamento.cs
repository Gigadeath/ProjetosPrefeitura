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

namespace OS_CodeFirst.View.Cadastro
{
    public partial class Cadastro_Departamento : Form
    {
        public Cadastro_Departamento()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Departamento dep = new Departamento();
            DepartamentoController depc = new DepartamentoController();

            dep.Setor = txtDepartamento.Text;
            depc.trataRequisicao(btnCadastrar.Text, dep);
        }
    }
}
