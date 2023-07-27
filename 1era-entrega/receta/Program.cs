﻿using System;


namespace Menu
{
    class Program
    {
        static void Main(string[] args)

        {

            Read reader = new Read();
            List<string> ingredientesList = reader.ReadFile("data/receta.txt");
          
            Menu ingredientes = new Menu("Ingredientes:", ingredientesList);
            Console.WriteLine(ingredientes.getTitle());
            Console.WriteLine();
            ingredientes.printOptions("*");

            Console.WriteLine();
            reader.Clear();          

            
            List<string> preparacionList = reader.ReadFile("data/preparacion.txt");            
            Menu preparacion = new Menu("Preparacion:", preparacionList);
            Console.WriteLine(preparacion.getTitle());
            Console.WriteLine();
            preparacion.printOptions("-");

           
            Console.WriteLine();
            reader.Clear();

            List<string> horneadoList = reader.ReadFile("data/horneado.txt");
            Menu horneado = new Menu("Horneado y preparacion de la torta:", horneadoList);
            Console.WriteLine(horneado.getTitle());
            Console.WriteLine();
            horneado.printOptions("-");
        }

        class Menu
        {
            private string Title;
            private List<string> Options;      

            public Menu(string title, List<string> options)
            {
                Title = title;
                Options = options;
            }

            

            public void printOptions(string simbol)

            {
                for (int i = 0; i < Options.Count(); i++)
                {

                    Console.WriteLine($"{(simbol == "-" ? ($"{i + 1}-") : simbol)} {Options[i]}");
                }

            }

            public string getTitle()
            {
                return Title;
            }
        }
    }
}
