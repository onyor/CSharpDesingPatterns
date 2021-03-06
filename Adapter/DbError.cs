﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    //Aşağıda DbError adında bir classımız var ve bu class IErrordan türemiş vaziyette olup interfacesi implemente etmektedir.
    public class DbError : IError
    {
        private int _errorNumber;
        private string _description;

        public int ErrorNumber
        {
            get { return _errorNumber; }
            set { _errorNumber = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


        public void SendMail()
        {
            Console.WriteLine("{0} {1} -> Db Hatasi gönderildi", ErrorNumber.ToString(), Description);
        }
    }
}
