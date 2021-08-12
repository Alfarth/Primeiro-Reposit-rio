using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Dominio
{
    public class Professor: Pessoa
    {
        public virtual Modalidade Modalidade { get; set; }

    }
}
