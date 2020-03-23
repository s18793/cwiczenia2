using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
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

            var csvPath = args.Length > 0 ? args[0] : @"Data\dane.csv";
            var resulPath = args.Length > 1 ? args[1] : @"Data\wynik";
            var type = args.Length > 2 ? args[2] : "xml";

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


            var line = File.ReadLines(csvPath);

            foreach (var lines in line)
            {
                if (!File.Exists(csvPath))
                {
                    Console.Error.Write("z³a scie¿ka");
                }
                else continue;
                string[] student = lines.Split(',');
                if (student.Length != 9)
                {

                    File.AppendAllText(@"Files\Log.txt", $"{DateTime.UtcNow} wrong informations\n");
                }


                Studies studies = new Studies
                {
                    name = student[2],
                    mode = student[3]
                };

                Student st = new Student
                {
                    Name = student[0],
                    LastName = student[1],
                    Studies = studies,
                    Id = student[4],
                    Bdate = student[5],
                    Email = student[6],
                    Mothers_Name = student[7],
                    Fathers_Name = student[8]
                };

                Studenci.Add(st);
                university.StudentsAll.Add(st);

            }


            using var writer = new FileStream($"{resulPath}.{type}", FileMode.Open);
            var serializer = new XmlSerializer(typeof(University));
            serializer.Serialize(writer, university);

            var jsonString = JsonSerializer.Serialize(university);
            File.WriteAllText($"{resulPath}.json", jsonString);












        }

        }

       
     

}
