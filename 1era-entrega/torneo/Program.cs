namespace Menu
{
    class Program
    {
        static void Main(string[] args)

        {

            Read reader = new Read();
            List<string> primeraList = reader.ReadFile("data/primera-fase.txt");
          
            Menu primera = new Menu("Primera Fase:", primeraList);
            Console.WriteLine(primera.getTitle());
            Console.WriteLine();
            primera.printOptions();

            Console.WriteLine();
            reader.Clear();          

            
            List<string> octavosList = reader.ReadFile("data/octavos.txt");            
            Menu octavos = new Menu("Octavos:", octavosList);
            Console.WriteLine(octavos.getTitle());
            Console.WriteLine();
            octavos.printOptions();

           
            Console.WriteLine();
            reader.Clear();

            List<string> cuartosList = reader.ReadFile("data/cuartos.txt");
            Menu cuartos = new Menu("Cuartos:", cuartosList);
            Console.WriteLine(cuartos.getTitle());
            Console.WriteLine();
            cuartos.printOptions();



            Console.WriteLine();
            reader.Clear();

            List<string> semiList = reader.ReadFile("data/semi.txt");
            Menu semi = new Menu("SemiFinal:", semiList);
            Console.WriteLine(semi.getTitle());
            Console.WriteLine();
            semi.printOptions();


            Console.WriteLine();
            reader.Clear();

            List<string> tercerList = reader.ReadFile("data/tercer.txt");
            Menu tercer = new Menu("Tercer Puesto:", tercerList);
            Console.WriteLine(tercer.getTitle());
            Console.WriteLine();
            tercer.printOptions();

            Console.WriteLine();
            reader.Clear();

            List<string> finalList = reader.ReadFile("data/final.txt");
            Menu final = new Menu("Final:", finalList);
            Console.WriteLine(final.getTitle());
            Console.WriteLine();
            final.printOptions();
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

            

            public void printOptions()

            {
                foreach (string option in Options)
                {
                    Console.WriteLine(option);

                }

            }

            public string getTitle()
            {
                return Title;
            }
        }
    }
}

