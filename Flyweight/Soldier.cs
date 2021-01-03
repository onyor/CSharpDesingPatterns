using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    // FlyWeight Class
    abstract class Soldier
    {

        #region Intrinsic Fields

        // Bütün FlyWeight nesne örnekleri tarafından ortak olan ve paylaşılan veriler
        protected string UnitName;
        protected string Guns;
        protected string Health;

        #endregion


        #region Extrinsic Fields

        // İstemci tarafından değerlendirilip hesaplanan ve MoveTo operasyonua gönderilerek FlyWeight nesne örnekleri tarafından değerlendirilen veriler
        protected int X;
        protected int Y;

        #endregion


        public abstract void MoveTo(int x, int y);
    }
}
