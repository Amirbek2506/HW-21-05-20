using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace ASR.NETCoreMVS.Models.Persons
{
    public class ConnectionDataPersons
    {
        public string ConnString = "Data Source=Amirbek;Initial Catalog=AlifAcademy;Integrated Security=True";
        public List<Person> GetInfoPersons()
        {
            using (IDbConnection db = new SqlConnection(ConnString))
            {
                return db.Query<Person>("SELECT * FROM PERSON").ToList<Person>();
            }
        }
    }
}
