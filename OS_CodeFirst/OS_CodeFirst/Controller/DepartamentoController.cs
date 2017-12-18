﻿using OS_CodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_CodeFirst.Controller
{
    class DepartamentoController
    {

        private ControleOS db = new ControleOS();

        public void trataRequisicao(String operacao, Departamento fun)
        {
            if (operacao.Equals("Cadastrar"))
            {
                var erros = Validacao.Valida(fun);

                if (erros.Count() == 0)
                {
                    try
                    {
                        db.Departamento.Add(fun);
                        db.SaveChanges();
                        MessageBox.Show("Departamento cadastrado !!");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel cadastrar o Departamento : " + e.Message);
                    }
                    //fecha form
                }
                else
                {
                    foreach (var e in erros)
                        MessageBox.Show(e.ToString());
                }
            }

            if (operacao.Equals("Alterar"))
            {
                var erros = Validacao.Valida(fun);

                if (erros.Count() == 0)
                {
                    try
                    {
                        db.Entry(fun).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Departamento alterado com sucesso!");

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel alterar o Departamento !" + e.Message);
                    }
                    //fecha form
                }
                else
                {
                    foreach (var e in erros)
                        MessageBox.Show(e.ToString());
                }
            }

            if (operacao.Equals("Excluir"))
            {
                if (MessageBox.Show("Deseja realmente excluir este Departamento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        fun = db.Departamento.Find(fun.Id);
                        db.Departamento.Remove(fun);
                        db.SaveChanges();
                        MessageBox.Show("Departamento excluido");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel excluir: " + e.Message);
                    }
                    //Fecha form
                }

            }
        }
        public Departamento getDados(int codigo)
        {

            var query = db.Departamento.Where(x => x.Id == codigo).First();
            return query;

        }
    }
}
