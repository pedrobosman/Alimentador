using Newtonsoft.Json;

namespace Alimentador.MensagensJson
{
    public class ServicoMensagens
    {
        private  string _dadosRecebidos = "";
        public ServicoMensagens(string dadosRecebidos)
        {
            _dadosRecebidos = dadosRecebidos;
        }
       
       public T? RetornarValorDeJson<T>()
        {
            try { 
                return JsonConvert.DeserializeObject<T>(_dadosRecebidos);
            }
            catch
            {
                return default(T);
            }
                //JsonSerializer.Deserialize<T>(_dadosRecebidos);
        }


        public enum TIPODARESPOSTA
        {
            ERRO = 0,
            HORARIOALIMENTACAO = 1,
            NMAXID = 2,
            HORARIOALIMENTADOR = 3,
            TENSAOLDR = 4,
            STATUSLED = 5,
            STATUSCONEXAO = 6,
            MENSAGEMINVALIDA = 7
        }

        public TIPODARESPOSTA TipoMensagemRecebida()
        {
            TIPODARESPOSTA tipo = TIPODARESPOSTA.MENSAGEMINVALIDA;
            string[] msg = {"\"erro\"", "\"id\"","\"nmax_id\"","\"hora\""
                    ,"\"tensao_ldr\"","\"led_status\"","\"status\""};
            for (int i = 0; i < msg.Length; i++)
            {
                if (_dadosRecebidos.Contains(msg[i]))
                {
                    tipo = (TIPODARESPOSTA)i;
                }
            }

            if (tipo == TIPODARESPOSTA.HORARIOALIMENTADOR)
            {
                tipo = (_dadosRecebidos.Contains(msg[1])) 
                    ? TIPODARESPOSTA.HORARIOALIMENTACAO : TIPODARESPOSTA.HORARIOALIMENTADOR;
            }

            return tipo;

        }




    }

}
