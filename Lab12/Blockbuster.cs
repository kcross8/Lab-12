using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab12
{
    class Blockbuster
    {
        //public List<Movie> Movies = ListMovies();
        public static void CheckOut()
        {
            Console.WriteLine("Welcome to GC Blockbuster");
            Console.WriteLine("Please select a Movie from the list:");
            PrintMovies();
            Console.WriteLine($"Please a select a movie you want to watch (1 - {ListMovies().Count})");
            int input = int.Parse(Console.ReadLine());
            int i = 0;
            foreach (Movie movie in ListMovies())
            {
                i++;
                if (input == i)
                {
                    movie.PrintInfo();
                    Console.WriteLine("\nDo you want to watch the movie? y/n");
                    string confirm = Console.ReadLine().ToLower().Trim();
                    if (confirm == "y")
                    {
                        movie.Play();
                    }
                }
            }
               
        }
     
        public static void PrintMovies()
        {
            List<Movie> movies = ListMovies();
            int i = 0;
            foreach (Movie movie in movies)
            {
                i++;
                Console.WriteLine($"{i}. {movie.Title}");
            }
        }

        public static List<Movie> ListMovies()
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

            List<Movie> Movies = new List<Movie>();
            Movies.Add(romantics);
            Movies.Add(actions);
            Movies.Add(funny);
            Movies.Add(toolStory);
            Movies.Add(scaryDoor);
            Movies.Add(serious);

            return Movies;
        }
    }
}
