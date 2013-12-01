using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Collections;
using System.Windows.Forms;
using CSIL;

namespace Computer_Skin_Interface
{
    public partial class Main : Form
    {
        SkinInterface SI; // экземпляр класса интерфейса
        SignalParams SP; // экземпляр класса с параметрами функции сигнала
        SkinInterface.SoundDevice[] Devices; // список аудиоустройств
        FileSystemWatcher FSW; // экземпляр FileSystemWatcher
        long LatestFileSize; // последний размер логфайла
        Queue DataQueue; // очеред комманд, поступивших из логфайла

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

        // Хэндлер события "файл был изменён"
        private void Watcher(object sender, FileSystemEventArgs e)
        {
            int count = 0; // количество попыток открыть файл на чтение
            bool success = false; // был ли файл успешно открыт

            while (count < 5 && !success) // делаем 5 попыток открыть файл
            {
                try
                {
                    using (FileStream stream = File.Open(tbLogFile.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) // открываем файл
                    {
                        if (stream.Length >= LatestFileSize) // если его длина стала больше, то
                        {
                            StreamReader reader = new StreamReader(stream);
                            stream.Position = LatestFileSize; // устанавливаем позицию для считывания старый конец файла
                            string new_line = reader.ReadToEnd(); // и считываем до нового конца, т.е. получаем то, что только что было записано в файл
                            if (new_line.StartsWith("***to_interface")) DataQueue.Enqueue(new_line); // если это что-то начинается на ключевую фразу, то добавляем это в очередь на обработку
                            LatestFileSize = stream.Length; // устанавливаем указатель конца файла на новый конец
                        }
                        stream.Close(); // закрываем поток
                    }
                    success = true; // удалось прочитать
                }
                catch (IOException) // если не получилось
                {
                    Thread.Sleep(50); // ждём 50 миллисекунд
                }
                count++; // увеличиваем номер попытки
            }
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

        // запуск интерфейса с порталом
        private void btLogWatcherStart_Click(object sender, EventArgs ea)
        {
            try
            {
                LatestFileSize = (new FileInfo(tbLogFile.Text)).Length; // узнаём последнюю длину файла
                FSW = new FileSystemWatcher(Path.GetDirectoryName(tbLogFile.Text), Path.GetFileName(tbLogFile.Text)); // создаём экземпляр FileSystemWatcher, настроенный на логфайл портала
            }
            catch (IOException e) // если чего-то пошло не так - выдадим сообщение об ошибке
            {
                MessageBox.Show("Can't open file " + tbLogFile.Text + "!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;    
            }
            btLogWatcherStart.Enabled = false;
            btLogWatcherStop.Enabled = true;
            btOpen.Enabled = false;
            tbLogFile.Enabled = false;
            DataQueue = new Queue(); // создаём очередь
            FSW.Changed += new FileSystemEventHandler(Watcher); // устанавливаем обработчик событий файла
            FSW.EnableRaisingEvents = true; // запускаем слежение за файлом
            LogTimer.Enabled = true;
        }

        // остановка интерфейса с порталом
        private void btLogWatcherStop_Click(object sender, EventArgs e)
        {
            btLogWatcherStart.Enabled = true;
            btLogWatcherStop.Enabled = false;
            btOpen.Enabled = true;
            tbLogFile.Enabled = true;
            LogTimer.Enabled = false;
            FSW.EnableRaisingEvents = false; // отключаем слежение за файлом
            FSW.Dispose(); // уничтожаем объект
        }

        // выбор логфайла портала
        private void btOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();
            if (OpenFileDialog.FileName != "")
                tbLogFile.Text = OpenFileDialog.FileName;
        }

        // обработка очереди накопившихся комманд, производится 30 раз за секунду
        private void LogTimer_Tick(object sender, EventArgs e)
        {
            int Amplitude; // переменная для амплитуды

            if (DataQueue.Count != 0) // если в очереди есть комманды
            {
                string command = DataQueue.Dequeue().ToString(); // берём первую комманду
                tbLog.AppendText("[" + DateTime.Now.ToString("hh:mm:ss") + "]" + command); // печатаем её в лог
                string[] parts = command.Split(' '); // делим на части по пробелу
                
                if (int.TryParse(parts[1], out Amplitude)) // пытаемся распарсить число из комманды как целое, это будет амплитуда
                    tbAmplitude.Value = Amplitude; // устанавливаем ползунок амплитуды на вычисленную позицию
            }
        }
    }
}
