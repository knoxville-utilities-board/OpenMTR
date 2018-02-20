namespace OpenMTRDemo.Forms
{
    partial class ExpandedImageForm
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
            this.pictureBoxExpanded = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpanded)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxExpanded
            // 
            this.pictureBoxExpanded.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxExpanded.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxExpanded.Name = "pictureBoxExpanded";
            this.pictureBoxExpanded.Size = new System.Drawing.Size(600, 417);
            this.pictureBoxExpanded.TabIndex = 0;
            this.pictureBoxExpanded.TabStop = false;
            // 
            // ExpandedImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.pictureBoxExpanded);
            this.Name = "ExpandedImageForm";
            this.Text = "ExpandedImageForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpanded)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxExpanded;
    }
}