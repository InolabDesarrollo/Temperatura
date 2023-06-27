namespace TemperaturaInolab
{
    partial class Loading
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
            pbCarga = new PictureBox();
            lblCargando = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)pbCarga).BeginInit();
            SuspendLayout();
            // 
            // pbCarga
            // 
            pbCarga.BackColor = Color.Transparent;
            pbCarga.Location = new Point(43, 22);
            pbCarga.Name = "pbCarga";
            pbCarga.Size = new Size(212, 212);
            pbCarga.TabIndex = 0;
            pbCarga.TabStop = false;
            // 
            // lblCargando
            // 
            lblCargando.AutoSize = true;
            lblCargando.BackColor = Color.Transparent;
            lblCargando.Depth = 0;
            lblCargando.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCargando.Location = new Point(53, 237);
            lblCargando.MouseState = MaterialSkin.MouseState.HOVER;
            lblCargando.Name = "lblCargando";
            lblCargando.Size = new Size(82, 19);
            lblCargando.TabIndex = 1;
            lblCargando.Text = "Cargando...";
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 280);
            Controls.Add(lblCargando);
            Controls.Add(pbCarga);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loading";
            Opacity = 0.7D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading";
            Load += Loading_Load;
            ((System.ComponentModel.ISupportInitialize)pbCarga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbCarga;
        private MaterialSkin.Controls.MaterialLabel lblCargando;
    }
}