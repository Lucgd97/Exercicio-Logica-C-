﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class Tabuada
    {
        public static void Calcular(int numero)
        {
            Console.WriteLine($" ===== Tabuada do numero {numero}! =====");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
        }
    }
}
