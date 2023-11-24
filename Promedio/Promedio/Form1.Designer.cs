namespace Promedio
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
            this.txtpromedio = new System.Windows.Forms.TextBox();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcondicion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtpromedio
            // 
            this.txtpromedio.Location = new System.Drawing.Point(331, 445);
            this.txtpromedio.Margin = new System.Windows.Forms.Padding(10);
            this.txtpromedio.Multiline = true;
            this.txtpromedio.Name = "txtpromedio";
            this.txtpromedio.Size = new System.Drawing.Size(156, 46);
            this.txtpromedio.TabIndex = 65;
            // 
            // txtnota3
            // 
            this.txtnota3.Location = new System.Drawing.Point(331, 214);
            this.txtnota3.Margin = new System.Windows.Forms.Padding(10);
            this.txtnota3.Multiline = true;
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(156, 46);
            this.txtnota3.TabIndex = 64;
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnnuevo.Location = new System.Drawing.Point(491, 311);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(188, 60);
            this.btnnuevo.TabIndex = 63;
            this.btnnuevo.Text = "Limpiar";
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "El promedio es:";
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btncalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncalcular.Location = new System.Drawing.Point(71, 311);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(211, 60);
            this.btncalcular.TabIndex = 60;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Nota 3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Nota 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Nota 1:";
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(331, 126);
            this.txtnota2.Margin = new System.Windows.Forms.Padding(10);
            this.txtnota2.Multiline = true;
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(156, 46);
            this.txtnota2.TabIndex = 57;
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(331, 45);
            this.txtnota1.Multiline = true;
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(156, 43);
            this.txtnota1.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Condición:";
            // 
            // txtcondicion
            // 
            this.txtcondicion.Location = new System.Drawing.Point(331, 525);
            this.txtcondicion.Margin = new System.Windows.Forms.Padding(10);
            this.txtcondicion.Multiline = true;
            this.txtcondicion.Name = "txtcondicion";
            this.txtcondicion.Size = new System.Drawing.Size(156, 46);
            this.txtcondicion.TabIndex = 67;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 608);
            this.Controls.Add(this.txtcondicion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpromedio);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.txtnota1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpromedio;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcondicion;
    }
}

