using ExemplosFundamentos.Models;

string apresentacao = "Olá, seja bem vindo";

int quantidade = 1;
Console.WriteLine("O valor da variável quantidade: "+ quantidade);
quantidade = 10;
Console.WriteLine("O valor da variável quantidade: "+ quantidade);

double altura = 1.80;

decimal preco = 1.80M;

bool condicao = true;

Console.WriteLine(apresentacao);
// Console.WriteLine("O valor da variável quantidade: "+ quantidade);
Console.WriteLine("O valor da variável altura: "+ altura.ToString("0.00"));
Console.WriteLine("O valor da variável preco: "+ preco);
Console.WriteLine("O valor da variável condicao: "+ condicao);


DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));



// Pessoa p = new Pessoa();
// p.Nome = "Artulanez Souza da Luz";
// p.Idade = 32;

// p.Apresentar();