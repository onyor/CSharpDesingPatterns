using System;

namespace State
{
    class Program
    {
        /**
         * State design patterni, nesnenin iç durumundaki değişikliklere göre çalışma zamanında farklı davranışlar sergilemesini sağlayan tasarım kalıbıdır. 
         * Yani biraz daha açarsak nesne belli özelliklerindeki değişimlere göre farklı davranışlar, fonksiyonellikler sergilemesi gibi düşünebiliriz. 
         */
        /*
         * Gündelik hayattan bir örnek ile devam edelim.Bir kredi kartınız olduğunu varsayalım ve bu kredi kartının durumlarına göre 
         * yani yazılım tarafından bakarsak iç özelliklerindeki değişimlere göre bankanız sizin hesabınızda değişiklikler yapıyor ve hesabınız 
         * farklı fonksiyonellikler sergiliyor.

            –  Kredi kartını yeni açtırdıysanız banka size standart bir tarife sunuyor(Standart faizler, standart kredi çekebilme limitleri vs).

            –  Kredi kartınızda çok fazla borç birikti ve ödeyemiyorsanız hesabı kara listeye çevirip size kredi vermiyor belki de faizlerinizi artırıyor.

            –  Eğer borçlarınızı düzenli ödüyorsanız da bir takım teşviklerin olduğu, rahatlıkla kredi alabildiğiniz bir premium hesaba çeviriyor.

            Yani kredi kartınızın bakiye-borç değerindeki değişimlere göre bankanız dinamik olarak sizin hesabınızı farklı davranışlara 
         yani durumlara(state’lere)  sokabiliyor.
         */
        static void Main(string[] args)
        {
            Account account = new Account();
            account.WithdrawMoney();
            account.PayInterest();

            account.ChangeStatus();

            account.WithdrawMoney();
            account.PayInterest();

            Console.ReadKey();
        }
    }
}
