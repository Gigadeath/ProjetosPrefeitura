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
    class StatusOS_Controller
    {
        private ControleOS db = new ControleOS();

        public void trataRequisicao(String operacao, StatusOS fun)
        {
            if (operacao.Equals("Cadastrar"))
            {
                var erros = Validacao.Valida(fun);

                if (erros.Count() == 0)
                {
                    try
                    {
                        db.StatusOS.Add(fun);
                        db.SaveChanges();
                        MessageBox.Show("StatusOS cadastrado !!");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel cadastrar o StatusOS : " + e.Message);
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
                        MessageBox.Show("StatusOS alterado com sucesso!");

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel alterar o StatusOS !" + e.Message);
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
                if (MessageBox.Show("Deseja realmente excluir este StatusOS?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        fun = db.StatusOS.Find(fun.Id);
                        db.StatusOS.Remove(fun);
                        db.SaveChanges();
                        MessageBox.Show("StatusOS excluido");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel excluir: " + e.Message);
                    }
                    //Fecha form
                }
            }
        }
        public StatusOS getDados(int codigo)
        {
            var query = db.StatusOS.Where(x => x.Id == codigo).First();
            var resultado = db.StatusOS.Where(x => x.OS_Id == query.OS_Id).OrderByDescending(x=>x.OS_Id).First();
            return resultado;
        }
        public bool verificaInsercao(int codigo)
        {
            var query = db.StatusOS.Where(x => x.Id == codigo).First();
            int resultado = db.StatusOS.Where(x => x.OS_Id == query.OS_Id).Where(x=> x.Status_Id==7 || x.Status_Id==8).Count();
            if(resultado > 0)
            {
                MessageBox.Show("Ordem de Serviço Encerrada ou Cancelada, sendo assim não é possivel altera-la!");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool verificaOS(int codigoOS)
        {
            
            int resultado = db.StatusOS.Where(x => x.OS_Id == codigoOS).Where(x => x.Status_Id == 7 || x.Status_Id == 8).Count();
            if (resultado > 0)
            {
                MessageBox.Show("Ordem de Serviço Encerrada ou Cancelada, sendo assim não é possivel altera-la!");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
