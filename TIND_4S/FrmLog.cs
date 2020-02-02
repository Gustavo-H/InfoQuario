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
    public partial class FrmLog : Form
    {
        public FrmLog()
        {
            InitializeComponent();
            carregarLog();
        }

        ClsLog log = new ClsLog();


        private void carregarLog()
        {
            string r = log.Grid();
            if (r == "OK")
            {
                gridReport.DataSource = log.Dt;
                gridReport.ReadOnly = true;
                gridReport.Columns[0].HeaderText = "Nome";
                gridReport.Columns[1].HeaderText = "Descrição do Uso";
                gridReport.Columns[2].HeaderText = "Data";

                gridReport.AutoResizeColumns();

                gridReport.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridReport.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridReport.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
                if (MessageBox.Show("Ocorreu um erro ao carregar o registro!\n\n Clique Sim Para Ver os Detalhes", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Error).ToString().ToUpper() == "YES")
                    MessageBox.Show(r, "Descrição Completa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void alterarPosicaoLblTitulo()
        {
            int sobra = gridReport.Size.Width - lblTitulo.Size.Width;
            if (sobra % 2 == 0)
            {
                lblTitulo.Left = (sobra / 2) - 20;
            }
            else
            {
                sobra--;
                lblTitulo.Left = (sobra / 2) -19;
            }
        }

        private void FrmLog_Resize(object sender, EventArgs e)
        {
            alterarPosicaoLblTitulo();
        }       
    }
}
