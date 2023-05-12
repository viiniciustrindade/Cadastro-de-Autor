using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADASTRTO_DE_AUTOR
{
    public class DaoConnection
    {
        public static SqlConnection GetConexao()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Treinamento;Integrated Security=True;MultipleActiveResultSets=true;");
            connection.Open();
            return connection;
        }
    }
}
