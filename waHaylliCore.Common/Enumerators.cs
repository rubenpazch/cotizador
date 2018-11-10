using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waHaylliCore.Common
{
    public enum csType
    {
        Binary,
        Boolean,
        Byte,
        ByteArray,
        Char,
        DateTime,
        Decimal,
        Double,
        Guid,
        Short,
        Int,
        Long,
        String,
        Null
    }
    public enum DatabaseType
    {
        Access,
        SQLServer,
        Oracle,
        MySql
    }
    /*public enum ParameterDirection
    {
        //
        // Resumen:
        //     Se trata de un parámetro de entrada.
        Input = 1,
        //
        // Resumen:
        //     Se trata de un parámetro de salida.
        Output = 2,
        //
        // Resumen:
        //     El parámetro es capaz de entrada y salida.
        InputOutput = 3,
        //
        // Resumen:
        //     El parámetro representa un valor devuelto de una operación como, por ejemplo,
        //     un procedimiento almacenado, una función integrada o una función definida por
        //     el usuario.
        ReturnValue = 6
    }
    //
    // Resumen:
    //     Describe el estado actual de la conexión a un origen de datos.
    public enum ConnectionState
    {
        //
        // Resumen:
        //     La conexión está cerrada.
        Closed = 0,
        //
        // Resumen:
        //     La conexión está abierta.
        Open = 1,
        //
        // Resumen:
        //     El objeto de conexión se conecta al origen de datos.
        Connecting = 2,
        //
        // Resumen:
        //     El objeto de conexión está ejecutando un comando. (Este valor está reservado
        //     para versiones futuras del producto).
        Executing = 4,
        //
        // Resumen:
        //     El objeto de conexión está recuperando datos. (Este valor está reservado para
        //     versiones futuras del producto).
        Fetching = 8,
        //
        // Resumen:
        //     Se pierde la conexión al origen de datos. Esto puede ocurrir sólo una vez abierta
        //     la conexión. Una conexión en este estado se puede cerrar y, a continuación, vuelva
        //     a abrir. (Este valor está reservado para versiones futuras del producto).
        Broken = 16
    }*/
}
