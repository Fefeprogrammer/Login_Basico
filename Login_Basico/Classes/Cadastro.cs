using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Login_Basico.Classes
{
    class Cadastro
    {
        StreamWriter x;

        private string CaminhoNome = "C:\\Users\\FELIPE\\source\\repos\\usuarios.txt";

        public void Cadastrar(TextBox nome, TextBox senha1, TextBox senha2)
        {
            x = File.CreateText(CaminhoNome);

            x.WriteLine(nome.Text);
            x.WriteLine();
            x.WriteLine(senha1.Text);
            x.WriteLine();
            x.WriteLine(senha2.Text);
            x.WriteLine();

            x.Close();
        }
    }
}
