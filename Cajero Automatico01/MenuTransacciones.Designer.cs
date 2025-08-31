
namespace Cajero_Automatico01
{
    partial class MenuTransacciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuTransacciones));
            this.lblwelcome = new System.Windows.Forms.Label();
            this.Botondepositar = new System.Windows.Forms.Button();
            this.botonretirar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(12, 79);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(690, 31);
            this.lblwelcome.TabIndex = 0;
            this.lblwelcome.Text = "Escoga la transacción que desea realizar por favor: ";
            this.lblwelcome.Click += new System.EventHandler(this.lblwelcome_Click);
            // 
            // Botondepositar
            // 
            this.Botondepositar.BackColor = System.Drawing.Color.Gainsboro;
            this.Botondepositar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Botondepositar.FlatAppearance.BorderSize = 2;
            this.Botondepositar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.Botondepositar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.Botondepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botondepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botondepositar.Location = new System.Drawing.Point(59, 185);
            this.Botondepositar.Name = "Botondepositar";
            this.Botondepositar.Size = new System.Drawing.Size(189, 82);
            this.Botondepositar.TabIndex = 1;
            this.Botondepositar.TabStop = false;
            this.Botondepositar.Text = "Depositar";
            this.Botondepositar.UseVisualStyleBackColor = false;
            this.Botondepositar.Click += new System.EventHandler(this.botondepositar_Click);
            // 
            // botonretirar
            // 
            this.botonretirar.BackColor = System.Drawing.Color.LightGray;
            this.botonretirar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonretirar.FlatAppearance.BorderSize = 2;
            this.botonretirar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.botonretirar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.botonretirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonretirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonretirar.Location = new System.Drawing.Point(426, 185);
            this.botonretirar.Name = "botonretirar";
            this.botonretirar.Size = new System.Drawing.Size(179, 82);
            this.botonretirar.TabIndex = 2;
            this.botonretirar.Text = "Retirar";
            this.botonretirar.UseVisualStyleBackColor = false;
            this.botonretirar.Click += new System.EventHandler(this.botonretirar_Click);
            // 
            // MenuTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(726, 389);
            this.Controls.Add(this.botonretirar);
            this.Controls.Add(this.Botondepositar);
            this.Controls.Add(this.lblwelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuTransacciones";
            this.Text = "MenuTransacciones";
            this.Load += new System.EventHandler(this.MenuTransacciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Button Botondepositar;
        private System.Windows.Forms.Button botonretirar;
    }
}