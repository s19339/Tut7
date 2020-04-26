using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial7.Services
{
    public class SqlServerDbService : IDbService

    {


        public bool CheckIndex(string index)
        {


            using (var con = new SqlConnection("Data Source=db-mssql;Initial Catalog=s19339;Integrated Security=True"))
            using (var com = new SqlCommand())
            {
                com.Connection = con;
                com.CommandText = @"select s.IndexNumber, s.FirstName, s.LastName from Student s;";
                con.Open();
                var dr = com.ExecuteReader();
                if (!dr.Read())
                {
                    return false;
                }
                return true;


            }
        }
    }
}
