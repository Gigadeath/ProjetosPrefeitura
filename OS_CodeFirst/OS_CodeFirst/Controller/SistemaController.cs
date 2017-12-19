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
    class SistemaController
    {
        private ControleOS db = new ControleOS();

        public void trataRequisicao(String operacao, Sistema fun)
        {
            if (operacao.Equals("Cadastrar"))
            {
                var erros = Validacao.Valida(fun);

                if (erros.Count() == 0)
                {
                    try
                    {
                        db.Sistema.Add(fun);
                        db.SaveChanges();
                        MessageBox.Show("Sistema cadastrado !!");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel cadastrar o Sistema : " + e.Message);
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
                        MessageBox.Show("Sistema alterado com sucesso!");

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel alterar o Sistema !" + e.Message);
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
                if (MessageBox.Show("Deseja realmente excluir este Sistema?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        fun = db.Sistema.Find(fun.Id);
                        db.Sistema.Remove(fun);
                        db.SaveChanges();
                        MessageBox.Show("Sistema excluido");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Não foi possivel excluir: " + e.Message);
                    }
                    //Fecha form
                }
            }
        }

        public string  getNumero_OS(int valor,Sistema fun,OS osm)
        {
           try
            {
              osm.Sistema_Id = valor;
              var OSN =db.OS.Where(x=> x.Sistema_Id == valor).OrderByDescending(x=>x.Id).First();
              return Convert.ToString(OSN.OSN);
           }
            catch (Exception exception)
            {
                return "";
                
            }
        }

        public string getNumeroSistema(int valor)
        {
            try
            {
                var Nsis = db.Sistema.Where(x => x.Id == valor).First();
                return Nsis.Numero_OS;
            }
            catch (Exception exception)
            {
                return "";
            }
        }
        public Sistema getDados(int codigo)
        {

            var query = db.Sistema.Where(x => x.Id == codigo).First();
            return query;

        }
    }
}
