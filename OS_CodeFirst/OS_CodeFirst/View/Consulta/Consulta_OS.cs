using OS_CodeFirst.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace OS_CodeFirst.View
{
    public partial class Consulta_OS : Form
    {
        public Consulta_OS()
        {
            InitializeComponent();
        }

        private void Consulta_StatusOS_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'oSSet.os'. Você pode movê-la ou removê-la conforme necessário.
            this.osTableAdapter.Fill(this.oSSet.os);
            // TODO: esta linha de código carrega dados na tabela 'sistemaSet.sistema'. Você pode movê-la ou removê-la conforme necessário.
            this.sistemaTableAdapter.Fill(this.sistemaSet.sistema);
            // TODO: esta linha de código carrega dados na tabela 'oSSet.os'. Você pode movê-la ou removê-la conforme necessário.
            this.osTableAdapter.Fill(this.oSSet.os);
            // TODO: esta linha de código carrega dados na tabela 'oSSet.os'. Você pode movê-la ou removê-la conforme necessário.
            this.osTableAdapter.Fill(this.oSSet.os);


        }

        private void statusosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mtxtOS_TextChanged(object sender, EventArgs e)
        {
            FiltraOS();
        }

        private void FiltraOS()
        {
            try
            {


                osBindingSource.Filter = "";
                string DE = " ", DP = " ", DEN = " ",OST="",SIS="";
                int count = 0;
                if (mtxtDataEmis.Text == null && mtxtPrevista.Text == null && mtxtEntregue == null && mtxtOS.Text == null)
                {
                    osBindingSource.Filter = "";

                }
                else if (mtxtDataEmis.Text != null && mtxtPrevista.Text != null && mtxtEntregue != null && mtxtOS.Text != null)
                {
                    if (mtxtDataEmis.Text.Replace("/", "").Trim().Length == 8)
                    {
                        if (mtxtDataEmis.Text != "")
                        {
                            DE = "DataEmissao ='" + string.Format("{0:yyyy/MM/dd}", mtxtDataEmis.Text) + "'";
                            osBindingSource.Filter += DE;
                            count++;

                        }
                    }


                    if (mtxtPrevista.Text.Replace("/", "").Trim().Length == 8)
                    {
                        if (mtxtPrevista.Text != "")
                        {
                            if (count > 0)
                            {
                                DP = " And DataPrevista ='" + string.Format("{0:yyyy/MM/dd}", mtxtPrevista.Text) + "'";
                                osBindingSource.Filter += DP;
                                count++;
                            }
                            else
                            {
                                DP = "DataPrevista = '" + string.Format("{0:yyyy/MM/dd}", mtxtPrevista.Text) + "'";
                                osBindingSource.Filter += DP;
                                count++;
                            }

                        }
                    }


                    if (mtxtEntregue.Text.Replace("/", "").Trim().Length == 8)
                    {

            

                        if (mtxtEntregue.Text != "")
                        { 
                            if (count > 0)
                            {
                                DEN = " And DataEntregue='" + string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(mtxtEntregue.Text)) + "'";
                                osBindingSource.Filter += DEN;
                                count++;
                            }
                            else
                            {
                                DEN = "DataEntregue ='" + string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(mtxtEntregue.Text)) + "'";
                                osBindingSource.Filter += DEN;
                                count++;
                            }
                        }
                    }
                    if (mtxtOS.Text.Replace("-", "").Replace("/", "").Trim().Length == 11)
                    {
                        if (mtxtOS.Text != "")
                        {
                            if (count > 0)
                            {
                                OST = " And OSN = '" + mtxtOS.Text + "'";
                                osBindingSource.Filter += OST;
                                count++;
                            }
                            else
                            {
                                OST = "OSN = '" + mtxtOS.Text + "'";
                                osBindingSource.Filter += OST;
                                count++;
                            }
                        }
                    }

                    if (cmbSistema.SelectedValue != null)
                    {
                        if (count > 0)
                        {
                            SIS = " And Sistema_Id=" + cmbSistema.SelectedValue + "";
                            osBindingSource.Filter += SIS;
                            count++;
                        }
                        else
                        {
                            SIS = "Sistema_Id=" + cmbSistema.SelectedValue + "";
                            osBindingSource.Filter += SIS;
                            count++;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO!!! -" + e);
            }



        }

        private void mtxtDataEmis_TextChanged(object sender, EventArgs e)
        {
            FiltraOS();
        }

        private void mtxtPrevista_TextChanged(object sender, EventArgs e)
        {
            FiltraOS();
        }

        private void cmbSistema_TextChanged(object sender, EventArgs e)
        {
            FiltraOS();
        }

        private void mtxtEntregue_TextChanged(object sender, EventArgs e)
        {
            FiltraOS();
        }

        private void dgvOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOS_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(dgvOS.SelectedRows[0].Cells[0].Value.ToString());
                Alteracao_OS altOS = new Alteracao_OS(codigo);
                altOS.ShowDialog(this);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'oSSet.os'. Você pode movê-la ou removê-la conforme necessário.
            this.osTableAdapter.Fill(this.oSSet.os);
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            OSController osc = new OSController();
            osc.MontaOS(Convert.ToInt32(Convert.ToInt32(dgvOS.SelectedRows[0].Cells[0].Value.ToString())));
        }
    }
}
