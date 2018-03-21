namespace OpenMTRDemo.Filters
{
    partial class PerspectiveFilter
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
            this.horizontalPerspectiveTrackBar = new System.Windows.Forms.TrackBar();
            this.verticalPerspectiveTrackBar = new System.Windows.Forms.TrackBar();
            this.horizontalNumeric = new System.Windows.Forms.NumericUpDown();
            this.verticalNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPerspectiveTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPerspectiveTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // horizontalPerspectiveTrackBar
            // 
            this.horizontalPerspectiveTrackBar.Location = new System.Drawing.Point(6, 22);
            this.horizontalPerspectiveTrackBar.Maximum = 100;
            this.horizontalPerspectiveTrackBar.Minimum = -100;
            this.horizontalPerspectiveTrackBar.Name = "horizontalPerspectiveTrackBar";
            this.horizontalPerspectiveTrackBar.Size = new System.Drawing.Size(137, 45);
            this.horizontalPerspectiveTrackBar.TabIndex = 3;
            this.horizontalPerspectiveTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.horizontalPerspectiveTrackBar.ValueChanged += new System.EventHandler(this.transform_ValueChanged);
            // 
            // verticalPerspectiveTrackBar
            // 
            this.verticalPerspectiveTrackBar.Location = new System.Drawing.Point(6, 48);
            this.verticalPerspectiveTrackBar.Maximum = 100;
            this.verticalPerspectiveTrackBar.Minimum = -100;
            this.verticalPerspectiveTrackBar.Name = "verticalPerspectiveTrackBar";
            this.verticalPerspectiveTrackBar.Size = new System.Drawing.Size(137, 45);
            this.verticalPerspectiveTrackBar.TabIndex = 4;
            this.verticalPerspectiveTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.verticalPerspectiveTrackBar.ValueChanged += new System.EventHandler(this.transform_ValueChanged);
            // 
            // horizontalNumeric
            // 
            this.horizontalNumeric.Location = new System.Drawing.Point(149, 22);
            this.horizontalNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.horizontalNumeric.Name = "horizontalNumeric";
            this.horizontalNumeric.Size = new System.Drawing.Size(42, 20);
            this.horizontalNumeric.TabIndex = 6;
            this.horizontalNumeric.ValueChanged += new System.EventHandler(this.transform_ValueChanged);
            // 
            // verticalNumeric
            // 
            this.verticalNumeric.Location = new System.Drawing.Point(149, 48);
            this.verticalNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.verticalNumeric.Name = "verticalNumeric";
            this.verticalNumeric.Size = new System.Drawing.Size(42, 20);
            this.verticalNumeric.TabIndex = 7;
            this.verticalNumeric.ValueChanged += new System.EventHandler(this.transform_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "V";
            // 
            // TransformFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verticalNumeric);
            this.Controls.Add(this.horizontalNumeric);
            this.Controls.Add(this.verticalPerspectiveTrackBar);
            this.Controls.Add(this.horizontalPerspectiveTrackBar);
            this.MaximumSize = new System.Drawing.Size(220, 150);
            this.Name = "TransformFilter";
            this.Size = new System.Drawing.Size(216, 78);
            this.Controls.SetChildIndex(this.horizontalPerspectiveTrackBar, 0);
            this.Controls.SetChildIndex(this.verticalPerspectiveTrackBar, 0);
            this.Controls.SetChildIndex(this.horizontalNumeric, 0);
            this.Controls.SetChildIndex(this.verticalNumeric, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPerspectiveTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPerspectiveTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar horizontalPerspectiveTrackBar;
        private System.Windows.Forms.TrackBar verticalPerspectiveTrackBar;
        private System.Windows.Forms.NumericUpDown horizontalNumeric;
        private System.Windows.Forms.NumericUpDown verticalNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
