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

            var movies = new Movie[]
            {
                new Movie { Genre = "Horror" , LengthInMinutes = 128, MovieID = 0, Price = 130, Title = "Robert The Ancient"},
                new Movie { Genre = "Action" , LengthInMinutes = 154, MovieID = 1, Price = 130, Title = "Fast & Furios"},
                new Movie { Genre = "Comedy" , LengthInMinutes = 105, MovieID = 2, Price = 130, Title = "Truman Show"}
            };

            context.Movies.AddRange(movies);
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
                new Show { LoungeID = , }
                


            };
            

            context.Shows.AddRange(show);
            context.SaveChanges();
        }
    }
}
