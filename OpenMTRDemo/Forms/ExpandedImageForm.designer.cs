namespace OpenMTRDemo.Forms
{
    partial class ExpandedImageForm
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
            this.OutputImageBox = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.blurBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gaussianVerticalSlider = new System.Windows.Forms.TrackBar();
            this.gaussianHorizontalSlider = new System.Windows.Forms.TrackBar();
            this.edgeFindingBox = new System.Windows.Forms.GroupBox();
            this.cannySettingsPanel = new System.Windows.Forms.Panel();
            this.CannyThreshold2Slider = new System.Windows.Forms.TrackBar();
            this.CannyThreshold1Slider = new System.Windows.Forms.TrackBar();
            this.CannyThreshold1Number = new System.Windows.Forms.NumericUpDown();
            this.CannyThreshold2Number = new System.Windows.Forms.NumericUpDown();
            this.sobelRadio = new System.Windows.Forms.RadioButton();
            this.cannyRadio = new System.Windows.Forms.RadioButton();
            this.FilterListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImageBox)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.blurBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianVerticalSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianHorizontalSlider)).BeginInit();
            this.edgeFindingBox.SuspendLayout();
            this.cannySettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold2Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold1Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold1Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold2Number)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputImageBox
            // 
            this.OutputImageBox.Location = new System.Drawing.Point(0, 24);
            this.OutputImageBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OutputImageBox.Name = "OutputImageBox";
            this.OutputImageBox.Size = new System.Drawing.Size(588, 441);
            this.OutputImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OutputImageBox.TabIndex = 1;
            this.OutputImageBox.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.HeightTextBox);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.WidthTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(248, 370);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Properties";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BackColor = System.Drawing.Color.White;
            this.HeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HeightTextBox.Location = new System.Drawing.Point(52, 27);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.ReadOnly = true;
            this.HeightTextBox.Size = new System.Drawing.Size(125, 13);
            this.HeightTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width:";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.BackColor = System.Drawing.Color.White;
            this.WidthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WidthTextBox.Location = new System.Drawing.Point(52, 14);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.ReadOnly = true;
            this.WidthTextBox.Size = new System.Drawing.Size(125, 13);
            this.WidthTextBox.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.blurBox);
            this.tabPage1.Controls.Add(this.edgeFindingBox);
            this.tabPage1.Controls.Add(this.FilterListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(248, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // blurBox
            // 
            this.blurBox.Controls.Add(this.label5);
            this.blurBox.Controls.Add(this.label4);
            this.blurBox.Controls.Add(this.label3);
            this.blurBox.Controls.Add(this.gaussianVerticalSlider);
            this.blurBox.Controls.Add(this.gaussianHorizontalSlider);
            this.blurBox.Enabled = false;
            this.blurBox.Location = new System.Drawing.Point(5, 194);
            this.blurBox.Name = "blurBox";
            this.blurBox.Size = new System.Drawing.Size(238, 94);
            this.blurBox.TabIndex = 8;
            this.blurBox.TabStop = false;
            this.blurBox.Text = "Gaussian Blur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "3";
            // 
            // gaussianVerticalSlider
            // 
            this.gaussianVerticalSlider.BackColor = System.Drawing.Color.White;
            this.gaussianVerticalSlider.LargeChange = 2;
            this.gaussianVerticalSlider.Location = new System.Drawing.Point(34, 13);
            this.gaussianVerticalSlider.Maximum = 3;
            this.gaussianVerticalSlider.Minimum = 1;
            this.gaussianVerticalSlider.Name = "gaussianVerticalSlider";
            this.gaussianVerticalSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.gaussianVerticalSlider.Size = new System.Drawing.Size(45, 75);
            this.gaussianVerticalSlider.TabIndex = 3;
            this.gaussianVerticalSlider.TickFrequency = 2;
            this.gaussianVerticalSlider.Value = 1;
            this.gaussianVerticalSlider.Scroll += new System.EventHandler(this.Render);
            // 
            // gaussianHorizontalSlider
            // 
            this.gaussianHorizontalSlider.BackColor = System.Drawing.Color.White;
            this.gaussianHorizontalSlider.LargeChange = 2;
            this.gaussianHorizontalSlider.Location = new System.Drawing.Point(6, 13);
            this.gaussianHorizontalSlider.Maximum = 3;
            this.gaussianHorizontalSlider.Minimum = 1;
            this.gaussianHorizontalSlider.Name = "gaussianHorizontalSlider";
            this.gaussianHorizontalSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.gaussianHorizontalSlider.Size = new System.Drawing.Size(45, 75);
            this.gaussianHorizontalSlider.TabIndex = 3;
            this.gaussianHorizontalSlider.TickFrequency = 2;
            this.gaussianHorizontalSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.gaussianHorizontalSlider.Value = 1;
            this.gaussianHorizontalSlider.Scroll += new System.EventHandler(this.Render);
            // 
            // edgeFindingBox
            // 
            this.edgeFindingBox.Controls.Add(this.cannySettingsPanel);
            this.edgeFindingBox.Controls.Add(this.sobelRadio);
            this.edgeFindingBox.Controls.Add(this.cannyRadio);
            this.edgeFindingBox.Enabled = false;
            this.edgeFindingBox.Location = new System.Drawing.Point(5, 67);
            this.edgeFindingBox.Name = "edgeFindingBox";
            this.edgeFindingBox.Size = new System.Drawing.Size(238, 121);
            this.edgeFindingBox.TabIndex = 2;
            this.edgeFindingBox.TabStop = false;
            this.edgeFindingBox.Text = "Edge Finding";
            // 
            // cannySettingsPanel
            // 
            this.cannySettingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.cannySettingsPanel.Controls.Add(this.CannyThreshold2Slider);
            this.cannySettingsPanel.Controls.Add(this.CannyThreshold1Slider);
            this.cannySettingsPanel.Controls.Add(this.CannyThreshold1Number);
            this.cannySettingsPanel.Controls.Add(this.CannyThreshold2Number);
            this.cannySettingsPanel.Location = new System.Drawing.Point(1, 40);
            this.cannySettingsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cannySettingsPanel.Name = "cannySettingsPanel";
            this.cannySettingsPanel.Size = new System.Drawing.Size(237, 76);
            this.cannySettingsPanel.TabIndex = 3;
            // 
            // CannyThreshold2Slider
            // 
            this.CannyThreshold2Slider.BackColor = System.Drawing.Color.White;
            this.CannyThreshold2Slider.LargeChange = 50;
            this.CannyThreshold2Slider.Location = new System.Drawing.Point(3, 29);
            this.CannyThreshold2Slider.Maximum = 255;
            this.CannyThreshold2Slider.Name = "CannyThreshold2Slider";
            this.CannyThreshold2Slider.Size = new System.Drawing.Size(183, 45);
            this.CannyThreshold2Slider.TabIndex = 5;
            this.CannyThreshold2Slider.TickFrequency = 17;
            this.CannyThreshold2Slider.Value = 150;
            this.CannyThreshold2Slider.Scroll += new System.EventHandler(this.cannyThreshold_ValueChanged);
            // 
            // CannyThreshold1Slider
            // 
            this.CannyThreshold1Slider.BackColor = System.Drawing.Color.White;
            this.CannyThreshold1Slider.LargeChange = 50;
            this.CannyThreshold1Slider.Location = new System.Drawing.Point(3, 3);
            this.CannyThreshold1Slider.Maximum = 255;
            this.CannyThreshold1Slider.Name = "CannyThreshold1Slider";
            this.CannyThreshold1Slider.Size = new System.Drawing.Size(183, 45);
            this.CannyThreshold1Slider.TabIndex = 4;
            this.CannyThreshold1Slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.CannyThreshold1Slider.Value = 100;
            this.CannyThreshold1Slider.Scroll += new System.EventHandler(this.cannyThreshold_ValueChanged);
            // 
            // CannyThreshold1Number
            // 
            this.CannyThreshold1Number.Location = new System.Drawing.Point(192, 3);
            this.CannyThreshold1Number.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.CannyThreshold1Number.Name = "CannyThreshold1Number";
            this.CannyThreshold1Number.Size = new System.Drawing.Size(42, 20);
            this.CannyThreshold1Number.TabIndex = 1;
            this.CannyThreshold1Number.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.CannyThreshold1Number.ValueChanged += new System.EventHandler(this.cannyThreshold_ValueChanged);
            // 
            // CannyThreshold2Number
            // 
            this.CannyThreshold2Number.Location = new System.Drawing.Point(192, 29);
            this.CannyThreshold2Number.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.CannyThreshold2Number.Name = "CannyThreshold2Number";
            this.CannyThreshold2Number.Size = new System.Drawing.Size(42, 20);
            this.CannyThreshold2Number.TabIndex = 3;
            this.CannyThreshold2Number.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.CannyThreshold2Number.ValueChanged += new System.EventHandler(this.cannyThreshold_ValueChanged);
            // 
            // sobelRadio
            // 
            this.sobelRadio.AutoSize = true;
            this.sobelRadio.Location = new System.Drawing.Point(62, 18);
            this.sobelRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sobelRadio.Name = "sobelRadio";
            this.sobelRadio.Size = new System.Drawing.Size(52, 17);
            this.sobelRadio.TabIndex = 7;
            this.sobelRadio.Text = "Sobel";
            this.sobelRadio.UseVisualStyleBackColor = true;
            // 
            // cannyRadio
            // 
            this.cannyRadio.AutoSize = true;
            this.cannyRadio.Checked = true;
            this.cannyRadio.Location = new System.Drawing.Point(6, 18);
            this.cannyRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cannyRadio.Name = "cannyRadio";
            this.cannyRadio.Size = new System.Drawing.Size(55, 17);
            this.cannyRadio.TabIndex = 6;
            this.cannyRadio.TabStop = true;
            this.cannyRadio.Text = "Canny";
            this.cannyRadio.UseVisualStyleBackColor = true;
            this.cannyRadio.CheckedChanged += new System.EventHandler(this.cannyRadio_CheckedChanged);
            // 
            // FilterListBox
            // 
            this.FilterListBox.FormattingEnabled = true;
            this.FilterListBox.Items.AddRange(new object[] {
            "Gaussian Blur",
            "Black and White",
            "Edge Finding"});
            this.FilterListBox.Location = new System.Drawing.Point(5, 5);
            this.FilterListBox.Name = "FilterListBox";
            this.FilterListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.FilterListBox.Size = new System.Drawing.Size(238, 56);
            this.FilterListBox.TabIndex = 0;
            this.FilterListBox.SelectedIndexChanged += new System.EventHandler(this.filterListBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(592, 26);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(256, 396);
            this.tabControl1.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(688, 429);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(76, 28);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(769, 429);
            this.okButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(76, 28);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ExpandedImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 465);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.OutputImageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ExpandedImageForm";
            this.Text = "OpenMTR Demo";
            this.Load += new System.EventHandler(this.ExpandedImageForm_Load);
            this.Controls.SetChildIndex(this.OutputImageBox, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.okButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.OutputImageBox)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.blurBox.ResumeLayout(false);
            this.blurBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianVerticalSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianHorizontalSlider)).EndInit();
            this.edgeFindingBox.ResumeLayout(false);
            this.edgeFindingBox.PerformLayout();
            this.cannySettingsPanel.ResumeLayout(false);
            this.cannySettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold2Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold1Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold1Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold2Number)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox OutputImageBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox edgeFindingBox;
        private System.Windows.Forms.TrackBar CannyThreshold2Slider;
        private System.Windows.Forms.TrackBar CannyThreshold1Slider;
        private System.Windows.Forms.NumericUpDown CannyThreshold2Number;
        private System.Windows.Forms.NumericUpDown CannyThreshold1Number;
        private System.Windows.Forms.ListBox FilterListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.RadioButton sobelRadio;
        private System.Windows.Forms.RadioButton cannyRadio;
        private System.Windows.Forms.Panel cannySettingsPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox blurBox;
        private System.Windows.Forms.TrackBar gaussianVerticalSlider;
        private System.Windows.Forms.TrackBar gaussianHorizontalSlider;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

