using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace TIND_4S
{
    class ClsDevolucao : ClsEmprestimo
    {
        //private ClsConexao conexao = new ClsConexao();
        
        public override string Atualizar()
        {
            conexao = new ClsConexao(); 
            try
            {                               
                SqlCommand cmd = new SqlCommand("sp_Upd_Emprestimo", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pID_Locador_Devolucao",ID_Locador_Devolucao);
                cmd.Parameters.AddWithValue("@pID_Locatario_Devolucao",ID_Locatario_Devolucao);
                cmd.Parameters.AddWithValue("@pDt_EfetivaDevolucao", Convert.ToDateTime(Dt_EfetivaDevolucao));
                cmd.Parameters.AddWithValue("@pID_Emprestimo",ID_Emprestimo);
                if(cmd.ExecuteNonQuery() > 0)                
                    return "OK";                
                else
                    return "0 linhas afetas quando o valor deveria ser 1 ou mais";                    
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                conexao.desconectar();
            }

        }
        public override string Consultar()
        {
            conexao = new ClsConexao();
            try
            {                
                SqlCommand cmd = new SqlCommand("sp_Sel_Emprestimo", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pID_Emprestimo", ID_Emprestimo);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {                    
                    ID_Locador_Saida = int.Parse(dr["ID_Locador_Saida"].ToString());                    
                    ID_Locatario_Saida = int.Parse(dr["ID_Locatario_Saida"].ToString());                    
                    Dt_PrevistaDevolucao = dr["Dt_PrevistaDevolucao"].ToString();
                    Dt_Retirada = dr["Dt_Retirada"].ToString();
                    return "OK";
                }
                else
                    return "Data Reader Retornou vazio, quando o mesmo deveria ter dados";                
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
        public string Grid(string tipo)
        {
            conexao = new ClsConexao();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Grid_Equipamento_Emprestado", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pDs_Tipo", tipo);
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
        public string Consultar(int id)
        {
            conexao = new ClsConexao();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Sel_ID_EmprestimoAberto", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pID_Equipamento", id);
                SqlDataReader dr = cmd.ExecuteReader();
                //if (dr.Read())                
                dr.Read();    
                return dr["ID"].ToString();                 
                //else
                  //  return "Dr Retornou vazio, quando o mesmo deveria ter dados";
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
        
        public override string Inserir()
        {
            
            throw new NotImplementedException();
        }        
        public override string Grid()
        {
            throw new NotImplementedException();
        }
        public override string Excluir()
        {
            throw new NotImplementedException();
        }
        
    }
}


