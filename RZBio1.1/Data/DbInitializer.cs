using RZBio1._1.Models;


namespace RZBio1._1.Data
{
    public class DbInitializer
    {
        
        public static void Initialize(CinemaContext context)
        {
            //context.Database.EnsureCreated();     

            if (context.Movies.Any())
            {
                return;   // DB has been seeded
            }

            var movie = new Movie[]
            {
                new Movie { Genre = "Horror" , LengthInMinutes = 128, MovieID = 0, Price = 130, Title = "Robert The Ancient"},
                new Movie { Genre = "Action" , LengthInMinutes = 154, MovieID = 1, Price = 130, Title = "Fast & Furious"},
                new Movie { Genre = "Comedy" , LengthInMinutes = 105, MovieID = 2, Price = 130, Title = "Truman Show"}
            };

            context.Movies.AddRange(movie);
            context.SaveChanges();

           var lounge = new Lounge[]
           {
                new Lounge { ChairsAmount = 120, LoungeID = 0, },
                new Lounge { ChairsAmount = 60, LoungeID = 1, },
                new Lounge { ChairsAmount = 60, LoungeID = 2, }
           };

            context.Lounges.AddRange(lounge);
            context.SaveChanges();


            var show = new Show[]
            {
                //Behöver kopplas till Lounge...
                new Show { ShowID = 0 ,LoungeID = lounge.Single(l => l.LoungeID == 0), Date = DateOnly.Parse("2023-12-05"), 
                    MovieToShow = movie.Single(m => m.Title == "Robert The Ancient"), TimeStart = TimeOnly.Parse("19:00:00")},

                new Show { ShowID = 1 ,LoungeID = lounge.Single(l => l.LoungeID == 1), Date = DateOnly.Parse("2023-12-06"),
                    MovieToShow = movie.Single(m => m.Title == "Truman Show"), TimeStart = TimeOnly.Parse("15:00:00")},

                 new Show { ShowID = 1 ,LoungeID = lounge.Single(l => l.LoungeID == 2), Date = DateOnly.Parse("2023-12-06"),
                    MovieToShow = movie.Single(m => m.Title == "Fast & Furious"), TimeStart = TimeOnly.Parse("15:00:00")}
            };
            

            context.Shows.AddRange(show);
            context.SaveChanges();
        }
    }
}
