using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using System.Linq;
using System.Web;

namespace NucorMap.Models
{
    public class MapSpec
    {
        public int Id { get; set; }
        public string NameDepartment { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public  int Speed { get; set; }
        public int SafetyLevel { get; set; }

        public List<MapSpec> ReadAll()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString))
            {
                return db.Query<MapSpec>("SELECT * FROM NucorMapDemo").ToList();
            }
        }



    }


}