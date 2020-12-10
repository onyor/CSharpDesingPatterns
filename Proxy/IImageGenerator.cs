using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    /**
     * Uygulamada IımageGenerator adındaki interface bizim real subjectimiz ve proxyi classımızın ortak bir dil konuşmasını sağlayacak,
     * yani bizim real subjectimiz de image generatorümüz de bu interface’i implemente edecektir.
     */
    interface IImageGenerator
    {
        void ShowImage();
    }
}
