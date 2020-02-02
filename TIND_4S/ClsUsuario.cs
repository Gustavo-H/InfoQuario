using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace TIND_4S
{
    class ClsUsuario : ClsCrud
    {
        private int mId_Usuario;
        private string mDs_Prontuario;
        private string mDs_Senha;
        private string mNm_Usuario;
        private string mDt_UltimoLogin;
        private string mDt_CadastroUsuario;
        private List<int> mID_Permissoes;

        public int ID_Usuario
        {
            get { return mId_Usuario; }
            set { mId_Usuario = value; }

        }
        public string Ds_Prontuario
        {
            get { return mDs_Prontuario; }
            set { mDs_Prontuario = value; }
        }
        public string Ds_Senha
        {
            get { return mDs_Senha; }
            set { mDs_Senha = value; }
        }
        public string Nm_Usuario
        {
            get { return mNm_Usuario; }
            set { mNm_Usuario = value; }
        }
        public List<int> ID_Permissoes
        {
            get { return mID_Permissoes; }
            set { mID_Permissoes = value; }
        }
        public string Dt_UltimoLogin
        {
            get { return mDt_UltimoLogin; }
            set { mDt_UltimoLogin = value; }
        }
        public string Dt_CadastroUsuario
        {
            get { return mDt_CadastroUsuario; }
            set { mDt_CadastroUsuario = value; }
        }
        
        
        public override string Atualizar()
        {
            conexao = new ClsConexao();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Upd_Usuario", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNm_Usuario", Nm_Usuario);
                cmd.Parameters.AddWithValue("@pDs_Prontuario", Ds_Prontuario);
                cmd.Parameters.AddWithValue("@pDs_Senha", Ds_Senha);
                cmd.Parameters.AddWithValue("@pId_Usuario", ID_Usuario);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return inserirPermissoesUsuario(ID_Usuario, ID_Permissoes);                    
                }
                else
                {
                    return "Falha no banco de dados ao tentar atualizar usuario \n A função ExecuteNomQuery retornou 0 linhas afetas quando o valor deveria ser um mais.";
                }
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
        public override string Consultar()
        {
            conexao = new ClsConexao();
            try
            {
                
                SqlCommand cmd = new SqlCommand("sp_Sel_Usuario", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pId_Usuario", ID_Usuario);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

                dr.Read();

                Nm_Usuario = dr["Nome"].ToString();
                Ds_Prontuario = dr["Login"].ToString();
                Ds_Senha = dr["Senha"].ToString();
                Dt_CadastroUsuario = dr["DataCadastro"].ToString();
                Dt_UltimoLogin = dr["UltimoLogin"].ToString();
                ID_Permissoes = getPermissoesUsuario(ID_Usuario);
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
        public override string Excluir()
        {
            conexao = new ClsConexao();
            try
            {
                
                SqlCommand cmd = new SqlCommand("sp_Del_Usuario", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pId_Usuario", ID_Usuario);

                if (cmd.ExecuteNonQuery() > 0)                
                    return "OK";                
                else
                    return "Função ExecuteNonQuery Retornou 0 linhas alteradas, sendo que devia ter sido alterado pelo menos 1.";
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
        public override string Grid()
        {
            string resultado = string.Empty;

            conexao = new ClsConexao();
            try
            {
                
                SqlCommand cmd = new SqlCommand("sp_Grid_Usuario", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNm_Usuario", Nm_Usuario);
                cmd.Parameters.AddWithValue("@pDs_Prontuario", Ds_Prontuario);               
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                Ds = new DataSet();
                da.Fill(Ds);
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
        public override string Inserir()
        {
            conexao = new ClsConexao();
            try
            {
                
                SqlCommand cmd = new SqlCommand("sp_Ins_Usuario", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNm_Usuario", Nm_Usuario);
                cmd.Parameters.AddWithValue("@pDs_Prontuario", Ds_Prontuario);
                cmd.Parameters.AddWithValue("@pDs_Senha", Ds_Senha);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())                
                    return inserirPermissoesUsuario(int.Parse(dr["ID"].ToString()), ID_Permissoes);                                    
                else               
                    return "Falha no banco de dados ao tenatr inserir funcionario/nA função ExecuteNomQuery Retornou 0 linhas afetadas quando o valor deveria ser igual ou mair que 1";                
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
          
        public static List<int> getPermissoesUsuario(int id)
        {
            ClsConexao conexao = new ClsConexao();
            List<int> permissoes = new List<int>();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_Sel_PermissoesUsuario", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pID_Usuario", id);
                SqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    permissoes.Add(int.Parse(dr["ID"].ToString()));
                }
                conexao.desconectar();
                return (permissoes);
            }
            catch
            {
                conexao.desconectar();
                return (null);
            }
        }       
        public static bool validarProntuario(string prontuario)
        {
            ClsConexao conexao = new ClsConexao();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ValidarProntuario", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pDs_Prontuario", prontuario);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }           
        }        

        private string inserirPermissoesUsuario(int id, List<int> permissoes)
        {
            conexao = new ClsConexao();
            SqlTransaction transaction;
            conexao.conectar();
            transaction = conexao.conexao.BeginTransaction("transPermissao");        

            try
            {                            
                SqlCommand cmd = new SqlCommand("sp_Del_PermissoesUsuario", transaction.Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = transaction;
                cmd.Parameters.AddWithValue("@pID_Usuario", id);
                
                cmd.ExecuteNonQuery();                
                
                for (int i = 0; i < ID_Permissoes.Count; i++)
                {                   
                    cmd = new SqlCommand("sp_Ins_PermissoesUsuario", transaction.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaction;
                    cmd.Parameters.AddWithValue("@pID_Usuario", id);
                    cmd.Parameters.AddWithValue("@pID_Funcionalidade", ID_Permissoes[i]);                    
                    cmd.ExecuteNonQuery();
                }
                
                transaction.Commit();
                conexao.desconectar();
                return ("OK");
            }
            catch (Exception ex)
            {                
                try
                {
                    transaction.Rollback();
                    return ex.ToString();
                }
                catch (Exception ex2)
                {
                    return ex.ToString() + ex2.ToString();
                }                
            }
        }        
        public string getFuncionalidades()
        { 
            conexao = new ClsConexao();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Sel_Funcionalidades", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                Ds = new DataSet();
                da.Fill(Ds);
                conexao.desconectar();
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
    }
}

        