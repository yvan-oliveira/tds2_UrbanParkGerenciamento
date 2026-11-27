using backUrbanPark.Model.DTO;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backUrbanPark.Repository
{
    public static class EntradaRepository
    {
        /// <summary>
        /// Busca os dados do veículo e do cliente para preencher a tela de entrada.
        /// Retorna null quando a placa não estiver cadastrada.
        /// </summary>
        public static DadosEntradaVeiculo? BuscarDadosPorPlaca(string placa)
        {
            const string sql = @"
                SELECT
                    c.id_cliente AS IdCliente,
                    c.nome AS NomeCliente,
                    v.id_veiculo AS IdVeiculo,
                    v.placa AS Placa,
                    v.modelo AS Modelo,
                    v.cor AS Cor
                FROM veiculos AS v
                INNER JOIN clientes AS c
                    ON c.id_cliente = v.id_cliente
                WHERE v.placa = @placa
                LIMIT 1;";

            using var comando = new MySqlCommand(sql);
            comando.Parameters.AddWithValue("@placa", placa);

            using var leitor = Banco.ExecutarConsulta(comando);

            if (!leitor.Read())
                return null;

            return new DadosEntradaVeiculo
            {
                IdCliente = leitor.GetInt32("IdCliente"),
                NomeCliente = leitor.GetString("NomeCliente"),
                IdVeiculo = leitor.GetInt32("IdVeiculo"),
                Placa = leitor.GetString("Placa"),
                Modelo = leitor.GetString("Modelo"),
                Cor = leitor.IsDBNull(leitor.GetOrdinal("Cor"))
                    ? null
                    : leitor.GetString("Cor")
            };
        }
    }
}
