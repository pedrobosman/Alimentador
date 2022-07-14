using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Alimentador.MensagensJson
{
    public class StatusLed
    {
        [JsonProperty("led_status")]
        public bool EstaLigado { get; set; }

        [JsonProperty("porcentagem")]
        public int Porcentagem { get; set; }
    }
}
