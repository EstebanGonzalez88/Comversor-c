namespace Comversor_c
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblcelsius = new System.Windows.Forms.Label();
            this.lblfahrenheint = new System.Windows.Forms.Label();
            this.btncelcius = new System.Windows.Forms.Button();
            this.btnfahrenheint = new System.Windows.Forms.Button();
            this.txtcelsius = new System.Windows.Forms.TextBox();
            this.txtfahrenheint = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Red;
            this.lbltitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Location = new System.Drawing.Point(222, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(349, 24);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "CONVERSOR DE TEMPERATURA";
            // 
            // lblcelsius
            // 
            this.lblcelsius.AutoSize = true;
            this.lblcelsius.BackColor = System.Drawing.Color.White;
            this.lblcelsius.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcelsius.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblcelsius.Location = new System.Drawing.Point(110, 97);
            this.lblcelsius.Name = "lblcelsius";
            this.lblcelsius.Size = new System.Drawing.Size(129, 22);
            this.lblcelsius.TabIndex = 1;
            this.lblcelsius.Text = "Grados Celsius";
            // 
            // lblfahrenheint
            // 
            this.lblfahrenheint.AutoSize = true;
            this.lblfahrenheint.BackColor = System.Drawing.Color.White;
            this.lblfahrenheint.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfahrenheint.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblfahrenheint.Location = new System.Drawing.Point(519, 97);
            this.lblfahrenheint.Name = "lblfahrenheint";
            this.lblfahrenheint.Size = new System.Drawing.Size(168, 22);
            this.lblfahrenheint.TabIndex = 2;
            this.lblfahrenheint.Text = "Grados Fahrenheint";
            // 
            // btncelcius
            // 
            this.btncelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncelcius.Location = new System.Drawing.Point(114, 254);
            this.btncelcius.Name = "btncelcius";
            this.btncelcius.Size = new System.Drawing.Size(125, 40);
            this.btncelcius.TabIndex = 3;
            this.btncelcius.Text = "De fahrenheint a Celcius";
            this.btncelcius.UseVisualStyleBackColor = true;
            this.btncelcius.Click += new System.EventHandler(this.btncelcius_Click);
            // 
            // btnfahrenheint
            // 
            this.btnfahrenheint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfahrenheint.Location = new System.Drawing.Point(536, 254);
            this.btnfahrenheint.Name = "btnfahrenheint";
            this.btnfahrenheint.Size = new System.Drawing.Size(131, 40);
            this.btnfahrenheint.TabIndex = 4;
            this.btnfahrenheint.Text = "De Celsius a Fahrenheint";
            this.btnfahrenheint.UseVisualStyleBackColor = true;
            this.btnfahrenheint.Click += new System.EventHandler(this.btnfahrenheint_Click);
            // 
            // txtcelsius
            // 
            this.txtcelsius.Location = new System.Drawing.Point(114, 166);
            this.txtcelsius.Name = "txtcelsius";
            this.txtcelsius.Size = new System.Drawing.Size(125, 20);
            this.txtcelsius.TabIndex = 5;
            this.txtcelsius.TextChanged += new System.EventHandler(this.txtcelsius_TextChanged);
            // 
            // txtfahrenheint
            // 
            this.txtfahrenheint.Location = new System.Drawing.Point(536, 166);
            this.txtfahrenheint.Name = "txtfahrenheint";
            this.txtfahrenheint.Size = new System.Drawing.Size(131, 20);
            this.txtfahrenheint.TabIndex = 6;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(357, 254);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 40);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtfahrenheint);
            this.Controls.Add(this.txtcelsius);
            this.Controls.Add(this.btnfahrenheint);
            this.Controls.Add(this.btncelcius);
            this.Controls.Add(this.lblfahrenheint);
            this.Controls.Add(this.lblcelsius);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "PEREZ GONZALEZ JOSE ESTEBAN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblcelsius;
        private System.Windows.Forms.Label lblfahrenheint;
        private System.Windows.Forms.Button btncelcius;
        private System.Windows.Forms.Button btnfahrenheint;
        private System.Windows.Forms.TextBox txtcelsius;
        private System.Windows.Forms.TextBox txtfahrenheint;
        private System.Windows.Forms.Button btnlimpiar;
    }
}

