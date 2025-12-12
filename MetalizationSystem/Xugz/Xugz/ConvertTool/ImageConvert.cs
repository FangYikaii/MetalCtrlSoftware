using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;


namespace Xugz
{
    public class ImageConvert
    {     
        public string Convert(string fileinpath, string fileoutpath, Format format, int width = 64, int height = 64)
        {
            try
            {
                Bitmap bitmap = new Bitmap(fileinpath);
                if (width > 0 & height > 0) bitmap = new Bitmap(bitmap, width, height);
                switch (format)
                {
                    case Format.JPG: bitmap.Save(fileoutpath, ImageFormat.Jpeg); break;
                    case Format.JPEG: bitmap.Save(fileoutpath, ImageFormat.Jpeg); break;
                    case Format.BMP: bitmap.Save(fileoutpath, ImageFormat.Bmp); break;
                    case Format.PNG: bitmap.Save(fileoutpath, ImageFormat.Png); break;
                    case Format.EMF: bitmap.Save(fileoutpath, ImageFormat.Emf); break;
                    case Format.GIF: bitmap.Save(fileoutpath, ImageFormat.Gif); break;
                    case Format.WMF: bitmap.Save(fileoutpath, ImageFormat.Wmf); break;
                    case Format.EXIF: bitmap.Save(fileoutpath, ImageFormat.Exif); break;
                    case Format.TIFF:
                        {
                            Stream stream = File.Create(fileoutpath);
                            bitmap.Save(stream, ImageFormat.Tiff);
                            stream.Close();
                        }
                        break;
                    case Format.ICO:
                        {
                            Stream stream = File.Create(fileoutpath);
                            using (Icon icon = Icon.FromHandle(bitmap.GetHicon()))
                            {
                                // 保存图标到文件
                                icon.Save(stream);
                                stream.Close();
                            }
                        }; break;
                    default: return "Error!";
                }
                return "Success!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public enum Format
        {
            JPG,
            JPEG,
            BMP,
            PNG,
            EMF,
            GIF,
            WMF,
            EXIF,
            TIFF,
            ICO
        }
    }
}
