using Dapper;
using MiniChef.Domain.IRepository;
using MiniChef.Domain.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniChef.Repository
{
    public class UserRepository : IUserRepository
    {
        private string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        public async Task<User> CreateUserRepository(User user)
        {
            // Validação de entrada
            if (string.IsNullOrWhiteSpace(user.nome))
            {
                throw new ArgumentException("O campo 'nome' é obrigatório.");
            }

            if (string.IsNullOrWhiteSpace(user.senha) || user.senha.Length < 6)
            {
                throw new ArgumentException("A senha deve ter pelo menos 6 caracteres.");
            }

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                var sql = "INSERT INTO Users (nome, senha) VALUES (@Nome, @Senha) RETURNING id";
                var userId = await connection.ExecuteScalarAsync<int>(sql, user);

                user.id = userId;
            }

            return user;
        }

        //public async Task<User> CreateUserRepository(User user)
        //{

        //    using (var connection = new NpgsqlConnection(_connectionString))
        //    {
        //        await connection.OpenAsync();

        //        var sql = "INSERT INTO Users (nome, senha) VALUES (@Nome, @Senha) RETURNING id";
        //        var userId = await connection.ExecuteScalarAsync<int>(sql, user);

        //        user.id = userId;
        //    }

        //    return user;
        //}

    }
}

