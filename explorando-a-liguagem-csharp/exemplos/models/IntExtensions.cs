using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplos.models
{
    public static class IntExtensions
    {
        public static bool ehPar(this int numero)
        {
            return numero % 2 == 0;
        }
}
}