using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Movie : IGenre
    {
        //
        public string Esrb { get; set; }
        
        public string Genre { get; set; }//
        
        public string Title { get; set; }

        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, SSsssshhhh!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Describe()
        {
            return $"{Title} is a(n) {Genre} movie, rated {Esrb}!";
        }
    }
}
