using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TIND_4S
{
    public class ClsConexao
    {
        public SqlConnection conexao = new SqlConnection();
        
        public SqlConnection conectar()
        {
            desconectar();            
            conexao.ConnectionString = "Server = IBM-PC\\SQLEXPRESS; Database = db_Tind4S; Uid = userTind4s; Trusted_Connection=True;";
            //conexao.ConnectionString = "Server = db-tind4s.chwaokuky6hn.sa-east-1.rds.amazonaws.com, 1433; Database = db_Tind4S; Uid = adminTind4S; Pwd = mineirofoda;";
            conexao.Open();
            return conexao;
        }

        public void desconectar()
        {
            conexao.Close();
        }
    }
}
