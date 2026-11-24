namespace UrbanParkGerenciamento
{
    partial class frm_ListVagas
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
            flw_CardVagas = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flw_CardVagas
            // 
            flw_CardVagas.Dock = DockStyle.Fill;
            flw_CardVagas.Location = new Point(0, 0);
            flw_CardVagas.Name = "flw_CardVagas";
            flw_CardVagas.Size = new Size(800, 450);
            flw_CardVagas.TabIndex = 0;
            // 
            // frm_ListVagas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flw_CardVagas);
            Name = "frm_ListVagas";
            Text = "frm_ListVagas";
            Load += frm_ListVagas_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flw_CardVagas;
    }
}