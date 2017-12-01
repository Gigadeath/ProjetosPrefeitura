using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_CodeFirst.Model
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O RF do Funcionario é obrigatório", AllowEmptyStrings = false)]
        public string RF { get; set; }
        [Required(ErrorMessage = "O nome do Funcionario é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Setor do usuário é obrigatório", AllowEmptyStrings = false)]
        public string Setor { get; set; }


        public virtual ICollection<OS> OS { get; set; }

      /*  public Funcionario()
        {
            this.OS = new HashSet<OS>();
        }*/

    }
}
