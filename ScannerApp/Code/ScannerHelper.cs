using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIA;

namespace ScannerApp.Code
{
    public static class ScannerHelper
    {
        public static Task<List<string>> GetDevices()
        {
            List<string> devices = new List<string>();
            // Clear List
            devices.Clear();
            try
            {
                DeviceManager deviceManager = new DeviceManager();

                foreach (DeviceInfo deviceInfo in deviceManager.DeviceInfos)
                {
                    if (deviceInfo.Type == WiaDeviceType.ScannerDeviceType)
                    {
                        devices.Add((string)deviceInfo.Properties["Name"].get_Value());
                    }
                }
            }
            catch { }

            return Task.FromResult(devices);
        }


        public static async Task<Image> ScanAsImageAsync(string scannerName,int dpi,string paperSize,int colorMode)
        {
            try
            {
                return await Task.Run(() =>
                {

                    // Get Device
                    DeviceManager deviceManager = new DeviceManager();
                    DeviceInfo selectedDevice = null;
                    foreach (DeviceInfo deviceInfo in deviceManager.DeviceInfos)
                    {
                        if (deviceInfo.Type == WiaDeviceType.ScannerDeviceType
                        && (string)deviceInfo.Properties["Name"].get_Value() == scannerName)
                        {
                            selectedDevice = deviceInfo;
                            break;
                        }
                    }

                    if (selectedDevice == null)
                    {
                        throw new Exception("لا يوجد جهاز متصل");
                    }

                    // Connect to device
                    Device device = selectedDevice.Connect();
                    Item scannerItem = device.Items[1];

                    // Set Settings of Scanner
                    SetScannerSettings(scannerItem, dpi, colorMode, paperSize);

                    // Scan and Get Image
                    ImageFile imageFile = null;
                    try
                    {
                        imageFile = (ImageFile)scannerItem.Transfer(WIA.FormatID.wiaFormatJPEG);

                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }

                    // Convert ImageFile to Image

                    byte[] imageByte = (byte[])imageFile.FileData.get_BinaryData();
                    using (MemoryStream ma = new MemoryStream(imageByte))
                    {
                        return Image.FromStream(ma);
                    };

                });
            }
            catch { return null; }
        
        }

        private static void SetScannerSettings(Item scannerItem, int dpi, int colorMode, string paperSize)
        {
            try
            {
                const string WIA_HORIZONTAL_DPI = "6147";
                const string WIA_VERTICAL_DPI = "6148";
                const string WIA_HORIZONTAL_EXTENT = "6151";
                const string WIA_VERTICAL_EXTENT = "6152";
                const string WIA_COLOR_MODE = "6146";



                SetWIAProperty(scannerItem.Properties, WIA_HORIZONTAL_DPI, dpi);
                SetWIAProperty(scannerItem.Properties, WIA_VERTICAL_DPI, dpi);
                SetWIAProperty(scannerItem.Properties, WIA_COLOR_MODE, colorMode);

                int width = 0;
                int height = 0;
                switch (paperSize.ToUpper())
                {
                    case "A4":
                        width = (int)(8.27 * dpi);
                        height = (int)(11.69 * dpi);
                        break;
                    case "A5":
                        width = (int)(5.83 * dpi);
                        height = (int)(8.27 * dpi);
                        break;
                    case "Letter":
                        width = (int)(8.5 * dpi);
                        height = (int)(11 * dpi);
                        break;
                    default:
                        throw new Exception("حجم الورقة غير معروف.");
                }

                SetWIAProperty(scannerItem.Properties, WIA_HORIZONTAL_EXTENT, width);
                SetWIAProperty(scannerItem.Properties, WIA_VERTICAL_EXTENT, height);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
         

        }

        private static void SetWIAProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }
    }
}
