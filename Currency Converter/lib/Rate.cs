using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Rate
    {
        public string target { get; set; }
        public bool success { get; set; }
        public double rate { get; set; }
        public string source { get; set; }
        public double amount { get; set; }
        public string message { get; set; }
    }
}
