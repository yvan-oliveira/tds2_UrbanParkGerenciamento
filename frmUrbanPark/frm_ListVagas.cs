using backUrbanPark;
using backUrbanPark.Model;
using backUrbanPark.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrbanParkGerenciamento.Parts;

namespace UrbanParkGerenciamento
{
    public partial class frm_ListVagas : Form
    {
        public frm_ListVagas()
        {
            InitializeComponent();
        }

        private void frm_ListVagas_Load(object sender, EventArgs e)
        {
           CarregarDadosEMontarVisualizacao();
        }

        private void CarregarDadosEMontarVisualizacao()
        {
            List<Vaga> listaVagas = VagaRepository.ListarTodasVagas();
            
            flw_CardVagas.Controls.Clear();

            foreach (var vaga in listaVagas)
            {
                int idVaga = vaga.Id;
                string strNumeroVaga = vaga.NumeroVaga.ToString();
                StatusVagas statusVaga = Enum.Parse<StatusVagas>(vaga.StatusVaga.ToString());

                ctr_StatusVagas cardVaga = new ctr_StatusVagas();

                cardVaga.IdVaga = idVaga;
                cardVaga.StatusVaga = statusVaga;
                cardVaga.NumeroVaga = strNumeroVaga;

                flw_CardVagas.Controls.Add(cardVaga);

            }
        }
    }
}
