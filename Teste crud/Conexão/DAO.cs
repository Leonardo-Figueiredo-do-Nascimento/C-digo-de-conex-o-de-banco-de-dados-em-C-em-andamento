using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Teste_crud.Conexão
{
    class DAO
    {
        public string connection = "Data Source=DESKTOP-BSA3PC1\\SQLEXPRESS; Initial Catalog=Teste_crud; Integrated Security=true;";

        public SqlConnection conectar()
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Conexão bem sucedida");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Deu merda");
                    Console.ReadLine();
                }
                
                return conn;
            }
        }

        public void salvar()
        {

        }


    }
}
