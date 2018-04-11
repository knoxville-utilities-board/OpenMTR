namespace OpenMTRDemo.Filters
{
    partial class DilateMorph
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
            ((System.ComponentModel.ISupportInitialize)(this.horizontalTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // horizontalTrackBar
            // 
            this.horizontalTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.horizontalTrackBar.Location = new System.Drawing.Point(7, 27);
            this.horizontalTrackBar.Name = "horizontalTrackBar";
            this.horizontalTrackBar.Size = new System.Drawing.Size(196, 56);
            this.horizontalTrackBar.TabIndex = 3;
            this.horizontalTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.horizontalTrackBar.Value = 1;
            this.horizontalTrackBar.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // verticalTrackBar
            // 
            this.verticalTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verticalTrackBar.Location = new System.Drawing.Point(7, 59);
            this.verticalTrackBar.Name = "verticalTrackBar";
            this.verticalTrackBar.Size = new System.Drawing.Size(196, 56);
            this.verticalTrackBar.TabIndex = 4;
            this.verticalTrackBar.Value = 1;
            this.verticalTrackBar.ValueChanged += new System.EventHandler(this.valueChanged);
            // 
            // DilateMorph
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.verticalTrackBar);
            this.Controls.Add(this.horizontalTrackBar);
            this.Name = "DilateMorph";
            this.Size = new System.Drawing.Size(288, 101);
            this.Controls.SetChildIndex(this.horizontalTrackBar, 0);
            this.Controls.SetChildIndex(this.verticalTrackBar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.horizontalTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar horizontalTrackBar;
        private System.Windows.Forms.TrackBar verticalTrackBar;
    }
}
