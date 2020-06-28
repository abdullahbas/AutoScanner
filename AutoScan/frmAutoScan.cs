using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WIA;
using System.IO;
using System.Threading;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using Tesseract;

namespace AutoScan
{
    public partial class frmAutoScan : Form
    {
        public frmAutoScan()
        {
            InitializeComponent();
        }


        int newDoc = 0;
        int cmbCMIndex = 0;
        Stopwatch sw = new Stopwatch();

        private void btnStartScan_Click(object sender, EventArgs e)
        {
            bgwScan.RunWorkerAsync(50000);
            btnStartScan.Enabled = false;
            btnStopScan.Enabled = true;
            cmbColorMode.Enabled = false;
            nudWidthInch.Enabled = false;
            nudHeightInch.Enabled = false;
            nudRes.Enabled = false;
            cbxCustomPixel.Enabled = false;
            nudHeight.Enabled = false;
            nudWidth.Enabled = false;

            cmbCMIndex = cmbColorMode.SelectedIndex;
        }



        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPath.Text = folderDlg.SelectedPath;
            }
        }

        private void frmAutoScan_Load(object sender, EventArgs e)
        {
          ///picScan.ImageLocation = "C:\\Users\\trabz\\Desktop\\AutoScan\\a.tiff";
            Control.CheckForIllegalCrossThreadCalls = false;
            txtPath.Text = "D:\\fat";
            nudHeightInch.Value = 4;
            nudWidthInch.Value = 4;
            nudWidth.Value = 1100;
            nudHeight.Value = 1500;
            cmbColorMode.SelectedIndex = 2;
        }
        public static string s;

        private void bgwScan_DoWork(object sender, DoWorkEventArgs e)
        {
            int ii = 1;
            while (!bgwScan.CancellationPending)
            {




                if (newDoc == 0)
                {
                    try
                    {
                        newDoc = 1;


                        ScanDoc();

                    }


                    catch 

                    {

                        MessageBox.Show("Cihaz Bağlantısını Kontrol Edin \n veya \n Besleyiciyi Kontrol Edin", "Makine Kullanılamıyor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        bgwScan.CancelAsync();
                        return;
                    }



                }

                for (int k = 1; k <= 10 * (int)nudTime.Value; k++)
                {

                    Thread.Sleep(100);

                    bgwScan.ReportProgress((int)(k / (int)nudTime.Value));
                    if (k == 10 * (int)nudTime.Value)
                        newDoc = 0;
                }

               
                    string path1 = "";
                try
                {
                    Image img = crop(picScan.Image);
                    cropIm.Image = img;
                    s = ocr(cropIm.Image);
                    path1 = strRe(s);
                    int x = int.Parse(path1);
                    textBox1.Text = x.ToString();

                    int count = 1;

                    string fileNameOnly = Path.GetFileNameWithoutExtension(txtPath.Text + "\\" + x.ToString() + ".jpg");
                    string extension = Path.GetExtension(txtPath.Text + "\\" + x.ToString() + ".jpg");
                    string path = Path.GetDirectoryName(txtPath.Text + "\\" + x.ToString() + ".jpg");
                    string newFullPath = txtPath.Text + "\\" + x.ToString() + ".jpg";

                    while (File.Exists(newFullPath))
                    {
                        string tempFileName = string.Format("{0}({1})", fileNameOnly, count++);
                        newFullPath = Path.Combine(path, tempFileName + extension);
                    }




                    picScan.Image.Save(newFullPath);
                    fatList.Items.Add(x.ToString());

                    label10.Text = "(" + fatList.Items.Count.ToString() + ")";

                }

                                    catch
                    {

                        Image img = crop(picScan.Image);


                    string fileName = "";
                    var files = Directory.GetFiles(txtPath.Text +"\\error\\", "*.jpg");


                    try
                    {
                        string f = ((files.Max(p1 => Int32.Parse(Path.GetFileNameWithoutExtension(p1)))) + 1).ToString();
                        fileName = txtPath.Text + "\\error\\"  + f + ".jpg";
                    }
                    catch 
                    {
                        fileName = txtPath.Text + "\\error\\" + "1.jpg";
                    }


                    picScan.Image.Save(fileName);
                        erFat.Items.Add(path1);

                        ii++;
                    label11.Text = "("+erFat.Items.Count.ToString()+")";


                }

    







            }

        }





        private void btnStopScan_Click(object sender, EventArgs e)
        {
            bgwScan.CancelAsync();
            btnStartScan.Enabled = true;
            btnStopScan.Enabled = false;
            cmbColorMode.Enabled = true;

            //
            btnStartScan.Enabled = true;
            btnStopScan.Enabled = false;
            cmbColorMode.Enabled = true;
            nudWidthInch.Enabled = true;
            nudHeightInch.Enabled = true;
            nudRes.Enabled = true;
            cbxCustomPixel.Enabled = true;
            if (cbxCustomPixel.Checked == true)
            {
                nudHeight.Enabled = true;
                nudWidth.Enabled = true;
            }


            sw.Reset();
            sw.Stop();
        }

        private void bgwScan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            {
                if (e.Cancelled) MessageBox.Show("Operation was canceled");
                else if (e.Error != null) MessageBox.Show(e.Error.Message);
                //else MessageBox.Show("Processing");
            }
        }

        private void bgwScan_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbWaiting.Value = (int)e.ProgressPercentage * 10;
            sw.Start();
            txtWT.Text = (int)nudTime.Value - (int)(sw.ElapsedMilliseconds / 1000)+ " Sn. Kaldı";

            if (pbWaiting.Value == 100)
            {
                pbWaiting.Value = 0;
                txtWT.Text = "İşleniyor";
                sw.Reset();
                sw.Stop();
            }
        }


        private static void AdjustScannerSettings(IItem scannnerItem, int scanResolutionDPI, int scanStartLeftPixel, int scanStartTopPixel,
                    int scanWidthPixels, int scanHeightPixels, int brightnessPercents, int contrastPercents, int colorMode)
        {
            const string WIA_SCAN_COLOR_MODE = "6146";
            const string WIA_HORIZONTAL_SCAN_RESOLUTION_DPI = "6147";
            const string WIA_VERTICAL_SCAN_RESOLUTION_DPI = "6148";
            const string WIA_HORIZONTAL_SCAN_START_PIXEL = "6149";
            const string WIA_VERTICAL_SCAN_START_PIXEL = "6150";
            const string WIA_HORIZONTAL_SCAN_SIZE_PIXELS = "6151";
            const string WIA_VERTICAL_SCAN_SIZE_PIXELS = "6152";
            const string WIA_SCAN_BRIGHTNESS_PERCENTS = "6154";
            const string WIA_SCAN_CONTRAST_PERCENTS = "6155";
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_START_PIXEL, scanStartLeftPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_START_PIXEL, scanStartTopPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_SIZE_PIXELS, scanWidthPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_SIZE_PIXELS, scanHeightPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_BRIGHTNESS_PERCENTS, brightnessPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_CONTRAST_PERCENTS, contrastPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_COLOR_MODE, colorMode);
            

        }

        private static void SetWIAProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }

        private static void SaveImageToTiff(ImageFile image, string fileName)
        {
            ImageProcess imgProcess = new ImageProcess();
            object convertFilter = "Convert";
            string convertFilterID = imgProcess.FilterInfos.get_Item(ref convertFilter).FilterID;
            imgProcess.Filters.Add(convertFilterID, 0);
            SetWIAProperty(imgProcess.Filters[imgProcess.Filters.Count].Properties, "FormatID", WIA.FormatID.wiaFormatPNG);
            image = imgProcess.Apply(image);
            image.SaveFile(fileName);
        }
        private void ScanDoc()
        {
            
                CommonDialogClass commonDialogClass = new CommonDialogClass();
                Device scannerDevice = commonDialogClass.ShowSelectDevice(WiaDeviceType.ScannerDeviceType, false, false);
                if (scannerDevice != null)
                {

                    Item scannnerItem = scannerDevice.Items[1];
                    SelectDeviceDocumentHandling(scannerDevice, DeviceDocumentHandling.Feeder);
                AdjustScannerSettings(scannnerItem, (int)nudRes.Value, 0, 0, (int)nudWidth.Value, (int)nudHeight.Value, 30, -50, cmbColorMode.SelectedIndex);
                    object scanResult = commonDialogClass.ShowTransfer(scannnerItem, WIA.FormatID.wiaFormatTIFF, false);
                    //picScan.Image = (System.Drawing.Image)scanResult;
                    if (scanResult != null)
                    {
                        ImageFile image = (ImageFile)scanResult;

                        string fileName = "";

                        var files = Directory.GetFiles(txtPath.Text+"\\temp\\", "*.jpg");


                        try
                        {
                            string f = ((files.Max(p1 => Int32.Parse(Path.GetFileNameWithoutExtension(p1)))) + 1).ToString();
                            fileName = txtPath.Text + "\\temp\\" + f + ".jpg";
                        }
                        catch 
                        {
                            fileName = txtPath.Text + "\\temp\\" + "1.jpg";
                        }

                        SaveImageToTiff(image, fileName);
                        picScan.ImageLocation = fileName;





                    }


                }
            







        }

        private void nudWidthInch_ValueChanged(object sender, EventArgs e)
        {
            nudWidth.Value = nudRes.Value * nudWidthInch.Value;
        }

        private void nudHeightInch_ValueChanged(object sender, EventArgs e)
        {
            nudHeight.Value = nudRes.Value * nudHeightInch.Value;
        }

        private void nudRes_ValueChanged(object sender, EventArgs e)
        {
            nudWidth.Value = nudRes.Value * nudWidthInch.Value;

            nudHeight.Value = nudRes.Value * nudHeightInch.Value;
        }

        private void cbxCustomPixel_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCustomPixel.Checked == true)
            {
                nudWidth.ReadOnly = false;
                nudHeight.ReadOnly = false;
            }
            else
            {
                nudWidth.ReadOnly = true;
                nudHeight.ReadOnly = true;
            }
        }







        public enum DeviceDocumentHandling : int
        {
            Feeder = 1,
            FlatBed = 2
        }
        public static Property FindProperty(WIA.Properties properties,
                                           int propertyId)
        {
            foreach (Property property in properties)
                if (property.PropertyID == propertyId)
                    return property;
            return null;
        }
        public static void SetDeviceProperty(Device device, int propertyId,
                                            object value)
        {
            Property property = FindProperty(device.Properties, propertyId);
            if (property != null)
                property.set_Value(value);
        }
        public static object GetDeviceProperty(Device device, int propertyId)
        {
            Property property = FindProperty(device.Properties, propertyId);
            return property != null ? property.get_Value() : null;
        }

        public static void SelectDeviceDocumentHandling(Device device,
                                    DeviceDocumentHandling handling)
        {
            int requested = (int)handling;
            int supported = (int)GetDeviceProperty(device,
                     DEVICE_PROPERTY_DOCUMENT_HANDLING_CAPABILITIES_ID);
            if ((requested & supported) != 0)
            {
                if ((requested & (int)DeviceDocumentHandling.Feeder) != 0)
                    SetDeviceProperty(device, DEVICE_PROPERTY_PAGES_ID, 1);
                SetDeviceProperty(device,
                       DEVICE_PROPERTY_DOCUMENT_HANDLING_SELECT_ID, requested);
            }
        }
        const int DEVICE_PROPERTY_DOCUMENT_HANDLING_CAPABILITIES_ID = 3086;
        const int DEVICE_PROPERTY_DOCUMENT_HANDLING_STATUS_ID = 3087;
        const int DEVICE_PROPERTY_DOCUMENT_HANDLING_SELECT_ID = 3088;
        const int DEVICE_PROPERTY_PAGES_ID = 3096;

        public string  ocr (Image im)
        {
            string path = Directory.GetCurrentDirectory();

            var ocr = new TesseractEngine(path+"\\tessdata", "eng", EngineMode.TesseractAndCube);
            
            var page = ocr.Process(im as Bitmap);
            textBox1.Text = page.GetText();
            return page.GetText();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = fatList.SelectedIndex;

            int count = 1;

            string fileNameOnly = Path.GetFileNameWithoutExtension(txtPath.Text + "\\" + textBox1.Text + ".jpg");
            string extension = Path.GetExtension(txtPath.Text + "\\" + textBox1.Text + ".jpg");
            string path = Path.GetDirectoryName(txtPath.Text + "\\" + textBox1.Text + ".jpg");
            string newFullPath = txtPath.Text + "\\" + textBox1.Text + ".jpg";

            while (File.Exists(newFullPath))
            {
                string tempFileName = string.Format("{0}({1})", fileNameOnly, count++);
                newFullPath = Path.Combine(path, tempFileName + extension);
            }



            picScan.Image.Save(newFullPath);

            File.Delete(txtPath.Text + fatList.SelectedItem.ToString());
            fatList.Items.Clear();
            PopulateListBox(fatList, txtPath.Text, "*.*");
            fatList.SelectedIndex = x;
            textBox1.Text = "";
        }
        private void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
        }
        public  Image crop(Image im)
        {


  


                Rectangle cropRect = new Rectangle(800, 60, 250, 70);
                Bitmap src = im as Bitmap;
                Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);
                cropIm.Image = target;
            try
            {
                using (Graphics g = Graphics.FromImage(target))
                {
                    g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height),
                                     cropRect,
                                     GraphicsUnit.Pixel);
                }

            }
            catch
            {

            }
                return target;
            
            
        }


        // Bağlantı metnini küçük harfe çevir.
        public string strRe(string str)
        { 
         string BaglantiMetni = str.ToLower();


            // Burada bağlantı metinlerindeki geçersiz karakterleri bir diziye aktarıyoruz.


            string[] GecersizKarakterler = {"f","l","k","j","s","¨","+",",","'",
"é",">","'","<","~",";","p","o","ı","u","y","t","p","o","v","r","e","%","!",
"'","^",",","|","*","w","q","_" ,"d","c","b","a","-","£","n","?","ğ", "ü", "ş",
 "ç", "ö", "ı",":", "_", ".", "-", " ", "!", "'", "^", "#", "+", "$", "%", "&", "/", "{", "(", "[", "]", ")", "=", "}", "?" };

            
            // Burada da geçerli olan karakterleri atıyoruz.




            // Bu iki dizide dikkat etmeniz gereken yer;


            // İlk dizideki 0. karakterin karşılığı ikinci dizide 0. eleman olucak şekilde ayarlanmıştır.


            // Yani geçersiz karakterin karşılığının mutlaka ikinci dizide geçerli karakter olarak bulunması gerekiyor.





            // Burada eğer bütün karakterler eşit ise metnimizi düzenliyoruz.


            


            


                // Döngümüz ile dizideki karakter sayısı kadar dönüp bütün karakterleri bağlantı metninde arıyoruz.


                for (int i = 0; i<GecersizKarakterler.Length; i++)


                {


                    // ve bulunan geçersiz karakteri yenisi ile değiştiriyoruz.


                    BaglantiMetni = BaglantiMetni.Replace(GecersizKarakterler[i], "");


                }





            // else { Karakter sayıları eşit değil; }


            // Yeni bağlantı metnimizi geri gönderiyoruz.


            return BaglantiMetni;


        }

        private void frmAutoScan_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                System.IO.DirectoryInfo di = new DirectoryInfo(txtPath.Text + "\\temp\\");

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
            catch
            {

            }
        }
        private void picScan_Click(object sender, EventArgs e)
        {
            
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
                        MessageBox.Show(coordinates.ToString());
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            picScan.ImageLocation = "D:\\fat\\70221.jpg";
        }

        private void fatList_MouseClick(object sender, MouseEventArgs e)
        {
            
            try
            {  try
                {
                    cropIm.Image = crop(Image.FromFile((txtPath.Text + "\\" + fatList.SelectedItem.ToString()) + ".jpg"));
                    picScan.ImageLocation = (txtPath.Text + "\\" + fatList.SelectedItem.ToString()) + ".jpg";
                }
               catch
                {
                    try
                    {
                        cropIm.Image = crop(Image.FromFile((txtPath.Text + "\\" + fatList.SelectedItem.ToString()) + ".png"));
                        picScan.ImageLocation = (txtPath.Text + "\\" + fatList.SelectedItem.ToString()) + ".png";
                    }
                    catch
                    {
                        cropIm.Image = crop(Image.FromFile((txtPath.Text + "\\" + fatList.SelectedItem.ToString()) + ".tiff"));
                        picScan.ImageLocation = (txtPath.Text + "\\" + fatList.SelectedItem.ToString()) + ".tiff";
                    }

                }
            }
            catch
            {
                cropIm.Image = null;
            }
        }
        public static string apo23;
        private void adjust_Click(object sender, EventArgs e)
        {
            Form frm = new Adjust();
            frm.Show(erFat);
            apo23 = txtPath.Text;
    
        }

        private void fatList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    cropIm.Image = crop(Image.FromFile((txtPath.Text + "\\" + fatList.SelectedItem.ToString()) + ".jpg"));
                    picScan.ImageLocation = (txtPath.Text + "\\" + fatList.SelectedItem.ToString()) + ".jpg";
                }
                catch
                {
                    try
                    {
                        cropIm.Image = crop(Image.FromFile((txtPath.Text + "\\" + fatList.SelectedItem.ToString()) + ".png"));
                        picScan.ImageLocation = (txtPath.Text + "\\" + fatList.SelectedItem.ToString()) + ".png";
                    }
                    catch
                    {
                        cropIm.Image = crop(Image.FromFile((txtPath.Text + "\\" + fatList.SelectedItem.ToString()) + ".tiff"));
                        picScan.ImageLocation = (txtPath.Text + "\\" + fatList.SelectedItem.ToString()) + ".tiff";
                    }

                }
            }
            catch
            {
                cropIm.Image = null;
            }
        }
    }
}
