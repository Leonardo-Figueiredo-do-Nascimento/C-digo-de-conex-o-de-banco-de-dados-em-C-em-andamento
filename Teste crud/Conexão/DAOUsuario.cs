using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Teste_crud.Modelos;
using System.Collections.Generic;

namespace Teste_crud.Conexão
{
    class DAOUsuario
    {   
         
        public void inserir(Usuario usuario)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BSA3PC1\\SQLEXPRESS; Initial Catalog=Teste_crud; Integrated Security=true;");
            conn.Open();

            string insert = "INSERT INTO tb_usuario(id,nome,idade,endereço) VALUES ('"+usuario.Id.ToString()+"','"+ usuario.Nome.ToString() + "','"+ usuario.Idade.ToString() +"','" + usuario.Endereço.ToString()+"')";
                
            SqlCommand cmd = new SqlCommand(insert,conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Inserção realizada com sucesso!");
            conn.Close();
        }

        public void deletar(Usuario usuario)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BSA3PC1\\SQLEXPRESS; Initial Catalog=Teste_crud; Integrated Security=true;");
            conn.Open();

            string delete = "DELETE FROM tb_usuario WHERE nome = '"+usuario.Nome.ToString()+"'";

            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Usuario deletado com sucesso!");
            conn.Close();
        }

        public void alterarNome(Usuario usuario, string nome)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BSA3PC1\\SQLEXPRESS; Initial Catalog=Teste_crud; Integrated Security=true;");
            conn.Open();

            string update = "UPDATE tb_usuario SET nome ="+nome.ToString()+" WHERE id = '" + usuario.Id.ToString() + "'";

            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Nome alterado com sucesso!");
            conn.Close();
        }

        public void listar(Usuario usuario)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-BSA3PC1\\SQLEXPRESS; Initial Catalog=Teste_crud; Integrated Security=true;");
            conn.Open();

            string listar = "SELECT * FROM tb_usuario'" + usuario.Nome.ToString() + "'";

            SqlCommand cmd = new SqlCommand(listar, conn);
            cmd.ExecuteNonQuery();

            List<Usuario> ls = new List<Usuario>();


            foreach(Usuario u in ls)
            {
                Console.WriteLine("id: "+ u.Id);
                Console.WriteLine("nome: "+u.Nome);
                Console.WriteLine("idade: "+u.Idade);
                Console.WriteLine("endereço: "+u.Endereço);
            }

            
            conn.Close();
            Console.ReadLine();
        }

    }
}
