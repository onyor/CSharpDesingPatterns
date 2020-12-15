using System;
using System.Linq;

namespace Strategy
{
    class Program
    {
        /**
         * Bir fonksiyonun birden fazla yapılış şekli olduğu takdirde, 
         * bu fonksiyonelliği farklı versiyonlarıyla kullanmak istendiğinde kullanılabilecek bir design patternidir.
         */

        /**
         * Aynı işi farklı şekillerde yapan birden fazla concrete strategy classımız olduğunda bunları bir strategy class üzerinden clienta sunmak, 
         * strategy classına da bu concrete tiplere ait ortak ata olan interfaceyi vermek , ilerleyen zamanlarda bu concrete tiplere bir yenisi daha eklendiğinde , 
         * işimizi kolaylaştıracak, bu durumda tek yapmamız gereken bu concrete tipi ortak interfaceden türetmek yeterli olacaktır. 
         * Strategy tasarım kalıbının da yaptığı tam olarak budur.
         */
        static void Main(string[] args)
        {
            Context context = new Context(new OperationMultiply());
            Console.WriteLine(context.executeStrategy(5, 4));

            context = new Context(new OperationSubstract());
            Console.WriteLine(context.executeStrategy(5, 4));

            context = new Context(new OperationAdd());
            Console.WriteLine(context.executeStrategy(5, 4));
        }
    }
}
