using System;
using System.Collections.Generic;
using CelularCTI.Model.Entidades;
using CelularCTI.Model.Suporte;
using Npgsql;

namespace CelularCTI.Model
{
    public static class Servico
    {
        //Métodos Gerais criam objetos representando entidades carregando os respectivos dados

        private static Fabricante ObjFabricante(ref NpgsqlDataReader dtr)
        {
            Fabricante fab = new Fabricante();
            fab.Id_Fabricante = Convert.ToInt64(dtr["id_fabricante"]);
            fab.Nome = dtr["nome"].ToString();
            fab.Observacao = dtr["observacao"].ToString();
            return fab;
        }

        private static Aparelho ObjAparelho(ref NpgsqlDataReader dtr)
        {
            Aparelho a = new Aparelho();
            a.Id_Aparelho = Convert.ToInt64(dtr["id_aparelho"]);
            a.Modelo = (String)dtr["modelo"];
            a.Quantidade = Convert.ToDouble(dtr["quantidade"]);
            a.Largura = Convert.ToDouble(dtr["largura"]);
            a.Altura = Convert.ToDouble(dtr["altura"]);
            a.Espessura = Convert.ToDouble(dtr["espessura"]);
            a.Peso = Convert.ToDouble(dtr["peso"]);
            a.Preco = (decimal)(dtr["preco"]);
            a.Desconto = (decimal)(dtr["desconto"]);
            a.Fabricante = ObjFabricante(ref dtr);
            a.Obsercacao = dtr["observacao"].ToString();
            return a;
        }

        public static Pedido ObjPedido(ref NpgsqlDataReader dr)
        {
            Pedido ped = new Pedido();
            ped.Id_pedido = Convert.ToInt64(dr["id_pedido"]);
            ped.Datahorapedido = Convert.ToDateTime(dr["datahorapedido"]);
            ped.Observacao = dr["observacao"].ToString();

            ped.Aparelho = ObjAparelho(ref dr);

            return ped;
        }

        public static Cliente ObjCliente(ref NpgsqlDataReader dtr)
        {
            Cliente cli = new Cliente();
            cli.Id_Cliente = Convert.ToInt64(dtr["id_cliente"]);
            cli.Nome = dtr["nome"].ToString();
            cli.Email = dtr["email"].ToString().ToLower();
            cli.CPF = dtr["cpf"].ToString();
            cli.Login = dtr["login"].ToString();
            cli.Senha = dtr["senha"].ToString();
            return cli;

        }

        
        public static void Salvar(Aparelho ap)
        {
            String sql;
            List<object> param = new List<object>();

            if (ap.Id_Aparelho == 0)
            {
                sql = "INSERT INTO aparelho     " +
                              "(id_fabricante,  " +
                              "modelo,          " +
                              "largura,         " +
                              "altura,          " +
                              "espessura,       " +
                              "peso,            " +
                              "quantidade,      " +
                              "preco,           " +
                              "desconto)        " +
                       "VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9) ";


                param.Add(ap.Fabricante.Id_Fabricante);
                param.Add(ap.Modelo);
                param.Add(ap.Largura);
                param.Add(ap.Altura);
                param.Add(ap.Espessura);
                param.Add(ap.Peso);
                param.Add(ap.Quantidade);
                param.Add(ap.Preco);
                param.Add(ap.Desconto);
                ConexaoBanco.Executar(sql, param);
            }
            else
            {
                sql = "UPDATE aparelho SET " +
                            "id_fabricante  = @1 " +
                            "modelo         = @2 " +
                            "largura        = @3 " +
                            "altura         = @4 " +
                            "espessura      = @5" +
                            "peso           = @6" +
                            "quantidade     = @7" +
                            "preco          = @8" +
                            "desconto       = @9" +
                        "WHERE id_aparelho  = @10";

                param.Add(ap.Fabricante.Id_Fabricante);
                param.Add(ap.Modelo);
                param.Add(ap.Largura);
                param.Add(ap.Altura);
                param.Add(ap.Espessura);
                param.Add(ap.Peso);
                param.Add(ap.Quantidade);
                param.Add(ap.Preco);
                param.Add(ap.Desconto);
                param.Add(ap.Id_Aparelho);

                ConexaoBanco.Executar(sql);
            }
        }

