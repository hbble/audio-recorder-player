using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_3_4 {
	class Converter {
		private string fMP3Name;
		private string fMP3Path;
		private string fTXTPath;

		public Converter() {
			fMP3Name = "\\Jason Mraz - Im Yours.mp3";


			fMP3Path = Directory.GetCurrentDirectory() + fMP3Name;

			string fTXTName = "\\out.txt";

			fTXTPath = Directory.GetCurrentDirectory() + fTXTName;

		}

		public string MP3FileName {
			get { return fMP3Name; }
		}


		public void StartConverting() {
			try {

				byte[] bytes = File.ReadAllBytes(fMP3Path);

				//create txt file
				if (File.Exists(fTXTPath))
					File.Delete(fTXTPath);


				StreamWriter fileTxt = new StreamWriter(fTXTPath);

				foreach (byte b in bytes) {
					fileTxt.Write(Convert.ToString(b, 2) + Environment.NewLine);
				}

				fileTxt.Close();


			}

			catch (FileNotFoundException) {
				MessageBox.Show("File does not exist!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


	}
}
