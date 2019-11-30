namespace VPassignment2
{
    partial class ViewAttendance
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
            this.ViewAttendancedataGridView = new System.Windows.Forms.DataGridView();
            this.GotoMenubutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.ViewAttendancebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAttendancedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewAttendancedataGridView
            // 
            this.ViewAttendancedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewAttendancedataGridView.Location = new System.Drawing.Point(24, 103);
            this.ViewAttendancedataGridView.Name = "ViewAttendancedataGridView";
            this.ViewAttendancedataGridView.Size = new System.Drawing.Size(747, 255);
            this.ViewAttendancedataGridView.TabIndex = 29;
            // 
            // GotoMenubutton
            // 
            this.GotoMenubutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GotoMenubutton.Location = new System.Drawing.Point(24, 394);
            this.GotoMenubutton.Name = "GotoMenubutton";
            this.GotoMenubutton.Size = new System.Drawing.Size(149, 32);
            this.GotoMenubutton.TabIndex = 28;
            this.GotoMenubutton.Text = "Main Menu";
            this.GotoMenubutton.UseVisualStyleBackColor = true;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(621, 394);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(150, 32);
            this.Exitbutton.TabIndex = 27;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            // 
            // ViewAttendancebutton
            // 
            this.ViewAttendancebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAttendancebutton.Location = new System.Drawing.Point(290, 36);
            this.ViewAttendancebutton.Name = "ViewAttendancebutton";
            this.ViewAttendancebutton.Size = new System.Drawing.Size(212, 32);
            this.ViewAttendancebutton.TabIndex = 30;
            this.ViewAttendancebutton.Text = "View Attendance";
            this.ViewAttendancebutton.UseVisualStyleBackColor = true;
            this.ViewAttendancebutton.Click += new System.EventHandler(this.ViewAttendancebutton_Click);
            // 
            // ViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewAttendancebutton);
            this.Controls.Add(this.ViewAttendancedataGridView);
            this.Controls.Add(this.GotoMenubutton);
            this.Controls.Add(this.Exitbutton);
            this.Name = "ViewAttendance";
            this.Text = "ViewAttendance";
            this.Load += new System.EventHandler(this.ViewAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewAttendancedataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewAttendancedataGridView;
        private System.Windows.Forms.Button GotoMenubutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button ViewAttendancebutton;
    }
}