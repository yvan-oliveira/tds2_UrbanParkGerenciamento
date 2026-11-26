namespace UrbanParkGerenciamento.Parts
{
    partial class ctr_StatusVagas
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pic_StatusVaga = new PictureBox();
            lbl_NumeroVaga = new Label();
            lbl_TipoVaga = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_StatusVaga).BeginInit();
            SuspendLayout();
            // 
            // pic_StatusVaga
            // 
            pic_StatusVaga.Image = frmUrbanPark.Properties.Resources.carIconVerde;
            pic_StatusVaga.Location = new Point(50, 62);
            pic_StatusVaga.Name = "pic_StatusVaga";
            pic_StatusVaga.Size = new Size(50, 50);
            pic_StatusVaga.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_StatusVaga.TabIndex = 0;
            pic_StatusVaga.TabStop = false;
            pic_StatusVaga.Click += pic_StatusVaga_Click;
            // 
            // lbl_NumeroVaga
            // 
            lbl_NumeroVaga.Dock = DockStyle.Top;
            lbl_NumeroVaga.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold);
            lbl_NumeroVaga.Location = new Point(0, 0);
            lbl_NumeroVaga.Name = "lbl_NumeroVaga";
            lbl_NumeroVaga.Size = new Size(148, 59);
            lbl_NumeroVaga.TabIndex = 1;
            lbl_NumeroVaga.Text = " 01";
            lbl_NumeroVaga.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lbl_TipoVaga
            // 
            lbl_TipoVaga.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TipoVaga.Location = new Point(25, 115);
            lbl_TipoVaga.Name = "lbl_TipoVaga";
            lbl_TipoVaga.Size = new Size(100, 23);
            lbl_TipoVaga.TabIndex = 2;
            lbl_TipoVaga.Text = "label1";
            lbl_TipoVaga.TextAlign = ContentAlignment.TopCenter;
            // 
            // ctr_StatusVagas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 247, 231);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lbl_TipoVaga);
            Controls.Add(lbl_NumeroVaga);
            Controls.Add(pic_StatusVaga);
            Name = "ctr_StatusVagas";
            Size = new Size(148, 148);
            Load += ctr_StatusVagas_Load;
            ((System.ComponentModel.ISupportInitialize)pic_StatusVaga).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_StatusVaga;
        private Label lbl_NumeroVaga;
        private Label lbl_TipoVaga;
    }
}
