using Alimentador.MensagensJson;
namespace Alimentador
{
    public partial class AdicionarHorario : Form
    {
        private int _NMaxDeAlimentacoes;

        public HorarioAlimentacao? Horario { get; set; }
        public AdicionarHorario(int NMaxId)
        {
            InitializeComponent();
            _NMaxDeAlimentacoes = NMaxId;
            for (int i = 1; i <= NMaxId; i++)
            {
                comboBoxID.Items.Add(i.ToString());
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool jaAlimentou = true;
            int hora = (int)numericUpDownHora.Value;
            int minuto = (int)numericUpDownMinuto.Value;
            int id = Convert.ToInt32(comboBoxID.Items[comboBoxID.SelectedIndex]);
            if (id <= 0)
            {
                id = 0;
            }
            DateTime horaEMinuto = DateTime.Now;
            if (hora > horaEMinuto.Hour)
            {
                jaAlimentou = false;
            }
            else if (hora == horaEMinuto.Hour)
            {
                if (minuto > horaEMinuto.Minute)
                    jaAlimentou = false;
            }
            else
            {
                jaAlimentou = true;
            }
            Horario = new HorarioAlimentacao()
            {
                ID = id,
                Hora = hora,
                Minuto = minuto,
                TempoVazao = (double)numericUpDownVazao.Value * 1000,
                JaAlimentou = jaAlimentou
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
