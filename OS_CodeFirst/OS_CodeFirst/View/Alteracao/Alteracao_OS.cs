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
    public partial class Alteracao_OS : Form
    {
        OS osm = new OS();
        OSController osc = new OSController();
        StatusOS statOS = new StatusOS();
        StatusOS_Controller statcon = new StatusOS_Controller();
        int id = 0;
        public Alteracao_OS(int codigo)
        {
            try
            {
                InitializeComponent();
                OSController oscon = new OSController();
                var dados = oscon.getDados(codigo);
                id = codigo;
                mtxtOS.Text = dados.OSN;
                cmbSistema.SelectedValue = dados.Sistema_Id;
                mtxtPA.Text = dados.PA;
                mtxtTC.Text = dados.TC;
                mtxtDataEmissao.Text = string.Format("{0:dd/MM/yyyy}", dados.DataEmissao);
                cmbResp.SelectedValue= dados.Funcionario_Id;
                MessageBox.Show("Funcionario id:"+dados.Funcionario_Id + " Selecionado:" +cmbResp.SelectedValue+ ":"+ cmbResp.SelectedItem+":"+cmbResp.SelectedIndex);
                cmbPrioridade.SelectedValue = dados.Prioridade_Id;
                cmbTipo.SelectedValue = dados.TipoServico_Id;
                txtItem.Text = dados.ItemContratual;
                cmbServico.Text = dados.Servico;
                mtxtPrev.Text = string.Format("{0:dd/MM/yyyy}", dados.DataPrevista);
                mtxtEntregue.Text = string.Format("{0:dd/MM/yyyy}", dados.DataEntregue);
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
                osc.trataRequisicao(btnSalvar.Text, osm);
                if (mtxtEntregue.Text != "01/01/0001")
                {
                    statOS.Descricao = "Ordem de Serviço Encerrada";
                    statOS.OS_Id = id;
                    statOS.Status_Id = 7;
                    statOS.dataAlteracao = DateTime.Now;
                    statcon.trataRequisicao("Cadastrar", statOS);
                }
                   
                
                
              
            }

        }

        private void Alteracao_OS_Load(object sender, EventArgs e)
        {

        }
    }
}
