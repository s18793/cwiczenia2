using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace cw2
{
    public class Program
    {
       public static void Main(string[] args)
        {

            var csvPath = @"C:\Users\Andrzej\source\repos\cwiczenia2\cw2\cw2\Data\dane.csv";
            var resulPath = @"C:\Users\Andrzej\source\repos\cwiczenia2\cw2\cw2\Data\wynik.xml";
            var type = "xml";

            var university = new University
            {
                Author = "Pawe³ Pietrzak"
            };

            if (!File.Exists(csvPath)){
                FileNotFoundException("Podana z³a scie¿ka: " + csvPath);
            }


            



        }

        private static void FileNotFoundException(string v)
        {
            throw new NotImplementedException();
        }
    }

}
