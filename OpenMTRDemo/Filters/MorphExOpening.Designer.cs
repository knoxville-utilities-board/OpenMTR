namespace OpenMTRDemo.Filters
{
    partial class MorphExOpening
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
            this.horizontalTrackBar.Location = new System.Drawing.Point(6, 22);
            this.horizontalTrackBar.Name = "horizontalTrackBar";
            this.horizontalTrackBar.Size = new System.Drawing.Size(207, 45);
            this.horizontalTrackBar.TabIndex = 3;
            this.horizontalTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.horizontalTrackBar.ValueChanged += new System.EventHandler(this.Render);
            // 
            // verticalTrackBar
            // 
            this.verticalTrackBar.Location = new System.Drawing.Point(6, 48);
            this.verticalTrackBar.Name = "verticalTrackBar";
            this.verticalTrackBar.Size = new System.Drawing.Size(207, 45);
            this.verticalTrackBar.TabIndex = 4;
            this.verticalTrackBar.ValueChanged += new System.EventHandler(this.Render);
            // 
            // MorphExOpening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.verticalTrackBar);
            this.Controls.Add(this.horizontalTrackBar);
            this.Name = "MorphExOpening";
            this.Size = new System.Drawing.Size(216, 81);
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
