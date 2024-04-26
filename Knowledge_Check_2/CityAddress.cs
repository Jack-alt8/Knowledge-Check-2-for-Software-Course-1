using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge_Check_2
{
    internal class CityAddress : StateAddress
    {
        public string CityName { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
    }
}
