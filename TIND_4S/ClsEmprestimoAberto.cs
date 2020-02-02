using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TIND_4S
{
    class ClsEmprestimoAberto : ClsEmprestimo
    { 
        private string mNm_Equipamento;
        private string mDs_TipoItem;
        private string mNm_Locatario;
        private string mRA_Locatario;
        private string mNm_Locador;
        private string mRA_Locador;

        public string Nm_Equipamento
        {
            get { return mNm_Equipamento; }
            set { mNm_Equipamento = value; }
        }
        public string Ds_TipoItem
        {
            get { return mDs_TipoItem; }
            set { mDs_TipoItem = value; }
        }
        public string Nm_Locatario
        {
            get { return mNm_Locatario; }
            set { mNm_Locatario = value; }
        }
        public string RA_Locatario
        {
            get { return mRA_Locatario; }
            set { mRA_Locatario = value; }
        }
        public string Nm_Locador
        {
            get { return mNm_Locador; }
            set { mNm_Locador = value; }
        }
        public string RA_Locador
        {
            get { return mRA_Locador; }
            set { mRA_Locador = value; }
        }        


        public override string Consultar()
        {
            conexao = new ClsConexao();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Sel_Emprestimo", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pID_Emprestimo",ID_Emprestimo);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Nm_Equipamento = dr["NomeEquipamento"].ToString();
                    Ds_TipoItem = dr["Ds_Tipo"].ToString();
                    Nm_Locatario = dr["Nm_Locatario"].ToString();
                    RA_Locatario = dr["RA_Locatario"].ToString();
                    Nm_Locador = dr["Nm_Locador"].ToString();
                    RA_Locador = dr["RA_Locador"].ToString();
                    Dt_Retirada = dr["Dt_Retirada"].ToString();
                    Dt_PrevistaDevolucao = dr["Dt_PrevistaDevolucao"].ToString();
                    return "OK";
                }
                else
                    return "Data Reader Vazio Quando o Mesmo Deveria ter ao menos uma linha";
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
                SqlCommand cmd = new SqlCommand("sp_Grid_EmprestimosAbertos", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                Ds = new DataSet();
                da.Fill(Ds);
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


        public override string Inserir()
        {
            throw new NotImplementedException();
        }
        public override string Atualizar()
        {
            throw new NotImplementedException();
        }
        public override string Excluir()
        {
            throw new NotImplementedException();
        }
    }
}
