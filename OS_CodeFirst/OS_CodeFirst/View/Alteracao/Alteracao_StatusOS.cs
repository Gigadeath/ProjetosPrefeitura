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
    public partial class Alteracao_StatusOS : Form
    {
        int Id, OS;
        StatusOS_Controller statcon = new StatusOS_Controller();
        public Alteracao_StatusOS(int codigo)
        {
            InitializeComponent();
            //this.statusTableAdapter.Fill(this.statusSet.status);
            statusBindingSource.Filter = "Id <> 1 And Id <> 7";
            var query=statcon.getDados(codigo);
            if (query.Status_Id==1 || query.Status_Id ==7)
            {
                cmbStatus.SelectedValue = 2;
            }
            else
            {
                cmbStatus.SelectedValue = query.Status_Id;
            }
            
            txtDescricao.Text = query.Descricao;
            Id = query.Id;
            OS = query.OS_Id;

        }

        private void Alteracao_StatusOS_Load(object sender, EventArgs e)
        {
           

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (statcon.verificaInsercao(Id) == true)
            {
                StatusOS stat = new StatusOS();
                stat.Id = Id;
                stat.Status_Id = Convert.ToInt32(cmbStatus.SelectedValue);
                stat.OS_Id = OS;
                stat.Descricao = txtDescricao.Text;
                stat.dataAlteracao = DateTime.Now;
                statcon.trataRequisicao(btnAlterar.Text, stat);
            }

        }
    }
}
