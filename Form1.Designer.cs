namespace DrawApp {
	partial class Form1 {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BrowseGcodeBtn = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxLinkFile1 = new System.Windows.Forms.TextBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.Serial = new System.Windows.Forms.GroupBox();
            this.labelBauds = new System.Windows.Forms.Label();
            this.labelCOM = new System.Windows.Forms.Label();
            this.labelCommand = new System.Windows.Forms.Label();
            this.comboBoxBauds = new System.Windows.Forms.ComboBox();
            this.ReloadBtn = new System.Windows.Forms.Button();
            this.ImpGcode = new System.Windows.Forms.GroupBox();
            this.lableFile = new System.Windows.Forms.Label();
            this.Jog = new System.Windows.Forms.GroupBox();
            this.buttonCheckBoard = new System.Windows.Forms.Button();
            this.textBoxMaxY = new System.Windows.Forms.TextBox();
            this.textBoxMaxX = new System.Windows.Forms.TextBox();
            this.labelMaxY = new System.Windows.Forms.Label();
            this.labelMaxX = new System.Windows.Forms.Label();
            this.buttonXde = new System.Windows.Forms.Button();
            this.buttonYde = new System.Windows.Forms.Button();
            this.buttonYin = new System.Windows.Forms.Button();
            this.buttonX0Y0 = new System.Windows.Forms.Button();
            this.buttonXin = new System.Windows.Forms.Button();
            this.labelDistance = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.labelSpeedJog = new System.Windows.Forms.Label();
            this.Report = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.scrollOutputChkbox = new System.Windows.Forms.CheckBox();
            this.serialResponseList = new System.Windows.Forms.ListBox();
            this.ImpImage = new System.Windows.Forms.GroupBox();
            this.BrowseImgBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLinkFile2 = new System.Windows.Forms.TextBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.gbDrawing = new System.Windows.Forms.GroupBox();
            this.tbLines = new System.Windows.Forms.TextBox();
            this.btGcodeGen = new System.Windows.Forms.Button();
            this.gbSpeed = new System.Windows.Forms.GroupBox();
            this.lbmax3000 = new System.Windows.Forms.Label();
            this.lbmin2000 = new System.Windows.Forms.Label();
            this.lbmmmin2 = new System.Windows.Forms.Label();
            this.lbPWM = new System.Windows.Forms.Label();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.tbPWM = new System.Windows.Forms.TextBox();
            this.tbSpeed = new System.Windows.Forms.TextBox();
            this.gbAdjust = new System.Windows.Forms.GroupBox();
            this.tbBrightness = new System.Windows.Forms.TextBox();
            this.lbBrightness = new System.Windows.Forms.Label();
            this.lbx2 = new System.Windows.Forms.Label();
            this.lbx1 = new System.Windows.Forms.Label();
            this.lbContrast = new System.Windows.Forms.Label();
            this.tbContrast = new System.Windows.Forms.TextBox();
            this.lbZoom = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pnPicture = new System.Windows.Forms.Panel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.btGenerate = new System.Windows.Forms.Button();
            this.gbOffset = new System.Windows.Forms.GroupBox();
            this.tbXos = new System.Windows.Forms.TextBox();
            this.lbXos = new System.Windows.Forms.Label();
            this.lbmm4 = new System.Windows.Forms.Label();
            this.lbYos = new System.Windows.Forms.Label();
            this.lbmm3 = new System.Windows.Forms.Label();
            this.tbYos = new System.Windows.Forms.TextBox();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.btAuto = new System.Windows.Forms.Button();
            this.lbWidth = new System.Windows.Forms.Label();
            this.lbmm2 = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.lbmm1 = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.rowsInFileLbl = new System.Windows.Forms.Label();
            this.sentRowsLbl = new System.Windows.Forms.Label();
            this.Serial.SuspendLayout();
            this.ImpGcode.SuspendLayout();
            this.Jog.SuspendLayout();
            this.Report.SuspendLayout();
            this.ImpImage.SuspendLayout();
            this.gbDrawing.SuspendLayout();
            this.gbSpeed.SuspendLayout();
            this.gbAdjust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.pnPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.gbOffset.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BrowseGcodeBtn
            // 
            this.BrowseGcodeBtn.Location = new System.Drawing.Point(328, 24);
            this.BrowseGcodeBtn.Name = "BrowseGcodeBtn";
            this.BrowseGcodeBtn.Size = new System.Drawing.Size(75, 39);
            this.BrowseGcodeBtn.TabIndex = 0;
            this.BrowseGcodeBtn.Text = "Browse";
            this.BrowseGcodeBtn.UseVisualStyleBackColor = true;
            this.BrowseGcodeBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(153, 18);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(81, 24);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxLinkFile1
            // 
            this.textBoxLinkFile1.Location = new System.Drawing.Point(6, 34);
            this.textBoxLinkFile1.Name = "textBoxLinkFile1";
            this.textBoxLinkFile1.Size = new System.Drawing.Size(316, 20);
            this.textBoxLinkFile1.TabIndex = 2;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(153, 45);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(81, 24);
            this.buttonDisconnect.TabIndex = 5;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxCommand.Location = new System.Drawing.Point(68, 77);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.ReadOnly = true;
            this.textBoxCommand.Size = new System.Drawing.Size(166, 20);
            this.textBoxCommand.TabIndex = 7;
            this.textBoxCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCommand_KeyPress);
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(49, 19);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(68, 21);
            this.comboBoxCOM.TabIndex = 10;
            // 
            // Serial
            // 
            this.Serial.Controls.Add(this.labelBauds);
            this.Serial.Controls.Add(this.labelCOM);
            this.Serial.Controls.Add(this.labelCommand);
            this.Serial.Controls.Add(this.textBoxCommand);
            this.Serial.Controls.Add(this.buttonConnect);
            this.Serial.Controls.Add(this.buttonDisconnect);
            this.Serial.Controls.Add(this.comboBoxBauds);
            this.Serial.Controls.Add(this.comboBoxCOM);
            this.Serial.Controls.Add(this.ReloadBtn);
            this.Serial.Location = new System.Drawing.Point(12, 12);
            this.Serial.Name = "Serial";
            this.Serial.Size = new System.Drawing.Size(256, 112);
            this.Serial.TabIndex = 16;
            this.Serial.TabStop = false;
            this.Serial.Text = "Serial";
            // 
            // labelBauds
            // 
            this.labelBauds.AutoSize = true;
            this.labelBauds.Location = new System.Drawing.Point(8, 45);
            this.labelBauds.Name = "labelBauds";
            this.labelBauds.Size = new System.Drawing.Size(37, 13);
            this.labelBauds.TabIndex = 19;
            this.labelBauds.Text = "Bauds";
            // 
            // labelCOM
            // 
            this.labelCOM.AutoSize = true;
            this.labelCOM.Location = new System.Drawing.Point(8, 24);
            this.labelCOM.Name = "labelCOM";
            this.labelCOM.Size = new System.Drawing.Size(31, 13);
            this.labelCOM.TabIndex = 19;
            this.labelCOM.Text = "COM";
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Location = new System.Drawing.Point(8, 80);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(54, 13);
            this.labelCommand.TabIndex = 16;
            this.labelCommand.Text = "Command";
            // 
            // comboBoxBauds
            // 
            this.comboBoxBauds.FormattingEnabled = true;
            this.comboBoxBauds.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "",
            "",
            ""});
            this.comboBoxBauds.Location = new System.Drawing.Point(49, 42);
            this.comboBoxBauds.Name = "comboBoxBauds";
            this.comboBoxBauds.Size = new System.Drawing.Size(68, 21);
            this.comboBoxBauds.TabIndex = 1;
            this.comboBoxBauds.Text = "115200";
            // 
            // ReloadBtn
            // 
            this.ReloadBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReloadBtn.Image")));
            this.ReloadBtn.Location = new System.Drawing.Point(123, 18);
            this.ReloadBtn.Name = "ReloadBtn";
            this.ReloadBtn.Size = new System.Drawing.Size(24, 24);
            this.ReloadBtn.TabIndex = 11;
            this.ReloadBtn.UseVisualStyleBackColor = true;
            this.ReloadBtn.Click += new System.EventHandler(this.ReloadBtn_Click);
            // 
            // ImpGcode
            // 
            this.ImpGcode.Controls.Add(this.lableFile);
            this.ImpGcode.Controls.Add(this.textBoxLinkFile1);
            this.ImpGcode.Controls.Add(this.BrowseGcodeBtn);
            this.ImpGcode.Location = new System.Drawing.Point(744, 12);
            this.ImpGcode.Name = "ImpGcode";
            this.ImpGcode.Size = new System.Drawing.Size(414, 85);
            this.ImpGcode.TabIndex = 17;
            this.ImpGcode.TabStop = false;
            this.ImpGcode.Text = "Import G-Code";
            // 
            // lableFile
            // 
            this.lableFile.AutoSize = true;
            this.lableFile.Location = new System.Drawing.Point(6, 19);
            this.lableFile.Name = "lableFile";
            this.lableFile.Size = new System.Drawing.Size(23, 13);
            this.lableFile.TabIndex = 15;
            this.lableFile.Text = "File";
            // 
            // Jog
            // 
            this.Jog.Controls.Add(this.buttonCheckBoard);
            this.Jog.Controls.Add(this.textBoxMaxY);
            this.Jog.Controls.Add(this.textBoxMaxX);
            this.Jog.Controls.Add(this.labelMaxY);
            this.Jog.Controls.Add(this.labelMaxX);
            this.Jog.Controls.Add(this.buttonXde);
            this.Jog.Controls.Add(this.buttonYde);
            this.Jog.Controls.Add(this.buttonYin);
            this.Jog.Controls.Add(this.buttonX0Y0);
            this.Jog.Controls.Add(this.buttonXin);
            this.Jog.Controls.Add(this.labelDistance);
            this.Jog.Controls.Add(this.textBoxDistance);
            this.Jog.Controls.Add(this.textBoxSpeed);
            this.Jog.Controls.Add(this.labelSpeedJog);
            this.Jog.Location = new System.Drawing.Point(12, 130);
            this.Jog.Name = "Jog";
            this.Jog.Size = new System.Drawing.Size(256, 233);
            this.Jog.TabIndex = 21;
            this.Jog.TabStop = false;
            this.Jog.Text = "Jog";
            // 
            // buttonCheckBoard
            // 
            this.buttonCheckBoard.Location = new System.Drawing.Point(172, 180);
            this.buttonCheckBoard.Name = "buttonCheckBoard";
            this.buttonCheckBoard.Size = new System.Drawing.Size(75, 45);
            this.buttonCheckBoard.TabIndex = 26;
            this.buttonCheckBoard.Text = "Check Board";
            this.buttonCheckBoard.UseVisualStyleBackColor = true;
            this.buttonCheckBoard.Click += new System.EventHandler(this.buttonCheckBoard_Click);
            // 
            // textBoxMaxY
            // 
            this.textBoxMaxY.Location = new System.Drawing.Point(53, 205);
            this.textBoxMaxY.Name = "textBoxMaxY";
            this.textBoxMaxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxY.TabIndex = 25;
            this.textBoxMaxY.Text = "400";
            // 
            // textBoxMaxX
            // 
            this.textBoxMaxX.Location = new System.Drawing.Point(53, 180);
            this.textBoxMaxX.Name = "textBoxMaxX";
            this.textBoxMaxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxX.TabIndex = 24;
            this.textBoxMaxX.Text = "500";
            // 
            // labelMaxY
            // 
            this.labelMaxY.AutoSize = true;
            this.labelMaxY.Location = new System.Drawing.Point(11, 208);
            this.labelMaxY.Name = "labelMaxY";
            this.labelMaxY.Size = new System.Drawing.Size(36, 13);
            this.labelMaxY.TabIndex = 22;
            this.labelMaxY.Text = "max Y";
            // 
            // labelMaxX
            // 
            this.labelMaxX.AutoSize = true;
            this.labelMaxX.Location = new System.Drawing.Point(12, 183);
            this.labelMaxX.Name = "labelMaxX";
            this.labelMaxX.Size = new System.Drawing.Size(36, 13);
            this.labelMaxX.TabIndex = 23;
            this.labelMaxX.Text = "max X";
            // 
            // buttonXde
            // 
            this.buttonXde.Location = new System.Drawing.Point(10, 116);
            this.buttonXde.Name = "buttonXde";
            this.buttonXde.Size = new System.Drawing.Size(75, 23);
            this.buttonXde.TabIndex = 21;
            this.buttonXde.Text = "X -";
            this.buttonXde.UseVisualStyleBackColor = true;
            this.buttonXde.Click += new System.EventHandler(this.buttonXde_Click);
            // 
            // buttonYde
            // 
            this.buttonYde.Location = new System.Drawing.Point(91, 145);
            this.buttonYde.Name = "buttonYde";
            this.buttonYde.Size = new System.Drawing.Size(75, 23);
            this.buttonYde.TabIndex = 20;
            this.buttonYde.Text = "Y -";
            this.buttonYde.UseVisualStyleBackColor = true;
            this.buttonYde.Click += new System.EventHandler(this.buttonYde_Click);
            // 
            // buttonYin
            // 
            this.buttonYin.Location = new System.Drawing.Point(91, 87);
            this.buttonYin.Name = "buttonYin";
            this.buttonYin.Size = new System.Drawing.Size(75, 23);
            this.buttonYin.TabIndex = 19;
            this.buttonYin.Text = "Y +";
            this.buttonYin.UseVisualStyleBackColor = true;
            this.buttonYin.Click += new System.EventHandler(this.buttonYin_Click);
            // 
            // buttonX0Y0
            // 
            this.buttonX0Y0.Location = new System.Drawing.Point(91, 116);
            this.buttonX0Y0.Name = "buttonX0Y0";
            this.buttonX0Y0.Size = new System.Drawing.Size(75, 23);
            this.buttonX0Y0.TabIndex = 18;
            this.buttonX0Y0.Text = "Home";
            this.buttonX0Y0.UseVisualStyleBackColor = true;
            this.buttonX0Y0.Click += new System.EventHandler(this.buttonX0Y0_Click);
            // 
            // buttonXin
            // 
            this.buttonXin.Location = new System.Drawing.Point(172, 116);
            this.buttonXin.Name = "buttonXin";
            this.buttonXin.Size = new System.Drawing.Size(75, 23);
            this.buttonXin.TabIndex = 17;
            this.buttonXin.Text = "X +";
            this.buttonXin.UseVisualStyleBackColor = true;
            this.buttonXin.Click += new System.EventHandler(this.buttonXin_Click);
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(11, 58);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(93, 13);
            this.labelDistance.TabIndex = 16;
            this.labelDistance.Text = "Set Distance (mm)";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(126, 55);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(100, 20);
            this.textBoxDistance.TabIndex = 15;
            this.textBoxDistance.Text = "100";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(126, 25);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeed.TabIndex = 14;
            this.textBoxSpeed.Text = "500";
            this.textBoxSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSpeed_KeyPress);
            // 
            // labelSpeedJog
            // 
            this.labelSpeedJog.AutoSize = true;
            this.labelSpeedJog.Location = new System.Drawing.Point(11, 28);
            this.labelSpeedJog.Name = "labelSpeedJog";
            this.labelSpeedJog.Size = new System.Drawing.Size(103, 13);
            this.labelSpeedJog.TabIndex = 13;
            this.labelSpeedJog.Text = "Set Speed (mm/min)";
            // 
            // Report
            // 
            this.Report.Controls.Add(this.buttonClear);
            this.Report.Controls.Add(this.scrollOutputChkbox);
            this.Report.Controls.Add(this.serialResponseList);
            this.Report.Location = new System.Drawing.Point(12, 369);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(256, 280);
            this.Report.TabIndex = 22;
            this.Report.TabStop = false;
            this.Report.Text = "Report";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(172, 14);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 24);
            this.buttonClear.TabIndex = 22;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // scrollOutputChkbox
            // 
            this.scrollOutputChkbox.AutoSize = true;
            this.scrollOutputChkbox.Checked = true;
            this.scrollOutputChkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scrollOutputChkbox.Location = new System.Drawing.Point(5, 21);
            this.scrollOutputChkbox.Name = "scrollOutputChkbox";
            this.scrollOutputChkbox.Size = new System.Drawing.Size(124, 17);
            this.scrollOutputChkbox.TabIndex = 21;
            this.scrollOutputChkbox.Text = "Scroll output window";
            this.scrollOutputChkbox.UseVisualStyleBackColor = true;
            // 
            // serialResponseList
            // 
            this.serialResponseList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.serialResponseList.FormattingEnabled = true;
            this.serialResponseList.Location = new System.Drawing.Point(5, 44);
            this.serialResponseList.Name = "serialResponseList";
            this.serialResponseList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.serialResponseList.Size = new System.Drawing.Size(242, 225);
            this.serialResponseList.TabIndex = 20;
            this.serialResponseList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.serialResponseList_DrawItem);
            // 
            // ImpImage
            // 
            this.ImpImage.Controls.Add(this.BrowseImgBtn);
            this.ImpImage.Controls.Add(this.label1);
            this.ImpImage.Controls.Add(this.textBoxLinkFile2);
            this.ImpImage.Location = new System.Drawing.Point(277, 12);
            this.ImpImage.Name = "ImpImage";
            this.ImpImage.Size = new System.Drawing.Size(439, 85);
            this.ImpImage.TabIndex = 23;
            this.ImpImage.TabStop = false;
            this.ImpImage.Text = "Import Image";
            // 
            // BrowseImgBtn
            // 
            this.BrowseImgBtn.Location = new System.Drawing.Point(358, 24);
            this.BrowseImgBtn.Name = "BrowseImgBtn";
            this.BrowseImgBtn.Size = new System.Drawing.Size(75, 39);
            this.BrowseImgBtn.TabIndex = 16;
            this.BrowseImgBtn.Text = "Browse";
            this.BrowseImgBtn.UseVisualStyleBackColor = true;
            this.BrowseImgBtn.Click += new System.EventHandler(this.BrowseImgBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "File";
            // 
            // textBoxLinkFile2
            // 
            this.textBoxLinkFile2.Location = new System.Drawing.Point(6, 34);
            this.textBoxLinkFile2.Name = "textBoxLinkFile2";
            this.textBoxLinkFile2.Size = new System.Drawing.Size(336, 20);
            this.textBoxLinkFile2.TabIndex = 0;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // gbDrawing
            // 
            this.gbDrawing.Controls.Add(this.tbLines);
            this.gbDrawing.Controls.Add(this.btGcodeGen);
            this.gbDrawing.Controls.Add(this.gbSpeed);
            this.gbDrawing.Controls.Add(this.gbAdjust);
            this.gbDrawing.Controls.Add(this.lbZoom);
            this.gbDrawing.Controls.Add(this.trackBar1);
            this.gbDrawing.Controls.Add(this.pnPicture);
            this.gbDrawing.Controls.Add(this.btGenerate);
            this.gbDrawing.Controls.Add(this.gbOffset);
            this.gbDrawing.Controls.Add(this.gbSize);
            this.gbDrawing.Controls.Add(this.buttonStart);
            this.gbDrawing.Controls.Add(this.buttonStop);
            this.gbDrawing.Controls.Add(this.rowsInFileLbl);
            this.gbDrawing.Controls.Add(this.sentRowsLbl);
            this.gbDrawing.Enabled = false;
            this.gbDrawing.Location = new System.Drawing.Point(274, 103);
            this.gbDrawing.Name = "gbDrawing";
            this.gbDrawing.Size = new System.Drawing.Size(884, 546);
            this.gbDrawing.TabIndex = 24;
            this.gbDrawing.TabStop = false;
            this.gbDrawing.Text = "Drawing";
            // 
            // tbLines
            // 
            this.tbLines.Location = new System.Drawing.Point(278, 16);
            this.tbLines.Name = "tbLines";
            this.tbLines.Size = new System.Drawing.Size(54, 20);
            this.tbLines.TabIndex = 31;
            this.tbLines.Text = "0";
            // 
            // btGcodeGen
            // 
            this.btGcodeGen.Location = new System.Drawing.Point(52, 469);
            this.btGcodeGen.Name = "btGcodeGen";
            this.btGcodeGen.Size = new System.Drawing.Size(75, 23);
            this.btGcodeGen.TabIndex = 30;
            this.btGcodeGen.Text = "G-code Gen";
            this.btGcodeGen.UseVisualStyleBackColor = true;
            this.btGcodeGen.Click += new System.EventHandler(this.btGcodeGen_Click);
            // 
            // gbSpeed
            // 
            this.gbSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.gbSpeed.Controls.Add(this.lbmax3000);
            this.gbSpeed.Controls.Add(this.lbmin2000);
            this.gbSpeed.Controls.Add(this.lbmmmin2);
            this.gbSpeed.Controls.Add(this.lbPWM);
            this.gbSpeed.Controls.Add(this.lbSpeed);
            this.gbSpeed.Controls.Add(this.tbPWM);
            this.gbSpeed.Controls.Add(this.tbSpeed);
            this.gbSpeed.Location = new System.Drawing.Point(9, 314);
            this.gbSpeed.Name = "gbSpeed";
            this.gbSpeed.Size = new System.Drawing.Size(165, 94);
            this.gbSpeed.TabIndex = 26;
            this.gbSpeed.TabStop = false;
            this.gbSpeed.Text = "Speed";
            // 
            // lbmax3000
            // 
            this.lbmax3000.AutoSize = true;
            this.lbmax3000.Location = new System.Drawing.Point(112, 68);
            this.lbmax3000.Name = "lbmax3000";
            this.lbmax3000.Size = new System.Drawing.Size(51, 13);
            this.lbmax3000.TabIndex = 24;
            this.lbmax3000.Text = "Max3000";
            // 
            // lbmin2000
            // 
            this.lbmin2000.AutoSize = true;
            this.lbmin2000.Location = new System.Drawing.Point(112, 55);
            this.lbmin2000.Name = "lbmin2000";
            this.lbmin2000.Size = new System.Drawing.Size(48, 13);
            this.lbmin2000.TabIndex = 24;
            this.lbmin2000.Text = "Min2000";
            // 
            // lbmmmin2
            // 
            this.lbmmmin2.AutoSize = true;
            this.lbmmmin2.Location = new System.Drawing.Point(118, 24);
            this.lbmmmin2.Name = "lbmmmin2";
            this.lbmmmin2.Size = new System.Drawing.Size(44, 13);
            this.lbmmmin2.TabIndex = 24;
            this.lbmmmin2.Text = "mm/min";
            // 
            // lbPWM
            // 
            this.lbPWM.AutoSize = true;
            this.lbPWM.Location = new System.Drawing.Point(6, 61);
            this.lbPWM.Name = "lbPWM";
            this.lbPWM.Size = new System.Drawing.Size(35, 13);
            this.lbPWM.TabIndex = 20;
            this.lbPWM.Text = "Servo";
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Location = new System.Drawing.Point(6, 24);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(38, 13);
            this.lbSpeed.TabIndex = 20;
            this.lbSpeed.Text = "Speed";
            // 
            // tbPWM
            // 
            this.tbPWM.Location = new System.Drawing.Point(47, 58);
            this.tbPWM.Name = "tbPWM";
            this.tbPWM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPWM.Size = new System.Drawing.Size(65, 20);
            this.tbPWM.TabIndex = 21;
            this.tbPWM.Text = "2700";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(64, 21);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbSpeed.Size = new System.Drawing.Size(52, 20);
            this.tbSpeed.TabIndex = 21;
            this.tbSpeed.Text = "500";
            // 
            // gbAdjust
            // 
            this.gbAdjust.BackColor = System.Drawing.SystemColors.Control;
            this.gbAdjust.Controls.Add(this.tbBrightness);
            this.gbAdjust.Controls.Add(this.lbBrightness);
            this.gbAdjust.Controls.Add(this.lbx2);
            this.gbAdjust.Controls.Add(this.lbx1);
            this.gbAdjust.Controls.Add(this.lbContrast);
            this.gbAdjust.Controls.Add(this.tbContrast);
            this.gbAdjust.Location = new System.Drawing.Point(9, 231);
            this.gbAdjust.Name = "gbAdjust";
            this.gbAdjust.Size = new System.Drawing.Size(165, 77);
            this.gbAdjust.TabIndex = 26;
            this.gbAdjust.TabStop = false;
            this.gbAdjust.Text = "Adjust";
            // 
            // tbBrightness
            // 
            this.tbBrightness.Location = new System.Drawing.Point(66, 19);
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbBrightness.Size = new System.Drawing.Size(52, 20);
            this.tbBrightness.TabIndex = 21;
            this.tbBrightness.Text = "0.5";
            // 
            // lbBrightness
            // 
            this.lbBrightness.AutoSize = true;
            this.lbBrightness.Location = new System.Drawing.Point(6, 22);
            this.lbBrightness.Name = "lbBrightness";
            this.lbBrightness.Size = new System.Drawing.Size(56, 13);
            this.lbBrightness.TabIndex = 20;
            this.lbBrightness.Text = "Brightness";
            // 
            // lbx2
            // 
            this.lbx2.AutoSize = true;
            this.lbx2.Location = new System.Drawing.Point(132, 48);
            this.lbx2.Name = "lbx2";
            this.lbx2.Size = new System.Drawing.Size(12, 13);
            this.lbx2.TabIndex = 22;
            this.lbx2.Text = "x";
            // 
            // lbx1
            // 
            this.lbx1.AutoSize = true;
            this.lbx1.Location = new System.Drawing.Point(132, 22);
            this.lbx1.Name = "lbx1";
            this.lbx1.Size = new System.Drawing.Size(12, 13);
            this.lbx1.TabIndex = 22;
            this.lbx1.Text = "x";
            // 
            // lbContrast
            // 
            this.lbContrast.AutoSize = true;
            this.lbContrast.Location = new System.Drawing.Point(6, 51);
            this.lbContrast.Name = "lbContrast";
            this.lbContrast.Size = new System.Drawing.Size(46, 13);
            this.lbContrast.TabIndex = 20;
            this.lbContrast.Text = "Contrast";
            // 
            // tbContrast
            // 
            this.tbContrast.Location = new System.Drawing.Point(66, 45);
            this.tbContrast.Name = "tbContrast";
            this.tbContrast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbContrast.Size = new System.Drawing.Size(52, 20);
            this.tbContrast.TabIndex = 21;
            this.tbContrast.Text = "2";
            // 
            // lbZoom
            // 
            this.lbZoom.AutoSize = true;
            this.lbZoom.Location = new System.Drawing.Point(621, 20);
            this.lbZoom.Name = "lbZoom";
            this.lbZoom.Size = new System.Drawing.Size(34, 13);
            this.lbZoom.TabIndex = 29;
            this.lbZoom.Text = "Zoom";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(664, 14);
            this.trackBar1.Maximum = 3;
            this.trackBar1.Minimum = -3;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(193, 45);
            this.trackBar1.TabIndex = 28;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pnPicture
            // 
            this.pnPicture.AutoScroll = true;
            this.pnPicture.Controls.Add(this.PictureBox);
            this.pnPicture.Location = new System.Drawing.Point(180, 55);
            this.pnPicture.Name = "pnPicture";
            this.pnPicture.Size = new System.Drawing.Size(693, 480);
            this.pnPicture.TabIndex = 28;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.PictureBox.Location = new System.Drawing.Point(15, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(662, 473);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox.TabIndex = 27;
            this.PictureBox.TabStop = false;
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(52, 440);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(75, 23);
            this.btGenerate.TabIndex = 26;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // gbOffset
            // 
            this.gbOffset.BackColor = System.Drawing.SystemColors.Control;
            this.gbOffset.Controls.Add(this.tbXos);
            this.gbOffset.Controls.Add(this.lbXos);
            this.gbOffset.Controls.Add(this.lbmm4);
            this.gbOffset.Controls.Add(this.lbYos);
            this.gbOffset.Controls.Add(this.lbmm3);
            this.gbOffset.Controls.Add(this.tbYos);
            this.gbOffset.Location = new System.Drawing.Point(9, 148);
            this.gbOffset.Name = "gbOffset";
            this.gbOffset.Size = new System.Drawing.Size(165, 77);
            this.gbOffset.TabIndex = 25;
            this.gbOffset.TabStop = false;
            this.gbOffset.Text = "Offset";
            // 
            // tbXos
            // 
            this.tbXos.Location = new System.Drawing.Point(66, 19);
            this.tbXos.Name = "tbXos";
            this.tbXos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbXos.Size = new System.Drawing.Size(52, 20);
            this.tbXos.TabIndex = 21;
            this.tbXos.Text = "0";
            // 
            // lbXos
            // 
            this.lbXos.AutoSize = true;
            this.lbXos.Location = new System.Drawing.Point(6, 19);
            this.lbXos.Name = "lbXos";
            this.lbXos.Size = new System.Drawing.Size(43, 13);
            this.lbXos.TabIndex = 20;
            this.lbXos.Text = "X-offset";
            // 
            // lbmm4
            // 
            this.lbmm4.AutoSize = true;
            this.lbmm4.Location = new System.Drawing.Point(132, 48);
            this.lbmm4.Name = "lbmm4";
            this.lbmm4.Size = new System.Drawing.Size(23, 13);
            this.lbmm4.TabIndex = 22;
            this.lbmm4.Text = "mm";
            // 
            // lbYos
            // 
            this.lbYos.AutoSize = true;
            this.lbYos.Location = new System.Drawing.Point(6, 49);
            this.lbYos.Name = "lbYos";
            this.lbYos.Size = new System.Drawing.Size(43, 13);
            this.lbYos.TabIndex = 20;
            this.lbYos.Text = "Y-offset";
            // 
            // lbmm3
            // 
            this.lbmm3.AutoSize = true;
            this.lbmm3.Location = new System.Drawing.Point(132, 22);
            this.lbmm3.Name = "lbmm3";
            this.lbmm3.Size = new System.Drawing.Size(23, 13);
            this.lbmm3.TabIndex = 22;
            this.lbmm3.Text = "mm";
            // 
            // tbYos
            // 
            this.tbYos.Location = new System.Drawing.Point(66, 45);
            this.tbYos.Name = "tbYos";
            this.tbYos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbYos.Size = new System.Drawing.Size(52, 20);
            this.tbYos.TabIndex = 21;
            this.tbYos.Text = "0";
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.SystemColors.Control;
            this.gbSize.Controls.Add(this.tbWidth);
            this.gbSize.Controls.Add(this.btAuto);
            this.gbSize.Controls.Add(this.lbWidth);
            this.gbSize.Controls.Add(this.lbmm2);
            this.gbSize.Controls.Add(this.lbHeight);
            this.gbSize.Controls.Add(this.lbmm1);
            this.gbSize.Controls.Add(this.tbHeight);
            this.gbSize.Location = new System.Drawing.Point(9, 40);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(165, 102);
            this.gbSize.TabIndex = 24;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(66, 16);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbWidth.Size = new System.Drawing.Size(52, 20);
            this.tbWidth.TabIndex = 21;
            this.tbWidth.Text = "210";
            // 
            // btAuto
            // 
            this.btAuto.Location = new System.Drawing.Point(43, 71);
            this.btAuto.Name = "btAuto";
            this.btAuto.Size = new System.Drawing.Size(75, 23);
            this.btAuto.TabIndex = 23;
            this.btAuto.Text = "Auto";
            this.btAuto.UseVisualStyleBackColor = true;
            this.btAuto.Click += new System.EventHandler(this.btAuto_Click);
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Location = new System.Drawing.Point(4, 22);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(35, 13);
            this.lbWidth.TabIndex = 20;
            this.lbWidth.Text = "Width";
            // 
            // lbmm2
            // 
            this.lbmm2.AutoSize = true;
            this.lbmm2.Location = new System.Drawing.Point(132, 48);
            this.lbmm2.Name = "lbmm2";
            this.lbmm2.Size = new System.Drawing.Size(23, 13);
            this.lbmm2.TabIndex = 22;
            this.lbmm2.Text = "mm";
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(4, 52);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(38, 13);
            this.lbHeight.TabIndex = 20;
            this.lbHeight.Text = "Height";
            // 
            // lbmm1
            // 
            this.lbmm1.AutoSize = true;
            this.lbmm1.Location = new System.Drawing.Point(132, 22);
            this.lbmm1.Name = "lbmm1";
            this.lbmm1.Size = new System.Drawing.Size(23, 13);
            this.lbmm1.TabIndex = 22;
            this.lbmm1.Text = "mm";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(66, 42);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbHeight.Size = new System.Drawing.Size(52, 20);
            this.tbHeight.TabIndex = 21;
            this.tbHeight.Text = "297";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(180, 14);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(92, 24);
            this.buttonStart.TabIndex = 15;
            this.buttonStart.Text = "Start from Line:";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(352, 14);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(52, 24);
            this.buttonStop.TabIndex = 18;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // rowsInFileLbl
            // 
            this.rowsInFileLbl.AutoSize = true;
            this.rowsInFileLbl.Location = new System.Drawing.Point(520, 20);
            this.rowsInFileLbl.Name = "rowsInFileLbl";
            this.rowsInFileLbl.Size = new System.Drawing.Size(46, 13);
            this.rowsInFileLbl.TabIndex = 16;
            this.rowsInFileLbl.Text = "Rows: 0";
            // 
            // sentRowsLbl
            // 
            this.sentRowsLbl.AutoSize = true;
            this.sentRowsLbl.Location = new System.Drawing.Point(410, 20);
            this.sentRowsLbl.Name = "sentRowsLbl";
            this.sentRowsLbl.Size = new System.Drawing.Size(66, 13);
            this.sentRowsLbl.TabIndex = 17;
            this.sentRowsLbl.Text = "Sent rows: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 659);
            this.Controls.Add(this.gbDrawing);
            this.Controls.Add(this.ImpImage);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.Jog);
            this.Controls.Add(this.ImpGcode);
            this.Controls.Add(this.Serial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DrawApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Serial.ResumeLayout(false);
            this.Serial.PerformLayout();
            this.ImpGcode.ResumeLayout(false);
            this.ImpGcode.PerformLayout();
            this.Jog.ResumeLayout(false);
            this.Jog.PerformLayout();
            this.Report.ResumeLayout(false);
            this.Report.PerformLayout();
            this.ImpImage.ResumeLayout(false);
            this.ImpImage.PerformLayout();
            this.gbDrawing.ResumeLayout(false);
            this.gbDrawing.PerformLayout();
            this.gbSpeed.ResumeLayout(false);
            this.gbSpeed.PerformLayout();
            this.gbAdjust.ResumeLayout(false);
            this.gbAdjust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.pnPicture.ResumeLayout(false);
            this.pnPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.gbOffset.ResumeLayout(false);
            this.gbOffset.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button BrowseGcodeBtn;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.TextBox textBoxLinkFile1;
		private System.Windows.Forms.Button buttonDisconnect;
		private System.Windows.Forms.TextBox textBoxCommand;
		private System.Windows.Forms.ComboBox comboBoxCOM;
		private System.Windows.Forms.Button ReloadBtn;
		private System.Windows.Forms.GroupBox Serial;
		private System.Windows.Forms.GroupBox ImpGcode;
		private System.Windows.Forms.Label labelCommand;
		private System.Windows.Forms.Label lableFile;
        private System.Windows.Forms.Label labelBauds;
        private System.Windows.Forms.Label labelCOM;
        private System.Windows.Forms.ComboBox comboBoxBauds;
        private System.Windows.Forms.GroupBox Jog;
        private System.Windows.Forms.Button buttonCheckBoard;
        private System.Windows.Forms.TextBox textBoxMaxY;
        private System.Windows.Forms.TextBox textBoxMaxX;
        private System.Windows.Forms.Label labelMaxY;
        private System.Windows.Forms.Label labelMaxX;
        private System.Windows.Forms.Button buttonXde;
        private System.Windows.Forms.Button buttonYde;
        private System.Windows.Forms.Button buttonYin;
        private System.Windows.Forms.Button buttonX0Y0;
        private System.Windows.Forms.Button buttonXin;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Label labelSpeedJog;
        private System.Windows.Forms.GroupBox Report;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox scrollOutputChkbox;
        private System.Windows.Forms.ListBox serialResponseList;
        private System.Windows.Forms.GroupBox ImpImage;
        private System.Windows.Forms.Button BrowseImgBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLinkFile2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.GroupBox gbDrawing;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label rowsInFileLbl;
        private System.Windows.Forms.Label sentRowsLbl;
        private System.Windows.Forms.Label lbmm2;
        private System.Windows.Forms.Label lbmm1;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.GroupBox gbOffset;
        private System.Windows.Forms.TextBox tbXos;
        private System.Windows.Forms.Label lbXos;
        private System.Windows.Forms.Label lbmm4;
        private System.Windows.Forms.Label lbYos;
        private System.Windows.Forms.Label lbmm3;
        private System.Windows.Forms.TextBox tbYos;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.Button btAuto;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Panel pnPicture;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbZoom;
        private System.Windows.Forms.GroupBox gbAdjust;
        private System.Windows.Forms.TextBox tbBrightness;
        private System.Windows.Forms.Label lbBrightness;
        private System.Windows.Forms.Label lbContrast;
        private System.Windows.Forms.TextBox tbContrast;
        private System.Windows.Forms.GroupBox gbSpeed;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.TextBox tbSpeed;
        private System.Windows.Forms.Label lbmmmin2;
        private System.Windows.Forms.Label lbmax3000;
        private System.Windows.Forms.Label lbmin2000;
        private System.Windows.Forms.Label lbPWM;
        private System.Windows.Forms.TextBox tbPWM;
        private System.Windows.Forms.Label lbx2;
        private System.Windows.Forms.Label lbx1;
        private System.Windows.Forms.Button btGcodeGen;
        private System.Windows.Forms.TextBox tbLines;
    }
}

