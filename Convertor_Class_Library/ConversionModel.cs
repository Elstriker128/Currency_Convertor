using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor_Class_Library
{
    public class ConversionModel
    {
        public string Base_code { get; set; }
        public string Target_code { get; set; }
        public decimal Conversion_rate { get; set; }
        public decimal Conversion_result { get; set; }
    }
}
