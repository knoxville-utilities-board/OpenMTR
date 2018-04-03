namespace OpenMTRDemo.Forms
{
    partial class TiledFiltersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiledFiltersForm));
            this.pictureBoxSource = new System.Windows.Forms.PictureBox();
            this.pictureBoxIsolated = new System.Windows.Forms.PictureBox();
            this.dialsBox = new System.Windows.Forms.Panel();
            this.pictureBoxDial4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDial3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDial2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDial1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIsolated)).BeginInit();
            this.dialsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDial4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDial3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDial2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDial1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSource
            // 
            this.pictureBoxSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxSource.Location = new System.Drawing.Point(12, 51);
            this.pictureBoxSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSource.Name = "pictureBoxSource";
            this.pictureBoxSource.Size = new System.Drawing.Size(310, 310);
            this.pictureBoxSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSource.TabIndex = 5;
            this.pictureBoxSource.TabStop = false;
            this.pictureBoxSource.DoubleClick += new System.EventHandler(this.Pane_DblClickHandler);
            // 
            // pictureBoxIsolated
            // 
            this.pictureBoxIsolated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxIsolated.Location = new System.Drawing.Point(327, 51);
            this.pictureBoxIsolated.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxIsolated.Name = "pictureBoxIsolated";
            this.pictureBoxIsolated.Size = new System.Drawing.Size(310, 310);
            this.pictureBoxIsolated.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIsolated.TabIndex = 7;
            this.pictureBoxIsolated.TabStop = false;
            this.pictureBoxIsolated.DoubleClick += new System.EventHandler(this.Pane_DblClickHandler);
            // 
            // dialsBox
            // 
            this.dialsBox.Controls.Add(this.pictureBoxDial4);
            this.dialsBox.Controls.Add(this.pictureBoxDial3);
            this.dialsBox.Controls.Add(this.pictureBoxDial2);
            this.dialsBox.Controls.Add(this.pictureBoxDial1);
            this.dialsBox.Enabled = false;
            this.dialsBox.Location = new System.Drawing.Point(329, 53);
            this.dialsBox.Margin = new System.Windows.Forms.Padding(0);
            this.dialsBox.Name = "dialsBox";
            this.dialsBox.Size = new System.Drawing.Size(306, 306);
            this.dialsBox.TabIndex = 12;
            this.dialsBox.Visible = false;
            // 
            // pictureBoxDial4
            // 
            this.pictureBoxDial4.Location = new System.Drawing.Point(153, 153);
            this.pictureBoxDial4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDial4.Name = "pictureBoxDial4";
            this.pictureBoxDial4.Size = new System.Drawing.Size(153, 153);
            this.pictureBoxDial4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDial4.TabIndex = 3;
            this.pictureBoxDial4.TabStop = false;
            this.pictureBoxDial4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Pane_DblClickHandler);
            // 
            // pictureBoxDial3
            // 
            this.pictureBoxDial3.Location = new System.Drawing.Point(0, 153);
            this.pictureBoxDial3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDial3.Name = "pictureBoxDial3";
            this.pictureBoxDial3.Size = new System.Drawing.Size(153, 153);
            this.pictureBoxDial3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDial3.TabIndex = 2;
            this.pictureBoxDial3.TabStop = false;
            this.pictureBoxDial3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Pane_DblClickHandler);
            // 
            // pictureBoxDial2
            // 
            this.pictureBoxDial2.Location = new System.Drawing.Point(153, 0);
            this.pictureBoxDial2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDial2.Name = "pictureBoxDial2";
            this.pictureBoxDial2.Size = new System.Drawing.Size(153, 153);
            this.pictureBoxDial2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDial2.TabIndex = 1;
            this.pictureBoxDial2.TabStop = false;
            this.pictureBoxDial2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Pane_DblClickHandler);
            // 
            // pictureBoxDial1
            // 
            this.pictureBoxDial1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDial1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDial1.Name = "pictureBoxDial1";
            this.pictureBoxDial1.Size = new System.Drawing.Size(153, 153);
            this.pictureBoxDial1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDial1.TabIndex = 0;
            this.pictureBoxDial1.TabStop = false;
            this.pictureBoxDial1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Pane_DblClickHandler);
            // 
            // TiledFiltersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(650, 378);
            this.Controls.Add(this.dialsBox);
            this.Controls.Add(this.pictureBoxIsolated);
            this.Controls.Add(this.pictureBoxSource);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TiledFiltersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenMTR Demo";
            this.Controls.SetChildIndex(this.pictureBoxSource, 0);
            this.Controls.SetChildIndex(this.pictureBoxIsolated, 0);
            this.Controls.SetChildIndex(this.dialsBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIsolated)).EndInit();
            this.dialsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDial4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDial3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDial2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDial1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxSource;
        private System.Windows.Forms.PictureBox pictureBoxIsolated;
        private System.Windows.Forms.Panel dialsBox;
        private System.Windows.Forms.PictureBox pictureBoxDial4;
        private System.Windows.Forms.PictureBox pictureBoxDial3;
        private System.Windows.Forms.PictureBox pictureBoxDial2;
        private System.Windows.Forms.PictureBox pictureBoxDial1;
    }
}