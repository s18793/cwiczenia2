using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cw2
{
    public class University
    {
        public University()
        {

            List<Student> studList = new List<Student>();
            List<Student> activStud = new List<Student>();



        }
        [XmlAttribute]
        public String Author
        {
            get; set;
        }

    }
}



