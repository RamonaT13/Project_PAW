
namespace Tabusca_Ramona_Project_1058
{
    partial class FormFacultate3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacultate3));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInchidere3 = new System.Windows.Forms.Button();
            this.treeViewFac3 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facultatea de Electronica, Comunicatii si Calculatoare";
            // 
            // buttonInchidere3
            // 
            this.buttonInchidere3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInchidere3.Location = new System.Drawing.Point(512, 322);
            this.buttonInchidere3.Name = "buttonInchidere3";
            this.buttonInchidere3.Size = new System.Drawing.Size(168, 81);
            this.buttonInchidere3.TabIndex = 4;
            this.buttonInchidere3.Text = "ÎNCHIDE";
            this.buttonInchidere3.UseVisualStyleBackColor = true;
            this.buttonInchidere3.Click += new System.EventHandler(this.buttonInchidere3_Click);
            // 
            // treeViewFac3
            // 
            this.treeViewFac3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeViewFac3.Location = new System.Drawing.Point(31, 156);
            this.treeViewFac3.Name = "treeViewFac3";
            this.treeViewFac3.Size = new System.Drawing.Size(443, 410);
            this.treeViewFac3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tabusca_Ramona_Project_1058.Properties.Resources.fac3;
            this.pictureBox1.Location = new System.Drawing.Point(-9, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormFacultate3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(713, 584);
            this.Controls.Add(this.treeViewFac3);
            this.Controls.Add(this.buttonInchidere3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFacultate3";
            this.Text = "Facultatea de Electronica, Comunicatii si Calculatoare";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInchidere3;
        private System.Windows.Forms.TreeView treeViewFac3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}