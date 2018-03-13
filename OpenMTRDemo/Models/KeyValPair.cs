using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTRDemo.Models
{
    //This class is created out of the necessity to make key value pairs mutable
    public class KeyValPair<KeyType>
    {
        public KeyType Id { get; set; }
        public MeterImage Meter { get; set; }

        public KeyValPair() { }

        public KeyValPair(KeyType key, MeterImage value)
        {
            this.Id = key;
            this.Meter = value;
        }
    }
}
