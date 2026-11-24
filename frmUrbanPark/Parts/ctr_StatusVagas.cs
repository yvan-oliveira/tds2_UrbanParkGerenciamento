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
    public enum StatusVagas {Livre, Ocupada}

    public partial class ctr_StatusVagas : UserControl
    {
        private int _idVaga;
        private StatusVagas _statusVaga;
        private string _numeroVaga;

        public event EventHandler VagaClicada;

        private Color _verdeClaro = Color.FromArgb(223, 247, 231);
        private Color _vermelhoClaro = Color.FromArgb(254, 224, 221);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IdVaga { get => _idVaga; set => _idVaga = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public StatusVagas StatusVaga { get => _statusVaga; set => _statusVaga = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NumeroVaga { get => _numeroVaga; set => _numeroVaga = value; }

        public ctr_StatusVagas()
        {
            InitializeComponent();
        }

        private void ctr_StatusVagas_Load(object sender, EventArgs e)
        {
            AtualizarAparenciaCard();
        }

        private void AtualizarAparenciaCard()
        {
            this.lbl_NumeroVaga.Text = this.NumeroVaga;
            
            if (this.StatusVaga == StatusVagas.Livre)
            {
                this.BackColor = _verdeClaro;
                this.pic_StatusVaga.Image = frmUrbanPark.Properties.Resources.carIconVerde;
            }
            else
            {
                this.BackColor = _vermelhoClaro;
                this.pic_StatusVaga.Image = frmUrbanPark.Properties.Resources.carIconVermlho; 
            }
        }
    }
}
