using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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
            return JsonSerializer.Deserialize<T>(_dadosRecebidos);
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
            string[] msg = {"erro", "id","nmax_id","hora"
                    ,"tensao_ldr","led_status","status"};
            for (int i = 0; i < msg.Length; i++)
            {
                if (_dadosRecebidos.Contains(msg[i]))
                {
                    tipo = (TIPODARESPOSTA)i;
                }
            }
            return tipo;

        }




    }

}
