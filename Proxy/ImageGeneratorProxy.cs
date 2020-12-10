using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    //Proxy
    class ImageGeneratorProxy : IImageGenerator
    {
        private ImageGenerator _generator;
        private string _fullPath;

        public ImageGeneratorProxy(string fullPath)
        {
            _fullPath = fullPath;
        }

        public void ShowImage()
        {
            if (_generator == null)
                _generator = new ImageGenerator(_fullPath);

            _generator.ShowImage();
        }
    }
}
