using System.ComponentModel;

namespace Level_Editor
{
    partial class SettingsWindow
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
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.resX = new System.Windows.Forms.TextBox();
            this.resY = new System.Windows.Forms.TextBox();
            this.FullscreenLabel = new System.Windows.Forms.Label();
            this.Fullscreen = new System.Windows.Forms.CheckBox();
            this.ProgramNameLabel = new System.Windows.Forms.Label();
            this.WindowText = new System.Windows.Forms.TextBox();
            this.SaveAndExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.Location = new System.Drawing.Point(12, 34);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(228, 25);
            this.ResolutionLabel.TabIndex = 0;
            this.ResolutionLabel.Text = "Default resolution";
            // 
            // resX
            // 
            this.resX.Location = new System.Drawing.Point(255, 31);
            this.resX.Name = "resX";
            this.resX.Size = new System.Drawing.Size(119, 20);
            this.resX.TabIndex = 1;
            this.resX.Text = "Width";
            this.resX.TextChanged += new System.EventHandler(this.resX_TextChanged);
            // 
            // resY
            // 
            this.resY.Location = new System.Drawing.Point(380, 31);
            this.resY.Name = "resY";
            this.resY.Size = new System.Drawing.Size(119, 20);
            this.resY.TabIndex = 2;
            this.resY.Text = "Height";
            this.resY.TextChanged += new System.EventHandler(this.resY_TextChanged);
            // 
            // FullscreenLabel
            // 
            this.FullscreenLabel.Location = new System.Drawing.Point(12, 59);
            this.FullscreenLabel.Name = "FullscreenLabel";
            this.FullscreenLabel.Size = new System.Drawing.Size(228, 25);
            this.FullscreenLabel.TabIndex = 3;
            this.FullscreenLabel.Text = "Fullscreen enabled";
            // 
            // Fullscreen
            // 
            this.Fullscreen.Location = new System.Drawing.Point(255, 53);
            this.Fullscreen.Name = "Fullscreen";
            this.Fullscreen.Size = new System.Drawing.Size(119, 27);
            this.Fullscreen.TabIndex = 4;
            this.Fullscreen.Text = "Enabled/Disabled";
            this.Fullscreen.UseVisualStyleBackColor = true;
            this.Fullscreen.CheckedChanged += new System.EventHandler(this.Fullscreen_CheckedChanged);
            // 
            // ProgramNameLabel
            // 
            this.ProgramNameLabel.Location = new System.Drawing.Point(12, 9);
            this.ProgramNameLabel.Name = "ProgramNameLabel";
            this.ProgramNameLabel.Size = new System.Drawing.Size(228, 25);
            this.ProgramNameLabel.TabIndex = 5;
            this.ProgramNameLabel.Text = "Program Name (also window name)";
            // 
            // WindowText
            // 
            this.WindowText.Location = new System.Drawing.Point(255, 5);
            this.WindowText.Name = "WindowText";
            this.WindowText.Size = new System.Drawing.Size(244, 20);
            this.WindowText.TabIndex = 6;
            this.WindowText.Text = "Made with Alpine Game Engine";
            this.WindowText.TextChanged += new System.EventHandler(this.WindowText_TextChanged);
            // 
            // SaveAndExit
            // 
            this.SaveAndExit.Location = new System.Drawing.Point(11, 242);
            this.SaveAndExit.Name = "SaveAndExit";
            this.SaveAndExit.Size = new System.Drawing.Size(152, 27);
            this.SaveAndExit.TabIndex = 7;
            this.SaveAndExit.Text = "Save and exit";
            this.SaveAndExit.UseVisualStyleBackColor = true;
            this.SaveAndExit.Click += new System.EventHandler(this.SaveAndExit_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 279);
            this.Controls.Add(this.SaveAndExit);
            this.Controls.Add(this.WindowText);
            this.Controls.Add(this.ProgramNameLabel);
            this.Controls.Add(this.Fullscreen);
            this.Controls.Add(this.FullscreenLabel);
            this.Controls.Add(this.resY);
            this.Controls.Add(this.resX);
            this.Controls.Add(this.ResolutionLabel);
            this.Name = "SettingsWindow";
            this.Text = "SettingsWindow";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button SaveAndExit;

        private System.Windows.Forms.Label ProgramNameLabel;
        private System.Windows.Forms.TextBox WindowText;

        private System.Windows.Forms.Label FullscreenLabel;
        private System.Windows.Forms.CheckBox Fullscreen;

        private System.Windows.Forms.TextBox resX;
        private System.Windows.Forms.TextBox resY;

        private System.Windows.Forms.Label ResolutionLabel;

        #endregion
    }
}