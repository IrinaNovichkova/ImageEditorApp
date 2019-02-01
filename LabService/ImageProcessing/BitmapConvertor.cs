using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LabService.ImageProcessing
{
    public static class SBitmapConvertor
    {
        public static List<Pixel> GetPixelListFromBitmap(Bitmap image)
        {
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            Byte[] imageBuffer = new Byte[imageData.Stride * imageData.Height];
            Marshal.Copy(imageData.Scan0, imageBuffer, 0, imageBuffer.Length);
            image.UnlockBits(imageData);

            List<Pixel> pixelList = new List<Pixel>(imageBuffer.Length / 4);

            using (MemoryStream memoryStream = new MemoryStream(imageBuffer))
            {
                memoryStream.Position = 0;
                using (BinaryReader binaryReader = new BinaryReader(memoryStream))
                {
                    while (memoryStream.Position + 4 <= memoryStream.Length)
                    {
                        Pixel pixel = new Pixel(binaryReader.ReadBytes(4));
                        pixelList.Add(pixel);
                    }
                }
            }
            return pixelList;
        }

        public static Bitmap GetBitmapFromPixelList(List<Pixel> pixels, int width, int height)
        {
            Bitmap result = new Bitmap(width, height, PixelFormat.Format32bppArgb);

            BitmapData resultData = result.LockBits(new Rectangle(0, 0, result.Width, result.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            Byte[] resultBuffer = new byte[resultData.Stride * resultData.Height];

            using (MemoryStream memoryStream = new MemoryStream(resultBuffer))
            {
                memoryStream.Position = 0;
                using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
                {
                    pixels.ForEach(x => binaryWriter.Write(x.GetColorBytes()));
                }
            }

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            result.UnlockBits(resultData);

            return result;
        }
    }
}
