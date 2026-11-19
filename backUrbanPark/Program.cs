using backUrbanPark.Model;
using backUrbanPark.Repository;

namespace backUrbanPark;

internal class Program
{
    static void Main(string[] args)
    {
        List<Vaga> vagas = new VagaRepository().ListarTodas();

        foreach (var vaga in vagas)
        {
            Console.WriteLine($"Id: {vaga.Id}, NumeroVaga: {vaga.NumeroVaga}, TipoVaga: {vaga.TipoVaga}, StatusVaga: {vaga.StatusVaga}\n");
        }
    }
}
