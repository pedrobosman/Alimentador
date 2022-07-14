using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Alimentador.MensagensJson
{
    public class StatusLed
    {
        [JsonPropertyName("led_status")]
        public bool LedStatus { get; set; }

        [JsonPropertyName("porcentagem")]
        public int Porcentagem { get; set; }
    }
}
