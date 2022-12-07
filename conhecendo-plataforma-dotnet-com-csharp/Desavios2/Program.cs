using System;
using System.Text.RegularExpressions;


//Desafio intermediario 3
class Desafio {
  public static void Main() {
    int quantidadeEntradas = 3;
      
    while (quantidadeEntradas > 0) {
      var numeroQuantidade = Int32.Parse(Console.ReadLine());
        
      if (numeroQuantidade >= 1 && numeroQuantidade <= 500) {
        string[] tartarugas = Console.ReadLine().Split(" ");
        
        var maiorVelocidade = Int32.Parse(tartarugas[0]);

        // TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 1; i < tartarugas.Length; i++ )
        {
            var tartaruga = Int32.Parse(tartarugas[i]);

            if ( maiorVelocidade < tartaruga )
            {
                maiorVelocidade = tartaruga;
            }
        }

        if( maiorVelocidade < 10) {
          Console.WriteLine(1);
        } else if ( maiorVelocidade >= 10 && maiorVelocidade < 20) {
          Console.WriteLine(2);
        } else if ( maiorVelocidade>= 20) {
          Console.WriteLine(3);
        }
        quantidadeEntradas--;
      } else {
        Console.WriteLine("Insira um número entre 1 e 500");
      }
    }
  }
}










//Desafio intermediario 2
// class minhaClasse { 

//   static void Main(string[] args) {  

//     double salario = 0.00; 
//     double reajuste = 0.00; 
//     double novoSalario = 0.00; 
//     double percentual = 0.00; 
  
//     salario = Convert.ToDouble(Console.ReadLine()); 

// //TODO: Complete os espaços em branco com uma possível solução para o problema:
   
//     if( salario < 0 ) { 
//       return; 

//     } else if ( salario <= 400.0 ) { 
//       percentual = (15.00/100.00); 
//       reajuste =  percentual * salario; 
//       novoSalario =   salario + reajuste; 


//     } else if (  salario > 400.0 && salario  <= 800.0 ) { 
//       percentual =   12/100; 
//       reajuste =  percentual * salario; 
//       novoSalario =   salario + reajuste; 

//     } else if ( salario > 800.0 && salario  <= 1200.0) { 
//       percentual = 10/100; 
//       reajuste =  percentual * salario; 
//       novoSalario =   salario + reajuste; 

//     } else if ( salario > 1200.0 && salario  <= 2000.0) { 
//       percentual =  7/100; 
//       reajuste =  percentual * salario; 
//       novoSalario =   salario + reajuste; 

//     } else { 
//       percentual = 4/100; 
//       reajuste =  percentual * salario; 
//       novoSalario =   salario + reajuste; 

//     } 

//     Console.WriteLine("Novo salario: {0:0.00}",  novoSalario); 
//     Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste); 
//     Console.WriteLine("Em percentual: {0} %", percentual * 100); 

//   } 
// }



// Desafio intermediario 1 
// public class Program
// {
//     public static void Main(String[] args)
//     {
//         int n = int.Parse(Console.ReadLine());
        
//         int[] num = new int[n];
    
// // TODO: Crie as outras condições necessárias para a resolução do desafio:
//         for (int i = 0; i < n; i++)        
//         {
//             num[i] = int.Parse(Console.ReadLine());
//         }
//         Console.WriteLine(MajorityElement(num));
        
//     }
//     public static int MajorityElement(int[] nums)
//     {
//         int major = nums[0];
//         int count = 1;

//         for (int i = 1; i < nums.Length; i++)
//         {
//             if ( count == 0 )
//             {
//                 major = nums[i];
//                 count = 1;
//             }
//             else
//             {
//                 if (major == nums[i])
//                 {
//                     count++;
//                 }
//                 else
//                 {
//                     count--;
//                 }
//             }
//         }
//         return major;
//     }
// }