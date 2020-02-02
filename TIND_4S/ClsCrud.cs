using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TIND_4S
{
    public abstract class ClsCrud
    {
        public ClsConexao conexao;
        // public int conexao;
        public DataSet Ds;
        public DataTable Dt;
        
        abstract public string Inserir();
        abstract public string Atualizar();
        abstract public string Consultar(); 
        abstract public string Grid();
        abstract public string Excluir();

        public void InserirLog()
        {         
              
        }
    }
}
