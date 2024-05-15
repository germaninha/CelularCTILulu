using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.Model.Entidades
{
    public class Cliente
    {
        /*private Int64 id_Cliente;
        private string nome;
        private string email;

        public Int64 Id_Cliente { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }*/

        private Int64 id_cliente;
        /*Qual é a diferença entre 'String' e 'string'?*/
        private string nome;
        private string cpf;
        private string email;
        private string login;
        private string senha;

        public Int64 Id_Cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}
