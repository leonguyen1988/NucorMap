using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NucorMap.database_access_layer
{
    public class database
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        // GET: All Locations
        public  DataTable GetAllLocation()
        {
            SqlCommand command = new SqlCommand("Select Deparment=NameDepartment,Latitude = Latitude, Longitude = Longitude from DepartmentsLocations",con);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            return dataTable;
        }
    }
}