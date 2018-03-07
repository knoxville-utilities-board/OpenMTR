namespace OpenMTRDemo.Filters
{
    partial class LaplacianFilter
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
            this.kSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deltaTrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kSizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // kSizeTrackBar
            // 
            this.kSizeTrackBar.Location = new System.Drawing.Point(6, 22);
            this.kSizeTrackBar.Maximum = 4;
            this.kSizeTrackBar.Name = "kSizeTrackBar";
            this.kSizeTrackBar.Size = new System.Drawing.Size(123, 45);
            this.kSizeTrackBar.TabIndex = 3;
            this.kSizeTrackBar.Value = 1;
            this.kSizeTrackBar.Scroll += new System.EventHandler(this.parametersChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kernel Size";
            // 
            // deltaTrackBar
            // 
            this.deltaTrackBar.Location = new System.Drawing.Point(6, 59);
            this.deltaTrackBar.Maximum = 5;
            this.deltaTrackBar.Minimum = 1;
            this.deltaTrackBar.Name = "deltaTrackBar";
            this.deltaTrackBar.Size = new System.Drawing.Size(123, 45);
            this.deltaTrackBar.TabIndex = 8;
            this.deltaTrackBar.Value = 1;
            this.deltaTrackBar.ValueChanged += new System.EventHandler(this.parametersChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Delta";
            // 
            // LaplacianFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deltaTrackBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kSizeTrackBar);
            this.Name = "LaplacianFilter";
            this.Size = new System.Drawing.Size(216, 96);
            this.Controls.SetChildIndex(this.kSizeTrackBar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.deltaTrackBar, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.kSizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar kSizeTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar deltaTrackBar;
        private System.Windows.Forms.Label label5;
    }
}
