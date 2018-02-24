using OpenMTR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTRDemo.Models
{
    //This class is created out of the necessity to make key value pairs mutable
    public class KeyValPair
    {
        public string Id { get; set; }
        public Meter meter;

        public KeyValPair() { }

        public KeyValPair(string key, Meter value)
        {
            this.Id = key;
            this.meter = value;
        }
    }
}
