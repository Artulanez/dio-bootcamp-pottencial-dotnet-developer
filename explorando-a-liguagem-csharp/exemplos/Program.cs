using exemplos.models;
using System.Globalization;

string dataString = "2022-07-17 18:00";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! data:{data}");
}
else
{ 
    Console.WriteLine($"{dataString} não é uma data válida!");
}


// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());

////////////////////////////////////
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40m;

// Console.WriteLine(valorMonetario.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));

// Console.WriteLine(valorMonetario.ToString("C1"));

// double porcentagem = .3909;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));


//////////////////////////////
// String numero1 = "10";
// int numero2 = 20;

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);

/////////////////////////////
// Pessoa p1 = new Pessoa("Artulanez","Souza",32);
// Pessoa p2 = new Pessoa("Lucrecia","Cariolano",34);

// Curso cursoDeIngles = new Curso("Ingles");

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

