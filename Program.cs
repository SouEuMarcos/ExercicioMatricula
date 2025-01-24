using System.Collections;
using ExemploExplorando.Models;

try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally
{
    Console.WriteLine("Finalizado!");
}

Pessoa p1 = new Pessoa(nome: "Marcos", sobrenome: "Vinícius");

// p1.Nome = "Marcos";
// p1.Sobrenome = "Vinícius";
// p1.Idade = 22;
// p1.Apresentar();

Pessoa p2 = new Pessoa(nome: "Rauana", sobrenome: "Lage");

// p2.Nome = "Rauana";
// p2.Sobrenome = "Lage";

Console.WriteLine("\n----------------------------------------------\n");

Curso cursoDeIngles = new Curso();

cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

Console.WriteLine("\n----------------------------------------------\n");
// Aplicando uma lista (QUEUE).

Queue<int> fila = new Queue<int>();

fila.Enqueue(10);
fila.Enqueue(8);
fila.Enqueue(20);
fila.Enqueue(34);
fila.Enqueue(192);

Console.WriteLine("\nOs elementos da fila são:");

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"\nRemovendo o elemento: {fila.Dequeue()}\n");

Console.WriteLine("Os elementos da fila são:");

foreach (int item in fila)
{
    Console.WriteLine(item);
}

// Aplicando uma pilha (STACK).
Console.WriteLine("\n----------------------------------------------\n");

Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

Console.WriteLine("\nOs elementos da pilha são:");

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"\nRemovendo o elemento: {pilha.Pop()}\n");

Console.WriteLine("Os elementos da pilha são:");

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

// Aplicando um Dictonary.
Console.WriteLine("\n----------------------------------------------\n");

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("PR", "Paraná");
estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} \nValor: {item.Value}\n");
}

// Verificando se há key existente.

string chave = "SP";
Console.WriteLine($"Verificando se há a chave: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existente. É seguro adicionar a chave: {chave}");
}

// Obtendo o valor do dictonary.
Console.WriteLine("");
Console.WriteLine(estados["PR"]);

// Aplicando na prática a tupla.
Console.WriteLine("\n----------------------------------------------\n");

(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Marcos", "Vinícius", 1.79M);

Console.WriteLine($"ID: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");