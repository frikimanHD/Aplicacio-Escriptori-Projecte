namespace Aplicacion_Escritorio_Proyecto.Vista
{
    partial class EditarEstat
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
            this.EstatComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.ConfirmarButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // EstatComboBox
            // 
            this.EstatComboBox.AutoResize = false;
            this.EstatComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EstatComboBox.Depth = 0;
            this.EstatComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.EstatComboBox.DropDownHeight = 174;
            this.EstatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstatComboBox.DropDownWidth = 121;
            this.EstatComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.EstatComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EstatComboBox.FormattingEnabled = true;
            this.EstatComboBox.Hint = "Estat";
            this.EstatComboBox.IntegralHeight = false;
            this.EstatComboBox.ItemHeight = 43;
            this.EstatComboBox.Items.AddRange(new object[] {
            "No preparat",
            "Preparat",
            "Entregat"});
            this.EstatComboBox.Location = new System.Drawing.Point(54, 113);
            this.EstatComboBox.MaxDropDownItems = 4;
            this.EstatComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.EstatComboBox.Name = "EstatComboBox";
            this.EstatComboBox.Size = new System.Drawing.Size(165, 49);
            this.EstatComboBox.StartIndex = 0;
            this.EstatComboBox.TabIndex = 0;
            // 
            // ConfirmarButton
            // 
            this.ConfirmarButton.AutoSize = false;
            this.ConfirmarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConfirmarButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ConfirmarButton.Depth = 0;
            this.ConfirmarButton.HighEmphasis = true;
            this.ConfirmarButton.Icon = null;
            this.ConfirmarButton.Location = new System.Drawing.Point(64, 228);
            this.ConfirmarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ConfirmarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConfirmarButton.Name = "ConfirmarButton";
            this.ConfirmarButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ConfirmarButton.Size = new System.Drawing.Size(140, 42);
            this.ConfirmarButton.TabIndex = 1;
            this.ConfirmarButton.Text = "Confirmar";
            this.ConfirmarButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ConfirmarButton.UseAccentColor = false;
            this.ConfirmarButton.UseVisualStyleBackColor = true;
            // 
            // EditarEstat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 294);
            this.Controls.Add(this.ConfirmarButton);
            this.Controls.Add(this.EstatComboBox);
            this.Name = "EditarEstat";
            this.Text = "Editar Estat";
            this.ResumeLayout(false);

        }

        #endregion

        public MaterialSkin.Controls.MaterialComboBox EstatComboBox;
        public MaterialSkin.Controls.MaterialButton ConfirmarButton;
    }
}