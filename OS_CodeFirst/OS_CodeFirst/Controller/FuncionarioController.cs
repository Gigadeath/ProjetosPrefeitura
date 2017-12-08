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
    class FuncionarioController
    {
        private ControleOS db = new ControleOS();

        public void trataRequisicao(String operacao,Funcionario  fun)
        {
            if (operacao.Equals("Cadastrar"))
            {
                var erros = Validacao.Valida(fun);

                if (erros.Count() == 0)
                {
                    try
                    {
                        db.Funcionario.Add(fun);
                        db.SaveChanges();
                        MessageBox.Show("Funcionario cadastrado !!");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel cadastrar o Funcionario : " + e.Message);
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
                        MessageBox.Show("Funcionario alterado com sucesso!");

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel alterar o Funcionario !" + e.Message);
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
                if (MessageBox.Show("Deseja realmente excluir este Funcionario?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        fun = db.Funcionario.Find(fun.Id);
                        db.Funcionario.Remove(fun);
                        db.SaveChanges();
                        MessageBox.Show("Funcionario excluido");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel excluir: " + e.Message);
                    }
                    //Fecha form
                }
            }
        }
        public Funcionario getDados(int codigo)
        {

            var query = db.Funcionario.Where(x => x.Id == codigo).First();
            return query;

        }
    }
}

