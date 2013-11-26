using System;
using System.Windows.Forms;
using CSIL;

namespace Computer_Skin_Interface
{
    public partial class Main : Form
    {
        SkinInterface SI; // экземпляр класса интерфейса
        SignalParams SP; // экземпляр класса с параметрами функции сигнала
        SkinInterface.SoundDevice[] Devices; // список аудиоустройств

        public Main()
        {
            InitializeComponent();
        }

        // реализация класса с параметрами функции сигнала
        private class SignalParams : SkinInterface.SignalFunctionParams
        {
            public float Amplitude; // амплитуда
            public float Frequency; // частота
            public SignalTypes SignalType; // тип сигнала

            public enum SignalTypes // тип типа сигнала :)
            {
                SineWave, // синус-волна
                Square,   // прямоугольный сигнал (меандр)
                Triangle  // треугольный (зубчатый) сигнал
            };
        }

        // функция сигнала
        static float Signal(float t, SkinInterface.SignalFunctionParams pars)
        {
            SignalParams Parameters = (SignalParams)pars; // получаем параметры
            float BaseValue = (float)Math.Sin(2 * Math.PI * t * Parameters.Frequency); // вычисляем базовую функцию - синус
            float ResultValue = 0; // переменная для возвращаемого значения

            if (Parameters.SignalType == SignalParams.SignalTypes.Square) // если задан прямоугольный сигнал
                ResultValue = Math.Sign(BaseValue); // По этой формуле http://en.wikipedia.org/wiki/Square_wave#Other_definitions
            if (Parameters.SignalType == SignalParams.SignalTypes.SineWave) // если задана синус-волна
                ResultValue = BaseValue; // просто синус, без изменений
            if (Parameters.SignalType == SignalParams.SignalTypes.Triangle) // если задан треугольный сигнал
                ResultValue = (float)(2 * Math.Asin(BaseValue) / Math.PI); // По этой формуле http://en.wikipedia.org/wiki/Triangle_wave#Definitions

            return Parameters.Amplitude * ResultValue; // масштабируем умножением на амплитуду
        }

        // загрузка программы
        private void Main_Load(object sender, EventArgs e)
        {
            Devices = SkinInterface.getSoundDevices(); // получаем список устройств
            
            if (Devices.Length == 0) // на случай, если нету ни одного устройства :)
            {
                MessageBox.Show("Active output sound devices not detected!");
                Application.Exit();
            }

            for (int i = 0; i < Devices.Length; i++) // добавляем их имена в ComboBox
                cbDevice.Items.Add(Devices[i].getName());

            SP = new SignalParams(); // создаём экземпляр класса с параметрами
            SP.Amplitude = 0.1f; // заполняем амплитуду
            SP.Frequency = 200f; // заполняем частоту
            SP.SignalType = SignalParams.SignalTypes.SineWave;  // заполняем тип сигнала

            cbDevice.SelectedIndex = 0; // эта строчка заставляет ComboBox отработать событие SelectedIndexChanged
        }

        // если выбрали другое устройство
        private void cbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            // настраиваем интерфейс на него
            SI = new SkinInterface(Devices[cbDevice.SelectedIndex], new SkinInterface.SignalFunction(Signal), SP);
        }

        // нажатие на кнопку Start
        private void btStart_Click(object sender, EventArgs e)
        {
            cbDevice.Enabled = false;
            btStart.Enabled = false;
            btSend.Enabled = false;
            btStop.Enabled = true;
            SI.StartSignal();
        }

        // нажатие на кнопку Stop
        private void btStop_Click(object sender, EventArgs e)
        {
            btStop.Enabled = false;
            btStart.Enabled = true;
            cbDevice.Enabled = true;
            btSend.Enabled = true;
            SI.StopSignal();
        }

        // изменение ползунком частоты
        private void tbFrequency_ValueChanged(object sender, EventArgs e)
        {
            SP.Frequency = (float)tbFrequency.Value;
            lbFrequency.Text = SP.Frequency + " Hz";
        }

        // изменение ползунком амплитуды
        private void tbAmplitude_ValueChanged(object sender, EventArgs e)
        {
            SP.Amplitude = (float)tbAmplitude.Value / 100;
            lbAmplitude.Text = SP.Amplitude.ToString();
        }

        // нажатие на кнопку Send
        private void btSend_Click(object sender, EventArgs e)
        {
            cbDevice.Enabled = false;
            btStart.Enabled = false;
            btStop.Enabled = true;

            if (rbAsync.Checked)
                SI.SendSignalAsync(Convert.ToInt32(udDuration.Value));

            if (rbSync.Checked)
                SI.SendSignal(Convert.ToInt32(udDuration.Value));

            btStop.Enabled = false;
            btStart.Enabled = true;
            cbDevice.Enabled = true;
        }

        // выбор синус-волны
        private void rbSine_CheckedChanged(object sender, EventArgs e)
        {
            SP.SignalType = SignalParams.SignalTypes.SineWave;
        }

        // выбор прямоугольного сигнала
        private void rbSquare_CheckedChanged(object sender, EventArgs e)
        {
            SP.SignalType = SignalParams.SignalTypes.Square;
        }

        // выбор треугольного сигнала
        private void rbTriangle_CheckedChanged(object sender, EventArgs e)
        {
            SP.SignalType = SignalParams.SignalTypes.Triangle;
        }

        // при закрытии формы останавливаем сигнал
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SI.StopSignal();
        }
    }
}
