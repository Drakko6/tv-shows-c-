using System;
using System.Collections.Generic;
using System.Linq;

namespace TV_shows
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TVshow> list = new List<TVshow>
            {
                new TVshow{ id =1, name = "Breaking Bad", favorite= false },
                new TVshow{ id =2, name = "Person of Interest", favorite= false  },
                new TVshow{ id =3, name = "Under the Dome", favorite= false   },
                new TVshow { id = 4, name = "Bitten", favorite= false  },
                new TVshow { id = 5, name = "Arrow", favorite= false  },
                new TVshow { id = 6, name = "Flash", favorite= false  },
                new TVshow { id = 7, name = "True Detective", favorite= true  },
                new TVshow { id = 8, name = "The 100", favorite= false  },
                new TVshow { id = 9, name = "Glee", favorite= false  },
                new TVshow { id = 10, name = "Homeland", favorite= false  },
            };
            List<TVshow> sortedList = list.OrderBy(o => o.name).ToList();
            Console.WriteLine("\t\tMy TV shows");
            Console.WriteLine("");
            foreach (TVshow show in sortedList)
            {
                show.showTVshow();
            }
            do
            {
                string input = Console.ReadLine();
                try
                {
                    if (Int32.Parse(input) > 0)
                    {
                        foreach (TVshow show in sortedList)
                        {
                            if (Int32.Parse(input) == show.id)
                            {
                                show.favorite = !show.favorite;
                                show.showTVshow();
                                Console.WriteLine("");
                            }
                        }

                    }
                }
                catch (FormatException)
                {
                    if (input == "favorites")
                    {
                        foreach (TVshow show in sortedList)
                        {
                            if (show.favorite)
                            {
                                show.showTVshow();
                            }
                        }
                        Console.WriteLine("");
                    }

                    if (input == "list")
                    {
                        foreach (TVshow show in sortedList)
                        {
                            show.showTVshow();
                        }
                        Console.WriteLine("");
                    }
                }

            } while (true);

        }
    }
}
