using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Alimentador.MensagensJson
{
    public class StatusLdr
    {

        [JsonProperty("tensao_ldr")]
        public double TensaoLdr { get; set; }

        [JsonProperty("limite_ldr")]
        public double LimiteAcionamento { get; set; }
    }
}
