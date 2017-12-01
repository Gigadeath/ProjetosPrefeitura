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
    class OSController
    {

        private ControleOS db = new ControleOS();

        public void trataRequisicao(String operacao, OS os)
        {
            if (operacao.Equals("Cadastrar"))
            {
                var erros = Validacao.Valida(os);

                if (erros.Count() == 0)
                {
                    try
                    {
                        db.OS.Add(os);
                        db.SaveChanges();
                        MessageBox.Show("Ordem de Serviço cadastrada !!");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel cadastrar a Ordem de Serviço : " + e.Message);
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
                var erros = Validacao.Valida(os);

                if (erros.Count() == 0)
                {
                    try
                    {
                        db.Entry(os).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Ordem de Serviço alterada com sucesso!");

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel alterar a Ordem de Serviço!" + e.Message);
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
                if (MessageBox.Show("Deseja realmente excluir esta Ordem de Serviço?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        os = db.OS.Find(os.Id);
                        db.OS.Remove(os);
                        db.SaveChanges();
                        MessageBox.Show("Ordem excluidoa");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel excluir: " + e.Message);
                    }
                    //Fecha form
                }
            }
        }
        public int getUltimaOS(int valor,OS os)
        {
            try
            {
                var Nsis = db.OS.Where(x => x.Sistema_Id == valor).OrderByDescending(x=>x.Id);
                return Nsis.First().Id;
            }
            catch (Exception exception)
            {
                return 0;
            }
        }
        public OS getDados(int codigo)
        {

                var query = db.OS.Where(x => x.Id == codigo).First();
                return query;
           
        }
    }
}
