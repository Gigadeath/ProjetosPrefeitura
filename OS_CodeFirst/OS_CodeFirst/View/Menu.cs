using OS_CodeFirst.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_CodeFirst
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
            
            
        }

        private void cadastroAlteraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreAjudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordemDeServicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastraOS cadOS = new Frm_CadastraOS();
            cadOS.Show();
                        



        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Funcionario cadfunc = new Cadastro_Funcionario();
            cadfunc.Show();
        }

        private void prioridadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Prioridade pri = new Cadastro_Prioridade();
            pri.Show();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Sistema cadsis = new Cadastro_Sistema();
            cadsis.Show();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tela desabilitada ,para cadastro de Status solicite ao GTIC","Atenção",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tipoDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_TipoServico cadts = new Cadastro_TipoServico();
            cadts.Show();
        }

        private void funcionariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_Funcionario func = new Consulta_Funcionario();
            func.Show();
        }

        private void prioridadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_Prioridade prior = new Consulta_Prioridade();
            prior.Show();
        }

        private void sistemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_Sistema sis = new Consulta_Sistema();
            sis.Show();
        }

        private void statusToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_Status status = new Consulta_Status();
            status.Show();
        }

        private void tipoDeServiçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_TipoServico tpc = new Consulta_TipoServico();
            tpc.Show();
        }

        private void statusDaOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_StatusOS conStatus = new Consulta_StatusOS();
            conStatus.ShowDialog();
        }

        private void oSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_OS conOS = new Consulta_OS();
            conOS.Show();
        }

        private void entregaProdamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_TotalServico contToOs = new Consulta_TotalServico();
            contToOs.ShowDialog();
        }
    }
}
