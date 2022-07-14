using Newtonsoft.Json;
using System.Text;

namespace Alimentador.MensagensJson
{
    public class ServicoMensagens 
    {
        private  string _dadosRecebidos = "";
        public ServicoMensagens()
        {
        }
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

        //Criar strings json para enviar ao arduino
        public string Solicitar(SOLICITACAOSIMPLES tipo_solicitacao)
        {
            StringBuilder solicitar = new StringBuilder();
            solicitar.Append("{\"tipo_msg\":");
            solicitar.Append((int)tipo_solicitacao);
            solicitar.Append("}");
            return solicitar.ToString();
    }
        public string DefinirHorarioAlimentacao(HorarioAlimentacao horario)
        {
            //{"tipo_msg":1,"id":1,"hora":8,"minuto":15,"tempo_vazao_ms":500,"ja_alimentou":0}
            StringBuilder solicitar = new StringBuilder();
            solicitar.Append("{\"tipo_msg\":1,\"id\":");
            solicitar.Append(horario.ID);
            solicitar.Append(",\"hora\":");
            solicitar.Append(horario.Hora);
            solicitar.Append(",\"minuto\":");
            solicitar.Append(horario.Minuto);
            solicitar.Append(",\"tempo_vazao_ms\":");
            solicitar.Append(horario.TempoVazao);
            solicitar.Append(",\"ja_alimentou\":");
            solicitar.Append(horario.JaAlimentou);
            solicitar.Append("}");
            return solicitar.ToString();
        }

        public string SolicitarAlimentacaoId(int id)
        {
            //{"tipo_msg":2,"id":2}
            StringBuilder solicitar = new StringBuilder();
            solicitar.Append("{\"tipo_msg\":2,\"id\":");
            solicitar.Append(id);
            solicitar.Append("}");
            return solicitar.ToString();
        }

        public string DefinirHorarioAlimentador(HorarioAlimentador horario)
        {
            //{"tipo_msg":4,"hora":15,"minuto":22,"segundo":20}
            StringBuilder solicitar = new StringBuilder();
            solicitar.Append("{\"tipo_msg\":4,\"hora\":");
            solicitar.Append(horario.Hora);
            solicitar.Append(",\"minuto\":");
            solicitar.Append(horario.Minuto);
            solicitar.Append(",\"segundo\":");
            solicitar.Append(horario.Segundo);
            solicitar.Append("}");
            return solicitar.ToString();
        }


        public string DefinirClaridadeLampada(int porcentagem)
        {
            //{"tipo_msg":6,"porcentagem":100}
            StringBuilder solicitar = new StringBuilder();
            solicitar.Append("{\"tipo_msg\":6,\"porcentagem\":");
            solicitar.Append(porcentagem);
            solicitar.Append("}");
            return solicitar.ToString();
        }

        public string DefinirClaridadeAcionamentoLDR(double tensaoLDR)
        {
            //{"tipo_msg":7,"tensao_ldr":5}
            StringBuilder solicitar = new StringBuilder();
            solicitar.Append("{\"tipo_msg\":7,\"tensao_ldr\":");
            solicitar.Append(tensaoLDR);
            solicitar.Append("}");
            return solicitar.ToString();
        }


        public enum SOLICITACAOSIMPLES
        {
            MaxIDs              = 3,
            HorarioAlimentador  = 5,
            StatusLed           = 8,
            StatusLdr           = 9,
            StatusAlimentador   = 10
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
