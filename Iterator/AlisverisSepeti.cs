using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    //Bir classın nesnesinin iteratif özellik kazanması ve foreach tarafından tanınması için IEnumerable interfacesini implemente etmesi gerekir.
    //IEnumerable interfacesi içerisinde sadece dönüş tipi IEnumerator interafacesini implemente eden sınıf nesnesi olan GetEnumetor metodunu bulundurur.
    //Bu metodu aşağıdaki gibi implemente ettikten sonra , 
    //metodun döneceği ve nesnenin foreachteki hareketlerini belirleyeceğimiz IEnumerator interfacesinden türeyen bir sınıf yazmamız gerekli.
    public class AlisverisSepeti : IEnumerable
    {

        public Urun[] UrunListesi { get; set; }

        public AlisverisSepeti()
        {
            UrunListesi = new Urun[]
           {
           new Urun(){ Name="Bilgisayar", Price=1022.3m},
           new Urun(){ Name="Ipad", Price=699.9m}
            };
        }

        public IEnumerator GetEnumerator()
        {
            return new AlisverisSepetiEnumerator(UrunListesi);
        }
    }
}
