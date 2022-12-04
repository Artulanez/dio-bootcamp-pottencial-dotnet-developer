using ExemplosFundamentos.Models;

//estrutura de repetição

int numero = 5;
int contador = 0;
while (contador <= 10)
{
    Console.WriteLine($"{numero} x {contador} = {numero *contador}");
    contador++;
}

// int numero = 5;

// for (int contador = 0; contador <= 100000; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero *contador}");
// }


//Operadores Aritimeticos
// Calculadora calc = new Calculadora();

// // calc.Somar(10,30);
// // calc.Subtrair(30,10);
// // calc.Multiplicar(10,5);
// // calc.Dividir(8,2);
// // calc.Potencia(3,3);

// // calc.Seno(30);
// // calc.Coseno(30);
// // calc.Tangente(30);

// int numero = 10;

// Console.WriteLine(numero);
// Console.WriteLine("Incrementando 10");
// numero++;
// Console.WriteLine(numero);
// Console.WriteLine("Decrementando 11");
// numero--;
// Console.WriteLine(numero);

//operador logico

// bool choveu = true;
// bool estaTarde = true;

// if ( !choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar.");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }



// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media > 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }

// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada!");
// }





// operadores condicionais 

// Console.WriteLine("Digite uma letra");
// string? letra = Console.ReadLine();

// switch(letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal.");
//         break;
//     default:
//         Console.WriteLine("Não é Vogal.");
//         break;
// }





// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;

// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda Invalida.");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda Realizada!");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade em estoque");
// }






// cast com tratamento
// string a = "15a";

// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada");





//Ordem das operações 
// double a = 4 / 2 + 2;

// Console.WriteLine(a);




//cast 
// int a = 5;
// double b = a;

// Console.WriteLine(b);

// int inteiro = 5;
// string a  = inteiro.ToString();

// Console.WriteLine(a);

//int a = Convert.ToInt32("5");
// int a = int.Parse("5a");

// Console.WriteLine(a);

// int a = 10;
// int b = 20;

// int c = a + b;

// // c = c + 5;
// c += 5;
// Console.WriteLine(c);

// Codigo criado nas aulas de tipos de dados e variáveis 

// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;
// Console.WriteLine("O valor da variável quantidade: "+ quantidade);
// quantidade = 10;
// Console.WriteLine("O valor da variável quantidade: "+ quantidade);

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// // Console.WriteLine("O valor da variável quantidade: "+ quantidade);
// Console.WriteLine("O valor da variável altura: "+ altura.ToString("0.00"));
// Console.WriteLine("O valor da variável preco: "+ preco);
// Console.WriteLine("O valor da variável condicao: "+ condicao);


// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));



// Pessoa p = new Pessoa();
// p.Nome = "Artulanez Souza da Luz";
// p.Idade = 32;

// p.Apresentar();