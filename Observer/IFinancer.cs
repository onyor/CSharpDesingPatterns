using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface IFinancer
    {
        void Update(Stock stock);
    }
}
