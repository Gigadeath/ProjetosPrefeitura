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
    public partial class Alteracao_TotalServico : MaterialForm
    {
        TotalServico tos = new TotalServico();
        TotalServicoController tosc = new TotalServicoController();
        int id = 0,OS_Id=0;
        public Alteracao_TotalServico(int codigo)
        {
            InitializeComponent();
            var dados = tosc.GetDados(codigo);
            id = codigo;
            OS_Id = dados.OS_id;
            mtxtHoras.Text = Convert.ToString(dados.totalHoras);
            mtxtDataLimite.Text = Convert.ToString(dados.DataLimite);
            var verificaOS = tosc.VerificaPrioridade(codigo);
            if (verificaOS.Prioridade_Id==1)
            {
                mtxtDataLimite.Enabled = false;
                
            }
            else
            {
                mtxtDataLimite.Enabled = true;
               
                
            }

            if(verificaOS.Servico=="Garantia")
            {
                mtxtHoras.Enabled = false;
            }
            else
            {
                mtxtHoras.Enabled = true;
            }

        }

        private void mbtnAlterar_Click(object sender, EventArgs e)
        {
            TotalServicoController tosc = new TotalServicoController();

            tos.id = id;
            tos.OS_id = OS_Id;
            tos.totalHoras = Convert.ToInt32(mtxtHoras.Text);
            tos.DataLimite = Convert.ToDateTime(mtxtDataLimite.Text);

            tosc.trataRequisicao("Alterar", tos);
            this.Close();
        }
    }
}
