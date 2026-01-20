namespace _00_file_toevoegen;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Program program = new Program();
        program.Run();
    }
    private void Run()
    {
        Console.WriteLine(Environment.CurrentDirectory);

        // YOU ARE AN IDIOT HAHAHAHA :)

        string[] lines = System.IO.File.ReadAllLines("quiz.txt");

        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }
        string[] artikelLines = System.IO.File.ReadAllLines("nos.nl.txt");

        for (int i = 0; i < artikelLines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }
    }

}
