using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageGeneratorProxy proxy1 = new ImageGeneratorProxy("c:\\resim1.jpg");
            ImageGeneratorProxy proxy2 = new ImageGeneratorProxy("c:\\resim2.jpg");

            proxy1.ShowImage();
            proxy2.ShowImage();
            proxy1.ShowImage();

            Console.ReadKey();
        }
    }
}
