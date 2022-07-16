using Alimentador.MensagensJson;
using System.IO.Ports;
using System.Text.Json;
using static Alimentador.MensagensJson.ServicoMensagens;

namespace Alimentador
{
    public partial class AlimentadorMain : Form
    {
        static SerialPort _serialPort;

        private ServicoMensagens _servicoMsgs;

        private bool _recarregar;

        private bool[] _startGetValues = null;

        private int NMaxHorariosAlimentacao;

        private const int delayCOM = 50;

        private static TimeSpan TimeOut = TimeSpan.FromMilliseconds(5000);
        public AlimentadorMain(SerialPort serialPort)
        {
            InitializeComponent();
            _serialPort = serialPort;
            _serialPort.DataReceived += _serialPort_DataReceived;
            _serialPort.ReadTimeout = 2000;
            _serialPort.WriteTimeout = 2000;

            _startGetValues = new bool[2] { true, true };
            _servicoMsgs = new ServicoMensagens();
            _recarregar = false;
            NMaxHorariosAlimentacao = 0;

            timerChecarConexao.Interval = 100;
            timerAtualizarDados.Interval = 1000;

            timerChecarConexao.Start();
        }

        private async void AlimentadorMain_Load(object sender, EventArgs e)
        {
            //await Task.Delay(delayCOM).WaitAsync(TimeOut);
            buttonRecarregarHorario.Enabled = false;
            for (int i = 0; i < 2; i++)
            {
                _serialPort.WriteLine(_servicoMsgs.Solicitar(SOLICITACAOSIMPLES.MaxIDs));
                await Task.Delay(delayCOM).WaitAsync(TimeOut);
            }

            _recarregar = true;
            await RecarregarHorarios().WaitAsync(TimeOut * 20);
            _recarregar = false;
            buttonRecarregarHorario.Enabled = true;

            _serialPort.WriteLine(_servicoMsgs.Solicitar(SOLICITACAOSIMPLES.StatusLed));
            await Task.Delay(delayCOM).WaitAsync(TimeOut);
            _serialPort.WriteLine(_servicoMsgs.Solicitar(SOLICITACAOSIMPLES.StatusLdr));



            timerAtualizarDados.Start();
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
            if (!_serialPort.IsOpen)
            {
                timerChecarConexao.Stop();
                timerAtualizarDados.Stop();
                _serialPort.Dispose();
                Desconectado();
            }
        }
        private async void timerAtualizarDados_Tick(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                try
                {
                    _serialPort.WriteLine(_servicoMsgs.Solicitar(SOLICITACAOSIMPLES.StatusLed));
                    await Task.Delay(delayCOM);
                    _serialPort.WriteLine(_servicoMsgs.Solicitar(SOLICITACAOSIMPLES.StatusLdr));
                    await Task.Delay(delayCOM);
                    _serialPort.WriteLine(_servicoMsgs.Solicitar(SOLICITACAOSIMPLES.HorarioAlimentador));
                    await Task.Delay(delayCOM);
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

        private async Task tratarSerialRecebido(string dadosRecebidos)
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
                    else
                    {
                        MessageBox.Show(erro.Mensagem,
                            "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case TIPODARESPOSTA.HORARIOALIMENTACAO:
                    HorarioAlimentacao? hAlim
                        = servicoMensagens.RetornarValorDeJson<HorarioAlimentacao>();
                    if (hAlim == null) break;
                    if (_recarregar)
                    {
                        if (hAlim.ID == 0 || hAlim.ID > NMaxHorariosAlimentacao)
                            break;
                        dataGridViewAlimentacao.Rows.Add(
                            hAlim.ID.ToString(), hAlim.Hora.ToString(),
                            hAlim.Minuto.ToString(), (hAlim.TempoVazao / 1000).ToString("F"),
                            (hAlim.JaAlimentou) ? "Sim" : "Não");
                    }
                    break;
                case TIPODARESPOSTA.NMAXID:
                    NMaxId? maxId =
                        servicoMensagens.RetornarValorDeJson<NMaxId>();
                    if (maxId == null) break;
                    NMaxHorariosAlimentacao = maxId.Valor;
                    break;
                case TIPODARESPOSTA.HORARIOALIMENTADOR:
                    HorarioAlimentador? horarioDispositivo =
                        servicoMensagens.RetornarValorDeJson<HorarioAlimentador>();
                    if (horarioDispositivo == null) break;
                    labelHorarioDisp.Text = horarioDispositivo.Hora.ToString("00")+":"+horarioDispositivo.Minuto.ToString("00");

                    break;
                case TIPODARESPOSTA.TENSAOLDR:
                    StatusLdr? ldr_Status = servicoMensagens.RetornarValorDeJson<StatusLdr>();
                    if (ldr_Status == null) break;
                    if (_startGetValues[1])
                    {
                        trackBarAmbiente.Value = (int)ldr_Status.LimiteAcionamento;
                        _startGetValues[1] = false;
                    }
                    labelPorcLuminosidade.Text = (100.00 - map(ldr_Status.TensaoLdr, 0, 5, 0, 100)).ToString("F") + " %";
                    break;
                case TIPODARESPOSTA.STATUSLED:
                    StatusLed? led_Status = servicoMensagens.RetornarValorDeJson<StatusLed>();
                    if (led_Status == null) break;
                    if (_startGetValues[0])
                    {
                        trackBarPorcLampada.Value = (int)led_Status.Porcentagem;
                        _startGetValues[0] = false;
                    }
                    //trackBarPorcLampada.Value = led_Status.Porcentagem;
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
            try
            {
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

        private void trackBarPorcLampada_MouseCaptureChanged(object sender, EventArgs e)
        {
            _serialPort.WriteLine(_servicoMsgs.DefinirClaridadeLampada(trackBarPorcLampada.Value));
        }

        private void trackBarAmbiente_MouseCaptureChanged(object sender, EventArgs e)
        {
            //int tensaoLdr = (int)map(trackBarAmbiente.Value, 0, 100, 0, 4);
            _serialPort.WriteLine(_servicoMsgs.DefinirClaridadeAcionamentoLDR(trackBarAmbiente.Value));
        }

        private async void buttonAdicionarHorairo_Click(object sender, EventArgs e)
        {
            timerAtualizarDados.Stop();
            for (int i = 0; i < 2; i++)
            {
                _serialPort.WriteLine(_servicoMsgs.Solicitar(SOLICITACAOSIMPLES.MaxIDs));
                await Task.Delay(delayCOM).WaitAsync(TimeOut);
            }
            using (AdicionarHorario formulario_horario = new AdicionarHorario(NMaxHorariosAlimentacao))
            {
                if (formulario_horario.ShowDialog() == DialogResult.OK)
                {
                    if (formulario_horario.Horario != null)
                        _serialPort.WriteLine(_servicoMsgs.DefinirHorarioAlimentacao(formulario_horario.Horario));
                    await Task.Delay(delayCOM).WaitAsync(TimeOut);


                    _recarregar = true;
                    await RecarregarHorarios().WaitAsync(TimeOut * 20);
                    _recarregar = false;
                }else if (formulario_horario.ShowDialog() == DialogResult.Cancel)
                {
                    _recarregar = true;
                    await RecarregarHorarios().WaitAsync(TimeOut * 20);
                    _recarregar = false;
                }

            }
            timerAtualizarDados.Start();
        }

        private async void buttonRecarregarHorario_Click(object sender, EventArgs e)
        {
            RecarregarTaskBars();
            buttonRecarregarHorario.Enabled = false;
            timerAtualizarDados.Stop();
            _recarregar = true;
            await RecarregarHorarios().WaitAsync(TimeOut * 20);
            _recarregar = false;
            timerAtualizarDados.Start();
            buttonRecarregarHorario.Enabled = true;
        }

        private void RecarregarTaskBars()
        {
            //Recupera valores atuais e reais dos taskbars
            _startGetValues[0] = true;
            _startGetValues[1] = true;
        }
        private async Task RecarregarHorarios()
        {

            for (int i = 0; i < 2; i++)
            {
                _serialPort.WriteLine(_servicoMsgs.Solicitar(SOLICITACAOSIMPLES.MaxIDs));
                await Task.Delay(delayCOM).WaitAsync(TimeOut);
            }

            if (NMaxHorariosAlimentacao > 0)
            {
                dataGridViewAlimentacao.Rows.Clear();
                for (int i = 1; i <= NMaxHorariosAlimentacao; i++)
                {
                    _serialPort.WriteLine(_servicoMsgs.SolicitarAlimentacaoId(i));
                    await Task.Delay(delayCOM).WaitAsync(TimeOut);
                }
            }
            else
            {
                MessageBox.Show("Não Foi possível Recuperar Número de ID's",
                            "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private async void buttonRemoveHorario_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha = dataGridViewAlimentacao.CurrentRow;
            if (linha != null)
            {
                _serialPort.WriteLine(_servicoMsgs.ExcluirAlimentacaoId(Convert.ToInt32(linha.Cells[0].Value)));
                await Task.Delay(delayCOM).WaitAsync(TimeOut);


                _recarregar = true;
                await RecarregarHorarios().WaitAsync(TimeOut * 20);
                _recarregar = false;
                
            }
            else
            {
                MessageBox.Show("Selecione um Horário!");
            }
            MessageBox.Show("Horário Excuído com Sucesso!");

        }

        private async void buttonSync_Click(object sender, EventArgs e)
        {
            timerAtualizarDados.Stop();
            DateTime agora = DateTime.Now;
            HorarioAlimentador horario = new HorarioAlimentador()
            {
                 Hora = agora.Hour,
                 Minuto = agora.Minute,
                 Segundo = agora.Second
            };
            _serialPort.WriteLine(_servicoMsgs.DefinirHorarioAlimentador(horario));
            await Task.Delay(delayCOM).WaitAsync(TimeOut);
            timerAtualizarDados.Start();
            
        }
    }
}
