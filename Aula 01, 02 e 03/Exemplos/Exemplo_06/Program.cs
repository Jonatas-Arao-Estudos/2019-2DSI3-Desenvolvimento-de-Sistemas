﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_06
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite um número: ");

                int numero = Convert.ToInt32(Console.ReadLine());

                int resultado = 100 / numero;

                Console.WriteLine("Resultado de 100 / {0} = {1}", numero, resultado);
            }
            catch
            {
                Console.WriteLine("ERRO");
            }

            Console.ReadKey();
        }
    }
}