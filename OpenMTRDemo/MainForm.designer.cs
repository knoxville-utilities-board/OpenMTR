namespace OpenMTRDemo
{
    partial class MainForm
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
            this.InputImageBox = new System.Windows.Forms.PictureBox();
            this.OutputImageBox = new System.Windows.Forms.PictureBox();
            this.metaDataLabel = new System.Windows.Forms.Label();
            this.MetaDataTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            ((System.ComponentModel.ISupportInitialize)(this.InputImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImageBox)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.edgeFindingBox.SuspendLayout();
            this.cannySettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold2Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold1Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold1Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold2Number)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputImageBox
            // 
            this.InputImageBox.Location = new System.Drawing.Point(9, 25);
            this.InputImageBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InputImageBox.Name = "InputImageBox";
            this.InputImageBox.Size = new System.Drawing.Size(240, 195);
            this.InputImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InputImageBox.TabIndex = 0;
            this.InputImageBox.TabStop = false;
            // 
            // OutputImageBox
            // 
            this.OutputImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputImageBox.Location = new System.Drawing.Point(9, 259);
            this.OutputImageBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OutputImageBox.Name = "OutputImageBox";
            this.OutputImageBox.Size = new System.Drawing.Size(501, 407);
            this.OutputImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OutputImageBox.TabIndex = 1;
            this.OutputImageBox.TabStop = false;
            // 
            // metaDataLabel
            // 
            this.metaDataLabel.AutoSize = true;
            this.metaDataLabel.Location = new System.Drawing.Point(11, 232);
            this.metaDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metaDataLabel.Name = "metaDataLabel";
            this.metaDataLabel.Size = new System.Drawing.Size(66, 13);
            this.metaDataLabel.TabIndex = 1;
            this.metaDataLabel.Text = "Meter Read:";
            // 
            // MetaDataTextBox
            // 
            this.MetaDataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MetaDataTextBox.Location = new System.Drawing.Point(78, 232);
            this.MetaDataTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MetaDataTextBox.Name = "MetaDataTextBox";
            this.MetaDataTextBox.ReadOnly = true;
            this.MetaDataTextBox.Size = new System.Drawing.Size(170, 13);
            this.MetaDataTextBox.TabIndex = 0;
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
            this.tabPage3.Size = new System.Drawing.Size(248, 195);
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
            this.tabPage1.Controls.Add(this.edgeFindingBox);
            this.tabPage1.Controls.Add(this.FilterListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(248, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filters";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.CannyThreshold2Slider.Scroll += new System.EventHandler(this.cannyThreshold2Slider_Scroll);
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
            this.CannyThreshold1Slider.Scroll += new System.EventHandler(this.cannyThreshold1Slider_Scroll);
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
            this.CannyThreshold1Number.ValueChanged += new System.EventHandler(this.cannyThreshold1Number_ValueChanged);
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
            this.CannyThreshold2Number.ValueChanged += new System.EventHandler(this.cannyThreshold2Number_ValueChanged);
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
            this.FilterListBox.Enabled = false;
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
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(254, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(256, 221);
            this.tabControl1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 675);
            this.Controls.Add(this.metaDataLabel);
            this.Controls.Add(this.MetaDataTextBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.OutputImageBox);
            this.Controls.Add(this.InputImageBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "OpenMTR Demo";
            ((System.ComponentModel.ISupportInitialize)(this.InputImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImageBox)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
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

        private System.Windows.Forms.PictureBox InputImageBox;
        private System.Windows.Forms.PictureBox OutputImageBox;
        private System.Windows.Forms.Label metaDataLabel;
        private System.Windows.Forms.TextBox MetaDataTextBox;
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
    }
}

