using System.Runtime.CompilerServices;
using Exemplo_Explorando.Models;

Pessoa p1 = new Pessoa("Luis Henrique", "Valar");
Pessoa p2 = new Pessoa("Julia", "Malu");

Curso cursoDeingles = new Curso();
cursoDeingles.NomeCurso = "Ingles";
cursoDeingles.Alunos = new List<Pessoa>();

cursoDeingles.AdicionarAluno(p1);
cursoDeingles.AdicionarAluno(p2);
cursoDeingles.ListarAlunos();


















/*
Pessoa p1 = new Pessoa();
p1.NomePessoa = "Luis Henrique";
p1.SobreNome = "Valar";
p1.Idade = 10;
p1.Apresentar();
*/

