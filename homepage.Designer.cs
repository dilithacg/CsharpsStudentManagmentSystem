namespace studentManagementSystem
{
    partial class homepage
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
            this.homePageManageStudent = new System.Windows.Forms.Button();
            this.homePageManageCourses = new System.Windows.Forms.Button();
            this.homePagePayments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // homePageManageStudent
            // 
            this.homePageManageStudent.Location = new System.Drawing.Point(43, 58);
            this.homePageManageStudent.Name = "homePageManageStudent";
            this.homePageManageStudent.Size = new System.Drawing.Size(160, 89);
            this.homePageManageStudent.TabIndex = 0;
            this.homePageManageStudent.Text = "Manage Students";
            this.homePageManageStudent.UseVisualStyleBackColor = true;
            this.homePageManageStudent.Click += new System.EventHandler(this.homePageManageStudent_Click);
            // 
            // homePageManageCourses
            // 
            this.homePageManageCourses.Location = new System.Drawing.Point(236, 58);
            this.homePageManageCourses.Name = "homePageManageCourses";
            this.homePageManageCourses.Size = new System.Drawing.Size(160, 89);
            this.homePageManageCourses.TabIndex = 1;
            this.homePageManageCourses.Text = "Add Courses";
            this.homePageManageCourses.UseVisualStyleBackColor = true;
            this.homePageManageCourses.Click += new System.EventHandler(this.homePageManageCourses_Click);
            // 
            // homePagePayments
            // 
            this.homePagePayments.Location = new System.Drawing.Point(138, 167);
            this.homePagePayments.Name = "homePagePayments";
            this.homePagePayments.Size = new System.Drawing.Size(160, 89);
            this.homePagePayments.TabIndex = 2;
            this.homePagePayments.Text = "Payments";
            this.homePagePayments.UseVisualStyleBackColor = true;
            this.homePagePayments.Click += new System.EventHandler(this.homePagePayments_Click);
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 309);
            this.Controls.Add(this.homePagePayments);
            this.Controls.Add(this.homePageManageCourses);
            this.Controls.Add(this.homePageManageStudent);
            this.Name = "homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.homepage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button homePageManageStudent;
        private Button homePageManageCourses;
        private Button homePagePayments;
    }
}