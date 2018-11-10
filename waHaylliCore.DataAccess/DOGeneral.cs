using System;
using System.Configuration;

namespace waHaylliCore.DataAccess
{
    public class DOGeneral
    {
        public String sConexion { get; set; }

        public DOGeneral()
        {
            sConexion = ConfigurationManager.ConnectionStrings["conConexion"].ConnectionString;
        }
    }
}
