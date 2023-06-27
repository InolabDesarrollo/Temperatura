namespace TemperaturaInolab
{
    partial class HomologarDatos
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
            menuStrip1 = new MenuStrip();
            toolStripContainer1 = new ToolStripContainer();
            adgvDatosSensores = new Zuby.ADGV.AdvancedDataGridView();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adgvDatosSensores).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(855, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(adgvDatosSensores);
            toolStripContainer1.ContentPanel.Size = new Size(855, 494);
            toolStripContainer1.Location = new Point(1, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(855, 518);
            toolStripContainer1.TabIndex = 1;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(menuStrip1);
            // 
            // adgvDatosSensores
            // 
            adgvDatosSensores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adgvDatosSensores.Dock = DockStyle.Fill;
            adgvDatosSensores.FilterAndSortEnabled = true;
            adgvDatosSensores.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            adgvDatosSensores.Location = new Point(0, 0);
            adgvDatosSensores.Name = "adgvDatosSensores";
            adgvDatosSensores.RightToLeft = RightToLeft.No;
            adgvDatosSensores.RowTemplate.Height = 25;
            adgvDatosSensores.Size = new Size(855, 494);
            adgvDatosSensores.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            adgvDatosSensores.TabIndex = 0;
            // 
            // HomologarDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 518);
            Controls.Add(toolStripContainer1);
            MainMenuStrip = menuStrip1;
            Name = "HomologarDatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomologarDatos";
            Load += HomologarDatos_Load;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adgvDatosSensores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripContainer toolStripContainer1;
        private Zuby.ADGV.AdvancedDataGridView adgvDatosSensores;
    }
}