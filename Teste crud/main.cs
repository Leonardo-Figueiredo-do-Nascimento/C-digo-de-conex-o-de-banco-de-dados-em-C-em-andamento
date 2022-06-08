using System;
using Teste_crud.Modelos;
using Teste_crud.Conexão;

namespace Teste_crud
{

    class main
    {
        static void Main(string[] args)
        {
            Usuario u1 = new Usuario();
            u1.Id = 1;
            u1.Nome = "Diego Santos";
            u1.Idade = 19;
            u1.Endereço = "Rua São paulo";

            DAOUsuario d1 = new DAOUsuario();
            d1.deletar(u1);
        }
    }
}

