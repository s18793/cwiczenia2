using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace cw2
{
    public class Student 
    {

        [XmlElement(ElementName = "indexNumber")]
        [JsonPropertyName("indexNumber")]
        public String Id
        {
            get; set;
        }
        [XmlElement(ElementName = "fname")]
        [JsonPropertyName("fname")]

        public String Name
        {
            get; set;
        }
        [XmlElement(ElementName = "lname")]
        [JsonPropertyName("lname")]
        public String LastName
        {
            get; set;
        }
        [XmlElement(ElementName = "birthdate")]
        [JsonPropertyName("birthdate")]
        public String Bdate
        {
            get; set;
        }
        [XmlElement(ElementName = "email")]
        [JsonPropertyName("email")]
        public String Email
        {
            get; set;
        }
        [XmlElement(ElementName = "studies")]
        [JsonPropertyName("studies")]
        public Studies Studies
         {  
            get; set;

         }
        [XmlElement(ElementName = "mothersName")]
        [JsonPropertyName("mothersName")]
        public String Mothers_Name
        {
            get; set;
        }
        [XmlElement(ElementName = "fathersName")]
        [JsonPropertyName("fathersName")]
        public String Fathers_Name
        {
            get; set;
        }

    }

}