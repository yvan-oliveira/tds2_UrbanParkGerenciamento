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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
