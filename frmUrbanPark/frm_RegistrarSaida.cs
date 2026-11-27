using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmUrbanPark
{
    public partial class frm_RegistrarSaida : Form
    {
        private string _numVaga;
        private int _idvaga;

        public frm_RegistrarSaida()
        {
            InitializeComponent();
        }

        public frm_RegistrarSaida(string numVaga, int idvaga) : this()
        {
            this._numVaga = numVaga;
            this._idvaga = idvaga;
        }

        private void frm_RegistrarSaida_Load(object sender, EventArgs e)
        {

        }
    }
}
