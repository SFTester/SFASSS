namespace SFASS
{
    partial class formStudy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbStudyNotReady = new System.Windows.Forms.RadioButton();
            this.rbMath = new System.Windows.Forms.RadioButton();
            this.tbcLessons = new System.Windows.Forms.TabControl();
            this.tabLessonsList = new System.Windows.Forms.TabPage();
            this.tabLessonCheck = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tbcLessons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbStudyNotReady);
            this.groupBox1.Controls.Add(this.rbMath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Что Вы хотите изучать?";
            // 
            // rbStudyNotReady
            // 
            this.rbStudyNotReady.AutoSize = true;
            this.rbStudyNotReady.Checked = true;
            this.rbStudyNotReady.Location = new System.Drawing.Point(6, 127);
            this.rbStudyNotReady.Name = "rbStudyNotReady";
            this.rbStudyNotReady.Size = new System.Drawing.Size(117, 17);
            this.rbStudyNotReady.TabIndex = 1;
            this.rbStudyNotReady.TabStop = true;
            this.rbStudyNotReady.Text = "Не определился...";
            this.rbStudyNotReady.UseVisualStyleBackColor = true;
            this.rbStudyNotReady.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbMath
            // 
            this.rbMath.AutoSize = true;
            this.rbMath.Location = new System.Drawing.Point(7, 20);
            this.rbMath.Name = "rbMath";
            this.rbMath.Size = new System.Drawing.Size(88, 17);
            this.rbMath.TabIndex = 0;
            this.rbMath.Text = "Математика";
            this.rbMath.UseVisualStyleBackColor = true;
            this.rbMath.CheckedChanged += new System.EventHandler(this.rbMath_CheckedChanged);
            // 
            // tbcLessons
            // 
            this.tbcLessons.Controls.Add(this.tabLessonsList);
            this.tbcLessons.Controls.Add(this.tabLessonCheck);
            this.tbcLessons.Location = new System.Drawing.Point(198, 12);
            this.tbcLessons.Name = "tbcLessons";
            this.tbcLessons.SelectedIndex = 0;
            this.tbcLessons.Size = new System.Drawing.Size(400, 400);
            this.tbcLessons.TabIndex = 2;
            this.tbcLessons.Visible = false;
            // 
            // tabLessonsList
            // 
            this.tabLessonsList.Location = new System.Drawing.Point(4, 22);
            this.tabLessonsList.Name = "tabLessonsList";
            this.tabLessonsList.Padding = new System.Windows.Forms.Padding(3);
            this.tabLessonsList.Size = new System.Drawing.Size(392, 374);
            this.tabLessonsList.TabIndex = 0;
            this.tabLessonsList.Text = "Занятия";
            this.tabLessonsList.UseVisualStyleBackColor = true;
            // 
            // tabLessonCheck
            // 
            this.tabLessonCheck.Location = new System.Drawing.Point(4, 22);
            this.tabLessonCheck.Name = "tabLessonCheck";
            this.tabLessonCheck.Padding = new System.Windows.Forms.Padding(3);
            this.tabLessonCheck.Size = new System.Drawing.Size(428, 391);
            this.tabLessonCheck.TabIndex = 1;
            this.tabLessonCheck.Text = "Ответы";
            this.tabLessonCheck.UseVisualStyleBackColor = true;
            // 
            // formStudy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::SFASS.Properties.Resources._0001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(620, 437);
            this.Controls.Add(this.tbcLessons);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formStudy";
            this.ShowIcon = false;
            this.Text = "Самообучение";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbcLessons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbStudyNotReady;
        private System.Windows.Forms.RadioButton rbMath;
        private System.Windows.Forms.TabControl tbcLessons;
        private System.Windows.Forms.TabPage tabLessonsList;
        private System.Windows.Forms.TabPage tabLessonCheck;
    }
}