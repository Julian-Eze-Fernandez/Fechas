namespace EjercicioPrg2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtAño = new System.Windows.Forms.TextBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.LblMes = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.LblAño = new System.Windows.Forms.Label();
            this.LblDia = new System.Windows.Forms.Label();
            this.CmbBoxMes = new System.Windows.Forms.ComboBox();
            this.TxtDia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtAño
            // 
            this.TxtAño.Location = new System.Drawing.Point(131, 30);
            this.TxtAño.MaxLength = 4;
            this.TxtAño.Name = "TxtAño";
            this.TxtAño.Size = new System.Drawing.Size(52, 20);
            this.TxtAño.TabIndex = 2;
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(207, 9);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(77, 42);
            this.Btn1.TabIndex = 3;
            this.Btn1.Text = "Adivinar";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // LblMes
            // 
            this.LblMes.AutoSize = true;
            this.LblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMes.Location = new System.Drawing.Point(70, 9);
            this.LblMes.Name = "LblMes";
            this.LblMes.Size = new System.Drawing.Size(37, 17);
            this.LblMes.TabIndex = 4;
            this.LblMes.Text = "Mes";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(87, 118);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(0, 17);
            this.LblResultado.TabIndex = 5;
            // 
            // LblAño
            // 
            this.LblAño.AutoSize = true;
            this.LblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAño.Location = new System.Drawing.Point(128, 9);
            this.LblAño.Name = "LblAño";
            this.LblAño.Size = new System.Drawing.Size(36, 17);
            this.LblAño.TabIndex = 6;
            this.LblAño.Text = "Año";
            // 
            // LblDia
            // 
            this.LblDia.AutoSize = true;
            this.LblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDia.Location = new System.Drawing.Point(12, 9);
            this.LblDia.Name = "LblDia";
            this.LblDia.Size = new System.Drawing.Size(32, 17);
            this.LblDia.TabIndex = 7;
            this.LblDia.Text = "Dia";
            // 
            // CmbBoxMes
            // 
            this.CmbBoxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxMes.FormattingEnabled = true;
            this.CmbBoxMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.CmbBoxMes.Location = new System.Drawing.Point(70, 30);
            this.CmbBoxMes.Name = "CmbBoxMes";
            this.CmbBoxMes.Size = new System.Drawing.Size(40, 21);
            this.CmbBoxMes.TabIndex = 9;
            // 
            // TxtDia
            // 
            this.TxtDia.Location = new System.Drawing.Point(15, 31);
            this.TxtDia.MaxLength = 2;
            this.TxtDia.Name = "TxtDia";
            this.TxtDia.Size = new System.Drawing.Size(40, 20);
            this.TxtDia.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "El dia proximo sera:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(334, 203);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDia);
            this.Controls.Add(this.CmbBoxMes);
            this.Controls.Add(this.LblDia);
            this.Controls.Add(this.LblAño);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblMes);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.TxtAño);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ejercicio Fecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtAño;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Label LblMes;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblAño;
        private System.Windows.Forms.Label LblDia;
        private System.Windows.Forms.ComboBox CmbBoxMes;
        private System.Windows.Forms.TextBox TxtDia;
        private System.Windows.Forms.Label label1;
    }
}

