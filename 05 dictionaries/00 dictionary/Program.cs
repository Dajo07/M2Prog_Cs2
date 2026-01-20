namespace _00_dictionary;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();

        personeelOpNummer.Add(382942, "Jim");
        personeelOpNummer.Add(789432, "Tim");

        string Jim = personeelOpNummer[382942];

        foreach (KeyValuePair<int, string> medewerker in personeelOpNummer)

        {

            foreach (int key in personeelOpNummer.Keys)
            {

            }

            foreach (string value in personeelOpNummer.Values)
            {

            }

        }
    }
    class Room
    {
        internal int x, y;
        internal Room(int x, int y, string[] level)
        {
            this.x = x;
            this.y = y;
            this.level = level;

            Room start = new Room(1, 1, new string[

                        "#####",
                        "#...#",
                        "#...#",
                        "#...#",
                        "#####"

                    ]);

            return $"{x},{y}";

             class Program 
 {
    rooms.Add(start.GetRoomLocationKey(), start);
        }
    }

        
}
