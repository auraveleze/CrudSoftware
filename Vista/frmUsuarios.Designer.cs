
namespace ProyectoSoftwareWeb.Vista
{
    partial class frmUsuarios
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
            this.btn_EliminarU = new System.Windows.Forms.Button();
            this.tx_NombreU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_NDocumentoU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_BuscarU = new System.Windows.Forms.Button();
            this.btn_CrearU = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_ContraseñaU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_UsuarioU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_SalirU = new System.Windows.Forms.Button();
            this.btn_AnteriorU = new System.Windows.Forms.Button();
            this.data_gv1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EliminarU
            // 
            this.btn_EliminarU.Location = new System.Drawing.Point(677, 51);
            this.btn_EliminarU.Name = "btn_EliminarU";
            this.btn_EliminarU.Size = new System.Drawing.Size(99, 23);
            this.btn_EliminarU.TabIndex = 13;
            this.btn_EliminarU.Text = "Eliminar";
            this.btn_EliminarU.UseVisualStyleBackColor = true;
            this.btn_EliminarU.Click += new System.EventHandler(this.btn_EliminarU_Click);
            // 
            // tx_NombreU
            // 
            this.tx_NombreU.Location = new System.Drawing.Point(332, 39);
            this.tx_NombreU.Name = "tx_NombreU";
            this.tx_NombreU.Size = new System.Drawing.Size(278, 20);
            this.tx_NombreU.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(332, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre completo";
            // 
            // tx_NDocumentoU
            // 
            this.tx_NDocumentoU.Location = new System.Drawing.Point(35, 39);
            this.tx_NDocumentoU.Name = "tx_NDocumentoU";
            this.tx_NDocumentoU.Size = new System.Drawing.Size(229, 20);
            this.tx_NDocumentoU.TabIndex = 10;
            this.tx_NDocumentoU.TextChanged += new System.EventHandler(this.tx_NDocumentoU_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero de documento";
            // 
            // btn_BuscarU
            // 
            this.btn_BuscarU.Location = new System.Drawing.Point(677, 22);
            this.btn_BuscarU.Name = "btn_BuscarU";
            this.btn_BuscarU.Size = new System.Drawing.Size(99, 23);
            this.btn_BuscarU.TabIndex = 8;
            this.btn_BuscarU.Text = "Buscar";
            this.btn_BuscarU.UseVisualStyleBackColor = true;
            this.btn_BuscarU.Click += new System.EventHandler(this.btn_BuscarU_Click);
            // 
            // btn_CrearU
            // 
            this.btn_CrearU.Location = new System.Drawing.Point(654, 10);
            this.btn_CrearU.Name = "btn_CrearU";
            this.btn_CrearU.Size = new System.Drawing.Size(99, 23);
            this.btn_CrearU.TabIndex = 14;
            this.btn_CrearU.Text = "Crear";
            this.btn_CrearU.UseVisualStyleBackColor = true;
            this.btn_CrearU.Click += new System.EventHandler(this.btn_CrearU_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tx_ContraseñaU);
            this.groupBox1.Controls.Add(this.btn_CrearU);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tx_UsuarioU);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(23, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 105);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(43, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Informacion para iniciar sesion";
            // 
            // tx_ContraseñaU
            // 
            this.tx_ContraseñaU.Location = new System.Drawing.Point(446, 70);
            this.tx_ContraseñaU.Name = "tx_ContraseñaU";
            this.tx_ContraseñaU.Size = new System.Drawing.Size(241, 20);
            this.tx_ContraseñaU.TabIndex = 19;
            this.tx_ContraseñaU.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(355, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tx_UsuarioU
            // 
            this.tx_UsuarioU.Location = new System.Drawing.Point(107, 70);
            this.tx_UsuarioU.Name = "tx_UsuarioU";
            this.tx_UsuarioU.Size = new System.Drawing.Size(204, 20);
            this.tx_UsuarioU.TabIndex = 17;
            this.tx_UsuarioU.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(40, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Usuario";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_SalirU
            // 
            this.btn_SalirU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirU.ForeColor = System.Drawing.Color.Red;
            this.btn_SalirU.Location = new System.Drawing.Point(727, 176);
            this.btn_SalirU.Name = "btn_SalirU";
            this.btn_SalirU.Size = new System.Drawing.Size(52, 23);
            this.btn_SalirU.TabIndex = 17;
            this.btn_SalirU.Text = "Salir";
            this.btn_SalirU.UseVisualStyleBackColor = true;
            this.btn_SalirU.Click += new System.EventHandler(this.btn_SalirU_Click);
            // 
            // btn_AnteriorU
            // 
            this.btn_AnteriorU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AnteriorU.ForeColor = System.Drawing.Color.Black;
            this.btn_AnteriorU.Location = new System.Drawing.Point(675, 176);
            this.btn_AnteriorU.Name = "btn_AnteriorU";
            this.btn_AnteriorU.Size = new System.Drawing.Size(52, 23);
            this.btn_AnteriorU.TabIndex = 16;
            this.btn_AnteriorU.Text = "Anterior";
            this.btn_AnteriorU.UseVisualStyleBackColor = true;
            this.btn_AnteriorU.Click += new System.EventHandler(this.btn_AnteriorU_Click);
            // 
            // data_gv1
            // 
            this.data_gv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gv1.Location = new System.Drawing.Point(38, 218);
            this.data_gv1.Name = "data_gv1";
            this.data_gv1.Size = new System.Drawing.Size(722, 118);
            this.data_gv1.TabIndex = 18;
            this.data_gv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.data_gv1);
            this.Controls.Add(this.btn_SalirU);
            this.Controls.Add(this.btn_AnteriorU);
            this.Controls.Add(this.btn_EliminarU);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tx_NombreU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_NDocumentoU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_BuscarU);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EliminarU;
        private System.Windows.Forms.TextBox tx_NombreU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_NDocumentoU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_BuscarU;
        private System.Windows.Forms.Button btn_CrearU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_SalirU;
        private System.Windows.Forms.Button btn_AnteriorU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_ContraseñaU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_UsuarioU;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView data_gv1;
    }
}