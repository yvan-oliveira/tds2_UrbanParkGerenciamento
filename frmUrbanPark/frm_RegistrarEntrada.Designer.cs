namespace UrbanParkGerenciamento
{
    partial class frm_RegistrarEntrada
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RegistrarEntrada));
            pnl_Cabecalho = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            lbl_Subtitulo = new Label();
            lbl_Titulo = new Label();
            pic_Logo = new PictureBox();
            grp_BuscarVeiculo = new GroupBox();
            msk_Placaveiculo = new MaskedTextBox();
            btn_BuscarPorPlaca = new Button();
            imgIconePesquisa = new ImageList(components);
            lbl_PlacaVeiculo = new Label();
            imgIconeCancelar = new ImageList(components);
            grp_DadosVeiculo = new GroupBox();
            txt_CorModelo = new TextBox();
            txt_NomeCliente = new TextBox();
            lbl_CorModelo = new Label();
            lbl_Cliente = new Label();
            grp_Movimentacao = new GroupBox();
            dtp_InfoHrEntrada = new DateTimePicker();
            dtp_InfoDtEntrada = new DateTimePicker();
            lbl_HoraDeEntrada = new Label();
            lblDataEntrada = new Label();
            txt_VagaSelecionada = new TextBox();
            lbl_VagaSelecionada = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btn_Cancelar = new Button();
            btn_RegistrarEntrada = new Button();
            imgIconeConfirmar = new ImageList(components);
            imageList1 = new ImageList(components);
            pnl_Cabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Logo).BeginInit();
            grp_BuscarVeiculo.SuspendLayout();
            grp_DadosVeiculo.SuspendLayout();
            grp_Movimentacao.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Cabecalho
            // 
            pnl_Cabecalho.BackColor = SystemColors.HotTrack;
            pnl_Cabecalho.Controls.Add(panel4);
            pnl_Cabecalho.Controls.Add(panel1);
            pnl_Cabecalho.Controls.Add(label1);
            pnl_Cabecalho.Controls.Add(lbl_Subtitulo);
            pnl_Cabecalho.Controls.Add(lbl_Titulo);
            pnl_Cabecalho.Controls.Add(pic_Logo);
            pnl_Cabecalho.Dock = DockStyle.Top;
            pnl_Cabecalho.ForeColor = SystemColors.HighlightText;
            pnl_Cabecalho.Location = new Point(0, 0);
            pnl_Cabecalho.Name = "pnl_Cabecalho";
            pnl_Cabecalho.Size = new Size(892, 100);
            pnl_Cabecalho.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(154, 17);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 65);
            panel4.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(428, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 65);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(451, 52);
            label1.Name = "label1";
            label1.Size = new Size(351, 28);
            label1.TabIndex = 4;
            label1.Text = "Inicia a movimentação do veículo no estacionado.";
            // 
            // lbl_Subtitulo
            // 
            lbl_Subtitulo.BackColor = Color.Transparent;
            lbl_Subtitulo.Font = new Font("Segoe Fluent Icons", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Subtitulo.ForeColor = Color.White;
            lbl_Subtitulo.Location = new Point(445, 10);
            lbl_Subtitulo.Name = "lbl_Subtitulo";
            lbl_Subtitulo.Size = new Size(238, 49);
            lbl_Subtitulo.TabIndex = 3;
            lbl_Subtitulo.Text = "Registrar Entrada";
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.BackColor = Color.Transparent;
            lbl_Titulo.Font = new Font("Segoe Fluent Icons", 45.75F, FontStyle.Bold);
            lbl_Titulo.ForeColor = Color.White;
            lbl_Titulo.Location = new Point(166, 5);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(259, 88);
            lbl_Titulo.TabIndex = 1;
            lbl_Titulo.Text = "UrbanPark";
            // 
            // pic_Logo
            // 
            pic_Logo.Image = frmUrbanPark.Properties.Resources.logo;
            pic_Logo.Location = new Point(38, 13);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new Size(100, 73);
            pic_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Logo.TabIndex = 0;
            pic_Logo.TabStop = false;
            // 
            // grp_BuscarVeiculo
            // 
            grp_BuscarVeiculo.Controls.Add(msk_Placaveiculo);
            grp_BuscarVeiculo.Controls.Add(btn_BuscarPorPlaca);
            grp_BuscarVeiculo.Controls.Add(lbl_PlacaVeiculo);
            grp_BuscarVeiculo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grp_BuscarVeiculo.ForeColor = SystemColors.HotTrack;
            grp_BuscarVeiculo.Location = new Point(25, 120);
            grp_BuscarVeiculo.Name = "grp_BuscarVeiculo";
            grp_BuscarVeiculo.Size = new Size(839, 96);
            grp_BuscarVeiculo.TabIndex = 1;
            grp_BuscarVeiculo.TabStop = false;
            grp_BuscarVeiculo.Text = "Buscar Veículo";
            // 
            // msk_Placaveiculo
            // 
            msk_Placaveiculo.BorderStyle = BorderStyle.FixedSingle;
            msk_Placaveiculo.Location = new Point(152, 47);
            msk_Placaveiculo.Mask = "aaaaaaa";
            msk_Placaveiculo.Name = "msk_Placaveiculo";
            msk_Placaveiculo.Size = new Size(241, 29);
            msk_Placaveiculo.TabIndex = 1;
            // 
            // btn_BuscarPorPlaca
            // 
            btn_BuscarPorPlaca.BackColor = Color.FromArgb(239, 239, 241);
            btn_BuscarPorPlaca.FlatAppearance.BorderColor = SystemColors.GrayText;
            btn_BuscarPorPlaca.FlatStyle = FlatStyle.Flat;
            btn_BuscarPorPlaca.Font = new Font("Segoe UI", 12F);
            btn_BuscarPorPlaca.ForeColor = Color.Black;
            btn_BuscarPorPlaca.ImageAlign = ContentAlignment.MiddleLeft;
            btn_BuscarPorPlaca.ImageIndex = 0;
            btn_BuscarPorPlaca.ImageList = imgIconePesquisa;
            btn_BuscarPorPlaca.Location = new Point(426, 47);
            btn_BuscarPorPlaca.Name = "btn_BuscarPorPlaca";
            btn_BuscarPorPlaca.Size = new Size(203, 33);
            btn_BuscarPorPlaca.TabIndex = 2;
            btn_BuscarPorPlaca.Text = "Buscar por Placa";
            btn_BuscarPorPlaca.UseVisualStyleBackColor = false;
            btn_BuscarPorPlaca.Click += btn_BuscarPorPlaca_Click;
            // 
            // imgIconePesquisa
            // 
            imgIconePesquisa.ColorDepth = ColorDepth.Depth32Bit;
            imgIconePesquisa.ImageStream = (ImageListStreamer)resources.GetObject("imgIconePesquisa.ImageStream");
            imgIconePesquisa.TransparentColor = Color.Transparent;
            imgIconePesquisa.Images.SetKeyName(0, "iconPesquisa.png");
            // 
            // lbl_PlacaVeiculo
            // 
            lbl_PlacaVeiculo.AutoSize = true;
            lbl_PlacaVeiculo.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PlacaVeiculo.ForeColor = Color.Black;
            lbl_PlacaVeiculo.Location = new Point(22, 49);
            lbl_PlacaVeiculo.Name = "lbl_PlacaVeiculo";
            lbl_PlacaVeiculo.Size = new Size(124, 21);
            lbl_PlacaVeiculo.TabIndex = 0;
            lbl_PlacaVeiculo.Text = "Placa do veículo:";
            // 
            // imgIconeCancelar
            // 
            imgIconeCancelar.ColorDepth = ColorDepth.Depth32Bit;
            imgIconeCancelar.ImageStream = (ImageListStreamer)resources.GetObject("imgIconeCancelar.ImageStream");
            imgIconeCancelar.TransparentColor = Color.Transparent;
            imgIconeCancelar.Images.SetKeyName(0, "iconeCancelar.png");
            // 
            // grp_DadosVeiculo
            // 
            grp_DadosVeiculo.Controls.Add(txt_CorModelo);
            grp_DadosVeiculo.Controls.Add(txt_NomeCliente);
            grp_DadosVeiculo.Controls.Add(lbl_CorModelo);
            grp_DadosVeiculo.Controls.Add(lbl_Cliente);
            grp_DadosVeiculo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grp_DadosVeiculo.ForeColor = SystemColors.HotTrack;
            grp_DadosVeiculo.Location = new Point(25, 232);
            grp_DadosVeiculo.Name = "grp_DadosVeiculo";
            grp_DadosVeiculo.Size = new Size(400, 160);
            grp_DadosVeiculo.TabIndex = 1;
            grp_DadosVeiculo.TabStop = false;
            grp_DadosVeiculo.Text = "Dados do Veículo";
            // 
            // txt_CorModelo
            // 
            txt_CorModelo.BorderStyle = BorderStyle.FixedSingle;
            txt_CorModelo.Enabled = false;
            txt_CorModelo.Location = new Point(150, 93);
            txt_CorModelo.Name = "txt_CorModelo";
            txt_CorModelo.Size = new Size(241, 29);
            txt_CorModelo.TabIndex = 5;
            // 
            // txt_NomeCliente
            // 
            txt_NomeCliente.BorderStyle = BorderStyle.FixedSingle;
            txt_NomeCliente.Enabled = false;
            txt_NomeCliente.Location = new Point(150, 40);
            txt_NomeCliente.Name = "txt_NomeCliente";
            txt_NomeCliente.Size = new Size(241, 29);
            txt_NomeCliente.TabIndex = 4;
            // 
            // lbl_CorModelo
            // 
            lbl_CorModelo.AutoSize = true;
            lbl_CorModelo.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CorModelo.ForeColor = Color.Black;
            lbl_CorModelo.Location = new Point(22, 95);
            lbl_CorModelo.Name = "lbl_CorModelo";
            lbl_CorModelo.Size = new Size(105, 21);
            lbl_CorModelo.TabIndex = 3;
            lbl_CorModelo.Text = "Cor / Modelo:";
            // 
            // lbl_Cliente
            // 
            lbl_Cliente.AutoSize = true;
            lbl_Cliente.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Cliente.ForeColor = Color.Black;
            lbl_Cliente.Location = new Point(22, 42);
            lbl_Cliente.Name = "lbl_Cliente";
            lbl_Cliente.Size = new Size(62, 21);
            lbl_Cliente.TabIndex = 2;
            lbl_Cliente.Text = "Cliente:";
            // 
            // grp_Movimentacao
            // 
            grp_Movimentacao.Controls.Add(dtp_InfoHrEntrada);
            grp_Movimentacao.Controls.Add(dtp_InfoDtEntrada);
            grp_Movimentacao.Controls.Add(lbl_HoraDeEntrada);
            grp_Movimentacao.Controls.Add(lblDataEntrada);
            grp_Movimentacao.Controls.Add(txt_VagaSelecionada);
            grp_Movimentacao.Controls.Add(lbl_VagaSelecionada);
            grp_Movimentacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grp_Movimentacao.ForeColor = SystemColors.HotTrack;
            grp_Movimentacao.Location = new Point(464, 232);
            grp_Movimentacao.Name = "grp_Movimentacao";
            grp_Movimentacao.Size = new Size(400, 160);
            grp_Movimentacao.TabIndex = 2;
            grp_Movimentacao.TabStop = false;
            grp_Movimentacao.Text = "Movimentação";
            // 
            // dtp_InfoHrEntrada
            // 
            dtp_InfoHrEntrada.CalendarFont = new Font("Segoe UI", 12F);
            dtp_InfoHrEntrada.CustomFormat = "HH:mm";
            dtp_InfoHrEntrada.Font = new Font("Segoe UI", 12F);
            dtp_InfoHrEntrada.Format = DateTimePickerFormat.Custom;
            dtp_InfoHrEntrada.Location = new Point(185, 118);
            dtp_InfoHrEntrada.Name = "dtp_InfoHrEntrada";
            dtp_InfoHrEntrada.ShowUpDown = true;
            dtp_InfoHrEntrada.Size = new Size(104, 29);
            dtp_InfoHrEntrada.TabIndex = 14;
            // 
            // dtp_InfoDtEntrada
            // 
            dtp_InfoDtEntrada.CalendarFont = new Font("Segoe UI", 12F);
            dtp_InfoDtEntrada.Font = new Font("Segoe UI", 12F);
            dtp_InfoDtEntrada.Format = DateTimePickerFormat.Short;
            dtp_InfoDtEntrada.Location = new Point(185, 72);
            dtp_InfoDtEntrada.Name = "dtp_InfoDtEntrada";
            dtp_InfoDtEntrada.Size = new Size(200, 29);
            dtp_InfoDtEntrada.TabIndex = 9;
            // 
            // lbl_HoraDeEntrada
            // 
            lbl_HoraDeEntrada.AutoSize = true;
            lbl_HoraDeEntrada.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_HoraDeEntrada.ForeColor = Color.Black;
            lbl_HoraDeEntrada.Location = new Point(27, 118);
            lbl_HoraDeEntrada.Name = "lbl_HoraDeEntrada";
            lbl_HoraDeEntrada.Size = new Size(124, 21);
            lbl_HoraDeEntrada.TabIndex = 8;
            lbl_HoraDeEntrada.Text = "Hora de Entrada:";
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataEntrada.ForeColor = Color.Black;
            lblDataEntrada.Location = new Point(27, 80);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(123, 21);
            lblDataEntrada.TabIndex = 7;
            lblDataEntrada.Text = "Data de Entrada:";
            // 
            // txt_VagaSelecionada
            // 
            txt_VagaSelecionada.BorderStyle = BorderStyle.FixedSingle;
            txt_VagaSelecionada.Enabled = false;
            txt_VagaSelecionada.Location = new Point(185, 34);
            txt_VagaSelecionada.Name = "txt_VagaSelecionada";
            txt_VagaSelecionada.Size = new Size(196, 29);
            txt_VagaSelecionada.TabIndex = 6;
            // 
            // lbl_VagaSelecionada
            // 
            lbl_VagaSelecionada.AutoSize = true;
            lbl_VagaSelecionada.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_VagaSelecionada.ForeColor = Color.Black;
            lbl_VagaSelecionada.Location = new Point(27, 42);
            lbl_VagaSelecionada.Name = "lbl_VagaSelecionada";
            lbl_VagaSelecionada.Size = new Size(134, 21);
            lbl_VagaSelecionada.TabIndex = 3;
            lbl_VagaSelecionada.Text = "Vaga Selecionada:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 417);
            panel2.Name = "panel2";
            panel2.Size = new Size(892, 100);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(btn_Cancelar);
            panel3.Controls.Add(btn_RegistrarEntrada);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(892, 100);
            panel3.TabIndex = 1;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(239, 239, 241);
            btn_Cancelar.FlatAppearance.BorderColor = Color.Gray;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Segoe UI", 12F);
            btn_Cancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Cancelar.ImageIndex = 0;
            btn_Cancelar.ImageList = imgIconeCancelar;
            btn_Cancelar.Location = new Point(750, 39);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(130, 33);
            btn_Cancelar.TabIndex = 3;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_RegistrarEntrada
            // 
            btn_RegistrarEntrada.BackColor = Color.FromArgb(223, 247, 231);
            btn_RegistrarEntrada.FlatAppearance.BorderColor = Color.Blue;
            btn_RegistrarEntrada.FlatStyle = FlatStyle.Flat;
            btn_RegistrarEntrada.Font = new Font("Segoe UI", 12F);
            btn_RegistrarEntrada.ImageAlign = ContentAlignment.MiddleLeft;
            btn_RegistrarEntrada.ImageIndex = 0;
            btn_RegistrarEntrada.ImageList = imgIconeConfirmar;
            btn_RegistrarEntrada.Location = new Point(555, 39);
            btn_RegistrarEntrada.Name = "btn_RegistrarEntrada";
            btn_RegistrarEntrada.Size = new Size(180, 33);
            btn_RegistrarEntrada.TabIndex = 2;
            btn_RegistrarEntrada.Text = "         Registrar Entrada";
            btn_RegistrarEntrada.UseVisualStyleBackColor = false;
            // 
            // imgIconeConfirmar
            // 
            imgIconeConfirmar.ColorDepth = ColorDepth.Depth32Bit;
            imgIconeConfirmar.ImageStream = (ImageListStreamer)resources.GetObject("imgIconeConfirmar.ImageStream");
            imgIconeConfirmar.TransparentColor = Color.Transparent;
            imgIconeConfirmar.Images.SetKeyName(0, "iconeConfirmar.png");
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "iconeConfirmar.png");
            // 
            // frm_RegistrarEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 517);
            Controls.Add(panel2);
            Controls.Add(grp_DadosVeiculo);
            Controls.Add(grp_Movimentacao);
            Controls.Add(grp_BuscarVeiculo);
            Controls.Add(pnl_Cabecalho);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_RegistrarEntrada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UrbanPark - Registrar Entrada";
            Load += frm_RegistrarEntrada_Load;
            pnl_Cabecalho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Logo).EndInit();
            grp_BuscarVeiculo.ResumeLayout(false);
            grp_BuscarVeiculo.PerformLayout();
            grp_DadosVeiculo.ResumeLayout(false);
            grp_DadosVeiculo.PerformLayout();
            grp_Movimentacao.ResumeLayout(false);
            grp_Movimentacao.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Cabecalho;
        private GroupBox grp_BuscarVeiculo;
        private GroupBox grp_DadosVeiculo;
        private GroupBox grp_Movimentacao;
        private Panel panel2;
        private Panel panel3;
        private Button btn_RegistrarEntrada;
        private Button btn_Cancelar;
        private PictureBox pic_Logo;
        private Label lbl_Titulo;
        private Label lbl_PlacaVeiculo;
        private Label lbl_Subtitulo;
        private Label lbl_Cliente;
        private Label lbl_CorModelo;
        private Label lbl_VagaSelecionada;
        private TextBox txt_NomeCliente;
        private TextBox txt_CorModelo;
        private TextBox txt_VagaSelecionada;
        private Label lblDataEntrada;
        private Label lbl_HoraDeEntrada;
        private DateTimePicker dtp_InfoDtEntrada;
        private Label label1;
        private Panel panel4;
        private Panel panel1;
        private ImageList imgIconeConfirmar;
        private ImageList imgIconeCancelar;
        private Button btn_BuscarPorPlaca;
        private ImageList imageList1;
        private ImageList imgIconePesquisa;
        private MaskedTextBox msk_Placaveiculo;
        private DateTimePicker dtp_InfoHrEntrada;
    }
}
