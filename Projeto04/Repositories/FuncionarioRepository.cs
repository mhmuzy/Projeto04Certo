using System;
using System.Collections.Generic;
using System.Text;
using Projeto04.Entities; //importando
using Projeto04.Contracts; //importando
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace Projeto04.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        //atributo 'somente leitura'
        private readonly string connectionString;

        //construtor -> ctor + 2x[tab]
        public FuncionarioRepository()
        {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=BDAula03b2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public void Inserir(Funcionario obj)
        {
            using (var connection = new SqlConnection())
            {
                connection.Execute("SP_InserirFuncionario", obj,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void Alterar(Funcionario obj)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute("SP_AlterarFuncionario", obj,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void Excluir(Funcionario obj)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute("SP_ExcluirFuncionario", obj,
                    commandType: CommandType.StoredProcedure);
            }
        }

        public List<Funcionario> Consultar()
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> Consultar(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> Consultar(decimal SalarioMin, decimal SalarioMax)
        {
            throw new NotImplementedException();
        }

        public Funcionario ObterPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
