using MySql.Data.MySqlClient;
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
    public partial class Consulta_Funcionario : Form
    {

        public Consulta_Funcionario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ordemservicoDataSet.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.ordemservicoDataSet.funcionario);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtxtRF_TextChanged(object sender, EventArgs e)
        {
            FiltraFunc();
        }

        private void FiltraFunc()
        {
            try
            {


                funcionarioBindingSource.Filter = "";
                string QRF = " ", QNome = " ", Qsetor = " ";
                int count = 0;
                if (mtxtRF.Text == null && txtNome.Text == null && txtSetor == null)
                {
                    funcionarioBindingSource.Filter = "";
                    

                }
                else if (mtxtRF.Text != null || txtNome.Text != null || txtSetor.Text != null)
                {

                    if (mtxtRF.Text.Replace(" ", "") != "")
                    {
                        QRF = "RF Like '%" + mtxtRF.Text.Replace(".", "").Replace("-", "").Replace(" ", "") + "%'";
                        funcionarioBindingSource.Filter += QRF;
                        count++;

                    }
                    if (txtNome.Text != "")
                    {
                        if (count > 0)
                        {
                            QNome = " And Nome Like '%" + txtNome.Text + "%'";
                            funcionarioBindingSource.Filter += QNome;
                            count++;
                        }
                        else
                        {
                            QNome = "Nome Like '%" + txtNome.Text + "%'";
                            funcionarioBindingSource.Filter += QNome;
                            count++;
                        }

                    }
                    if (txtSetor.Text != "")
                    {
                        if (count > 0)
                        {
                            Qsetor = " And Setor Like '%" + txtSetor.Text + "%'";
                            funcionarioBindingSource.Filter += Qsetor;
                            count++;
                        }
                        else
                        {
                            Qsetor = "Setor Like '%" + txtSetor.Text + "%'";
                            funcionarioBindingSource.Filter += Qsetor;
                            count++;
                        }
                    }
                }
            }catch(Exception e)
            {
                MessageBox.Show("ERRO!!! -" + e);
            }
            


        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            FiltraFunc();
        }

        private void txtSetor_TextChanged(object sender, EventArgs e)
        {
            FiltraFunc();
        }

        private void ordemservicoDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

