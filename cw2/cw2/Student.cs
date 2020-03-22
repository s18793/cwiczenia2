using System;
using System.Xml.Serialization;

namespace cw2
{
    public class Student 
    {

        [XmlAttribute]
        public String Id
        {
            get; set;
        }

        public String Name
        {
            get; set;
        }
        public String LastName
        {
            get; set;
        }
        public String Bdate
        {
            get; set;
        }
        public String Email
        {
            get; set;
        }
        public Studies Studies
         {  
            get; set;

         }
        public String Mothers_Name
        {
            get; set;
        }
        public String Fathers_Name
        {
            get; set;
        }

    }

}