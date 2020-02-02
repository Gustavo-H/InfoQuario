using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIND_4S
{
    public partial class FrmBuscarDados : Form
    {
        public FrmBuscarDados(string tipoBusca)
        {
            InitializeComponent();
            this.Text = tipoBusca;
            lblMensagem.Text = tipoBusca;

            if (tipoBusca == "Buscando Nome Equipamento")
            {
                txtProntuario.Visible = false;
                lblProntuario.Visible = false;
            }

            txtNome.text = ClsRelatorio.NomeResult;
            txtProntuario.text = ClsRelatorio.ProntuarioResult;
            buscar();

        }

        
        Image imgBKP;

        ClsRelatorio Relatorio = new ClsRelatorio();        
        ClsUsuario user = new ClsUsuario();

        

        private void buscar()
        {
            try
            {
                switch (this.Text)
                {
                    case "Buscando Nome Equipamento":
                        {
                            if (Relatorio.Grid(txtNome.text) == "OK")
                            {
                                gridDados.DataSource = Relatorio.Ds.Tables[0];
                                gridDados.ReadOnly = true;
                                gridDados.Columns[0].HeaderText = "ID";
                                gridDados.Columns[1].HeaderText = "Nome";

                                gridDados.Columns[0].Visible = false;
                                gridDados.Columns[0].Width = 0;

                                gridDados.AutoResizeColumns();

                                gridDados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                gridDados.Enabled = true;
                            }
                        }
                        break;

                    case "Buscando Solicitante":
                        {                            
                            Relatorio.Grid(txtNome.text, txtProntuario.text);                                 

                            gridDados.DataSource = Relatorio.Ds.Tables[0];
                            gridDados.ReadOnly = true;
                            gridDados.Columns[0].HeaderText = "ID";
                            gridDados.Columns[1].HeaderText = "Nome";
                            gridDados.Columns[2].HeaderText = "R.A.";

                            gridDados.Columns[0].Visible = false;
                            gridDados.Columns[0].Width = 0;

                            gridDados.AutoResizeColumns();

                            gridDados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                        break;

                    default:
                        {
                            user.Nm_Usuario = txtNome.text;
                            user.Ds_Prontuario = txtProntuario.text;

                            if (user.Grid() == "OK")
                            {
                                gridDados.DataSource = user.Ds.Tables[0];
                                gridDados.ReadOnly = true;
                                gridDados.Columns[0].HeaderText = "ID";
                                gridDados.Columns[1].HeaderText = "Nome";
                                gridDados.Columns[2].HeaderText = "R.A.";

                                gridDados.Columns[0].Visible = false;
                                gridDados.Columns[0].Width = 0;

                                gridDados.AutoResizeColumns();

                                gridDados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            }                          
                                
                        }
                        break;
                }
                //if(gridDados.RowCount < 1)
                  //  gridDados.AllowUserToAddRows]

            }
            catch(Exception ex)
            {
                if (MessageBox.Show("Ocorreu um erro ao buscar\nos dados no banco de dados\n\nClique sim para ver a descrição completa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString().ToUpper() == "YES")
                    MessageBox.Show(ex.ToString(), "Descrição Detalhada");
            }
        }   


        private void IMGCloseRED_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            imgBKP = btnClose.Image;
            btnClose.Image = IMG_RED.Image;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = imgBKP;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void selecionarItem(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    if (MessageBox.Show("Deseja Mesmo Selecionar o Nome :\n" + gridDados.CurrentRow.Cells[1].Value.ToString(), "Atenção",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1).ToString().ToUpper() == "YES")
                    {
                        ClsRelatorio.NomeResult = gridDados.CurrentRow.Cells[1].Value.ToString();
                        ClsRelatorio.IdResult = int.Parse(gridDados.CurrentRow.Cells[0].Value.ToString());
                        if (gridDados.CurrentRow.Cells.Count > 2)
                            ClsRelatorio.ProntuarioResult = gridDados.CurrentRow.Cells[2].Value.ToString();
                        this.Close();
                    }
                }
            }
            catch { }            
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.text == "Nome")
                txtNome.text = string.Empty;
            if (txtProntuario.text == "Prontuario")
                txtProntuario.text = string.Empty;

            if (txtNome.text.Contains("\n"))
                MessageBox.Show("sd");
        }

        private void txtNome_txtProntuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;

            if (this.Text == "Buscando Nome Equipamento")
                msg = "-- Digite no campo nome, o nome do item ou o tipo dele.\n" +
                      "-- Exemplo: Caso você esteja procurando pela Sala de Aula 5,\n" +
                      "   Ao começar digitar \"Sala \" o sistema trará todas as salas que\n" +
                      "   se enquadram em sua busca.\n\n" +

                      "-- Quanto mais você digita mais resumido fica os resultados.\n\n" +

                      "-- Para Escolher um resultado basta dar um clique sobre o resultado.\n" +
                      "   você sera consultado se deseja mesmo este resultado,\n" +
                      "   basta clicar sim para seleciona-lo.";
            else
                msg = "-- Digite no campo nome, o nome do pessoa que deseja procurar.\n" +
                      "-- Digite no campo prontuario, o prontuario do pessoa.\n" +
                      "-- Exemplo: Caso você esteja procurando por josé Da Silva,\n" +
                      "   Ao começar digitar \"José ...\" o sistema trará os nomes que\n" +
                      "   se enquadram em sua busca.\n\n" +

                      "-- Quanto mais você digita mais resumido fica os resultados.\n\n" +

                      "-- Para Escolher um resultado basta dar um clique sobre o resultado.\n" +
                      "   você sera consultado se deseja mesmo este resultado,\n" +
                      "   basta clicar sim para seleciona-lo.";


            FrmInfo info = new FrmInfo(msg);
            info.ShowDialog();

        }

        private void FrmBuscarDados_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 8000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.txtNome, "Digite aqui um nome para buscar");
            toolTip1.SetToolTip(this.txtProntuario, "Digite aqui um prontuario para buscar");
            toolTip1.SetToolTip(this.gridDados, "Dê 1 Clique Para Escolher");
            toolTip1.SetToolTip(this.btnInfo, "Clique Abrir a Ajuda e Dicas");
        }
    }
}
