namespace capaPresentacionCita
{
    partial class fCita
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
            this.tabCita = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxHoraDisponible = new System.Windows.Forms.TextBox();
            this.textBoxFechaCita = new System.Windows.Forms.TextBox();
            this.textBoxNuevaCita = new System.Windows.Forms.TextBox();
            this.textBoxIdCita = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelNuevaCita = new System.Windows.Forms.Label();
            this.labelFechaCita = new System.Windows.Forms.Label();
            this.labelHoraDisponible = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelIdCita = new System.Windows.Forms.Label();
            this.labelRegistrarCitas = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewRegistrarCita = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.tabCita.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrarCita)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCita
            // 
            this.tabCita.Controls.Add(this.tabPage1);
            this.tabCita.Controls.Add(this.tabPage2);
            this.tabCita.Location = new System.Drawing.Point(1, 1);
            this.tabCita.Name = "tabCita";
            this.tabCita.SelectedIndex = 0;
            this.tabCita.Size = new System.Drawing.Size(800, 450);
            this.tabCita.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.textBoxPrecio);
            this.tabPage1.Controls.Add(this.textBoxHoraDisponible);
            this.tabPage1.Controls.Add(this.textBoxFechaCita);
            this.tabPage1.Controls.Add(this.textBoxNuevaCita);
            this.tabPage1.Controls.Add(this.textBoxIdCita);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.labelNuevaCita);
            this.tabPage1.Controls.Add(this.labelFechaCita);
            this.tabPage1.Controls.Add(this.labelHoraDisponible);
            this.tabPage1.Controls.Add(this.labelPrecio);
            this.tabPage1.Controls.Add(this.labelIdCita);
            this.tabPage1.Controls.Add(this.labelRegistrarCitas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(219, 293);
            this.textBoxPrecio.Multiline = true;
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(337, 29);
            this.textBoxPrecio.TabIndex = 11;
            // 
            // textBoxHoraDisponible
            // 
            this.textBoxHoraDisponible.Location = new System.Drawing.Point(219, 238);
            this.textBoxHoraDisponible.Multiline = true;
            this.textBoxHoraDisponible.Name = "textBoxHoraDisponible";
            this.textBoxHoraDisponible.Size = new System.Drawing.Size(337, 29);
            this.textBoxHoraDisponible.TabIndex = 10;
            // 
            // textBoxFechaCita
            // 
            this.textBoxFechaCita.Location = new System.Drawing.Point(219, 183);
            this.textBoxFechaCita.Multiline = true;
            this.textBoxFechaCita.Name = "textBoxFechaCita";
            this.textBoxFechaCita.Size = new System.Drawing.Size(337, 29);
            this.textBoxFechaCita.TabIndex = 9;
            // 
            // textBoxNuevaCita
            // 
            this.textBoxNuevaCita.Location = new System.Drawing.Point(219, 124);
            this.textBoxNuevaCita.Multiline = true;
            this.textBoxNuevaCita.Name = "textBoxNuevaCita";
            this.textBoxNuevaCita.Size = new System.Drawing.Size(337, 29);
            this.textBoxNuevaCita.TabIndex = 8;
            // 
            // textBoxIdCita
            // 
            this.textBoxIdCita.Location = new System.Drawing.Point(219, 69);
            this.textBoxIdCita.Multiline = true;
            this.textBoxIdCita.Name = "textBoxIdCita";
            this.textBoxIdCita.Size = new System.Drawing.Size(337, 29);
            this.textBoxIdCita.TabIndex = 7;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.Navy;
            this.buttonGuardar.Location = new System.Drawing.Point(337, 338);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(129, 34);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelNuevaCita
            // 
            this.labelNuevaCita.AutoSize = true;
            this.labelNuevaCita.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevaCita.ForeColor = System.Drawing.Color.Transparent;
            this.labelNuevaCita.Location = new System.Drawing.Point(26, 124);
            this.labelNuevaCita.Name = "labelNuevaCita";
            this.labelNuevaCita.Size = new System.Drawing.Size(75, 24);
            this.labelNuevaCita.TabIndex = 5;
            this.labelNuevaCita.Text = "Nueva ";
            // 
            // labelFechaCita
            // 
            this.labelFechaCita.AutoSize = true;
            this.labelFechaCita.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaCita.ForeColor = System.Drawing.Color.Transparent;
            this.labelFechaCita.Location = new System.Drawing.Point(26, 183);
            this.labelFechaCita.Name = "labelFechaCita";
            this.labelFechaCita.Size = new System.Drawing.Size(73, 24);
            this.labelFechaCita.TabIndex = 4;
            this.labelFechaCita.Text = "Fecha ";
            // 
            // labelHoraDisponible
            // 
            this.labelHoraDisponible.AutoSize = true;
            this.labelHoraDisponible.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraDisponible.ForeColor = System.Drawing.Color.Transparent;
            this.labelHoraDisponible.Location = new System.Drawing.Point(26, 238);
            this.labelHoraDisponible.Name = "labelHoraDisponible";
            this.labelHoraDisponible.Size = new System.Drawing.Size(166, 24);
            this.labelHoraDisponible.TabIndex = 3;
            this.labelHoraDisponible.Text = "Hora Disponible";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.Transparent;
            this.labelPrecio.Location = new System.Drawing.Point(26, 293);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(70, 24);
            this.labelPrecio.TabIndex = 2;
            this.labelPrecio.Text = "Precio";
            // 
            // labelIdCita
            // 
            this.labelIdCita.AutoSize = true;
            this.labelIdCita.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdCita.ForeColor = System.Drawing.Color.Transparent;
            this.labelIdCita.Location = new System.Drawing.Point(26, 69);
            this.labelIdCita.Name = "labelIdCita";
            this.labelIdCita.Size = new System.Drawing.Size(36, 24);
            this.labelIdCita.TabIndex = 1;
            this.labelIdCita.Text = "ID";
            // 
            // labelRegistrarCitas
            // 
            this.labelRegistrarCitas.AutoSize = true;
            this.labelRegistrarCitas.Font = new System.Drawing.Font("AR DECODE", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarCitas.ForeColor = System.Drawing.Color.Transparent;
            this.labelRegistrarCitas.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelRegistrarCitas.Location = new System.Drawing.Point(281, 3);
            this.labelRegistrarCitas.Name = "labelRegistrarCitas";
            this.labelRegistrarCitas.Size = new System.Drawing.Size(237, 46);
            this.labelRegistrarCitas.TabIndex = 0;
            this.labelRegistrarCitas.Text = "Registro de Citas";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.dataGridViewRegistrarCita);
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
            // dataGridViewRegistrarCita
            // 
            this.dataGridViewRegistrarCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistrarCita.Location = new System.Drawing.Point(88, 265);
            this.dataGridViewRegistrarCita.Name = "dataGridViewRegistrarCita";
            this.dataGridViewRegistrarCita.Size = new System.Drawing.Size(589, 150);
            this.dataGridViewRegistrarCita.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR DECODE", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(219, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Busqueda de Información";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.Navy;
            this.buttonBuscar.Location = new System.Drawing.Point(126, 199);
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
            this.buttonEliminar.Location = new System.Drawing.Point(491, 199);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(137, 34);
            this.buttonEliminar.TabIndex = 11;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(215, 120);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(337, 29);
            this.textBoxBuscar.TabIndex = 10;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.Color.Navy;
            this.buttonEditar.Location = new System.Drawing.Point(304, 199);
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
            this.labelBuscar.Location = new System.Drawing.Point(84, 125);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(97, 24);
            this.labelBuscar.TabIndex = 8;
            this.labelBuscar.Text = "BUSCAR";
            // 
            // fCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCita);
            this.Name = "fCita";
            this.Text = "Cita";
            this.tabCita.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrarCita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCita;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxHoraDisponible;
        private System.Windows.Forms.TextBox textBoxFechaCita;
        private System.Windows.Forms.TextBox textBoxNuevaCita;
        private System.Windows.Forms.TextBox textBoxIdCita;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelNuevaCita;
        private System.Windows.Forms.Label labelFechaCita;
        private System.Windows.Forms.Label labelHoraDisponible;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelIdCita;
        private System.Windows.Forms.Label labelRegistrarCitas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.DataGridView dataGridViewRegistrarCita;
    }
}

