
namespace Tabusca_Ramona_Project_1058
{
    partial class FormFacultate2
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInchidere2 = new System.Windows.Forms.Button();
            this.treeViewFac2 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facultatea de Mecanica si Tehnologie";
            // 
            // buttonInchidere2
            // 
            this.buttonInchidere2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInchidere2.Location = new System.Drawing.Point(512, 322);
            this.buttonInchidere2.Name = "buttonInchidere2";
            this.buttonInchidere2.Size = new System.Drawing.Size(168, 81);
            this.buttonInchidere2.TabIndex = 4;
            this.buttonInchidere2.Text = "ÎNCHIDE";
            this.buttonInchidere2.UseVisualStyleBackColor = true;
            this.buttonInchidere2.Click += new System.EventHandler(this.buttonInchidere2_Click);
            // 
            // treeViewFac2
            // 
            this.treeViewFac2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeViewFac2.Location = new System.Drawing.Point(31, 156);
            this.treeViewFac2.Name = "treeViewFac2";
            this.treeViewFac2.Size = new System.Drawing.Size(443, 410);
            this.treeViewFac2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tabusca_Ramona_Project_1058.Properties.Resources.fac2png;
            this.pictureBox1.Location = new System.Drawing.Point(45, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormFacultate2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(713, 584);
            this.Controls.Add(this.treeViewFac2);
            this.Controls.Add(this.buttonInchidere2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormFacultate2";
            this.Text = "Facultatea de Mecanica si Tehnologie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInchidere2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewFac2;
    }
}