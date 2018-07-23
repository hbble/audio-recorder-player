using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_3_4 {
	public partial class MainWindow : Form {

		private Converter converter;

		//запис
		private WaveIn sourceStream = null;	//потік
		private DirectSoundOut waveDirectOut = null;  //для програвання
		private WaveFileWriter waveWriter = null; //для запису
		
		//прослуховування
		private WaveOutEvent waveOut;

		public MainWindow() {
			InitializeComponent();

			converter = new Converter();
			labelFileToConv.Text = "..." + converter.MP3FileName;

			//список мікрофонів
			setupMicList();


		}

		private void convertButton_Click(object sender, EventArgs e) {

			converter.StartConverting();

			labelStatus.Text = "Done";
			
		}

		private void setupMicList() {
			int waveInDevices = WaveIn.DeviceCount;

			for (int i = 0; i < waveInDevices; i++) {
				WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(i);  //інформація про девайс

				devicesComboBox.Items.Add(deviceInfo.ProductName);
			}

			devicesComboBox.SelectedIndex = 0;
		}

		private SaveFileDialog save;
		private void startRecButton_Click(object sender, EventArgs e) {

			save = new SaveFileDialog();
			save.Filter = "Wave File | *.wav";
			if (save.ShowDialog() != DialogResult.OK) return;

			startRecButton.Enabled = false;
			stopRecButton.Enabled = true;

			int deviceNumber = devicesComboBox.SelectedIndex;

			//ініціалізація потоку запису
			sourceStream = new WaveIn();
			sourceStream.DeviceNumber = deviceNumber;
			sourceStream.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(deviceNumber).Channels);

			////створюємо провайдер
			//WaveInProvider waveIn = new WaveInProvider(sourceStream);

			////для виводу
			//waveDirectOut = new DirectSoundOut();
			//waveDirectOut.Init(waveIn);

			////починаємо читати
			//sourceStream.StartRecording();
			//waveDirectOut.Play();	//відтворення безпосередньо

			//збереження у файл
			sourceStream.DataAvailable += SourceStream_DataAvailable;   //подія
			waveWriter = new WaveFileWriter(save.FileName, sourceStream.WaveFormat);
			

			//починаємо запис
			sourceStream.StartRecording();

		}

		private void SourceStream_DataAvailable(object sender, WaveInEventArgs e) {

			if (waveWriter == null) return;

			waveWriter.Write(e.Buffer, 0, e.BytesRecorded); //записуємо

			//візуалізація
			byte[] buffer = e.Buffer;

			for (int index = 0; index < e.BytesRecorded; index += 2000) {

				short sample = BitConverter.ToInt16(buffer, index);
				float sample32 = sample / 32768f;
				sample32 *= 2;  //збільшуємо амплітуду для наочності
				waveformPainter.AddMax(sample32);
			}
			
			waveWriter.Flush(); //очистка буферу

		}

		private void stopRecButton_Click(object sender, EventArgs e) {

			startRecButton.Enabled = true;
			stopRecButton.Enabled = false;


			if (waveDirectOut != null) {
				waveDirectOut.Stop();
				waveDirectOut.Dispose();
				waveDirectOut = null;
			}

			if (sourceStream != null) {
				sourceStream.StopRecording();
				sourceStream.Dispose();
				sourceStream = null;
			}

			if (waveWriter != null) {
				waveWriter.Dispose();
				waveWriter = null;
			}

		}

		private void startListenButton_Click(object sender, EventArgs e) {

			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Wave or MP3 Files | *.wav; *.mp3";

			if (open.ShowDialog() != DialogResult.OK) return;

			startListenButton.Enabled = false;
			stopListenButton.Enabled = true;

			waveOut = new WaveOutEvent();   //потік

			if (open.FileName.EndsWith(".mp3")) {

				Mp3FileReader mp3Reader = new Mp3FileReader(open.FileName); //reader
				waveOut.Init(mp3Reader);    //зв'язуємо

				waveOut.Play(); //починаємо програвати


			}
			else if (open.FileName.EndsWith(".wav")) {

				WaveFileReader waveReader = new WaveFileReader(open.FileName); //reader
				waveOut.Init(waveReader);    //зв'язуємо

				waveOut.Play(); //починаємо програвати

				
			}
		}

		private void stopListenButton_Click(object sender, EventArgs e) {

			startListenButton.Enabled = true;
			stopListenButton.Enabled = false;

			if (waveOut != null) {
				waveOut.Stop();
				waveOut.Dispose();
				waveOut = null;
			}

		}
	}
}
