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
    public partial class Frm_CadastraOS : MaterialForm
    {
        OS osm = new OS();
        Sistema sis = new Sistema();
        SistemaController siscon = new SistemaController();
        ControleOS db = new ControleOS();
        OSController oscon = new OSController();
        StatusOS staOS = new StatusOS();
        StatusOS_Controller statCon = new StatusOS_Controller();
        TotalServico totServ = new TotalServico();
        TotalServicoController totServCon = new TotalServicoController();
        DepFuncController dfc = new DepFuncController(); 

        public Frm_CadastraOS()
        {
            InitializeComponent();
        }

        private void Cadastro_OS_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ordemservicoDataSet2.tiposervico'. Você pode movê-la ou removê-la conforme necessário.
            this.tiposervicoTableAdapter.Fill(this.ordemservicoDataSet2.tiposervico);
            // TODO: esta linha de código carrega dados na tabela 'ordemservicoDataSet1.prioridade'. Você pode movê-la ou removê-la conforme necessário.
            this.prioridadeTableAdapter.Fill(this.ordemservicoDataSet1.prioridade);
            // TODO: esta linha de código carrega dados na tabela 'ordemservicoDataSet.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.ordemservicoDataSet.funcionario);
            // TODO: esta linha de código carrega dados na tabela 'sistemaSet.sistema'. Você pode movê-la ou removê-la conforme necessário.
            this.sistemaTableAdapter.Fill(this.sistemaSet.sistema);



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mtxtOS_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblOS_Click(object sender, EventArgs e)
        {

        }

        private void cmbSistema_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSistema_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblPA_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (mtxtPrev.Text.Replace("/", "").Trim().Length == 8 && mtxtDataEmissao.Text.Replace("/", "").Trim().Length == 8 && txtSolicitacao.Text !="") 
            {
                OS osm = new OS();
               // MessageBox.Show(mtxtEntregue.Text);
                OSController osc = new OSController();
                try
                {
                    osm.OSN = mtxtOS.Text;
                    osm.Sistema_Id = Convert.ToInt32(cmbSistema.SelectedValue);
                    osm.PA = mtxtPA.Text;
                    osm.TC = mtxtTC.Text;
                    osm.DataEmissao = Convert.ToDateTime(mtxtDataEmissao.Text);
                    osm.Funcionario_Id = Convert.ToInt32(cmbResp.SelectedValue);
                    osm.Prioridade_Id = Convert.ToInt32(cmbPrioridade.SelectedValue);
                    osm.TipoServico_Id = Convert.ToInt32(cmbTipo.SelectedValue);
                    osm.ItemContratual = txtItem.Text;
                    osm.Servico = cmbServico.Text;
                    osm.DataPrevista = Convert.ToDateTime(mtxtPrev.Text);
                    osm.Departamento_Id = dfc.LastDepartamento(osm.Funcionario_Id).Departamento_Id;
                    if (mtxtEntregue.Text.Replace("/", "").Trim().Length == 8)
                    {
                        osm.DataEntregue = Convert.ToDateTime(mtxtEntregue.Text);

                    }
                    else
                    {
                        osm.DataEntregue = DateTime.MinValue;
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erro: " + exception);
                }
                osm.Solicitacao = txtSolicitacao.Text;
                osc.trataRequisicao(btnSalvar.Text, osm);

                staOS.Descricao = "Ordem de Serviço Gerada";
                staOS.OS_Id = oscon.getUltimaOS(Convert.ToInt32(cmbSistema.SelectedValue), osm);
                staOS.Status_Id = 1;
                staOS.dataAlteracao = DateTime.Now;
                statCon.trataRequisicao(btnSalvar.Text, staOS);


                if (mtxtEntregue.Text.Replace("/", "").Trim().Length == 8)
                {
                    if (Convert.ToDateTime(mtxtEntregue.Text) >= Convert.ToDateTime(mtxtDataEmissao.Text))
                    {
                        staOS.Descricao = "Ordem de Serviço Encerrada";
                        staOS.OS_Id = oscon.getUltimaOS(Convert.ToInt32(cmbSistema.SelectedValue), osm);
                        staOS.Status_Id = 7;
                        staOS.dataAlteracao = DateTime.Now;
                        statCon.trataRequisicao(btnSalvar.Text, staOS);
                    }

                }

                if (Convert.ToInt32(cmbPrioridade.SelectedValue) == 1)
                {
                    if (DateTime.Now.DayOfWeek.ToString().Equals("Monday") || DateTime.Now.DayOfWeek.ToString().Equals("Tuesday"))
                    {
                        totServ.DataLimite = DateTime.Now.AddDays(3);
                    }
                    else
                    {
                        totServ.DataLimite = DateTime.Now.AddDays(5);
                    }
                }
                else
                {
                    totServ.DataLimite = DateTime.MinValue;
                    MessageBox.Show("Preencher data limite na tela de Entrega Prodam", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                totServ.totalHoras = 0;
                totServ.OS_id = oscon.getUltimaOS(Convert.ToInt32(cmbSistema.SelectedValue), osm);
                totServCon.trataRequisicao("Cadastrar", totServ);
            }
            else
            {

                MessageBox.Show("Verifique a data de Emissão e a data de Previsão", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();

        }

        private void cmbSistema_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void cmbSistema_SelectedValueChanged(object sender, EventArgs e)
        {

            GeraOS();
            
        }

        private void GeraOS()
        {
            OS osm = new OS();
            string Nsis = siscon.getNumero_OS(Convert.ToInt32(cmbSistema.SelectedValue), sis, osm);
            
            //MessageBox.Show(Convert.ToString(cmbSistema.SelectedValue));
            if (Nsis.Equals(""))
            {

                string Numero = siscon.getNumeroSistema(Convert.ToInt32(cmbSistema.SelectedValue));
                mtxtOS.Text = Numero + "-" + "0001/" + DateTime.Now.Year;
            }
            else
            {
                string[] osString = Nsis.Split('/');
                if (osString[1].ToString() == Convert.ToString(DateTime.Now.Year))
                {
                    string[] osStringFinal = osString[0].Split('-');
                    int osAtual = Convert.ToInt32(osStringFinal[1].ToString()) + 1;
                    string delimitador = Convert.ToString(osAtual).PadLeft(4, '0');
                    mtxtOS.Text = osStringFinal[0] + "-" + delimitador + '/' + DateTime.Now.Year;
                }
                else
                {
                    string Numero = siscon.getNumeroSistema(Convert.ToInt32(cmbSistema.SelectedValue));
                    mtxtOS.Text = Numero + "-" + "0001/" + DateTime.Now.Year;
                }
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
