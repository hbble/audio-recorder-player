namespace Course_3_4 {
	partial class MainWindow {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.groupBoxConvert = new System.Windows.Forms.GroupBox();
			this.labelStatus = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.convertButton = new System.Windows.Forms.Button();
			this.labelFileToConv = new System.Windows.Forms.Label();
			this.groupBoxMic = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.stopListenButton = new System.Windows.Forms.Button();
			this.startListenButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.stopRecButton = new System.Windows.Forms.Button();
			this.startRecButton = new System.Windows.Forms.Button();
			this.devicesComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.waveformPainter = new NAudio.Gui.WaveformPainter();
			this.groupBoxConvert.SuspendLayout();
			this.groupBoxMic.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "File to Convert:";
			// 
			// groupBoxConvert
			// 
			this.groupBoxConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxConvert.Controls.Add(this.labelStatus);
			this.groupBoxConvert.Controls.Add(this.label2);
			this.groupBoxConvert.Controls.Add(this.convertButton);
			this.groupBoxConvert.Controls.Add(this.labelFileToConv);
			this.groupBoxConvert.Controls.Add(this.label1);
			this.groupBoxConvert.Location = new System.Drawing.Point(13, 13);
			this.groupBoxConvert.Name = "groupBoxConvert";
			this.groupBoxConvert.Size = new System.Drawing.Size(454, 67);
			this.groupBoxConvert.TabIndex = 1;
			this.groupBoxConvert.TabStop = false;
			this.groupBoxConvert.Text = "Convert .mp3 to .txt";
			// 
			// labelStatus
			// 
			this.labelStatus.AutoSize = true;
			this.labelStatus.Location = new System.Drawing.Point(181, 43);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(0, 13);
			this.labelStatus.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(134, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Stat:";
			// 
			// convertButton
			// 
			this.convertButton.Location = new System.Drawing.Point(6, 38);
			this.convertButton.Name = "convertButton";
			this.convertButton.Size = new System.Drawing.Size(110, 23);
			this.convertButton.TabIndex = 2;
			this.convertButton.Text = "Convert!";
			this.convertButton.UseVisualStyleBackColor = true;
			this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
			// 
			// labelFileToConv
			// 
			this.labelFileToConv.AutoSize = true;
			this.labelFileToConv.Location = new System.Drawing.Point(90, 16);
			this.labelFileToConv.Name = "labelFileToConv";
			this.labelFileToConv.Size = new System.Drawing.Size(29, 13);
			this.labelFileToConv.TabIndex = 1;
			this.labelFileToConv.Text = "NaN";
			// 
			// groupBoxMic
			// 
			this.groupBoxMic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxMic.Controls.Add(this.waveformPainter);
			this.groupBoxMic.Controls.Add(this.groupBox2);
			this.groupBoxMic.Controls.Add(this.groupBox1);
			this.groupBoxMic.Controls.Add(this.devicesComboBox);
			this.groupBoxMic.Controls.Add(this.label3);
			this.groupBoxMic.Location = new System.Drawing.Point(13, 87);
			this.groupBoxMic.Name = "groupBoxMic";
			this.groupBoxMic.Size = new System.Drawing.Size(454, 261);
			this.groupBoxMic.TabIndex = 2;
			this.groupBoxMic.TabStop = false;
			this.groupBoxMic.Text = "Micro";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.stopListenButton);
			this.groupBox2.Controls.Add(this.startListenButton);
			this.groupBox2.Location = new System.Drawing.Point(295, 203);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(153, 52);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Listening";
			// 
			// stopListenButton
			// 
			this.stopListenButton.Enabled = false;
			this.stopListenButton.Location = new System.Drawing.Point(80, 19);
			this.stopListenButton.Name = "stopListenButton";
			this.stopListenButton.Size = new System.Drawing.Size(63, 23);
			this.stopListenButton.TabIndex = 12;
			this.stopListenButton.Text = "Stop";
			this.stopListenButton.UseVisualStyleBackColor = true;
			this.stopListenButton.Click += new System.EventHandler(this.stopListenButton_Click);
			// 
			// startListenButton
			// 
			this.startListenButton.Location = new System.Drawing.Point(6, 19);
			this.startListenButton.Name = "startListenButton";
			this.startListenButton.Size = new System.Drawing.Size(65, 23);
			this.startListenButton.TabIndex = 0;
			this.startListenButton.Text = "Play";
			this.startListenButton.UseVisualStyleBackColor = true;
			this.startListenButton.Click += new System.EventHandler(this.startListenButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.stopRecButton);
			this.groupBox1.Controls.Add(this.startRecButton);
			this.groupBox1.Location = new System.Drawing.Point(10, 203);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(153, 52);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Recording";
			// 
			// stopRecButton
			// 
			this.stopRecButton.Enabled = false;
			this.stopRecButton.Location = new System.Drawing.Point(80, 19);
			this.stopRecButton.Name = "stopRecButton";
			this.stopRecButton.Size = new System.Drawing.Size(63, 23);
			this.stopRecButton.TabIndex = 12;
			this.stopRecButton.Text = "Stop";
			this.stopRecButton.UseVisualStyleBackColor = true;
			this.stopRecButton.Click += new System.EventHandler(this.stopRecButton_Click);
			// 
			// startRecButton
			// 
			this.startRecButton.Location = new System.Drawing.Point(6, 19);
			this.startRecButton.Name = "startRecButton";
			this.startRecButton.Size = new System.Drawing.Size(65, 23);
			this.startRecButton.TabIndex = 0;
			this.startRecButton.Text = "Start";
			this.startRecButton.UseVisualStyleBackColor = true;
			this.startRecButton.Click += new System.EventHandler(this.startRecButton_Click);
			// 
			// devicesComboBox
			// 
			this.devicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.devicesComboBox.FormattingEnabled = true;
			this.devicesComboBox.Location = new System.Drawing.Point(93, 19);
			this.devicesComboBox.Name = "devicesComboBox";
			this.devicesComboBox.Size = new System.Drawing.Size(170, 21);
			this.devicesComboBox.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Select micro:";
			// 
			// waveformPainter
			// 
			this.waveformPainter.Location = new System.Drawing.Point(6, 46);
			this.waveformPainter.Name = "waveformPainter";
			this.waveformPainter.Size = new System.Drawing.Size(442, 151);
			this.waveformPainter.TabIndex = 15;
			this.waveformPainter.Text = "waveformPainter";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(479, 360);
			this.Controls.Add(this.groupBoxMic);
			this.Controls.Add(this.groupBoxConvert);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.Text = "MainWindow";
			this.groupBoxConvert.ResumeLayout(false);
			this.groupBoxConvert.PerformLayout();
			this.groupBoxMic.ResumeLayout(false);
			this.groupBoxMic.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBoxConvert;
		private System.Windows.Forms.Label labelFileToConv;
		private System.Windows.Forms.Button convertButton;
		private System.Windows.Forms.GroupBox groupBoxMic;
		private System.Windows.Forms.Button startRecButton;
		private System.Windows.Forms.ComboBox devicesComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button stopRecButton;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button stopListenButton;
		private System.Windows.Forms.Button startListenButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private NAudio.Gui.WaveformPainter waveformPainter;
	}
}

