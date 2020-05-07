using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;

        public VHS(string title, Genre category, int runTime, List<string> scenes) :base(title, category, runTime, scenes)
        {

        }
        
        public override void Play()
        {
            string scene = Scenes[CurrentTime];
            Console.WriteLine();
            Console.WriteLine(scene);
            Console.WriteLine();
            CurrentTime++;
            if (CurrentTime > Scenes.Count - 1)
            {
                Rewind();
            }
            Console.WriteLine("Do you want to watch another scene? y/n");
            string confirm = Console.ReadLine().ToLower().Trim();
            if (confirm == "y")
            {
                Play();
            }
            else
            {
                Console.WriteLine("Goodbye");
            }
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }

 

    }
}
