using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class AlisverisSepetiEnumerator : IEnumerator
    {
        //Aşağıda GetEnumarator sınfının döneceği yapıyı implemente etmekteyiz.IEnumerator içerisinde 3 ana özellik bulundurur.

        //Current   : İterasyonda kalınan yer.
        //MoveNext : İterasyon sırasında bir sonraki adımın var olup olmadığı yani döngünün sona ulaşıp ulaşmadığı
        //Reset : iterasyonu başa alan yapı.

        //Bu classın nesnesini GetEnumerator return’e verdiğimizde foreachte her bir iterasyon indexi artığında önce MoveNext çalışacak , 
        //yapıda sona gelip gelmediğimizi kontrol edecek eğer sona gelmediysek arkasından Current çalışıp ihtiyacımız olan elemanı bize dönecek.

        private Urun[] _UrunList;
        int _curentIndex = -1;

        public AlisverisSepetiEnumerator(Urun[] urunList)
        {
            _UrunList = urunList;
        }

        //iterasyonda kalinan yer.
        public object Current
        {
            get { return _UrunList[_curentIndex]; }
        }

        //bir sonraki adım var mi kontrolü.
        public bool MoveNext()
        {
            return ++_curentIndex < _UrunList.Length;
        }

        //iterasyonu basa alir.
        public void Reset()
        {
            _curentIndex = -1;
        }
    }
}
