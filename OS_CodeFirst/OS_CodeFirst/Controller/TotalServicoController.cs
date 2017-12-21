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
    class TotalServicoController
    {

        private ControleOS db = new ControleOS();

        public void trataRequisicao(String operacao, TotalServico fun)
        {
            if (operacao.Equals("Cadastrar"))
            {
                var erros = Validacao.Valida(fun);

                if (erros.Count() == 0)
                {
                    try
                    {
                        db.TotalServico.Add(fun);
                        db.SaveChanges();
                        MessageBox.Show("Total do Servico cadastrado !!");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel cadastrar o Total do Servico : " + e.Message);
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
                        MessageBox.Show("Total do Servico alterado com sucesso!");

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel alterar o Total do Servico !" + e.Message);
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
                if (MessageBox.Show("Deseja realmente excluir este Total do Servico?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        fun = db.TotalServico.Find(fun.id);
                        db.TotalServico.Remove(fun);
                        db.SaveChanges();
                        MessageBox.Show("Total do Servico excluido");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel excluir: " + e.Message);
                    }
                    //Fecha form
                }
            }
        }
        public OS VerificaPrioridade(int codigo)
        {
            var query = db.TotalServico.Where(x => x.id == codigo).First();
            var OS = db.OS.Where(x => x.Id == query.OS_id).First();

            return OS;
        }

        public TotalServico GetDados(int codigo)
        {
            var query = db.TotalServico.Where(x => x.id == codigo).First();
            return query;
        }

    }
}
