using System;

namespace TV_shows
{
    class TVshow
    {

        public int id { get; set; }

        public string name { get; set; }

        public bool favorite { get; set; }


        public void showTVshow()
        {

            Console.Write(id);
            Console.Write(" |\t");
            Console.Write(name);
            Console.Write(" |\t");
            if (favorite)
            {
                Console.Write("*");

            }
            Console.WriteLine("");
        }



    }
}
