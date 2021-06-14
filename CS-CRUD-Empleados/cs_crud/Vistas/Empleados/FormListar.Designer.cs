namespace cs_crud.Vistas.Empleados
{
    partial class FormListar
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
            this.gb_listar = new System.Windows.Forms.GroupBox();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lLabel_nuevo = new System.Windows.Forms.LinkLabel();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label_buscar = new System.Windows.Forms.Label();
            this.gb_listar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_listar
            // 
            this.gb_listar.Controls.Add(this.dgv_empleados);
            this.gb_listar.Controls.Add(this.lLabel_nuevo);
            this.gb_listar.Controls.Add(this.txt_buscar);
            this.gb_listar.Controls.Add(this.label_buscar);
            this.gb_listar.Location = new System.Drawing.Point(12, 12);
            this.gb_listar.Name = "gb_listar";
            this.gb_listar.Size = new System.Drawing.Size(674, 426);
            this.gb_listar.TabIndex = 5;
            this.gb_listar.TabStop = false;
            // 
            // dgv_empleados
            // 
            this.dgv_empleados.AllowUserToAddRows = false;
            this.dgv_empleados.AllowUserToDeleteRows = false;
            this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgv_empleados.Location = new System.Drawing.Point(7, 70);
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.Size = new System.Drawing.Size(649, 331);
            this.dgv_empleados.TabIndex = 4;
            this.dgv_empleados.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_empleados_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre y Apellidos";
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DNI";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Genero";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Distrito";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Editar";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Eliminar";
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "EmpleadoId";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // lLabel_nuevo
            // 
            this.lLabel_nuevo.AutoSize = true;
            this.lLabel_nuevo.Location = new System.Drawing.Point(6, 33);
            this.lLabel_nuevo.Name = "lLabel_nuevo";
            this.lLabel_nuevo.Size = new System.Drawing.Size(89, 13);
            this.lLabel_nuevo.TabIndex = 0;
            this.lLabel_nuevo.TabStop = true;
            this.lLabel_nuevo.Text = "Nuevo Empleado";
            this.lLabel_nuevo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLabel_nuevo_LinkClicked);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(440, 33);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(216, 20);
            this.txt_buscar.TabIndex = 3;
            this.txt_buscar.TextChanged += new System.EventHandler(this.Txt_buscar_TextChanged);
            // 
            // label_buscar
            // 
            this.label_buscar.AutoSize = true;
            this.label_buscar.Location = new System.Drawing.Point(437, 16);
            this.label_buscar.Name = "label_buscar";
            this.label_buscar.Size = new System.Drawing.Size(40, 13);
            this.label_buscar.TabIndex = 2;
            this.label_buscar.Text = "Buscar";
            // 
            // FormListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.gb_listar);
            this.Name = "FormListar";
            this.Text = "FormListar";
            this.Load += new System.EventHandler(this.FormListar_Load);
            this.gb_listar.ResumeLayout(false);
            this.gb_listar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_listar;
        private System.Windows.Forms.LinkLabel lLabel_nuevo;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label_buscar;
        internal System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewLinkColumn Column5;
        private System.Windows.Forms.DataGridViewLinkColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}