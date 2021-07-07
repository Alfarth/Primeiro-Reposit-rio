using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Dominio
{
    class Academia
    {
        public List<Aluno> Alunos { get; private set; }

        public Academia()
        {
            Alunos = new List<Aluno>();
        }

        public void AdicionaAluno(string cpf)
        {
            Aluno aluno = new Aluno();
            aluno.CPF = cpf;
            Alunos.Add(aluno);
        }

        public void ExcluirAluno( string cpf)
        {
            foreach (var aluno in Alunos)
            {
                if(cpf.Equals(aluno.CPF))
                {
                    Alunos.Remove(aluno);
                }
            }
        }
    }
}
