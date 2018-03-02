namespace OpenMTRDemo.Filters
{
    partial class CannyFilter
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
            this.thresholdTrackBar1 = new System.Windows.Forms.TrackBar();
            this.thresholdTrackBar2 = new System.Windows.Forms.TrackBar();
            this.thresholdNumber1 = new System.Windows.Forms.NumericUpDown();
            this.thresholdNumber2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // thresholdTrackBar1
            // 
            this.thresholdTrackBar1.LargeChange = 51;
            this.thresholdTrackBar1.Location = new System.Drawing.Point(3, 22);
            this.thresholdTrackBar1.Maximum = 255;
            this.thresholdTrackBar1.Name = "thresholdTrackBar1";
            this.thresholdTrackBar1.Size = new System.Drawing.Size(159, 45);
            this.thresholdTrackBar1.SmallChange = 17;
            this.thresholdTrackBar1.TabIndex = 3;
            this.thresholdTrackBar1.TickFrequency = 51;
            this.thresholdTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.thresholdTrackBar1.Value = 85;
            this.thresholdTrackBar1.ValueChanged += new System.EventHandler(this.threshold_ValueChanged);
            // 
            // thresholdTrackBar2
            // 
            this.thresholdTrackBar2.LargeChange = 51;
            this.thresholdTrackBar2.Location = new System.Drawing.Point(3, 43);
            this.thresholdTrackBar2.Maximum = 255;
            this.thresholdTrackBar2.Name = "thresholdTrackBar2";
            this.thresholdTrackBar2.Size = new System.Drawing.Size(159, 45);
            this.thresholdTrackBar2.SmallChange = 17;
            this.thresholdTrackBar2.TabIndex = 4;
            this.thresholdTrackBar2.TickFrequency = 51;
            this.thresholdTrackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.thresholdTrackBar2.Value = 170;
            this.thresholdTrackBar2.ValueChanged += new System.EventHandler(this.threshold_ValueChanged);
            // 
            // thresholdNumber1
            // 
            this.thresholdNumber1.Location = new System.Drawing.Point(168, 31);
            this.thresholdNumber1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.thresholdNumber1.Name = "thresholdNumber1";
            this.thresholdNumber1.Size = new System.Drawing.Size(47, 20);
            this.thresholdNumber1.TabIndex = 5;
            this.thresholdNumber1.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            this.thresholdNumber1.ValueChanged += new System.EventHandler(this.threshold_ValueChanged);
            // 
            // thresholdNumber2
            // 
            this.thresholdNumber2.Location = new System.Drawing.Point(168, 57);
            this.thresholdNumber2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.thresholdNumber2.Name = "thresholdNumber2";
            this.thresholdNumber2.Size = new System.Drawing.Size(47, 20);
            this.thresholdNumber2.TabIndex = 6;
            this.thresholdNumber2.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            this.thresholdNumber2.ValueChanged += new System.EventHandler(this.threshold_ValueChanged);
            // 
            // CannyFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.thresholdNumber2);
            this.Controls.Add(this.thresholdNumber1);
            this.Controls.Add(this.thresholdTrackBar2);
            this.Controls.Add(this.thresholdTrackBar1);
            this.Name = "CannyFilter";
            this.Size = new System.Drawing.Size(218, 92);
            this.Controls.SetChildIndex(this.thresholdTrackBar1, 0);
            this.Controls.SetChildIndex(this.thresholdTrackBar2, 0);
            this.Controls.SetChildIndex(this.thresholdNumber1, 0);
            this.Controls.SetChildIndex(this.thresholdNumber2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar thresholdTrackBar1;
        private System.Windows.Forms.TrackBar thresholdTrackBar2;
        private System.Windows.Forms.NumericUpDown thresholdNumber1;
        private System.Windows.Forms.NumericUpDown thresholdNumber2;
    }
}
