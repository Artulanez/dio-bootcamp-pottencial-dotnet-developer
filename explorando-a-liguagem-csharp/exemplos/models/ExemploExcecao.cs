using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplos.models
{
    public class ExemploExcecao
    {
        public void metodo1()
        {
            try
            {
                metodo2();    
            }
            catch (Exception ex)            
            {
                Console.WriteLine("Exceção tratada."+ex.Message);
            }
            
        }

        public void metodo2()
        { 
            metodo3();
        }

        public void metodo3()
        {
            metodo4();
        }

        public void metodo4()
        {
            throw new Exception("Ocorreu uma Exceção");
        }
    }
}