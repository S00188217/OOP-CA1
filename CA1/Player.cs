using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Player
    {
        public string Name { get; set; }
        public decimal Value { get; set; }


        public override string ToString()
        {
            return $"{Name} - {Value}";
        }
    }

}
