using System.ComponentModel;

namespace Level_Editor
{
    partial class AboutEngine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutEngine));
            this.name = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(122, 119);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(122, 18);
            this.name.TabIndex = 0;
            this.name.Text = "Alpine Engine";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(12, 172);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(315, 157);
            this.description.TabIndex = 1;
            this.description.Text = resources.GetString("description.Text");
            this.description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // githubLink
            // 
            this.githubLink.Location = new System.Drawing.Point(122, 137);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(76, 14);
            this.githubLink.TabIndex = 2;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "Link to GitHub";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // AboutEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 338);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.description);
            this.Controls.Add(this.name);
            this.Name = "AboutEngine";
            this.Text = "About";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.LinkLabel githubLink;

        private System.Windows.Forms.Label description;

        private System.Windows.Forms.Label name;

        #endregion
    }
}