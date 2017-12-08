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
    public partial class Consulta_StatusOS : Form
    {
        public Consulta_StatusOS()
        {
            InitializeComponent();
        }

        private void Consulta_StatusOS_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ordemservicoDataSet4.statusos'. Você pode movê-la ou removê-la conforme necessário.
            this.statusosTableAdapter.Fill(this.ordemservicoDataSet4.statusos);

        }

        private void mtxtOS_TextChanged(object sender, EventArgs e)
        {
            FiltraStatusOS();
        }

        private void mtxtEmissao_TextChanged(object sender, EventArgs e)
        {
            FiltraStatusOS();
        }

        private void mtxtPrevista_TextChanged(object sender, EventArgs e)
        {
            FiltraStatusOS();
        }

        private void mtxtEntregue_TextChanged(object sender, EventArgs e)
        {
            FiltraStatusOS();
        }

        private void FiltraStatusOS()
        {
            try
            {


                statusosBindingSource.Filter = "";
                string DE = " ", DP = " ", DEN = " ", OST = "";
                int count = 0;
                if (mtxtDataEmis.Text == null && mtxtPrevista.Text == null && mtxtEntregue == null && mtxtOS.Text == null)
                {
                    statusosBindingSource.Filter = "";

                }
                else if (mtxtDataEmis.Text != null && mtxtPrevista.Text != null && mtxtEntregue != null && mtxtOS.Text != null)
                {
                    if (mtxtDataEmis.Text.Replace("/", "").Trim().Length == 8)
                    {
                        if (mtxtDataEmis.Text != "")
                        {
                            DE = "DataEmissao ='" + string.Format("{0:yyyy/MM/dd}", mtxtDataEmis.Text) + "'";
                            statusosBindingSource.Filter += DE;
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
                                statusosBindingSource.Filter += DP;
                                count++;
                            }
                            else
                            {
                                DP = "DataPrevista = '" + string.Format("{0:yyyy/MM/dd}", mtxtPrevista.Text) + "'";
                                statusosBindingSource.Filter += DP;
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
                                statusosBindingSource.Filter += DEN;
                                count++;
                            }
                            else
                            {
                                DEN = "DataEntregue ='" + string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(mtxtEntregue.Text)) + "'";
                                statusosBindingSource.Filter += DEN;
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
                                statusosBindingSource.Filter += OST;
                                count++;
                            }
                            else
                            {
                                OST = "OSN = '" + mtxtOS.Text + "'";
                                statusosBindingSource.Filter += OST;
                                count++;
                            }
                        }
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO!!! -" + e);
            }



        }

        private void dgvStatusOS_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int codigo = 0;
                codigo = Convert.ToInt32(dgvStatusOS.SelectedRows[0].Cells[0].Value.ToString());
                Alteracao_StatusOS altStatOS = new Alteracao_StatusOS(codigo);
                altStatOS.ShowDialog(this);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
        }
    }
}
