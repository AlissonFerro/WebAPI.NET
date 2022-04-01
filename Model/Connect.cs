using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class Connect
    {
        public SqlConnection connection;

        public void createConnect()
        {
            SqlConnectionStringBuilder strConetc = new SqlConnectionStringBuilder();

            strConetc.DataSource = "SNCCH03LABF322\\TEW_SQLEXPRESS";

            strConetc.InitialCatalog = "projeto1";

            strConetc.IntegratedSecurity = true;            
           
            connection= new SqlConnection(strConetc.ConnectionString);

            connection.Open();
           
        }
    }
}
