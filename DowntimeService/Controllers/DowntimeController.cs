using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using DowntimeService.DBContext;
using DowntimeService.Models;

namespace DowntimeService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DowntimeController : Controller
    {

        AndonPullDB objAndonPullDB = new AndonPullDB();
        //[HttpGet]
        //public string TestMethod1()
        //{
        //    return "Method1";
        //}

        [HttpGet]
        public List<AndonPullModel> GetAndonPull()
        {

            DataSet dsAndonPull = objAndonPullDB.GetAndonPullDetails();
            List<AndonPullModel> lstAndonPull = new List<AndonPullModel>();

            foreach (DataRow dr in dsAndonPull.Tables[0].Rows)
            {

                lstAndonPull.Add(new AndonPullModel
                {
                    ProductionLineID = Convert.ToInt32(dr["ProductionLineID"]),
                    ProductionLineName = dr["ProductionLineDescription"].ToString(),
                    //StartTime = Convert.ToDateTime(dr["StartTime"]),
                    //EndTime = Convert.ToDateTime(dr["EndTime"])
                }

                                );
            }

            return lstAndonPull;
        }

    }
}
