using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    //IError adında bir interfacesimiz var ve bu interface kendinden türeyen classlar için bir grup oluşturacak.
    interface IError
    {
        int ErrorNumber { get; set; }
        string Description { get; set; }
        void SendMail();
    }
}
