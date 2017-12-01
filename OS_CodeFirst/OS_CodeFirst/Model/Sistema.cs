using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_CodeFirst.Model
{
   public class Sistema
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do sistema é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O numero da OS é obrigatório", AllowEmptyStrings = false)]
        [StringLength(3, MinimumLength = 3)]
        public string Numero_OS { get; set; }



        public virtual ICollection<OS> OS { get; set; }

        /*public Sistema()
        {
            this.OS = new HashSet<OS>();
        }*/
    }
}
