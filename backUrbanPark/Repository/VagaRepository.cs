using backUrbanPark.Model;
using MySqlConnector;
using System.Data;

namespace backUrbanPark.Repository;

public class VagaRepository
{
    /// <summary>
    /// Insere uma nova vaga no banco de dados.
    /// </summary>
    /// <param name="vaga"></param>
    /// <returns></returns>
    public int Inserir(Vaga vaga)
    {
        return 1;
    }

    public Vaga? BuscarPorId(int id)
    {
        string sql = "sp_buscarVagaPorId";

        using (var cmd = new MySqlCommand(sql))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

            using (var reader = Banco.ExecutarConsulta(cmd))
            {
                Vaga vagaBanco = new Vaga();

                vagaBanco.Id = reader.GetInt32("id_vaga");
                vagaBanco.NumeroVaga = reader.GetInt32("numero_vaga");
                vagaBanco.TipoVaga = Enum.Parse<TipoVaga>(reader["tipo"].ToString());
                vagaBanco.StatusVaga = Enum.Parse<StatusVaga>(reader["status"].ToString());

                return vagaBanco;
            }
        }
    }
}
