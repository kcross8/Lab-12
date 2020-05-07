using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12
{
    class DVD : Movie
    {
        public DVD(string title, Genre category, int runTime, List<string> scenes) : base(title, category, runTime, scenes)
        {

        }
        public override void Play()
        {    
            PrintScenes();
            Console.WriteLine();
            Console.WriteLine($"Which scene would you like to watch? (Select 0 to {Scenes.Count - 1})");
            string input = Console.ReadLine();
            int select = int.Parse(input);
            if (select > Scenes.Count - 1)
            {
                Console.WriteLine($"That is not an option. (Select 0 to {Scenes.Count - 1})");
                Play();
            }
            string scene = Scenes[select];
            Console.WriteLine($"\n{scene}");
            Console.WriteLine("Do you want to watch another scene? y/n");
            string confirm = Console.ReadLine().ToLower().Trim();
            if (confirm == "y")
            {
                Console.WriteLine();
                Play();
            }
            else
            {
                Console.WriteLine("Goodbye");
            }
        }



    }
}
