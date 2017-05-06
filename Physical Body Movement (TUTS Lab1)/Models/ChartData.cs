using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Physical_Body_Movement__TUTS_Lab1_.Models
{
    public class ChartData
    {
        public bool IsValid { get; set; } 
        public List<double> X { get; set; } = new List<double>();
        public List<double> Y { get; set; } = new List<double>();
    }
}
