namespace Menu
{
    class Program
    {
        static void Main(string[] args)

        {

            Read reader = new Read();
            List<string> primerList = reader.ReadFile("data/primer.txt");
          
            Menu primer = new Menu("Primer Año:", primerList);
            Console.WriteLine(primer.getTitle());
            Console.WriteLine();
            primer.printOptions("*");

            Console.WriteLine();
            reader.Clear();          

            
            List<string> segundoList = reader.ReadFile("data/segundo.txt");            
            Menu segundo = new Menu("Segundo Año:", segundoList);
            Console.WriteLine(segundo.getTitle());
            Console.WriteLine();
            segundo.printOptions("-");

           
            Console.WriteLine();
            reader.Clear();

            List<string> tercerList = reader.ReadFile("data/tercer.txt");
            Menu tercer = new Menu("Tercer Año:", tercerList);
            Console.WriteLine(tercer.getTitle());
            Console.WriteLine();
            tercer.printOptions("-");
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

