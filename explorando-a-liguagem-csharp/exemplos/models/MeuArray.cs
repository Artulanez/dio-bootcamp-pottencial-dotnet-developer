using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplos.models
{
    public class MeuArray<T>
    {
        public static int capacidade = 10;
        public int contador = 0;
        private T[] array = new T[10];

        public void AdicionarElementoArray(T elemento)
        {
            if (contador + 1 < 11)
            {
                array[contador] = elemento;
            }
            contador++;
        }

        public T this[int index]
        {
            get { return array[index];  }
            set { array[index] = value; }
        }
    }
}