using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace TIND_4S
{
    class ClsRelatorio : ClsEmprestimo
    {
        private string mNm_Equipamento;        
        private string mNm_Locatario;       
        private string mNm_LocadorSaida;
        private string mNm_LocadorDevolucao;
      
        private int mDs_Status;
        private string mDt_SaidaInicio;
        private string mDt_SaidaFim;
        private string mDt_DevolucaoInicio;
        private string mDt_DevolucaoFim;


        public string Dt_SaidaInicio
        {
            get { return mDt_SaidaInicio; }
            set { mDt_SaidaInicio = value; }
        }
        public string Dt_SaidaFim
        {
            get { return mDt_SaidaFim; }
            set { mDt_SaidaFim = value; }
        }
        public string Dt_DevolucaoInicio
        {
            get { return mDt_DevolucaoInicio; }
            set { mDt_DevolucaoInicio = value; }
        }
        public string Dt_DevolucaoFim
        {
            get { return mDt_DevolucaoFim; }
            set { mDt_DevolucaoFim = value; }
        }
        public string Nm_Equipamento
        {
            get { return mNm_Equipamento; }
            set { mNm_Equipamento = value; }
        }       
        public string Nm_Locatario
        {
            get { return mNm_Locatario; }
            set { mNm_Locatario = value; }
        }       
        public string Nm_LocadorSaida
        {
            get { return mNm_LocadorSaida; }
            set { mNm_LocadorSaida = value; }
        }
        public string Nm_LocadorDevolucao
        {
            get { return mNm_LocadorDevolucao; }
            set { mNm_LocadorDevolucao = value; }
        }       
        public int Ds_Status
        {
            set { mDs_Status = value; }
            get { return mDs_Status; }
        }


        public static string NomeResult = string.Empty;
        public static int IdResult = 0;
        public static string ProntuarioResult = string.Empty;

        
        public override string Grid()
        {
            conexao = new ClsConexao(); 
            
            try
            {                                  
                SqlCommand cmd = new SqlCommand("sp_Grid_Relatorio", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                if (!string.IsNullOrWhiteSpace(Dt_SaidaInicio))
                {
                    cmd.Parameters.AddWithValue("@pDt_SaidaInicio", Convert.ToDateTime(Dt_SaidaInicio));
                    cmd.Parameters.AddWithValue("@pDt_SaidaFim", Convert.ToDateTime(Dt_SaidaFim));
                }
                else
                {
                    cmd.Parameters.AddWithValue("@pDt_SaidaInicio", "");
                    cmd.Parameters.AddWithValue("@pDt_SaidaFim", "");
                }

                if (!string.IsNullOrWhiteSpace(Dt_DevolucaoFim))
                {
                    cmd.Parameters.AddWithValue("@pDt_DevolucaoInicio", Convert.ToDateTime(Dt_DevolucaoInicio));
                    cmd.Parameters.AddWithValue("@pDt_DevolucaoFim", Convert.ToDateTime(Dt_DevolucaoFim));
                }
                else
                {
                    cmd.Parameters.AddWithValue("@pDt_DevolucaoInicio", "");
                    cmd.Parameters.AddWithValue("@pDt_DevolucaoFim", "");
                }
                
                cmd.Parameters.AddWithValue("@pNm_Equipamento", Nm_Equipamento);
                cmd.Parameters.AddWithValue("@pNm_Locatario", Nm_Locatario);
                cmd.Parameters.AddWithValue("@pNm_LocadorSaida", Nm_LocadorSaida);
                cmd.Parameters.AddWithValue("@pNm_LocadorDevolucao", Nm_LocadorDevolucao);
                cmd.Parameters.AddWithValue("@pDs_Status", Ds_Status);
                cmd.Parameters.AddWithValue("@pID_Equipamento", ID_Equipamento);
                cmd.Parameters.AddWithValue("@pID_Locador_Devolucao", ID_Locador_Devolucao);
                cmd.Parameters.AddWithValue("@pID_Locador_Saida", ID_Locador_Saida);
                cmd.Parameters.AddWithValue("@pID_Locatario_Saida", ID_Locatario_Saida);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                Dt = new DataTable();
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
        public string Grid(string nome)
        {
            conexao = new ClsConexao();

            try
            {
                
                SqlCommand cmd = new SqlCommand("sp_Grid_EquipamentoRelatorio", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNm_Equipamento", nome);
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
                Ds = new DataSet();
                //Dt = new DataTable();
                da.Fill(Ds);
                //da.Fill(Dt);
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


        public override string Consultar()
        {
            throw new NotImplementedException();
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
