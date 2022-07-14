using Alimentador.MensagensJson;
using System.IO.Ports;
using System.Text.Json;
using static Alimentador.MensagensJson.ServicoMensagens;

namespace Alimentador
{
    public partial class AlimentadorMain : Form
    {
        static SerialPort _serialPort;

        public AlimentadorMain(SerialPort serialPort)
        {
            InitializeComponent();
            _serialPort = serialPort;
            _serialPort.DataReceived += _serialPort_DataReceived;
            _serialPort.ReadTimeout = 2000;
            _serialPort.WriteTimeout = 500;

            timerChecarConexao.Interval = 100;
            timerChecarConexao.Start();
            timerAtualizarDados.Interval = 300;
            timerAtualizarDados.Start();

        }


        private void Desconectado()
        {
            MessageBox.Show("Desconectado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
            FormCOMConectar serialConectar = new FormCOMConectar();
            serialConectar.Closed += (s, args) => this.Close();
            serialConectar.Show();
        }

        private void timerChecarConexao_Tick(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                toolStripLabelStatus.Text = "Status Dispositivo:" + "Conectado";
            }
            else
            {
                toolStripLabelStatus.Text = "Status Dispositivo:" + "Desconectado";
                timerChecarConexao.Stop();
                Desconectado();
            }
        }
        private void timerAtualizarDados_Tick(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                try
                {
                    string send = "{\"tipo_msg\"" +
                        ":10}";
                    _serialPort.WriteLine(send);
                }
                catch
                {
                    timerAtualizarDados.Stop();
                    MessageBox.Show("Erro", "Erro", MessageBoxButtons.OK);
                    Desconectado();
                }
            }
            else
            {
                timerAtualizarDados.Stop();
            }
        }

        private void tratarSerialRecebido(string dadosRecebidos)
        {
            ServicoMensagens servicoMensagens = new ServicoMensagens(dadosRecebidos);
            TIPODARESPOSTA resposta = servicoMensagens.TipoMensagemRecebida();

            switch (resposta)
            {
                case TIPODARESPOSTA.ERRO:
                    MsgErro? erro = servicoMensagens.RetornarValorDeJson<MsgErro>();
                    if (erro == null) break;
                    if (erro.Mensagem == "id_errado")
                    {
                        MessageBox.Show("Verifique o ID de alimentação!",
                            "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case TIPODARESPOSTA.HORARIOALIMENTACAO:
                    HorarioAlimentacao? horarioAlimentacao
                        = servicoMensagens.RetornarValorDeJson<HorarioAlimentacao>();
                    if (horarioAlimentacao == null) break;


                    break;
                case TIPODARESPOSTA.NMAXID:
                    NMaxId? maxId =
                        servicoMensagens.RetornarValorDeJson<NMaxId>();
                    if (maxId == null) break;

                    break;
                case TIPODARESPOSTA.HORARIOALIMENTADOR:
                    HorarioAlimentador? horarioDispositivo =
                        servicoMensagens.RetornarValorDeJson<HorarioAlimentador>();
                    if (horarioDispositivo == null) break;

                    break;
                case TIPODARESPOSTA.TENSAOLDR:
                    StatusLdr? ldr_Status = servicoMensagens.RetornarValorDeJson<StatusLdr>();
                    if (ldr_Status == null) break;

                    break;
                case TIPODARESPOSTA.STATUSLED:
                    StatusLed? led_Status = servicoMensagens.RetornarValorDeJson<StatusLed>();
                    if (led_Status == null) break;

                    break;
                case TIPODARESPOSTA.STATUSCONEXAO:
                    StatusAlimentador? statusAlimentador
                        = servicoMensagens.RetornarValorDeJson<StatusAlimentador>();
                    if (statusAlimentador == null) break;

                    break;
                case TIPODARESPOSTA.MENSAGEMINVALIDA:

                    break;
                default:
                    break;
            }
        }
        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string dadosEntradaSerial = "";
            SerialPort sp = (SerialPort)sender;
            dadosEntradaSerial = sp.ReadLine();
            EventHandler myEvent = (sender, e) => tratarSerialRecebido(dadosEntradaSerial);
            try { 
            this.Invoke(myEvent);
            }
            catch
            {
                return;
            }
        }

        
    }
}
