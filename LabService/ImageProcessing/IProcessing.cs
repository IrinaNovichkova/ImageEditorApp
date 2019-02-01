using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabService.ImageProcessing
{
    internal interface IProcessing
    {
        Bitmap Process(Bitmap image);
        Bitmap Example { get; }
    }
}
