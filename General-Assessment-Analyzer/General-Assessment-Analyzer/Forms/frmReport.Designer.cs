﻿namespace General_Assessment_Analyzer.Forms
{
    partial class frmReport
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCombine = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_StudentData = new System.Windows.Forms.Label();
            this.lb_CourseData = new System.Windows.Forms.Label();
            this.lb_AssessmentData = new System.Windows.Forms.Label();
            this.btn_LoadStudentFile = new System.Windows.Forms.Button();
            this.btn_LoadCourseFile = new System.Windows.Forms.Button();
            this.btn_LoadAssessmentFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_FilterSubjects = new System.Windows.Forms.Button();
            this.clb_Subjects = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_FilterAssessments = new System.Windows.Forms.Button();
            this.clb_AssessmentTypes = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tvCourses = new System.Windows.Forms.TreeView();
            this.btn_AddSelectedCourses = new System.Windows.Forms.Button();
            this.btn_SelectAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCombine);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lb_StudentData);
            this.groupBox1.Controls.Add(this.lb_CourseData);
            this.groupBox1.Controls.Add(this.lb_AssessmentData);
            this.groupBox1.Controls.Add(this.btn_LoadStudentFile);
            this.groupBox1.Controls.Add(this.btn_LoadCourseFile);
            this.groupBox1.Controls.Add(this.btn_LoadAssessmentFile);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load Data";
            // 
            // btnCombine
            // 
            this.btnCombine.Location = new System.Drawing.Point(7, 141);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(211, 23);
            this.btnCombine.TabIndex = 7;
            this.btnCombine.Text = "Combine Dataset";
            this.btnCombine.UseVisualStyleBackColor = true;
            this.btnCombine.Click += new System.EventHandler(this.btnCombine_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Assessment Catalog Loaded from Computer";
            // 
            // lb_StudentData
            // 
            this.lb_StudentData.AutoSize = true;
            this.lb_StudentData.Location = new System.Drawing.Point(149, 83);
            this.lb_StudentData.Name = "lb_StudentData";
            this.lb_StudentData.Size = new System.Drawing.Size(33, 13);
            this.lb_StudentData.TabIndex = 5;
            this.lb_StudentData.Text = "Done";
            // 
            // lb_CourseData
            // 
            this.lb_CourseData.AutoSize = true;
            this.lb_CourseData.Location = new System.Drawing.Point(149, 54);
            this.lb_CourseData.Name = "lb_CourseData";
            this.lb_CourseData.Size = new System.Drawing.Size(33, 13);
            this.lb_CourseData.TabIndex = 4;
            this.lb_CourseData.Text = "Done";
            // 
            // lb_AssessmentData
            // 
            this.lb_AssessmentData.AutoSize = true;
            this.lb_AssessmentData.Location = new System.Drawing.Point(149, 25);
            this.lb_AssessmentData.Name = "lb_AssessmentData";
            this.lb_AssessmentData.Size = new System.Drawing.Size(33, 13);
            this.lb_AssessmentData.TabIndex = 3;
            this.lb_AssessmentData.Text = "Done";
            // 
            // btn_LoadStudentFile
            // 
            this.btn_LoadStudentFile.Location = new System.Drawing.Point(7, 78);
            this.btn_LoadStudentFile.Name = "btn_LoadStudentFile";
            this.btn_LoadStudentFile.Size = new System.Drawing.Size(136, 23);
            this.btn_LoadStudentFile.TabIndex = 2;
            this.btn_LoadStudentFile.Text = "Load Student Data";
            this.btn_LoadStudentFile.UseVisualStyleBackColor = true;
            this.btn_LoadStudentFile.Click += new System.EventHandler(this.btn_LoadStudentFile_Click);
            // 
            // btn_LoadCourseFile
            // 
            this.btn_LoadCourseFile.Location = new System.Drawing.Point(7, 49);
            this.btn_LoadCourseFile.Name = "btn_LoadCourseFile";
            this.btn_LoadCourseFile.Size = new System.Drawing.Size(136, 23);
            this.btn_LoadCourseFile.TabIndex = 1;
            this.btn_LoadCourseFile.Text = "Load Course Data";
            this.btn_LoadCourseFile.UseVisualStyleBackColor = true;
            this.btn_LoadCourseFile.Click += new System.EventHandler(this.btn_LoadCourseFile_Click);
            // 
            // btn_LoadAssessmentFile
            // 
            this.btn_LoadAssessmentFile.Location = new System.Drawing.Point(7, 20);
            this.btn_LoadAssessmentFile.Name = "btn_LoadAssessmentFile";
            this.btn_LoadAssessmentFile.Size = new System.Drawing.Size(136, 23);
            this.btn_LoadAssessmentFile.TabIndex = 0;
            this.btn_LoadAssessmentFile.Text = "Load Assessment Data";
            this.btn_LoadAssessmentFile.UseVisualStyleBackColor = true;
            this.btn_LoadAssessmentFile.Click += new System.EventHandler(this.btn_LoadAssessmentFile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_FilterSubjects);
            this.groupBox2.Controls.Add(this.clb_Subjects);
            this.groupBox2.Location = new System.Drawing.Point(13, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter - Step 1 - Subjects";
            // 
            // btn_FilterSubjects
            // 
            this.btn_FilterSubjects.Location = new System.Drawing.Point(128, 20);
            this.btn_FilterSubjects.Name = "btn_FilterSubjects";
            this.btn_FilterSubjects.Size = new System.Drawing.Size(111, 23);
            this.btn_FilterSubjects.TabIndex = 1;
            this.btn_FilterSubjects.Text = "Filter Subjects";
            this.btn_FilterSubjects.UseVisualStyleBackColor = true;
            this.btn_FilterSubjects.Click += new System.EventHandler(this.btn_FilterSubjects_Click);
            // 
            // clb_Subjects
            // 
            this.clb_Subjects.FormattingEnabled = true;
            this.clb_Subjects.Location = new System.Drawing.Point(7, 20);
            this.clb_Subjects.Name = "clb_Subjects";
            this.clb_Subjects.Size = new System.Drawing.Size(114, 124);
            this.clb_Subjects.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_FilterAssessments);
            this.groupBox3.Controls.Add(this.clb_AssessmentTypes);
            this.groupBox3.Location = new System.Drawing.Point(13, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 163);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter - Step 2 - Select Assessment Type";
            // 
            // btn_FilterAssessments
            // 
            this.btn_FilterAssessments.Location = new System.Drawing.Point(130, 19);
            this.btn_FilterAssessments.Name = "btn_FilterAssessments";
            this.btn_FilterAssessments.Size = new System.Drawing.Size(109, 23);
            this.btn_FilterAssessments.TabIndex = 3;
            this.btn_FilterAssessments.Text = "Filter Assessments";
            this.btn_FilterAssessments.UseVisualStyleBackColor = true;
            this.btn_FilterAssessments.Click += new System.EventHandler(this.btn_FilterAssessments_Click);
            // 
            // clb_AssessmentTypes
            // 
            this.clb_AssessmentTypes.FormattingEnabled = true;
            this.clb_AssessmentTypes.Location = new System.Drawing.Point(9, 19);
            this.clb_AssessmentTypes.Name = "clb_AssessmentTypes";
            this.clb_AssessmentTypes.Size = new System.Drawing.Size(114, 124);
            this.clb_AssessmentTypes.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tvCourses);
            this.groupBox4.Controls.Add(this.btn_AddSelectedCourses);
            this.groupBox4.Controls.Add(this.btn_SelectAll);
            this.groupBox4.Location = new System.Drawing.Point(264, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(413, 214);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Courses";
            // 
            // tvCourses
            // 
            this.tvCourses.CheckBoxes = true;
            this.tvCourses.Location = new System.Drawing.Point(7, 20);
            this.tvCourses.Name = "tvCourses";
            this.tvCourses.Size = new System.Drawing.Size(400, 159);
            this.tvCourses.TabIndex = 3;
            this.tvCourses.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvCourses_AfterCheck);
            this.tvCourses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tvCourses_MouseClick);
            // 
            // btn_AddSelectedCourses
            // 
            this.btn_AddSelectedCourses.Location = new System.Drawing.Point(94, 185);
            this.btn_AddSelectedCourses.Name = "btn_AddSelectedCourses";
            this.btn_AddSelectedCourses.Size = new System.Drawing.Size(81, 23);
            this.btn_AddSelectedCourses.TabIndex = 2;
            this.btn_AddSelectedCourses.Text = "Add Selected";
            this.btn_AddSelectedCourses.UseVisualStyleBackColor = true;
            this.btn_AddSelectedCourses.Click += new System.EventHandler(this.btn_AddSelectedCourses_Click);
            // 
            // btn_SelectAll
            // 
            this.btn_SelectAll.Location = new System.Drawing.Point(7, 185);
            this.btn_SelectAll.Name = "btn_SelectAll";
            this.btn_SelectAll.Size = new System.Drawing.Size(81, 23);
            this.btn_SelectAll.TabIndex = 1;
            this.btn_SelectAll.Text = "Select All";
            this.btn_SelectAll.UseVisualStyleBackColor = true;
            this.btn_SelectAll.Click += new System.EventHandler(this.btn_SelectAll_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 603);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReport";
            this.Text = "Produce Assessment Reports";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_StudentData;
        private System.Windows.Forms.Label lb_CourseData;
        private System.Windows.Forms.Label lb_AssessmentData;
        private System.Windows.Forms.Button btn_LoadStudentFile;
        private System.Windows.Forms.Button btn_LoadCourseFile;
        private System.Windows.Forms.Button btn_LoadAssessmentFile;
        private System.Windows.Forms.Button btnCombine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_FilterSubjects;
        private System.Windows.Forms.CheckedListBox clb_Subjects;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_FilterAssessments;
        private System.Windows.Forms.CheckedListBox clb_AssessmentTypes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_AddSelectedCourses;
        private System.Windows.Forms.Button btn_SelectAll;
        private System.Windows.Forms.TreeView tvCourses;
    }
}