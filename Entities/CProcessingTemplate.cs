using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Entities
{
    public abstract class CProcessingTemplate
    {
        private readonly Bitmap _example;

        public Bitmap Process(Bitmap image)
        {
            throw new NotImplementedException();
        }
    }
}
