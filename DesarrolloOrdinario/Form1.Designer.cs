namespace DesarrolloOrdinario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MostrarArea = new System.Windows.Forms.Button();
            this.MostrarVolumenes = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.desarrolloDataSet = new DesarrolloOrdinario.desarrolloDataSet();
            this.puntajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.puntajesTableAdapter = new DesarrolloOrdinario.desarrolloDataSetTableAdapters.puntajesTableAdapter();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntajeAreasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntajeVolumenesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntajesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MostrarArea
            // 
            this.MostrarArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MostrarArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarArea.ForeColor = System.Drawing.Color.White;
            this.MostrarArea.Image = ((System.Drawing.Image)(resources.GetObject("MostrarArea.Image")));
            this.MostrarArea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MostrarArea.Location = new System.Drawing.Point(28, 159);
            this.MostrarArea.Name = "MostrarArea";
            this.MostrarArea.Size = new System.Drawing.Size(316, 87);
            this.MostrarArea.TabIndex = 0;
            this.MostrarArea.Text = "Aprender sobre áreas";
            this.MostrarArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MostrarArea.UseVisualStyleBackColor = false;
            this.MostrarArea.Click += new System.EventHandler(this.button1_Click);
            // 
            // MostrarVolumenes
            // 
            this.MostrarVolumenes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.MostrarVolumenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarVolumenes.ForeColor = System.Drawing.Color.White;
            this.MostrarVolumenes.Image = ((System.Drawing.Image)(resources.GetObject("MostrarVolumenes.Image")));
            this.MostrarVolumenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MostrarVolumenes.Location = new System.Drawing.Point(28, 251);
            this.MostrarVolumenes.Name = "MostrarVolumenes";
            this.MostrarVolumenes.Size = new System.Drawing.Size(316, 91);
            this.MostrarVolumenes.TabIndex = 1;
            this.MostrarVolumenes.Text = "Aprender sobre volúmenes";
            this.MostrarVolumenes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MostrarVolumenes.UseVisualStyleBackColor = false;
            this.MostrarVolumenes.Click += new System.EventHandler(this.button2_Click);
            // 
            // Salir
            // 
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Salir.Location = new System.Drawing.Point(1053, 353);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(102, 50);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Salir";
            this.Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "¡Bienvenido!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "¿Qué busca aprender?";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.puntajeAreasDataGridViewTextBoxColumn,
            this.puntajeVolumenesDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.puntajesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(381, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(774, 225);
            this.dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(679, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tabla de puntajes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre de \r\nUsuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // desarrolloDataSet
            // 
            this.desarrolloDataSet.DataSetName = "desarrolloDataSet";
            this.desarrolloDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // puntajesBindingSource
            // 
            this.puntajesBindingSource.DataMember = "puntajes";
            this.puntajesBindingSource.DataSource = this.desarrolloDataSet;
            // 
            // puntajesTableAdapter
            // 
            this.puntajesTableAdapter.ClearBeforeFill = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // puntajeAreasDataGridViewTextBoxColumn
            // 
            this.puntajeAreasDataGridViewTextBoxColumn.DataPropertyName = "puntajeAreas";
            this.puntajeAreasDataGridViewTextBoxColumn.HeaderText = "Puntaje en Areas";
            this.puntajeAreasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.puntajeAreasDataGridViewTextBoxColumn.Name = "puntajeAreasDataGridViewTextBoxColumn";
            this.puntajeAreasDataGridViewTextBoxColumn.ReadOnly = true;
            this.puntajeAreasDataGridViewTextBoxColumn.Width = 125;
            // 
            // puntajeVolumenesDataGridViewTextBoxColumn
            // 
            this.puntajeVolumenesDataGridViewTextBoxColumn.DataPropertyName = "puntajeVolumenes";
            this.puntajeVolumenesDataGridViewTextBoxColumn.HeaderText = "Puntaje en Volumenes";
            this.puntajeVolumenesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.puntajeVolumenesDataGridViewTextBoxColumn.Name = "puntajeVolumenesDataGridViewTextBoxColumn";
            this.puntajeVolumenesDataGridViewTextBoxColumn.ReadOnly = true;
            this.puntajeVolumenesDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(64)))), ((int)(((byte)(51)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(381, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 50);
            this.button2.TabIndex = 10;
            this.button2.Text = "Eliminar \r\npuntajes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 415);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.MostrarVolumenes);
            this.Controls.Add(this.MostrarArea);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolloDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntajesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MostrarArea;
        private System.Windows.Forms.Button MostrarVolumenes;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private desarrolloDataSet desarrolloDataSet;
        private System.Windows.Forms.BindingSource puntajesBindingSource;
        private desarrolloDataSetTableAdapters.puntajesTableAdapter puntajesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntajeAreasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntajeVolumenesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}

