using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Alimentador.MensagensJson
{
    

    public class HorarioAlimentacao
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("hora")]
        public int Hora { get; set; }

        [JsonProperty("minuto")]
        public int Minuto { get; set; }

        [JsonProperty("segundo")]
        public int Segundo { get; set; }

        [JsonProperty("tempo_vazao_ms")]
        public double TempoVazao { get; set; }

        [JsonProperty("ja_alimentou")]
        public bool JaAlimentou { get; set; }

    }
}
