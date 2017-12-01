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
    public partial class Consulta_Status : Form
    {
        public Consulta_Status()
        {
            InitializeComponent();
        }

        private void Consulta_Status_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'statusSet.status'. Você pode movê-la ou removê-la conforme necessário.
           // this.statusTableAdapter.Fill(this.statusSet.status);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            FiltraStatus();
        }

        private void FiltraStatus()
        {
           statusBindingSource.Filter = "";
            if (txtStatus.Text != "")
            {
                statusBindingSource.Filter = "Nome Like '%" + txtStatus.Text + "%'";
            }
        }
    }
}
