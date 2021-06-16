using HotelAppLibrary.DataBases;
using HotelAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAppLibrary.Data
{
    public class SqlData
    {
        private readonly ISqlDataAccess _db;
        private const string connectionString = "SqlDb";

        public SqlData(ISqlDataAccess db)
        {
            _db = db;
        }
        public List<RoomTypeModel> GetAvailableRoomType(DateTime startDate, DateTime endDate)
        {
            _db.LoadData<RoomTypeModel, dynamic>("db_spRoomTypes_GetAvailableTypes",
                                                 new { startDate, endDate },
                                                 "SqlDb",
                                                  true);
        }
    }
}
