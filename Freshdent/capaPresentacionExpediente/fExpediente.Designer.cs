namespace capaPresentacionExpediente
{
    partial class fExpediente
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
            this.labelRegistroExpediente = new System.Windows.Forms.Label();
            this.dataGridViewEspecialidad = new System.Windows.Forms.DataGridView();
            this.tabCita.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspecialidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCita
            // 
            this.tabCita.Controls.Add(this.tabPage1);
            this.tabCita.Location = new System.Drawing.Point(0, 0);
            this.tabCita.Name = "tabCita";
            this.tabCita.SelectedIndex = 0;
            this.tabCita.Size = new System.Drawing.Size(800, 450);
            this.tabCita.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.dataGridViewEspecialidad);
            this.tabPage1.Controls.Add(this.labelRegistroExpediente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            // 
            // labelRegistroExpediente
            // 
            this.labelRegistroExpediente.AutoSize = true;
            this.labelRegistroExpediente.Font = new System.Drawing.Font("AR DECODE", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroExpediente.ForeColor = System.Drawing.Color.Transparent;
            this.labelRegistroExpediente.Location = new System.Drawing.Point(253, 14);
            this.labelRegistroExpediente.Name = "labelRegistroExpediente";
            this.labelRegistroExpediente.Size = new System.Drawing.Size(260, 46);
            this.labelRegistroExpediente.TabIndex = 0;
            this.labelRegistroExpediente.Text = "Registro Expediente";
            // 
            // dataGridViewEspecialidad
            // 
            this.dataGridViewEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEspecialidad.Location = new System.Drawing.Point(129, 79);
            this.dataGridViewEspecialidad.Name = "dataGridViewEspecialidad";
            this.dataGridViewEspecialidad.Size = new System.Drawing.Size(538, 337);
            this.dataGridViewEspecialidad.TabIndex = 15;
            // 
            // fExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCita);
            this.Name = "fExpediente";
            this.Text = "Expediente";
            this.tabCita.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspecialidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCita;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewEspecialidad;
        private System.Windows.Forms.Label labelRegistroExpediente;
    }
}