        public static void Salvar(Cliente cliente)
        {
            string sql;
            List<object> param = new List<object>();

            if (cliente.Id_Cliente == 0)
            {
                sql = "INSERT INTO cliente " +
                        "(nome, cpf, email, login, senha, id_cliente) " +
                        "VALUES (@1, @2, @3, @4, @5, @6) ";

                param.Add(cliente.Nome);
                param.Add(cliente.CPF);
                param.Add(cliente.Email);
                param.Add(cliente.Login);
                param.Add(cliente.Senha);
                param.Add(cliente.Id_Cliente);
                ConexaoBanco.Executar(sql, param);
            }
            else
            {
                sql = "UPDATE aparelho SET   " +
                            "nome         = @1 " +
                            "cpf          = @2 " +
                            "email        = @3 " +
                            "login        = @4 " +
                            "senha        = @5 " +
                        "WHERE id_cliente = @6";

                param.Add(cliente.Nome);
                param.Add(cliente.CPF);
                param.Add(cliente.Email);
                param.Add(cliente.Login);
                param.Add(cliente.Senha);
                param.Add(cliente.Id_Cliente);

            }
        }

        //---------------------------------Métodos de Pesquisa---------------------------------------

        public static Aparelho BuscarAparelho(Int64 id)
        {
            string sql;
            Aparelho aparelho = new Aparelho();

            sql = "SELECT aparelho.*, fabricante.* " +
                "FROM aparelho INNER JOIN fabricante " +
                "ON aparelho.id_fabricante = fabricante.id_fabricante " +
                "WHERE aparelho.id_aparelho = " + id;

            NpgsqlDataReader dtr = ConexaoBanco.Selecionar(sql);
            dtr.Read();
            aparelho = ObjAparelho(ref dtr);
            dtr.Close();

            return aparelho;
        }

        public static List<Aparelho> BuscarAparelho()
        {
            string sql;
            List<Aparelho> aparelho = new List<Aparelho>();

            sql = "SELECT aparelho.*, fabricante.* " +
                "FROM aparelho INNER JOIN fabricante " +
                "ON aparelho.id_fabricante = fabricante.id_fabricante " +
                "ORDER BY fabricante.nome, aparelho.modelo ";

            NpgsqlDataReader dtr = ConexaoBanco.Selecionar(sql);
            while (dtr.Read())
                aparelho.Add(ObjAparelho(ref dtr));
            dtr.Close();

            return aparelho;
        }

        public static List<Aparelho> BuscarAparelho(string modelo)
        {
            string sql;
            List<Aparelho> aparelho = new List<Aparelho>();

            sql = "SELECT aparelho.*, fabricante.* " +
                "FROM aparelho INNER JOIN fabricante " +
                "ON aparelho.id_fabricante = fabricante.id_fabricante " +
                "WHERE aparelho.modelo ILIKE '%" + modelo + "%' " +
                "ORDER BY aparelho.modelo";

            NpgsqlDataReader dtr = ConexaoBanco.Selecionar(sql);
            while (dtr.Read())
                aparelho.Add(ObjAparelho(ref dtr));
            dtr.Close();

            return aparelho;
        }

