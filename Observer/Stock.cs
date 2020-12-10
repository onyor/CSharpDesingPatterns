using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    //Subject: Takip etmek istediğimiz hisse stoku
    //Observable
    class Stock
    {
        public string Name { get; set; }
        //Değişikliklerden haberdar olacak kitle
        private List<IFinancer> _financiers;

        private decimal _lotValue;

        public decimal LotValue
        {
            get { return _lotValue; }
            set
            {
                _lotValue = value;
                Notify();
            }
        }

        private void Notify()
        {
            foreach (IFinancer financier in _financiers)
            {
                financier.Update(this);
            }
        }

        public Stock()
        {
            _financiers = new List<IFinancer>();
        }

        public void Subscribe(IFinancer financier)
        {
            _financiers.Add(financier);
        }


        public void Unsubscribe(IFinancer financier)
        {
            _financiers.Remove(financier);
        }

    }
}
