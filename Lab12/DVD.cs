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

        public void ListDVD()
        {
            List<string> romanceScenes = new List<string>();
            romanceScenes.Add("Two people meet");
            romanceScenes.Add("Three hearts break");
            romanceScenes.Add("They were all in love");
            DVD romantics = new DVD("Romantics", Genre.Romance, 140, romanceScenes);

            List<string> actionScenes = new List<string>();
            actionScenes.Add("the spaceship enters space");
            actionScenes.Add("the planet vs the sun");
            actionScenes.Add("the aliens discover humans");
            DVD actions = new DVD("Space Stars", Genre.Action, 220, actionScenes);

            List<string> funnyScenes = new List<string>();
            funnyScenes.Add("Weird things happen");
            funnyScenes.Add("People react strangely");
            funnyScenes.Add("A crazy event occurs");
            DVD funny = new DVD("Funny Weirdos", Genre.Comedy, 130, funnyScenes);
        }

    }
}
