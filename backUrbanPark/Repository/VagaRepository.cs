using backUrbanPark.Model;
using MySqlConnector;
using System.Data;

namespace backUrbanPark.Repository;

public static class VagaRepository
{
    /// <summary>
    /// Insere uma nova vaga no banco de dados.
    /// </summary>
    /// <param name="vaga"></param>
    /// <returns></returns>
    public static int InserirVaga(Vaga vaga)
    {
        string sql = "sp_inserir_vaga";
        using (var cmd = new MySqlCommand(sql))
        {
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@p_numero_vaga", vaga.NumeroVaga);
            cmd.Parameters.AddWithValue("@p_tipo", vaga.TipoVaga);
            cmd.Parameters.AddWithValue("@p_status", vaga.StatusVaga);

            return Banco.ExecutarComando(cmd);
        }
    }

    /// <summary>
    /// Busca uma vaga no banco de dados pelo seu ID.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Vaga? ListarVagaPorId(int id)
    {
        string sql = "sp_listar_vaga_por_id";

        using (var cmd = new MySqlCommand(sql))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_id", id);

            using (var reader = Banco.ExecutarConsulta(cmd))
            {
                Vaga vagaBanco = MapearVaga(reader);
            }
        }
        return null;
    }

    /// <summary>
    /// Retorna uma lista de todas as vagas cadastradas no banco de dados.
    /// </summary>
    /// <returns></returns>
    public static List<Vaga> ListarTodasVagas()
    {
        string sql = "sp_listar_todas_vagas";

        List<Vaga> vagas = new List<Vaga>();

        using (var cmd = new MySqlCommand(sql))
        {
            cmd.CommandType = CommandType.StoredProcedure;

            using (var reader = Banco.ExecutarConsulta(cmd))
            {
                while (reader.Read())
                {
                    vagas.Add(MapearVaga(reader));
                }
            }
        }
        return vagas;
    }

    /// <summary>
    /// Metodo auxiliar para mapear os dados do reader para um objeto Vaga.
    /// </summary>
    /// <param name="reader"></param>
    /// <returns></returns>
    private static Vaga MapearVaga(MySqlDataReader reader)
    {
        int id_vaga = reader.GetInt32("id_vaga");
        int numeroVaga = reader.GetInt32("numero_vaga");
        TipoVaga tipoVaga = Enum.Parse<TipoVaga>(reader["tipo"].ToString());
        StatusVaga statusVaga = Enum.Parse<StatusVaga>(reader["status"].ToString());
        
        return new Vaga(id_vaga, numeroVaga, tipoVaga, statusVaga);
    }

}
