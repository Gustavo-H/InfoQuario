using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TIND_4S
{
    class ClsEquipamento : ClsCrud
    {
        private int mID_Equipamento;
        private string mNm_Equipamento;
        private int mNr_Equipamento;
        private string mDs_Tipo;

        public int ID_Equipamento
        {
            get { return mID_Equipamento; }
            set { mID_Equipamento = value; }
        }
        public string Nm_Equipamento
        {
            get { return mNm_Equipamento; }
            set { mNm_Equipamento = value; }
        }
        public int Nr_Equipamento
        {
            get { return mNr_Equipamento; }
            set { mNr_Equipamento = value; }
        }
        public string Ds_Tipo
        {
            get { return mDs_Tipo; }
            set { mDs_Tipo = value; }
        }

        public override string Atualizar()
        {
            conexao = new ClsConexao();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_Upd_Equipamento", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNm_Equipamento", Nm_Equipamento);
                cmd.Parameters.AddWithValue("@pDs_Tipo", Ds_Tipo);
                cmd.Parameters.AddWithValue("@pNr_Equipamento", Nr_Equipamento);
                cmd.Parameters.AddWithValue("@pID_Equipamento", ID_Equipamento);
                if (cmd.ExecuteNonQuery() > 0)
                    return "OK";
                else
                    return "Erro Desconhecido";
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
        public override string Consultar()
        {
            conexao = new ClsConexao();

            try
            {
                
                SqlCommand cmd = new SqlCommand("sp_Sel_Equipamento", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;                
                cmd.Parameters.AddWithValue("@pID_Equipamento", ID_Equipamento);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Nm_Equipamento = dr["Nome"].ToString();
                    Nr_Equipamento = int.Parse(dr["Numero"].ToString());
                    Ds_Tipo = dr["Tipo"].ToString();
                    return "OK";
                }
                else
                {
                     return "Erro Sem Explicação";                   
                }
            }
            catch (Exception ex)
            {
                conexao.desconectar();
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
                SqlCommand cmd = new SqlCommand("sp_Grid_Equipamento", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNm_Equipamento", Nm_Equipamento);
                cmd.Parameters.AddWithValue("@pNr_Equipamento", Nr_Equipamento);
                cmd.Parameters.AddWithValue("@pDs_Tipo", Ds_Tipo);
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
                SqlCommand cmd = new SqlCommand("sp_Ins_Equipamento", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNm_Equipamento", Nm_Equipamento);
                cmd.Parameters.AddWithValue("@pDs_Tipo", Ds_Tipo);
                cmd.Parameters.AddWithValue("@pNr_Equipamento", Nr_Equipamento);      
                
                if (cmd.ExecuteNonQuery() > 0)
                    return "OK";
                else
                    return "Erro Sem Explicação";
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
                SqlCommand cmd = new SqlCommand("sp_Del_Equipamento", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pID_Equipamento", ID_Equipamento);
                if (cmd.ExecuteNonQuery() > 0)
                    return "OK";
                else               
                    return "Erro Desconhecido";                
            }
            catch (Exception ex)
            {
                conexao.desconectar();
                return ex.ToString();
            }
            finally
            {
                conexao.desconectar();
            }
        }
        public string ConsultarExistente()
        {
            conexao = new ClsConexao();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_Sel_EquipamentoExistente", conexao.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNm_Equipamento", Nm_Equipamento);
                cmd.Parameters.AddWithValue("@pNr_Equipamento", Nr_Equipamento);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                    return "true";
                else
                    return "false";                
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
    }
}
