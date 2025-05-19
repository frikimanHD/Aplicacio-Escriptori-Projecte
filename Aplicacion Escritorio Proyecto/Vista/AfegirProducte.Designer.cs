namespace Aplicacion_Escritorio_Proyecto.Vista
{
    partial class AfegirProducte
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
            this.CodiBarresTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.NomTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.DescripcioTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.CategoriaComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.PreuTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.StockTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.ConfirmarButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // CodiBarresTextBox
            // 
            this.CodiBarresTextBox.AllowPromptAsInput = true;
            this.CodiBarresTextBox.AnimateReadOnly = false;
            this.CodiBarresTextBox.AsciiOnly = false;
            this.CodiBarresTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CodiBarresTextBox.BeepOnError = false;
            this.CodiBarresTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.CodiBarresTextBox.Depth = 0;
            this.CodiBarresTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CodiBarresTextBox.HidePromptOnLeave = false;
            this.CodiBarresTextBox.HideSelection = true;
            this.CodiBarresTextBox.Hint = "Codi de barres";
            this.CodiBarresTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.CodiBarresTextBox.LeadingIcon = null;
            this.CodiBarresTextBox.Location = new System.Drawing.Point(6, 95);
            this.CodiBarresTextBox.Mask = "0000000000000";
            this.CodiBarresTextBox.MaxLength = 32767;
            this.CodiBarresTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CodiBarresTextBox.Name = "CodiBarresTextBox";
            this.CodiBarresTextBox.PasswordChar = '\0';
            this.CodiBarresTextBox.PrefixSuffixText = null;
            this.CodiBarresTextBox.PromptChar = '*';
            this.CodiBarresTextBox.ReadOnly = false;
            this.CodiBarresTextBox.RejectInputOnFirstFailure = false;
            this.CodiBarresTextBox.ResetOnPrompt = true;
            this.CodiBarresTextBox.ResetOnSpace = true;
            this.CodiBarresTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CodiBarresTextBox.SelectedText = "";
            this.CodiBarresTextBox.SelectionLength = 0;
            this.CodiBarresTextBox.SelectionStart = 0;
            this.CodiBarresTextBox.ShortcutsEnabled = true;
            this.CodiBarresTextBox.Size = new System.Drawing.Size(250, 48);
            this.CodiBarresTextBox.SkipLiterals = true;
            this.CodiBarresTextBox.TabIndex = 0;
            this.CodiBarresTextBox.TabStop = false;
            this.CodiBarresTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CodiBarresTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.CodiBarresTextBox.TrailingIcon = null;
            this.CodiBarresTextBox.UseSystemPasswordChar = false;
            this.CodiBarresTextBox.ValidatingType = null;
            // 
            // NomTextBox
            // 
            this.NomTextBox.AnimateReadOnly = false;
            this.NomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NomTextBox.Depth = 0;
            this.NomTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NomTextBox.Hint = "Nom";
            this.NomTextBox.LeadingIcon = null;
            this.NomTextBox.Location = new System.Drawing.Point(6, 149);
            this.NomTextBox.MaxLength = 100;
            this.NomTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.NomTextBox.Multiline = false;
            this.NomTextBox.Name = "NomTextBox";
            this.NomTextBox.Size = new System.Drawing.Size(250, 50);
            this.NomTextBox.TabIndex = 1;
            this.NomTextBox.Text = "";
            this.NomTextBox.TrailingIcon = null;
            // 
            // DescripcioTextBox
            // 
            this.DescripcioTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DescripcioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescripcioTextBox.Depth = 0;
            this.DescripcioTextBox.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DescripcioTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DescripcioTextBox.Hint = "Descripció";
            this.DescripcioTextBox.Location = new System.Drawing.Point(6, 205);
            this.DescripcioTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.DescripcioTextBox.Name = "DescripcioTextBox";
            this.DescripcioTextBox.Size = new System.Drawing.Size(250, 96);
            this.DescripcioTextBox.TabIndex = 2;
            this.DescripcioTextBox.Text = "";
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.AutoResize = false;
            this.CategoriaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CategoriaComboBox.Depth = 0;
            this.CategoriaComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CategoriaComboBox.DropDownHeight = 174;
            this.CategoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriaComboBox.DropDownWidth = 121;
            this.CategoriaComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CategoriaComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Hint = "Categoría";
            this.CategoriaComboBox.IntegralHeight = false;
            this.CategoriaComboBox.ItemHeight = 43;
            this.CategoriaComboBox.Items.AddRange(new object[] {
            "Verdura",
            "Congelat",
            "Lacti",
            "Fruita",
            "Miscel·lanis"});
            this.CategoriaComboBox.Location = new System.Drawing.Point(559, 94);
            this.CategoriaComboBox.MaxDropDownItems = 4;
            this.CategoriaComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(235, 49);
            this.CategoriaComboBox.StartIndex = 0;
            this.CategoriaComboBox.TabIndex = 3;
            // 
            // PreuTextBox
            // 
            this.PreuTextBox.AllowPromptAsInput = true;
            this.PreuTextBox.AnimateReadOnly = false;
            this.PreuTextBox.AsciiOnly = false;
            this.PreuTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PreuTextBox.BeepOnError = false;
            this.PreuTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.PreuTextBox.Depth = 0;
            this.PreuTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PreuTextBox.HidePromptOnLeave = false;
            this.PreuTextBox.HideSelection = true;
            this.PreuTextBox.Hint = "Preu";
            this.PreuTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.PreuTextBox.LeadingIcon = null;
            this.PreuTextBox.Location = new System.Drawing.Point(671, 149);
            this.PreuTextBox.Mask = "00.00";
            this.PreuTextBox.MaxLength = 32767;
            this.PreuTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PreuTextBox.Name = "PreuTextBox";
            this.PreuTextBox.PasswordChar = '\0';
            this.PreuTextBox.PrefixSuffixText = null;
            this.PreuTextBox.PromptChar = '_';
            this.PreuTextBox.ReadOnly = false;
            this.PreuTextBox.RejectInputOnFirstFailure = false;
            this.PreuTextBox.ResetOnPrompt = true;
            this.PreuTextBox.ResetOnSpace = true;
            this.PreuTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PreuTextBox.SelectedText = "";
            this.PreuTextBox.SelectionLength = 0;
            this.PreuTextBox.SelectionStart = 0;
            this.PreuTextBox.ShortcutsEnabled = true;
            this.PreuTextBox.Size = new System.Drawing.Size(123, 48);
            this.PreuTextBox.SkipLiterals = true;
            this.PreuTextBox.TabIndex = 4;
            this.PreuTextBox.TabStop = false;
            this.PreuTextBox.Text = "  .";
            this.PreuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PreuTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.PreuTextBox.TrailingIcon = null;
            this.PreuTextBox.UseSystemPasswordChar = false;
            this.PreuTextBox.ValidatingType = null;
            // 
            // StockTextBox
            // 
            this.StockTextBox.AllowPromptAsInput = true;
            this.StockTextBox.AnimateReadOnly = false;
            this.StockTextBox.AsciiOnly = false;
            this.StockTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StockTextBox.BeepOnError = false;
            this.StockTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.StockTextBox.Depth = 0;
            this.StockTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StockTextBox.HidePromptOnLeave = false;
            this.StockTextBox.HideSelection = true;
            this.StockTextBox.Hint = "Stock";
            this.StockTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.StockTextBox.LeadingIcon = null;
            this.StockTextBox.Location = new System.Drawing.Point(671, 214);
            this.StockTextBox.Mask = "00";
            this.StockTextBox.MaxLength = 32767;
            this.StockTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.PasswordChar = '\0';
            this.StockTextBox.PrefixSuffixText = null;
            this.StockTextBox.PromptChar = '_';
            this.StockTextBox.ReadOnly = false;
            this.StockTextBox.RejectInputOnFirstFailure = false;
            this.StockTextBox.ResetOnPrompt = true;
            this.StockTextBox.ResetOnSpace = true;
            this.StockTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StockTextBox.SelectedText = "";
            this.StockTextBox.SelectionLength = 0;
            this.StockTextBox.SelectionStart = 0;
            this.StockTextBox.ShortcutsEnabled = true;
            this.StockTextBox.Size = new System.Drawing.Size(123, 48);
            this.StockTextBox.SkipLiterals = true;
            this.StockTextBox.TabIndex = 5;
            this.StockTextBox.TabStop = false;
            this.StockTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StockTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.StockTextBox.TrailingIcon = null;
            this.StockTextBox.UseSystemPasswordChar = false;
            this.StockTextBox.ValidatingType = null;
            // 
            // ConfirmarButton
            // 
            this.ConfirmarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConfirmarButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ConfirmarButton.Depth = 0;
            this.ConfirmarButton.HighEmphasis = true;
            this.ConfirmarButton.Icon = null;
            this.ConfirmarButton.Location = new System.Drawing.Point(636, 271);
            this.ConfirmarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ConfirmarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConfirmarButton.Name = "ConfirmarButton";
            this.ConfirmarButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ConfirmarButton.Size = new System.Drawing.Size(158, 36);
            this.ConfirmarButton.TabIndex = 6;
            this.ConfirmarButton.Text = "Confirmar";
            this.ConfirmarButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ConfirmarButton.UseAccentColor = false;
            this.ConfirmarButton.UseVisualStyleBackColor = true;
            // 
            // AfegirProducte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 316);
            this.Controls.Add(this.ConfirmarButton);
            this.Controls.Add(this.StockTextBox);
            this.Controls.Add(this.PreuTextBox);
            this.Controls.Add(this.CategoriaComboBox);
            this.Controls.Add(this.DescripcioTextBox);
            this.Controls.Add(this.NomTextBox);
            this.Controls.Add(this.CodiBarresTextBox);
            this.Name = "AfegirProducte";
            this.Text = "Afegir/Modificar Producte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialMaskedTextBox CodiBarresTextBox;
        public MaterialSkin.Controls.MaterialTextBox NomTextBox;
        public MaterialSkin.Controls.MaterialMultiLineTextBox DescripcioTextBox;
        public MaterialSkin.Controls.MaterialComboBox CategoriaComboBox;
        public MaterialSkin.Controls.MaterialMaskedTextBox PreuTextBox;
        public MaterialSkin.Controls.MaterialMaskedTextBox StockTextBox;
        public MaterialSkin.Controls.MaterialButton ConfirmarButton;
    }
}