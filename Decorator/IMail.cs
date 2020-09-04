using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /*
     * Geliştireceğimiz örneğin senaryosunu ele alalım önce. Uygulamamız, eposta gönderebilen bir modüle sahip olsun. 
     * Epostanın standart yapısının üzerine, içerik şifrelenmesi veya imza eklenmesi gibi ekstra operasyonlar (süsler) eklenebilsin istiyoruz. 
     * Tüm bu ekstra fonksiyonlar eklendikten sonra bile, göndereceğiniz nesne hala bir eposta nesnesi değil mi? Tıpkı kahve örneğindeki gibi yani.
     * O zaman, tüm mail süsleyicilerinde ortak olarak bulunan metodun Gonder() metodu olduğunu söyleyebiliriz. 
     * O halde bu ve bunun gibi metotları, bir interface altında toplayarak işe başlayabiliriz bence!
     */
    public interface IMail
    {
        void Send();
    }
}
