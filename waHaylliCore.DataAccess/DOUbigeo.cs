using System;
using System.Collections.Generic;
using System.Text;
using waHaylliCore.Common;
using waHaylliCore.EntityModel;
using System.Data.SqlClient;
using System.Data;
using AppLogger;

namespace waHaylliCore.DataAccess
{
    public class DOUbigeo : DOGeneral, IRepository<Ubigeo> 
    {
        private DataFactory _dbProviderFactory;
        private DataHandler _dataHandler;
        private int _errorCode, _rowsAffected;

        public  DOUbigeo() {
            _dbProviderFactory = new DataFactory();
            _dataHandler = new DataHandler();
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Ubigeo entity)
        {
            throw new NotImplementedException();
        }

        public List<Ubigeo> SelectAll()
        {

            //_errorCode = 0;
            //_rowsAffected = 0;
            
            var returnedEntities = new List<Ubigeo>();

            try
            {
                var sb = new StringBuilder();
                sb.Append("SET DATEFORMAT DMY; ");
                sb.Append("SELECT ");
                sb.Append("[ubigeoId],[title],[code],[label],[search],[numberChildrens],[levelOrder],[fatherId]");             
                sb.Append(" FROM [GEN].[Ubigeo]");
                sb.Append("WHERE [levelOrder]= 0 and [fatherId]= 0 ");
                sb.Append("order by title asc ");
                sb.Append("SELECT @intErrorCode=@@ERROR; ");

                var commandText = sb.ToString();
                sb.Clear();


                using (var dbConnection = _dbProviderFactory.CreateConnection(sConexion,DatabaseType.SQLServer))
                {
                    if (dbConnection == null)
                        throw new ArgumentNullException("dbConnection", "The db connection can't be null.");

                    dbConnection.ConnectionString = sConexion;

                    using (var dbCommand = _dbProviderFactory.CreateCommand(commandText, DatabaseType.SQLServer,dbConnection))
                    {
                        if (dbCommand == null)
                            throw new ArgumentNullException("dbCommand" + " The db command for entity [Ubigeo] can't be null. ");

                        dbCommand.Connection = dbConnection;
                        dbCommand.CommandText = commandText;

                        //Input Parameters - None

                        //Output Parameters
                        _dataHandler.AddParameterToCommand((SqlCommand)dbCommand, "@intErrorCode", csType.Int, ParameterDirection.Output, null);

                        //Open Connection
                        if (dbConnection.State != ConnectionState.Open)
                            dbConnection.Open();

                        //Execute query.
                        using (var reader = dbCommand.ExecuteReader())
                        {
                            if (reader!=null)
                            {
                                while (reader.Read())
                                {
                                    var entity = new Ubigeo();
                                    entity.ubigeoId = reader.GetInt32(0);
                                    entity.title = reader.GetString(1);
                                    entity.code = reader.GetString(2);

                                    returnedEntities.Add(entity);
                                }
                            }

                        }

                        //_errorCode = int.Parse(dbCommand.Parameters["@intErrorCode"].Value.ToString());

                        if (_errorCode != 0)
                        {

                            // Throw error.
                            throw new Exception("The SelectAll method for entity [ServiceType] reported the Database ErrorCode: " + _errorCode);
                        }
                    }
                }

                return returnedEntities;
            }
            catch (Exception ex)
            {
                //Log exception error
                //_loggingHandler.LogEntry(ExceptionHandler.GetExceptionMessageFormatted(ex), true);
                FactoryFileLogger.FactoryLoggerMethod(ex.Message+"\n"+ex.StackTrace + "\n" + ex.Source, LogLevel.Critical, "DOUbigeo.SelectAll");
                
                //Bubble error to caller and encapsulate Exception object
                throw new Exception("EmployeesRepository::SelectAll::Error occured.", ex);
            }
        }

        public Ubigeo SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Ubigeo entity)
        {
            throw new NotImplementedException();
        }
    }
}
