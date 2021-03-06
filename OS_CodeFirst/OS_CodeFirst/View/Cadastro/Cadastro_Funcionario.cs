﻿using OS_CodeFirst.Controller;
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
using MaterialSkin;
using MaterialSkin.Controls;

namespace OS_CodeFirst.View
{
    public partial class Cadastro_Funcionario : MaterialForm
    {
        public Cadastro_Funcionario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FuncionarioController func = new FuncionarioController();
            Funcionario fun = new Funcionario(); 
            fun.RF = mtxtRF.Text.Replace(".", "").Replace("-", ""); 
            fun.Nome = txtNome.Text;
            fun.status = true;
            //fun.Setor = txtSetor.Text;

            func.trataRequisicao(btnSalvar.Text, fun);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
