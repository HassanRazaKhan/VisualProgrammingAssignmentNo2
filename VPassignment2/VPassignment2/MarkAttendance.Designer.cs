namespace VPassignment2
{
    partial class MarkAttendance
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
            this.MarkAttendancedataGridView = new System.Windows.Forms.DataGridView();
            this.GotoMenubutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.AbsenrradioButton = new System.Windows.Forms.RadioButton();
            this.PresentradioButton = new System.Windows.Forms.RadioButton();
            this.attendaneIdtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.attendaneNametextBoxtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MarkAttendancedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MarkAttendancedataGridView
            // 
            this.MarkAttendancedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarkAttendancedataGridView.Location = new System.Drawing.Point(28, 191);
            this.MarkAttendancedataGridView.Name = "MarkAttendancedataGridView";
            this.MarkAttendancedataGridView.Size = new System.Drawing.Size(747, 164);
            this.MarkAttendancedataGridView.TabIndex = 26;
            // 
            // GotoMenubutton
            // 
            this.GotoMenubutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GotoMenubutton.Location = new System.Drawing.Point(60, 381);
            this.GotoMenubutton.Name = "GotoMenubutton";
            this.GotoMenubutton.Size = new System.Drawing.Size(149, 32);
            this.GotoMenubutton.TabIndex = 24;
            this.GotoMenubutton.Text = "Main Menu";
            this.GotoMenubutton.UseVisualStyleBackColor = true;
            this.GotoMenubutton.Click += new System.EventHandler(this.GotoMenubutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(597, 381);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(150, 32);
            this.Exitbutton.TabIndex = 23;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // AbsenrradioButton
            // 
            this.AbsenrradioButton.AutoSize = true;
            this.AbsenrradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsenrradioButton.Location = new System.Drawing.Point(441, 141);
            this.AbsenrradioButton.Name = "AbsenrradioButton";
            this.AbsenrradioButton.Size = new System.Drawing.Size(93, 28);
            this.AbsenrradioButton.TabIndex = 21;
            this.AbsenrradioButton.TabStop = true;
            this.AbsenrradioButton.Text = "Absent";
            this.AbsenrradioButton.UseVisualStyleBackColor = true;
            this.AbsenrradioButton.CheckedChanged += new System.EventHandler(this.AbsenrradioButton_CheckedChanged);
            // 
            // PresentradioButton
            // 
            this.PresentradioButton.AutoSize = true;
            this.PresentradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresentradioButton.Location = new System.Drawing.Point(295, 141);
            this.PresentradioButton.Name = "PresentradioButton";
            this.PresentradioButton.Size = new System.Drawing.Size(99, 28);
            this.PresentradioButton.TabIndex = 20;
            this.PresentradioButton.TabStop = true;
            this.PresentradioButton.Text = "Present";
            this.PresentradioButton.UseVisualStyleBackColor = true;
            this.PresentradioButton.CheckedChanged += new System.EventHandler(this.PresentradioButton_CheckedChanged);
            // 
            // attendaneIdtextBox
            // 
            this.attendaneIdtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendaneIdtextBox.Location = new System.Drawing.Point(295, 40);
            this.attendaneIdtextBox.Name = "attendaneIdtextBox";
            this.attendaneIdtextBox.Size = new System.Drawing.Size(239, 29);
            this.attendaneIdtextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID ";
            // 
            // attendaneNametextBoxtextBox
            // 
            this.attendaneNametextBoxtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendaneNametextBoxtextBox.Location = new System.Drawing.Point(295, 85);
            this.attendaneNametextBoxtextBox.Name = "attendaneNametextBoxtextBox";
            this.attendaneNametextBoxtextBox.Size = new System.Drawing.Size(239, 29);
            this.attendaneNametextBoxtextBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Name";
            // 
            // MarkAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.attendaneNametextBoxtextBox);
            this.Controls.Add(this.MarkAttendancedataGridView);
            this.Controls.Add(this.GotoMenubutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.AbsenrradioButton);
            this.Controls.Add(this.PresentradioButton);
            this.Controls.Add(this.attendaneIdtextBox);
            this.Controls.Add(this.label1);
            this.Name = "MarkAttendance";
            this.Text = "MarkAttendance";
            this.Load += new System.EventHandler(this.MarkAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MarkAttendancedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MarkAttendancedataGridView;
        private System.Windows.Forms.Button GotoMenubutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.RadioButton AbsenrradioButton;
        private System.Windows.Forms.RadioButton PresentradioButton;
        private System.Windows.Forms.TextBox attendaneIdtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox attendaneNametextBoxtextBox;
        private System.Windows.Forms.Label label2;
    }
}