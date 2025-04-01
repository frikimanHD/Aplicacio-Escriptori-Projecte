namespace Aplicacion_Escritorio_Proyecto
{
    partial class Form1
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
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.CercarComandesComboBox = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ListViewProductes = new MaterialSkin.Controls.MaterialListView();
            this.CodiDeBarres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Imatge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descripcio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AfegirProducteButton = new MaterialSkin.Controls.MaterialButton();
            this.EliminarProducteButton = new MaterialSkin.Controls.MaterialButton();
            this.ModificarProducteButton = new MaterialSkin.Controls.MaterialButton();
            this.CercarProductesTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.CercarProductesComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.RefrescarProductesButton = new MaterialSkin.Controls.MaterialButton();
            this.EliminarComandesButton = new MaterialSkin.Controls.MaterialButton();
            this.ModEstatComandaButton = new MaterialSkin.Controls.MaterialButton();
            this.GenerarFacturaComandaButton = new MaterialSkin.Controls.MaterialButton();
            this.ComandesListView = new MaterialSkin.Controls.MaterialListView();
            this.Numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PreuTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pagat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Recollida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumProductes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.CodiDeBarresComanda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomProducteComanda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantitatComanda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PreuProducteComanda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CercarComandesTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.NomComerçTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.DireccioComerçTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.NIFComerçTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.TelefonComerçTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.EmailComerçTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialListView2 = new MaterialSkin.Controls.MaterialListView();
            this.NomClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CercarComandesComboBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-250, 67);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(250, 120);
            this.materialDrawer1.TabIndex = 0;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // CercarComandesComboBox
            // 
            this.CercarComandesComboBox.Controls.Add(this.tabPage1);
            this.CercarComandesComboBox.Controls.Add(this.tabPage2);
            this.CercarComandesComboBox.Controls.Add(this.tabPage4);
            this.CercarComandesComboBox.Controls.Add(this.tabPage5);
            this.CercarComandesComboBox.Depth = 0;
            this.CercarComandesComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CercarComandesComboBox.Location = new System.Drawing.Point(3, 64);
            this.CercarComandesComboBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.CercarComandesComboBox.Multiline = true;
            this.CercarComandesComboBox.Name = "CercarComandesComboBox";
            this.CercarComandesComboBox.SelectedIndex = 0;
            this.CercarComandesComboBox.Size = new System.Drawing.Size(1185, 683);
            this.CercarComandesComboBox.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RefrescarProductesButton);
            this.tabPage1.Controls.Add(this.CercarProductesComboBox);
            this.tabPage1.Controls.Add(this.CercarProductesTextBox);
            this.tabPage1.Controls.Add(this.ModificarProducteButton);
            this.tabPage1.Controls.Add(this.EliminarProducteButton);
            this.tabPage1.Controls.Add(this.AfegirProducteButton);
            this.tabPage1.Controls.Add(this.ListViewProductes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1177, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CercarComandesTextBox);
            this.tabPage2.Controls.Add(this.materialListView1);
            this.tabPage2.Controls.Add(this.materialComboBox1);
            this.tabPage2.Controls.Add(this.ComandesListView);
            this.tabPage2.Controls.Add(this.GenerarFacturaComandaButton);
            this.tabPage2.Controls.Add(this.ModEstatComandaButton);
            this.tabPage2.Controls.Add(this.EliminarComandesButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1177, 657);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comandes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.EmailComerçTextBox);
            this.tabPage4.Controls.Add(this.TelefonComerçTextBox);
            this.tabPage4.Controls.Add(this.materialButton1);
            this.tabPage4.Controls.Add(this.NIFComerçTextBox);
            this.tabPage4.Controls.Add(this.DireccioComerçTextBox);
            this.tabPage4.Controls.Add(this.NomComerçTextBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1177, 657);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Info comerç";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.materialListView2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1177, 657);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Clients";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ListViewProductes
            // 
            this.ListViewProductes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewProductes.AutoSizeTable = false;
            this.ListViewProductes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListViewProductes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewProductes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodiDeBarres,
            this.Nom,
            this.Imatge,
            this.Descripcio,
            this.Preu,
            this.Stock,
            this.Categories});
            this.ListViewProductes.Depth = 0;
            this.ListViewProductes.FullRowSelect = true;
            this.ListViewProductes.HideSelection = false;
            this.ListViewProductes.Location = new System.Drawing.Point(6, 124);
            this.ListViewProductes.MinimumSize = new System.Drawing.Size(200, 100);
            this.ListViewProductes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListViewProductes.MouseState = MaterialSkin.MouseState.OUT;
            this.ListViewProductes.Name = "ListViewProductes";
            this.ListViewProductes.OwnerDraw = true;
            this.ListViewProductes.Size = new System.Drawing.Size(1165, 527);
            this.ListViewProductes.TabIndex = 0;
            this.ListViewProductes.UseCompatibleStateImageBehavior = false;
            this.ListViewProductes.View = System.Windows.Forms.View.Details;
            // 
            // CodiDeBarres
            // 
            this.CodiDeBarres.Text = "Codi de barres";
            this.CodiDeBarres.Width = 141;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nom.Width = 153;
            // 
            // Imatge
            // 
            this.Imatge.Text = "Imatge";
            this.Imatge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Imatge.Width = 105;
            // 
            // Descripcio
            // 
            this.Descripcio.Text = "Descripcio";
            this.Descripcio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Descripcio.Width = 185;
            // 
            // Preu
            // 
            this.Preu.Text = "Preu";
            this.Preu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Preu.Width = 86;
            // 
            // Stock
            // 
            this.Stock.Text = "Stock";
            this.Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Stock.Width = 84;
            // 
            // Categories
            // 
            this.Categories.Text = "Categories";
            this.Categories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Categories.Width = 135;
            // 
            // AfegirProducteButton
            // 
            this.AfegirProducteButton.AutoSize = false;
            this.AfegirProducteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AfegirProducteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AfegirProducteButton.Depth = 0;
            this.AfegirProducteButton.HighEmphasis = true;
            this.AfegirProducteButton.Icon = null;
            this.AfegirProducteButton.Location = new System.Drawing.Point(6, 79);
            this.AfegirProducteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AfegirProducteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AfegirProducteButton.Name = "AfegirProducteButton";
            this.AfegirProducteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AfegirProducteButton.Size = new System.Drawing.Size(128, 36);
            this.AfegirProducteButton.TabIndex = 1;
            this.AfegirProducteButton.Text = "Afegir";
            this.AfegirProducteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AfegirProducteButton.UseAccentColor = false;
            this.AfegirProducteButton.UseVisualStyleBackColor = true;
            // 
            // EliminarProducteButton
            // 
            this.EliminarProducteButton.AutoSize = false;
            this.EliminarProducteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EliminarProducteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EliminarProducteButton.Depth = 0;
            this.EliminarProducteButton.HighEmphasis = true;
            this.EliminarProducteButton.Icon = null;
            this.EliminarProducteButton.Location = new System.Drawing.Point(162, 79);
            this.EliminarProducteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EliminarProducteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EliminarProducteButton.Name = "EliminarProducteButton";
            this.EliminarProducteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EliminarProducteButton.Size = new System.Drawing.Size(128, 36);
            this.EliminarProducteButton.TabIndex = 2;
            this.EliminarProducteButton.Text = "Eliminar";
            this.EliminarProducteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EliminarProducteButton.UseAccentColor = false;
            this.EliminarProducteButton.UseVisualStyleBackColor = true;
            // 
            // ModificarProducteButton
            // 
            this.ModificarProducteButton.AutoSize = false;
            this.ModificarProducteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModificarProducteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ModificarProducteButton.Depth = 0;
            this.ModificarProducteButton.HighEmphasis = true;
            this.ModificarProducteButton.Icon = null;
            this.ModificarProducteButton.Location = new System.Drawing.Point(318, 79);
            this.ModificarProducteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ModificarProducteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModificarProducteButton.Name = "ModificarProducteButton";
            this.ModificarProducteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ModificarProducteButton.Size = new System.Drawing.Size(128, 36);
            this.ModificarProducteButton.TabIndex = 3;
            this.ModificarProducteButton.Text = "Modificar";
            this.ModificarProducteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ModificarProducteButton.UseAccentColor = false;
            this.ModificarProducteButton.UseVisualStyleBackColor = true;
            // 
            // CercarProductesTextBox
            // 
            this.CercarProductesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CercarProductesTextBox.AnimateReadOnly = false;
            this.CercarProductesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CercarProductesTextBox.Depth = 0;
            this.CercarProductesTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CercarProductesTextBox.Hint = "Cercar";
            this.CercarProductesTextBox.LeadingIcon = null;
            this.CercarProductesTextBox.Location = new System.Drawing.Point(996, 65);
            this.CercarProductesTextBox.MaxLength = 50;
            this.CercarProductesTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CercarProductesTextBox.Multiline = false;
            this.CercarProductesTextBox.Name = "CercarProductesTextBox";
            this.CercarProductesTextBox.Size = new System.Drawing.Size(175, 50);
            this.CercarProductesTextBox.TabIndex = 4;
            this.CercarProductesTextBox.Text = "";
            this.CercarProductesTextBox.TrailingIcon = null;
            // 
            // CercarProductesComboBox
            // 
            this.CercarProductesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CercarProductesComboBox.AutoResize = false;
            this.CercarProductesComboBox.BackColor = System.Drawing.Color.White;
            this.CercarProductesComboBox.Depth = 0;
            this.CercarProductesComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CercarProductesComboBox.DropDownHeight = 174;
            this.CercarProductesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CercarProductesComboBox.DropDownWidth = 121;
            this.CercarProductesComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CercarProductesComboBox.ForeColor = System.Drawing.Color.Black;
            this.CercarProductesComboBox.FormattingEnabled = true;
            this.CercarProductesComboBox.IntegralHeight = false;
            this.CercarProductesComboBox.ItemHeight = 43;
            this.CercarProductesComboBox.Items.AddRange(new object[] {
            "Codi de barres",
            "Nom",
            "Preu",
            "Stock",
            "Categories"});
            this.CercarProductesComboBox.Location = new System.Drawing.Point(996, 10);
            this.CercarProductesComboBox.MaxDropDownItems = 4;
            this.CercarProductesComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CercarProductesComboBox.Name = "CercarProductesComboBox";
            this.CercarProductesComboBox.Size = new System.Drawing.Size(175, 49);
            this.CercarProductesComboBox.StartIndex = 0;
            this.CercarProductesComboBox.TabIndex = 5;
            // 
            // RefrescarProductesButton
            // 
            this.RefrescarProductesButton.AutoSize = false;
            this.RefrescarProductesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RefrescarProductesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RefrescarProductesButton.Depth = 0;
            this.RefrescarProductesButton.HighEmphasis = true;
            this.RefrescarProductesButton.Icon = null;
            this.RefrescarProductesButton.Location = new System.Drawing.Point(7, 23);
            this.RefrescarProductesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RefrescarProductesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RefrescarProductesButton.Name = "RefrescarProductesButton";
            this.RefrescarProductesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RefrescarProductesButton.Size = new System.Drawing.Size(127, 36);
            this.RefrescarProductesButton.TabIndex = 6;
            this.RefrescarProductesButton.Text = "Refrescar";
            this.RefrescarProductesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RefrescarProductesButton.UseAccentColor = false;
            this.RefrescarProductesButton.UseVisualStyleBackColor = true;
            // 
            // EliminarComandesButton
            // 
            this.EliminarComandesButton.AutoSize = false;
            this.EliminarComandesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EliminarComandesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EliminarComandesButton.Depth = 0;
            this.EliminarComandesButton.HighEmphasis = true;
            this.EliminarComandesButton.Icon = null;
            this.EliminarComandesButton.Location = new System.Drawing.Point(6, 43);
            this.EliminarComandesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EliminarComandesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EliminarComandesButton.Name = "EliminarComandesButton";
            this.EliminarComandesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EliminarComandesButton.Size = new System.Drawing.Size(122, 36);
            this.EliminarComandesButton.TabIndex = 0;
            this.EliminarComandesButton.Text = "Eliminar";
            this.EliminarComandesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EliminarComandesButton.UseAccentColor = false;
            this.EliminarComandesButton.UseVisualStyleBackColor = true;
            // 
            // ModEstatComandaButton
            // 
            this.ModEstatComandaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModEstatComandaButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ModEstatComandaButton.Depth = 0;
            this.ModEstatComandaButton.HighEmphasis = true;
            this.ModEstatComandaButton.Icon = null;
            this.ModEstatComandaButton.Location = new System.Drawing.Point(151, 43);
            this.ModEstatComandaButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ModEstatComandaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModEstatComandaButton.Name = "ModEstatComandaButton";
            this.ModEstatComandaButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ModEstatComandaButton.Size = new System.Drawing.Size(148, 36);
            this.ModEstatComandaButton.TabIndex = 1;
            this.ModEstatComandaButton.Text = "Modificar estat";
            this.ModEstatComandaButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ModEstatComandaButton.UseAccentColor = false;
            this.ModEstatComandaButton.UseVisualStyleBackColor = true;
            // 
            // GenerarFacturaComandaButton
            // 
            this.GenerarFacturaComandaButton.AutoSize = false;
            this.GenerarFacturaComandaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenerarFacturaComandaButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.GenerarFacturaComandaButton.Depth = 0;
            this.GenerarFacturaComandaButton.HighEmphasis = true;
            this.GenerarFacturaComandaButton.Icon = null;
            this.GenerarFacturaComandaButton.Location = new System.Drawing.Point(323, 43);
            this.GenerarFacturaComandaButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GenerarFacturaComandaButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.GenerarFacturaComandaButton.Name = "GenerarFacturaComandaButton";
            this.GenerarFacturaComandaButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.GenerarFacturaComandaButton.Size = new System.Drawing.Size(160, 36);
            this.GenerarFacturaComandaButton.TabIndex = 2;
            this.GenerarFacturaComandaButton.Text = "Generar factura";
            this.GenerarFacturaComandaButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.GenerarFacturaComandaButton.UseAccentColor = false;
            this.GenerarFacturaComandaButton.UseVisualStyleBackColor = true;
            // 
            // ComandesListView
            // 
            this.ComandesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComandesListView.AutoSizeTable = false;
            this.ComandesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComandesListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComandesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numero,
            this.Client,
            this.PreuTotal,
            this.Data,
            this.Pagat,
            this.Recollida,
            this.NumProductes,
            this.Estat});
            this.ComandesListView.Depth = 0;
            this.ComandesListView.FullRowSelect = true;
            this.ComandesListView.HideSelection = false;
            this.ComandesListView.Location = new System.Drawing.Point(6, 88);
            this.ComandesListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.ComandesListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ComandesListView.MouseState = MaterialSkin.MouseState.OUT;
            this.ComandesListView.Name = "ComandesListView";
            this.ComandesListView.OwnerDraw = true;
            this.ComandesListView.Size = new System.Drawing.Size(981, 210);
            this.ComandesListView.TabIndex = 3;
            this.ComandesListView.UseCompatibleStateImageBehavior = false;
            this.ComandesListView.View = System.Windows.Forms.View.Details;
            // 
            // Numero
            // 
            this.Numero.Text = "Numero";
            this.Numero.Width = 109;
            // 
            // Client
            // 
            this.Client.Text = "Client";
            this.Client.Width = 103;
            // 
            // PreuTotal
            // 
            this.PreuTotal.Text = "Preu Total";
            this.PreuTotal.Width = 122;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 91;
            // 
            // Pagat
            // 
            this.Pagat.Text = "Pagat";
            this.Pagat.Width = 99;
            // 
            // Recollida
            // 
            this.Recollida.Text = "Recollida";
            this.Recollida.Width = 114;
            // 
            // NumProductes
            // 
            this.NumProductes.Text = "Num Productes";
            this.NumProductes.Width = 149;
            // 
            // Estat
            // 
            this.Estat.Text = "Estat";
            this.Estat.Width = 193;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Numero",
            "Client",
            "Pagat",
            "Estat"});
            this.materialComboBox1.Location = new System.Drawing.Point(1018, 6);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(153, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 4;
            // 
            // materialListView1
            // 
            this.materialListView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodiDeBarresComanda,
            this.NomProducteComanda,
            this.QuantitatComanda,
            this.PreuProducteComanda});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(323, 342);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(509, 297);
            this.materialListView1.TabIndex = 5;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // CodiDeBarresComanda
            // 
            this.CodiDeBarresComanda.Text = "Codi de barres";
            this.CodiDeBarresComanda.Width = 136;
            // 
            // NomProducteComanda
            // 
            this.NomProducteComanda.Text = "Nom";
            this.NomProducteComanda.Width = 145;
            // 
            // QuantitatComanda
            // 
            this.QuantitatComanda.Text = "Quantitat";
            this.QuantitatComanda.Width = 116;
            // 
            // PreuProducteComanda
            // 
            this.PreuProducteComanda.Text = "Preu";
            this.PreuProducteComanda.Width = 106;
            // 
            // CercarComandesTextBox
            // 
            this.CercarComandesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CercarComandesTextBox.AnimateReadOnly = false;
            this.CercarComandesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CercarComandesTextBox.Depth = 0;
            this.CercarComandesTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CercarComandesTextBox.Hint = "Cercar";
            this.CercarComandesTextBox.LeadingIcon = null;
            this.CercarComandesTextBox.Location = new System.Drawing.Point(1018, 61);
            this.CercarComandesTextBox.MaxLength = 50;
            this.CercarComandesTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CercarComandesTextBox.Multiline = false;
            this.CercarComandesTextBox.Name = "CercarComandesTextBox";
            this.CercarComandesTextBox.Size = new System.Drawing.Size(153, 50);
            this.CercarComandesTextBox.TabIndex = 6;
            this.CercarComandesTextBox.Text = "";
            this.CercarComandesTextBox.TrailingIcon = null;
            // 
            // NomComerçTextBox
            // 
            this.NomComerçTextBox.AnimateReadOnly = false;
            this.NomComerçTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NomComerçTextBox.Depth = 0;
            this.NomComerçTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NomComerçTextBox.Hint = "Nom";
            this.NomComerçTextBox.LeadingIcon = null;
            this.NomComerçTextBox.Location = new System.Drawing.Point(6, 47);
            this.NomComerçTextBox.MaxLength = 50;
            this.NomComerçTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.NomComerçTextBox.Multiline = false;
            this.NomComerçTextBox.Name = "NomComerçTextBox";
            this.NomComerçTextBox.Size = new System.Drawing.Size(237, 50);
            this.NomComerçTextBox.TabIndex = 0;
            this.NomComerçTextBox.Text = "";
            this.NomComerçTextBox.TrailingIcon = null;
            // 
            // DireccioComerçTextBox
            // 
            this.DireccioComerçTextBox.AnimateReadOnly = false;
            this.DireccioComerçTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DireccioComerçTextBox.Depth = 0;
            this.DireccioComerçTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DireccioComerçTextBox.Hint = "Direcció";
            this.DireccioComerçTextBox.LeadingIcon = null;
            this.DireccioComerçTextBox.Location = new System.Drawing.Point(6, 138);
            this.DireccioComerçTextBox.MaxLength = 50;
            this.DireccioComerçTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.DireccioComerçTextBox.Multiline = false;
            this.DireccioComerçTextBox.Name = "DireccioComerçTextBox";
            this.DireccioComerçTextBox.Size = new System.Drawing.Size(237, 50);
            this.DireccioComerçTextBox.TabIndex = 1;
            this.DireccioComerçTextBox.Text = "";
            this.DireccioComerçTextBox.TrailingIcon = null;
            // 
            // NIFComerçTextBox
            // 
            this.NIFComerçTextBox.AnimateReadOnly = false;
            this.NIFComerçTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NIFComerçTextBox.Depth = 0;
            this.NIFComerçTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NIFComerçTextBox.Hint = "NIF";
            this.NIFComerçTextBox.LeadingIcon = null;
            this.NIFComerçTextBox.Location = new System.Drawing.Point(6, 338);
            this.NIFComerçTextBox.MaxLength = 50;
            this.NIFComerçTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.NIFComerçTextBox.Multiline = false;
            this.NIFComerçTextBox.Name = "NIFComerçTextBox";
            this.NIFComerçTextBox.Size = new System.Drawing.Size(237, 50);
            this.NIFComerçTextBox.TabIndex = 4;
            this.NIFComerçTextBox.Text = "";
            this.NIFComerçTextBox.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(512, 585);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(165, 36);
            this.materialButton1.TabIndex = 5;
            this.materialButton1.Text = "Actualitzar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // TelefonComerçTextBox
            // 
            this.TelefonComerçTextBox.AllowPromptAsInput = true;
            this.TelefonComerçTextBox.AnimateReadOnly = false;
            this.TelefonComerçTextBox.AsciiOnly = false;
            this.TelefonComerçTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TelefonComerçTextBox.BeepOnError = false;
            this.TelefonComerçTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TelefonComerçTextBox.Depth = 0;
            this.TelefonComerçTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TelefonComerçTextBox.HidePromptOnLeave = false;
            this.TelefonComerçTextBox.HideSelection = true;
            this.TelefonComerçTextBox.Hint = "Telefon de contacte";
            this.TelefonComerçTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.TelefonComerçTextBox.LeadingIcon = null;
            this.TelefonComerçTextBox.Location = new System.Drawing.Point(312, 248);
            this.TelefonComerçTextBox.Mask = "+00-000-00-00-00";
            this.TelefonComerçTextBox.MaxLength = 32767;
            this.TelefonComerçTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.TelefonComerçTextBox.Name = "TelefonComerçTextBox";
            this.TelefonComerçTextBox.PasswordChar = '\0';
            this.TelefonComerçTextBox.PrefixSuffixText = null;
            this.TelefonComerçTextBox.PromptChar = '_';
            this.TelefonComerçTextBox.ReadOnly = false;
            this.TelefonComerçTextBox.RejectInputOnFirstFailure = false;
            this.TelefonComerçTextBox.ResetOnPrompt = true;
            this.TelefonComerçTextBox.ResetOnSpace = true;
            this.TelefonComerçTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TelefonComerçTextBox.SelectedText = "";
            this.TelefonComerçTextBox.SelectionLength = 0;
            this.TelefonComerçTextBox.SelectionStart = 0;
            this.TelefonComerçTextBox.ShortcutsEnabled = true;
            this.TelefonComerçTextBox.Size = new System.Drawing.Size(250, 48);
            this.TelefonComerçTextBox.SkipLiterals = true;
            this.TelefonComerçTextBox.TabIndex = 6;
            this.TelefonComerçTextBox.TabStop = false;
            this.TelefonComerçTextBox.Text = "+  -   -  -  -";
            this.TelefonComerçTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TelefonComerçTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.TelefonComerçTextBox.TrailingIcon = null;
            this.TelefonComerçTextBox.UseSystemPasswordChar = false;
            this.TelefonComerçTextBox.ValidatingType = null;
            // 
            // EmailComerçTextBox
            // 
            this.EmailComerçTextBox.AnimateReadOnly = false;
            this.EmailComerçTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailComerçTextBox.Depth = 0;
            this.EmailComerçTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmailComerçTextBox.Hint = "E-mail de contacte";
            this.EmailComerçTextBox.LeadingIcon = null;
            this.EmailComerçTextBox.Location = new System.Drawing.Point(6, 248);
            this.EmailComerçTextBox.MaxLength = 50;
            this.EmailComerçTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.EmailComerçTextBox.Multiline = false;
            this.EmailComerçTextBox.Name = "EmailComerçTextBox";
            this.EmailComerçTextBox.Size = new System.Drawing.Size(237, 50);
            this.EmailComerçTextBox.TabIndex = 7;
            this.EmailComerçTextBox.Text = "";
            this.EmailComerçTextBox.TrailingIcon = null;
            // 
            // materialListView2
            // 
            this.materialListView2.AutoSizeTable = false;
            this.materialListView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NomClient});
            this.materialListView2.Depth = 0;
            this.materialListView2.FullRowSelect = true;
            this.materialListView2.HideSelection = false;
            this.materialListView2.Location = new System.Drawing.Point(6, 91);
            this.materialListView2.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView2.Name = "materialListView2";
            this.materialListView2.OwnerDraw = true;
            this.materialListView2.Size = new System.Drawing.Size(827, 389);
            this.materialListView2.TabIndex = 0;
            this.materialListView2.UseCompatibleStateImageBehavior = false;
            this.materialListView2.View = System.Windows.Forms.View.Details;
            // 
            // NomClient
            // 
            this.NomClient.Text = "Nom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 750);
            this.Controls.Add(this.CercarComandesComboBox);
            this.Controls.Add(this.materialDrawer1);
            this.DrawerTabControl = this.CercarComandesComboBox;
            this.Name = "Form1";
            this.Text = "Form1";
            this.CercarComandesComboBox.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialTabControl CercarComandesComboBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private MaterialSkin.Controls.MaterialListView ListViewProductes;
        private System.Windows.Forms.ColumnHeader CodiDeBarres;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Imatge;
        private System.Windows.Forms.ColumnHeader Descripcio;
        private System.Windows.Forms.ColumnHeader Preu;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.ColumnHeader Categories;
        private MaterialSkin.Controls.MaterialButton EliminarProducteButton;
        private MaterialSkin.Controls.MaterialButton AfegirProducteButton;
        private MaterialSkin.Controls.MaterialButton ModificarProducteButton;
        private MaterialSkin.Controls.MaterialComboBox CercarProductesComboBox;
        private MaterialSkin.Controls.MaterialTextBox CercarProductesTextBox;
        private MaterialSkin.Controls.MaterialButton RefrescarProductesButton;
        private MaterialSkin.Controls.MaterialButton EliminarComandesButton;
        private MaterialSkin.Controls.MaterialButton ModEstatComandaButton;
        private MaterialSkin.Controls.MaterialButton GenerarFacturaComandaButton;
        private MaterialSkin.Controls.MaterialListView ComandesListView;
        private System.Windows.Forms.ColumnHeader Numero;
        private System.Windows.Forms.ColumnHeader Client;
        private System.Windows.Forms.ColumnHeader PreuTotal;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Pagat;
        private System.Windows.Forms.ColumnHeader Recollida;
        private System.Windows.Forms.ColumnHeader NumProductes;
        private System.Windows.Forms.ColumnHeader Estat;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader CodiDeBarresComanda;
        private System.Windows.Forms.ColumnHeader NomProducteComanda;
        private System.Windows.Forms.ColumnHeader QuantitatComanda;
        private System.Windows.Forms.ColumnHeader PreuProducteComanda;
        private MaterialSkin.Controls.MaterialTextBox CercarComandesTextBox;
        private MaterialSkin.Controls.MaterialTextBox NomComerçTextBox;
        private MaterialSkin.Controls.MaterialTextBox DireccioComerçTextBox;
        private MaterialSkin.Controls.MaterialTextBox NIFComerçTextBox;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMaskedTextBox TelefonComerçTextBox;
        private MaterialSkin.Controls.MaterialTextBox EmailComerçTextBox;
        private MaterialSkin.Controls.MaterialListView materialListView2;
        private System.Windows.Forms.ColumnHeader NomClient;
    }
}

