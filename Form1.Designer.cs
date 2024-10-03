namespace PonderaciónConDataTable
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
            this.tablaRegistros = new System.Windows.Forms.DataGridView();
            this.asignturaSeleccion = new System.Windows.Forms.ComboBox();
            this.nombreInput = new System.Windows.Forms.TextBox();
            this.nota1input = new System.Windows.Forms.NumericUpDown();
            this.nota2input = new System.Windows.Forms.NumericUpDown();
            this.nota3input = new System.Windows.Forms.NumericUpDown();
            this.nota4input = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota1input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota2input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota3input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota4input)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaRegistros
            // 
            this.tablaRegistros.AllowUserToAddRows = false;
            this.tablaRegistros.AllowUserToDeleteRows = false;
            this.tablaRegistros.AllowUserToResizeColumns = false;
            this.tablaRegistros.AllowUserToResizeRows = false;
            this.tablaRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRegistros.GridColor = System.Drawing.SystemColors.Control;
            this.tablaRegistros.Location = new System.Drawing.Point(12, 307);
            this.tablaRegistros.Name = "tablaRegistros";
            this.tablaRegistros.RowHeadersWidth = 51;
            this.tablaRegistros.RowTemplate.Height = 24;
            this.tablaRegistros.ShowEditingIcon = false;
            this.tablaRegistros.Size = new System.Drawing.Size(1253, 357);
            this.tablaRegistros.TabIndex = 0;
            this.tablaRegistros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaRegistros_CellClick);
            // 
            // asignturaSeleccion
            // 
            this.asignturaSeleccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.asignturaSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asignturaSeleccion.FormattingEnabled = true;
            this.asignturaSeleccion.Items.AddRange(new object[] {
            "Desarrollo y Diseño de Software",
            "Taller de Creatividad e Innovacion",
            "Programacion II",
            "Bases de Datos II",
            "Inglés I"});
            this.asignturaSeleccion.Location = new System.Drawing.Point(277, 105);
            this.asignturaSeleccion.Name = "asignturaSeleccion";
            this.asignturaSeleccion.Size = new System.Drawing.Size(253, 37);
            this.asignturaSeleccion.TabIndex = 1;
            this.asignturaSeleccion.Text = "Desarrollo y Diseño de Software";
            // 
            // nombreInput
            // 
            this.nombreInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreInput.Location = new System.Drawing.Point(277, 54);
            this.nombreInput.Name = "nombreInput";
            this.nombreInput.Size = new System.Drawing.Size(253, 34);
            this.nombreInput.TabIndex = 2;
            // 
            // nota1input
            // 
            this.nota1input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota1input.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nota1input.Location = new System.Drawing.Point(669, 54);
            this.nota1input.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nota1input.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nota1input.Name = "nota1input";
            this.nota1input.Size = new System.Drawing.Size(120, 34);
            this.nota1input.TabIndex = 3;
            this.nota1input.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // nota2input
            // 
            this.nota2input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota2input.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nota2input.Location = new System.Drawing.Point(669, 98);
            this.nota2input.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nota2input.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nota2input.Name = "nota2input";
            this.nota2input.Size = new System.Drawing.Size(120, 34);
            this.nota2input.TabIndex = 4;
            this.nota2input.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // nota3input
            // 
            this.nota3input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota3input.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nota3input.Location = new System.Drawing.Point(669, 140);
            this.nota3input.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nota3input.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nota3input.Name = "nota3input";
            this.nota3input.Size = new System.Drawing.Size(120, 34);
            this.nota3input.TabIndex = 5;
            this.nota3input.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // nota4input
            // 
            this.nota4input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota4input.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nota4input.Location = new System.Drawing.Point(669, 182);
            this.nota4input.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nota4input.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nota4input.Name = "nota4input";
            this.nota4input.Size = new System.Drawing.Size(120, 34);
            this.nota4input.TabIndex = 6;
            this.nota4input.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Asignatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nota 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(569, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nota 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(569, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nota 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(569, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nota 4";
            // 
            // agregarBtn
            // 
            this.agregarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarBtn.Location = new System.Drawing.Point(395, 243);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(94, 32);
            this.agregarBtn.TabIndex = 13;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarBtn.Location = new System.Drawing.Point(495, 243);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(94, 32);
            this.eliminarBtn.TabIndex = 14;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // editarBtn
            // 
            this.editarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarBtn.Location = new System.Drawing.Point(595, 243);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(94, 32);
            this.editarBtn.TabIndex = 15;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = true;
            this.editarBtn.Click += new System.EventHandler(this.editarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 676);
            this.Controls.Add(this.editarBtn);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nota4input);
            this.Controls.Add(this.nota3input);
            this.Controls.Add(this.nota2input);
            this.Controls.Add(this.nota1input);
            this.Controls.Add(this.nombreInput);
            this.Controls.Add(this.asignturaSeleccion);
            this.Controls.Add(this.tablaRegistros);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablaRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota1input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota2input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota3input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota4input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaRegistros;
        private System.Windows.Forms.ComboBox asignturaSeleccion;
        private System.Windows.Forms.TextBox nombreInput;
        private System.Windows.Forms.NumericUpDown nota1input;
        private System.Windows.Forms.NumericUpDown nota2input;
        private System.Windows.Forms.NumericUpDown nota3input;
        private System.Windows.Forms.NumericUpDown nota4input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button editarBtn;
    }
}

