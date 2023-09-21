using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_Explorando.Models
{
    public class Curso
    {
        public string NomeCurso { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno (Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObtemQtdAlunosMatriculados ()
        {
            int quantidade = Alunos.Count();
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {NomeCurso}:");
            for (int i = 0; i < Alunos.Count; i++)
            {
                string texto = $"N° {i + 1} - {Alunos[i].NomeCompleto}"; 
                Console.WriteLine(texto);
            }
        }

    }
}