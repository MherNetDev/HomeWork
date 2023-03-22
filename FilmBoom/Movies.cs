﻿using System.Reflection;

namespace FilmBoom
{
    delegate void MethodDelegate();

    class Movies : IMovies
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string[] Actors { get; set; }
        public string Plot { get; set; }
        public int choice { get; set; }


        public void DlgMeth()
        {
            MethodDelegate[] methods = new MethodDelegate[]
            {
            Avengers_M,
            AceVentura_M,
            RushHour_M,
            OnePlusOne_M
             };
            methods[choice].Invoke();
        }


        static void Avengers_M()
        {
            Movies myMovie = new Movies();
            myMovie.Title = "Avengers";
            myMovie.Year = 2012;
            myMovie.Director = " Joss Whedon";
            myMovie.Actors = new string[] { "Robert Downey Jr.", "Chris Evans", "Mark Ruffalo", "Chris Hemsworth", "Scarlett Johansson"};
            myMovie.Plot = "Earth's mightiest heroes must come together and learn to fight as a team if they are going to stop the mischievous Loki and his alien army from enslaving humanity.";
            Write(myMovie.Title, myMovie.Year, myMovie.Director, myMovie.Actors, myMovie.Plot);
        }

        static void AceVentura_M()
        {
            Movies myMovie = new Movies();
            myMovie.Title = "Ace Ventura";
            myMovie.Year = 1994;
            myMovie.Director = "Tom Shadyac";
            myMovie.Actors = new string[] { "Jim Carrey", "Courteney Cox", "Sean Young", "Tone Loc", "Dan Marino" };
            myMovie.Plot = "A goofy detective specializing in animals goes in search of the missing mascot of the Miami Dolphins.";
            Write(myMovie.Title, myMovie.Year, myMovie.Director, myMovie.Actors, myMovie.Plot);
        }

        static void RushHour_M()
        {
            Movies myMovie = new Movies();
            myMovie.Title = "1+1";
            myMovie.Year = 2011;
            myMovie.Director = "Olivier Nakache, Éric Toledano";
            myMovie.Actors = new string[] { "François Cluzet", "Omar Sy", "Anne Le Ny", "Audrey Fleurot", "Joséphine de Meaux" };
            myMovie.Plot = "After he becomes a quadriplegic from a paragliding accident, an aristocrat hires a young man from the projects to be his caregiver.";
            Write(myMovie.Title, myMovie.Year, myMovie.Director, myMovie.Actors, myMovie.Plot);
        }
        static void OnePlusOne_M()
        {
            Movies myMovie = new Movies();
            myMovie.Title = "Avengers";
            myMovie.Year = 2012;
            myMovie.Director = " Joss Whedon";
            myMovie.Actors = new string[] { "Robert Downey Jr.", "Chris Evans", "Mark Ruffalo", "Chris Hemsworth", "Scarlett Johansson" };
            myMovie.Plot = "Earth's mightiest heroes must come together and learn to fight as a team if they are going to stop the mischievous Loki and his alien army from enslaving humanity.";
            Write(myMovie.Title, myMovie.Year, myMovie.Director, myMovie.Actors, myMovie.Plot);
        }


        static void Write(string Title,int Year,string Director, string[] Actors,string Plot ) {

            Console.WriteLine("Title - "+ Title+"\n");
            Console.WriteLine("Year - "+ Year + "\n");
            Console.WriteLine("Director - "+ Director+"\n");
            Console.WriteLine("Actors - "+"{0}", string.Join(", ", Actors)+"\n");
            Console.WriteLine("Plot - "+Plot+"\n");
        }

    }
}
