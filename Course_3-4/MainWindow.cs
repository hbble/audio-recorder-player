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

		//recording
		private WaveIn sourceStream = null;	//stream
		private DirectSoundOut waveDirectOut = null;  //for playing
		private WaveFileWriter waveWriter = null; //for recording
		
		//listening
		private WaveOutEvent waveOut;

		public MainWindow() {
			InitializeComponent();

			converter = new Converter();
			labelFileToConv.Text = "..." + converter.MP3FileName;

			//micro list
			setupMicList();


		}

		private void convertButton_Click(object sender, EventArgs e) {

			converter.StartConverting();

			labelStatus.Text = "Done";
			
		}

		private void setupMicList() {
			int waveInDevices = WaveIn.DeviceCount;

			for (int i = 0; i < waveInDevices; i++) {
				WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(i);  //device info

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

			//recorging stream init
			sourceStream = new WaveIn();
			sourceStream.DeviceNumber = deviceNumber;
			sourceStream.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(deviceNumber).Channels);

			////creating provider
			//WaveInProvider waveIn = new WaveInProvider(sourceStream);

			//waveDirectOut = new DirectSoundOut();
			//waveDirectOut.Init(waveIn);

			////start reading
			//sourceStream.StartRecording();
			//waveDirectOut.Play();	//відтворення безпосередньо

			//saving
			sourceStream.DataAvailable += SourceStream_DataAvailable;
			waveWriter = new WaveFileWriter(save.FileName, sourceStream.WaveFormat);


            //start recording
            sourceStream.StartRecording();

		}

		private void SourceStream_DataAvailable(object sender, WaveInEventArgs e) {

			if (waveWriter == null) return;

			waveWriter.Write(e.Buffer, 0, e.BytesRecorded); //writing

			//visualisation
			byte[] buffer = e.Buffer;

			for (int index = 0; index < e.BytesRecorded; index += 2000) {

				short sample = BitConverter.ToInt16(buffer, index);
				float sample32 = sample / 32768f;
				sample32 *= 2;  //increasing amplitude for better visualisation
				waveformPainter.AddMax(sample32);
			}
			
			waveWriter.Flush();

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

			waveOut = new WaveOutEvent();   //stream

			if (open.FileName.EndsWith(".mp3")) {

				Mp3FileReader mp3Reader = new Mp3FileReader(open.FileName); //reader
				waveOut.Init(mp3Reader);

				waveOut.Play(); //start playing


			}
			else if (open.FileName.EndsWith(".wav")) {

				WaveFileReader waveReader = new WaveFileReader(open.FileName); //reader
				waveOut.Init(waveReader);

				waveOut.Play(); //start playing


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
