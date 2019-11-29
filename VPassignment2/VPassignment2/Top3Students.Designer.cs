namespace VPassignment2
{
    partial class Top3Students
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
            this.TopStudentsbutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // GotoMenubutton
            // 
            this.GotoMenubutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GotoMenubutton.Location = new System.Drawing.Point(67, 393);
            this.GotoMenubutton.Name = "GotoMenubutton";
            this.GotoMenubutton.Size = new System.Drawing.Size(149, 32);
            this.GotoMenubutton.TabIndex = 17;
            this.GotoMenubutton.Text = "Main Menu";
            this.GotoMenubutton.UseVisualStyleBackColor = true;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(591, 393);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(150, 32);
            this.Exitbutton.TabIndex = 16;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            // 
            // TopStudentsbutton
            // 
            this.TopStudentsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopStudentsbutton.Location = new System.Drawing.Point(238, 77);
            this.TopStudentsbutton.Name = "TopStudentsbutton";
            this.TopStudentsbutton.Size = new System.Drawing.Size(326, 84);
            this.TopStudentsbutton.TabIndex = 18;
            this.TopStudentsbutton.Text = "Top 3 Students";
            this.TopStudentsbutton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(217, 184);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(372, 160);
            this.listBox1.TabIndex = 19;
            // 
            // Top3Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TopStudentsbutton);
            this.Controls.Add(this.GotoMenubutton);
            this.Controls.Add(this.Exitbutton);
            this.Name = "Top3Students";
            this.Text = "Top3Students";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GotoMenubutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button TopStudentsbutton;
        private System.Windows.Forms.ListBox listBox1;
    }
}