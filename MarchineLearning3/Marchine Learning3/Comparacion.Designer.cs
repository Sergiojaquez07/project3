namespace Marchine_Learning3
{
    partial class Comparacion
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenesDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.imagenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guardarDataSet3 = new Marchine_Learning3.guardarDataSet3();
            this.imagenesTableAdapter = new Marchine_Learning3.guardarDataSet3TableAdapters.imagenesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardarDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.imagenesDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.imagenesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(231, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 203);
            this.dataGridView1.TabIndex = 1;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // imagenesDataGridViewImageColumn
            // 
            this.imagenesDataGridViewImageColumn.DataPropertyName = "imagenes";
            this.imagenesDataGridViewImageColumn.HeaderText = "imagenes";
            this.imagenesDataGridViewImageColumn.Name = "imagenesDataGridViewImageColumn";
            // 
            // imagenesBindingSource
            // 
            this.imagenesBindingSource.DataMember = "imagenes";
            this.imagenesBindingSource.DataSource = this.guardarDataSet3;
            // 
            // guardarDataSet3
            // 
            this.guardarDataSet3.DataSetName = "guardarDataSet3";
            this.guardarDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imagenesTableAdapter
            // 
            this.imagenesTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fotos de las Personas  Desaparecidas";
            // 
            // Comparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Comparacion";
            this.Text = "Comparacion";
            this.Load += new System.EventHandler(this.Comparacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardarDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private guardarDataSet3 guardarDataSet3;
        private System.Windows.Forms.BindingSource imagenesBindingSource;
        private guardarDataSet3TableAdapters.imagenesTableAdapter imagenesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenesDataGridViewImageColumn;
        private System.Windows.Forms.Label label2;
    }
}