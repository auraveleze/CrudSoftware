
namespace ProyectoSoftwareWeb.Vista
{
    partial class frmChequeo
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SalirC = new System.Windows.Forms.Button();
            this.btn_AnteriorC = new System.Windows.Forms.Button();
            this.tbObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_PanelC = new System.Windows.Forms.DataGridView();
            this.btn_EliminarC = new System.Windows.Forms.Button();
            this.tx_NombreC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_NDocumentoC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_BuscarC = new System.Windows.Forms.Button();
            this.btn_ActualizarC = new System.Windows.Forms.Button();
            this.btn_CrearC = new System.Windows.Forms.Button();
            this.tx_ObservacionC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_FacturaC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PanelC)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(19, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Noviembre";
            // 
            // btn_SalirC
            // 
            this.btn_SalirC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirC.ForeColor = System.Drawing.Color.Red;
            this.btn_SalirC.Location = new System.Drawing.Point(726, 371);
            this.btn_SalirC.Name = "btn_SalirC";
            this.btn_SalirC.Size = new System.Drawing.Size(52, 23);
            this.btn_SalirC.TabIndex = 26;
            this.btn_SalirC.Text = "Salir";
            this.btn_SalirC.UseVisualStyleBackColor = true;
            this.btn_SalirC.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_AnteriorC
            // 
            this.btn_AnteriorC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AnteriorC.ForeColor = System.Drawing.Color.Black;
            this.btn_AnteriorC.Location = new System.Drawing.Point(674, 371);
            this.btn_AnteriorC.Name = "btn_AnteriorC";
            this.btn_AnteriorC.Size = new System.Drawing.Size(52, 23);
            this.btn_AnteriorC.TabIndex = 25;
            this.btn_AnteriorC.Text = "Anterior";
            this.btn_AnteriorC.UseVisualStyleBackColor = true;
            this.btn_AnteriorC.Click += new System.EventHandler(this.buttonCerrar1_Click);
            // 
            // tbObservacion
            // 
            this.tbObservacion.HeaderText = "Observacion";
            this.tbObservacion.Name = "tbObservacion";
            // 
            // tbFactura
            // 
            this.tbFactura.HeaderText = "Factura";
            this.tbFactura.MinimumWidth = 10;
            this.tbFactura.Name = "tbFactura";
            // 
            // tbNombre
            // 
            this.tbNombre.HeaderText = "Nombre";
            this.tbNombre.MinimumWidth = 15;
            this.tbNombre.Name = "tbNombre";
            // 
            // dgv_PanelC
            // 
            this.dgv_PanelC.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_PanelC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PanelC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbNombre,
            this.tbFactura,
            this.tbObservacion});
            this.dgv_PanelC.Location = new System.Drawing.Point(23, 163);
            this.dgv_PanelC.MaximumSize = new System.Drawing.Size(755, 207);
            this.dgv_PanelC.MinimumSize = new System.Drawing.Size(755, 207);
            this.dgv_PanelC.Name = "dgv_PanelC";
            this.dgv_PanelC.Size = new System.Drawing.Size(755, 207);
            this.dgv_PanelC.TabIndex = 11;
            // 
            // btn_EliminarC
            // 
            this.btn_EliminarC.Location = new System.Drawing.Point(679, 70);
            this.btn_EliminarC.Name = "btn_EliminarC";
            this.btn_EliminarC.Size = new System.Drawing.Size(99, 23);
            this.btn_EliminarC.TabIndex = 32;
            this.btn_EliminarC.Text = "Eliminar";
            this.btn_EliminarC.UseVisualStyleBackColor = true;
            // 
            // tx_NombreC
            // 
            this.tx_NombreC.Location = new System.Drawing.Point(325, 74);
            this.tx_NombreC.Name = "tx_NombreC";
            this.tx_NombreC.Size = new System.Drawing.Size(328, 20);
            this.tx_NombreC.TabIndex = 31;
            this.tx_NombreC.TextChanged += new System.EventHandler(this.tx_NombreC_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(325, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombre completo";
            // 
            // tx_NDocumentoC
            // 
            this.tx_NDocumentoC.Location = new System.Drawing.Point(28, 74);
            this.tx_NDocumentoC.Name = "tx_NDocumentoC";
            this.tx_NDocumentoC.Size = new System.Drawing.Size(229, 20);
            this.tx_NDocumentoC.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Numero de documento";
            // 
            // btn_BuscarC
            // 
            this.btn_BuscarC.Location = new System.Drawing.Point(679, 41);
            this.btn_BuscarC.Name = "btn_BuscarC";
            this.btn_BuscarC.Size = new System.Drawing.Size(99, 23);
            this.btn_BuscarC.TabIndex = 27;
            this.btn_BuscarC.Text = "Buscar";
            this.btn_BuscarC.UseVisualStyleBackColor = true;
            // 
            // btn_ActualizarC
            // 
            this.btn_ActualizarC.Location = new System.Drawing.Point(679, 128);
            this.btn_ActualizarC.Name = "btn_ActualizarC";
            this.btn_ActualizarC.Size = new System.Drawing.Size(99, 23);
            this.btn_ActualizarC.TabIndex = 34;
            this.btn_ActualizarC.Text = "Actualizar";
            this.btn_ActualizarC.UseVisualStyleBackColor = true;
            // 
            // btn_CrearC
            // 
            this.btn_CrearC.Location = new System.Drawing.Point(679, 99);
            this.btn_CrearC.Name = "btn_CrearC";
            this.btn_CrearC.Size = new System.Drawing.Size(99, 23);
            this.btn_CrearC.TabIndex = 33;
            this.btn_CrearC.Text = "Crear";
            this.btn_CrearC.UseVisualStyleBackColor = true;
            // 
            // tx_ObservacionC
            // 
            this.tx_ObservacionC.Location = new System.Drawing.Point(411, 117);
            this.tx_ObservacionC.Name = "tx_ObservacionC";
            this.tx_ObservacionC.Size = new System.Drawing.Size(242, 20);
            this.tx_ObservacionC.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(327, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Observaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(28, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "¿Entrego la factura del mes?";
            // 
            // tx_FacturaC
            // 
            this.tx_FacturaC.Location = new System.Drawing.Point(176, 118);
            this.tx_FacturaC.Name = "tx_FacturaC";
            this.tx_FacturaC.Size = new System.Drawing.Size(81, 20);
            this.tx_FacturaC.TabIndex = 36;
            // 
            // frmChequeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.tx_ObservacionC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_FacturaC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_EliminarC);
            this.Controls.Add(this.tx_NombreC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_NDocumentoC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_BuscarC);
            this.Controls.Add(this.btn_ActualizarC);
            this.Controls.Add(this.btn_CrearC);
            this.Controls.Add(this.btn_SalirC);
            this.Controls.Add(this.btn_AnteriorC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_PanelC);
            this.Name = "frmChequeo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de chequeo";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PanelC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SalirC;
        private System.Windows.Forms.Button btn_AnteriorC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbObservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbNombre;
        private System.Windows.Forms.DataGridView dgv_PanelC;
        private System.Windows.Forms.Button btn_EliminarC;
        private System.Windows.Forms.TextBox tx_NombreC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_NDocumentoC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_BuscarC;
        private System.Windows.Forms.Button btn_ActualizarC;
        private System.Windows.Forms.Button btn_CrearC;
        private System.Windows.Forms.TextBox tx_ObservacionC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_FacturaC;
    }
}