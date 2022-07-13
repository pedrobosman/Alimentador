using System;
using System.IO.Ports;
using System.Xml.Linq;

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

        private void tratarSerialRecebido(string dadosEntradaSerial)
        {
            label1.Text = dadosEntradaSerial;
        }

        private void timerChecarConexao_Tick(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                toolStripLabelStatus.Text = "Status Dispositivo:" + "OK";
            }
            else
            {
                toolStripLabelStatus.Text = "Status Dispositivo:" + "Desconectado";
                timerChecarConexao.Stop();
                Desconectado();
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

        private void timerAtualizarDados_Tick(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                try
                {
                    string send = "{\"tipo_msg\""+":9}";
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
    }
}
