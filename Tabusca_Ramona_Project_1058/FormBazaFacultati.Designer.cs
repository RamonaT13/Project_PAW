
namespace Tabusca_Ramona_Project_1058
{
    partial class FormBazaFacultati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBazaFacultati));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idFacultateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeFacultateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultatiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_ProjectDataSet2 = new Tabusca_Ramona_Project_1058.DB_ProjectDataSet2();
            this.facultatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_ProjectDataSet1 = new Tabusca_Ramona_Project_1058.DB_ProjectDataSet1();
            this.facultatiTableAdapter = new Tabusca_Ramona_Project_1058.DB_ProjectDataSet1TableAdapters.FacultatiTableAdapter();
            this.facultatiTableAdapter1 = new Tabusca_Ramona_Project_1058.DB_ProjectDataSet2TableAdapters.FacultatiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultatiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ProjectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ProjectDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFacultateDataGridViewTextBoxColumn,
            this.numeFacultateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facultatiBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // idFacultateDataGridViewTextBoxColumn
            // 
            this.idFacultateDataGridViewTextBoxColumn.DataPropertyName = "IdFacultate";
            this.idFacultateDataGridViewTextBoxColumn.HeaderText = "IdFacultate";
            this.idFacultateDataGridViewTextBoxColumn.Name = "idFacultateDataGridViewTextBoxColumn";
            this.idFacultateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeFacultateDataGridViewTextBoxColumn
            // 
            this.numeFacultateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeFacultateDataGridViewTextBoxColumn.DataPropertyName = "numeFacultate";
            this.numeFacultateDataGridViewTextBoxColumn.HeaderText = "numeFacultate";
            this.numeFacultateDataGridViewTextBoxColumn.Name = "numeFacultateDataGridViewTextBoxColumn";
            // 
            // facultatiBindingSource1
            // 
            this.facultatiBindingSource1.DataMember = "Facultati";
            this.facultatiBindingSource1.DataSource = this.dB_ProjectDataSet2;
            // 
            // dB_ProjectDataSet2
            // 
            this.dB_ProjectDataSet2.DataSetName = "DB_ProjectDataSet2";
            this.dB_ProjectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultatiBindingSource
            // 
            this.facultatiBindingSource.DataMember = "Facultati";
            this.facultatiBindingSource.DataSource = this.dB_ProjectDataSet1;
            // 
            // dB_ProjectDataSet1
            // 
            this.dB_ProjectDataSet1.DataSetName = "DB_ProjectDataSet1";
            this.dB_ProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultatiTableAdapter
            // 
            this.facultatiTableAdapter.ClearBeforeFill = true;
            // 
            // facultatiTableAdapter1
            // 
            this.facultatiTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(536, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Inchide";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBazaFacultati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(668, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBazaFacultati";
            this.Text = "FormBazaFacultati";
            this.Load += new System.EventHandler(this.FormBazaFacultati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultatiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ProjectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ProjectDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_ProjectDataSet1 dB_ProjectDataSet1;
        private System.Windows.Forms.BindingSource facultatiBindingSource;
        private DB_ProjectDataSet1TableAdapters.FacultatiTableAdapter facultatiTableAdapter;
        private DB_ProjectDataSet2 dB_ProjectDataSet2;
        private System.Windows.Forms.BindingSource facultatiBindingSource1;
        private DB_ProjectDataSet2TableAdapters.FacultatiTableAdapter facultatiTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFacultateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeFacultateDataGridViewTextBoxColumn;
    }
}