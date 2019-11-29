namespace VPassignment2
{
    partial class SearchStudent
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
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.SearchByIDradioButton = new System.Windows.Forms.RadioButton();
            this.SearchByNameradioButton = new System.Windows.Forms.RadioButton();
            this.AllStudentsradioButton = new System.Windows.Forms.RadioButton();
            this.GotoMenubutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.SearchdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SearchdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID / Name";
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchtextBox.Location = new System.Drawing.Point(296, 65);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(239, 29);
            this.SearchtextBox.TabIndex = 1;
            // 
            // SearchByIDradioButton
            // 
            this.SearchByIDradioButton.AutoSize = true;
            this.SearchByIDradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByIDradioButton.Location = new System.Drawing.Point(61, 145);
            this.SearchByIDradioButton.Name = "SearchByIDradioButton";
            this.SearchByIDradioButton.Size = new System.Drawing.Size(148, 28);
            this.SearchByIDradioButton.TabIndex = 2;
            this.SearchByIDradioButton.TabStop = true;
            this.SearchByIDradioButton.Text = "Search By ID";
            this.SearchByIDradioButton.UseVisualStyleBackColor = true;
            // 
            // SearchByNameradioButton
            // 
            this.SearchByNameradioButton.AutoSize = true;
            this.SearchByNameradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByNameradioButton.Location = new System.Drawing.Point(296, 145);
            this.SearchByNameradioButton.Name = "SearchByNameradioButton";
            this.SearchByNameradioButton.Size = new System.Drawing.Size(184, 28);
            this.SearchByNameradioButton.TabIndex = 3;
            this.SearchByNameradioButton.TabStop = true;
            this.SearchByNameradioButton.Text = "Search By Name";
            this.SearchByNameradioButton.UseVisualStyleBackColor = true;
            // 
            // AllStudentsradioButton
            // 
            this.AllStudentsradioButton.AutoSize = true;
            this.AllStudentsradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllStudentsradioButton.Location = new System.Drawing.Point(551, 145);
            this.AllStudentsradioButton.Name = "AllStudentsradioButton";
            this.AllStudentsradioButton.Size = new System.Drawing.Size(197, 28);
            this.AllStudentsradioButton.TabIndex = 5;
            this.AllStudentsradioButton.TabStop = true;
            this.AllStudentsradioButton.Text = "Show All Students";
            this.AllStudentsradioButton.UseVisualStyleBackColor = true;
            this.AllStudentsradioButton.CheckedChanged += new System.EventHandler(this.AllStudentsradioButton_CheckedChanged);
            // 
            // GotoMenubutton
            // 
            this.GotoMenubutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GotoMenubutton.Location = new System.Drawing.Point(61, 406);
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
            this.Exitbutton.Location = new System.Drawing.Point(598, 406);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(150, 32);
            this.Exitbutton.TabIndex = 14;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Searchbutton
            // 
            this.Searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbutton.Location = new System.Drawing.Point(572, 68);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(115, 32);
            this.Searchbutton.TabIndex = 16;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // SearchdataGridView
            // 
            this.SearchdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchdataGridView.Location = new System.Drawing.Point(92, 211);
            this.SearchdataGridView.Name = "SearchdataGridView";
            this.SearchdataGridView.Size = new System.Drawing.Size(647, 164);
            this.SearchdataGridView.TabIndex = 17;
            // 
            // SearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchdataGridView);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.GotoMenubutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.AllStudentsradioButton);
            this.Controls.Add(this.SearchByNameradioButton);
            this.Controls.Add(this.SearchByIDradioButton);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.label1);
            this.Name = "SearchStudent";
            this.Text = "SearchStudent";
            this.Load += new System.EventHandler(this.SearchStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.RadioButton SearchByIDradioButton;
        private System.Windows.Forms.RadioButton SearchByNameradioButton;
        private System.Windows.Forms.RadioButton AllStudentsradioButton;
        private System.Windows.Forms.Button GotoMenubutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.DataGridView SearchdataGridView;
    }
}