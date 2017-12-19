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
    public partial class Consulta_Prioridade : MaterialForm
    {
        public Consulta_Prioridade()
        {
            InitializeComponent();
        }

        private void Consulta_Prioridade_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ordemservicoDataSet1.prioridade'. Você pode movê-la ou removê-la conforme necessário.
            this.prioridadeTableAdapter.Fill(this.ordemservicoDataSet1.prioridade);

        }

        private void txtPrioridade_TextChanged(object sender, EventArgs e)
        {
            FiltraPriori();
        }

        private void FiltraPriori()
        {
            prioridadeBindingSource.Filter = "";
            if (txtPrioridade.Text!="")
            {
                prioridadeBindingSource.Filter = "Nivel Like '%"+txtPrioridade.Text+"%'";
            }
        }
    }
}
