namespace _01_functions

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        internal void Run()
        {
            Console.WriteLine("Hello");

            Console.WriteLine("do you know Tom Clancy the Division?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);

            Console.WriteLine("would you survive in Tom Clanys the Division?");
            string antwoord2 = Console.ReadLine();
            Console.WriteLine(antwoord2);

            Console.WriteLine("Do you like pasta?");
            string antwoord3 = Console.ReadLine();
            Console.WriteLine(antwoord3);

            Console.WriteLine("Do you like shooters games?");
            string antwoord4 = Console.ReadLine();
            Console.WriteLine(antwoord4);

            Console.WriteLine("do you like water?");
            string antwoord5 = Console.ReadLine();
            Console.WriteLine(antwoord5);
        }
    }

}
