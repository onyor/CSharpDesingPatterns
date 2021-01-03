using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    /**
     * GameWorldCareTaker (Caretaker class): Memento classı güvenli bir şekilde saklar ama üyeleri üzerinde herhangi bir değişiklik yapmaz.
     */
    class GameWorldCareTaker
    {
        List<GameWorldMemento> gameWorldMementos;

        public GameWorldCareTaker()
        {
            this.gameWorldMementos = new List<GameWorldMemento>();
        }
        public void add(GameWorldMemento gameWorldMemento) {
            gameWorldMementos.Add(gameWorldMemento);
        }

        public GameWorldMemento lastVersionGet()
        {
            if (gameWorldMementos!=null)
            {
                GameWorldMemento lastVersion = gameWorldMementos[gameWorldMementos.Count-1];
                gameWorldMementos.Remove(lastVersion);

                return lastVersion;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Yüklü versiyon bulunamadı!");
            }
        }
    }
}
