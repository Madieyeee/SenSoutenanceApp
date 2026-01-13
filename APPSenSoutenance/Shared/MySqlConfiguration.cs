using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace APPSenSoutenance.Shared
{
    public class MySqlConfiguration : DbConfiguration
    {
        public MySqlConfiguration()
        {
            SetHistoryContext("MySql.Data.MySqlClient", (conn, schema) => new MySqlHistoryContext(conn, schema));
            SetProviderServices("MySql.Data.MySqlClient", new MySqlProviderServices());
        }
    }
}
