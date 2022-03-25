using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroExercicioVS.PastaExercicio1.SalaDeAula
{
    internal class Aluno
    {
            public string CPF { get; }
            public string Nome { get; }
            public DateTime DataDeNascimento { get; }

            public Aluno(string nome, DateTime dataNascimento, string cpf)
            {
                Nome = nome;
                DataDeNascimento = dataNascimento;
                CPF = cpf;
            }
        }
    }
}
