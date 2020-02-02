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
    public partial class FrmInfo : Form
    {
        public FrmInfo(string msg)
        {
            InitializeComponent();
            lbl.Text = msg;
        }


       // string msgFormInfo = "Nesta tela você pode fazer buscas de equipamentos, usuarios do sistemas (vistos de entrada e saida), ";

        private void carregarMenssagem(string qualForm)
        {


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}