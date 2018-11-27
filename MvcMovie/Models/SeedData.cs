using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Errand of Angels",
                        ReleaseDate = DateTime.Parse("2008-01-01"),
                        Genre = "Drama",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt1029285/",
                        Directors = "Christian Vuissa",
                        RunTime = 91
                    },

                    new Movie
                    {
                        Title = "Charly",
                        ReleaseDate = DateTime.Parse("2002-09-20"),
                        Genre = "Comedy, Drama, Romance",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0330136/",
                        Directors = "Adam Thomas Anderegg",
                        RunTime = 103
                    },

                    new Movie
                    {
                        Title = "One Man's Treasure",
                        ReleaseDate = DateTime.Parse("2009-01-31"),
                        Genre = "Adventure",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt1303776/",
                        Directors = "John Lyde",
                        RunTime = 85
                    },

                    new Movie
                    {
                        Title = "Suits on the Loose",
                        ReleaseDate = DateTime.Parse("2005-10-14"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0405357/",
                        Directors = "Rodney Henson",
                        RunTime = 94
                    },

                    new Movie
                    {
                        Title = "Mobsters and Mormons",
                        ReleaseDate = DateTime.Parse("2005-09-09"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0439707/",
                        Directors = "John E. Moyer",
                        RunTime = 90
                    },

                    new Movie
                    {
                        Title = "Baptists at Our Barbecue",
                        ReleaseDate = DateTime.Parse("2004-10-08"),
                        Genre = "Comedy, Romance",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0391104/",
                        Directors = "Christian Vuissa",
                        RunTime = 92
                    },

                    new Movie
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-01-30"),
                        Genre = "Comedy, Drama, Romance",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0306069/",
                        Directors = "Kurt Hale",
                        RunTime = 102
                    },

                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-02-20"),
                        Genre = "Comedy, Drama",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0377038/",
                        Directors = "Scott S. Anderson",
                        RunTime = 112
                    },

                    new Movie
                    {
                        Title = "Once I Was a Beehive",
                        ReleaseDate = DateTime.Parse("2015-08-14"),
                        Genre = "Comedy, Drama, Family",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt4002772/",
                        Directors = "Maclain Nelson",
                        RunTime = 119
                    },
                    
                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = "Adventure, Biography, Drama",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0250371/",
                        Directors = "Mitch Davis",
                        RunTime = 113
                    },

                    new Movie
                    {
                        Title = "The Work and the Glory",
                        ReleaseDate = DateTime.Parse("2004-11-24"),
                        Genre = "Romance, Drama",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0410454/",
                        Directors = "Russell Holt",
                        RunTime = 118
                    },

                    new Movie
                    {
                        Title = "The Singles 2nd Ward",
                        ReleaseDate = DateTime.Parse("2007-12-11"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt1109520/",
                        Directors = "Kurt Hale",
                        RunTime = 87
                    },

                    new Movie
                    {
                        Title = "The Work and the Glory II: American Zion",
                        ReleaseDate = DateTime.Parse("2005-10-13"),
                        Genre = "Drama, Western",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0457530/",
                        Directors = "Sterling Van Wagenen",
                        RunTime = 100
                    },

                    new Movie
                    {
                        Title = "Ephraim's Rescue",
                        ReleaseDate = DateTime.Parse("2013-05-31"),
                        Genre = "Adventure, Drama, History",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt2509298/",
                        Directors = "T.C. Christensen",
                        RunTime = 99
                    },
                    
                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-06-03"),
                        Genre = "Adventure, History",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt1909270/",
                        Directors = "T.C. Christensen",
                        RunTime = 113
                    },
                    
                    new Movie
                    {
                        Title = "God's Army",
                        ReleaseDate = DateTime.Parse("2000-03-10"),
                        Genre = "Drama",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0238247/",
                        Directors = "Richard Dutcher",
                        RunTime = 108
                    },

                    new Movie
                    {
                        Title = "Brigham City",
                        ReleaseDate = DateTime.Parse("2001-03-30"),
                        Genre = "Crime, Drama, Mystery",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0268200/",
                        Directors = "Richard Dutcher",
                        RunTime = 119
                    },
                    
                    new Movie
                    {
                        Title = "States of Grace",
                        ReleaseDate = DateTime.Parse("2005-11-04"),
                        Genre = "Drama",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0395561/",
                        Directors = "Richard Dutcher",
                        RunTime = 128
                    },
                    
                    new Movie
                    {
                        Title = "The Work and the Glory III: A House Divided",
                        ReleaseDate = DateTime.Parse("2006-11-22"),
                        Genre = "Drama, Western",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0460611/",
                        Directors = "Sterling Van Wagenen",
                        RunTime = 89
                    },

                    new Movie
                    {
                        Title = "The Saratov Approach",
                        ReleaseDate = DateTime.Parse("2013-10-09"),
                        Genre = "Action, Drama, Thriller",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt2887322/",
                        Directors = "Garrett Batty",
                        RunTime = 107
                    },

                    new Movie
                    {
                        Title = "Freetown",
                        ReleaseDate = DateTime.Parse("2015-04-08"),
                        Genre = "Action, Drama, Thriller, War",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt3735554/",
                        Directors = "Garrett Batty",
                        RunTime = 113
                    },
                    
                    new Movie
                    {
                        Title = "The Book of Mormon Movie, Volume 1: The Journey",
                        ReleaseDate = DateTime.Parse("2003-09-12"),
                        Genre = "Adventure",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0349159/",
                        Directors = "Gary Rogers",
                        RunTime = 120
                    },

                    new Movie
                    {
                        Title = "Christmas Mission",
                        ReleaseDate = DateTime.Parse("1999-12-25"),
                        Genre = "Short, Drama",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0279732/",
                        Directors = "Michael L. Schaertl",
                        RunTime = 30
                    },

                    new Movie
                    {
                        Title = "The R.M.",
                        ReleaseDate = DateTime.Parse("2003-01-24"),
                        Genre = "Comedy, Crime, Family",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0341540/",
                        Directors = "Kurt Hale",
                        RunTime = 101
                    },

                    new Movie
                    {
                        Title = "Passage to Zarahemla",
                        ReleaseDate = DateTime.Parse("2007-10-15"),
                        Genre = "Adventure, Fantasy",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0479974/",
                        Directors = "Chris Heimerdinger",
                        RunTime = 90
                    },

                    new Movie
                    {
                        Title = "The Home Teachers",
                        ReleaseDate = DateTime.Parse("2004-01-09"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0377071/",
                        Directors = "Kurt Hale",
                        RunTime = 82
                    },

                    new Movie
                    {
                        Title = "Sons of Provo",
                        ReleaseDate = DateTime.Parse("2004-10-30"),
                        Genre = "Comedy, Music",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0396223/",
                        Directors = "Will Swenson",
                        RunTime = 93
                    },

                    new Movie
                    {
                        Title = "The Return",
                        ReleaseDate = DateTime.Parse("2006-01-21"),
                        Genre = "Comedy, Drama, Romance",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0478262/",
                        Directors = "Michael Amundsen",
                        RunTime = 105
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = "Documentary",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt4003774/",
                        Directors = "Blair Treu",
                        RunTime = 78
                    },

                    new Movie
                    {
                        Title = "The Dance",
                        ReleaseDate = DateTime.Parse("2007-04-06"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0799997/",
                        Directors = "McKay Daines",
                        RunTime = 81
                    },
                    
                    new Movie
                    {
                        Title = "The Cokeville Miracle",
                        ReleaseDate = DateTime.Parse("2015-06-05"),
                        Genre = "Drama, Family, History, Mystery, Thriller",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt3877296/",
                        Directors = "T.C. Christensen",
                        RunTime = 94
                    },

                    new Movie
                    {
                        Title = "Silent Night",
                        ReleaseDate = DateTime.Parse("2012-11-22"),
                        Genre = "Biography, Drama, Music",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt2562132/",
                        Directors = "Christian Vuissa",
                        RunTime = 95
                    },

                    new Movie
                    {
                        Title = "You're So Cupid!",
                        ReleaseDate = DateTime.Parse("2010-02-12"),
                        Genre = "Family, Fantasy, Romance",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt1464606/",
                        Directors = "John Lyde",
                        RunTime = 93
                    },

                    new Movie
                    {
                        Title = "Emma Smith: My Story",
                        ReleaseDate = DateTime.Parse("2008-04-11"),
                        Genre = "Biography, Drama, History",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt1091225/",
                        Directors = "T.C. Christensen, Gary Cook",
                        RunTime = 98
                    },

                    new Movie
                    {
                        Title = "Saints and Soldiers",
                        ReleaseDate = DateTime.Parse("2003-09-11"),
                        Genre = "Action, Drama, War",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0373283/",
                        Directors = "Ryan Little",
                        RunTime = 90
                    },

                    new Movie
                    {
                        Title = "Saints and Soldiers: The Void",
                        ReleaseDate = DateTime.Parse("2014-08-15"),
                        Genre = "Action, Drama, War",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt1270114/",
                        Directors = "Ryan Little",
                        RunTime = 94
                    },

                    new Movie
                    {
                        Title = "Saints and Soldiers: Airborne Creed",
                        ReleaseDate = DateTime.Parse("2012-08-17"),
                        Genre = "Action, Drama, War",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt2082415/",
                        Directors = "Ryan Little",
                        RunTime = 94
                    },

                    new Movie
                    {
                        Title = "Out of Step",
                        ReleaseDate = DateTime.Parse("2002-02-15"),
                        Genre = "Drama",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0311614/",
                        Directors = "Ryan Little",
                        RunTime = 90
                    },

                    new Movie
                    {
                        Title = "16 Stones",
                        ReleaseDate = DateTime.Parse("2014-10-01"),
                        Genre = "Adventure",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt1212054/",
                        Directors = "Brian Brough",
                        RunTime = 93
                    },

                    new Movie
                    {
                        Title = "Inspired Guns",
                        ReleaseDate = DateTime.Parse("2014-01-24"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt2738706/",
                        Directors = "Adam White",
                        RunTime = 99
                    },

                    new Movie
                    {
                        Title = "Forever Strong",
                        ReleaseDate = DateTime.Parse("2008-09-26"),
                        Genre = "Drama, Sport",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt0840322/",
                        Directors = "Ryan Little",
                        RunTime = 112
                    },

                    new Movie
                    {
                        Title = "Melted Hearts",
                        ReleaseDate = DateTime.Parse("2009-01-01"),
                        Genre = "Comedy, Romance",
                        Price = 9.99M,
                        URL = "https://www.imdb.com/title/tt1580286/",
                        Directors = "Jorge Ramirez Rivera",
                        RunTime = 95
                    }

                );
                context.SaveChanges();
            }
        }
    }
}