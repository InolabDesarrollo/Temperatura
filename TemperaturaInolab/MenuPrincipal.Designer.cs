namespace TemperaturaInolab
{
    partial class MenuPrincipal
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
            btnSeleccionarArchivo = new MaterialSkin.Controls.MaterialButton();
            rbCamaraC = new MaterialSkin.Controls.MaterialRadioButton();
            rbHornosM = new MaterialSkin.Controls.MaterialRadioButton();
            rbBanos = new MaterialSkin.Controls.MaterialRadioButton();
            rbAutoclaves = new MaterialSkin.Controls.MaterialRadioButton();
            openFileDialog1 = new OpenFileDialog();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            gbCantidades = new GroupBox();
            txtCantidadAdicionales = new MaterialSkin.Controls.MaterialTextBox2();
            txtCantidadSensores = new MaterialSkin.Controls.MaterialTextBox2();
            gbCantidades.SuspendLayout();
            SuspendLayout();
            // 
            // btnSeleccionarArchivo
            // 
            btnSeleccionarArchivo.AutoSize = false;
            btnSeleccionarArchivo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSeleccionarArchivo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSeleccionarArchivo.Depth = 0;
            btnSeleccionarArchivo.HighEmphasis = true;
            btnSeleccionarArchivo.Icon = null;
            btnSeleccionarArchivo.Location = new Point(118, 454);
            btnSeleccionarArchivo.Margin = new Padding(4, 6, 4, 6);
            btnSeleccionarArchivo.MouseState = MaterialSkin.MouseState.HOVER;
            btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            btnSeleccionarArchivo.NoAccentTextColor = Color.Empty;
            btnSeleccionarArchivo.Size = new Size(125, 36);
            btnSeleccionarArchivo.TabIndex = 4;
            btnSeleccionarArchivo.Text = "Seleccionar Archivo";
            btnSeleccionarArchivo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSeleccionarArchivo.UseAccentColor = false;
            btnSeleccionarArchivo.UseVisualStyleBackColor = true;
            btnSeleccionarArchivo.Click += btnSeleccionarArchivo_Click;
            // 
            // rbCamaraC
            // 
            rbCamaraC.AutoSize = true;
            rbCamaraC.Depth = 0;
            rbCamaraC.Location = new Point(62, 99);
            rbCamaraC.Margin = new Padding(0);
            rbCamaraC.MouseLocation = new Point(-1, -1);
            rbCamaraC.MouseState = MaterialSkin.MouseState.HOVER;
            rbCamaraC.Name = "rbCamaraC";
            rbCamaraC.Ripple = true;
            rbCamaraC.Size = new Size(257, 37);
            rbCamaraC.TabIndex = 5;
            rbCamaraC.TabStop = true;
            rbCamaraC.Text = "Camara Climatica / Incubadora";
            rbCamaraC.UseVisualStyleBackColor = true;
            rbCamaraC.CheckedChanged += rbCamaraC_CheckedChanged;
            // 
            // rbHornosM
            // 
            rbHornosM.AutoSize = true;
            rbHornosM.Depth = 0;
            rbHornosM.Location = new Point(62, 136);
            rbHornosM.Margin = new Padding(0);
            rbHornosM.MouseLocation = new Point(-1, -1);
            rbHornosM.MouseState = MaterialSkin.MouseState.HOVER;
            rbHornosM.Name = "rbHornosM";
            rbHornosM.Ripple = true;
            rbHornosM.Size = new Size(151, 37);
            rbHornosM.TabIndex = 6;
            rbHornosM.TabStop = true;
            rbHornosM.Text = "Hornos / Muflas";
            rbHornosM.UseVisualStyleBackColor = true;
            rbHornosM.CheckedChanged += rbHornosM_CheckedChanged;
            // 
            // rbBanos
            // 
            rbBanos.AutoSize = true;
            rbBanos.Depth = 0;
            rbBanos.Location = new Point(62, 173);
            rbBanos.Margin = new Padding(0);
            rbBanos.MouseLocation = new Point(-1, -1);
            rbBanos.MouseState = MaterialSkin.MouseState.HOVER;
            rbBanos.Name = "rbBanos";
            rbBanos.Ripple = true;
            rbBanos.Size = new Size(80, 37);
            rbBanos.TabIndex = 7;
            rbBanos.TabStop = true;
            rbBanos.Text = "Baños";
            rbBanos.UseVisualStyleBackColor = true;
            rbBanos.CheckedChanged += rbBanos_CheckedChanged;
            // 
            // rbAutoclaves
            // 
            rbAutoclaves.AutoSize = true;
            rbAutoclaves.Depth = 0;
            rbAutoclaves.Location = new Point(62, 210);
            rbAutoclaves.Margin = new Padding(0);
            rbAutoclaves.MouseLocation = new Point(-1, -1);
            rbAutoclaves.MouseState = MaterialSkin.MouseState.HOVER;
            rbAutoclaves.Name = "rbAutoclaves";
            rbAutoclaves.Ripple = true;
            rbAutoclaves.Size = new Size(113, 37);
            rbAutoclaves.TabIndex = 8;
            rbAutoclaves.TabStop = true;
            rbAutoclaves.Text = "Autoclaves";
            rbAutoclaves.UseVisualStyleBackColor = true;
            rbAutoclaves.CheckedChanged += rbAutoclaves_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(74, 37);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(70, 19);
            materialLabel1.TabIndex = 9;
            materialLabel1.Text = "Sensores:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(74, 104);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(87, 19);
            materialLabel2.TabIndex = 10;
            materialLabel2.Text = "Adicionales:";
            // 
            // gbCantidades
            // 
            gbCantidades.Controls.Add(txtCantidadAdicionales);
            gbCantidades.Controls.Add(txtCantidadSensores);
            gbCantidades.Controls.Add(materialLabel1);
            gbCantidades.Controls.Add(materialLabel2);
            gbCantidades.Location = new Point(6, 273);
            gbCantidades.Name = "gbCantidades";
            gbCantidades.Size = new Size(386, 143);
            gbCantidades.TabIndex = 11;
            gbCantidades.TabStop = false;
            gbCantidades.Text = "Cantidad de Sensores";
            gbCantidades.Visible = false;
            // 
            // txtCantidadAdicionales
            // 
            txtCantidadAdicionales.AnimateReadOnly = false;
            txtCantidadAdicionales.BackgroundImageLayout = ImageLayout.None;
            txtCantidadAdicionales.CharacterCasing = CharacterCasing.Normal;
            txtCantidadAdicionales.Depth = 0;
            txtCantidadAdicionales.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCantidadAdicionales.HideSelection = true;
            txtCantidadAdicionales.LeadingIcon = null;
            txtCantidadAdicionales.Location = new Point(167, 89);
            txtCantidadAdicionales.MaxLength = 32767;
            txtCantidadAdicionales.MouseState = MaterialSkin.MouseState.OUT;
            txtCantidadAdicionales.Name = "txtCantidadAdicionales";
            txtCantidadAdicionales.PasswordChar = '\0';
            txtCantidadAdicionales.PrefixSuffixText = null;
            txtCantidadAdicionales.ReadOnly = false;
            txtCantidadAdicionales.RightToLeft = RightToLeft.No;
            txtCantidadAdicionales.SelectedText = "";
            txtCantidadAdicionales.SelectionLength = 0;
            txtCantidadAdicionales.SelectionStart = 0;
            txtCantidadAdicionales.ShortcutsEnabled = true;
            txtCantidadAdicionales.Size = new Size(111, 48);
            txtCantidadAdicionales.TabIndex = 12;
            txtCantidadAdicionales.TabStop = false;
            txtCantidadAdicionales.TextAlign = HorizontalAlignment.Left;
            txtCantidadAdicionales.TrailingIcon = null;
            txtCantidadAdicionales.UseSystemPasswordChar = false;
            // 
            // txtCantidadSensores
            // 
            txtCantidadSensores.AnimateReadOnly = false;
            txtCantidadSensores.BackgroundImageLayout = ImageLayout.None;
            txtCantidadSensores.CharacterCasing = CharacterCasing.Normal;
            txtCantidadSensores.Depth = 0;
            txtCantidadSensores.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCantidadSensores.HideSelection = true;
            txtCantidadSensores.LeadingIcon = null;
            txtCantidadSensores.Location = new Point(168, 22);
            txtCantidadSensores.MaxLength = 32767;
            txtCantidadSensores.MouseState = MaterialSkin.MouseState.OUT;
            txtCantidadSensores.Name = "txtCantidadSensores";
            txtCantidadSensores.PasswordChar = '\0';
            txtCantidadSensores.PrefixSuffixText = null;
            txtCantidadSensores.ReadOnly = false;
            txtCantidadSensores.RightToLeft = RightToLeft.No;
            txtCantidadSensores.SelectedText = "";
            txtCantidadSensores.SelectionLength = 0;
            txtCantidadSensores.SelectionStart = 0;
            txtCantidadSensores.ShortcutsEnabled = true;
            txtCantidadSensores.Size = new Size(110, 48);
            txtCantidadSensores.TabIndex = 11;
            txtCantidadSensores.TabStop = false;
            txtCantidadSensores.TextAlign = HorizontalAlignment.Left;
            txtCantidadSensores.TrailingIcon = null;
            txtCantidadSensores.UseSystemPasswordChar = false;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 509);
            Controls.Add(gbCantidades);
            Controls.Add(rbAutoclaves);
            Controls.Add(rbBanos);
            Controls.Add(rbHornosM);
            Controls.Add(rbCamaraC);
            Controls.Add(btnSeleccionarArchivo);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            gbCantidades.ResumeLayout(false);
            gbCantidades.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnSeleccionarArchivo;
        private MaterialSkin.Controls.MaterialRadioButton rbCamaraC;
        private MaterialSkin.Controls.MaterialRadioButton rbHornosM;
        private MaterialSkin.Controls.MaterialRadioButton rbBanos;
        private MaterialSkin.Controls.MaterialRadioButton rbAutoclaves;
        private OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private GroupBox gbCantidades;
        private MaterialSkin.Controls.MaterialTextBox2 txtCantidadAdicionales;
        private MaterialSkin.Controls.MaterialTextBox2 txtCantidadSensores;
    }
}