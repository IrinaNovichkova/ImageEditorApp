using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabService.ImageProcessing
{
    class BlackWhileFilter : IProcessing
    {
        public Bitmap Process(Bitmap image)
        {
            //TODO Логику доставания пикселей и обратно - отдельно?
            List<Pixel> pixels = SBitmapConvertor.GetPixelListFromBitmap(image);
            List<Pixel> transformedPixels = ApplyFilter(pixels);
            return SBitmapConvertor.GetBitmapFromPixelList(transformedPixels, image.Width, image.Height);
        }

        public Bitmap Example { get; }

        private List<Pixel> ApplyFilter(List<Pixel> pixels)
        {
            return pixels
                .Select(x => 0.21 * x.R + 0.72 * x.G + 0.07 * x.B)
                .Select(x => x > 127 ? new Pixel(255, 255, 255) : new Pixel(0, 0, 0)).ToList();
        }
    }
}
