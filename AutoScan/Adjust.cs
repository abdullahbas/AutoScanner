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

using System.IO;
using System.Windows.Forms;

namespace AutoScan
{
    public partial class Adjust : Form
    {
        public Adjust()
        {
            InitializeComponent();
        }

        private void Adjust_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
            textBox2.Text = "D:\\fat\\error\\";
            PopulateListBox(faultlist,"D:\\fat"+"\\error", "*.*");
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

        private void faultlist_MouseClick(object sender, MouseEventArgs e)
        {
            fault.ImageLocation = (textBox2.Text + faultlist.SelectedItem.ToString());
            cropIm.Image = crop(Image.FromFile(textBox2.Text+ faultlist.SelectedItem.ToString()));
        }
        public Image crop(Image im)
        {





            Rectangle cropRect = new Rectangle(800, 80, 300, 100);
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
        private void button1_Click(object sender, EventArgs e)
        {
            int x = faultlist.SelectedIndex;
            
            int count = 1;

            string fileNameOnly = Path.GetFileNameWithoutExtension(textBox2.Text + "\\" + textBox1.Text + ".jpg");
            string extension = Path.GetExtension(textBox2.Text + "\\" + textBox1.Text + ".jpg");
            string path = Path.GetDirectoryName(textBox2.Text + "\\" + textBox1.Text + ".jpg");
            string newFullPath = textBox2.Text + "\\" + textBox1.Text + ".jpg";

            while (File.Exists(newFullPath))
            {
                string tempFileName = string.Format("{0}({1})", fileNameOnly, count++);
                newFullPath = Path.Combine(path, tempFileName + extension);
            }



            fault.Image.Save(newFullPath);

            File.Delete(textBox2.Text  + faultlist.SelectedItem.ToString());
            faultlist.Items.Clear();
            PopulateListBox(faultlist, textBox2.Text , "*.*");
            faultlist.SelectedIndex = x ;
            textBox1.Text = "";
        }

        private void faultlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            fault.ImageLocation = (textBox2.Text  + faultlist.SelectedItem.ToString());
            cropIm.Image = crop(Image.FromFile(textBox2.Text + faultlist.SelectedItem.ToString()));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
               textBox2.Text = folderDlg.SelectedPath+"\\";
            }
            faultlist.Items.Clear();
            PopulateListBox(faultlist, textBox2.Text, "*.*");

        }
    }
}
