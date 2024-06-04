namespace CarlosRamosExamenCRUD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxSKU = new System.Windows.Forms.TextBox();
            this.textBoxProveedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBoxCosto = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPrecioVenta = new System.Windows.Forms.MaskedTextBox();
            this.numericUpDownSTOK = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.botonActualizar = new System.Windows.Forms.Button();
            this.botonInsertar = new System.Windows.Forms.Button();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.openFileDialogImagen = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.botonSeleccionarImagen = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.monthCalendarFechasSeleccionas = new System.Windows.Forms.MonthCalendar();
            this.botonLeer = new System.Windows.Forms.Button();
            this.buttonPruebaConexion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonBucarPorFechas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSTOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proveedor";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(704, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "Costo de Producto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(408, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio de Venta";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(704, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 38);
            this.label7.TabIndex = 6;
            this.label7.Text = "Disponible";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1356, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(366, 36);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha de Registro";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(250, 103);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(91, 26);
            this.textBoxID.TabIndex = 17;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(404, 105);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(869, 26);
            this.textBoxNombre.TabIndex = 8;
            // 
            // textBoxSKU
            // 
            this.textBoxSKU.Location = new System.Drawing.Point(79, 294);
            this.textBoxSKU.Name = "textBoxSKU";
            this.textBoxSKU.Size = new System.Drawing.Size(257, 26);
            this.textBoxSKU.TabIndex = 9;
            // 
            // textBoxProveedor
            // 
            this.textBoxProveedor.Location = new System.Drawing.Point(413, 294);
            this.textBoxProveedor.Name = "textBoxProveedor";
            this.textBoxProveedor.Size = new System.Drawing.Size(210, 26);
            this.textBoxProveedor.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(75, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 37);
            this.label9.TabIndex = 11;
            this.label9.Text = "SKU de Producto";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // maskedTextBoxCosto
            // 
            this.maskedTextBoxCosto.Location = new System.Drawing.Point(79, 415);
            this.maskedTextBoxCosto.Name = "maskedTextBoxCosto";
            this.maskedTextBoxCosto.Size = new System.Drawing.Size(257, 26);
            this.maskedTextBoxCosto.TabIndex = 13;
            // 
            // maskedTextBoxPrecioVenta
            // 
            this.maskedTextBoxPrecioVenta.Location = new System.Drawing.Point(413, 415);
            this.maskedTextBoxPrecioVenta.Name = "maskedTextBoxPrecioVenta";
            this.maskedTextBoxPrecioVenta.Size = new System.Drawing.Size(210, 26);
            this.maskedTextBoxPrecioVenta.TabIndex = 14;
            // 
            // numericUpDownSTOK
            // 
            this.numericUpDownSTOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSTOK.Location = new System.Drawing.Point(700, 415);
            this.numericUpDownSTOK.Name = "numericUpDownSTOK";
            this.numericUpDownSTOK.Size = new System.Drawing.Size(204, 30);
            this.numericUpDownSTOK.TabIndex = 15;
            // 
            // dateTimePickerFechaRegistro
            // 
            this.dateTimePickerFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaRegistro.Location = new System.Drawing.Point(1356, 101);
            this.dateTimePickerFechaRegistro.Name = "dateTimePickerFechaRegistro";
            this.dateTimePickerFechaRegistro.Size = new System.Drawing.Size(365, 28);
            this.dateTimePickerFechaRegistro.TabIndex = 16;
            // 
            // botonActualizar
            // 
            this.botonActualizar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botonActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonActualizar.Location = new System.Drawing.Point(990, 312);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(283, 44);
            this.botonActualizar.TabIndex = 19;
            this.botonActualizar.Text = "Actualizar Producto";
            this.botonActualizar.UseVisualStyleBackColor = false;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // botonInsertar
            // 
            this.botonInsertar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botonInsertar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInsertar.Location = new System.Drawing.Point(310, 900);
            this.botonInsertar.Name = "botonInsertar";
            this.botonInsertar.Size = new System.Drawing.Size(156, 48);
            this.botonInsertar.TabIndex = 20;
            this.botonInsertar.Text = "Insertar";
            this.botonInsertar.UseVisualStyleBackColor = false;
            this.botonInsertar.Click += new System.EventHandler(this.botonInsertar_Click);
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(705, 294);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(204, 26);
            this.textBoxCategoria.TabIndex = 22;
            // 
            // openFileDialogImagen
            // 
            this.openFileDialogImagen.FileName = "openFileDialogSleccionar";
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBoxImagen.Location = new System.Drawing.Point(79, 517);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(387, 356);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 23;
            this.pictureBoxImagen.TabStop = false;
            this.pictureBoxImagen.Click += new System.EventHandler(this.pictureBoxImagen_Click);
            // 
            // botonSeleccionarImagen
            // 
            this.botonSeleccionarImagen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botonSeleccionarImagen.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSeleccionarImagen.Location = new System.Drawing.Point(71, 900);
            this.botonSeleccionarImagen.Name = "botonSeleccionarImagen";
            this.botonSeleccionarImagen.Size = new System.Drawing.Size(152, 48);
            this.botonSeleccionarImagen.TabIndex = 24;
            this.botonSeleccionarImagen.Text = "Seleccionar Imagen";
            this.botonSeleccionarImagen.UseVisualStyleBackColor = false;
            this.botonSeleccionarImagen.Click += new System.EventHandler(this.botonSeleccionarImagen_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botonEliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.botonEliminar.Location = new System.Drawing.Point(990, 407);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(283, 44);
            this.botonEliminar.TabIndex = 25;
            this.botonEliminar.Text = "Eliminar Producto";
            this.botonEliminar.UseVisualStyleBackColor = false;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botonBuscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscar.Location = new System.Drawing.Point(250, 138);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(91, 37);
            this.botonBuscar.TabIndex = 26;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = false;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewProductos.Location = new System.Drawing.Point(485, 565);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersWidth = 62;
            this.dataGridViewProductos.RowTemplate.Height = 28;
            this.dataGridViewProductos.Size = new System.Drawing.Size(1237, 308);
            this.dataGridViewProductos.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.GrayText;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1356, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(365, 36);
            this.label10.TabIndex = 29;
            this.label10.Text = "Buscar Producto por Fecha de Registro";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // monthCalendarFechasSeleccionas
            // 
            this.monthCalendarFechasSeleccionas.Location = new System.Drawing.Point(1361, 218);
            this.monthCalendarFechasSeleccionas.MaxSelectionCount = 30;
            this.monthCalendarFechasSeleccionas.Name = "monthCalendarFechasSeleccionas";
            this.monthCalendarFechasSeleccionas.TabIndex = 30;
            this.monthCalendarFechasSeleccionas.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // botonLeer
            // 
            this.botonLeer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botonLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLeer.Location = new System.Drawing.Point(990, 218);
            this.botonLeer.Name = "botonLeer";
            this.botonLeer.Size = new System.Drawing.Size(283, 42);
            this.botonLeer.TabIndex = 31;
            this.botonLeer.Text = "Leer Productos";
            this.botonLeer.UseVisualStyleBackColor = false;
            this.botonLeer.Click += new System.EventHandler(this.botonLeer_Click);
            // 
            // buttonPruebaConexion
            // 
            this.buttonPruebaConexion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonPruebaConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPruebaConexion.Location = new System.Drawing.Point(1476, 900);
            this.buttonPruebaConexion.Name = "buttonPruebaConexion";
            this.buttonPruebaConexion.Size = new System.Drawing.Size(246, 43);
            this.buttonPruebaConexion.TabIndex = 32;
            this.buttonPruebaConexion.Text = "Prueba de Conexion";
            this.buttonPruebaConexion.UseVisualStyleBackColor = false;
            this.buttonPruebaConexion.Click += new System.EventHandler(this.buttonPruebaConexion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox1.Image = global::CarlosRamosExamenCRUD.Properties.Resources.Screenshot_20240603_144202_Logo_Maker;
            this.pictureBox1.InitialImage = global::CarlosRamosExamenCRUD.Properties.Resources.Screenshot_20240603_144202_Logo_Maker;
            this.pictureBox1.Location = new System.Drawing.Point(79, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // botonBucarPorFechas
            // 
            this.botonBucarPorFechas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botonBucarPorFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBucarPorFechas.Location = new System.Drawing.Point(1451, 499);
            this.botonBucarPorFechas.Name = "botonBucarPorFechas";
            this.botonBucarPorFechas.Size = new System.Drawing.Size(257, 37);
            this.botonBucarPorFechas.TabIndex = 34;
            this.botonBucarPorFechas.Text = "Buscar Por Fechas";
            this.botonBucarPorFechas.UseVisualStyleBackColor = false;
            this.botonBucarPorFechas.Click += new System.EventHandler(this.botonBucarPorFechas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1794, 984);
            this.Controls.Add(this.botonBucarPorFechas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPruebaConexion);
            this.Controls.Add(this.botonLeer);
            this.Controls.Add(this.monthCalendarFechasSeleccionas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonSeleccionarImagen);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxSKU);
            this.Controls.Add(this.textBoxProveedor);
            this.Controls.Add(this.botonInsertar);
            this.Controls.Add(this.botonActualizar);
            this.Controls.Add(this.dateTimePickerFechaRegistro);
            this.Controls.Add(this.numericUpDownSTOK);
            this.Controls.Add(this.maskedTextBoxPrecioVenta);
            this.Controls.Add(this.maskedTextBoxCosto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSTOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSKU;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCosto;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrecioVenta;
        private System.Windows.Forms.NumericUpDown numericUpDownSTOK;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaRegistro;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button botonActualizar;
        private System.Windows.Forms.Button botonInsertar;
        private System.Windows.Forms.TextBox textBoxProveedor;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagen;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Button botonSeleccionarImagen;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MonthCalendar monthCalendarFechasSeleccionas;
        private System.Windows.Forms.Button botonLeer;
        private System.Windows.Forms.Button buttonPruebaConexion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonBucarPorFechas;
        private System.Windows.Forms.MonthCalendar monthCalendarInicio;
        private System.Windows.Forms.MonthCalendar monthCalendarFin;


    }
}

