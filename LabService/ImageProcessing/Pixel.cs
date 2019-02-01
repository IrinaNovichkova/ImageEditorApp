using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabService.ImageProcessing
{
    public struct Pixel
    {
        public Byte A { get;}
        public Byte R { get;}
        public Byte G { get;}
        public Byte B { get;}

        public Pixel(byte[] colorBytes)
        {
            B = colorBytes[0];
            G = colorBytes[1];
            R = colorBytes[2];
            A = colorBytes[3];
        }

        public Pixel(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
            A = 0;
        }

        public byte[] GetColorBytes()
        {
            return new [] {B, G, R, A};
        }
    }
}
