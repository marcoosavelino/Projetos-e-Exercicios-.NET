﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    class Program
    {




        static void Main(string[] args)
        {

            string[,] MatrizAlfa = new string[1000, 5];

            int cont = 1;

            for (int i = 0; i < MatrizAlfa.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizAlfa.GetLength(1); j++)
                {

                    Console.WriteLine("Código do Cliente: {0}", cont++);

                    Console.WriteLine("Nome:");
                    MatrizAlfa[i, j] = Console.ReadLine();
                    Console.WriteLine("Telefone:");
                    MatrizAlfa[i, j] = Console.ReadLine();
                    Console.WriteLine("CPF:");
                    MatrizAlfa[i, j] = Console.ReadLine();
                    Console.WriteLine("Cidade:");
                    MatrizAlfa[i, j] = Console.ReadLine();
                    Console.WriteLine("E-mail:");
                    MatrizAlfa[i, j] = Console.ReadLine();


                }
            }

              void ConsultaCliente(string pNome)
            {
                Console.WriteLine("Consulte um nome:");
                pNome = Console.ReadLine();

                for (int i = 0; i < MatrizAlfa.GetLength(0); i++)
                {
                    for (int j = 0; j < MatrizAlfa.GetLength(1); j++)
                    {
                        if (MatrizAlfa[i,j] == pNome)
                        {
                            Console.WriteLine(MatrizAlfa[i, 0],MatrizAlfa[i,1], MatrizAlfa[i, 2], MatrizAlfa[i, 3], MatrizAlfa[i, 4],MatrizAlfa[i,5]);
                        }
                        else
                        {
                            Console.WriteLine("Cliente não encontrado!!");
                        }
                    }
                }

                void ConsultaPorCPF (string pCPF)
                {
                    string CPF;

                    Console.WriteLine("Informe o CPF para Consulta:");
                    CPF = Console.ReadLine();

                    for (int i = 0; i < MatrizAlfa.GetLength(0); i++)
                    {
                        for (int j = 0; j < MatrizAlfa.GetLength(1); j++)
                        {
                            if (MatrizAlfa[i, j] == CPF)
                            {
                                Console.WriteLine(MatrizAlfa[i, 0], MatrizAlfa[i, 1], MatrizAlfa[i, 2], MatrizAlfa[i, 3], MatrizAlfa[i, 4], MatrizAlfa[i, 5]);
                            }
                            else
                            {
                                Console.WriteLine("Cliente não encontrado!!");
                            }
                        }
                    }




                }
                



            }


            


        }
    }
}
