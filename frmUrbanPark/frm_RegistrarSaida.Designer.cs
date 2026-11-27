namespace frmUrbanPark
{
    partial class frm_RegistrarSaida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RegistrarSaida));
            grp_DadosVeiculo = new GroupBox();
            txt_NumeroVaga = new TextBox();
            lbl_Vaga = new Label();
            txt_CorModelo = new TextBox();
            txt_NomeCliente = new TextBox();
            lbl_CorModelo = new Label();
            lbl_Cliente = new Label();
            grp_BuscarVeiculo = new GroupBox();
            btn_BuscarPorPlaca = new Button();
            imgIconePesquisa = new ImageList(components);
            msk_Placaveiculo = new MaskedTextBox();
            lbl_PlacaVeiculo = new Label();
            pnl_Cabecalho = new Panel();
            label1 = new Label();
            lbl_Subtitulo = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            lbl_Titulo = new Label();
            pic_Logo = new PictureBox();
            btn_RegistrarSaida = new Button();
            imgIconeConfirmar = new ImageList(components);
            grp_Movimentacao = new GroupBox();
            dtp_InfoHrSaida = new DateTimePicker();
            lbl_HoraSaida = new Label();
            dtp_InfoDtSaida = new DateTimePicker();
            lbl_DtHoraEntrada = new DateTimePicker();
            lbl_DataSaida = new Label();
            lbl_DataHoraEntrada = new Label();
            txt_InfoTempoPermanencia = new TextBox();
            lblTarifaVigente = new Label();
            grpCalculo = new GroupBox();
            panel1 = new Panel();
            lbl_ValorPagar = new Label();
            lbl_ValorAPagar = new Label();
            txt_InfoTarifa = new TextBox();
            lbl_TempoPermanencia = new Label();
            btn_Cancelar = new Button();
            imgIconeCancelar = new ImageList(components);
            imageList1 = new ImageList(components);
            grp_DadosVeiculo.SuspendLayout();
            grp_BuscarVeiculo.SuspendLayout();
            pnl_Cabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Logo).BeginInit();
            grp_Movimentacao.SuspendLayout();
            grpCalculo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // grp_DadosVeiculo
            // 
            grp_DadosVeiculo.Controls.Add(txt_NumeroVaga);
            grp_DadosVeiculo.Controls.Add(lbl_Vaga);
            grp_DadosVeiculo.Controls.Add(txt_CorModelo);
            grp_DadosVeiculo.Controls.Add(txt_NomeCliente);
            grp_DadosVeiculo.Controls.Add(lbl_CorModelo);
            grp_DadosVeiculo.Controls.Add(lbl_Cliente);
            grp_DadosVeiculo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grp_DadosVeiculo.ForeColor = SystemColors.HotTrack;
            grp_DadosVeiculo.Location = new Point(12, 231);
            grp_DadosVeiculo.Name = "grp_DadosVeiculo";
            grp_DadosVeiculo.Size = new Size(400, 338);
            grp_DadosVeiculo.TabIndex = 4;
            grp_DadosVeiculo.TabStop = false;
            grp_DadosVeiculo.Text = "Dados do Veículo";
            // 
            // txt_NumeroVaga
            // 
            txt_NumeroVaga.BorderStyle = BorderStyle.FixedSingle;
            txt_NumeroVaga.Enabled = false;
            txt_NumeroVaga.Location = new Point(150, 133);
            txt_NumeroVaga.Name = "txt_NumeroVaga";
            txt_NumeroVaga.Size = new Size(60, 29);
            txt_NumeroVaga.TabIndex = 7;
            // 
            // lbl_Vaga
            // 
            lbl_Vaga.AutoSize = true;
            lbl_Vaga.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Vaga.ForeColor = Color.Black;
            lbl_Vaga.Location = new Point(21, 135);
            lbl_Vaga.Name = "lbl_Vaga";
            lbl_Vaga.Size = new Size(48, 21);
            lbl_Vaga.TabIndex = 6;
            lbl_Vaga.Text = "Vaga:";
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
            txt_NomeCliente.Location = new Point(150, 41);
            txt_NomeCliente.Name = "txt_NomeCliente";
            txt_NomeCliente.Size = new Size(241, 29);
            txt_NomeCliente.TabIndex = 4;
            // 
            // lbl_CorModelo
            // 
            lbl_CorModelo.AutoSize = true;
            lbl_CorModelo.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CorModelo.ForeColor = Color.Black;
            lbl_CorModelo.Location = new Point(21, 93);
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
            lbl_Cliente.Location = new Point(21, 41);
            lbl_Cliente.Name = "lbl_Cliente";
            lbl_Cliente.Size = new Size(62, 21);
            lbl_Cliente.TabIndex = 2;
            lbl_Cliente.Text = "Cliente:";
            // 
            // grp_BuscarVeiculo
            // 
            grp_BuscarVeiculo.Controls.Add(btn_BuscarPorPlaca);
            grp_BuscarVeiculo.Controls.Add(msk_Placaveiculo);
            grp_BuscarVeiculo.Controls.Add(lbl_PlacaVeiculo);
            grp_BuscarVeiculo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grp_BuscarVeiculo.ForeColor = SystemColors.HotTrack;
            grp_BuscarVeiculo.Location = new Point(12, 119);
            grp_BuscarVeiculo.Name = "grp_BuscarVeiculo";
            grp_BuscarVeiculo.Size = new Size(921, 96);
            grp_BuscarVeiculo.TabIndex = 3;
            grp_BuscarVeiculo.TabStop = false;
            grp_BuscarVeiculo.Text = "Buscar Veículo";
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
            btn_BuscarPorPlaca.Location = new Point(446, 37);
            btn_BuscarPorPlaca.Name = "btn_BuscarPorPlaca";
            btn_BuscarPorPlaca.Size = new Size(203, 33);
            btn_BuscarPorPlaca.TabIndex = 8;
            btn_BuscarPorPlaca.Text = "Buscar por Placa";
            btn_BuscarPorPlaca.UseVisualStyleBackColor = false;
            // 
            // imgIconePesquisa
            // 
            imgIconePesquisa.ColorDepth = ColorDepth.Depth32Bit;
            imgIconePesquisa.ImageStream = (ImageListStreamer)resources.GetObject("imgIconePesquisa.ImageStream");
            imgIconePesquisa.TransparentColor = Color.Transparent;
            imgIconePesquisa.Images.SetKeyName(0, "iconPesquisa.png");
            // 
            // msk_Placaveiculo
            // 
            msk_Placaveiculo.BorderStyle = BorderStyle.FixedSingle;
            msk_Placaveiculo.Location = new Point(168, 41);
            msk_Placaveiculo.Mask = "000-0000";
            msk_Placaveiculo.Name = "msk_Placaveiculo";
            msk_Placaveiculo.Size = new Size(241, 29);
            msk_Placaveiculo.TabIndex = 7;
            // 
            // lbl_PlacaVeiculo
            // 
            lbl_PlacaVeiculo.AutoSize = true;
            lbl_PlacaVeiculo.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PlacaVeiculo.ForeColor = Color.Black;
            lbl_PlacaVeiculo.Location = new Point(22, 49);
            lbl_PlacaVeiculo.Name = "lbl_PlacaVeiculo";
            lbl_PlacaVeiculo.Size = new Size(124, 21);
            lbl_PlacaVeiculo.TabIndex = 1;
            lbl_PlacaVeiculo.Text = "Placa do veículo:";
            // 
            // pnl_Cabecalho
            // 
            pnl_Cabecalho.BackColor = SystemColors.HotTrack;
            pnl_Cabecalho.Controls.Add(label1);
            pnl_Cabecalho.Controls.Add(lbl_Subtitulo);
            pnl_Cabecalho.Controls.Add(panel3);
            pnl_Cabecalho.Controls.Add(panel2);
            pnl_Cabecalho.Controls.Add(lbl_Titulo);
            pnl_Cabecalho.Controls.Add(pic_Logo);
            pnl_Cabecalho.Dock = DockStyle.Top;
            pnl_Cabecalho.ForeColor = SystemColors.HighlightText;
            pnl_Cabecalho.Location = new Point(0, 0);
            pnl_Cabecalho.Name = "pnl_Cabecalho";
            pnl_Cabecalho.Size = new Size(945, 100);
            pnl_Cabecalho.TabIndex = 5;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(462, 54);
            label1.Name = "label1";
            label1.Size = new Size(373, 27);
            label1.TabIndex = 3;
            label1.Text = "Finaliza  a movimentação do veículo no estacionado.";
            // 
            // lbl_Subtitulo
            // 
            lbl_Subtitulo.BackColor = Color.Transparent;
            lbl_Subtitulo.Font = new Font("Segoe Fluent Icons", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Subtitulo.ForeColor = Color.White;
            lbl_Subtitulo.Location = new Point(458, 9);
            lbl_Subtitulo.Name = "lbl_Subtitulo";
            lbl_Subtitulo.Size = new Size(238, 49);
            lbl_Subtitulo.TabIndex = 2;
            lbl_Subtitulo.Text = "Registrar Saída";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(434, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 65);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(162, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 65);
            panel2.TabIndex = 4;
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.BackColor = Color.Transparent;
            lbl_Titulo.Font = new Font("Segoe Fluent Icons", 45.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Titulo.ForeColor = Color.White;
            lbl_Titulo.Location = new Point(169, 4);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(259, 88);
            lbl_Titulo.TabIndex = 1;
            lbl_Titulo.Text = "UrbanPark";
            // 
            // pic_Logo
            // 
            pic_Logo.Image = Properties.Resources.logo;
            pic_Logo.Location = new Point(38, 12);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new Size(100, 73);
            pic_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Logo.TabIndex = 0;
            pic_Logo.TabStop = false;
            // 
            // btn_RegistrarSaida
            // 
            btn_RegistrarSaida.BackColor = Color.ForestGreen;
            btn_RegistrarSaida.FlatStyle = FlatStyle.Popup;
            btn_RegistrarSaida.Font = new Font("Segoe UI", 12F);
            btn_RegistrarSaida.ForeColor = Color.White;
            btn_RegistrarSaida.ImageAlign = ContentAlignment.MiddleLeft;
            btn_RegistrarSaida.ImageIndex = 0;
            btn_RegistrarSaida.ImageList = imgIconeConfirmar;
            btn_RegistrarSaida.Location = new Point(551, 589);
            btn_RegistrarSaida.Name = "btn_RegistrarSaida";
            btn_RegistrarSaida.Size = new Size(197, 33);
            btn_RegistrarSaida.TabIndex = 2;
            btn_RegistrarSaida.Text = "Registrar Entrada";
            btn_RegistrarSaida.UseVisualStyleBackColor = false;
            // 
            // imgIconeConfirmar
            // 
            imgIconeConfirmar.ColorDepth = ColorDepth.Depth32Bit;
            imgIconeConfirmar.ImageStream = (ImageListStreamer)resources.GetObject("imgIconeConfirmar.ImageStream");
            imgIconeConfirmar.TransparentColor = Color.Transparent;
            imgIconeConfirmar.Images.SetKeyName(0, "iconCheck.png");
            // 
            // grp_Movimentacao
            // 
            grp_Movimentacao.Controls.Add(dtp_InfoHrSaida);
            grp_Movimentacao.Controls.Add(lbl_HoraSaida);
            grp_Movimentacao.Controls.Add(dtp_InfoDtSaida);
            grp_Movimentacao.Controls.Add(lbl_DtHoraEntrada);
            grp_Movimentacao.Controls.Add(lbl_DataSaida);
            grp_Movimentacao.Controls.Add(lbl_DataHoraEntrada);
            grp_Movimentacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grp_Movimentacao.ForeColor = SystemColors.HotTrack;
            grp_Movimentacao.Location = new Point(434, 222);
            grp_Movimentacao.Name = "grp_Movimentacao";
            grp_Movimentacao.Size = new Size(499, 163);
            grp_Movimentacao.TabIndex = 7;
            grp_Movimentacao.TabStop = false;
            grp_Movimentacao.Text = "Movimentação";
            // 
            // dtp_InfoHrSaida
            // 
            dtp_InfoHrSaida.CalendarFont = new Font("Segoe UI", 12F);
            dtp_InfoHrSaida.CustomFormat = "HH:mm";
            dtp_InfoHrSaida.Font = new Font("Segoe UI", 12F);
            dtp_InfoHrSaida.Format = DateTimePickerFormat.Custom;
            dtp_InfoHrSaida.Location = new Point(363, 104);
            dtp_InfoHrSaida.Name = "dtp_InfoHrSaida";
            dtp_InfoHrSaida.ShowUpDown = true;
            dtp_InfoHrSaida.Size = new Size(104, 29);
            dtp_InfoHrSaida.TabIndex = 13;
            // 
            // lbl_HoraSaida
            // 
            lbl_HoraSaida.AutoSize = true;
            lbl_HoraSaida.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_HoraSaida.ForeColor = Color.Black;
            lbl_HoraSaida.Location = new Point(247, 108);
            lbl_HoraSaida.Name = "lbl_HoraSaida";
            lbl_HoraSaida.Size = new Size(109, 21);
            lbl_HoraSaida.TabIndex = 12;
            lbl_HoraSaida.Text = "Hora de Saída:";
            // 
            // dtp_InfoDtSaida
            // 
            dtp_InfoDtSaida.CalendarFont = new Font("Segoe UI", 12F);
            dtp_InfoDtSaida.Font = new Font("Segoe UI", 12F);
            dtp_InfoDtSaida.Format = DateTimePickerFormat.Short;
            dtp_InfoDtSaida.Location = new Point(117, 102);
            dtp_InfoDtSaida.Name = "dtp_InfoDtSaida";
            dtp_InfoDtSaida.Size = new Size(104, 29);
            dtp_InfoDtSaida.TabIndex = 11;
            // 
            // lbl_DtHoraEntrada
            // 
            lbl_DtHoraEntrada.CalendarFont = new Font("Segoe UI", 12F);
            lbl_DtHoraEntrada.CustomFormat = "dd/mm/yy HH:mm";
            lbl_DtHoraEntrada.Enabled = false;
            lbl_DtHoraEntrada.Font = new Font("Segoe UI", 12F);
            lbl_DtHoraEntrada.Format = DateTimePickerFormat.Custom;
            lbl_DtHoraEntrada.Location = new Point(205, 44);
            lbl_DtHoraEntrada.Name = "lbl_DtHoraEntrada";
            lbl_DtHoraEntrada.Size = new Size(262, 29);
            lbl_DtHoraEntrada.TabIndex = 10;
            // 
            // lbl_DataSaida
            // 
            lbl_DataSaida.AutoSize = true;
            lbl_DataSaida.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DataSaida.ForeColor = Color.Black;
            lbl_DataSaida.Location = new Point(24, 108);
            lbl_DataSaida.Name = "lbl_DataSaida";
            lbl_DataSaida.Size = new Size(87, 21);
            lbl_DataSaida.TabIndex = 2;
            lbl_DataSaida.Text = "Data Saída:";
            // 
            // lbl_DataHoraEntrada
            // 
            lbl_DataHoraEntrada.AutoSize = true;
            lbl_DataHoraEntrada.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DataHoraEntrada.ForeColor = Color.Black;
            lbl_DataHoraEntrada.Location = new Point(22, 49);
            lbl_DataHoraEntrada.Name = "lbl_DataHoraEntrada";
            lbl_DataHoraEntrada.Size = new Size(170, 21);
            lbl_DataHoraEntrada.TabIndex = 1;
            lbl_DataHoraEntrada.Text = "Data / Hora de Entrada:";
            // 
            // txt_InfoTempoPermanencia
            // 
            txt_InfoTempoPermanencia.BorderStyle = BorderStyle.FixedSingle;
            txt_InfoTempoPermanencia.Enabled = false;
            txt_InfoTempoPermanencia.Location = new Point(239, 28);
            txt_InfoTempoPermanencia.Name = "txt_InfoTempoPermanencia";
            txt_InfoTempoPermanencia.Size = new Size(241, 29);
            txt_InfoTempoPermanencia.TabIndex = 6;
            // 
            // lblTarifaVigente
            // 
            lblTarifaVigente.AutoSize = true;
            lblTarifaVigente.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTarifaVigente.ForeColor = Color.Black;
            lblTarifaVigente.Location = new Point(16, 76);
            lblTarifaVigente.Name = "lblTarifaVigente";
            lblTarifaVigente.Size = new Size(107, 21);
            lblTarifaVigente.TabIndex = 14;
            lblTarifaVigente.Text = "Tarifa Vigente:";
            // 
            // grpCalculo
            // 
            grpCalculo.Controls.Add(panel1);
            grpCalculo.Controls.Add(txt_InfoTarifa);
            grpCalculo.Controls.Add(lbl_TempoPermanencia);
            grpCalculo.Controls.Add(txt_InfoTempoPermanencia);
            grpCalculo.Controls.Add(lblTarifaVigente);
            grpCalculo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpCalculo.ForeColor = SystemColors.HotTrack;
            grpCalculo.Location = new Point(436, 397);
            grpCalculo.Name = "grpCalculo";
            grpCalculo.Size = new Size(497, 172);
            grpCalculo.TabIndex = 15;
            grpCalculo.TabStop = false;
            grpCalculo.Text = "Calculo do Estacionamento";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 247, 231);
            panel1.Controls.Add(lbl_ValorPagar);
            panel1.Controls.Add(lbl_ValorAPagar);
            panel1.Location = new Point(16, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 41);
            panel1.TabIndex = 19;
            // 
            // lbl_ValorPagar
            // 
            lbl_ValorPagar.AutoSize = true;
            lbl_ValorPagar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbl_ValorPagar.ForeColor = Color.Black;
            lbl_ValorPagar.Location = new Point(4, 8);
            lbl_ValorPagar.Name = "lbl_ValorPagar";
            lbl_ValorPagar.Size = new Size(131, 25);
            lbl_ValorPagar.TabIndex = 15;
            lbl_ValorPagar.Text = "Valor a Pagar:";
            // 
            // lbl_ValorAPagar
            // 
            lbl_ValorAPagar.AutoSize = true;
            lbl_ValorAPagar.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbl_ValorAPagar.ForeColor = Color.DarkGreen;
            lbl_ValorAPagar.Location = new Point(361, 5);
            lbl_ValorAPagar.Name = "lbl_ValorAPagar";
            lbl_ValorAPagar.Size = new Size(100, 32);
            lbl_ValorAPagar.TabIndex = 17;
            lbl_ValorAPagar.Text = "R$ 0,00";
            // 
            // txt_InfoTarifa
            // 
            txt_InfoTarifa.BorderStyle = BorderStyle.FixedSingle;
            txt_InfoTarifa.Enabled = false;
            txt_InfoTarifa.Location = new Point(239, 76);
            txt_InfoTarifa.Name = "txt_InfoTarifa";
            txt_InfoTarifa.Size = new Size(241, 29);
            txt_InfoTarifa.TabIndex = 18;
            // 
            // lbl_TempoPermanencia
            // 
            lbl_TempoPermanencia.AutoSize = true;
            lbl_TempoPermanencia.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_TempoPermanencia.ForeColor = Color.Black;
            lbl_TempoPermanencia.Location = new Point(16, 36);
            lbl_TempoPermanencia.Name = "lbl_TempoPermanencia";
            lbl_TempoPermanencia.Size = new Size(171, 21);
            lbl_TempoPermanencia.TabIndex = 16;
            lbl_TempoPermanencia.Text = "Tempo de Permanência:";
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
            btn_Cancelar.Location = new Point(786, 589);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(130, 33);
            btn_Cancelar.TabIndex = 16;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // imgIconeCancelar
            // 
            imgIconeCancelar.ColorDepth = ColorDepth.Depth32Bit;
            imgIconeCancelar.ImageStream = (ImageListStreamer)resources.GetObject("imgIconeCancelar.ImageStream");
            imgIconeCancelar.TransparentColor = Color.Transparent;
            imgIconeCancelar.Images.SetKeyName(0, "iconeCancelar.png");
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "iconeConfirmar.png");
            // 
            // frm_RegistrarSaida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 644);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_RegistrarSaida);
            Controls.Add(grpCalculo);
            Controls.Add(grp_Movimentacao);
            Controls.Add(pnl_Cabecalho);
            Controls.Add(grp_DadosVeiculo);
            Controls.Add(grp_BuscarVeiculo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_RegistrarSaida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " UrbanPark - Registrar Saída";
            Load += frm_RegistrarSaida_Load;
            grp_DadosVeiculo.ResumeLayout(false);
            grp_DadosVeiculo.PerformLayout();
            grp_BuscarVeiculo.ResumeLayout(false);
            grp_BuscarVeiculo.PerformLayout();
            pnl_Cabecalho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Logo).EndInit();
            grp_Movimentacao.ResumeLayout(false);
            grp_Movimentacao.PerformLayout();
            grpCalculo.ResumeLayout(false);
            grpCalculo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grp_DadosVeiculo;
        private TextBox txt_CorModelo;
        private TextBox txt_NomeCliente;
        private Label lbl_CorModelo;
        private Label lbl_Cliente;
        private GroupBox grp_BuscarVeiculo;
        private Label lbl_PlacaVeiculo;
        private Panel pnl_Cabecalho;
        private Label label1;
        private Label lbl_Subtitulo;
        private Label lbl_Titulo;
        private PictureBox pic_Logo;
        private Button btn_RegistrarSaida;
        private Label lbl_Vaga;
        private TextBox txt_NumeroVaga;
        private GroupBox grp_Movimentacao;
        private TextBox txt_InfoTempoPermanencia;
        private Label lbl_DataHoraEntrada;
        private Label lbl_DataSaida;
        private DateTimePicker dtp_InfoDtSaida;
        private DateTimePicker lbl_DtHoraEntrada;
        private Label lbl_HoraSaida;
        private DateTimePicker dtp_InfoHrSaida;
        private Label lblTarifaVigente;
        private GroupBox grpCalculo;
        private Label lbl_TempoPermanencia;
        private Label lbl_ValorPagar;
        private Label lbl_ValorAPagar;
        private TextBox txt_InfoTarifa;
        private Panel panel1;
        private MaskedTextBox msk_Placaveiculo;
        private Panel panel2;
        private Panel panel3;
        private Button btn_Cancelar;
        private ImageList imgIconeConfirmar;
        private ImageList imgIconeCancelar;
        private ImageList imageList1;
        private ImageList imgIconePesquisa;
        private Button btn_BuscarPorPlaca;
    }
}