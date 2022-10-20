using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace WebApplication2.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDBContext(serviceProvider.GetRequiredService<DbContextOptions<AppDBContext>>()))
            {
                var home = new List<Home>

                {
                        new Home
                    {
                        HomeType = "Pineapple",
                        IsNeighbour = true
                    },
                    new Home
                    {
                        HomeType = "Rock",
                        IsNeighbour = true
                    },
                    new Home
                    {
                        HomeType = "Moai statue",
                        IsNeighbour = true
                    },
                    new Home
                    {
                        HomeType = "Anchor",
                        IsNeighbour = false
                    },
                    new Home
                    {
                        HomeType = "Tree",
                        IsNeighbour = false
                    }
                };

                if (!context.home.Any())
                {
                    home.ForEach(x => context.home.Add(x));
                
                }
                if (context.users.Any())
                {
                    return;
                }
                

                context.users.AddRange(
                    new User
                    {
      
                        FirstName = "SpongeBoB ",
                        LastName = "SquarePants",
                        Job = "Fry cook",
                        JobPlace = "Krusty Krab",
                        SkinCollor = "Light yellow with olive-green holes",
                        Home = home[0]
                        
                    },
                     new User
                     {
                        
                         FirstName = "Patrick",
                         LastName = "Star",
                         Job = "Non",
                         JobPlace ="Non",
                         SkinCollor = "Coral pink with red dots and outline",
                         Home = home[1]

                     },
                      new User
                      {
                        
                          FirstName = "Squidward",
                          LastName = "Tentacles",
                          Job = "Cashier",
                          JobPlace = "Krusty Krab",
                          SkinCollor = "Turquoise",
                          Home = home[2]

                      },
                       new User
                       {
                          
                           FirstName = "Eugene",
                           LastName = "Krabs",
                           Job = "Owner",
                           JobPlace = "Krusty Krab",
                           SkinCollor = "Crimson red",
                           Home = home[3]
                       },
                        new User
                        {
                        
                            FirstName = "Sandy",
                            LastName = "Cheeks",
                            Job = "Scientist",
                            JobPlace = "Own Laboratory",
                            SkinCollor = "Brown",
                            Home = home[4]
                        }
                    );

                context.SaveChanges();
            }

        }

    }
}

