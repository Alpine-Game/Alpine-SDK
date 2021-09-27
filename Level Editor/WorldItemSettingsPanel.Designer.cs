﻿using System.ComponentModel;

namespace Level_Editor {
    partial class WorldItemSettingsPanel {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textureBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texture:";
            // 
            // textureBox
            // 
            this.textureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textureBox.Location = new System.Drawing.Point(44, 3);
            this.textureBox.Name = "textureBox";
            this.textureBox.Size = new System.Drawing.Size(229, 20);
            this.textureBox.TabIndex = 1;
            // 
            // WorldItemSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textureBox);
            this.Controls.Add(this.label1);
            this.Name = "WorldItemSettingsPanel";
            this.Size = new System.Drawing.Size(282, 28);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textureBox;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}