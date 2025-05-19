namespace Aplicacion_Escritorio_Proyecto.Vista
{
    partial class CrearComerç
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.nomComerçTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.telefonComerçTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.emailComerçTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.NIFComerçTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.registrarComerçButton = new MaterialSkin.Controls.MaterialButton();
            this.ErrorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 75);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(340, 42);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "No tens un comerç registrat.\r\nEnregistra el teu per poder utilitzar el programa.";
            // 
            // nomComerçTextBox
            // 
            this.nomComerçTextBox.AnimateReadOnly = false;
            this.nomComerçTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomComerçTextBox.Depth = 0;
            this.nomComerçTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nomComerçTextBox.Hint = "Nom";
            this.nomComerçTextBox.LeadingIcon = null;
            this.nomComerçTextBox.Location = new System.Drawing.Point(9, 146);
            this.nomComerçTextBox.MaxLength = 50;
            this.nomComerçTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.nomComerçTextBox.Multiline = false;
            this.nomComerçTextBox.Name = "nomComerçTextBox";
            this.nomComerçTextBox.Size = new System.Drawing.Size(250, 50);
            this.nomComerçTextBox.TabIndex = 1;
            this.nomComerçTextBox.Text = "";
            this.nomComerçTextBox.TrailingIcon = null;
            // 
            // telefonComerçTextBox
            // 
            this.telefonComerçTextBox.AllowPromptAsInput = true;
            this.telefonComerçTextBox.AnimateReadOnly = false;
            this.telefonComerçTextBox.AsciiOnly = false;
            this.telefonComerçTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.telefonComerçTextBox.BeepOnError = false;
            this.telefonComerçTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.telefonComerçTextBox.Depth = 0;
            this.telefonComerçTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.telefonComerçTextBox.HidePromptOnLeave = false;
            this.telefonComerçTextBox.HideSelection = true;
            this.telefonComerçTextBox.Hint = "Telefon";
            this.telefonComerçTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.telefonComerçTextBox.LeadingIcon = null;
            this.telefonComerçTextBox.Location = new System.Drawing.Point(9, 216);
            this.telefonComerçTextBox.Mask = "+00-000-00-00-00";
            this.telefonComerçTextBox.MaxLength = 32767;
            this.telefonComerçTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.telefonComerçTextBox.Name = "telefonComerçTextBox";
            this.telefonComerçTextBox.PasswordChar = '\0';
            this.telefonComerçTextBox.PrefixSuffixText = null;
            this.telefonComerçTextBox.PromptChar = '_';
            this.telefonComerçTextBox.ReadOnly = false;
            this.telefonComerçTextBox.RejectInputOnFirstFailure = false;
            this.telefonComerçTextBox.ResetOnPrompt = true;
            this.telefonComerçTextBox.ResetOnSpace = true;
            this.telefonComerçTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.telefonComerçTextBox.SelectedText = "";
            this.telefonComerçTextBox.SelectionLength = 0;
            this.telefonComerçTextBox.SelectionStart = 0;
            this.telefonComerçTextBox.ShortcutsEnabled = true;
            this.telefonComerçTextBox.Size = new System.Drawing.Size(250, 48);
            this.telefonComerçTextBox.SkipLiterals = true;
            this.telefonComerçTextBox.TabIndex = 2;
            this.telefonComerçTextBox.TabStop = false;
            this.telefonComerçTextBox.Text = "+  -   -  -  -";
            this.telefonComerçTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.telefonComerçTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.telefonComerçTextBox.TrailingIcon = null;
            this.telefonComerçTextBox.UseSystemPasswordChar = false;
            this.telefonComerçTextBox.ValidatingType = null;
            // 
            // emailComerçTextBox
            // 
            this.emailComerçTextBox.AnimateReadOnly = false;
            this.emailComerçTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailComerçTextBox.Depth = 0;
            this.emailComerçTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emailComerçTextBox.Hint = "Email";
            this.emailComerçTextBox.LeadingIcon = null;
            this.emailComerçTextBox.Location = new System.Drawing.Point(9, 281);
            this.emailComerçTextBox.MaxLength = 50;
            this.emailComerçTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.emailComerçTextBox.Multiline = false;
            this.emailComerçTextBox.Name = "emailComerçTextBox";
            this.emailComerçTextBox.Size = new System.Drawing.Size(250, 50);
            this.emailComerçTextBox.TabIndex = 3;
            this.emailComerçTextBox.Text = "";
            this.emailComerçTextBox.TrailingIcon = null;
            // 
            // NIFComerçTextBox
            // 
            this.NIFComerçTextBox.AnimateReadOnly = false;
            this.NIFComerçTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NIFComerçTextBox.Depth = 0;
            this.NIFComerçTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NIFComerçTextBox.Hint = "NIF";
            this.NIFComerçTextBox.LeadingIcon = null;
            this.NIFComerçTextBox.Location = new System.Drawing.Point(9, 349);
            this.NIFComerçTextBox.MaxLength = 50;
            this.NIFComerçTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.NIFComerçTextBox.Multiline = false;
            this.NIFComerçTextBox.Name = "NIFComerçTextBox";
            this.NIFComerçTextBox.Size = new System.Drawing.Size(250, 50);
            this.NIFComerçTextBox.TabIndex = 4;
            this.NIFComerçTextBox.Text = "";
            this.NIFComerçTextBox.TrailingIcon = null;
            // 
            // registrarComerçButton
            // 
            this.registrarComerçButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registrarComerçButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.registrarComerçButton.Depth = 0;
            this.registrarComerçButton.HighEmphasis = true;
            this.registrarComerçButton.Icon = null;
            this.registrarComerçButton.Location = new System.Drawing.Point(156, 434);
            this.registrarComerçButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registrarComerçButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registrarComerçButton.Name = "registrarComerçButton";
            this.registrarComerçButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.registrarComerçButton.Size = new System.Drawing.Size(163, 36);
            this.registrarComerçButton.TabIndex = 5;
            this.registrarComerçButton.Text = "Registrar comerç";
            this.registrarComerçButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.registrarComerçButton.UseAccentColor = false;
            this.registrarComerçButton.UseVisualStyleBackColor = true;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Depth = 0;
            this.ErrorLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ErrorLabel.Location = new System.Drawing.Point(9, 406);
            this.ErrorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(1, 0);
            this.ErrorLabel.TabIndex = 6;
            // 
            // CrearComerç
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 501);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.registrarComerçButton);
            this.Controls.Add(this.NIFComerçTextBox);
            this.Controls.Add(this.emailComerçTextBox);
            this.Controls.Add(this.telefonComerçTextBox);
            this.Controls.Add(this.nomComerçTextBox);
            this.Controls.Add(this.materialLabel1);
            this.Name = "CrearComerç";
            this.Text = "Crear Comerç";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialTextBox NIFComerçTextBox;
        public MaterialSkin.Controls.MaterialButton registrarComerçButton;
        public MaterialSkin.Controls.MaterialTextBox nomComerçTextBox;
        public MaterialSkin.Controls.MaterialMaskedTextBox telefonComerçTextBox;
        public MaterialSkin.Controls.MaterialTextBox emailComerçTextBox;
        public MaterialSkin.Controls.MaterialLabel ErrorLabel;
    }
}