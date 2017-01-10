using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteAnalysis.Worker.Utilities
{
    public class CtConnection : IDisposable
    {
        public SqlConnection cnn;
        private const string connectionString = "Server=tcp:satrackteamserver.database.windows.net,1433;Initial Catalog=SatrackCT;Persist Security Info=False;User ID=andreslon@satrackteamserver;Password=22@ndreslon;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public CtConnection()
        {
            if ((cnn = _cnn()) == null)
            {
                this.Dispose();
            }
        }

        private SqlConnection _cnn()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = connectionString;
                conn.Open();
                return conn;
            }
            catch
            {
                conn.Dispose();
                return null;
            }
        }
        public void Dispose()
        {
            if (cnn != null)
            {
                cnn.Dispose();
            }
        }
    }
}
