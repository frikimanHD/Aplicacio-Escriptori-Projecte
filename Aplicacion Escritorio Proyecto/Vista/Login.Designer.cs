namespace Aplicacion_Escritorio_Proyecto.Vista
{
    partial class Login
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
            this.UsuariLoginTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.ContrasenyaLoginTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.LoginButton = new MaterialSkin.Controls.MaterialButton();
            this.labelError = new MaterialSkin.Controls.MaterialLabel();
            this.RegistrarseButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // UsuariLoginTextBox
            // 
            this.UsuariLoginTextBox.AnimateReadOnly = false;
            this.UsuariLoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsuariLoginTextBox.Depth = 0;
            this.UsuariLoginTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UsuariLoginTextBox.Hint = "Usuari";
            this.UsuariLoginTextBox.LeadingIcon = null;
            this.UsuariLoginTextBox.Location = new System.Drawing.Point(266, 147);
            this.UsuariLoginTextBox.MaxLength = 50;
            this.UsuariLoginTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.UsuariLoginTextBox.Multiline = false;
            this.UsuariLoginTextBox.Name = "UsuariLoginTextBox";
            this.UsuariLoginTextBox.Size = new System.Drawing.Size(239, 50);
            this.UsuariLoginTextBox.TabIndex = 0;
            this.UsuariLoginTextBox.Text = "";
            this.UsuariLoginTextBox.TrailingIcon = null;
            // 
            // ContrasenyaLoginTextBox
            // 
            this.ContrasenyaLoginTextBox.AnimateReadOnly = false;
            this.ContrasenyaLoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContrasenyaLoginTextBox.Depth = 0;
            this.ContrasenyaLoginTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ContrasenyaLoginTextBox.Hint = "Contrasenya";
            this.ContrasenyaLoginTextBox.LeadingIcon = null;
            this.ContrasenyaLoginTextBox.Location = new System.Drawing.Point(266, 237);
            this.ContrasenyaLoginTextBox.MaxLength = 50;
            this.ContrasenyaLoginTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ContrasenyaLoginTextBox.Multiline = false;
            this.ContrasenyaLoginTextBox.Name = "ContrasenyaLoginTextBox";
            this.ContrasenyaLoginTextBox.Password = true;
            this.ContrasenyaLoginTextBox.Size = new System.Drawing.Size(239, 50);
            this.ContrasenyaLoginTextBox.TabIndex = 1;
            this.ContrasenyaLoginTextBox.Text = "";
            this.ContrasenyaLoginTextBox.TrailingIcon = null;
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = false;
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LoginButton.Depth = 0;
            this.LoginButton.HighEmphasis = true;
            this.LoginButton.Icon = null;
            this.LoginButton.Location = new System.Drawing.Point(382, 327);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LoginButton.Size = new System.Drawing.Size(123, 36);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoginButton.UseAccentColor = false;
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Depth = 0;
            this.labelError.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelError.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelError.Location = new System.Drawing.Point(266, 294);
            this.labelError.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(1, 0);
            this.labelError.TabIndex = 3;
            // 
            // RegistrarseButton
            // 
            this.RegistrarseButton.AutoSize = false;
            this.RegistrarseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegistrarseButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RegistrarseButton.Depth = 0;
            this.RegistrarseButton.HighEmphasis = true;
            this.RegistrarseButton.Icon = null;
            this.RegistrarseButton.Location = new System.Drawing.Point(251, 327);
            this.RegistrarseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegistrarseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegistrarseButton.Name = "RegistrarseButton";
            this.RegistrarseButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RegistrarseButton.Size = new System.Drawing.Size(123, 36);
            this.RegistrarseButton.TabIndex = 4;
            this.RegistrarseButton.Text = "Registrar-se";
            this.RegistrarseButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RegistrarseButton.UseAccentColor = false;
            this.RegistrarseButton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegistrarseButton);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ContrasenyaLoginTextBox);
            this.Controls.Add(this.UsuariLoginTextBox);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MaterialSkin.Controls.MaterialTextBox UsuariLoginTextBox;
        public MaterialSkin.Controls.MaterialTextBox ContrasenyaLoginTextBox;
        public MaterialSkin.Controls.MaterialButton LoginButton;
        public MaterialSkin.Controls.MaterialLabel labelError;
        public MaterialSkin.Controls.MaterialButton RegistrarseButton;
    }
}