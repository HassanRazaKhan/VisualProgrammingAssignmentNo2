namespace VPassignment2
{
    partial class DeleteStudent
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
            this.DeletetextBox = new System.Windows.Forms.TextBox();
            this.GotoMenubutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // DeletetextBox
            // 
            this.DeletetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletetextBox.Location = new System.Drawing.Point(347, 168);
            this.DeletetextBox.Name = "DeletetextBox";
            this.DeletetextBox.Size = new System.Drawing.Size(224, 29);
            this.DeletetextBox.TabIndex = 1;
            // 
            // GotoMenubutton
            // 
            this.GotoMenubutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GotoMenubutton.Location = new System.Drawing.Point(58, 392);
            this.GotoMenubutton.Name = "GotoMenubutton";
            this.GotoMenubutton.Size = new System.Drawing.Size(149, 32);
            this.GotoMenubutton.TabIndex = 15;
            this.GotoMenubutton.Text = "Main Menu";
            this.GotoMenubutton.UseVisualStyleBackColor = true;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(582, 392);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(150, 32);
            this.Exitbutton.TabIndex = 14;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            // 
            // Deletebutton
            // 
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Location = new System.Drawing.Point(322, 392);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(150, 32);
            this.Deletebutton.TabIndex = 16;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.GotoMenubutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.DeletetextBox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteStudent";
            this.Text = "DeleteStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeletetextBox;
        private System.Windows.Forms.Button GotoMenubutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Deletebutton;
    }
}