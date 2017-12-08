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
    class TipoServicoController
    {
        private ControleOS db = new ControleOS();

        public void trataRequisicao(String operacao, TipoServico fun)
        {
            if (operacao.Equals("Cadastrar"))
            {
                var erros = Validacao.Valida(fun);

                if (erros.Count() == 0)
                {
                    try
                    {
                        db.TipoServico.Add(fun);
                        db.SaveChanges();
                        MessageBox.Show("Tipo de Serviço cadastrado !!");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel cadastrar o Tipo de Serviço : " + e.Message);
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
                        MessageBox.Show("Tipo de Serviço alterado com sucesso!");

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel alterar o Tipo de Serviço !" + e.Message);
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
                if (MessageBox.Show("Deseja realmente excluir este Tipo de Serviço?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        fun = db.TipoServico.Find(fun.Id);
                        db.TipoServico.Remove(fun);
                        db.SaveChanges();
                        MessageBox.Show("Tipo de Serviço excluido");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel excluir: " + e.Message);
                    }
                    //Fecha form
                }
            }
        }
        public TipoServico getDados(int codigo)
        {

            var query = db.TipoServico.Where(x => x.Id == codigo).First();
            return query;

        }
    }
}
