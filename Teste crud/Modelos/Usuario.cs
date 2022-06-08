using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_crud.Modelos
{
    class Usuario
    {
        private int id;
        private string nome;
        private int idade;
        private string endereço;


        public string Nome { get; set; }
        public int Id { get; set; }
        public int Idade { get; set; }
        public string Endereço { get; set; }

    }
}
