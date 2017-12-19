using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_CodeFirst.Model
{
    public class OS
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O numero da OS é obrigatório", AllowEmptyStrings = false)]
        public string OSN { get; set; }
        [Required(ErrorMessage = "O numero do PA é obrigatório", AllowEmptyStrings = false)]
        public string PA { get; set; }
        [Required(ErrorMessage = "O numero do TC é obrigatório", AllowEmptyStrings = false)]
        public string TC { get; set; }
        [Required(ErrorMessage = "A Data de Emissão é obrigatório", AllowEmptyStrings = false)]
        public DateTime DataEmissao { get; set; }
        public string ItemContratual { get; set; }
        [Required(ErrorMessage = "A Data Prevista é obrigatório", AllowEmptyStrings = false)]
        public DateTime DataPrevista { get; set; }
        [Required(ErrorMessage = "A Data Entregue é obrigatório", AllowEmptyStrings = false)]
        public DateTime DataEntregue { get; set; }
        [Required(ErrorMessage = "A descrição é obrigatória", AllowEmptyStrings = false)]
        public string Solicitacao { get; set; }
        public string Servico { get; set; }



        public Int32 Funcionario_Id { get; set; }
        public Int32 Prioridade_Id { get; set; }
        public Int32 Sistema_Id { get; set; }
        public Int32 TipoServico_Id { get; set; }
        public Int32 Departamento_Id { get; set; }


        public virtual ICollection<StatusOS> StatusOS { get; set; }

        [ForeignKey("Funcionario_Id")]
        public Funcionario Funcionario { get; set; }

        [ForeignKey("Prioridade_Id")]
        public Prioridade Prioridade { get; set; }

        [ForeignKey("Sistema_Id")]
        public Sistema Sistema { get; set; }

        [ForeignKey("TipoServico_Id")]
        public TipoServico TipoServico {get; set;}

        [ForeignKey("Departamento_Id")]
        public Departamento Departamento { get; set; }

    /*  public OS()
        {
            this.StatusOS = new HashSet<StatusOS>();
        }*/
    }
}
