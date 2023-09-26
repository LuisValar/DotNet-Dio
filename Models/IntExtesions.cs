using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_Explorando.Models
{
    public static class IntExtesions
    {
        public static bool Ehpar(this int numero)
        {
           return numero % 2 == 0;
        }
    }
}