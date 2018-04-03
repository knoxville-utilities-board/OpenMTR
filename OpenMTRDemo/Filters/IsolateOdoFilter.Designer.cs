namespace OpenMTRDemo.Filters
{
    partial class IsolateOdoFilter
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
            this.thresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.thresholdNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.isolateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // thresholdTrackBar
            // 
            this.thresholdTrackBar.LargeChange = 100;
            this.thresholdTrackBar.Location = new System.Drawing.Point(6, 22);
            this.thresholdTrackBar.Maximum = 10000;
            this.thresholdTrackBar.Name = "thresholdTrackBar";
            this.thresholdTrackBar.Size = new System.Drawing.Size(135, 45);
            this.thresholdTrackBar.TabIndex = 3;
            this.thresholdTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.thresholdTrackBar.Value = 300;
            this.thresholdTrackBar.ValueChanged += new System.EventHandler(this.threshold_ValueChanged);
            // 
            // thresholdNumeric
            // 
            this.thresholdNumeric.DecimalPlaces = 2;
            this.thresholdNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.thresholdNumeric.Location = new System.Drawing.Point(147, 22);
            this.thresholdNumeric.Name = "thresholdNumeric";
            this.thresholdNumeric.Size = new System.Drawing.Size(66, 20);
            this.thresholdNumeric.TabIndex = 4;
            this.thresholdNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.thresholdNumeric.ValueChanged += new System.EventHandler(this.threshold_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Isolated image size % of primary image";
            // 
            // isolateButton
            // 
            this.isolateButton.Location = new System.Drawing.Point(157, 60);
            this.isolateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.isolateButton.Name = "isolateButton";
            this.isolateButton.Size = new System.Drawing.Size(56, 19);
            this.isolateButton.TabIndex = 6;
            this.isolateButton.Text = "Isolate";
            this.isolateButton.UseVisualStyleBackColor = true;
            this.isolateButton.Click += new System.EventHandler(this.isolateButton_Click);
            // 
            // IsolateFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.isolateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thresholdNumeric);
            this.Controls.Add(this.thresholdTrackBar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(220, 122);
            this.MinimumSize = new System.Drawing.Size(220, 25);
            this.Name = "IsolateFilter";
            this.Size = new System.Drawing.Size(216, 84);
            this.Controls.SetChildIndex(this.thresholdTrackBar, 0);
            this.Controls.SetChildIndex(this.thresholdNumeric, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.isolateButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar thresholdTrackBar;
        private System.Windows.Forms.NumericUpDown thresholdNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button isolateButton;
    }
}
