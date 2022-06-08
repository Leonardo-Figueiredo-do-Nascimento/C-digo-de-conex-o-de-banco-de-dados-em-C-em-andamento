using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Teste_crud.Modelos;

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
    }
}
