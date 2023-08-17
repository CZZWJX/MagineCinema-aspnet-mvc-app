using MagineCinema.Data.Enums;
using MagineCinema.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace MagineCinema.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            //TO ADD DATA ETC
            using(var servicesScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = servicesScope.ServiceProvider.GetService<AppDBContext>();

                context.Database.EnsureCreated();

                //Movie
                //If nothing inside this table
                if (!context.Movie.Any())
                {
                    context.Movie.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            name = "Lost In The Stars",
                            synopsis = "A man`s wife disappears during their anniversary trip to a romantic getaway on an island. When she reappears, he insists that this new woman isn`t his wife. When a top lawyer gets involved in this bizarre case, more mysteries start to emerge.",
                            price = 24.00,
                            imageURL = "../wwwroot/images/movies/LostInTheStars.jpg",
                            startDate = new System.DateTime(2023, 07, 27),
                            endDate = new System.DateTime(2023, 08, 30),
                            language = Enums.Language.Mandarin,
                            rate = Enums.Rate.PG16,
                            movieLength = 120,
                            MovieCategories = string.Join(",", new List<MovieCategory>
                            {
                                MovieCategory.Crime,
                                MovieCategory.Mystery
                            }),
                            movieStatus = MovieStatus.Active
                        }
                    });
                    context.SaveChanges();
                }

                //Actor
                if (!context.Actor.Any())
                {
                    context.Actor.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                           profilePictureURL = "../wwwroot/images/actors/ni_ni.jpg",
                           fullName = "Ni Ni",
                           bio = "Ni Ni (Chinese: 倪妮; pinyin: Ní Nī, born 8 August 1988) is a Chinese actress best known for portraying Yu Mo in the 2011 film The Flowers of War, directed by Zhang Yimou; and Ling Xi in the 2019 television series Love and Destiny. She is considered to be one of the “New Four Dan Actresses” by Southern Metropolis Daily."
                        },
                        
                        new Actor()
                        {
                           profilePictureURL = "../wwwroot/images/actors/zhu_yi_long.jpg",
                           fullName = "Zhu Yi Long",
                           bio = "Zhu Yilong (Chinese: 朱一龙, born 16 April 1988) is a Chinese actor.[1][2] He is best known for his performance as Mo Sanmei in the drama film Lighting Up the Stars (2022), a movie with a budge of $8 million and box office of $253.8 million,[3] and for which he won the Best Actor award at the 35th Golden Rooster Awards.[4] He is also well known for his roles in Guardian (2018), The Story of Minglan (2018), Reunion: The Sound of the Providence (2020), Embrace Again (2021) and The Rebel (2021)."
                        },
                        
                        new Actor()
                        {
                           profilePictureURL = "../wwwroot/images/actors/du_jiang.jpg",
                           fullName = "Du Jiang",
                           bio = "Du Jiang (杜江), born on September 10, 1985, in Jinan, Shandong, China, is a Chinese actor. His main works include Finding Mr. Right, Operation Red Sea, Flash Over, The Bravest, etc."
                        }
                    });
                    context.SaveChanges();
                }
                
                //Director
                if (!context.Director.Any())
                {
                    context.Director.AddRange(new List<Director>()
                    {
                        new Director()
                        {
                            profilePictureURL = "../wwwroot/images/director/cui_rui.jpg",
                            fullName = "Cui Rui",
                            bio = "Rui Cui is known for Spring Flower (2017), To Pimp a Butterfly (2017) and Free Choice (2017)."
                        },

                        new Director()
                        {
                            profilePictureURL = "../wwwroot/images/director/liu_xiang.jpg",
                            fullName = "Liu Xiang",
                            bio = "Liu Xiang, Director, director of photography, screenwriter. Graduated from Tianjin University with a major in chemical engineering and technology, and a major in photography from the French 3IS Film Academy. He has been engaged in photography in China and France for a long time."
                        }

                    });
                    context.SaveChanges();
                }

                //Actor_Movie
                if (!context.Actor_Movie.Any())
                {
                    context.Actor_Movie.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            actorId = 2,
                            movieId = 3
                        },
                        
                        new Actor_Movie()
                        {
                            actorId = 3,
                            movieId = 3
                        },
                        
                        new Actor_Movie()
                        {
                            actorId = 4,
                            movieId = 3
                        }
                    });
                    context.SaveChanges();
                } 
                
                //Director_Movie
                if (!context.Director_Movie.Any())
                {
                    context.Director_Movie.AddRange(new List<Director_Movie>()
                    {
                        new Director_Movie()
                        {
                            directorId = 2,
                            movieId = 3
                        },
                        
                        new Director_Movie()
                        {
                            directorId = 3,
                            movieId = 3
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
