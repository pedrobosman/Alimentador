using Newtonsoft.Json;



namespace Alimentador.MensagensJson
{
    public class ReceberMensagemGeral
    {
        [JsonProperty("erro")]
        public string? Erro { get; set; }

        [JsonProperty("nmax_id")]
        public int NMaxId { get; set; }

        

        [JsonProperty("led_status")]
        public bool LedStatus { get; set; }

        [JsonProperty("porcentagem")]
        public int Porcentagem { get; set; }

        [JsonProperty("tensao_ldr")]
        public double TensaoLdr { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

    }
}
