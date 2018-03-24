namespace OpenMTRDemo.Filters
{
    partial class AffineFilter
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
            this.horizontalTrackBar = new System.Windows.Forms.TrackBar();
            this.verticalTrackBar = new System.Windows.Forms.TrackBar();
            this.horizontalNumeric = new System.Windows.Forms.NumericUpDown();
            this.verticalNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.angleNumeric = new System.Windows.Forms.NumericUpDown();
            this.angleTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // horizontalTrackBar
            // 
            this.horizontalTrackBar.Location = new System.Drawing.Point(6, 22);
            this.horizontalTrackBar.Maximum = 100;
            this.horizontalTrackBar.Minimum = -100;
            this.horizontalTrackBar.Name = "horizontalTrackBar";
            this.horizontalTrackBar.Size = new System.Drawing.Size(137, 45);
            this.horizontalTrackBar.TabIndex = 3;
            this.horizontalTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.horizontalTrackBar.ValueChanged += new System.EventHandler(this.transform_ValueChanged);
            // 
            // verticalTrackBar
            // 
            this.verticalTrackBar.Location = new System.Drawing.Point(6, 48);
            this.verticalTrackBar.Maximum = 100;
            this.verticalTrackBar.Minimum = -100;
            this.verticalTrackBar.Name = "verticalTrackBar";
            this.verticalTrackBar.Size = new System.Drawing.Size(137, 45);
            this.verticalTrackBar.TabIndex = 4;
            this.verticalTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.verticalTrackBar.ValueChanged += new System.EventHandler(this.transform_ValueChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "R";
            // 
            // angleNumeric
            // 
            this.angleNumeric.Location = new System.Drawing.Point(149, 73);
            this.angleNumeric.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.angleNumeric.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.angleNumeric.Name = "angleNumeric";
            this.angleNumeric.Size = new System.Drawing.Size(42, 20);
            this.angleNumeric.TabIndex = 12;
            this.angleNumeric.ValueChanged += new System.EventHandler(this.transform_ValueChanged);
            // 
            // angleTrackBar
            // 
            this.angleTrackBar.Location = new System.Drawing.Point(6, 73);
            this.angleTrackBar.Maximum = 180;
            this.angleTrackBar.Minimum = -180;
            this.angleTrackBar.Name = "angleTrackBar";
            this.angleTrackBar.Size = new System.Drawing.Size(137, 45);
            this.angleTrackBar.TabIndex = 11;
            this.angleTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.angleTrackBar.ValueChanged += new System.EventHandler(this.transform_ValueChanged);
            // 
            // ShearFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.angleNumeric);
            this.Controls.Add(this.angleTrackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verticalNumeric);
            this.Controls.Add(this.horizontalNumeric);
            this.Controls.Add(this.verticalTrackBar);
            this.Controls.Add(this.horizontalTrackBar);
            this.MaximumSize = new System.Drawing.Size(220, 150);
            this.Name = "ShearFilter";
            this.Size = new System.Drawing.Size(216, 101);
            this.Controls.SetChildIndex(this.horizontalTrackBar, 0);
            this.Controls.SetChildIndex(this.verticalTrackBar, 0);
            this.Controls.SetChildIndex(this.horizontalNumeric, 0);
            this.Controls.SetChildIndex(this.verticalNumeric, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.angleTrackBar, 0);
            this.Controls.SetChildIndex(this.angleNumeric, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.horizontalTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar horizontalTrackBar;
        private System.Windows.Forms.TrackBar verticalTrackBar;
        private System.Windows.Forms.NumericUpDown horizontalNumeric;
        private System.Windows.Forms.NumericUpDown verticalNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown angleNumeric;
        private System.Windows.Forms.TrackBar angleTrackBar;
    }
}
