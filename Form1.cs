using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace DrawApp
{
    public partial class Form1 : Form
    {
        // variable for g-code sender
        string RxString;
        List<string> lines = new List<string>();
        int CurrentRow = 0;
        bool transfer = false;

        // variable for image processing
        Bitmap bitmap, tmpBm1, tmpBm2, bitmap_draw; // Img import
        int widthDraw_pixel;  // Widght of draw
        int heightDraw_pixel; // Height of draw
        double pixel_per_mm = 3.780952381;  // 96 PPI 
        byte[,,] imageArray = null;
        byte[,,] ditheredArray = null;

        // variable for g-code generate
        double mm_per_pixel = 0.264483627;  // 96 PPI 
        string folderpath = "";
        string filename_gcode = "";
        List<string> list_command = new List<string>();
        double offsetx = 0;
        double offsety = 0;
        double speed = 500;

        enum status_pixel_chain
        {
            none,
            white,
            black
        }

        public Form1()
        {
            InitializeComponent();

            System.Windows.Forms.Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(Application_UnhandledException);

            disableControlsForPrinting();
            buttonStop.Enabled = false;
            widthDraw_pixel = (int)(Convert.ToInt32(tbWidth.Text) * pixel_per_mm);
            heightDraw_pixel = (int)(Convert.ToInt32(tbHeight.Text) * pixel_per_mm);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PictureBox.Image = null;
            PictureBox.Image = ZoomPicture(bitmap_draw, new Size(trackBar1.Value, trackBar1.Value));
        }

        Image ZoomPicture(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * Math.Pow(2, size.Width)), Convert.ToInt32(img.Height * Math.Pow(2, size.Height)));
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            return bm;
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;
            MessageBox.Show(ex.Message, "Thread exception");
        }

        private static void Application_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject != null)
            {
                Exception ex = (Exception)e.ExceptionObject;
                MessageBox.Show(ex.Message, "Application exception");
            }
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            buttonStop.Enabled = true;
            ImpImage.Enabled = false;
            gbDrawing.Enabled = true;
            gbOffset.Enabled = false;
            gbSize.Enabled = false;

            openFileDialog1.Filter = "G-code Files(*.CNC;*.NC;*.TAP;*.TXT;*.gcode)|*.CNC;*.NC;*.TAP;*.TXT;*.gcode|All files (*.*)|*.*";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxLinkFile1.Text = openFileDialog1.FileName;

                if (File.Exists(textBoxLinkFile1.Text))
                {
                    using (StreamReader r = new StreamReader(textBoxLinkFile1.Text))
                    {
                        string line = String.Empty;
                        int rowCounter = 0;
                        while ((line = r.ReadLine()) != null)
                        {
                            if (line.Trim() != "")
                                rowCounter++;
                        }
                        rowsInFileLbl.Text = "Rows: " + rowCounter.ToString();
                    }
                }
            }
        }

        private void BrowseImgBtn_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            gbDrawing.Enabled = true;
            gbSize.Enabled = true;
            tbHeight.Text = "297";
            tbWidth.Text = "210";
            ImpGcode.Enabled = false;
            btGcodeGen.Enabled = false;

            openFileDialog2.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png| All files (*.*)|*.*";
            openFileDialog2.FileName = "";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {

                System.IO.FileInfo fileinfo = new System.IO.FileInfo(openFileDialog2.FileName);
                folderpath = fileinfo.DirectoryName; // save path

                textBoxLinkFile2.Text = openFileDialog2.FileName;

                if (File.Exists(textBoxLinkFile2.Text))
                {
                    bitmap = new Bitmap(openFileDialog2.FileName);
                }
            }
        }

        private void btAuto_Click(object sender, EventArgs e)
        {
            /// Calculate size of image to draw ///
            /// 
            widthDraw_pixel = (int)(Convert.ToInt32(tbWidth.Text) * pixel_per_mm);
            heightDraw_pixel = (int)(Convert.ToInt32(tbHeight.Text) * pixel_per_mm);
            double widthScale = ((double)widthDraw_pixel) / (double)bitmap.Width;
            double heightScale = ((double)heightDraw_pixel) / (double)bitmap.Height;
            double scale = Math.Min(widthScale, heightScale);
            // recalculate width or height
            if (scale == widthScale)
            {
                heightDraw_pixel = Convert.ToInt32(widthScale * bitmap.Height);
                tbHeight.Text = Convert.ToString(Convert.ToInt32(heightDraw_pixel / pixel_per_mm));
            }
            else
            {
                widthDraw_pixel = Convert.ToInt32(heightScale * bitmap.Width);
                tbWidth.Text = Convert.ToString(Convert.ToInt32(widthDraw_pixel / pixel_per_mm));
            }
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            /// Generate image to draw ///
            /// 

            // Create img to process
            widthDraw_pixel = (int)(Convert.ToInt32(tbWidth.Text) * pixel_per_mm);
            heightDraw_pixel = (int)(Convert.ToInt32(tbHeight.Text) * pixel_per_mm);
            using (Bitmap tmp1 = new Bitmap(bitmap))
                tmpBm1 = tmp1.Clone(new Rectangle(0, 0, tmp1.Width, tmp1.Height), System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            bitmap_draw = new Bitmap(widthDraw_pixel, heightDraw_pixel);
            bitmap_draw = ResizeImage(tmpBm1, widthDraw_pixel, heightDraw_pixel);

            // Brightness and Contrast
            using (Bitmap tmp2 = new Bitmap(bitmap_draw))
                tmpBm2 = tmp2.Clone(new Rectangle(0, 0, tmp2.Width, tmp2.Height), System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            float brightness = float.Parse(tbBrightness.Text);
            float contrast = float.Parse(tbContrast.Text);
            float gamma = 1.0f;                                     // no change in gamma

            float adjustedBrightness = brightness - 1.0f;

            float[][] ptsArray ={					// create matrix that will brighten and contrast the image
			new float[] {contrast, 0, 0, 0, 0},		// scale red
			new float[] {0, contrast, 0, 0, 0},		// scale green
			new float[] {0, 0, contrast, 0, 0},		// scale blue
			new float[] {0, 0, 0, 1.0f, 0},			// don't scale alpha
			new float[] {adjustedBrightness, adjustedBrightness, adjustedBrightness, 0, 1}};

            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(ptsArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
            Graphics g = Graphics.FromImage(bitmap_draw);
            g.DrawImage(tmpBm2, new Rectangle(0, 0, bitmap_draw.Width, bitmap_draw.Height), 0, 0, tmpBm2.Width, tmpBm2.Height, GraphicsUnit.Pixel, imageAttributes);

            // Img processing for draw with Atkimson Dithering
            imageArray = Dithering.GetImageArray(bitmap_draw);
            ditheredArray = Dithering.Make(imageArray, 1, true);
            bitmap_draw = Dithering.GetBitmapFromArray(ditheredArray);

            // Display image
            PictureBox.Image = bitmap_draw;
            PictureBox.Image.Save(Path.Combine(folderpath, "draw_image.jpg"));

            btGcodeGen.Enabled = true;
        }

        private void btGcodeGen_Click(object sender, EventArgs e)
        {
            gbAdjust.Enabled = false;
            gbOffset.Enabled = false;
            gbSpeed.Enabled = false;
            gbSize.Enabled = false;


            offsetx = Convert.ToDouble(tbXos.Text);
            offsety = Convert.ToDouble(tbYos.Text);
            speed = Convert.ToDouble(tbSpeed.Text);

            filename_gcode = Path.Combine(folderpath, "g-code-generate.gcode");
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(filename_gcode))
                {
                    File.Delete(filename_gcode);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

            list_command.Add("G0 X0 Y0 F" + String.Format("{0:0.000}", speed));
            list_command.Add("M3 S0");

            status_pixel_chain st = status_pixel_chain.none;
            bool IsLefttoRight = true;
            int w = bitmap_draw.Width - 1;
            int h = bitmap_draw.Height - 1;
            for (int i = h; i >= 0; i--)    // bottom to top image
            {
                string loc_y = "Y" + String.Format("{0:0.000}", (h - i) * mm_per_pixel + offsety);
                string len_h = "G0 " + loc_y + " S0";
                list_command.Add(len_h);
                string len_w;
                if (IsLefttoRight == true)
                {
                    for (int j = 0; j <= w; j++)
                    {
                        Color pixel = bitmap_draw.GetPixel(j, i);
                        int grayScale = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));
                        if (grayScale < 127)
                        {
                            if (st != status_pixel_chain.black)
                            {
                                string loc_x = "X" + String.Format("{0:0.000}", j * mm_per_pixel + offsetx);
                                len_w = "G0 " + loc_x + " " + loc_y + " S0";
                                list_command.Add(len_w);
                                st = status_pixel_chain.black;
                            }
                        }
                        else
                        {
                            if (st != status_pixel_chain.white)
                            {
                                string loc_x = "X" + String.Format("{0:0.000}", j * mm_per_pixel + offsetx);
                                len_w = "G1 " + loc_x + " S" + tbPWM.Text;
                                list_command.Add(len_w);
                                st = status_pixel_chain.white;
                            }
                        }
                    }
                }
                else if (IsLefttoRight == false)
                {
                    for (int j = w; j >= 0; j--)
                    {
                        Color pixel = bitmap_draw.GetPixel(j, i);
                        int grayScale = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));
                        if (grayScale < 127)
                        {
                            if (st != status_pixel_chain.black)
                            {
                                string loc_x = "X" + String.Format("{0:0.000}", j * mm_per_pixel + offsetx);
                                len_w = "G0 " + loc_x + " " + loc_y + " S0";
                                list_command.Add(len_w);
                                st = status_pixel_chain.black;
                            }
                        }
                        else
                        {
                            if (st != status_pixel_chain.white)
                            {
                                string loc_x = "X" + String.Format("{0:0.000}", j * mm_per_pixel + offsetx);
                                len_w = "G1 " + loc_x + " S" + tbPWM.Text;
                                list_command.Add(len_w);
                                st = status_pixel_chain.white;
                            }
                        }
                    }
                }
                IsLefttoRight = !IsLefttoRight;
            }

            list_command.Add("M3 S0");
            list_command.Add("M5");
            list_command.Add("G0 X0 Y0");

            using (TextWriter tw = new StreamWriter(filename_gcode))
            {
                foreach (String s in list_command)
                    tw.WriteLine(s);
            }
            list_command.Clear();

            textBoxLinkFile1.Text = filename_gcode;
            buttonStart.Enabled = true;

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxCOM.Text != "")
            {
                serialPort1.PortName = comboBoxCOM.SelectedItem.ToString();
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBauds.Text);

                serialPort1.Open();

                if (serialPort1.IsOpen)
                {
                    comboBoxCOM.Enabled = false;
                    comboBoxBauds.Enabled = false;
                    ReloadBtn.Enabled = false;
                    buttonConnect.Enabled = false;
                    buttonDisconnect.Enabled = true;
                    textBoxCommand.ReadOnly = false;
                    enableControlsForPrinting();
                }
            }
            else
            {
                MessageBox.Show("Check your connect and Press reload please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                comboBoxCOM.Enabled = true;
                ReloadBtn.Enabled = true;
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
                textBoxCommand.ReadOnly = true;
                transfer = false;
                disableControlsForPrinting();
                BrowseGcodeBtn.Enabled = true;
                buttonStop.Enabled = false;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void textBoxCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // ASCII enter = 13(decimal)
            {
                if (!serialPort1.IsOpen) return;
                textBoxCommand.Text += "\r\n";
                char[] buff = new char[textBoxCommand.Text.Length];
                buff = textBoxCommand.Text.ToCharArray();
                serialPort1.Write(buff, 0, buff.Count());
                serialResponseList.Items.Add(textBoxCommand.Text);
                serialResponseList.TopIndex = serialResponseList.Items.Count - 1;
                textBoxCommand.Text = "";
            }
        }

        private void DisplayText(object sender, EventArgs e)
        {
            string[] arr = RxString.Replace("\n\r", "\r\n").Replace("\r\n", "\n").Trim('\n').Split('\n');
            foreach (string item in arr)
            {
                if (item != "ok")
                {
                    serialResponseList.Items.Add(item);
                    serialResponseList.TopIndex = serialResponseList.Items.Count - 1;
                }
            }
        }

        private void DisplayCurrentRow(object sender, EventArgs e)
        {
            serialResponseList.Items.Add(lines[CurrentRow - 1]);
            if (scrollOutputChkbox.Checked)
                serialResponseList.TopIndex = serialResponseList.Items.Count - 1;
            sentRowsLbl.Text = "Sent rows: " + CurrentRow.ToString();
        }

        private void PrintDone(object sender, EventArgs e)
        {
            MessageBox.Show("All the G-code was sent to Grbl.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            transfer = false;
            enableControlsForPrinting();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString += serialPort1.ReadExisting();
            if (RxString.EndsWith("\r\n") || RxString.EndsWith("\n\r"))
            {
                this.Invoke(new EventHandler(DisplayText));
                RxString = String.Empty;
                if (transfer)
                    sendNextLine();
            }

        }

        private void sendNextLine()
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    if (CurrentRow < lines.Count)
                    {
                        serialPort1.WriteLine(lines[CurrentRow]);
                        CurrentRow++;
                        this.Invoke(new EventHandler(DisplayCurrentRow));
                    }
                    else
                    {
                        transfer = false;
                        this.Invoke(new EventHandler(PrintDone));
                    }
                }
                else
                {
                    MessageBox.Show("Port not open.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Serial.Enabled = false;
                Jog.Enabled = false;

                if (File.Exists(textBoxLinkFile1.Text))
                {
                    using (StreamReader r = new StreamReader(textBoxLinkFile1.Text))
                    {
                        disableControlsForPrinting();
                        lines = new List<string>();
                        CurrentRow = Convert.ToInt32(tbLines.Text);
                        transfer = true;

                        string line;
                        while ((line = r.ReadLine()) != null)
                        {
                            if (line.Trim() != "")
                                lines.Add(line.Trim());
                        }
                        rowsInFileLbl.Text = "Rows: " + lines.Count.ToString();
                        sendNextLine();
                    }
                }
            }
            else
            {
                MessageBox.Show("No serial ports found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enableControlsForPrinting()
        {
            buttonStop.Enabled = false;
            buttonStart.Enabled = true;
            //BrowseBtn.Enabled = true;
            //textBoxLinkFile.Enabled = true;
        }

        private void disableControlsForPrinting()
        {
            buttonStart.Enabled = false;
            //BrowseBtn.Enabled = false;
            buttonStop.Enabled = true;
            //textBoxLinkFile.Enabled = false;
        }

        private void loadPortSelector()
        {
            List<String> tList = new List<String>();

            comboBoxCOM.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                tList.Add(s);
            }

            if (tList.Count < 1)
            {
                //MessageBox.Show("No serial ports found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tList.Sort();
                comboBoxCOM.Items.AddRange(tList.ToArray());
                comboBoxCOM.SelectedIndex = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadPortSelector();
        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            loadPortSelector();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                    serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Serial.Enabled = true;
            Jog.Enabled = true;

            transfer = false;
            enableControlsForPrinting();
            serialPort1.WriteLine("M5");
            serialResponseList.Items.Add("M5");
            serialResponseList.TopIndex = serialResponseList.Items.Count - 1;
            serialPort1.WriteLine("G0 X0 Y0");
            serialResponseList.Items.Add("G0 X0 Y0");
            serialResponseList.TopIndex = serialResponseList.Items.Count - 1;
        }

        private void serialResponseList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                Color C = Color.White;
                if (serialResponseList.Items[e.Index].ToString().Contains("error:"))
                    C = Color.LightPink;
                else if (serialResponseList.Items[e.Index].ToString().Contains("Grbl") || serialResponseList.Items[e.Index].ToString().Contains('$'))
                    C = Color.LightSkyBlue;

                e.DrawBackground();
                Graphics g = e.Graphics;

                // draw the background color you want
                g.FillRectangle(new SolidBrush(C), e.Bounds);

                // draw the text of the list item, not doing this will only show the background color
                g.DrawString(serialResponseList.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.Black), new PointF(e.Bounds.X, e.Bounds.Y));

                e.DrawFocusRectangle();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            serialResponseList.Items.Clear();
        }


        /// <summary>
        /// Jog pannel event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        float xPos = 0;
        float yPos = 0;
        private void textBoxSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // ASCII enter = 13(decimal)
            {
                if (!serialPort1.IsOpen) return;
                string send = "";
                send = "G1 F" + textBoxSpeed.Text + "\r\n";
                char[] buff = new char[send.Length];
                buff = send.ToCharArray();
                serialPort1.Write(buff, 0, buff.Count());
                serialResponseList.Items.Add(send);
                serialResponseList.TopIndex = serialResponseList.Items.Count - 1;
            }

        }

        private void buttonX0Y0_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            xPos = 0;
            yPos = 0;
            string send = "G1X0Y0" + "\r\n";
            char[] buff = new char[send.Length];
            buff = send.ToCharArray();
            serialPort1.Write(buff, 0, buff.Count());
            serialResponseList.Items.Add(send);
            serialResponseList.TopIndex = serialResponseList.Items.Count - 1;
        }

        private void buttonXin_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            xPos = (xPos + float.Parse(textBoxDistance.Text));
            string send = "G1X" + xPos.ToString() + "\r\n";
            char[] buff = new char[send.Length];
            buff = send.ToCharArray();
            serialPort1.Write(buff, 0, buff.Count());
            serialResponseList.Items.Add(send);
            serialResponseList.TopIndex = serialResponseList.Items.Count - 1;
        }

        private void buttonXde_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            xPos = (xPos - float.Parse(textBoxDistance.Text));
            string send = "G1X" + xPos.ToString() + "\r\n";
            char[] buff = new char[send.Length];
            buff = send.ToCharArray();
            serialPort1.Write(buff, 0, buff.Count());
            serialResponseList.Items.Add(send);
            serialResponseList.TopIndex = serialResponseList.Items.Count - 1;
        }

        private void buttonYin_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            yPos = (yPos + float.Parse(textBoxDistance.Text));
            string send = "G1Y" + yPos.ToString() + "\r\n";
            char[] buff = new char[send.Length];
            buff = send.ToCharArray();
            serialPort1.Write(buff, 0, buff.Count());
            serialResponseList.Items.Add(send);
            serialResponseList.TopIndex = serialResponseList.Items.Count - 1;
        }

        private void buttonYde_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            yPos = (yPos - float.Parse(textBoxDistance.Text));
            string send = "G1Y" + yPos.ToString() + "\r\n";
            char[] buff = new char[send.Length];
            buff = send.ToCharArray();
            serialPort1.Write(buff, 0, buff.Count());
            serialResponseList.Items.Add(send);
            serialResponseList.TopIndex = serialResponseList.Items.Count - 1;
        }

        private void buttonCheckBoard_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;

            xPos = float.Parse(textBoxMaxX.Text);
            string sendx = "G1X" + xPos.ToString() + "\r\n";
            char[] buffx = new char[sendx.Length];
            buffx = sendx.ToCharArray();
            serialPort1.Write(buffx, 0, buffx.Count());
            serialResponseList.Items.Add(sendx);
            serialResponseList.TopIndex = serialResponseList.Items.Count - 1;

            yPos = float.Parse(textBoxMaxY.Text);
            string sendy = "G1Y" + yPos.ToString() + "\r\n";
            char[] buffy = new char[sendy.Length];
            buffy = sendy.ToCharArray();
            serialPort1.Write(buffy, 0, buffy.Count());
            serialResponseList.Items.Add(sendy);
            serialResponseList.TopIndex = serialResponseList.Items.Count - 1;

            xPos = 0;
            sendx = "G1X0" + "\r\n";
            buffx = sendx.ToCharArray();
            serialPort1.Write(buffx, 0, buffx.Count());
            serialResponseList.Items.Add(sendx);
            serialResponseList.TopIndex = serialResponseList.Items.Count - 1;

            yPos = 0;
            sendy = "G1Y0" + "\r\n";
            buffy = sendy.ToCharArray();
            serialPort1.Write(buffy, 0, buffy.Count());
            serialResponseList.Items.Add(sendy);
            serialResponseList.TopIndex = serialResponseList.Items.Count - 1;
        }
    }
}
