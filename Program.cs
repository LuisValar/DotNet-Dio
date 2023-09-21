using System.Runtime.CompilerServices;
using Exemplo_Explorando.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

#region

//Formatação de moedas
decimal valorMonetario = 82.40M;
Console.WriteLine($"{valorMonetario:C}");

// alterando a localização do código
decimal valorMonetario2 = 182.40M;
Console.WriteLine(valorMonetario2.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// alterando a localização do código personalizada
decimal valorMonetario3 = 182.40M;
Console.WriteLine(valorMonetario3.ToString("C8"));
Console.WriteLine(valorMonetario3.ToString("N8"));

//Trabalhando com porcentagem
double portcentagem = .212;
Console.WriteLine(portcentagem.ToString("P"));

//Trabalhando com separadores
int numero = 212123;
Console.WriteLine(numero.ToString(" ##-##-## "));

// Date Time
DateTime data = DateTime.Now;
Console.WriteLine(data);

Console.WriteLine("Ajustando formatos  " + data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine("Ajustando formatos  " + data.ToString("dd/M/yyyy HH:mm"));
Console.WriteLine("Ajustando para formato de 12 horas  " + data.ToString("dd/MM/yyyy hh:mm"));

// Formatação de hora e data
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

// Conversão de horas
string dataString  = "20-09-2023 10:30";
bool sucessoData = DateTime.TryParseExact(dataString, 
                                            "yyyy-MM-dd HH:mm", 
                                            CultureInfo.InvariantCulture, 
                                            DateTimeStyles.None, 
                                            out data);
if(sucessoData)
{
    Console.WriteLine($"Conversão de data realizada com sucesso, Data: {data}" );
}else{
    Console.WriteLine($"{dataString} não é uma data válida.");
}
                        


#endregion



/*Pessoa p1 = new Pessoa("Luis Henrique", "Valar");
Pessoa p2 = new Pessoa("Julia", "Malu");

Curso cursoDeingles = new Curso();
cursoDeingles.NomeCurso = "Ingles";
cursoDeingles.Alunos = new List<Pessoa>();

cursoDeingles.AdicionarAluno(p1);
cursoDeingles.AdicionarAluno(p2);
cursoDeingles.ListarAlunos();
*/



/*
Pessoa p1 = new Pessoa();
p1.NomePessoa = "Luis Henrique";
p1.SobreNome = "Valar";
p1.Idade = 10;
p1.Apresentar();
*/

