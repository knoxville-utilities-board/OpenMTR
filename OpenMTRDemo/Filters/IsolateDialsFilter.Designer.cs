namespace OpenMTRDemo.Filters
{
    partial class IsolateDialsFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.isolateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isolateButton
            // 
            this.isolateButton.AutoSize = true;
            this.isolateButton.Location = new System.Drawing.Point(165, 20);
            this.isolateButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.isolateButton.Name = "isolateButton";
            this.isolateButton.Size = new System.Drawing.Size(48, 23);
            this.isolateButton.TabIndex = 7;
            this.isolateButton.Text = "Isolate";
            this.isolateButton.UseVisualStyleBackColor = true;
            this.isolateButton.Click += new System.EventHandler(this.isolateButton_Click);
            // 
            // IsolateDialsFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.isolateButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(247, 124);
            this.MinimumSize = new System.Drawing.Size(17, 21);
            this.Name = "IsolateDialsFilter";
            this.Size = new System.Drawing.Size(216, 48);
            this.Controls.SetChildIndex(this.isolateButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button isolateButton;
    }
}
