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
    Console.WriteLine("Finalizado!\n");
}

Pessoa p1 = new Pessoa(nome: "Marcos", sobrenome: "Vinícius");

// p1.Nome = "Marcos";
// p1.Sobrenome = "Vinícius";
// p1.Idade = 22;
// p1.Apresentar();

Pessoa p2 = new Pessoa(nome: "Rauana", sobrenome: "Lage");

// p2.Nome = "Rauana";
// p2.Sobrenome = "Lage";


Curso cursoDeIngles = new Curso();

cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

// Aplicando uma lista (QUEUE).

Queue<int> fila = new Queue<int>();

fila.Enqueue(10);
fila.Enqueue(8);
fila.Enqueue(20);
fila.Enqueue(34);
fila.Enqueue(192);

Console.WriteLine("Os elementos da Queue são:");

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"\nRemovendo o elemento: {fila.Dequeue()}\n");

Console.WriteLine("Os elementos da Queue são:");

foreach (int item in fila)
{
    Console.WriteLine(item);
}