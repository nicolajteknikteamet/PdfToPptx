using ShapeCrawler;
using SkiaSharp;
using Timer = System.Windows.Forms.Timer;

namespace PdfToPptx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Timer _timer = new Timer();
        private bool _isTimerEnabled = false;
        private bool _isProcessing = false;

        private string path1 = @"C:\Users\NicolajJohannessen\OneDrive - Teknikteamet\Skrivbordet\PdfTest";
        private string path2 = @"C:\Users\NicolajJohannessen\OneDrive - Teknikteamet\Skrivbordet\PdfExport";

        private void Form1_Load(object sender, EventArgs e)
        {
            //ConvertPresentation();
#if DEBUG
            txtWatchPath.Text = path1;
            txtExportWatchPath.Text = path2;
#endif
        }

        private void AddToLog(string message)
        {
            //invoke if invoke required
            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new Action(() => AddToLog(message)));
            }
            else
            {
                txtLog.AppendText(DateTime.Now.ToString("s") + ": " + message + Environment.NewLine);
            }

            //this.txtLog.AppendText(DateTime.Now.ToString("s") + ": " + message + Environment.NewLine);

        }

        private void StartCheckPdfTask()
        {
            if (_isProcessing)
                return;
            
            var task = new Task(CheckForPdfs);
            task.Start();
        }

        private async Task ConvertPresentation(string pdfPath, string exportPath)
        {
            var pdf = File.OpenRead(pdfPath);

            var pageCount = PDFtoImage.Conversion.GetPageCount(pdf, true);

            

            using var sourcePresentation = SCPresentation.Open("SourceTemplate.pptx");
            using var presentation = SCPresentation.Open("Blank.pptx");
            for (int i = 2; i <= pageCount; i++)
            {
                presentation.Slides.Add(sourcePresentation.Slides[0]);
            }


            for (int i = 0; i < pageCount; i++)
            {
                toolStripStatusConverter.Text = $"Converting page {i + 1} of {pageCount} in {Path.GetFileName(pdfPath)}";
                var image = PDFtoImage.Conversion.ToImage(pdfStream: pdf, true, null, i, 300, null, null, false, false);

                var firstSlide = presentation.Slides[i];
                var shape = firstSlide.Shapes.OfType<IPicture>().First();

                if (File.Exists("img.png"))
                    File.Delete("img.png");

                using (Stream imgFile = File.Open("img.png", FileMode.CreateNew))
                {
                    var d = image.Encode(SKEncodedImageFormat.Png, 100);
                    d.SaveTo(imgFile);
                }

                //firstSlide.Background.SetImage("img.jpg");

                shape.Image.SetImage("img.png");

                double proportionFactor = (double)shape.Height/(double)image.Height;
                int imageWidth = (int)(image.Width * proportionFactor);
                if (imageWidth < shape.Width)
                {
                    shape.Width = imageWidth;
                    shape.X = (presentation.SlideWidth / 2) - (imageWidth / 2);
                    
                }

                File.Delete("img.png");
            }

            var filePath = Path.Combine(exportPath, Path.GetFileNameWithoutExtension(pdfPath) + ".pptx");
            presentation.SaveAs(filePath);

            pdf.Close();
            pdf.Dispose();
            toolStripStatusConverter.Text = "";
        }

        private async void btnTransfer_Click(object sender, EventArgs e)
        {
            ConvertPresentation(txtPdfPath.Text, txtExportPath.Text);
        }

        private void btnBrowsePdfPath_Click(object sender, EventArgs e)
        {
            //show file dialog with pdf as filter, put result in txtPdfPath
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog initial directory set to documents
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFileDialog.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    txtPdfPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBrowseExportPath_Click(object sender, EventArgs e)
        {
            //show folder browser dialog, put result in txtExportPath
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                //folderBrowserDialog initial directory set to documents
                folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified folder
                    txtExportPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _timer.Interval = 10000;
            
            if (_isTimerEnabled)
            {
                AddToLog("Timer stopped");
                _timer.Tick -= _timer_Tick;
                _timer.Stop();
                _isTimerEnabled = false;
                btnStart.Text = "Start";
                grpSingleFile.Enabled = true;
                toolStripStatus.Text = "Last sync: Stopped";
            }
            else
            {
                AddToLog("Timer started");
                _timer.Tick += _timer_Tick;
                _timer.Start();
                _isTimerEnabled = true;
                btnStart.Text = "Stop";
                grpSingleFile.Enabled = false;
                StartCheckPdfTask();
            }


        }

        private void _timer_Tick(object? sender, EventArgs e)
        {
            StartCheckPdfTask();
        }

        private void CheckForPdfs()
        {
            try
            {
                if (_isProcessing)
                {
                    return;
                }
                _isProcessing = true;
                toolStripStatus.Text = "Last sync: " + DateTime.Now.ToString("s");

                var pdfs = Directory.GetFiles(txtWatchPath.Text, "*.pdf");
                foreach (var pdf in pdfs)
                {
                    if (!_isTimerEnabled) return;
                    
                    if (File.Exists(Path.Combine(txtExportWatchPath.Text, Path.GetFileNameWithoutExtension(pdf) + ".pptx")))
                    {
                        //AddToLog("File already exists");
                        continue;
                    }
                    AddToLog($"Found {Path.GetFileName(pdf)}");
                    ConvertPresentation(pdf, txtExportWatchPath.Text);
                    AddToLog($"Converted {Path.GetFileName(pdf)}");
                }
            }
            catch (Exception ex)
            {
                AddToLog(ex.Message);
            }
            finally
            {
                _isProcessing = false;
            }

        }


        private void btnBrowseWatchPath_Click(object sender, EventArgs e)
        {
            //show folder browser dialog, put result in txtWatchPath
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                //folderBrowserDialog initial directory set to documents
                folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified folder
                    txtWatchPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnBrowseExportWatchPath_Click(object sender, EventArgs e)
        {
            //show folder browser dialog, put result in txtExportWatchPath
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                //folderBrowserDialog initial directory set to documents
                folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified folder
                    txtExportWatchPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dropPanel_DragEnter(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (fileList.Length > 1 || !fileList[0].Contains(".pdf"))
            {
                e.Effect = DragDropEffects.None;
            }
            else
            {
                e.Effect = DragDropEffects.Copy;
            }
            
            //only allow pdf files for DragEnter
            //if (e.Data.GetDataPresent(DataFormats.FileDrop))
            //{
            //    txtPdfPath.Text = e.Data.GetData(DataFormats.FileDrop) as string;
            //}
        }

        private void dropPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            AddToLog("Exporting " + Path.GetFileName(fileList[0]));

            ConvertPresentation(fileList[0], Path.GetDirectoryName(fileList[0]));

            AddToLog("Presentation stored in same folder as PDF file");
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                txtPdfPath.Text = e.Data.GetData(DataFormats.FileDrop) as string;
            }
        }
    }
}