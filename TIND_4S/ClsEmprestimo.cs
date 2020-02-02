using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TIND_4S
{
    abstract class ClsEmprestimo : ClsCrud
    {
        private int mID_Emprestimo;
        private int mID_Equipamento;
        private string mDt_Retirada;
        private int mID_Locatario_Saida;
        private int mID_Locador_Saida;
        private string mDt_PrevistaDevolucao;
        private string mDt_EfetivaDevolucao;
        private int mID_Locatario_Devolucao;
        private int mID_Locador_Devolucao;
        
        public int ID_Emprestimo
        {
            get { return mID_Emprestimo; }
            set { mID_Emprestimo = value; }
        }
        public int ID_Equipamento
        {
            get { return mID_Equipamento; }
            set { mID_Equipamento = value; }
        }
        public int ID_Locatario_Saida
        {
            get { return mID_Locatario_Saida; }
            set { mID_Locatario_Saida = value; }
        }
        public int ID_Locador_Saida
        {
            get { return mID_Locador_Saida; }
            set { mID_Locador_Saida = value; }
        }
        public int ID_Locatario_Devolucao
        {
            get { return mID_Locatario_Devolucao; }
            set { mID_Locatario_Devolucao = value; }
        }
        public int ID_Locador_Devolucao
        {
            get { return mID_Locador_Devolucao; }
            set { mID_Locador_Devolucao = value; }
        }
        public string Dt_Retirada
        {
            get { return mDt_Retirada; }
            set { mDt_Retirada = value; }
        }
        public string Dt_PrevistaDevolucao
        {
            get { return mDt_PrevistaDevolucao; }
            set { mDt_PrevistaDevolucao = value; }
        }
        public string Dt_EfetivaDevolucao
        {
            get { return mDt_EfetivaDevolucao; }
            set { mDt_EfetivaDevolucao = value; }
        }        

        public string InserirNovoLocador(string nome, string prontuario)
        {
            conexao = new ClsConexao();
            try
            {                
                SqlCommand cmd = new SqlCommand("sp_Sel_Locatario", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNm_Locatario", nome);
                cmd.Parameters.AddWithValue("@pRA_Locatario", prontuario);
                SqlDataReader dr = cmd.ExecuteReader();
                
                string result = string.Empty;
                while (dr.Read())                
                    result += dr[0].ToString();

                if (result.Length == 1)
                    return result;
                else if (result.Length > 1)
                    return "Digite o Nome e o Prontuario do Solicitante corretamente, pois foram encotrados mais de uma pessoa com os dados informados";
                else
                {
                    cmd = new SqlCommand("sp_Ins_Locatario", conexao.conectar());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pNm_Locatario", nome);
                    cmd.Parameters.AddWithValue("@pRA_Locatario", prontuario);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                        return dr[0].ToString();
                    else
                        return "Falaha Ao Inserir Locatario, Contate o Administrador";
                }                    
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
