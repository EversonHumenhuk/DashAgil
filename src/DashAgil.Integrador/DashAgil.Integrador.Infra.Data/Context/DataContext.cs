using MySqlConnector;
using System;

namespace DashAgil.Integrador.Infra.Data.Context
{
    public class DataContext : IDisposable
    {
        public MySqlConnection Connection { get; set; }

        public DataContext(string connection)
        {
            this.Connection = new MySqlConnection(connection);
            this.Connection.Open();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
