using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_CodeFirst.Model
{
    public class Departamento
    {

        [Key]
        public int Id { get; set; }      
        [Required(ErrorMessage = "O nome do setor do usuário é obrigatório", AllowEmptyStrings = false)]
        public string Setor { get; set; }

        public virtual ICollection<OS> OS { get; set; }
        public virtual ICollection<Dep_Func> DepFunc { get; set; }


    }
}
