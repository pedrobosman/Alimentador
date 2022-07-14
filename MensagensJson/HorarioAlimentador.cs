using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Alimentador.MensagensJson
{
    public class HorarioAlimentador
    {
        [JsonProperty("hora")]
        public int Hora { get; set; }

        [JsonProperty("minuto")]
        public int Minuto { get; set; }

        [JsonProperty("segundo")]
        public int Segundo { get; set; }
    }
}
