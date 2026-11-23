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
            ctr_StatusVagas1 = new UrbanParkGerenciamento.Parts.ctr_StatusVagas();
            SuspendLayout();
            // 
            // ctr_StatusVagas1
            // 
            ctr_StatusVagas1.BackColor = Color.FromArgb(223, 247, 231);
            ctr_StatusVagas1.Location = new Point(126, 100);
            ctr_StatusVagas1.Name = "ctr_StatusVagas1";
            ctr_StatusVagas1.Size = new Size(150, 150);
            ctr_StatusVagas1.TabIndex = 0;
            // 
            // frm_ListVagas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ctr_StatusVagas1);
            Name = "frm_ListVagas";
            Text = "frm_ListVagas";
            ResumeLayout(false);
        }

        #endregion

        private Parts.ctr_StatusVagas ctr_StatusVagas1;
    }
}