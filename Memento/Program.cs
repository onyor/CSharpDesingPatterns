using System;

namespace Memento
{
    //Kendisi Behavioral tasarım kalıpları gurubunda olan bir tasarım desenidir.
    /**
     * Memento tasarım kalıbı ile varlıkların initial stateleri yani o anki mevcut konumları saklanarak herhangi bir zaman dilimi 
     * içerisinde bir önceki hallerine döndürülmek istenen durumlarda kullanılır.
     */

    //Originator: Bu sınıf durumu tutulacak olan nesnemiz oluyor, eski veya yeni halini tutmamızı sağlayacak metotlar burada yer alacak.
    //Memento: Bu sınıf ise, asıl nesnemizin istediğimiz alanları tutan sınıftır.
    //Caretaker: Geri dönüş adımlarımızı Memento tipinden tutacak olan sınıftır.


    //Aşağıdaki senaryomuz bir oyun üzerinden ilerlesin. Oyunda bulunan Gezegenler oyunun belirli zamanlarında kaydedilen eski haline çevrilebilsin. 
    class Program
    {
        static void Main(string[] args)
        {
            GameWorld zulu = new GameWorld { Name = "Zulu", Population = 100000 };
            Console.WriteLine(zulu.ToString());

            GameWorldCareTaker taker = new GameWorldCareTaker();


            taker.add(zulu.Save()); //zulunun o anki halini sakla

            zulu.Population += 10;
            Console.WriteLine(zulu);

            taker.add(zulu.Save()); //zulunun o anki halini sakla

            zulu.Population += 10;
            Console.WriteLine(zulu);


            zulu.Undo(taker.lastVersionGet()); //eski dünyayi geri yükle
            Console.WriteLine(zulu);
            zulu.Undo(taker.lastVersionGet()); //eski dünyayi geri yükle
            Console.WriteLine(zulu);

            Console.ReadKey();
        }
    }
}
