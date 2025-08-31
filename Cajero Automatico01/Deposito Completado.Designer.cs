
namespace Cajero_Automatico01
{
    partial class Deposito_Completado
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
            this.TransacCompletada = new System.Windows.Forms.Label();
            this.SalirDeposito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TransacCompletada
            // 
            this.TransacCompletada.AutoSize = true;
            this.TransacCompletada.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransacCompletada.Location = new System.Drawing.Point(137, 116);
            this.TransacCompletada.Name = "TransacCompletada";
            this.TransacCompletada.Size = new System.Drawing.Size(506, 55);
            this.TransacCompletada.TabIndex = 0;
            this.TransacCompletada.Text = "Depósito Completado";
            // 
            // SalirDeposito
            // 
            this.SalirDeposito.BackColor = System.Drawing.Color.DarkGray;
            this.SalirDeposito.FlatAppearance.BorderSize = 2;
            this.SalirDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalirDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirDeposito.Location = new System.Drawing.Point(278, 253);
            this.SalirDeposito.Name = "SalirDeposito";
            this.SalirDeposito.Size = new System.Drawing.Size(224, 71);
            this.SalirDeposito.TabIndex = 1;
            this.SalirDeposito.Text = "Salir";
            this.SalirDeposito.UseVisualStyleBackColor = false;
            this.SalirDeposito.Click += new System.EventHandler(this.SalirDeposito_Click);
            // 
            // Deposito_Completado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalirDeposito);
            this.Controls.Add(this.TransacCompletada);
            this.Name = "Deposito_Completado";
            this.Text = "Depósito_Completado";
            this.Load += new System.EventHandler(this.Deposito_Completado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TransacCompletada;
        private System.Windows.Forms.Button SalirDeposito;
    }
}