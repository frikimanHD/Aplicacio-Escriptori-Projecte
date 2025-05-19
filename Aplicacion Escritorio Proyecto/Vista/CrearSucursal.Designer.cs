namespace Aplicacion_Escritorio_Proyecto.Vista
{
    partial class CrearSucursal
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
            this.DireccioSucursalTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.CrearSucursalButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(3, 64);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(434, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Per crear una sucursal només introdueix la direcció completa.";
            // 
            // DireccioSucursalTextBox
            // 
            this.DireccioSucursalTextBox.AnimateReadOnly = false;
            this.DireccioSucursalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DireccioSucursalTextBox.Depth = 0;
            this.DireccioSucursalTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DireccioSucursalTextBox.Hint = "Direcció";
            this.DireccioSucursalTextBox.LeadingIcon = null;
            this.DireccioSucursalTextBox.Location = new System.Drawing.Point(6, 223);
            this.DireccioSucursalTextBox.MaxLength = 200;
            this.DireccioSucursalTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.DireccioSucursalTextBox.Multiline = false;
            this.DireccioSucursalTextBox.Name = "DireccioSucursalTextBox";
            this.DireccioSucursalTextBox.Size = new System.Drawing.Size(363, 50);
            this.DireccioSucursalTextBox.TabIndex = 1;
            this.DireccioSucursalTextBox.Text = "";
            this.DireccioSucursalTextBox.TrailingIcon = null;
            // 
            // CrearSucursalButton
            // 
            this.CrearSucursalButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CrearSucursalButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CrearSucursalButton.Depth = 0;
            this.CrearSucursalButton.HighEmphasis = true;
            this.CrearSucursalButton.Icon = null;
            this.CrearSucursalButton.Location = new System.Drawing.Point(141, 405);
            this.CrearSucursalButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CrearSucursalButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CrearSucursalButton.Name = "CrearSucursalButton";
            this.CrearSucursalButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CrearSucursalButton.Size = new System.Drawing.Size(144, 36);
            this.CrearSucursalButton.TabIndex = 2;
            this.CrearSucursalButton.Text = "Crear sucursal";
            this.CrearSucursalButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CrearSucursalButton.UseAccentColor = false;
            this.CrearSucursalButton.UseVisualStyleBackColor = true;
            // 
            // CrearSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.CrearSucursalButton);
            this.Controls.Add(this.DireccioSucursalTextBox);
            this.Controls.Add(this.materialLabel1);
            this.Name = "CrearSucursal";
            this.Text = "Crear Sucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialTextBox DireccioSucursalTextBox;
        public MaterialSkin.Controls.MaterialButton CrearSucursalButton;
    }
}