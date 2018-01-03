using OS_CodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

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
#pragma warning disable CS0168 // A variável "exception" está declarada, mas nunca é usada
            catch (Exception exception)
#pragma warning restore CS0168 // A variável "exception" está declarada, mas nunca é usada
            {
                return 0;
            }
        }
        public OS getDados(int codigo)
        {

                var query = db.OS.Where(x => x.Id == codigo).First();
                return query;
           
        }

        public void MontaOS(int codigo)
        {
            OSController osc = new OSController();
            FuncionarioController fun = new FuncionarioController();
            PrioridadeController pri = new PrioridadeController();
            TipoServicoController tipc = new TipoServicoController();
            SistemaController sisc = new SistemaController();
            DepartamentoController depc = new DepartamentoController();
            
            try
            {
                var OS = osc.getDados(codigo);
                var FUNC = fun.getDados(OS.Funcionario_Id);
                var PRIO = pri.getDados(OS.Prioridade_Id);
                var TIPS = tipc.getDados(OS.TipoServico_Id);
                var SIST = sisc.getDados(OS.Sistema_Id);
                var DEP = depc.getDados(OS.Departamento_Id);



                var template = new FileStream("Ordem de Serviço PAPA.docx", FileMode.Open, FileAccess.Read);
                var docs = new List<DocX>();

                var x = 0;

                x++;
                var doc = DocX.Create("C:\\OS-" + OS.OSN.Replace("/", "") + ".docx");
                doc.ApplyTemplate(template, true);
                doc.ReplaceText("«N_OS»", OS.OSN);
                doc.ReplaceText("«PA»", OS.PA);
                doc.ReplaceText("«TC»", OS.TC);
                doc.ReplaceText("«Data_Emissao»", string.Format("{0:dd/MM/yyyy}", OS.DataEmissao));
                doc.ReplaceText("«Area_Demandante»", DEP.Setor);
                doc.ReplaceText("«Responsável»", FUNC.Nome);
                doc.ReplaceText("«Prioridade»", PRIO.Nivel);
                doc.ReplaceText("«Tipo»", TIPS.Nome);
                doc.ReplaceText("«Item_contratual»", OS.ItemContratual);
                doc.ReplaceText("«Serviço»", OS.Servico);
                doc.ReplaceText("«Sistema»", SIST.Nome);
                doc.ReplaceText("«Data_prevista»", string.Format("{0:dd/MM/yyyy}", OS.DataPrevista));
                doc.ReplaceText("«solicitação»", Convert.ToString(OS.Solicitacao));
                doc.Save();
                docs.Add(doc);

                MessageBox.Show("OS Gerada com sucesso!!", "OS gerada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        public void MontaAceite(int codigo)
        {
            OSController osc = new OSController();
            FuncionarioController fun = new FuncionarioController();
            PrioridadeController pri = new PrioridadeController();
            TipoServicoController tipc = new TipoServicoController();
            SistemaController sisc = new SistemaController();
            DepartamentoController depc = new DepartamentoController();

            try
            {
                var OS = osc.getDados(codigo);
                var FUNC = fun.getDados(OS.Funcionario_Id);
                var PRIO = pri.getDados(OS.Prioridade_Id);
                var TIPS = tipc.getDados(OS.TipoServico_Id);
                var SIST = sisc.getDados(OS.Sistema_Id);
                var DEP = depc.getDados(OS.Departamento_Id);



                var template = new FileStream("Aceite.docx", FileMode.Open, FileAccess.Read);
                var docs = new List<DocX>();

                var x = 0;

                x++;
                var doc = DocX.Create("C:\\Aceite-" + OS.OSN.Replace("/", "") + ".docx");
                doc.ApplyTemplate(template, true);
                doc.ReplaceText("«N_OS»", OS.OSN);
                doc.ReplaceText("«Data_Entregue»", string.Format("{0:dd/MM/yyyy}", OS.DataEntregue));
                doc.ReplaceText("«Area_Demandante»", DEP.Setor);
                doc.ReplaceText("«Responsável»", FUNC.Nome);
                doc.ReplaceText("«Executavel»", "PRODAM");
                doc.ReplaceText("«COTIC»", "FERNANDO GONSALES");
                doc.ReplaceText("«Sistema»", SIST.Nome);
                doc.ReplaceText("«solicitação»", Convert.ToString(OS.Solicitacao));
                doc.Save();
                docs.Add(doc);

                MessageBox.Show("Aceite Gerado com sucesso!!", "OS gerada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }
        public List<StatusOS> verificaEstimativa()
        {

            var query = db.StatusOS.Where(x => x.Status_Id == 2).ToList();
            return query;
            
        }

        public int ContaOS(int os)
        {
            var query = db.StatusOS.Where(x => x.Status_Id == 2 && x.OS_Id==os).Count();
            return query;
        }

        public TimeSpan  GetDataAtt(int os)
        {
            var query = db.StatusOS.Where(x => x.OS_Id == os && x.Status_Id == 2).First();
            var Resultado = DateTime.Now - query.dataAlteracao;
            return Resultado;
        }
    }
}
