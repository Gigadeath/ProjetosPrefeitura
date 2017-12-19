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
using OS_CodeFirst.BD;
using OS_CodeFirst.Model;
using OS_CodeFirst.Controller;
using OS_CodeFirst.View.Cadastro;
using MaterialSkin;
using MaterialSkin.Controls;

namespace OS_CodeFirst
{
    public partial class FrmInicial : MaterialForm
    {
        public FrmInicial()
        {
            InitializeComponent();
            TimeSpan diff = DateTime.Now - DateTime.Now;
            int conta = 0; int index = 0;
            var item = consulta_UltimoStatusTableAdapter.GetDataBy().ToList();
            int aux = 60;
            var label = new Label();
            label.Text = "Ordens de Serviços Atrasadas";
            label.Size = new Size(196, 13);
            label.Location = new Point(0,0);
            label.Font = new Font(label.Font, FontStyle.Underline);
            pnlOS.Controls.Add(label);

            label = new Label();
            label.Text = "OS em Aberto";
            label.Size = new Size(196, 13);
            label.Location = new Point(0, 22);
            pnlOS.Controls.Add(label);

            if (item.Count > 0)
            {
                
                for (index = 0; index < item.Count; index++)
                {

                    label = new Label();
                    label.Text = item.ElementAt(index).OSN;
                    label.Location = new Point(23, aux);
                    label.DoubleClick += new EventHandler(redirect);
                    label.MouseUp += new MouseEventHandler(nohover);
                    label.MouseDown += new MouseEventHandler(nohover);
                    label.MouseMove += new MouseEventHandler(hover);
                    label.ForeColor = Color.DarkBlue;
                    aux += 22;
                    pnlOS.Controls.Add(label);

                }
            }else
            {
                label = new Label();
                label.Text = "Nenhuma OS pendente";
                label.Location = new Point(30, aux);
                label.Size = new Size(140, 13);
                label.ForeColor = Color.Red;
                pnlOS.Controls.Add(label);
                aux += 50;
            }

            label = new Label();
            label.Text = "OS com estimativa pendente";
            label.Size = new Size(196,13);
            label.Location = new Point(0, aux);
            aux += 22;
            pnlOS.Controls.Add(label);
            OSController osc = new OSController();
            var estimativa = consulta_UltimoStatusTableAdapter.GetEstimativa().ToList();

            if (estimativa.Count() > 0)
            {
                foreach (var obj in estimativa)
                {
                    diff = osc.GetDataAtt(obj.ID);
                    conta = osc.ContaOS(obj.ID);
                    if (conta > 0)
                    {

                        if (conta > 1)
                        {

                            if (!DateTime.Now.DayOfWeek.Equals("Friday"))
                            {
                                if (diff.Days > 2)
                                {
                                    label = new Label();
                                    label.Text = osc.getDados(obj.ID).OSN;
                                    label.Location = new Point(23, aux);
                                    label.DoubleClick += new EventHandler(redirect);
                                    label.MouseUp += new MouseEventHandler(nohover);
                                    label.MouseDown += new MouseEventHandler(nohover);
                                    label.MouseMove += new MouseEventHandler(hover);
                                    label.ForeColor = Color.DarkBlue;
                                    aux += 22;
                                    pnlOS.Controls.Add(label);
                                }
                            }
                            else
                            {
                                if (diff.Days > 4)
                                {
                                    label = new Label();
                                    label.Text = osc.getDados(obj.ID).OSN;
                                    label.Location = new Point(23, aux);
                                    label.DoubleClick += new EventHandler(redirect);
                                    label.MouseUp += new MouseEventHandler(nohover);
                                    label.MouseDown += new MouseEventHandler(nohover);
                                    label.MouseMove += new MouseEventHandler(hover);
                                    label.ForeColor = Color.DarkBlue;
                                    aux += 22;
                                    pnlOS.Controls.Add(label);
                                }
                            }
                        }
                        else
                        {
                            if (DateTime.Now.DayOfWeek.Equals("Monday") || DateTime.Now.DayOfWeek.Equals("Tuesday"))
                            {
                                if (diff.Days > 4)
                                {
                                    label = new Label();
                                    label.Text = osc.getDados(obj.ID).OSN;
                                    label.Location = new Point(23, aux);
                                    label.DoubleClick += new EventHandler(redirect);
                                    label.MouseUp += new MouseEventHandler(nohover);
                                    label.MouseDown += new MouseEventHandler(nohover);
                                    label.MouseMove += new MouseEventHandler(hover);
                                    label.ForeColor = Color.DarkBlue;
                                    aux += 22;
                                    pnlOS.Controls.Add(label);
                                }

                            }
                            else
                            {
                                if (diff.Days > 6)
                                {
                                    label = new Label();
                                    label.Text = osc.getDados(obj.ID).OSN;
                                    label.Location = new Point(23, aux);
                                    label.DoubleClick += new EventHandler(redirect);
                                    label.MouseUp += new MouseEventHandler(nohover);
                                    label.MouseDown += new MouseEventHandler(nohover);
                                    label.MouseMove += new MouseEventHandler(hover);
                                    label.ForeColor = Color.DarkBlue;
                                    aux += 22;
                                    pnlOS.Controls.Add(label);
                                }

                            }


                        }
                    }

                }
            }
            else
            {
                label = new Label();
                label.Text = "Nenhuma OS pendente";
                label.Location = new Point(30, aux);
                label.Size = new Size(140, 13);
                label.ForeColor = Color.Red;
                pnlOS.Controls.Add(label);
                aux += 50;
            }
            label = new Label();
            label.Text = "OS com data Limite atrasada";
            label.Size = new Size(196, 13);
            label.Location = new Point(0, aux);
            aux += 22;
            pnlOS.Controls.Add(label);
            var desenvolvimento = consulta_UltimoStatusTableAdapter.GetEstimativa().ToList();
            if (desenvolvimento.Count()>0)
            {
                foreach (var obj in desenvolvimento)
                {
                    label = new Label();
                    label.Text = osc.getDados(obj.ID).OSN;
                    label.Location = new Point(23, aux);
                    label.DoubleClick += new EventHandler(redirect);
                    label.MouseUp += new MouseEventHandler(nohover);
                    label.MouseDown += new MouseEventHandler(nohover);
                    label.MouseMove += new MouseEventHandler(hover);
                    label.ForeColor = Color.DarkBlue;
                    aux += 22;
                    pnlOS.Controls.Add(label);
                }
            }
            else
            {
                label = new Label();
                label.Text = "Nenhuma OS pendente";
                label.Location = new Point(30, aux);
                label.Size = new Size(140, 13);
                label.ForeColor = Color.Red;
                pnlOS.Controls.Add(label);
                aux += 50;
            }
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
            cadOS.ShowDialog();
                        



        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Funcionario cadfunc = new Cadastro_Funcionario();
            cadfunc.ShowDialog();
        }

