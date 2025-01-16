using ExemploExplorando.Models;

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