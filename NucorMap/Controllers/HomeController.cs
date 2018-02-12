
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;
using QuickGraph;
using NucorMap.Models;


namespace Map.Controllers
{
    public class HomeController : Controller
    {
        // GET: Index1
        //public ActionResult Index()
        //{
        //    SqlConnection conn = new SqlConnection(
        //                    "Data Souce = ITSQL; Initial Catalog = IT;Integrated Security =SSPI");

        //    //string conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        //    //SqlCommand command = new SqlCommand("SELECT * FROM NucorMap");

        //    List<MapSpec> Map = new List<MapSpec>();
        //    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["IT"].ConnectionString))
        //    {
        //        db.Query<MapSpec>("SELECT * FROM dbo.NucorMap").ToList();
        //    }
        //    return View(Map);
        //}

        // GET: /Index
        public ActionResult Index()
        {
            List<MapSpec> Nucorlist = new List<MapSpec>();
            AdjacencyGraph<MapSpec, Edge<MapSpec>> map = new AdjacencyGraph<MapSpec, Edge<MapSpec>>(true);
            //string markers = "[";
            string conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlCommand command = new SqlCommand("SELECT * FROM NucorMapDemo");
            using (SqlConnection connection = new SqlConnection(conString))
            {
                command.Connection = connection;

                connection.Open();

                using (SqlDataReader SqlDataReader = command.ExecuteReader())
                {
                    //while (SqlDataReader.Read())
                    //{
                        // Using Dapper Class to get data and store them in to the list is easy and fast
                        using (IDbConnection db = new SqlConnection(conString))
                        {
                            Nucorlist = db.Query<MapSpec>("SELECT * FROM NucorMapDemo").ToList();
                        }
                   
                        for (int i = 0; i < Nucorlist.Count-1; i++)
                        {
                            map.AddVerticesAndEdge(new Edge<MapSpec>(Nucorlist[i],Nucorlist[i+1]));
                        

                        }
                    Dictionary<Edge<MapSpec>, int> cost = new Dictionary<Edge<MapSpec>, int>();
                        for(int i =0; i<map.EdgeCount;i++)
                    {

                    }
                    
                    //Edge<MapSpec>[] leo = new Edge<MapSpec>[Nucorlist.Count];
                    //    for(int i = 0; i<leo.Length;i++)
                    //{
                    //    Edge<MapSpec> i = new Edge<MapSpec>(Nucorlist.ElementAt(), Nucorlist[i + 1]);
                    //}
                    //    markers += "{";
                    //    markers += string.Format("'Id':'{0}',", SqlDataReader["Id"]);
                    //    markers += string.Format("'Department': '{0}',", SqlDataReader["NameDepartment"]);
                    //    markers += string.Format("'Latitude': '{0}',", SqlDataReader["Latitude"]);
                    //    markers += string.Format("'Longitude':'{0}',", SqlDataReader["Longitude"]);
                    //    markers += string.Format("'Speed':'{0}',", SqlDataReader["Speed"]);
                    //    markers += "},";
                    //}
                    //}
                    connection.Close();

                }

                //markers += "];";
                //ViewBag.Location = markers;

                return View();
            }
        }
    }
       

        ////public JsonResult GetAllLocationById(int id)
        ////{
        ////    var data = db.Departments.Single(x => x.id == id);
        ////    return Json(data, JsonRequestBehavior.AllowGet);
        ////}
        ////public String Location_Bind(DataTable dataTable)
        ////{
        ////    System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
        ////    List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
        ////    Dictionary<string, object> row;
        ////    foreach (DataRow dataRow in dataTable.Rows)
        ////    {
        ////        row = new Dictionary<string, object>();
        ////        foreach (DataColumn col in dataTable.Columns)
        ////        {
        ////            row.Add(col.ColumnName, dataRow[col]);
        ////        }
        ////        rows.Add(row);
        ////    }
        ////    return serializer.Serialize(rows);
        ////}
    //[NonAction]
    //    public List<Department> GetList()
    //    {
    //        return new List<Department>
    //        {
    //            new Department
    //            {
    //                id = 1,
    //                name = "Administrator",
    //                latitude = 35.899411,
    //                longitude = -89.776254
    //            },
    //            new Department
    //            {
    //                id = 2,
    //                name ="Sale",
    //                latitude = 35.899411,
    //                longitude = -89.776254
    //            },
    //            new Department
    //            {
    //                id = 3,
    //                name ="GuardCheck",
    //                latitude = 35.907578,
    //                longitude = -89.775639
    //            },
    //        };
    //    }

}