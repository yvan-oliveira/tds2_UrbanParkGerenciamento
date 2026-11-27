using backUrbanPark.Model.DTO;
using backUrbanPark.Repository;

namespace UrbanParkGerenciamento
{
    public partial class frm_RegistrarEntrada : Form
    {
        private string _numVaga;
        private int _idvaga;

        public frm_RegistrarEntrada()
        {
            InitializeComponent();
        }

        public frm_RegistrarEntrada(string numVaga, int idvaga) : this()
        {
            this._numVaga = numVaga;
            this._idvaga = idvaga;
        }

        private void frm_RegistrarEntrada_Load(object sender, EventArgs e)
        {
            txt_VagaSelecionada.Text = _numVaga;
            msk_Placaveiculo.Focus();
        }
        private void btn_BuscarPorPlaca_Click(object sender, EventArgs e)
        {
            DadosEntradaVeiculo? dadosVeiculo = new DadosEntradaVeiculo();

            dadosVeiculo = EntradaRepository.BuscarDadosPorPlaca(msk_Placaveiculo.Text);

            if (dadosVeiculo == null) 
            {
                MessageBox.Show("Veículo não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                btn_RegistrarEntrada.Enabled = false;
                msk_Placaveiculo.Clear();
                txt_NomeCliente.Clear();
                txt_CorModelo.Clear();
                msk_Placaveiculo.Focus();                
                return;
            }

            btn_RegistrarEntrada.Enabled = false;
            txt_NomeCliente.Text = dadosVeiculo.NomeCliente;
            txt_CorModelo.Text = $"{dadosVeiculo.Modelo} / {dadosVeiculo.Cor}";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

        }

    }
}
