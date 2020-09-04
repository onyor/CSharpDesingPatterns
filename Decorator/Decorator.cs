using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /* 
     * Burası önemli bir nokta… GenelMail nesnesi üzerine, şu an planlama şansımızın olmadığı başka işlemler de ekleyebiliriz öyle değil mi? 
     * Başka işlemleri ekleyebilecek her sınıfa Decorator ismini verelim. 
     * Tüm Decorator'ler çekirdek nesnemizi (genelMail) alır ve üzerine yeni bir işlev (süs) ekler. 
     * Aynı zamanda tüm Decorator'ler, dekore ettikleri nesnenin ortak metotlarını içermeliler.
     */
    public abstract class Decorator : IMail
    {
        private IMail mail;
        public Decorator(IMail mail)
        {
            this.mail = mail;
        }
        public virtual void Send()
        {
            mail.Send();
        }
    }
}