        public static List<Aparelho> BuscarAparelho(decimal precoMin, decimal precoMax)
        {
            string sql;
            List<Aparelho> aparelho = new List<Aparelho>();
            List<object> param = new List<object>();

            sql = "SELECT aparelho.*, fabricante.* " +
                "FROM aparelho INNER JOIN fabricante " +
                "ON aparelho.id_fabricante = fabricante.id_fabricante " +
                "WHERE aparelho.preco BETWEEN @1 AND @2 " +
                "ORDER BY aparelho.preco";

            param.Add(precoMin);
            param.Add(precoMax);

            NpgsqlDataReader dtr = ConexaoBanco.Selecionar(sql, param);
            while (dtr.Read())
                aparelho.Add(ObjAparelho(ref dtr));
            dtr.Close();

            return aparelho;
        }

        public static List<Aparelho> BuscarAparelho(Fabricante f)
        {
            List<Aparelho> aparelhos = new List<Aparelho>();
            NpgsqlDataReader dtr = ConexaoBanco.Selecionar(
                "SELECT * FROM aparelho " +
                "INNER JOIN fabricante ON fabricante.id_fabricante = aparelho.id_fabricante " +
                "WHERE fabricante.id_fabricante=" + f.Id_Fabricante);
            while (dtr.Read())
                aparelhos.Add(ObjAparelho(ref dtr));
            dtr.Close();
            return aparelhos;
        }

        public static List<Cliente> BuscarCliente()
        {
            string sql;
            List<Cliente> cliente = new List<Cliente>();
            sql = "SELECT * FROM cliente " +
                    "ORDER BY nome";
            /*NÃO TEM PARÂMETRO*/
            NpgsqlDataReader dtr = ConexaoBanco.Selecionar(sql);
            while (dtr.Read())
                cliente.Add(ObjCliente(ref dtr));
            dtr.Close();

            return cliente;
        }

        public static List<Cliente> BuscarCliente(string nome)
        {
            /*"SELECT aparelho.*, fabricante.* " O .* serve para listar todos os campos que
             estiverem da tabela*/
            string sql;
            List<Cliente> cliente = new List<Cliente>();
            sql = "SELECT * FROM cliente " +
                    "WHERE nome ILIKE '%" + nome + "%' " +
                    "ORDER BY nome";
            NpgsqlDataReader dtr = ConexaoBanco.Selecionar(sql);
            while (dtr.Read())
                cliente.Add(ObjCliente(ref dtr));
            dtr.Close();

            return cliente;
        }

        public static Cliente BuscarClienteCPF(string cpf)
        {
            string sql;
            Cliente cliente = new Cliente();
            sql = "SELECT * FROM cliente " +
                    "WHERE cpf = '" + cpf + "'";
            NpgsqlDataReader dtr = ConexaoBanco.Selecionar(sql);
            dtr.Read();
            cliente = ObjCliente(ref dtr);
            dtr.Close();

            return cliente;
        }

        public static List<Fabricante> BuscarFabricante()
        {
            string sql;
            List<Fabricante> fabricante = new List<Fabricante>();

            sql = "SELECT * FROM fabricante " +
                     "ORDER BY nome";

            NpgsqlDataReader dtr = ConexaoBanco.Selecionar(sql);
            while (dtr.Read())
                fabricante.Add(ObjFabricante(ref dtr));
            dtr.Close();

            return fabricante;
        }

        public static Pedido FazerPedido(Aparelho ap, string observacao)
        {
            Pedido p = new Pedido();

            try
            {
                p.Aparelho = ap;
                p.Datahorapedido = DateTime.Now;

                String sql = "INSERT INTO pedido (id_aparelho, datahorapedido, observacao) " +
                            "VALUES (" + ap.Id_Aparelho +
                            ", '" + p.Datahorapedido.ToString("yyyy-MM-dd hh:mm:ss") +
                            "', '" + observacao + "')";

                ConexaoBanco.Executar(sql);

                // Dando baixa no estoque do aparelho
                ap.Quantidade--;
                Salvar(ap);

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Não foi ´possível efetivar o pedido  da compra!"
                                                + "\n\nMais detalhes: " + ex.Message);
            }
            return p;
        }
    }
}