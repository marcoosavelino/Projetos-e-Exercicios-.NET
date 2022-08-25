﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Ex_08_Lista_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;

            Console.WriteLine("------------------------");
            Console.WriteLine("   | 01  |  Ex 01   ");
            Console.WriteLine("   | 02  |  Ex 02   ");
            Console.WriteLine("   | 03  |  Ex 03   ");
            Console.WriteLine("   | 04  |  Ex 04   ");
            Console.WriteLine("   | 05  |  Ex 05   ");
            Console.WriteLine("   | 06  |  Ex 06   ");
            Console.WriteLine("   | 07  |  Ex 07   ");
            Console.WriteLine("------------------------");
            codigo = Convert.ToInt32(Console.ReadLine());


            switch (codigo)
            {
                case 1:
                    
                    double A, B, C;

                    Console.WriteLine("Informe o valor de A:");
                    A = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe o valor de B:");
                    B = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe o valor de C:");
                    C = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("A SOMA DE (A e B) É MENOR DO QUE (C)?? {0}", (A + B) < C ? "Verdade" : "Falso");

                    
                    break;

                case 2:
                    string nome, sexo, estcivil;
                    double tempodec;

                    Console.WriteLine("Digite o nome de uma pessoa:");
                    nome = Console.ReadLine();
                    Console.WriteLine("Qual o sexo desta pessoa?");
                    sexo = Console.ReadLine();
                    Console.WriteLine("Qual o estado civil desta pessoa?");
                    estcivil = Console.ReadLine();


                    if ((sexo == "F") && (estcivil == "CASADA"))
                    {
                        Console.WriteLine("Quanto tempo de Casada ela tem?");
                        tempodec = Convert.ToDouble(Console.ReadLine());
                    }

                    
                    break;
                case 3:
                    int number;
                    

                    Console.WriteLine("Informe um número:");
                    number = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(number % 2 == 0 ? "Par" : "Ímpar");

                    
                    break;
                case 4:
                    int D, E, F;

                    Console.WriteLine("Informe o valor de D:");
                    D = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o valor de E:");
                    E = Convert.ToInt32(Console.ReadLine());

                    F = 0;

                    Console.WriteLine("O Valor de F é: {0}", D == E ? F = D + E : F = D * E);

                    
                    break;
                case 5:
                    double numero;


                    Console.WriteLine("Informe um número:");
                    numero = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(numero >= 0 ? numero * 2 : numero * 3);

                    
                    break;
                case 6:
                    bool valor1, valor2;
                    string resultado;


                    Console.WriteLine("Informe o valor 1:");
                    valor1 = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("Informe o valor 2:");
                    valor2 = Convert.ToBoolean(Console.ReadLine());

                    resultado = valor1 == valor2 ? "Os Valores são iguais" : "Os valores são diferentes";
                    Console.WriteLine(resultado);


                    if (resultado == "Os Valores são iguais")
                    {
                        Console.WriteLine("AMBOS SÃO: {0}", valor1);
                    }
                    
                    break;
                default:
                    int n1;
                    string texto1;

                    Console.WriteLine("Informe um número:");
                    n1 = Convert.ToInt32(Console.ReadLine());

                    texto1 = n1 % 2 == 0 ? "Par" : "Ímpar";
                    Console.WriteLine(texto1);


                    if (texto1 == "Par")
                    {
                        Console.WriteLine("Novo Valor: {0}", n1 + 5);
                    }
                    else
                    {
                        Console.WriteLine("Novo Valor: {0}", n1 + 8);
                    }
                    break;
            }         
            


            Console.ReadKey();

        }
    }
}
