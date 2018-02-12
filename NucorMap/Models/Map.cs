using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace Map.Models
{
    public class Map
    {
        public int Id { get; set; }
        public string NameDepartment { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Speed { get; set; }
        public double SafetyLevel { get; set; }
    }
}