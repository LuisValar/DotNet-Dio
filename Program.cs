using System.Runtime.CompilerServices;
using Exemplo_Explorando.Models;
using System.Globalization;
using Newtonsoft.Json;

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
string dataString = "01/01/2021";
bool sucessoData = DateTime.TryParseExact(dataString,
                                            "dd/MM/YYYY",
                                            CultureInfo.InvariantCulture,
                                            DateTimeStyles.None,
                                            out data);
if (sucessoData)
{
    Console.WriteLine($"Conversão de data realizada com sucesso, Data: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida.");
}

#endregion

#region 
try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu uma exeção de diretorio não encontrado. {ex}");
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu uma exeção de arquivo não encontrado. {ex}");
}
finally
{
    Console.WriteLine("Chegou até aqui!");
}
#endregion

#region//Filas
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int i in fila)
{
    Console.WriteLine(i);
}
//Sempre remove o primeiro elemento
Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
foreach(int i in fila)
{
    Console.WriteLine(i);
}
#endregion

#region //Pilhas
Console.WriteLine("Aqui jás uma pilha");
Stack<int> pilha = new Stack<int>();
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int i in pilha)
{
    Console.WriteLine(i);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

foreach(int i in pilha)
{
    Console.WriteLine(i);
}
#endregion

#region //Dictionary

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("RS", "Rio Grande do Sul");
estados.Add("SC", "Santa Catarina");
estados.Add("PR", "Parana");

foreach(var i in estados)
{
    Console.WriteLine($"Chave: {i.Key}, Valor: {i.Value}");
}

Console.WriteLine("-----------------");

estados.Remove("PR");
estados["SC"] = "Santa Catarina editada";
foreach(var i in estados)
{
    Console.WriteLine($"Chave: {i.Key}, Valor: {i.Value}");
}
string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");
if(estados.ContainsKey(chave))
{
    Console.WriteLine("Valor existente");
}
else
{
    Console.WriteLine($"Valor inexistente. o valor {chave} pode ser add.");
}
#endregion

#region //Tuplas
(int id, string nome, string sobreNome) tupla = (28, "Luis Henrique", "Valar");
Console.WriteLine(tupla.id);

// outra forma de tupla
ValueTuple<int, string, string> outroExemploTupla = (28, "Luis Henrique", "valar");
var maisUmaTupla = Tuple.Create(28, "Luis Henrique", "valar");
#endregion

LeituraArquivo arquivo = new LeituraArquivo();
var (Sucesso, LinhasArquivo, QtdLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if(Sucesso)
{
    Console.WriteLine("quantidade linhas do arquivo: " + QtdLinhas);
    foreach(string linha in LinhasArquivo)
        Console.WriteLine(linha);
}
else
    Console.WriteLine("Não foi possivel ler o arquivo");


Pessoa p1 = new Pessoa("Luis Henrique", "Valar");
(string nome, string sobrenome) = p1;


#region //if ternario
int numeroParOuImpar = 20;

par = numeroParOuImpar.Ehpar();

bool ehpar = false;

//não ternario
if(numeroParOuImpar % 2 == 0)
    Console.WriteLine($"O numero {numeroParOuImpar} é par");
else
    Console.WriteLine($"O numero {numeroParOuImpar} é impar");

//if ternario
ehpar = numeroParOuImpar % 2 == 0;
Console.WriteLine($"O numero {numeroParOuImpar} é " + (ehpar ? "par" : "impar"));

#endregion

bool? desejaReceberEmail = null;
if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
    Console.WriteLine("O Usuário optou por receber e-mail!");
else
    Console.WriteLine("O Usuário optou por não receber e-mail!");

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.Json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"ID: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}, Desconto: {venda.Desconto}");
}

#region //Tipo Anonimo

var tipoAnonimo = new { Nome = "Luis", sobrenome = "Valar", Altura = 1.80 };
Console.WriteLine("Nome: " + tipoAnonimo.Nome);
Console.WriteLine("SobreNome: " + tipoAnonimo.sobrenome);
Console.WriteLine("Altura: " + tipoAnonimo.Altura);

//Retorno de coleção
var listaAnonimo = listaVenda.Select(x => new{x.Produto, x.Preco});

foreach(var venda in listaAnonimo)
    Console.WriteLine($"Produto: {venda.Produto}, preço: {venda.Preco}");

#endregion

#region //Tipo dinamico

dynamic variavelDinamica = 4;
Console.WriteLine($"Tipo da variável:  {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

#endregion

#region //Classe generica

MeuArray<int> arrayInteiro = new MeuArray<int>();
arrayInteiro.AdicionarElementoArray(30);

Console.WriteLine(arrayInteiro[0]);
#endregion

//new ExemploExcecao().Metodo1(); 


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

