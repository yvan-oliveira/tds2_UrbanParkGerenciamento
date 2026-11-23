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
            lbl_StatusVaga = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_StatusVaga).BeginInit();
            SuspendLayout();
            // 
            // pic_StatusVaga
            // 
            pic_StatusVaga.Image = frmUrbanPark.Properties.Resources.carIconVerde;
            pic_StatusVaga.Location = new Point(46, 58);
            pic_StatusVaga.Name = "pic_StatusVaga";
            pic_StatusVaga.Size = new Size(50, 50);
            pic_StatusVaga.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_StatusVaga.TabIndex = 0;
            pic_StatusVaga.TabStop = false;
            // 
            // lbl_StatusVaga
            // 
            lbl_StatusVaga.AutoSize = true;
            lbl_StatusVaga.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_StatusVaga.Location = new Point(46, 35);
            lbl_StatusVaga.Name = "lbl_StatusVaga";
            lbl_StatusVaga.Size = new Size(51, 21);
            lbl_StatusVaga.TabIndex = 1;
            lbl_StatusVaga.Text = "LIVRE";
            // 
            // ctr_StatusVagas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 247, 231);
            Controls.Add(lbl_StatusVaga);
            Controls.Add(pic_StatusVaga);
            Name = "ctr_StatusVagas";
            ((System.ComponentModel.ISupportInitialize)pic_StatusVaga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_StatusVaga;
        private Label lbl_StatusVaga;
    }
}
