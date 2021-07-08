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
        public void SalvarAluno(string cpf, string nome, string telefone)
        {
            foreach (var aluno in Alunos)
            {
                if (aluno.CPF.Equals(cpf))
                {
                    aluno.Nome = nome;
                    aluno.Telefone = telefone;
                }
            }
        }

        public void Pagar(string cpf)
        {
            foreach (var aluno in Alunos)
            {
                if (aluno.CPF.Equals(cpf))
                {
                    aluno.PagaMensalidade();
                }
            }
        }
    }       

}
