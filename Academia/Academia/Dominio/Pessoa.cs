using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Dominio
{
    public class Pessoa
    {
        [MaxLength(50)]
        public string Nome { get; set; }
        [Key]
        public string CPF { get; set; }

        
    }
}
