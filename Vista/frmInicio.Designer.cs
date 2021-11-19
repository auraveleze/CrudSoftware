
using System;

namespace ProyectoSoftwareWeb.Vista
{
    partial class frmInicio
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SalirI = new System.Windows.Forms.Button();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(98, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Informacion almacenada";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(98, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Encuestas";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Location = new System.Drawing.Point(98, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Documentos";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Thistle;
            this.button4.Location = new System.Drawing.Point(98, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Usuarios";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Thistle;
            this.button5.Location = new System.Drawing.Point(98, 361);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(205, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "Lista de Chequeo";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Desde este menu podras acceder a las diferentes acciones a realizar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pagina principal";
            // 
            // btn_SalirI
            // 
            this.btn_SalirI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirI.ForeColor = System.Drawing.Color.Red;
            this.btn_SalirI.Location = new System.Drawing.Point(359, 403);
            this.btn_SalirI.Name = "btn_SalirI";
            this.btn_SalirI.Size = new System.Drawing.Size(52, 23);
            this.btn_SalirI.TabIndex = 11;
            this.btn_SalirI.Text = "Salir";
            this.btn_SalirI.UseVisualStyleBackColor = true;
            this.btn_SalirI.Click += new System.EventHandler(this.btn_SalirI_Click_1);
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Conectar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Conectar.Location = new System.Drawing.Point(3, 403);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(62, 23);
            this.btn_Conectar.TabIndex = 12;
            this.btn_Conectar.Text = "Conectar";
            this.btn_Conectar.UseVisualStyleBackColor = true;
            this.btn_Conectar.Click += new System.EventHandler(this.button6_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 429);
            this.Controls.Add(this.btn_Conectar);
            this.Controls.Add(this.btn_SalirI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SalirI;
        private EventHandler button1_Click;
        private EventHandler button2_Click;
        private EventHandler button3_Click;
        private EventHandler button4_Click;
        private EventHandler button5_Click;
        private EventHandler btn_SalirI_Click;
        private EventHandler frmInicio_Load;
        private System.Windows.Forms.Button btn_Conectar;
    }
}