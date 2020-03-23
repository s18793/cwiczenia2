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
            List<Student> Studenci = new List<Student>();
            String csvPath = @"C:\Users\Andrzej\source\repos\cwiczenia2\cw2\cw2\Data\dane.csv";
            String resulPath = @"C:\Users\Andrzej\source\repos\cwiczenia2\cw2\cw2\Data\wynik.xml";
            String type = "xml";

            var university = new University
            {
                Author = "Pawe³ Pietrzak"
            };

            if (args.Length == 0)
            {
                csvPath = @"dane.csv";
                resulPath = @"result.xml";
                type = "xml";
            }
            else if (args.Length == 1)
            {
                csvPath = args[0];
                resulPath = @"result.xml";
                type = "xml";
            }
            else if (args.Length == 2)
            {
                csvPath = args[0];
                resulPath = args[1];
                type = "xml";
            }
            else if (args.Length == 3)
            {
                csvPath = args[0];
                resulPath = args[1];
                type = args[2];

            }
            else
            {
                Console.Error.Write("Poda³eœ/aœ z³¹ liczbê argumentów");
                return;
            }



            if (!File.Exists(csvPath)) {
                FileNotFoundException("Podana z³a scie¿ka: " + csvPath);
            }


           
           
            











        }

        private static void FileNotFoundException(string v)
        {
            throw new NotImplementedException();
        }
    }

}
