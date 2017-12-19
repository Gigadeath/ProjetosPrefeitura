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
    public partial class Alteracao_OS : MaterialForm
    {
        OS osm = new OS();
        OSController osc = new OSController();
        StatusOS statOS = new StatusOS();
        StatusOS_Controller statcon = new StatusOS_Controller();
        int id = 0,departamento=0;
        public Alteracao_OS(int codigo)
        {
            try
            {
                InitializeComponent();
                // TODO: esta linha de código carrega dados na tabela 'tipoServicoDataSet.tiposervico'. Você pode movê-la ou removê-la conforme necessário.
                this.tiposervicoTableAdapter.Fill(this.tipoServicoDataSet.tiposervico);
                // TODO: esta linha de código carrega dados na tabela 'ordemservicoDataSet1.prioridade'. Você pode movê-la ou removê-la conforme necessário.
                this.prioridadeTableAdapter.Fill(this.ordemservicoDataSet1.prioridade);
                // TODO: esta linha de código carrega dados na tabela 'ordemservicoDataSet.funcionario'. Você pode movê-la ou removê-la conforme necessário.
                this.funcionarioTableAdapter.Fill(this.ordemservicoDataSet.funcionario);
                // TODO: esta linha de código carrega dados na tabela 'sistemaSet.sistema'. Você pode movê-la ou removê-la conforme necessário.
                this.sistemaTableAdapter.Fill(this.sistemaSet.sistema);
                OSController oscon = new OSController();
                var dados = oscon.getDados(codigo);
                id = codigo;
                mtxtOS.Text = dados.OSN;
                cmbSistema.SelectedValue = dados.Sistema_Id;
                mtxtPA.Text = dados.PA;
                mtxtTC.Text = dados.TC;
                mtxtDataEmissao.Text = string.Format("{0:dd/MM/yyyy}", dados.DataEmissao);
                cmbResp.SelectedValue = dados.Funcionario_Id;
                cmbPrioridade.SelectedValue = dados.Prioridade_Id;
                cmbTipo.SelectedValue = dados.TipoServico_Id;
                txtItem.Text = dados.ItemContratual;
                cmbServico.Text = dados.Servico;
                mtxtPrev.Text = string.Format("{0:dd/MM/yyyy}", dados.DataPrevista);
                mtxtEntregue.Text = string.Format("{0:dd/MM/yyyy}", dados.DataEntregue);
                departamento = dados.Departamento_Id;
                txtSolicitacao.Text = dados.Solicitacao;
            }catch(Exception ex)
            {
                MessageBox.Show("Erro: " +ex);
            }
        }
        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            StatusOS_Controller statcon = new StatusOS_Controller();
            if (statcon.verificaOS(id) == true)
            {
                osm.OSN = mtxtOS.Text;
                osm.Id = id;
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
                osm.DataEntregue = Convert.ToDateTime(mtxtEntregue.Text);
                osm.Solicitacao = txtSolicitacao.Text;
                osm.Departamento_Id = departamento;
                osc.trataRequisicao(btnSalvar.Text, osm);
                if (mtxtEntregue.Text != "01/01/0001")
                {
                    statOS.Descricao = "Ordem de Serviço Encerrada";
                    statOS.OS_Id = id;
                    statOS.Status_Id = 7;
                    statOS.dataAlteracao = DateTime.Now;
                    statcon.trataRequisicao("Cadastrar", statOS);
                }

                this.Close();
                
              
            }

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void Alteracao_OS_Load(object sender, EventArgs e)
        {
            

        }
    }
}
