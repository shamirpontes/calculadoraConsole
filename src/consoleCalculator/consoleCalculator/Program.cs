﻿using System;

namespace consoleCalculator 
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            Menu();
        }

        static void Menu() 
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine(" 1 - Soma");
            Console.WriteLine(" 2 - Subtração");
            Console.WriteLine(" 3 - Divisão");
            Console.WriteLine(" 4 - Multiplicação");

            Console.WriteLine("---------------");
            Console.WriteLine("Selecione um opção: ");

            short result = short.Parse (Console.ReadLine());

            switch(result)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
            }
        }
        static void Soma()
        {

            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor; ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = valor1 + valor2;
            Console.WriteLine($"O resultado da soma é: {resultado} ");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao() 
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse (Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 - valor2;
            Console.WriteLine($" O resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao() 
        {

            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1/valor2;
            Console.WriteLine($" O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao() {

            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 * valor2;
            Console.WriteLine($" O resultado da multiplicação é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}
