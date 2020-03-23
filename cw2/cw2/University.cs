using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cw2
{
    public class University
    {

        public University()
        {

            StudentsAll = new List<Student>();
            CreateDate = DateTime.Now.ToString("yyyy-mm-dd");
            StudentsActiv = new List<Student>();




        }

        [XmlAttribute(AttributeName = "Author")]
        [JsonPropertyName("Author")]
        public String Author
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "CreatedAt")]
        [JsonPropertyName("CreatedAt")]
        public string CreateDate
        {
            get; set;
        }

        public List<Student> StudentsAll
        {
            get; set;
        }

        public List<Student> StudentsActiv
        {
            get; set;
        }
       
        
    }
}



