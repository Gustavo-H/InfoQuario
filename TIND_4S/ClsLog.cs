using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace TIND_4S
{
    class ClsLog : ClsCrud
    {
        private int mID_Usuario;
        private string mDs_Log;
        private DateTime mDt_Log;

        public int ID_Usuario
        {
            get { return mID_Usuario; }
            set { mID_Usuario = value; }
        }
        public string Ds_Log
        {
            get { return mDs_Log; }
            set { mDs_Log = value; }
        }
        public DateTime Dt_Log
        {
            get { return mDt_Log; }
            set { mDt_Log = value; }        
        }


        public override string Inserir()
        {
            conexao = new ClsConexao();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Ins_Log", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pId_Usuario", ID_Usuario);
                cmd.Parameters.AddWithValue("@pDs_Log", Ds_Log);                
                cmd.ExecuteNonQuery();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                conexao.desconectar();
            }
        }
        public override string Grid()
        {
            conexao = new ClsConexao();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Grid_Log", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                Dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(Dt);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                conexao.desconectar();
            }
        }



        public override string Atualizar()
        {
            throw new NotImplementedException();
        }
        public override string Consultar()
        {
            throw new NotImplementedException();
        }
        public override string Excluir()
        {
            throw new NotImplementedException();
        }
    }
}
