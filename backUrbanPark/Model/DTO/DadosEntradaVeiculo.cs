using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backUrbanPark.Model.DTO
{
    public class DadosEntradaVeiculo
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; } = "";
        public int IdVeiculo { get; set; }
        public string Placa { get; set; } = "";
        public string Modelo { get; set; } = "";
        public string? Cor { get; set; }
    }
}
