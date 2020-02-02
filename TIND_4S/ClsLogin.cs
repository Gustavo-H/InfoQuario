using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace TIND_4S
{
    class ClsLogin
    {

        public static ClsLogin UserLogado;
        ClsConexao conexao = new ClsConexao();


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

       

        public string validarLogin()
        {            
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ValidarLogin", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pLogin", Ds_Prontuario);
                cmd.Parameters.AddWithValue("@pSenha", Ds_Senha);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                
                if (dr.Read())                
                {
                    UserLogado = new ClsLogin();
                    UserLogado.ID_Usuario = int.Parse(dr["ID"].ToString());
                    UserLogado.Nm_Usuario = dr["Nome"].ToString();
                    UserLogado.Ds_Prontuario = Ds_Prontuario;
                    UserLogado.Dt_CadastroUsuario = dr["DataCadastro"].ToString();
                    UserLogado.Dt_UltimoLogin = dr["UltimoLogin"].ToString();
                    UserLogado.ID_Permissoes = ClsUsuario.getPermissoesUsuario(UserLogado.ID_Usuario);
                    setDataLogin();
                    return "true";
                }
                else
                    return "false";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }       
        private void setDataLogin()
        {            
            try
            {
                
                SqlCommand cmd = new SqlCommand("sp_Set_DataLogin", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pId_Usuario", UserLogado.ID_Usuario);
                cmd.ExecuteNonQuery();
                conexao.desconectar();
            }
            catch
            {
            }

        }
    }
}
