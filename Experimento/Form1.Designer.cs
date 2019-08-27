namespace Experimento
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
            this.comboAlgoritmo = new System.Windows.Forms.ComboBox();
            this.comboTamanio = new System.Windows.Forms.ComboBox();
            this.comboOrden = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.listTiempos = new System.Windows.Forms.ListBox();
            this.comboRepe = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboAlgoritmo
            // 
            this.comboAlgoritmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlgoritmo.FormattingEnabled = true;
            this.comboAlgoritmo.Items.AddRange(new object[] {
            "MergeSort",
            "InsertionSort"});
            this.comboAlgoritmo.Location = new System.Drawing.Point(109, 22);
            this.comboAlgoritmo.Name = "comboAlgoritmo";
            this.comboAlgoritmo.Size = new System.Drawing.Size(121, 21);
            this.comboAlgoritmo.TabIndex = 0;
            // 
            // comboTamanio
            // 
            this.comboTamanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTamanio.FormattingEnabled = true;
            this.comboTamanio.Items.AddRange(new object[] {
            "1000",
            "100000",
            "10000000"});
            this.comboTamanio.Location = new System.Drawing.Point(109, 75);
            this.comboTamanio.Name = "comboTamanio";
            this.comboTamanio.Size = new System.Drawing.Size(121, 21);
            this.comboTamanio.TabIndex = 1;
            // 
            // comboOrden
            // 
            this.comboOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrden.FormattingEnabled = true;
            this.comboOrden.Items.AddRange(new object[] {
            "Aleatorio",
            "Ascendente",
            "Descendente"});
            this.comboOrden.Location = new System.Drawing.Point(109, 126);
            this.comboOrden.Name = "comboOrden";
            this.comboOrden.Size = new System.Drawing.Size(121, 21);
            this.comboOrden.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Algoritmo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tamaño arreglo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ordenamiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tiempos";
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Location = new System.Drawing.Point(77, 239);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(110, 53);
            this.buttonOrdenar.TabIndex = 7;
            this.buttonOrdenar.Text = "ORDENAR";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.ButtonOrdenar_Click);
            // 
            // listTiempos
            // 
            this.listTiempos.FormattingEnabled = true;
            this.listTiempos.Location = new System.Drawing.Point(317, 46);
            this.listTiempos.Name = "listTiempos";
            this.listTiempos.Size = new System.Drawing.Size(120, 290);
            this.listTiempos.TabIndex = 8;
            // 
            // comboRepe
            // 
            this.comboRepe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRepe.FormattingEnabled = true;
            this.comboRepe.Items.AddRange(new object[] {
            "1",
            "500",
            "1000"});
            this.comboRepe.Location = new System.Drawing.Point(109, 178);
            this.comboRepe.Name = "comboRepe";
            this.comboRepe.Size = new System.Drawing.Size(121, 21);
            this.comboRepe.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "# Repeticiones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 362);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboRepe);
            this.Controls.Add(this.listTiempos);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboOrden);
            this.Controls.Add(this.comboTamanio);
            this.Controls.Add(this.comboAlgoritmo);
            this.Name = "Form1";
            this.Text = "Experimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAlgoritmo;
        private System.Windows.Forms.ComboBox comboTamanio;
        private System.Windows.Forms.ComboBox comboOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.ListBox listTiempos;
        private System.Windows.Forms.ComboBox comboRepe;
        private System.Windows.Forms.Label label5;
    }
}

