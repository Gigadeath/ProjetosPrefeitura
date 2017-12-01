using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_CodeFirst.Model
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do Status é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }


        public virtual ICollection<StatusOS> StatusOS { get; set; }



        /*public Status()
        {
            this.StatusOS = new HashSet<StatusOS>();
        }*/
    }
}
