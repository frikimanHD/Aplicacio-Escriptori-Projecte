namespace Aplicacion_Escritorio_Proyecto.Vista
{
    partial class SeleccionarSucursal
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
            this.SucursalsComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SeleccionarButton = new MaterialSkin.Controls.MaterialButton();
            this.CrearSucursalButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // SucursalsComboBox
            // 
            this.SucursalsComboBox.AutoResize = false;
            this.SucursalsComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SucursalsComboBox.Depth = 0;
            this.SucursalsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SucursalsComboBox.DropDownHeight = 174;
            this.SucursalsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SucursalsComboBox.DropDownWidth = 121;
            this.SucursalsComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SucursalsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SucursalsComboBox.FormattingEnabled = true;
            this.SucursalsComboBox.IntegralHeight = false;
            this.SucursalsComboBox.ItemHeight = 43;
            this.SucursalsComboBox.Location = new System.Drawing.Point(119, 192);
            this.SucursalsComboBox.MaxDropDownItems = 4;
            this.SucursalsComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.SucursalsComboBox.Name = "SucursalsComboBox";
            this.SucursalsComboBox.Size = new System.Drawing.Size(237, 49);
            this.SucursalsComboBox.StartIndex = 0;
            this.SucursalsComboBox.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(309, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Selecciona sucursal en la que vols treballar.";
            // 
            // SeleccionarButton
            // 
            this.SeleccionarButton.AutoSize = false;
            this.SeleccionarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SeleccionarButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SeleccionarButton.Depth = 0;
            this.SeleccionarButton.HighEmphasis = true;
            this.SeleccionarButton.Icon = null;
            this.SeleccionarButton.Location = new System.Drawing.Point(261, 382);
            this.SeleccionarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SeleccionarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SeleccionarButton.Name = "SeleccionarButton";
            this.SeleccionarButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SeleccionarButton.Size = new System.Drawing.Size(189, 36);
            this.SeleccionarButton.TabIndex = 2;
            this.SeleccionarButton.Text = "Seleccionar sucursal";
            this.SeleccionarButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SeleccionarButton.UseAccentColor = false;
            this.SeleccionarButton.UseVisualStyleBackColor = true;
            // 
            // CrearSucursalButton
            // 
            this.CrearSucursalButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CrearSucursalButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CrearSucursalButton.Depth = 0;
            this.CrearSucursalButton.HighEmphasis = true;
            this.CrearSucursalButton.Icon = null;
            this.CrearSucursalButton.Location = new System.Drawing.Point(35, 382);
            this.CrearSucursalButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CrearSucursalButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CrearSucursalButton.Name = "CrearSucursalButton";
            this.CrearSucursalButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CrearSucursalButton.Size = new System.Drawing.Size(158, 36);
            this.CrearSucursalButton.TabIndex = 3;
            this.CrearSucursalButton.Text = "Crear sucursal";
            this.CrearSucursalButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CrearSucursalButton.UseAccentColor = false;
            this.CrearSucursalButton.UseVisualStyleBackColor = true;
            // 
            // SeleccionarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.CrearSucursalButton);
            this.Controls.Add(this.SeleccionarButton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.SucursalsComboBox);
            this.Name = "SeleccionarSucursal";
            this.Text = "Seleccionar Sucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialComboBox SucursalsComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialButton SeleccionarButton;
        public MaterialSkin.Controls.MaterialButton CrearSucursalButton;
    }
}