        private void prioridadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Prioridade pri = new Cadastro_Prioridade();
            pri.ShowDialog();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Sistema cadsis = new Cadastro_Sistema();
            cadsis.ShowDialog();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tela desabilitada ,para cadastro de Status solicite ao GTIC","Atenção",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tipoDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_TipoServico cadts = new Cadastro_TipoServico();
            cadts.ShowDialog();
        }

        private void funcionariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_Funcionario func = new Consulta_Funcionario();
            func.ShowDialog();
        }

        private void prioridadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_Prioridade prior = new Consulta_Prioridade();
            prior.ShowDialog();
        }

        private void sistemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_Sistema sis = new Consulta_Sistema();
            sis.ShowDialog();
        }

        private void statusToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_Status status = new Consulta_Status();
            status.ShowDialog();
        }

        private void tipoDeServiçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta_TipoServico tpc = new Consulta_TipoServico();
            tpc.ShowDialog();
        }

        private void statusDaOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_StatusOS conStatus = new Consulta_StatusOS(null);
            conStatus.ShowDialog();
        }

        private void oSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_OS conOS = new Consulta_OS();
            conOS.ShowDialog();
        }

        private void entregaProdamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_TotalServico contToOs = new Consulta_TotalServico();
            contToOs.ShowDialog();
        }

        private void geraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void oSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Geracao_OS genOs = new Geracao_OS();
            genOs.ShowDialog();
        }

       
        private void redirect(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            Consulta_StatusOS staOS = new Consulta_StatusOS(clickedLabel.Text);
            staOS.ShowDialog();
        }
        private void hover(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            clickedLabel.Font= new Font(clickedLabel.Font,FontStyle.Underline);
        }
        private void nohover(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            clickedLabel.Font = new Font(clickedLabel.Font, FontStyle.Regular);
        }

        private void lblLegenda_Click(object sender, EventArgs e)
        {

        }

        private void pnlOS_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Departamento cadDep = new Cadastro_Departamento();
            cadDep.ShowDialog();
        }

        private void departamentoXFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_DepxFun cadDep = new Cadastro_DepxFun();
            cadDep.ShowDialog();
        }
    }
}
