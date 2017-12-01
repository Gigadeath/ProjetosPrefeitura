﻿using System;
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
    public partial class Consulta_TotalServico : Form
    {
        public Consulta_TotalServico()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ordemservicoDataSet2.totalservico'. Você pode movê-la ou removê-la conforme necessário.
            //this.totalservicoTableAdapter.Fill(this.TotalServicoSet.totalservico);

        }

        private void mtxtOS_TextChanged(object sender, EventArgs e)
        {
            FiltraTotServ();
        }

        private void FiltraTotServ()
        {
            try
            {


                totalservicoBindingSource.Filter = "";
                string DE = " ", DP = " ", DEN = " ", OST = "", SIS = "";
                int count = 0;
                if (mtxtDataLimite.Text == null  && mtxtOS.Text == null)
                {
                    totalservicoBindingSource.Filter = "";

                }
                else if (mtxtDataLimite.Text != null && mtxtOS.Text != null)
                {
                    if (mtxtDataLimite.Text.Replace("/", "").Trim().Length == 8)
                    {
                        if (mtxtDataLimite.Text != "")
                        {
                            DE = "DataLimite ='" + string.Format("{0:yyyy/MM/dd}", mtxtDataLimite.Text) + "'";
                            totalservicoBindingSource.Filter += DE;
                            count++;

                        }
                    }


                    if (mtxtOS.Text.Replace("-", "").Replace("/", "").Trim().Length == 11)
                    {
                        if (mtxtOS.Text != "")
                        {
                            if (count > 0)
                            {
                                OST = " And OSN = '" + mtxtOS.Text + "'";
                                totalservicoBindingSource.Filter += OST;
                                count++;
                            }
                            else
                            {
                                OST = "OSN = '" + mtxtOS.Text + "'";
                                totalservicoBindingSource.Filter += OST;
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

        private void mtxtDataLimite_TextChanged(object sender, EventArgs e)
        {
            FiltraTotServ();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
