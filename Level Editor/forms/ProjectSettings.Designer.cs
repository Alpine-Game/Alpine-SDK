using System.ComponentModel;

namespace Level_Editor
{
    partial class ProjectSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.projNameLabel = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.TextBox();
            this.fpsLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.windowNameLabel = new System.Windows.Forms.Label();
            this.windowName = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projNameLabel
            // 
            this.projNameLabel.Location = new System.Drawing.Point(8, 10);
            this.projNameLabel.Name = "projNameLabel";
            this.projNameLabel.Size = new System.Drawing.Size(221, 28);
            this.projNameLabel.TabIndex = 0;
            this.projNameLabel.Text = "Project Name";
            // 
            // projectName
            // 
            this.projectName.Location = new System.Drawing.Point(238, 7);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(224, 20);
            this.projectName.TabIndex = 1;
            this.projectName.Text = "ERROR";
            // 
            // fpsLabel
            // 
            this.fpsLabel.Location = new System.Drawing.Point(8, 38);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(221, 28);
            this.fpsLabel.TabIndex = 2;
            this.fpsLabel.Text = "Frames Per Second";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "ERROR";
            // 
            // windowNameLabel
            // 
            this.windowNameLabel.Location = new System.Drawing.Point(8, 66);
            this.windowNameLabel.Name = "windowNameLabel";
            this.windowNameLabel.Size = new System.Drawing.Size(221, 28);
            this.windowNameLabel.TabIndex = 4;
            this.windowNameLabel.Text = "Window Name";
            // 
            // windowName
            // 
            this.windowName.Location = new System.Drawing.Point(239, 66);
            this.windowName.Name = "windowName";
            this.windowName.Size = new System.Drawing.Size(224, 20);
            this.windowName.TabIndex = 5;
            this.windowName.Text = "ERROR";
            // 
            // save
            // 
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(12, 467);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(175, 32);
            this.save.TabIndex = 6;
            this.save.Text = "Save and Exit";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Location = new System.Drawing.Point(288, 467);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(175, 32);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel (won\'t save)";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ProjectSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 511);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.windowName);
            this.Controls.Add(this.windowNameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fpsLabel);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.projNameLabel);
            this.Name = "ProjectSettings";
            this.Text = "Project Settings";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button cancel;

        private System.Windows.Forms.Button save;

        private System.Windows.Forms.Label projNameLabel;
        private System.Windows.Forms.TextBox projectName;
        private System.Windows.Forms.Label fpsLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label windowNameLabel;
        private System.Windows.Forms.TextBox windowName;

        #endregion
    }
}