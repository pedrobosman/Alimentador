using Alimentador.MensagensJson;
using System.IO.Ports;
using System.Text.Json;
using static Alimentador.MensagensJson.ServicoMensagens;

namespace Alimentador
{
    public partial class AlimentadorMain : Form
    {
        static SerialPort _serialPort;

        private  ServicoMensagens _servicoMsgs;

        private bool _flagSliderAmbiente;

        private bool _flagSliderLampada;
        public AlimentadorMain(SerialPort serialPort)
        {
            InitializeComponent();
            _serialPort = serialPort;
            _serialPort.DataReceived += _serialPort_DataReceived;
            _serialPort.ReadTimeout = 2000;
            _serialPort.WriteTimeout = 2000;

            timerChecarConexao.Interval = 100;
            timerChecarConexao.Start();
            timerAtualizarDados.Interval = 500;
            timerAtualizarDados.Start();
            _servicoMsgs = new ServicoMensagens();
            _flagSliderAmbiente = true;
        }


        private void Desconectado()
        {
            //_serialPort.Close();
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
        private async void timerAtualizarDados_Tick(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                try
                {
                    if (_flagSliderLampada)
                        _serialPort.WriteLine(_servicoMsgs.Solicitar(SOLICITACAOSIMPLES.StatusLed));
                    await Task.Delay(150);
                    if (_flagSliderAmbiente)
                        _serialPort.WriteLine(_servicoMsgs.Solicitar(SOLICITACAOSIMPLES.StatusLdr));
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
            ServicoMensagens? servicoMensagens = new ServicoMensagens(dadosRecebidos);
            TIPODARESPOSTA? resposta = servicoMensagens.TipoMensagemRecebida();

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
                    trackBarAmbiente.Value = (int)ldr_Status.LimiteAcionamento;
                    labelPorcLuminosidade.Text = (100.00 - map(ldr_Status.TensaoLdr, 0, 5, 0, 100)).ToString("F") +" %";
                    break;
                case TIPODARESPOSTA.STATUSLED:
                    StatusLed? led_Status = servicoMensagens.RetornarValorDeJson<StatusLed>();
                    if (led_Status == null) break;
                    trackBarPorcLampada.Value = led_Status.Porcentagem;
                    if (led_Status.EstaLigado)
                    {
                        pictureBoxLampada.Image.Dispose();
                        pictureBoxLampada.Image = Alimentador.Properties.Resources.aceso;
                    }
                    else
                    {
                        pictureBoxLampada.Image.Dispose();
                        pictureBoxLampada.Image = Alimentador.Properties.Resources.desligado;
                    }

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

        private static double map(double value, double fromLow, double fromHigh, double toLow, double toHigh)
        {
            return (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;
        }

        private  void trackBarPorcLampada_MouseCaptureChanged(object sender, EventArgs e)
        {
            _flagSliderLampada = false;

            _serialPort.Write(_servicoMsgs.DefinirClaridadeLampada(trackBarPorcLampada.Value));
            _flagSliderLampada = true;
        }

        private  void trackBarAmbiente_MouseCaptureChanged(object sender, EventArgs e)
        {
            _flagSliderAmbiente = false;
            //int tensaoLdr = (int)map(trackBarAmbiente.Value, 0, 100, 0, 4);
            _serialPort.Write(_servicoMsgs.DefinirClaridadeAcionamentoLDR(trackBarAmbiente.Value));
            _flagSliderAmbiente = true;
        }

        private void trackBarPorcLampada_Scroll(object sender, EventArgs e)
        {
            _flagSliderLampada = false;
        }

        private void trackBarPorcLampada_Enter(object sender, EventArgs e)
        {
            _flagSliderLampada = false;
        }
        private void trackBarAmbiente_Scroll(object sender, EventArgs e)
        {
            _flagSliderAmbiente = false;
        }
        private void trackBarAmbiente_Enter(object sender, EventArgs e)
        {
            _flagSliderAmbiente = false;
        }

        
    }
}
