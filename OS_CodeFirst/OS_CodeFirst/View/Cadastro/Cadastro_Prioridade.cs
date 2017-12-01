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
    public partial class Cadastro_Prioridade : Form
    {
        public Cadastro_Prioridade()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Prioridade pri = new Prioridade();
            PrioridadeController pcon = new PrioridadeController();
            pri.Nivel = txtNivel.Text;
            pcon.trataRequisicao(btnSalvar.Text,pri);
        }
    }
}
