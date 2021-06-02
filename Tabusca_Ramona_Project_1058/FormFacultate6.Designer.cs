
namespace Tabusca_Ramona_Project_1058
{
    partial class FormFacultate6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacultate6));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInchidere6 = new System.Windows.Forms.Button();
            this.treeViewFac6 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facultatea de Teologie, Litere, Istorie și Arte";
            // 
            // buttonInchidere6
            // 
            this.buttonInchidere6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInchidere6.Location = new System.Drawing.Point(512, 322);
            this.buttonInchidere6.Name = "buttonInchidere6";
            this.buttonInchidere6.Size = new System.Drawing.Size(168, 81);
            this.buttonInchidere6.TabIndex = 4;
            this.buttonInchidere6.Text = "ÎNCHIDE";
            this.buttonInchidere6.UseVisualStyleBackColor = true;
            this.buttonInchidere6.Click += new System.EventHandler(this.buttonInchidere6_Click);
            // 
            // treeViewFac6
            // 
            this.treeViewFac6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeViewFac6.Location = new System.Drawing.Point(31, 156);
            this.treeViewFac6.Name = "treeViewFac6";
            this.treeViewFac6.Size = new System.Drawing.Size(443, 410);
            this.treeViewFac6.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tabusca_Ramona_Project_1058.Properties.Resources.FAC6_1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormFacultate6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(713, 584);
            this.Controls.Add(this.treeViewFac6);
            this.Controls.Add(this.buttonInchidere6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFacultate6";
            this.Text = "Facultatea de Teologie, Litere, Istorie și Arte";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewFac6;
        private System.Windows.Forms.Button buttonInchidere6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}