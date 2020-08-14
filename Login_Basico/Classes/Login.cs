using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Login_Basico.Classes
{
    class Login
    {
        public Login(TextBox usuario, TextBox senha)
        {
            StreamReader x;

            string caminho = "C:\\Users\\FELIPE\\source\\repos\\usuarios.txt";

            x = File.OpenText(caminho);

            string linha = x.ReadLine();

            x.Close();

            if(usuario.Text == linha && senha.Text == linha)
            {
                F_Principal principal = new F_Principal();
                principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario e/ou senha invalido");
            }
        }
    }
}
