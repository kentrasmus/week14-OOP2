using System;
using System.IO;

namespace ObjectsFromFile
{
    class Program
    {
        class Movie
        {
            string title;
            string rating;
            string year;
            
            public Movie(string _title, string _rating, string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;

            }
        }
        static void Main(string[] args)
        {
           foreach(string movie in GetDataFromFiles())
            {
                string[] tempArry = movie.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Title:, rating:, year:");
        }
        public static string[] GetDataFromFiles()
        {
            string filePath = @"C:\Users\opilane\samples\movies.txt";
            string[] dataFormFile = File.ReadAllLines(filePath);
            return dataFormFile;
        }
        public static void DisplayArryElements(string[] someArrys)
        {
            foreach(string element in someArrys)
            {
                Console.WriteLine(element);
            }

        }

    }
}
