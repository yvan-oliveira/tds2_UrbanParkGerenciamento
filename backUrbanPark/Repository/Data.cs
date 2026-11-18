using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backUrbanPark.Repository;

public static class Data
{
    // String de conexão com os dados do servidor MySQL/MariaDB
    private static readonly string stringDeConexao = "Server=10.91.45.58;Port=3306;Database=urbanpark;Uid=admin;Pwd=12345678";

    /// <summary>
    /// Testa a conexão com o banco de dados e exibe a versão atual.
    /// </summary>
    public static void TestarConexao()
    {
        // O bloco 'using' garante que a conexão será fechada e descartada da memória automaticamente
        using (var connection = new MySqlConnection(stringDeConexao))
        {
            try
            {
                Console.WriteLine("Tentando conectar ao banco de dados...");

                // Abre a conexão com o servidor
                connection.Open();

                Console.WriteLine("Conexão bem sucedida!");

                // Executa um comando simples para descobrir a versão do banco
                using (var command = new MySqlCommand("SELECT VERSION();", connection))
                {
                    string? version = command.ExecuteScalar()?.ToString();
                    Console.WriteLine($"Versão do Servidor: {version}");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao conectar no banco de dados.");
                Console.WriteLine(ex.Message);
            }
        }
    }

    /// <summary>
    /// Executa comandos que modificam dados (INSERT, UPDATE, DELETE).
    /// Retorna a quantidade de linhas afetadas ou -1 em caso de erro.
    /// </summary>
    public static int ExecutarComando(MySqlCommand command)
    {
        using (var conexao = new MySqlConnection(stringDeConexao))
        {
            // Associa o comando à conexão aberta
            command.Connection = conexao;

            try
            {
                conexao.Open();

                // ExecuteNonQuery executa a instrução e retorna o número de linhas alteradas
                return command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Erro de Banco de Dados: {ex.Message}");
                return -1;
            }
        }
    }

    /// <summary>
    /// Executa comandos (geralmente INSERT) e retorna o ID gerado automaticamente pela tabela.
    /// </summary>
    public static int ExecutarComandoRetornandoId(MySqlCommand command)
    {
        using (var conexao = new MySqlConnection(stringDeConexao))
        {
            command.Connection = conexao;

            try
            {
                conexao.Open();

                // ExecuteScalar pega apenas o primeiro valor retornado pela consulta (ex: SELECT LAST_INSERT_ID())
                object objRetorno = command.ExecuteScalar();

                // Valida se o retorno não é nulo (nem nulo do C# e nem DBNull do banco)
                if (objRetorno != null && objRetorno != DBNull.Value)
                {
                    // Converte o resultado para inteiro com segurança
                    return Convert.ToInt32(objRetorno);
                }

                return 0;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Erro de Banco de Dados: {ex.Message}");
                return -1;
            }
        }
    }

    /// <summary>
    /// Executa consultas (SELECT) e retorna um leitor de dados (MySqlDataReader).
    /// </summary>
    public static MySqlDataReader ExecutarConsulta(MySqlCommand command)
    {
        // ATENÇÃO: Aqui NÃO usamos o 'using' na conexão porque precisamos que ela 
        // continue aberta enquanto a tela/classe externa estiver lendo os dados linha por linha.
        var conexao = new MySqlConnection(stringDeConexao);
        command.Connection = conexao;

        try
        {
            conexao.Open();

            // O CommandBehavior.CloseConnection fecha a conexão automaticamente 
            // assim que o leitor de dados for fechado lá no código que chamou este método.
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }
        catch (MySqlException ex)
        {
            // Se der erro ao abrir, fechamos a conexão manualmente para liberar a memória
            conexao.Dispose();
            Console.WriteLine($"Erro na leitura do banco de dados: {ex.Message}");

            // Relança o erro para que a aplicação saiba que a consulta falhou
            throw;
        }
    }
}
