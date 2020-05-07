using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12
{
    abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string title, Genre category, int runTime, List<string> scenes)
        {
            Title = title;
            Category = category;
            RunTime = runTime;
            Scenes = scenes;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"\nTitle: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Runtime: {RunTime}");            
        }

        public void PrintScenes()
        {
            int i = 0;
            foreach (string scene in Scenes)
            {
                Console.WriteLine($"{i}: {scene}");
                i++;
            }
        }
        public abstract void Play(); //child classes will fill in
        

    }
}
