
namespace Tabusca_Ramona_Project_1058
{
    partial class FormFacultate5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacultate5));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInchidere5 = new System.Windows.Forms.Button();
            this.treeViewFac5 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facultatea de Științe ale Educatiei, Științe Sociale şi Psihologie";
            // 
            // buttonInchidere5
            // 
            this.buttonInchidere5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInchidere5.Location = new System.Drawing.Point(512, 322);
            this.buttonInchidere5.Name = "buttonInchidere5";
            this.buttonInchidere5.Size = new System.Drawing.Size(168, 81);
            this.buttonInchidere5.TabIndex = 4;
            this.buttonInchidere5.Text = "ÎNCHIDE";
            this.buttonInchidere5.UseVisualStyleBackColor = true;
            this.buttonInchidere5.Click += new System.EventHandler(this.buttonInchidere5_Click);
            // 
            // treeViewFac5
            // 
            this.treeViewFac5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeViewFac5.Location = new System.Drawing.Point(31, 156);
            this.treeViewFac5.Name = "treeViewFac5";
            this.treeViewFac5.Size = new System.Drawing.Size(443, 410);
            this.treeViewFac5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tabusca_Ramona_Project_1058.Properties.Resources.FAC5_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormFacultate5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(713, 584);
            this.Controls.Add(this.treeViewFac5);
            this.Controls.Add(this.buttonInchidere5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFacultate5";
            this.Text = "Facultatea de Științe ale Educatiei, Științe Sociale şi Psihologie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewFac5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInchidere5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}