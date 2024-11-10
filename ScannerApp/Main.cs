using ScannerApp.Code;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace ScannerApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private async void Main_Load(object sender, EventArgs e)
        {
            await LoadDevices();
            textBoxSavedFolder.Text = Properties.Settings.Default.LocationPath;
            comboBoxPaperSize.SelectedIndex = 0;

            if (Properties.Settings.Default.LocationPath == string.Empty)
            {
                MessageBox.Show("ﬁ„ »«Œ Ì«— „”«— «·Õ›Ÿ «·„·›«  «·„„”ÊÕ… «Ê·« !",
               "«Œ Ì«— „”«— «·Õ›Ÿ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1
               , MessageBoxOptions.RightAlign);
                SelectFolderPath();
            }


        }


        private async void linkLabelLoadDevices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await LoadDevices();
        }

        private async Task LoadDevices()
        {
            //Load Devices
            pictureBoxLoading.Visible = true;
            comboBoxDevices.DataSource = await ScannerHelper.GetDevices();
            pictureBoxLoading.Visible = false;
        }

        private void linkLabelChangeSavedFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            SelectFolderPath();
        }

        private void linkLabelOpenSavedFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Properties.Settings.Default.LocationPath,
                UseShellExecute = true,
            };

            Process.Start(psi);
        }

        private void SelectFolderPath()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            dialog.UseDescriptionForTitle = true;
            dialog.Description = "«Œ Ì«— „Ã·œ «·Õ›Ÿ";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.LocationPath = dialog.SelectedPath;
                Properties.Settings.Default.Save();
                textBoxSavedFolder.Text = Properties.Settings.Default.LocationPath;
            }
        }

        private async void buttonScan_Click(object sender, EventArgs e)
        {
            // Check Devices
            if (comboBoxDevices.Items.Count == 0)
            {
                MessageBox.Show("ﬁ„ »«Œ Ì«— ÃÂ«“ ··›Õ’ «Ê·« !",
             "«Œ Ì«—  ÃÂ«“", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1
             , MessageBoxOptions.RightAlign);
            }
            else
            {
                string deviceName = comboBoxDevices.SelectedItem.ToString();
                int dpi = Convert.ToInt32(comboBoxDpi.Text);
                string paperSize = comboBoxPaperSize.SelectedItem.ToString();

                // Set Color Mode
                int color = 0;
                if (radioButtonColor.Checked)
                {
                    color = 1;
                }
                if (radioButtonGray.Checked)
                {
                    color = 2;
                }

                pictureBoxLoading.Show();



                // Scanning : Start

                for (int i = 1; i <= numericUpDownScannerPaperCont.Value; i++)
                {
                    pictureBoxShow.Image = Properties.Resources.scaning;

                    var scannedImage = await ScannerHelper.ScanAsImageAsync(deviceName, dpi, paperSize, color);
                    if (scannedImage != null)
                    {
                        pictureBoxShow.Image = scannedImage;
                        SaveImage(scannedImage, textBoxSavedFolder.Text);
                    }
                  

                    await Task.Delay(1000);
                }

                numericUpDownScannerPaperCont.Value = 1;

                // End

                pictureBoxLoading.Hide();

            }


        }

        private void SaveImage(Image image, string path)
        {
            try
            {
                string fileName = Path.Combine(path, $"{Guid.NewGuid()}.jpg");
                using (var Imagefile = new Bitmap(image))
                {
                    Imagefile.Save(fileName, ImageFormat.Jpeg);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

      
        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            dialog.Description = "«Œ — „Ã·œ Õ›Ÿ «·’Ê—…";
            var resutl= dialog.ShowDialog();
            if(resutl == DialogResult.OK)
            {
                SaveImage(pictureBoxShow.Image,dialog.SelectedPath);
                MessageBox.Show(" „ Õ›Ÿ «·’Ê—… »‰Ã«Õ");
            }
        }
    }
}
