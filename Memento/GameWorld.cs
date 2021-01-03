using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{

    //GameWorld(Orginator class): Saklamak istediğimiz gerçek nesnemizin sınıfı
    class GameWorld
    {
        public string Name { get; set; }
        public long Population { get; set; }

        //Yeni bir gameworldmomento nesnesi örnekleyip ona orginator classına ait nesnenin ilgili özelliklerini atar.
        public GameWorldMemento Save()
        {
            return new GameWorldMemento { Name = this.Name, Population = this.Population }; //calisma zamanındaki özelllikleri alır.
        }

        //o anda gelen orginator nesnesinin ilgili özelliklerini set eder
        public void Undo(GameWorldMemento memento)
        {
            this.Name = memento.Name;
            this.Population = memento.Population;
        }

        public override string ToString()
        {
            return String.Format("{0} dünyasında {1} insan var", Name, Population);
        }
    }
}
