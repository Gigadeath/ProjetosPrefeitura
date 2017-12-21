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

namespace OS_CodeFirst.View
{
    public partial class Geracao_Aceite : MaterialForm
    {
        OSController osc = new OSController();
        public Geracao_Aceite()
        {
            InitializeComponent();
        }

        private void Geracao_Aceite_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'consulta_Aceite.Aceite'. Você pode movê-la ou removê-la conforme necessário.
            this.aceiteTableAdapter.Fill(this.consulta_Aceite.Aceite);
            // TODO: esta linha de código carrega dados na tabela 'oS__Ativas_Atrasadas.Consulta_UltimoStatus'. Você pode movê-la ou removê-la conforme necessário.
            this.consulta_UltimoStatusTableAdapter.Fill(this.oS__Ativas_Atrasadas.Consulta_UltimoStatus);

        }

        private void MbtnGerar_Click(object sender, EventArgs e)
        {
            osc.MontaAceite(Convert.ToInt32(cmbOS.SelectedValue));
            this.Close();
        }
    }
}
