using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0; //setting an initial value 0

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

        public void ListVHS()
        {
            List<string> toolScenes = new List<string>();
            toolScenes.Add("The hammer vs the screwdriver");
            toolScenes.Add("The tools run away");
            toolScenes.Add("The workers reunite with the tools");
            VHS toolStory = new VHS("Tool Story", Genre.Comedy, 120, toolScenes);

            List<string> scaryScenes = new List<string>();
            scaryScenes.Add("Looking at a scary door");
            scaryScenes.Add("Going inside the scary door");
            scaryScenes.Add("Being scared by the scary door");
            VHS scaryDoor = new VHS("The Scary Door", Genre.Horror, 140, scaryScenes);

            List<string> dramaScenes = new List<string>();
            dramaScenes.Add("People acting serious");
            dramaScenes.Add("Serious things happening");
            dramaScenes.Add("A surprising twist");
            VHS serious = new VHS("Serious People", Genre.Drama, 180, dramaScenes);

        }

    }
}
