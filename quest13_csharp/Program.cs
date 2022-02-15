﻿/*
Desafio
O programa deve ler um valor inteiro D indefinidas vezes, ele só irá parar quando o valor de D for igual a 0. Para cada D lido, imprima a soma dos 5 pares consecutivos a partir de D, inclusive ele mesmo , se for par. Se o valor de entrada for 4, por exemplo, a saída deve ser 40, que é o resultado da operação: 4 + 6 + 8 + 10 + 12, enquanto que se o valor de entrada for 11, por exempo, a saída deve ser 80, que é a soma de 12+14+16+18+20.

Entrada
O arquivo de entrada contém muitos valores inteiros. O último valor do arquivo é zero.

Saída
Imprima a saida conforme a explicação acima e o exemplo abaixo.
*/
using System;



namespace quest13_csharp

{

    internal static class Program

    {

        private static void Main()

        {

            int X;

            while ((X = int.Parse(Console.ReadLine())) != 0)

            {

                int soma = 0;



                if (X % 2 != 0)

                {

                    X++;

                }



                for (int j = 0; j < 5; j++)

                {

                    soma += X + j * 2;

                }



                Console.WriteLine(soma);

            }

        }

    }

}