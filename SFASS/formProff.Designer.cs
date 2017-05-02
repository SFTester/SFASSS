namespace SFASS
{
    partial class formProff
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
            this.gbProf = new System.Windows.Forms.GroupBox();
            this.rbProfNotReady = new System.Windows.Forms.RadioButton();
            this.rbProfCalculator = new System.Windows.Forms.RadioButton();
            this.rbProfHow = new System.Windows.Forms.RadioButton();
            this.rbProfWhy = new System.Windows.Forms.RadioButton();
            this.tbcProf = new System.Windows.Forms.TabControl();
            this.tabProfTasks = new System.Windows.Forms.TabPage();
            this.tabProfResults = new System.Windows.Forms.TabPage();
            this.gbProf.SuspendLayout();
            this.tbcProf.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProf
            // 
            this.gbProf.Controls.Add(this.rbProfNotReady);
            this.gbProf.Controls.Add(this.rbProfCalculator);
            this.gbProf.Controls.Add(this.rbProfHow);
            this.gbProf.Controls.Add(this.rbProfWhy);
            this.gbProf.Location = new System.Drawing.Point(12, 12);
            this.gbProf.Name = "gbProf";
            this.gbProf.Size = new System.Drawing.Size(180, 150);
            this.gbProf.TabIndex = 0;
            this.gbProf.TabStop = false;
            this.gbProf.Text = "Что Вы хотите знать?";
            // 
            // rbProfNotReady
            // 
            this.rbProfNotReady.AutoSize = true;
            this.rbProfNotReady.Checked = true;
            this.rbProfNotReady.Location = new System.Drawing.Point(6, 127);
            this.rbProfNotReady.Name = "rbProfNotReady";
            this.rbProfNotReady.Size = new System.Drawing.Size(117, 17);
            this.rbProfNotReady.TabIndex = 3;
            this.rbProfNotReady.TabStop = true;
            this.rbProfNotReady.Text = "Не определился...";
            this.rbProfNotReady.UseVisualStyleBackColor = true;
            this.rbProfNotReady.CheckedChanged += new System.EventHandler(this.rbProfNotReady_CheckedChanged);
            // 
            // rbProfCalculator
            // 
            this.rbProfCalculator.AutoSize = true;
            this.rbProfCalculator.Location = new System.Drawing.Point(7, 68);
            this.rbProfCalculator.Name = "rbProfCalculator";
            this.rbProfCalculator.Size = new System.Drawing.Size(161, 17);
            this.rbProfCalculator.TabIndex = 2;
            this.rbProfCalculator.Text = "Калькулятор Вашей жизни";
            this.rbProfCalculator.UseVisualStyleBackColor = true;
            // 
            // rbProfHow
            // 
            this.rbProfHow.AutoSize = true;
            this.rbProfHow.Location = new System.Drawing.Point(7, 44);
            this.rbProfHow.Name = "rbProfHow";
            this.rbProfHow.Size = new System.Drawing.Size(163, 17);
            this.rbProfHow.TabIndex = 1;
            this.rbProfHow.Text = "Как выбирать профессию?";
            this.rbProfHow.UseVisualStyleBackColor = true;
            // 
            // rbProfWhy
            // 
            this.rbProfWhy.AutoSize = true;
            this.rbProfWhy.Location = new System.Drawing.Point(7, 20);
            this.rbProfWhy.Name = "rbProfWhy";
            this.rbProfWhy.Size = new System.Drawing.Size(145, 17);
            this.rbProfWhy.TabIndex = 0;
            this.rbProfWhy.Text = "Зачем мне профессия?";
            this.rbProfWhy.UseVisualStyleBackColor = true;
            // 
            // tbcProf
            // 
            this.tbcProf.Controls.Add(this.tabProfTasks);
            this.tbcProf.Controls.Add(this.tabProfResults);
            this.tbcProf.Location = new System.Drawing.Point(198, 12);
            this.tbcProf.Name = "tbcProf";
            this.tbcProf.SelectedIndex = 0;
            this.tbcProf.Size = new System.Drawing.Size(400, 400);
            this.tbcProf.TabIndex = 1;
            this.tbcProf.Visible = false;
            // 
            // tabProfTasks
            // 
            this.tabProfTasks.Location = new System.Drawing.Point(4, 22);
            this.tabProfTasks.Name = "tabProfTasks";
            this.tabProfTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfTasks.Size = new System.Drawing.Size(392, 374);
            this.tabProfTasks.TabIndex = 0;
            this.tabProfTasks.Text = "Задания";
            this.tabProfTasks.UseVisualStyleBackColor = true;
            // 
            // tabProfResults
            // 
            this.tabProfResults.Location = new System.Drawing.Point(4, 22);
            this.tabProfResults.Name = "tabProfResults";
            this.tabProfResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfResults.Size = new System.Drawing.Size(392, 374);
            this.tabProfResults.TabIndex = 1;
            this.tabProfResults.Text = "Результаты";
            this.tabProfResults.UseVisualStyleBackColor = true;
            // 
            // formProff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::SFASS.Properties.Resources.proff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tbcProf);
            this.Controls.Add(this.gbProf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formProff";
            this.ShowIcon = false;
            this.Text = "Выбор профессии";
            this.Load += new System.EventHandler(this.formProff_Load);
            this.gbProf.ResumeLayout(false);
            this.gbProf.PerformLayout();
            this.tbcProf.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProf;
        private System.Windows.Forms.RadioButton rbProfNotReady;
        private System.Windows.Forms.RadioButton rbProfCalculator;
        private System.Windows.Forms.RadioButton rbProfHow;
        private System.Windows.Forms.RadioButton rbProfWhy;
        private System.Windows.Forms.TabControl tbcProf;
        private System.Windows.Forms.TabPage tabProfTasks;
        private System.Windows.Forms.TabPage tabProfResults;
    }
}