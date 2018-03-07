namespace OpenMTRDemo.Filters
{
    partial class BaseFilter
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
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Label();
            this.moveUpButton = new System.Windows.Forms.Label();
            this.moveDownButton = new System.Windows.Forms.Label();
            this.labelButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 3);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Filter";
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Location = new System.Drawing.Point(200, 3);
            this.removeButton.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(13, 13);
            this.removeButton.TabIndex = 0;
            this.removeButton.Text = "X";
            this.removeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelButtonToolTip.SetToolTip(this.removeButton, "Remove this filter");
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            this.removeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.removeButton.MouseEnter += new System.EventHandler(this.button_MouseHover);
            this.removeButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // moveUpButton
            // 
            this.moveUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveUpButton.Location = new System.Drawing.Point(170, 3);
            this.moveUpButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(13, 13);
            this.moveUpButton.TabIndex = 1;
            this.moveUpButton.Text = "˄";
            this.moveUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelButtonToolTip.SetToolTip(this.moveUpButton, "Load this filter earlier");
            this.moveUpButton.Click += new System.EventHandler(this.moveButton_Click);
            this.moveUpButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.moveUpButton.MouseEnter += new System.EventHandler(this.button_MouseHover);
            this.moveUpButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // moveDownButton
            // 
            this.moveDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveDownButton.Location = new System.Drawing.Point(185, 3);
            this.moveDownButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(13, 13);
            this.moveDownButton.TabIndex = 2;
            this.moveDownButton.Text = "˅";
            this.moveDownButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelButtonToolTip.SetToolTip(this.moveDownButton, "Load this filter later");
            this.moveDownButton.Click += new System.EventHandler(this.moveButton_Click);
            this.moveDownButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.moveDownButton.MouseEnter += new System.EventHandler(this.button_MouseHover);
            this.moveDownButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // BaseFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.moveDownButton);
            this.Controls.Add(this.moveUpButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.nameLabel);
            this.MaximumSize = new System.Drawing.Size(220, 100);
            this.MinimumSize = new System.Drawing.Size(220, 21);
            this.Name = "BaseFilter";
            this.Size = new System.Drawing.Size(216, 17);
            this.Load += new System.EventHandler(this.BaseFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label removeButton;
        private System.Windows.Forms.Label moveUpButton;
        private System.Windows.Forms.Label moveDownButton;
        private System.Windows.Forms.ToolTip labelButtonToolTip;
    }
}
