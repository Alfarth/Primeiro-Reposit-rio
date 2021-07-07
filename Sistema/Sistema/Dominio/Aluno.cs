using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Dominio
{
    class Aluno : Pessoa
    {
        public string Turma { get; set; }

        public double Mensalidade { get; set; }
        private bool pagouMensalidade = false;

        public void PagaMensalidade()
        {
            pagouMensalidade = true;
        }
        
        public override string ToString()
        {
            return Nome;
        }

    }
}
