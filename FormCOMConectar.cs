using System.IO.Ports;
using System.Management;

namespace Alimentador
{
    public partial class FormCOMConectar : Form
    {
        static SerialPort _serialPort;

        public List<ManagementObject> _portas;
        public FormCOMConectar()
        {
            InitializeComponent();
            _serialPort = new SerialPort();
            _serialPort.BaudRate = 9600;
            comboBoxPortas.Items.Clear();
            _portas = new List<ManagementObject>();
        }

        private void AlimentadorMain_Load(object sender, EventArgs e)
        {

        }

        private void Portas_DropDown(object sender, EventArgs e)
        {
            comboBoxPortas.Items.Clear();
            _portas.Clear();
            //string[] portas = SerialPort.GetPortNames();
            comboBoxPortas.Enabled = false;
            comboBoxPortas.Text = "Aguarde...";
            _portas = AutodetectArduinoPort();
            comboBoxPortas.Text = "";
            comboBoxPortas.Enabled = true;

            if (_portas.Count > 0)
            {
                foreach (var porta in _portas)
                {
                    comboBoxPortas.Items.Add(porta["Description"].ToString());
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
            string? portaSelecionada = (portaIndex>=0)? comboBoxPortas.Items[portaIndex].ToString() : null;
            string? porta = null;

            foreach (var portas in _portas)
            {
                if (portas["Description"].ToString() == portaSelecionada)
                    porta = portas["DeviceID"].ToString();
            }
;

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
                        comboBoxPortas.Items.Clear();
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
        private List<ManagementObject> AutodetectArduinoPort()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            List<ManagementObject> arduinos = new List<ManagementObject>();
            try
            {
                
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();

                    if (desc.Contains("Arduino"))
                    {
                        arduinos.Add(item);
                    }
                }
                
                return arduinos;
            }
            catch (ManagementException e)
            {
                /* Do Nothing */
            }

            return null;
        }
    }
}
