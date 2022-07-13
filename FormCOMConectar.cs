using System.IO.Ports;

namespace Alimentador
{
    public partial class FormCOMConectar : Form
    {
        static SerialPort _serialPort;
        public FormCOMConectar()
        {
            InitializeComponent();
            _serialPort = new SerialPort();
            _serialPort.BaudRate = 9600;
            comboBoxPortas.Items.Clear();
        }

        private void AlimentadorMain_Load(object sender, EventArgs e)
        {

        }

        private void Portas_DropDown(object sender, EventArgs e)
        {
            comboBoxPortas.Items.Clear();
            string[] portas = SerialPort.GetPortNames();

            if (portas.Length > 0)
            {
                foreach (string porta in portas)
                {

                    comboBoxPortas.Items.Add(porta);
                }
            }
            else
            {
                MessageBox.Show("Conecte o Dispositivo.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            int portaIndex = comboBoxPortas.SelectedIndex;
            string? porta = (portaIndex>=0)? comboBoxPortas.Items[portaIndex].ToString() : null;

            if (String.IsNullOrEmpty(porta))
            {
                MessageBox.Show("Selecionar Dispositivo", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Checando se já estou conectado
            if (_serialPort.IsOpen == false)
            {
                //Tentando realizar a conexão Serial
                try
                {
                    _serialPort.PortName = porta;
                    _serialPort.Open();
                    if (_serialPort.IsOpen)
                    {
                        MessageBox.Show("Conectado!", "Alimentador", MessageBoxButtons.OK);
                        this.Hide();
                        AlimentadorMain alimentador = new AlimentadorMain(_serialPort);
                        alimentador.Closed += (s, args) => this.Close();
                        alimentador.Show();

                    }
                }
                catch
                {
                    MessageBox.Show("Erro na Conexão", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            

        }
    }
}
