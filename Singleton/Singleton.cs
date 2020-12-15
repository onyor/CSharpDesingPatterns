using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Singleton
    {
        private static Singleton _instance;
        private static Guid _id; //nesnenin tek olduğunun ispati

        public Guid Id { get { return _id= Guid.NewGuid(); } }

        private Singleton(Guid id)
        { 
            
            _id = id;
        }
        //singleton sınıfına ait sınıfın çalışma zamanında constructordan yararlanarak oluşturulmamamasını sağlar
        private Singleton()
        {   

        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
                _instance = new Singleton();

            return _instance;
        }
    }
}
