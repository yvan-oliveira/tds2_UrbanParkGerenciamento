using backUrbanPark;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrbanParkGerenciamento.Parts
{
    public enum EStatusVagas { Livre, Ocupada }
    public enum ETipoVaga { Carro, Moto, PCD, Idoso }


    public partial class ctr_StatusVagas : UserControl
    {
        private int _idVaga;
        private EStatusVagas _statusVaga;
        private string _numeroVaga;
        private ETipoVaga _tipoVaga;

        // Evento publico
        public event EventHandler CardClicado;

        private Color _verdeClaro = Color.FromArgb(223, 247, 231);
        private Color _vermelhoClaro = Color.FromArgb(254, 224, 221);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IdVaga { get => _idVaga; set => _idVaga = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public EStatusVagas StatusVaga { get => _statusVaga; set => _statusVaga = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NumeroVaga { get => _numeroVaga; set => _numeroVaga = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ETipoVaga TipoVaga { get => _tipoVaga; set => _tipoVaga = value; }

        public ctr_StatusVagas()
        {
            InitializeComponent();

            // ================================================================
            // 2. INSCRIÇÃO NOS EVENTOS INTERNOS (+=)
            // No Windows Forms, clicar em um Label ou PictureBox dentro de um
            // UserControl NÃO dispara o Click do UserControl automaticamente.
            // Por isso, conectamos o Click do fundo, do texto e da imagem
            // ao mesmo método (AoClicarNoCard), garantindo que o card inteiro
            // seja clicável.
            // ================================================================

            this.Click += AoClicarNoCard;
            this.lbl_NumeroVaga.Click += AoClicarNoCard;
            this.pic_StatusVaga.Click += AoClicarNoCard;
            this.lbl_TipoVaga.Click += AoClicarNoCard;
        }

        private void ctr_StatusVagas_Load(object sender, EventArgs e)
        {
            AtualizarAparenciaCard();
        }

        private void AtualizarAparenciaCard()
        {
            this.lbl_NumeroVaga.Text = this.NumeroVaga;
            this.lbl_TipoVaga.Text = this.TipoVaga.ToString();
            // Define a cor de fundo conforme o status
            this.BackColor = this.StatusVaga switch
            {
                EStatusVagas.Livre => _verdeClaro,
                EStatusVagas.Ocupada => _vermelhoClaro,
                _ => this.BackColor
            };
            // Define o ícone conforme o tipo e status da vaga
            this.pic_StatusVaga.Image = (this.TipoVaga, this.StatusVaga) switch
            {
                (ETipoVaga.Carro, EStatusVagas.Livre) => frmUrbanPark.Properties.Resources.carIconVerde,
                (ETipoVaga.Carro, EStatusVagas.Ocupada) => frmUrbanPark.Properties.Resources.carIconVermlho,
                (ETipoVaga.Moto, EStatusVagas.Livre) => frmUrbanPark.Properties.Resources.motoIconeVerde,
                (ETipoVaga.Moto, EStatusVagas.Ocupada) => frmUrbanPark.Properties.Resources.motoIconeVermelho,
                (ETipoVaga.PCD, EStatusVagas.Livre) => frmUrbanPark.Properties.Resources.pcdVerde,
                (ETipoVaga.PCD, EStatusVagas.Ocupada) => frmUrbanPark.Properties.Resources.pcdVermelho,
                (ETipoVaga.Idoso, EStatusVagas.Livre) => frmUrbanPark.Properties.Resources.idosoVerde,
                (ETipoVaga.Idoso, EStatusVagas.Ocupada) => frmUrbanPark.Properties.Resources.idosoVermelho,
                _ => null
            };
        }
        private void pic_StatusVaga_Click(object sender, EventArgs e)
        {

        }

        private void AoClicarNoCard(object sender, EventArgs e)
        {
            CardClicado?.Invoke(this, EventArgs.Empty);
        }
    }
}
