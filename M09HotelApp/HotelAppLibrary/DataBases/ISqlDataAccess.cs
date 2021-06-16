using System.Collections.Generic;

namespace HotelAppLibrary.DataBases
{
    public interface ISqlDataAccess
    {
        List<T> LoadData<T, U>(string sqlStatement, 
                               U parameters, 
                               string connectionStringName,
                               bool isStoreProcedure = false);
        void SaveData<T>(string sqlStatement,
                         T parameters,
                         string connectionStringName,
                         bool isStoreProcedure = false);
    }
}