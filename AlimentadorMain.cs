using System.IO.Ports;

namespace Alimentador
{
    public partial class AlimentadorMain : Form
    {

        static SerialPort _serialPort;
        public AlimentadorMain()
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

            if (portas.Length>0)
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
            if (_serialPort.IsOpen == false)
            {
                try
                {
                    string? porta = comboBoxPortas.Items[comboBoxPortas.SelectedIndex].ToString();
                    if (!String.IsNullOrEmpty(porta))
                    {
                        _serialPort.PortName = porta;
                        _serialPort.Open();
                    }
                }
                catch
                {
                    MessageBox.Show("Erro na Conexão", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_serialPort.IsOpen)
                {
                    BtnConectar.Text = "Desconectar";
                    comboBoxPortas.Enabled = false;
                }
            }
            else
            {

                try
                {
                    _serialPort.Close();
                    comboBoxPortas.Enabled = true;
                    BtnConectar.Text = "Conectar";
                }
                catch
                {
                    MessageBox.Show("Erro na Desconexão", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }
    }
}
