using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    //Observer : Gözlemcilerimiz
    interface IFinancer
    {
        void Update(Stock stock);
    }
}
