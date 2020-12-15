using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Factory
    {
        private DatabaseFactory _databaseFactory;
        private Connection _connection;
        private Command _command;

        public Factory(DatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _connection = databaseFactory.CreateConnection();
            _command = _databaseFactory.CreateCommand();
        }

        public void Start()
        {
            _connection.Connect();

            if (_connection.State == "Baglanti Durumu")
                _command.Execute("select ...");

        }
    }
}
