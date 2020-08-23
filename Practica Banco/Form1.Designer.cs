namespace Practica_Banco
{
    partial class Form1
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
            this.deposito = new System.Windows.Forms.Button();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.monto = new System.Windows.Forms.Label();
            this.retirar = new System.Windows.Forms.Button();
            this.clientetxt = new System.Windows.Forms.TextBox();
            this.cliente1 = new System.Windows.Forms.Button();
            this.cliente2 = new System.Windows.Forms.Button();
            this.cliente3 = new System.Windows.Forms.Button();
            this.saldo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deposito
            // 
            this.deposito.Location = new System.Drawing.Point(37, 162);
            this.deposito.Name = "deposito";
            this.deposito.Size = new System.Drawing.Size(75, 23);
            this.deposito.TabIndex = 0;
            this.deposito.Text = "Depositar";
            this.deposito.UseVisualStyleBackColor = true;
            this.deposito.Click += new System.EventHandler(this.deposito_Click);
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(37, 124);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(100, 20);
            this.cantidad.TabIndex = 1;
            this.cantidad.TextChanged += new System.EventHandler(this.cantidad_TextChanged);
            this.cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_KeyPress);
            // 
            // monto
            // 
            this.monto.AutoSize = true;
            this.monto.Location = new System.Drawing.Point(34, 108);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(37, 13);
            this.monto.TabIndex = 2;
            this.monto.Text = "Monto";
            // 
            // retirar
            // 
            this.retirar.Location = new System.Drawing.Point(136, 162);
            this.retirar.Name = "retirar";
            this.retirar.Size = new System.Drawing.Size(75, 23);
            this.retirar.TabIndex = 3;
            this.retirar.Text = "Retirar";
            this.retirar.UseVisualStyleBackColor = true;
            this.retirar.Click += new System.EventHandler(this.retirar_Click);
            // 
            // clientetxt
            // 
            this.clientetxt.Location = new System.Drawing.Point(37, 76);
            this.clientetxt.Name = "clientetxt";
            this.clientetxt.Size = new System.Drawing.Size(273, 20);
            this.clientetxt.TabIndex = 4;
            // 
            // cliente1
            // 
            this.cliente1.Location = new System.Drawing.Point(37, 12);
            this.cliente1.Name = "cliente1";
            this.cliente1.Size = new System.Drawing.Size(75, 23);
            this.cliente1.TabIndex = 5;
            this.cliente1.Text = "Cliente1";
            this.cliente1.UseVisualStyleBackColor = true;
            this.cliente1.Click += new System.EventHandler(this.cliente1_Click);
            // 
            // cliente2
            // 
            this.cliente2.Location = new System.Drawing.Point(136, 12);
            this.cliente2.Name = "cliente2";
            this.cliente2.Size = new System.Drawing.Size(75, 23);
            this.cliente2.TabIndex = 6;
            this.cliente2.Text = "Cliente2";
            this.cliente2.UseVisualStyleBackColor = true;
            this.cliente2.Click += new System.EventHandler(this.cliente2_Click);
            // 
            // cliente3
            // 
            this.cliente3.Location = new System.Drawing.Point(235, 12);
            this.cliente3.Name = "cliente3";
            this.cliente3.Size = new System.Drawing.Size(75, 23);
            this.cliente3.TabIndex = 7;
            this.cliente3.Text = "Cliente3";
            this.cliente3.UseVisualStyleBackColor = true;
            this.cliente3.Click += new System.EventHandler(this.cliente3_Click);
            // 
            // saldo
            // 
            this.saldo.Location = new System.Drawing.Point(235, 162);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(75, 23);
            this.saldo.TabIndex = 3;
            this.saldo.Text = "Saldo";
            this.saldo.UseVisualStyleBackColor = true;
            this.saldo.Click += new System.EventHandler(this.saldo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 332);
            this.Controls.Add(this.cliente3);
            this.Controls.Add(this.cliente2);
            this.Controls.Add(this.cliente1);
            this.Controls.Add(this.clientetxt);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.retirar);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.deposito);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deposito;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label monto;
        private System.Windows.Forms.Button retirar;
        private System.Windows.Forms.TextBox clientetxt;
        private System.Windows.Forms.Button cliente1;
        private System.Windows.Forms.Button cliente2;
        private System.Windows.Forms.Button cliente3;
        private System.Windows.Forms.Button saldo;
    }
}

