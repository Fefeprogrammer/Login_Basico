﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Login_Basico.Classes;

namespace Login_Basico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login(tb_usuario, tb_senha);
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            F_Cadastro cadastro = new F_Cadastro();
            cadastro.ShowDialog();
        }
    }
}
