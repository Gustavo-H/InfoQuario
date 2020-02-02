using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TIND_4S
{
    class ClsNovoEmprestimo : ClsEmprestimo
    {
        //ClsConexao conexao = new ClsConexao();
        public override string Inserir()
        {
            conexao = new ClsConexao();

            try
            {                
                SqlCommand cmd = new SqlCommand("sp_Ins_NovoEmprestimo", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pID_Equipamento", ID_Equipamento);
                cmd.Parameters.AddWithValue("@pDt_Retirada", Convert.ToDateTime(Dt_Retirada));
                cmd.Parameters.AddWithValue("@pID_Locatario_Saida", ID_Locatario_Saida);
                cmd.Parameters.AddWithValue("@pID_Locador_Saida", ID_Locador_Saida);
                cmd.Parameters.AddWithValue("@pDt_PrevistaDevolucao", Convert.ToDateTime(Dt_PrevistaDevolucao));
                if (cmd.ExecuteNonQuery() > 0)
                    return "OK";
                else
                    return "Procedimento NonQuery nao retornou nehuma linha alterada";
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
        public string Grid(string tipo)
        {

            conexao = new ClsConexao();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_Grid_Equipamento_Disponivel", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pDs_Tipo", tipo);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //Ds = new DataSet();
                Dt = new DataTable();
                da.Fill(Dt);
                return "OK";
            }
            catch (Exception ex)
            {
                return (ex.ToString());
            }
            finally
            {
                conexao.desconectar();
            }
        }                        
        public string Grid(string nome, string prontuario)
        {
            conexao = new ClsConexao();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_Grid_Locatario", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNm_Locatario", nome);
                cmd.Parameters.AddWithValue("@pRA_Locatario", prontuario);
                SqlDataAdapter da = new SqlDataAdapter(cmd);                
                Dt = new DataTable();
                da.Fill(Dt);
                return "OK";
            }
            catch (Exception ex)
            {
                return (ex.ToString());
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
        public override string Grid()
        {
            throw new NotImplementedException();
        }

    }
}
