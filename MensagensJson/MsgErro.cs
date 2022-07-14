using Newtonsoft.Json;

namespace Alimentador.MensagensJson
{
    public class MsgErro
    {
        [JsonProperty("erro")]
        public string? Mensagem { get; set; }
    }
}
