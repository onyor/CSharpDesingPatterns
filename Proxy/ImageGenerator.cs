using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class ImageGenerator : IImageGenerator
    {
        private string _fullPath;

        public ImageGenerator(string fullPath)
        {
            _fullPath = fullPath;
        }
        public void ShowImage()
        {
            Console.WriteLine("{0} Resim Gösteriliyor..", _fullPath);
        }
    }
}
