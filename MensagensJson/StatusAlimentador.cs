using System.Text.Json.Serialization;

namespace Alimentador.MensagensJson
{
    public class StatusAlimentador
    {
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    }
}
