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
            pnl_Cabecalho = new Panel();
            lbl_Subtitulo = new Label();
            lbl_Titulo = new Label();
            pic_Logo = new PictureBox();
            grp_BuscarVeiculo = new GroupBox();
            lbl_PlacaVeiculo = new Label();
            btn_BuscarPorPlaca = new Button();
            grp_DadosVeiculo = new GroupBox();
            lbl_CorModelo = new Label();
            lbl_Cliente = new Label();
            grp_Movimentacao = new GroupBox();
            lbl_VagaSelecionada = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btn_Cancelar = new Button();
            btn_RegistrarEntrada = new Button();
            txt_NomeCliente = new TextBox();
            txt_CorModelo = new TextBox();
            txt_PlacaVeiculo = new TextBox();
            txt_VagaSelecionada = new TextBox();
            lblDataEntrada = new Label();
            lbl_HoraDeEntrada = new Label();
            dtp_InfoDtEntrada = new DateTimePicker();
            dtp_InfoHrEntrada = new DateTimePicker();
            label1 = new Label();
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
            pnl_Cabecalho.BackColor = SystemColors.Highlight;
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
            // lbl_Subtitulo
            // 
            lbl_Subtitulo.BackColor = Color.Transparent;
            lbl_Subtitulo.Font = new Font("Segoe Fluent Icons", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Subtitulo.ForeColor = Color.White;
            lbl_Subtitulo.Location = new Point(417, 9);
            lbl_Subtitulo.Name = "lbl_Subtitulo";
            lbl_Subtitulo.Size = new Size(238, 49);
            lbl_Subtitulo.TabIndex = 2;
            lbl_Subtitulo.Text = "Registrar Entrada";
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.BackColor = Color.Transparent;
            lbl_Titulo.Font = new Font("Segoe Fluent Icons", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Titulo.ForeColor = Color.White;
            lbl_Titulo.Location = new Point(175, 9);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(259, 88);
            lbl_Titulo.TabIndex = 1;
            lbl_Titulo.Text = "UrbanPark";
            // 
            // pic_Logo
            // 
            pic_Logo.Location = new Point(38, 12);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new Size(100, 73);
            pic_Logo.TabIndex = 0;
            pic_Logo.TabStop = false;
            // 
            // grp_BuscarVeiculo
            // 
            grp_BuscarVeiculo.Controls.Add(txt_PlacaVeiculo);
            grp_BuscarVeiculo.Controls.Add(lbl_PlacaVeiculo);
            grp_BuscarVeiculo.Controls.Add(btn_BuscarPorPlaca);
            grp_BuscarVeiculo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grp_BuscarVeiculo.ForeColor = SystemColors.HotTrack;
            grp_BuscarVeiculo.Location = new Point(25, 120);
            grp_BuscarVeiculo.Name = "grp_BuscarVeiculo";
            grp_BuscarVeiculo.Size = new Size(839, 96);
            grp_BuscarVeiculo.TabIndex = 1;
            grp_BuscarVeiculo.TabStop = false;
            grp_BuscarVeiculo.Text = "Buscar Veículo";
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
            // btn_BuscarPorPlaca
            // 
            btn_BuscarPorPlaca.Location = new Point(490, 37);
            btn_BuscarPorPlaca.Name = "btn_BuscarPorPlaca";
            btn_BuscarPorPlaca.Size = new Size(220, 29);
            btn_BuscarPorPlaca.TabIndex = 0;
            btn_BuscarPorPlaca.Text = "Buscar por Placa";
            btn_BuscarPorPlaca.UseVisualStyleBackColor = true;
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
            grp_DadosVeiculo.TabIndex = 2;
            grp_DadosVeiculo.TabStop = false;
            grp_DadosVeiculo.Text = "Dados do Veículo";
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
            // lbl_VagaSelecionada
            // 
            lbl_VagaSelecionada.AutoSize = true;
            lbl_VagaSelecionada.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_VagaSelecionada.ForeColor = Color.Black;
            lbl_VagaSelecionada.Location = new Point(36, 39);
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
            btn_Cancelar.Location = new Point(750, 39);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(130, 33);
            btn_Cancelar.TabIndex = 3;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_RegistrarEntrada
            // 
            btn_RegistrarEntrada.Location = new Point(578, 39);
            btn_RegistrarEntrada.Name = "btn_RegistrarEntrada";
            btn_RegistrarEntrada.Size = new Size(130, 33);
            btn_RegistrarEntrada.TabIndex = 2;
            btn_RegistrarEntrada.Text = "Registrar Entrada";
            btn_RegistrarEntrada.UseVisualStyleBackColor = true;
            // 
            // txt_NomeCliente
            // 
            txt_NomeCliente.BorderStyle = BorderStyle.FixedSingle;
            txt_NomeCliente.Location = new Point(103, 39);
            txt_NomeCliente.Name = "txt_NomeCliente";
            txt_NomeCliente.Size = new Size(241, 29);
            txt_NomeCliente.TabIndex = 4;
            // 
            // txt_CorModelo
            // 
            txt_CorModelo.BorderStyle = BorderStyle.FixedSingle;
            txt_CorModelo.Location = new Point(150, 93);
            txt_CorModelo.Name = "txt_CorModelo";
            txt_CorModelo.Size = new Size(241, 29);
            txt_CorModelo.TabIndex = 5;
            // 
            // txt_PlacaVeiculo
            // 
            txt_PlacaVeiculo.BorderStyle = BorderStyle.FixedSingle;
            txt_PlacaVeiculo.Location = new Point(168, 49);
            txt_PlacaVeiculo.Name = "txt_PlacaVeiculo";
            txt_PlacaVeiculo.Size = new Size(241, 29);
            txt_PlacaVeiculo.TabIndex = 6;
            // 
            // txt_VagaSelecionada
            // 
            txt_VagaSelecionada.BorderStyle = BorderStyle.FixedSingle;
            txt_VagaSelecionada.Location = new Point(185, 34);
            txt_VagaSelecionada.Name = "txt_VagaSelecionada";
            txt_VagaSelecionada.Size = new Size(196, 29);
            txt_VagaSelecionada.TabIndex = 6;
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataEntrada.ForeColor = Color.Black;
            lblDataEntrada.Location = new Point(36, 78);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(123, 21);
            lblDataEntrada.TabIndex = 7;
            lblDataEntrada.Text = "Data de Entrada:";
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
            // dtp_InfoDtEntrada
            // 
            dtp_InfoDtEntrada.CalendarFont = new Font("Segoe UI", 12F);
            dtp_InfoDtEntrada.Font = new Font("Segoe UI", 12F);
            dtp_InfoDtEntrada.Format = DateTimePickerFormat.Short;
            dtp_InfoDtEntrada.Location = new Point(193, 78);
            dtp_InfoDtEntrada.Name = "dtp_InfoDtEntrada";
            dtp_InfoDtEntrada.Size = new Size(200, 29);
            dtp_InfoDtEntrada.TabIndex = 9;
            // 
            // dtp_InfoHrEntrada
            // 
            dtp_InfoHrEntrada.CalendarFont = new Font("Segoe UI", 12F);
            dtp_InfoHrEntrada.Font = new Font("Segoe UI", 12F);
            dtp_InfoHrEntrada.Format = DateTimePickerFormat.Time;
            dtp_InfoHrEntrada.Location = new Point(181, 125);
            dtp_InfoHrEntrada.Name = "dtp_InfoHrEntrada";
            dtp_InfoHrEntrada.Size = new Size(200, 29);
            dtp_InfoHrEntrada.TabIndex = 10;
            dtp_InfoHrEntrada.Value = new DateTime(2026, 11, 26, 10, 58, 0, 0);
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(417, 58);
            label1.Name = "label1";
            label1.Size = new Size(351, 39);
            label1.TabIndex = 3;
            label1.Text = "Inicia a movimentação do veículo no estacionado.";
            label1.Click += this.label1_Click;
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
            Name = "frm_RegistrarEntrada";
            Text = "UrbanPark - Registrar Entrada";
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
        private Button btn_BuscarPorPlaca;
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
        private TextBox txt_PlacaVeiculo;
        private TextBox txt_VagaSelecionada;
        private Label lblDataEntrada;
        private Label lbl_HoraDeEntrada;
        private DateTimePicker dtp_InfoDtEntrada;
        private DateTimePicker dtp_InfoHrEntrada;
        private Label label1;
    }
}
