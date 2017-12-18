using OS_CodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_CodeFirst.Controller
{
    class DepFuncController
    {
        private ControleOS db = new ControleOS();

        public void trataRequisicao(String operacao, Dep_Func fun)
        {
            if (operacao.Equals("Cadastrar"))
            {
                var erros = Validacao.Valida(fun);

                if (erros.Count() == 0)
                {
                    try
                    {
                        db.DepFunc.Add(fun);
                        db.SaveChanges();
                        MessageBox.Show("Nivel de Prioridade cadastrado !!");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel cadastrar o Nivel de Prioridade : " + e.Message);
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
                        MessageBox.Show("Nivel de Prioridade alterado com sucesso!");

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel alterar o Nivel de Prioridade !" + e.Message);
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
                if (MessageBox.Show("Deseja realmente excluir este Nivel de Prioridade?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        fun = db.DepFunc.Find(fun.Id);
                        db.DepFunc.Remove(fun);
                        db.SaveChanges();
                        MessageBox.Show("Nivel de Prioridade excluido");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel excluir: " + e.Message);
                    }
                    //Fecha form
                }

            }
        }

        public Dep_Func LastDepartamento(int funcionario)
        {

            var query = db.DepFunc.Where(x => x.Funcionario_Id == funcionario).OrderByDescending(x => x.Id).First();
            return query;

        }
    }
}
