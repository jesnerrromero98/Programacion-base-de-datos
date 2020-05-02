namespace capaPresentacionEspecialidad
{
    partial class fEspecialidad
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
            this.tabEspecialidad = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxDescripcionEspecialidad = new System.Windows.Forms.TextBox();
            this.labelDescripcionEspecialidad = new System.Windows.Forms.Label();
            this.textBoxNombreEspecialidad = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelNombreEspecialidad = new System.Windows.Forms.Label();
            this.labelIdEspecialidad = new System.Windows.Forms.Label();
            this.labelRegistrarEspecialidad = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewEspecialidad = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.tabEspecialidad.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspecialidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEspecialidad
            // 
            this.tabEspecialidad.Controls.Add(this.tabPage1);
            this.tabEspecialidad.Controls.Add(this.tabPage2);
            this.tabEspecialidad.Location = new System.Drawing.Point(1, 1);
            this.tabEspecialidad.Name = "tabEspecialidad";
            this.tabEspecialidad.SelectedIndex = 0;
            this.tabEspecialidad.Size = new System.Drawing.Size(800, 450);
            this.tabEspecialidad.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.textBoxDescripcionEspecialidad);
            this.tabPage1.Controls.Add(this.labelDescripcionEspecialidad);
            this.tabPage1.Controls.Add(this.textBoxNombreEspecialidad);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.labelNombreEspecialidad);
            this.tabPage1.Controls.Add(this.labelIdEspecialidad);
            this.tabPage1.Controls.Add(this.labelRegistrarEspecialidad);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            // 
            // textBoxDescripcionEspecialidad
            // 
            this.textBoxDescripcionEspecialidad.Location = new System.Drawing.Point(278, 243);
            this.textBoxDescripcionEspecialidad.Multiline = true;
            this.textBoxDescripcionEspecialidad.Name = "textBoxDescripcionEspecialidad";
            this.textBoxDescripcionEspecialidad.Size = new System.Drawing.Size(337, 29);
            this.textBoxDescripcionEspecialidad.TabIndex = 10;
            // 
            // labelDescripcionEspecialidad
            // 
            this.labelDescripcionEspecialidad.AutoSize = true;
            this.labelDescripcionEspecialidad.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionEspecialidad.ForeColor = System.Drawing.Color.Transparent;
            this.labelDescripcionEspecialidad.Location = new System.Drawing.Point(153, 243);
            this.labelDescripcionEspecialidad.Name = "labelDescripcionEspecialidad";
            this.labelDescripcionEspecialidad.Size = new System.Drawing.Size(119, 24);
            this.labelDescripcionEspecialidad.TabIndex = 9;
            this.labelDescripcionEspecialidad.Text = "Descripción";
            // 
            // textBoxNombreEspecialidad
            // 
            this.textBoxNombreEspecialidad.Location = new System.Drawing.Point(241, 175);
            this.textBoxNombreEspecialidad.Multiline = true;
            this.textBoxNombreEspecialidad.Name = "textBoxNombreEspecialidad";
            this.textBoxNombreEspecialidad.Size = new System.Drawing.Size(337, 29);
            this.textBoxNombreEspecialidad.TabIndex = 8;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(226, 114);
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
            // labelNombreEspecialidad
            // 
            this.labelNombreEspecialidad.AutoSize = true;
            this.labelNombreEspecialidad.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreEspecialidad.ForeColor = System.Drawing.Color.Transparent;
            this.labelNombreEspecialidad.Location = new System.Drawing.Point(153, 180);
            this.labelNombreEspecialidad.Name = "labelNombreEspecialidad";
            this.labelNombreEspecialidad.Size = new System.Drawing.Size(82, 24);
            this.labelNombreEspecialidad.TabIndex = 5;
            this.labelNombreEspecialidad.Text = "Nombre";
            // 
            // labelIdEspecialidad
            // 
            this.labelIdEspecialidad.AutoSize = true;
            this.labelIdEspecialidad.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdEspecialidad.ForeColor = System.Drawing.Color.Transparent;
            this.labelIdEspecialidad.Location = new System.Drawing.Point(153, 119);
            this.labelIdEspecialidad.Name = "labelIdEspecialidad";
            this.labelIdEspecialidad.Size = new System.Drawing.Size(36, 24);
            this.labelIdEspecialidad.TabIndex = 1;
            this.labelIdEspecialidad.Text = "ID";
            // 
            // labelRegistrarEspecialidad
            // 
            this.labelRegistrarEspecialidad.AutoSize = true;
            this.labelRegistrarEspecialidad.Font = new System.Drawing.Font("AR DECODE", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarEspecialidad.ForeColor = System.Drawing.Color.Transparent;
            this.labelRegistrarEspecialidad.Location = new System.Drawing.Point(218, 15);
            this.labelRegistrarEspecialidad.Name = "labelRegistrarEspecialidad";
            this.labelRegistrarEspecialidad.Size = new System.Drawing.Size(315, 46);
            this.labelRegistrarEspecialidad.TabIndex = 0;
            this.labelRegistrarEspecialidad.Text = "Registro de Especialidad";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.dataGridViewEspecialidad);
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
            // dataGridViewEspecialidad
            // 
            this.dataGridViewEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEspecialidad.Location = new System.Drawing.Point(89, 249);
            this.dataGridViewEspecialidad.Name = "dataGridViewEspecialidad";
            this.dataGridViewEspecialidad.Size = new System.Drawing.Size(589, 150);
            this.dataGridViewEspecialidad.TabIndex = 14;
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
            // fEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabEspecialidad);
            this.Name = "fEspecialidad";
            this.Text = "Especialidad";
            this.tabEspecialidad.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspecialidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEspecialidad;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxDescripcionEspecialidad;
        private System.Windows.Forms.Label labelDescripcionEspecialidad;
        private System.Windows.Forms.TextBox textBoxNombreEspecialidad;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelNombreEspecialidad;
        private System.Windows.Forms.Label labelIdEspecialidad;
        private System.Windows.Forms.Label labelRegistrarEspecialidad;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewEspecialidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Label labelBuscar;
    }
}

