using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class GeneralMail : IMail
    {
        private string kimden;
        private string kime;
        public GeneralMail(string kimden, string kime)
        {
            this.kimden = kimden;
            this.kime = kime;
        }
        public void Send()
        {
            Console.WriteLine("Mail, {0} kişisinden {1} kişine gidiyor.", kimden, kime);
        }
    }
}
