using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backUrbanPark.Model;

public class Vaga
{
    private int _id;
    private int _numeroVaga;
    private TipoVaga _tipoVaga;
    private StatusVaga _statusVaga;

    public int Id { get => _id; set => _id = value; }
    public int NumeroVaga { get => _numeroVaga; set => _numeroVaga = value; }
    public TipoVaga TipoVaga { get => _tipoVaga; set => _tipoVaga = value; }
    public StatusVaga StatusVaga { get => _statusVaga; set => _statusVaga = value; }

    public Vaga(int numeroVaga, TipoVaga tipoVaga, StatusVaga statusVaga)
    {
        NumeroVaga = numeroVaga;
        TipoVaga = tipoVaga;
        StatusVaga = statusVaga;
    }

    public Vaga(int id, int numeroVaga, TipoVaga tipoVaga, StatusVaga statusVaga)
    {
        Id = id;
        NumeroVaga = numeroVaga;
        TipoVaga = tipoVaga;
        StatusVaga = statusVaga;
    }


}
