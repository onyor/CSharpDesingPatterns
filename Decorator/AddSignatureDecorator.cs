using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /*
     * Aynı biçimde, Mail nesnesine dijital imza eklemek de ekstra bir özellik olabilir. 
     * Bu arada ben, örneği basit tutmak için Decorator sınıflarındaki Send metodunda ekrana ekstra yazı yazdırdım sadece. 
     * Ama tabii ki daha karmaşık bir yapı da eklenebilir.
     */
    public class AddSignatureDecorator : Decorator
    {
        private string signature;
        public AddSignatureDecorator(IMail mail, string signature) : base(mail)
        {
            this.signature = signature;
        }
        public override void Send()
        {
            base.Send();
            Console.WriteLine(signature + " olarak imzalandı");
        }
    }
}
