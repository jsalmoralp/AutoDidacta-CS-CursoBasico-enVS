namespace cs_crud.Vistas.Empleados
{
    partial class FormActualizar
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.gb_telefonos = new System.Windows.Forms.GroupBox();
            this.dgv_telefonos = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label_telefono = new System.Windows.Forms.Label();
            this.cbo_operador = new System.Windows.Forms.ComboBox();
            this.label_operadores = new System.Windows.Forms.Label();
            this.gb_datosTrabajador = new System.Windows.Forms.GroupBox();
            this.cbo_distrito = new System.Windows.Forms.ComboBox();
            this.cbo_provincia = new System.Windows.Forms.ComboBox();
            this.cbo_departamento = new System.Windows.Forms.ComboBox();
            this.cbo_estado_civil = new System.Windows.Forms.ComboBox();
            this.cbo_genero = new System.Windows.Forms.ComboBox();
            this.label_distrito = new System.Windows.Forms.Label();
            this.label_provincia = new System.Windows.Forms.Label();
            this.label_departamento = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label_direccion = new System.Windows.Forms.Label();
            this.label_estadoCivil = new System.Windows.Forms.Label();
            this.label_genero = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label_dni = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.label_apellidos = new System.Windows.Forms.Label();
            this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_telefonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telefonos)).BeginInit();
            this.gb_datosTrabajador.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(190, 416);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(109, 416);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_registrar.TabIndex = 14;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.Btn_registrar_Click);
            // 
            // gb_telefonos
            // 
            this.gb_telefonos.Controls.Add(this.dgv_telefonos);
            this.gb_telefonos.Controls.Add(this.btn_agregar);
            this.gb_telefonos.Controls.Add(this.txt_numero);
            this.gb_telefonos.Controls.Add(this.label_telefono);
            this.gb_telefonos.Controls.Add(this.cbo_operador);
            this.gb_telefonos.Controls.Add(this.label_operadores);
            this.gb_telefonos.Location = new System.Drawing.Point(12, 232);
            this.gb_telefonos.Name = "gb_telefonos";
            this.gb_telefonos.Size = new System.Drawing.Size(373, 178);
            this.gb_telefonos.TabIndex = 13;
            this.gb_telefonos.TabStop = false;
            this.gb_telefonos.Text = "Telefonos";
            // 
            // dgv_telefonos
            // 
            this.dgv_telefonos.AllowUserToAddRows = false;
            this.dgv_telefonos.AllowUserToDeleteRows = false;
            this.dgv_telefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_telefonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Operador,
            this.Telefono,
            this.Eliminar,
            this.Column1,
            this.Column2});
            this.dgv_telefonos.Location = new System.Drawing.Point(10, 60);
            this.dgv_telefonos.Name = "dgv_telefonos";
            this.dgv_telefonos.ReadOnly = true;
            this.dgv_telefonos.Size = new System.Drawing.Size(360, 108);
            this.dgv_telefonos.TabIndex = 25;
            this.dgv_telefonos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_telefonos_CellMouseDoubleClick);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(295, 29);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 24;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(133, 32);
            this.txt_numero.MaxLength = 9;
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(159, 20);
            this.txt_numero.TabIndex = 23;
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_numero_KeyPress);
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.Location = new System.Drawing.Point(130, 16);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(49, 13);
            this.label_telefono.TabIndex = 22;
            this.label_telefono.Text = "Telefono";
            // 
            // cbo_operador
            // 
            this.cbo_operador.FormattingEnabled = true;
            this.cbo_operador.Items.AddRange(new object[] {
            "Moviestar",
            "Orange",
            "Yoigo",
            "Vodafone"});
            this.cbo_operador.Location = new System.Drawing.Point(10, 32);
            this.cbo_operador.Name = "cbo_operador";
            this.cbo_operador.Size = new System.Drawing.Size(114, 21);
            this.cbo_operador.TabIndex = 21;
            // 
            // label_operadores
            // 
            this.label_operadores.AutoSize = true;
            this.label_operadores.Location = new System.Drawing.Point(7, 16);
            this.label_operadores.Name = "label_operadores";
            this.label_operadores.Size = new System.Drawing.Size(62, 13);
            this.label_operadores.TabIndex = 20;
            this.label_operadores.Text = "Operadores";
            // 
            // gb_datosTrabajador
            // 
            this.gb_datosTrabajador.Controls.Add(this.cbo_distrito);
            this.gb_datosTrabajador.Controls.Add(this.cbo_provincia);
            this.gb_datosTrabajador.Controls.Add(this.cbo_departamento);
            this.gb_datosTrabajador.Controls.Add(this.cbo_estado_civil);
            this.gb_datosTrabajador.Controls.Add(this.cbo_genero);
            this.gb_datosTrabajador.Controls.Add(this.label_distrito);
            this.gb_datosTrabajador.Controls.Add(this.label_provincia);
            this.gb_datosTrabajador.Controls.Add(this.label_departamento);
            this.gb_datosTrabajador.Controls.Add(this.txt_direccion);
            this.gb_datosTrabajador.Controls.Add(this.label_direccion);
            this.gb_datosTrabajador.Controls.Add(this.label_estadoCivil);
            this.gb_datosTrabajador.Controls.Add(this.label_genero);
            this.gb_datosTrabajador.Controls.Add(this.txt_dni);
            this.gb_datosTrabajador.Controls.Add(this.label_dni);
            this.gb_datosTrabajador.Controls.Add(this.txt_nombre);
            this.gb_datosTrabajador.Controls.Add(this.label_nombre);
            this.gb_datosTrabajador.Controls.Add(this.txt_apellidos);
            this.gb_datosTrabajador.Controls.Add(this.label_apellidos);
            this.gb_datosTrabajador.Location = new System.Drawing.Point(12, 12);
            this.gb_datosTrabajador.Name = "gb_datosTrabajador";
            this.gb_datosTrabajador.Size = new System.Drawing.Size(373, 213);
            this.gb_datosTrabajador.TabIndex = 12;
            this.gb_datosTrabajador.TabStop = false;
            this.gb_datosTrabajador.Text = "Datos del Trabajador";
            // 
            // cbo_distrito
            // 
            this.cbo_distrito.FormattingEnabled = true;
            this.cbo_distrito.Location = new System.Drawing.Point(256, 181);
            this.cbo_distrito.Name = "cbo_distrito";
            this.cbo_distrito.Size = new System.Drawing.Size(114, 21);
            this.cbo_distrito.TabIndex = 21;
            // 
            // cbo_provincia
            // 
            this.cbo_provincia.FormattingEnabled = true;
            this.cbo_provincia.Location = new System.Drawing.Point(133, 181);
            this.cbo_provincia.Name = "cbo_provincia";
            this.cbo_provincia.Size = new System.Drawing.Size(114, 21);
            this.cbo_provincia.TabIndex = 20;
            this.cbo_provincia.SelectedValueChanged += new System.EventHandler(this.Cbo_provincia_SelectedValueChanged);
            // 
            // cbo_departamento
            // 
            this.cbo_departamento.FormattingEnabled = true;
            this.cbo_departamento.Location = new System.Drawing.Point(10, 181);
            this.cbo_departamento.Name = "cbo_departamento";
            this.cbo_departamento.Size = new System.Drawing.Size(114, 21);
            this.cbo_departamento.TabIndex = 19;
            this.cbo_departamento.SelectedValueChanged += new System.EventHandler(this.Cbo_departamento_SelectedValueChanged);
            // 
            // cbo_estado_civil
            // 
            this.cbo_estado_civil.FormattingEnabled = true;
            this.cbo_estado_civil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorciado",
            "Conviviente"});
            this.cbo_estado_civil.Location = new System.Drawing.Point(256, 84);
            this.cbo_estado_civil.Name = "cbo_estado_civil";
            this.cbo_estado_civil.Size = new System.Drawing.Size(114, 21);
            this.cbo_estado_civil.TabIndex = 18;
            // 
            // cbo_genero
            // 
            this.cbo_genero.FormattingEnabled = true;
            this.cbo_genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbo_genero.Location = new System.Drawing.Point(133, 84);
            this.cbo_genero.Name = "cbo_genero";
            this.cbo_genero.Size = new System.Drawing.Size(114, 21);
            this.cbo_genero.TabIndex = 17;
            // 
            // label_distrito
            // 
            this.label_distrito.AutoSize = true;
            this.label_distrito.Location = new System.Drawing.Point(253, 165);
            this.label_distrito.Name = "label_distrito";
            this.label_distrito.Size = new System.Drawing.Size(39, 13);
            this.label_distrito.TabIndex = 16;
            this.label_distrito.Text = "Distrito";
            // 
            // label_provincia
            // 
            this.label_provincia.AutoSize = true;
            this.label_provincia.Location = new System.Drawing.Point(130, 165);
            this.label_provincia.Name = "label_provincia";
            this.label_provincia.Size = new System.Drawing.Size(51, 13);
            this.label_provincia.TabIndex = 14;
            this.label_provincia.Text = "Provincia";
            // 
            // label_departamento
            // 
            this.label_departamento.AutoSize = true;
            this.label_departamento.Location = new System.Drawing.Point(7, 165);
            this.label_departamento.Name = "label_departamento";
            this.label_departamento.Size = new System.Drawing.Size(74, 13);
            this.label_departamento.TabIndex = 12;
            this.label_departamento.Text = "Departamento";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(10, 133);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(360, 20);
            this.txt_direccion.TabIndex = 11;
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Location = new System.Drawing.Point(7, 117);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(52, 13);
            this.label_direccion.TabIndex = 10;
            this.label_direccion.Text = "Direccion";
            // 
            // label_estadoCivil
            // 
            this.label_estadoCivil.AutoSize = true;
            this.label_estadoCivil.Location = new System.Drawing.Point(253, 69);
            this.label_estadoCivil.Name = "label_estadoCivil";
            this.label_estadoCivil.Size = new System.Drawing.Size(62, 13);
            this.label_estadoCivil.TabIndex = 8;
            this.label_estadoCivil.Text = "Estado Civil";
            // 
            // label_genero
            // 
            this.label_genero.AutoSize = true;
            this.label_genero.Location = new System.Drawing.Point(130, 69);
            this.label_genero.Name = "label_genero";
            this.label_genero.Size = new System.Drawing.Size(42, 13);
            this.label_genero.TabIndex = 6;
            this.label_genero.Text = "Genero";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(10, 85);
            this.txt_dni.MaxLength = 9;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(114, 20);
            this.txt_dni.TabIndex = 5;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_dni_KeyPress);
            // 
            // label_dni
            // 
            this.label_dni.AutoSize = true;
            this.label_dni.Location = new System.Drawing.Point(7, 69);
            this.label_dni.Name = "label_dni";
            this.label_dni.Size = new System.Drawing.Size(26, 13);
            this.label_dni.TabIndex = 4;
            this.label_dni.Text = "DNI";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(232, 36);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(138, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(232, 20);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 2;
            this.label_nombre.Text = "Nombre";
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(10, 37);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(216, 20);
            this.txt_apellidos.TabIndex = 1;
            // 
            // label_apellidos
            // 
            this.label_apellidos.AutoSize = true;
            this.label_apellidos.Location = new System.Drawing.Point(7, 20);
            this.label_apellidos.Name = "label_apellidos";
            this.label_apellidos.Size = new System.Drawing.Size(49, 13);
            this.label_apellidos.TabIndex = 0;
            this.label_apellidos.Text = "Apellidos";
            // 
            // Operador
            // 
            this.Operador.HeaderText = "Operador";
            this.Operador.Name = "Operador";
            this.Operador.ReadOnly = true;
            this.Operador.Width = 120;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 140;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 55;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "EmpleadoId";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TelefonoId";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // FormActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.gb_telefonos);
            this.Controls.Add(this.gb_datosTrabajador);
            this.Name = "FormActualizar";
            this.Text = "FormActualizar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormActualizar_FormClosed);
            this.Load += new System.EventHandler(this.FormActualizar_Load);
            this.gb_telefonos.ResumeLayout(false);
            this.gb_telefonos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telefonos)).EndInit();
            this.gb_datosTrabajador.ResumeLayout(false);
            this.gb_datosTrabajador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.GroupBox gb_telefonos;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label_telefono;
        private System.Windows.Forms.ComboBox cbo_operador;
        private System.Windows.Forms.Label label_operadores;
        private System.Windows.Forms.GroupBox gb_datosTrabajador;
        private System.Windows.Forms.Label label_distrito;
        private System.Windows.Forms.Label label_provincia;
        private System.Windows.Forms.Label label_departamento;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.Label label_estadoCivil;
        private System.Windows.Forms.Label label_genero;
        private System.Windows.Forms.Label label_dni;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_apellidos;
        internal System.Windows.Forms.ComboBox cbo_genero;
        internal System.Windows.Forms.DataGridView dgv_telefonos;
        internal System.Windows.Forms.ComboBox cbo_distrito;
        internal System.Windows.Forms.ComboBox cbo_provincia;
        internal System.Windows.Forms.ComboBox cbo_departamento;
        internal System.Windows.Forms.ComboBox cbo_estado_civil;
        internal System.Windows.Forms.TextBox txt_direccion;
        internal System.Windows.Forms.TextBox txt_dni;
        internal System.Windows.Forms.TextBox txt_nombre;
        internal System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}