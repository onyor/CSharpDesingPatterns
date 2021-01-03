using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    /**
     * GameWorldMemento (Memento class): T anında save etmek istediğimiz nesnenin saklanacağı class ; 
     * hangi özellikleri saklamak istersek onlara uygun propertyler tanımlamamaız yeterli olacaktır.
     */

    class GameWorldMemento
    {
        public string Name { get; set; }
        public long Population { get; set; }
    }
}
