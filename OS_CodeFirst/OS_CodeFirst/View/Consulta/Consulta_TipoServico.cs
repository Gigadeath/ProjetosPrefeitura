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
    public partial class Consulta_TipoServico : Form
    {
        public Consulta_TipoServico()
        {
            InitializeComponent();
        }

        private void Consulta_TipoServico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tipoServicoDataSet.tiposervico'. Você pode movê-la ou removê-la conforme necessário.
            this.tiposervicoTableAdapter.Fill(this.tipoServicoDataSet.tiposervico);

        }

        private void txtTipoServico_TextChanged(object sender, EventArgs e)
        {
            FiltraTipoServico();
        }

        private void FiltraTipoServico()
        {
            tiposervicoBindingSource.Filter = "";
            if (txtTipoServico.Text != "")
            {
                tiposervicoBindingSource.Filter = "Nome Like '%" + txtTipoServico.Text + "%'";
            }
        }
    }
}
