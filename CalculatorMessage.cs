using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CalculatorClassLibrary
{
    public  class CalculatorMessage
    {
        
        [JsonProperty("FirstNum")]
        public double FirstNum { get; set; }
        [JsonProperty("SecondNum")]
        public double SecondNum { get; set; }
        [JsonProperty("Operator")]
        public string? Operator { get; set; }
        [JsonProperty("Result")]
        public double Result { get; set; }
        public DateTime CreatedOn { get; set; }

        
    }
}
