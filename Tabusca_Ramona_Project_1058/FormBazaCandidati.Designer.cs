
namespace Tabusca_Ramona_Project_1058
{
    partial class FormBazaCandidati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBazaCandidati));
            this.dataGridViewCandidati = new System.Windows.Forms.DataGridView();
            this.candidatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_ProjectDataSet = new Tabusca_Ramona_Project_1058.DB_ProjectDataSet();
            this.candidatiTableAdapter = new Tabusca_Ramona_Project_1058.DB_ProjectDataSetTableAdapters.CandidatiTableAdapter();
            this.buttonIesi = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salveazaXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idCandidatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numePrenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDepartajareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultateAleasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializareAleasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCandidati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ProjectDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCandidati
            // 
            this.dataGridViewCandidati.AutoGenerateColumns = false;
            this.dataGridViewCandidati.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewCandidati.CausesValidation = false;
            this.dataGridViewCandidati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCandidati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCandidatDataGridViewTextBoxColumn,
            this.numePrenumeDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.medieDataGridViewTextBoxColumn,
            this.notaDepartajareDataGridViewTextBoxColumn,
            this.facultateAleasaDataGridViewTextBoxColumn,
            this.specializareAleasaDataGridViewTextBoxColumn});
            this.dataGridViewCandidati.DataSource = this.candidatiBindingSource;
            this.dataGridViewCandidati.Location = new System.Drawing.Point(12, 26);
            this.dataGridViewCandidati.Name = "dataGridViewCandidati";
            this.dataGridViewCandidati.Size = new System.Drawing.Size(1029, 412);
            this.dataGridViewCandidati.TabIndex = 0;
            // 
            // candidatiBindingSource
            // 
            this.candidatiBindingSource.DataMember = "Candidati";
            this.candidatiBindingSource.DataSource = this.dB_ProjectDataSet;
            // 
            // dB_ProjectDataSet
            // 
            this.dB_ProjectDataSet.DataSetName = "DB_ProjectDataSet";
            this.dB_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidatiTableAdapter
            // 
            this.candidatiTableAdapter.ClearBeforeFill = true;
            // 
            // buttonIesi
            // 
            this.buttonIesi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonIesi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIesi.Location = new System.Drawing.Point(1063, 190);
            this.buttonIesi.Name = "buttonIesi";
            this.buttonIesi.Size = new System.Drawing.Size(94, 42);
            this.buttonIesi.TabIndex = 1;
            this.buttonIesi.Text = "Inchide";
            this.buttonIesi.UseVisualStyleBackColor = false;
            this.buttonIesi.Click += new System.EventHandler(this.buttonIesi_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaXMLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1181, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salveazaXMLToolStripMenuItem
            // 
            this.salveazaXMLToolStripMenuItem.Name = "salveazaXMLToolStripMenuItem";
            this.salveazaXMLToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.salveazaXMLToolStripMenuItem.Text = "Salveaza XML";
            this.salveazaXMLToolStripMenuItem.Click += new System.EventHandler(this.salveazaXMLToolStripMenuItem_Click);
            // 
            // idCandidatDataGridViewTextBoxColumn
            // 
            this.idCandidatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idCandidatDataGridViewTextBoxColumn.DataPropertyName = "IdCandidat";
            this.idCandidatDataGridViewTextBoxColumn.HeaderText = "IdCandidat";
            this.idCandidatDataGridViewTextBoxColumn.Name = "idCandidatDataGridViewTextBoxColumn";
            this.idCandidatDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCandidatDataGridViewTextBoxColumn.Width = 386;
            // 
            // numePrenumeDataGridViewTextBoxColumn
            // 
            this.numePrenumeDataGridViewTextBoxColumn.DataPropertyName = "NumePrenume";
            this.numePrenumeDataGridViewTextBoxColumn.HeaderText = "NumePrenume";
            this.numePrenumeDataGridViewTextBoxColumn.Name = "numePrenumeDataGridViewTextBoxColumn";
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            // 
            // medieDataGridViewTextBoxColumn
            // 
            this.medieDataGridViewTextBoxColumn.DataPropertyName = "Medie";
            this.medieDataGridViewTextBoxColumn.HeaderText = "Medie";
            this.medieDataGridViewTextBoxColumn.Name = "medieDataGridViewTextBoxColumn";
            // 
            // notaDepartajareDataGridViewTextBoxColumn
            // 
            this.notaDepartajareDataGridViewTextBoxColumn.DataPropertyName = "notaDepartajare";
            this.notaDepartajareDataGridViewTextBoxColumn.HeaderText = "notaDepartajare";
            this.notaDepartajareDataGridViewTextBoxColumn.Name = "notaDepartajareDataGridViewTextBoxColumn";
            // 
            // facultateAleasaDataGridViewTextBoxColumn
            // 
            this.facultateAleasaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.facultateAleasaDataGridViewTextBoxColumn.DataPropertyName = "facultateAleasa";
            this.facultateAleasaDataGridViewTextBoxColumn.HeaderText = "facultateAleasa";
            this.facultateAleasaDataGridViewTextBoxColumn.Name = "facultateAleasaDataGridViewTextBoxColumn";
            // 
            // specializareAleasaDataGridViewTextBoxColumn
            // 
            this.specializareAleasaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.specializareAleasaDataGridViewTextBoxColumn.DataPropertyName = "specializareAleasa";
            this.specializareAleasaDataGridViewTextBoxColumn.HeaderText = "specializareAleasa";
            this.specializareAleasaDataGridViewTextBoxColumn.Name = "specializareAleasaDataGridViewTextBoxColumn";
            // 
            // FormBazaCandidati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1181, 450);
            this.Controls.Add(this.buttonIesi);
            this.Controls.Add(this.dataGridViewCandidati);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormBazaCandidati";
            this.Text = "Baza de date Candidati";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCandidati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ProjectDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCandidati;
        private DB_ProjectDataSet dB_ProjectDataSet;
        private System.Windows.Forms.BindingSource candidatiBindingSource;
        private DB_ProjectDataSetTableAdapters.CandidatiTableAdapter candidatiTableAdapter;
        private System.Windows.Forms.Button buttonIesi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salveazaXMLToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCandidatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numePrenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDepartajareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultateAleasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializareAleasaDataGridViewTextBoxColumn;
    }
}