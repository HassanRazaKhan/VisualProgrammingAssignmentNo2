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
            this.GotoMenubutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.DeletedataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DeletedataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.GotoMenubutton.Click += new System.EventHandler(this.GotoMenubutton_Click);
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
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
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
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // DeletedataGridView
            // 
            this.DeletedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeletedataGridView.Location = new System.Drawing.Point(58, 84);
            this.DeletedataGridView.Name = "DeletedataGridView";
            this.DeletedataGridView.Size = new System.Drawing.Size(674, 150);
            this.DeletedataGridView.TabIndex = 17;
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeletedataGridView);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.GotoMenubutton);
            this.Controls.Add(this.Exitbutton);
            this.Name = "DeleteStudent";
            this.Text = "DeleteStudent";
            this.Load += new System.EventHandler(this.DeleteStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeletedataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button GotoMenubutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.DataGridView DeletedataGridView;
    }
}