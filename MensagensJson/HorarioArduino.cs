using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Alimentador.MensagensJson
{
    public class HorarioArduino
    {
        [JsonPropertyName("hora")]
        public int Hora { get; set; }

        [JsonPropertyName("minuto")]
        public int Minuto { get; set; }

        [JsonPropertyName("segundo")]
        public int Segundo { get; set; }
    }
}
