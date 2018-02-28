using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTR
{
    public class MeterMetaData
    {
        [JsonProperty("read")]
        public string MeterRead { get; set; }
        [JsonProperty("readType")]
        public string ReadType { get; set; }
        [JsonProperty("meterType")]
        public string MeterType { get; set; }
        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }
    }
}
