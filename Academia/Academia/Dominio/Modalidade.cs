using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Dominio
{
    public class Modalidade
    {
        [Key]
        public int IdModalidade { get; set; }
        [MaxLength(100), Required]
        public string Nome { get; set; }

    }
}
