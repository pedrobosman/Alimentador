using Newtonsoft.Json;


namespace Alimentador.MensagensJson
{
    public class StatusAlimentador
    {
        [JsonProperty("status")]
        public string? Status { get; set; }
    }
}
