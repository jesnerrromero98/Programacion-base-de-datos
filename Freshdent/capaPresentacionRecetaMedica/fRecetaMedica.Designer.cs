namespace capaPresentacionRecetaMedica
{
    partial class fRecetaMedica
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
            this.tabRecetaMedica = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxIndicaciones = new System.Windows.Forms.TextBox();
            this.labelIndicaciones = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textBoxNombreMedicamento = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelNombreMedicamento = new System.Windows.Forms.Label();
            this.labelIdRecetaMedica = new System.Windows.Forms.Label();
            this.labelRegistrarRecetaMedica = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewRecetaMedica = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.tabRecetaMedica.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecetaMedica)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRecetaMedica
            // 
            this.tabRecetaMedica.Controls.Add(this.tabPage1);
            this.tabRecetaMedica.Controls.Add(this.tabPage2);
            this.tabRecetaMedica.Location = new System.Drawing.Point(0, 1);
            this.tabRecetaMedica.Name = "tabRecetaMedica";
            this.tabRecetaMedica.SelectedIndex = 0;
            this.tabRecetaMedica.Size = new System.Drawing.Size(800, 450);
            this.tabRecetaMedica.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.textBoxIndicaciones);
            this.tabPage1.Controls.Add(this.labelIndicaciones);
            this.tabPage1.Controls.Add(this.textBoxCantidad);
            this.tabPage1.Controls.Add(this.labelCantidad);
            this.tabPage1.Controls.Add(this.textBoxNombreMedicamento);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.labelNombreMedicamento);
            this.tabPage1.Controls.Add(this.labelIdRecetaMedica);
            this.tabPage1.Controls.Add(this.labelRegistrarRecetaMedica);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            // 
            // textBoxIndicaciones
            // 
            this.textBoxIndicaciones.Location = new System.Drawing.Point(195, 260);
            this.textBoxIndicaciones.Multiline = true;
            this.textBoxIndicaciones.Name = "textBoxIndicaciones";
            this.textBoxIndicaciones.Size = new System.Drawing.Size(337, 29);
            this.textBoxIndicaciones.TabIndex = 12;
            // 
            // labelIndicaciones
            // 
            this.labelIndicaciones.AutoSize = true;
            this.labelIndicaciones.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndicaciones.ForeColor = System.Drawing.Color.Transparent;
            this.labelIndicaciones.Location = new System.Drawing.Point(52, 265);
            this.labelIndicaciones.Name = "labelIndicaciones";
            this.labelIndicaciones.Size = new System.Drawing.Size(127, 24);
            this.labelIndicaciones.TabIndex = 11;
            this.labelIndicaciones.Text = "Indicaciones";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(182, 197);
            this.textBoxCantidad.Multiline = true;
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(337, 29);
            this.textBoxCantidad.TabIndex = 10;
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.Color.Transparent;
            this.labelCantidad.Location = new System.Drawing.Point(52, 202);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(93, 24);
            this.labelCantidad.TabIndex = 9;
            this.labelCantidad.Text = "Cantidad";
            // 
            // textBoxNombreMedicamento
            // 
            this.textBoxNombreMedicamento.Location = new System.Drawing.Point(282, 142);
            this.textBoxNombreMedicamento.Multiline = true;
            this.textBoxNombreMedicamento.Name = "textBoxNombreMedicamento";
            this.textBoxNombreMedicamento.Size = new System.Drawing.Size(337, 29);
            this.textBoxNombreMedicamento.TabIndex = 8;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(143, 91);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(219, 29);
            this.textBoxId.TabIndex = 7;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.Navy;
            this.buttonGuardar.Location = new System.Drawing.Point(316, 333);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(129, 34);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelNombreMedicamento
            // 
            this.labelNombreMedicamento.AutoSize = true;
            this.labelNombreMedicamento.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreMedicamento.ForeColor = System.Drawing.Color.Transparent;
            this.labelNombreMedicamento.Location = new System.Drawing.Point(52, 147);
            this.labelNombreMedicamento.Name = "labelNombreMedicamento";
            this.labelNombreMedicamento.Size = new System.Drawing.Size(211, 24);
            this.labelNombreMedicamento.TabIndex = 5;
            this.labelNombreMedicamento.Text = "Nombre Medicamento";
            // 
            // labelIdRecetaMedica
            // 
            this.labelIdRecetaMedica.AutoSize = true;
            this.labelIdRecetaMedica.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdRecetaMedica.ForeColor = System.Drawing.Color.Transparent;
            this.labelIdRecetaMedica.Location = new System.Drawing.Point(52, 96);
            this.labelIdRecetaMedica.Name = "labelIdRecetaMedica";
            this.labelIdRecetaMedica.Size = new System.Drawing.Size(36, 24);
            this.labelIdRecetaMedica.TabIndex = 1;
            this.labelIdRecetaMedica.Text = "ID";
            // 
            // labelRegistrarRecetaMedica
            // 
            this.labelRegistrarRecetaMedica.AutoSize = true;
            this.labelRegistrarRecetaMedica.Font = new System.Drawing.Font("AR DECODE", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarRecetaMedica.ForeColor = System.Drawing.Color.Transparent;
            this.labelRegistrarRecetaMedica.Location = new System.Drawing.Point(227, 20);
            this.labelRegistrarRecetaMedica.Name = "labelRegistrarRecetaMedica";
            this.labelRegistrarRecetaMedica.Size = new System.Drawing.Size(364, 46);
            this.labelRegistrarRecetaMedica.TabIndex = 0;
            this.labelRegistrarRecetaMedica.Text = "Registro de Receta Medica";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.dataGridViewRecetaMedica);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.labelBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            // 
            // dataGridViewRecetaMedica
            // 
            this.dataGridViewRecetaMedica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecetaMedica.Location = new System.Drawing.Point(89, 249);
            this.dataGridViewRecetaMedica.Name = "dataGridViewRecetaMedica";
            this.dataGridViewRecetaMedica.Size = new System.Drawing.Size(589, 150);
            this.dataGridViewRecetaMedica.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR DECODE", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(219, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Busqueda de Información";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.Navy;
            this.buttonBuscar.Location = new System.Drawing.Point(127, 188);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(129, 34);
            this.buttonBuscar.TabIndex = 12;
            this.buttonBuscar.Text = "BUSCAR";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.Navy;
            this.buttonEliminar.Location = new System.Drawing.Point(491, 188);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(137, 34);
            this.buttonEliminar.TabIndex = 11;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(247, 120);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(337, 29);
            this.textBoxBuscar.TabIndex = 10;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.Color.Navy;
            this.buttonEditar.Location = new System.Drawing.Point(315, 188);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(129, 34);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.labelBuscar.Location = new System.Drawing.Point(107, 125);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(97, 24);
            this.labelBuscar.TabIndex = 8;
            this.labelBuscar.Text = "BUSCAR";
            // 
            // fRecetaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabRecetaMedica);
            this.Name = "fRecetaMedica";
            this.Text = "Receta Medica";
            this.tabRecetaMedica.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecetaMedica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRecetaMedica;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxIndicaciones;
        private System.Windows.Forms.Label labelIndicaciones;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox textBoxNombreMedicamento;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelNombreMedicamento;
        private System.Windows.Forms.Label labelIdRecetaMedica;
        private System.Windows.Forms.Label labelRegistrarRecetaMedica;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewRecetaMedica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Label labelBuscar;
    }
}

