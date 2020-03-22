using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cw2
{
    public class Studies
    {
        [XmlElement(ElementName = "name")]
        [JsonPropertyName("name")]
        public string name { get; set; }
        [XmlElement(ElementName = "mode")]
        [JsonPropertyName("mode")]
        public string mode { get; set; }
    }
}