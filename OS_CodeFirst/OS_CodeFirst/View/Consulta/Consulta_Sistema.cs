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
    public partial class Consulta_Sistema : MaterialForm
    {
        public Consulta_Sistema()
        {
            InitializeComponent();
        }

        private void Consulta_Sistema_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaSet.sistema'. Você pode movê-la ou removê-la conforme necessário.
            this.sistemaTableAdapter.Fill(this.sistemaSet.sistema);

        }

        private void txtSistema_TextChanged(object sender, EventArgs e)
        {
            FiltraSis();

        }

        private void FiltraSis()
        {
            sistemaBindingSource.Filter = "";
            if (txtSistema.Text != "")
            {
                sistemaBindingSource.Filter = "Nome Like '%" + txtSistema.Text + "%'";
            }
        }
    }
}
