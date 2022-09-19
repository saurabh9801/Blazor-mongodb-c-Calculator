using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    public class Calculator
    {
       
        public double FirstNum { get; set; }

        public double SecondNum { get; set; }

        public string? Operator { get; set; }

        public double Result { get; set; }
        public DateTime CreatedOn { get; set; }
        
       
    }
    
}

