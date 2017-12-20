using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_CodeFirst.Model
{
    public class TipoServico
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do tipo de Serviço é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Status do Serviço é obrigatório", AllowEmptyStrings = false)]
        public bool status { get; set; }

        public virtual ICollection<OS> Ordens { get; set; }

        /*public TipoServico()
        {
            this.Ordens = new HashSet<OS>();
        }*/
    }
}
