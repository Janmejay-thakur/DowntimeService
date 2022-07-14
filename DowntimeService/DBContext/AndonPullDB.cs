using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DowntimeService.DBContext
{
    public class AndonPullDB
    {
        SqlConnection _connection = new SqlConnection("server=LAPTOP-7GUDFKJ7\\SQLEXPRESS; database = FacMon; Integrated Security =true;");
        public DataSet GetAndonPullDetails()
        {
            DataSet dsAndonPull = new DataSet();


            SqlCommand cmdAndonPull = new SqlCommand("GetAndonPull", _connection);
            cmdAndonPull.CommandType = CommandType.StoredProcedure;
            cmdAndonPull.Parameters.AddWithValue("@ProductionLineID", 4);
            SqlDataAdapter daAndonPull = new SqlDataAdapter(cmdAndonPull);
            daAndonPull.Fill(dsAndonPull);

            return dsAndonPull;
        }


    }
}
