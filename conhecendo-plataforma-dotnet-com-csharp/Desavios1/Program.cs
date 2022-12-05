using System.Collections.Generic;

class Programs{
    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
        // TODO: Crie as outras condições necessárias para a resolução do desafio:
        List<string> listaEntrada = new List<string>();

        for (int i = 0; i < qt; i++)
        {
            listaEntrada.Add(Console.ReadLine());
        }


        for (int contador = 0; contador < listaEntrada.Count; contador++)
        {
            string[] v = listaEntrada[contador].Split(" ");
            string a = v[0];
            string b = v[1];


            if (b.Length > a.Length)
                Console.WriteLine("nao encaixa");
            else if (a.EndsWith(b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");

        }
    }

}

