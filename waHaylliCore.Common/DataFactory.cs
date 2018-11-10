using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace waHaylliCore.Common
{
    public class DataFactory {
            public DataFactory() { }

            public  IDbConnection CreateConnection(string ConnectionString, DatabaseType databaseType) {
                IDbConnection conn;

                switch (databaseType)
                {
                    case DatabaseType.Access:
                        conn = new OleDbConnection(ConnectionString);
                        break;
                    case DatabaseType.SQLServer:
                        conn = new SqlConnection(ConnectionString);
                        break;
                    case DatabaseType.Oracle:
                        conn = new OracleConnection(ConnectionString);
                        break;
                    case DatabaseType.MySql:
                        conn = new MySqlConnection(ConnectionString);
                        break;
                    default:
                        conn = new SqlConnection(ConnectionString);
                        break;
                }
                return conn;
            }
            public  IDbCommand CreateCommand(string commandText, DatabaseType databaseType, IDbConnection cnn)
            {
                IDbCommand cmd;

                switch (databaseType) {
                    case DatabaseType.Access:
                        cmd = new OleDbCommand (commandText, (OleDbConnection)cnn);
                        break;
                    case DatabaseType.SQLServer:
                        cmd = new SqlCommand(commandText, (SqlConnection)cnn);
                        break;
                    case DatabaseType.Oracle:
                        cmd = new OracleCommand(commandText, (OracleConnection)cnn);
                        break;
                    case DatabaseType.MySql:
                        cmd = new MySqlCommand(commandText, (MySqlConnection)cnn);
                        break;
                    default:
                        cmd = new SqlCommand(commandText, (SqlConnection)cnn);
                        break;

                }
                return cmd;
            }
            public  DbDataAdapter CreateAdapter(IDbCommand cmd, DatabaseType dbtype)
            {
                DbDataAdapter da;
                switch (dbtype)
                {
                    case DatabaseType.Access:
                        da = new OleDbDataAdapter
                           ((OleDbCommand)cmd);
                        break;

                    case DatabaseType.SQLServer:
                        da = new SqlDataAdapter
                           ((SqlCommand)cmd);
                        break;

                    case DatabaseType.Oracle:
                        da = new OracleDataAdapter
                           ((OracleCommand)cmd);
                        break;

                    case DatabaseType.MySql:
                        da = new MySqlDataAdapter
                           ((MySqlCommand)cmd);
                        break;

                    default:
                        da = new SqlDataAdapter
                           ((SqlCommand)cmd);
                        break;
                }

                return da;
            }


        }
        
    
}
