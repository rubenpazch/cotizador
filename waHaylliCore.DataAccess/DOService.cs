using System;
using System.Collections.Generic;
using waHaylliCore.EntityModel;

namespace waHaylliCore.DataAccess
{
    public class DOService : IRepository<Service>
    {
        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Service entity)
        {
            throw new NotImplementedException();
        }

        public List<Service> SelectAll()
        {
            //_errorCode = 0;
            //_rowsAffected = 0;
            /*
            var returnedEntities = new List<Service>();

            try
            {
                var sb = new StringBuilder();
                sb.Append("SET DATEFORMAT DMY; ");
                sb.Append("SELECT ");
                sb.Append("[serviceTypeId], ");
                sb.Append("[nameServiceType], ");
                sb.Append("[descriptionService] ");
                sb.Append("FROM [dbo].[tServiceType]");
                sb.Append("ORDER BY [nameServiceType]");
                sb.Append("SELECT @intErrorCode=@@ERROR; ");

                var commandText = sb.ToString();
                sb.Clear();

                using (var dbConnection = _dbProviderFactory.CreateConnection())
                {
                    if (dbConnection == null)
                        throw new ArgumentNullException("dbConnection", "The db connection can't be null.");

                    dbConnection.ConnectionString = _connectionString;

                    using (var dbCommand = _dbProviderFactory.CreateCommand())
                    {
                        if (dbCommand == null)
                            throw new ArgumentNullException("dbCommand" + " The db command for entity [ServiceType] can't be null. ");

                        dbCommand.Connection = dbConnection;
                        dbCommand.CommandText = commandText;

                        //Input Parameters - None

                        //Output Parameters
                        _dataHandler.AddParameterToCommand(dbCommand, "@intErrorCode", csType.Int, ParameterDirection.Output, null);

                        //Open Connection
                        if (dbConnection.State != ConnectionState.Open)
                            dbConnection.Open();

                        //Execute query.
                        using (var reader = dbCommand.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    var entity = new ServiceType();
                                    entity.serviceTypeId = reader.GetInt32(0);
                                    entity.nameServiceType = reader.GetString(1);
                                    entity.descriptionServiceType = reader.GetString(2);
                                    returnedEntities.Add(entity);
                                }
                            }

                        }

                        _errorCode = int.Parse(dbCommand.Parameters["@intErrorCode"].Value.ToString());

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

                //Bubble error to caller and encapsulate Exception object
                throw new Exception("EmployeesRepository::SelectAll::Error occured.", ex);
            }*/
            

            throw new NotImplementedException();
        }

        public Service SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Service entity)
        {
            throw new NotImplementedException();
        }
    }
}
