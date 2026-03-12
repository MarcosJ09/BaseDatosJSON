namespace BaseDatosJSON
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuProductos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ItemEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            this.poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGuardar = new ReaLTaiizor.Controls.ThunderButton();
            this.TxtUnidades = new ReaLTaiizor.Controls.SkyNumeric();
            this.skyLabel4 = new ReaLTaiizor.Controls.SkyLabel();
            this.TxtMarca = new ReaLTaiizor.Controls.DungeonTextBox();
            this.M = new ReaLTaiizor.Controls.SkyLabel();
            this.skyLabel3 = new ReaLTaiizor.Controls.SkyLabel();
            this.TxtCategoria = new ReaLTaiizor.Controls.MaterialComboBox();
            this.TxtProducto = new ReaLTaiizor.Controls.DungeonTextBox();
            this.skyLabel2 = new ReaLTaiizor.Controls.SkyLabel();
            this.TxtCodigo = new ReaLTaiizor.Controls.CyberTextBox();
            this.skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.MenuProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuProductos
            // 
            this.MenuProductos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MenuProductos.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuProductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemEliminar,
            this.ItemModificar});
            this.MenuProductos.Name = "MenuProductos";
            this.MenuProductos.Size = new System.Drawing.Size(239, 68);
            // 
            // ItemEliminar
            // 
            this.ItemEliminar.Name = "ItemEliminar";
            this.ItemEliminar.Size = new System.Drawing.Size(238, 32);
            this.ItemEliminar.Text = "Eliminar Producto";
            this.ItemEliminar.Click += new System.EventHandler(this.ItemEliminar_Click);
            // 
            // ItemModificar
            // 
            this.ItemModificar.Name = "ItemModificar";
            this.ItemModificar.Size = new System.Drawing.Size(238, 32);
            this.ItemModificar.Text = "Modificar producto";
            this.ItemModificar.Click += new System.EventHandler(this.ItemModificar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // metroDivider1
            // 
            this.metroDivider1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroDivider1.IsDerivedStyle = true;
            this.metroDivider1.Location = new System.Drawing.Point(-8, 434);
            this.metroDivider1.Name = "metroDivider1";
            this.metroDivider1.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            this.metroDivider1.Size = new System.Drawing.Size(1027, 4);
            this.metroDivider1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroDivider1.StyleManager = null;
            this.metroDivider1.TabIndex = 28;
            this.metroDivider1.Text = "metroDivider1";
            this.metroDivider1.ThemeAuthor = "Taiizor";
            this.metroDivider1.ThemeName = "MetroLight";
            this.metroDivider1.Thickness = 1;
            // 
            // poisonDataGridView1
            // 
            this.poisonDataGridView1.AllowUserToResizeRows = false;
            this.poisonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.poisonDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poisonDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.poisonDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.poisonDataGridView1.ColumnHeadersHeight = 34;
            this.poisonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Categoria,
            this.Marca,
            this.Cantidad});
            this.poisonDataGridView1.ContextMenuStrip = this.MenuProductos;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poisonDataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.poisonDataGridView1.EnableHeadersVisualStyles = false;
            this.poisonDataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.poisonDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView1.Location = new System.Drawing.Point(51, 456);
            this.poisonDataGridView1.Name = "poisonDataGridView1";
            this.poisonDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.poisonDataGridView1.RowHeadersVisible = false;
            this.poisonDataGridView1.RowHeadersWidth = 62;
            this.poisonDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.poisonDataGridView1.RowTemplate.Height = 28;
            this.poisonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poisonDataGridView1.Size = new System.Drawing.Size(956, 198);
            this.poisonDataGridView1.TabIndex = 27;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 8;
            this.Categoria.Name = "Categoria";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 8;
            this.Marca.Name = "Marca";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnGuardar.Location = new System.Drawing.Point(790, 380);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(146, 32);
            this.BtnGuardar.TabIndex = 26;
            this.BtnGuardar.Text = "Guardar";
            // 
            // TxtUnidades
            // 
            this.TxtUnidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.TxtUnidades.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TxtUnidades.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TxtUnidades.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.TxtUnidades.BorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.TxtUnidades.BotTriangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.TxtUnidades.ButtonBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.TxtUnidades.ButtonBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.TxtUnidades.ButtonBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.TxtUnidades.ButtonBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.TxtUnidades.ButtonBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.TxtUnidades.ButtonBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.TxtUnidades.ButtonBorderColorE = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.TxtUnidades.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUnidades.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.TxtUnidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.TxtUnidades.Location = new System.Drawing.Point(823, 319);
            this.TxtUnidades.Maximum = ((long)(9999999));
            this.TxtUnidades.Minimum = ((long)(0));
            this.TxtUnidades.Name = "TxtUnidades";
            this.TxtUnidades.Size = new System.Drawing.Size(113, 30);
            this.TxtUnidades.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.TxtUnidades.TabIndex = 25;
            this.TxtUnidades.Text = "skyNumeric1";
            this.TxtUnidades.TopTriangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.TxtUnidades.Value = ((long)(0));
            // 
            // skyLabel4
            // 
            this.skyLabel4.AutoSize = true;
            this.skyLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel4.Location = new System.Drawing.Point(686, 319);
            this.skyLabel4.Name = "skyLabel4";
            this.skyLabel4.Size = new System.Drawing.Size(105, 22);
            this.skyLabel4.TabIndex = 24;
            this.skyLabel4.Text = "Unidades";
            // 
            // TxtMarca
            // 
            this.TxtMarca.BackColor = System.Drawing.Color.Transparent;
            this.TxtMarca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TxtMarca.EdgeColor = System.Drawing.Color.White;
            this.TxtMarca.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtMarca.ForeColor = System.Drawing.Color.DimGray;
            this.TxtMarca.Location = new System.Drawing.Point(506, 311);
            this.TxtMarca.MaxLength = 32767;
            this.TxtMarca.Multiline = false;
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.ReadOnly = false;
            this.TxtMarca.Size = new System.Drawing.Size(146, 37);
            this.TxtMarca.TabIndex = 23;
            this.TxtMarca.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtMarca.UseSystemPasswordChar = false;
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.M.Location = new System.Drawing.Point(417, 313);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(71, 22);
            this.M.TabIndex = 22;
            this.M.Text = "Marca";
            // 
            // skyLabel3
            // 
            this.skyLabel3.AutoSize = true;
            this.skyLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel3.Location = new System.Drawing.Point(47, 313);
            this.skyLabel3.Name = "skyLabel3";
            this.skyLabel3.Size = new System.Drawing.Size(107, 22);
            this.skyLabel3.TabIndex = 21;
            this.skyLabel3.Text = "Categoria";
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.AutoResize = false;
            this.TxtCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtCategoria.Depth = 0;
            this.TxtCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TxtCategoria.DropDownHeight = 174;
            this.TxtCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtCategoria.DropDownWidth = 121;
            this.TxtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtCategoria.FormattingEnabled = true;
            this.TxtCategoria.IntegralHeight = false;
            this.TxtCategoria.ItemHeight = 43;
            this.TxtCategoria.Items.AddRange(new object[] {
            "Linea Blanca",
            "Tecnologia",
            "Belleza",
            "Otro"});
            this.TxtCategoria.Location = new System.Drawing.Point(161, 299);
            this.TxtCategoria.MaxDropDownItems = 4;
            this.TxtCategoria.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(219, 49);
            this.TxtCategoria.StartIndex = 0;
            this.TxtCategoria.TabIndex = 20;
            // 
            // TxtProducto
            // 
            this.TxtProducto.BackColor = System.Drawing.Color.Transparent;
            this.TxtProducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TxtProducto.EdgeColor = System.Drawing.Color.White;
            this.TxtProducto.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtProducto.ForeColor = System.Drawing.Color.DimGray;
            this.TxtProducto.Location = new System.Drawing.Point(161, 210);
            this.TxtProducto.MaxLength = 32767;
            this.TxtProducto.Multiline = false;
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.ReadOnly = false;
            this.TxtProducto.Size = new System.Drawing.Size(566, 37);
            this.TxtProducto.TabIndex = 19;
            this.TxtProducto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtProducto.UseSystemPasswordChar = false;
            // 
            // skyLabel2
            // 
            this.skyLabel2.AutoSize = true;
            this.skyLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel2.Location = new System.Drawing.Point(47, 210);
            this.skyLabel2.Name = "skyLabel2";
            this.skyLabel2.Size = new System.Drawing.Size(108, 22);
            this.skyLabel2.TabIndex = 18;
            this.skyLabel2.Text = "Producto:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Alpha = 20;
            this.TxtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.TxtCodigo.Background_WidthPen = 3F;
            this.TxtCodigo.BackgroundPen = true;
            this.TxtCodigo.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.TxtCodigo.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.TxtCodigo.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.TxtCodigo.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.TxtCodigo.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.TxtCodigo.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.TxtCodigo.Font = new System.Drawing.Font("Arial", 10F);
            this.TxtCodigo.ForeColor = System.Drawing.Color.White;
            this.TxtCodigo.Lighting = false;
            this.TxtCodigo.LinearGradientPen = false;
            this.TxtCodigo.Location = new System.Drawing.Point(690, 109);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.PenWidth = 15;
            this.TxtCodigo.RGB = false;
            this.TxtCodigo.Rounding = true;
            this.TxtCodigo.RoundingInt = 60;
            this.TxtCodigo.Size = new System.Drawing.Size(204, 41);
            this.TxtCodigo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.TxtCodigo.TabIndex = 17;
            this.TxtCodigo.Tag = "Cyber";
            this.TxtCodigo.TextButton = "";
            this.TxtCodigo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TxtCodigo.Timer_RGB = 300;
            // 
            // skyLabel1
            // 
            this.skyLabel1.AutoSize = true;
            this.skyLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skyLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel1.Location = new System.Drawing.Point(586, 119);
            this.skyLabel1.Name = "skyLabel1";
            this.skyLabel1.Size = new System.Drawing.Size(86, 22);
            this.skyLabel1.TabIndex = 16;
            this.skyLabel1.Text = "Codigo:";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(65, 39);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(846, 67);
            this.bigLabel1.TabIndex = 15;
            this.bigLabel1.Text = "Gestion de productos -Base de Datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 693);
            this.Controls.Add(this.metroDivider1);
            this.Controls.Add(this.poisonDataGridView1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtUnidades);
            this.Controls.Add(this.skyLabel4);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.M);
            this.Controls.Add(this.skyLabel3);
            this.Controls.Add(this.TxtCategoria);
            this.Controls.Add(this.TxtProducto);
            this.Controls.Add(this.skyLabel2);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.skyLabel1);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(112, 35);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip MenuProductos;
        private System.Windows.Forms.ToolStripMenuItem ItemEliminar;
        private System.Windows.Forms.ToolStripMenuItem ItemModificar;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        public ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private ReaLTaiizor.Controls.ThunderButton BtnGuardar;
        private ReaLTaiizor.Controls.SkyNumeric TxtUnidades;
        private ReaLTaiizor.Controls.SkyLabel skyLabel4;
        private ReaLTaiizor.Controls.DungeonTextBox TxtMarca;
        private ReaLTaiizor.Controls.SkyLabel M;
        private ReaLTaiizor.Controls.SkyLabel skyLabel3;
        private ReaLTaiizor.Controls.MaterialComboBox TxtCategoria;
        private ReaLTaiizor.Controls.DungeonTextBox TxtProducto;
        private ReaLTaiizor.Controls.SkyLabel skyLabel2;
        private ReaLTaiizor.Controls.CyberTextBox TxtCodigo;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}

