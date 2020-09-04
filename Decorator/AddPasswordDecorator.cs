using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /*
     * Hem IMail interface’ini implemente eden hem de Constructor parametresi olarak IMail interface’ini alan bir sınıf oluşturduk böylece. 
     * Bu mantıkla, bir dekoratör de başka bir dekoratör tarafından “süslenebilir” oldu.
     * İlk olarak GenelMail nesnesini şifrelemek istediğinizi düşünelim. Bu tasarıma göre, şifreleme gayet bir süs olabilir. 
     * O zaman bu işlem kesinlikle bir Dekoratör tarafından yapılabilir.
     */
    public class AddPasswordDecorator : Decorator
    {
        public AddPasswordDecorator(IMail mail) : base(mail)
        {

        }
        
        public override void Send()
        {
            base.Send();
            Console.WriteLine(" Şifrelendi  ");
        }
    }
}
