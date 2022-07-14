using System.Text.Json;
using System.Text.Json.Serialization;

namespace Alimentador.MensagensJson
{
    public class ReceberMensagemGeral
    {
        [JsonPropertyName("erro")]
        public string? Erro { get; set; }

        [JsonPropertyName("nmax_id")]
        public int NMaxId { get; set; }

        

        [JsonPropertyName("led_status")]
        public bool LedStatus { get; set; }

        [JsonPropertyName("porcentagem")]
        public int Porcentagem { get; set; }

        [JsonPropertyName("tensao_ldr")]
        public double TensaoLdr { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

    }
}
