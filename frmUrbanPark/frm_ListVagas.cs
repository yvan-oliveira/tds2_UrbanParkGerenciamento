using backUrbanPark;
using backUrbanPark.Model;
using backUrbanPark.Repository;
using frmUrbanPark;
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
                EStatusVagas statusVaga = Enum.Parse<EStatusVagas>(vaga.StatusVaga.ToString());
                ETipoVaga tipoVaga = Enum.Parse<ETipoVaga>(vaga.TipoVaga.ToString());

                ctr_StatusVagas cardVaga = new ctr_StatusVagas();

                cardVaga.IdVaga = idVaga;
                cardVaga.StatusVaga = statusVaga;
                cardVaga.NumeroVaga = strNumeroVaga;
                cardVaga.TipoVaga = tipoVaga;

                cardVaga.CardClicado += cardVaga_Click;


                flw_CardVagas.Controls.Add(cardVaga);

            }
        }

        public void cardVaga_Click(object sender, EventArgs e)
        {
            ctr_StatusVagas cardSelecionado = (ctr_StatusVagas)sender;

            if (cardSelecionado.StatusVaga == EStatusVagas.Livre)
            {
                frm_RegistrarEntrada frmEntrada = new frm_RegistrarEntrada(cardSelecionado.NumeroVaga, cardSelecionado.IdVaga);

                frmEntrada.ShowDialog();
            }
            else
            {
                frm_RegistrarSaida frmSaida = new frm_RegistrarSaida(cardSelecionado.NumeroVaga, cardSelecionado.IdVaga);

                frmSaida.ShowDialog();
            }
        }
    }
}
