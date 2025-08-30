
namespace Cajero_Automatico01
{
    partial class MenuLogin
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
            this.lblw = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.botoncontinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblw
            // 
            this.lblw.AutoSize = true;
            this.lblw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblw.Location = new System.Drawing.Point(130, 94);
            this.lblw.Name = "lblw";
            this.lblw.Size = new System.Drawing.Size(129, 25);
            this.lblw.TabIndex = 0;
            this.lblw.Text = "Bienvenido";
            this.lblw.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblname.Location = new System.Drawing.Point(80, 23);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(233, 37);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "CAJERO ATM";
            this.lblname.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(83, 147);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(214, 20);
            this.lbluser.TabIndex = 3;
            this.lbluser.Text = "Ingrese su primer nombre";
            this.lbluser.Click += new System.EventHandler(this.lbluser_Click);
            // 
            // botoncontinuar
            // 
            this.botoncontinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoncontinuar.Location = new System.Drawing.Point(135, 235);
            this.botoncontinuar.Name = "botoncontinuar";
            this.botoncontinuar.Size = new System.Drawing.Size(100, 37);
            this.botoncontinuar.TabIndex = 4;
            this.botoncontinuar.Text = "Continuar";
            this.botoncontinuar.UseVisualStyleBackColor = true;
            this.botoncontinuar.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(409, 310);
            this.Controls.Add(this.botoncontinuar);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MenuLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Cajero Automático";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblw;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Button botoncontinuar;
    }
}

