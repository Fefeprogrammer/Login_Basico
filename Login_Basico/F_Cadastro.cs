using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_Basico.Classes;

namespace Login_Basico
{
    public partial class F_Cadastro : Form
    {
        Cadastro cadastro = new Cadastro();

        public F_Cadastro()
        {
            InitializeComponent();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_nome.Text = null;
            tb_senha.Text = null;
            tb_senha2.Text = null;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            cadastro.Cadastrar(tb_nome, tb_senha, tb_senha2);
        }
    }
}
