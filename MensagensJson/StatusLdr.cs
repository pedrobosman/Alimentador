using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Alimentador.MensagensJson
{
    public class StatusLDR
    {


        [JsonPropertyName("tensao_ldr")]
        public double TensaoLdr { get; set; }
    }
}
